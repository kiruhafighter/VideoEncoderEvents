using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace VideoEncoderEvents
{
    public class VideoEncoder
    {
        public event EventHandler<VideoEventArgs> VideoEncoded;
        public void Encoding(Video video)
        {
            Console.WriteLine("Encoding started");
            Thread.Sleep(1000);
            Console.WriteLine("Please, wait");
            Thread.Sleep(1500);
            Console.WriteLine("Loading...");
            OnVideoEncoded(video);
            Console.WriteLine("Video has been encoded successfully");
        }

        private void OnVideoEncoded(Video video)
        {
            VideoEncoded?.Invoke(this, new VideoEventArgs() { Video = video });
        }
    }
}
