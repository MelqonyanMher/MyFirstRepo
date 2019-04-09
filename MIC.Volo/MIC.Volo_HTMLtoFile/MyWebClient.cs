using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Xml;

namespace MIC.Volo_HTMLtoFile
{
    class MyWebClient
    {
        public readonly WebClient web;

        public MyWebClient(string uri)
        {
            this.web = new WebClient();
            this.uri = new Uri(uri);
        }

        public Uri uri { get; private set; }

        public string Download()
        {
            return web.DownloadString(uri);
        }


    }
}
