using System;
using System.Threading;

namespace Events
{
    class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }

        public VideoEventArgs(Video vid)
        {
            this.Video = vid;
        }
    }
    class VideoEncoder
    {
        public delegate void VideoEncoderEventHandler(object obj, VideoEventArgs args);

        public event VideoEncoderEventHandler EventHandler;
    
        public void Encode(Video video)
        {
            Console.WriteLine("Encoding a video...");
            Thread.Sleep(3000);

            OnVideoEncoded(video);
        }

        public void OnVideoEncoded(Video video)
        {
            EventHandler?.Invoke(this, new VideoEventArgs(video));
        }
    }
}