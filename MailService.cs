using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoEncoderEvents
{
    public class MailService
    {
        public static void SendMail(object source, VideoEventArgs args)
        {
            Console.WriteLine($"Mail: Video {args.Video.Title} has been encoded");
        }
    }
}
