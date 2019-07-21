using System;

namespace Events
{
    class MailInformation
    {
        public void OnVideoEncoded(object obj, VideoEventArgs args)
        {
            Console.WriteLine("Sending mail..." + args.Video.Title);
        }
    }
}