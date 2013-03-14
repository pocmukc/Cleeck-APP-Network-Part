using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace Cleeck.sockets
{
    class HTTPRequest
    {
        public static string connect(){
            string server = "90.188.1.11";
            string port = "35555";
            string uri = "/broker?region=1&type=0";
            WebRequest request = WebRequest.Create(
                "http://"+
                server + ":" +
                port +
                uri);
            request.Method = "GET";
            WebResponse response = request.GetResponse();
            StreamReader sr = new StreamReader(response.GetResponseStream());
            return sr.ReadToEnd();
        }
    }
}
