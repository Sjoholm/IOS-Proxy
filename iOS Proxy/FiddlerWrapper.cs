using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fiddler;
using System.Net.Security;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace iOS_Proxy
{
    class FiddlerWrapper
    {
        private Action<FiddlerSession> _callback;
        public string Filter { get; set; }
        private bool _quizKampenCheat = false;
        //private FiddlerCoreStartupFlags settings;
        public FiddlerWrapper(Action<FiddlerSession> callback, bool onlyRemote, bool quizKampenCheat)
        {
            _callback += callback;
            FiddlerApplication.BeforeRequest += OnBeforeRequest;
            FiddlerApplication.AfterSessionComplete += OnAfterSessionComplete;
            FiddlerApplication.OnValidateServerCertificate += new System.EventHandler<ValidateServerCertificateEventArgs>(ValidateCert);
            FiddlerApplication.OnNotification += (sender, oNEA) => Debug.WriteLine("** NotifyUser: " + oNEA.NotifyString);
            FiddlerApplication.Log.OnLogString += (sender, oLEA) => Debug.WriteLine("** LogString: " + oLEA.LogString);
            //settings = FiddlerCoreStartupFlags.Default;
            _quizKampenCheat = quizKampenCheat;
            Filter = "";
        }

        private void OnBeforeRequest(Session session)
        {
            if (session.clientIP.Contains("127.0.0.1"))
                return;
            
            string oldReqBody = session.GetRequestBodyAsString();
            if (_quizKampenCheat &&
                oldReqBody.Contains("game_update") &&
                oldReqBody.Contains("my_answers"))
            {
                string newReqBody = FixReqBody(oldReqBody);
                session.utilSetRequestBody(newReqBody);
            }
        }

        private string FixReqBody(string oldReqBody)
        {
            int pos1 = oldReqBody.IndexOf("my_answers");
            int pos2 = pos1 + "my_answers%22%3A%22".Length;
            pos1 = oldReqBody.IndexOf("%22", pos2);
            string oldAnswers = oldReqBody.Substring(pos2, pos1 - pos2);
            var reg = new Regex(@"[^0]");
            string newAnswers = reg.Replace(oldAnswers, "0");
            return oldReqBody.Replace("my_answers%22%3A%22" + oldAnswers + "%22", 
                                      "my_answers%22%3A%22" + newAnswers + "%22");
        }

        private void OnAfterSessionComplete(Session session)
        {
            if (session.clientIP.Contains("127.0.0.1"))
                return;

            if (!string.IsNullOrWhiteSpace(Filter) && !session.url.Contains(Filter))
                return;

            FiddlerSession fiddlerSession = new FiddlerSession(session);
            if (_callback != null)
                _callback(fiddlerSession);
        }

        private void ValidateCert(object sender, ValidateServerCertificateEventArgs e)
        {
            if (SslPolicyErrors.None == e.CertificatePolicyErrors)
                return;

            e.ValidityState = CertificateValidity.ForceValid;
        }

        public void Start()
        {
            if (!FiddlerApplication.IsStarted())
                FiddlerApplication.Startup(8888, true, true, true);
        }

        public void Stop()
        {
            if (FiddlerApplication.IsStarted())
                FiddlerApplication.Shutdown();
        }

        public void Dispose()
        {
            Stop();
        }
    }
}
