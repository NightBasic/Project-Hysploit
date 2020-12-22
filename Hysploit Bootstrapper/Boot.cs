using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace Hysploit_Bootstrapper
{
    class Boot
    {
        static void Main(string[] args)
        {

            // Config
            String pname = "Hysploit";
            String dlink = "https://pastebin.com/raw/yBTfmpRS";
            string title = @"
 ▄ .▄ ▄· ▄▌.▄▄ ·  ▄▄▄·▄▄▌        ▪  ▄▄▄▄▄     ▄▄·  ▄ .▄▄▄▄ . ▄▄· ▄ •▄ ▪   ▐ ▄  ▄▄ •          
██▪▐█▐█▪██▌▐█ ▀. ▐█ ▄███•  ▪     ██ •██      ▐█ ▌▪██▪▐█▀▄.▀·▐█ ▌▪█▌▄▌▪██ •█▌▐█▐█ ▀ ▪         
██▀▐█▐█▌▐█▪▄▀▀▀█▄ ██▀·██▪   ▄█▀▄ ▐█· ▐█.▪    ██ ▄▄██▀▐█▐▀▀▪▄██ ▄▄▐▀▀▄·▐█·▐█▐▐▌▄█ ▀█▄         
██▌▐▀ ▐█▀·.▐█▄▪▐█▐█▪·•▐█▌▐▌▐█▌.▐▌▐█▌ ▐█▌·    ▐███▌██▌▐▀▐█▄▄▌▐███▌▐█.█▌▐█▌██▐█▌▐█▄▪▐█         
▀▀▀ ·  ▀ •  ▀▀▀▀ .▀   .▀▀▀  ▀█▄▀▪▀▀▀ ▀▀▀     ·▀▀▀ ▀▀▀ · ▀▀▀ ·▀▀▀ ·▀  ▀▀▀▀▀▀ █▪·▀▀▀▀  ▀  ▀  ▀ 
";
            // ---------- Do not touch here if you do not know ----------
            Console.Title = pname + " Bootstrapper";
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Downloading new Files...");
            WebClient wc = new WebClient();
            String key = wc.DownloadString(dlink);
            String path = @"Files\" + pname + ".zip";
            System.Net.WebClient Dow = new WebClient();
            String patch = (@"Files");
            Directory.CreateDirectory(patch);
            Dow.DownloadFile(key, path);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(pname + " Downloaded | Updated!");
            Console.WriteLine($"Now open " + patch + " and Run " + pname + ".zip");
            Console.ReadKey();
        }
    }
}
