using System;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video("Video1");
            var encoder = new VideoEncoder();
            var mailinfo = new MailInformation();
            var textinfo = new TextInformation();

            encoder.EventHandler += mailinfo.OnVideoEncoded;
            encoder.EventHandler += textinfo.OnVideoEncoded;

            encoder.Encode(video);

            Console.ReadKey();
        }
    }
}
