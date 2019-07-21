using System;

namespace Events
{
    class TextInformation
    {
        public void OnVideoEncoded(object obj, VideoEventArgs args)
        {
            Console.WriteLine("Sending text message..." + args.Video.Title);
        }
    }
}