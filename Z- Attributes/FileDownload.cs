using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z__Attributes
{
    public static class FileDownload
    {
        [Obsolete("Cette méthode est obsolète, utilisez DownloadAndInstall à la place.")]
        public static void Download()
        {
            Console.WriteLine("Download");
        }

        [Obsolete("Cette méthode est obsolète, utilisez DownloadAndInstall à la place.")]
        public static void Install()
        {
            Console.WriteLine("Install");
        }

        
        public static void DownloadAndInstall()
        {
            Console.WriteLine("Download & Install");
        }

    }
}
