using System;

namespace MIC.Volo_HTMLtoFile
{
    class Program
    {
        static void Main(string[] args)
        {
            MyWebClient my = new MyWebClient("Http://facebook.com");
           my.DownloadInFile(@"C:\Users\Melqonyan\Desktop\my.txt");
        }
    }
}
