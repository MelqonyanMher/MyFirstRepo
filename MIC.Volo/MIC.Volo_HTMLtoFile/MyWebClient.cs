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

        public void DownloadInFile(string adress)
        {
            string s = this.Download();
            StreamWriter writer = new StreamWriter(adress, true, System.Text.Encoding.Default);
            Console.WriteLine(" ||||||||||||||||||||");
            int j = 1;
            for (int i = 0; i < s.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                if (i < s.Length / 20 * j)
                {
                    writer.Write(s[i]);
                }
                else
                {
                    writer.Write(s[i]);
                    Console.SetCursorPosition(j, 0);
                    Console.Write("|");
                    Console.SetCursorPosition(10, 1);
                    Console.WriteLine($"{(i * 100 / s.Length + 1)}%");
                    j++;
                }

            }
            Console.ResetColor();
            Console.WriteLine();
            writer.Dispose();
        }
    }
}
