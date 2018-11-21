using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Net.WebClient wc = new System.Net.WebClient();
            byte[] raw = wc.DownloadData("http://www.yoursite.com/resource/file.htm");

            string webData = System.Text.Encoding.UTF8.GetString(raw);
            fedgdgdgddddddddddddddddddddddddddddd



        }
    }
}
