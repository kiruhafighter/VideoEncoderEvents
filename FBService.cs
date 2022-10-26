using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoEncoderEvents
{
    public class FBService
    {
        public static void Notify(object source , VideoEventArgs args)
        {
            Console.WriteLine($"Facebook notification: Video {args.Video.Title} has been encoded");
        }
    }
}
