using Fiddler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace iOS_Proxy
{
    public class FiddlerSession
    {
        public string client_ip { get; set; }
        public string url { get; set; }
        public string method { get; set; }
        public string requestContentType { get; set; }
        public string requestBody { get; set; }
        public string responseContentType { get; set; }
        public string responseBody { get; set; }

        public FiddlerSession(Session session)
        {
            client_ip = session.clientIP;
            url = session.url;
            method = session.RequestMethod;
            requestBody = session.GetRequestBodyAsString();
            responseBody = session.GetResponseBodyAsString();

            responseContentType = "";
            foreach (HTTPHeaderItem header in session.oResponse.headers)
            {
                if (header.Name == "Content-Type")
                    responseContentType += header.Value + "\n";
            }

            requestContentType = "";
            foreach (HTTPHeaderItem header in session.oRequest.headers)
            {
                if (header.Name == "Content-Type")
                    requestContentType += header.Value + "\n";
            }
        }
    }
}
