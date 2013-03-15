using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace Cleeck.sockets
{
    enum TypeOfConnect
    {
        Mobile,  // 0
        HTTP  // 1
    }

    class HTTPConnector
    {

        #region Переменные

        private string _host;
        private uint _port;
        private TypeOfConnect _type;

        public string host
        {
            get { return _host; }
        }

        public uint port 
        {
            get { return _port; }
        }

        public TypeOfConnect type
        {
            get { return _type; }
        }

        #endregion

        #region Конструкторы

#if DEBUG
        //Конструктор по умолчанию (для отладки)
        public HTTPConnector()
        {
            _host = "90.188.1.11";
            _port = 35555;
            _type = TypeOfConnect.Mobile;
        }
#endif
        public HTTPConnector(string host, uint port)
        {
            _host = host;
            _port = port;
            _type = TypeOfConnect.Mobile;
        }

        public HTTPConnector(
                string host, 
                uint port, 
                TypeOfConnect type
            )
        {
            _host = host;
            _port = port;
            _type = type;
        }

        //копирование запрещено
        private HTTPConnector(HTTPConnector con){}

        #endregion

        public string request(){
            string uri = "/broker?region=1&type="+(int)type;
            WebRequest request = WebRequest.Create(
                "http://"+
                host + ":" +
                port +
                uri);
            request.Method = "GET";
            string result = "";
            try
            {
                WebResponse response = request.GetResponse();
                StreamReader sr = new StreamReader(response.GetResponseStream());
                result = sr.ReadToEnd();
            }
            catch (Exception e)
            {
#if DEBUG
                System.Windows.Forms.MessageBox.Show(e.ToString());
#else
                System.Windows.Forms.MessageBox.Show("Ошибка подключения к сокету");
#endif
            }
            return result;
        }
    }
}
