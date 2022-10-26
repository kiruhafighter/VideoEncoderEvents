using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoEncoderEvents
{
    public class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { Title = "RoP s.2 ep.1"};
            var videoEncoder = new VideoEncoder();
            videoEncoder.VideoEncoded += MailService.SendMail;
            videoEncoder.VideoEncoded += FBService.Notify;
            videoEncoder.Encoding(video);

        }
    }
}
