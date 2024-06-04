using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    public class VideoEncoder
    {
        // we want an event in this class to notify the user that the video is finnish 
        // Three steps we need to follow:

        // 1 - define a delegate, contract between the publisher and the subscriper
        //public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);

        // 2 - define an event based on that delegate, notice it is in the past tens something that happend and finnish
        //public event VideoEncodedEventHandler VideoEncoded;

        // 1 and 2 you can make them simply as here
        //Instead of writing two lines of code here we could simply write
        //EventHandler (withot sending data) or EventHandler<TEventArgs> (sending some data) like 
        public event EventHandler<VideoEventArgs> VideoEncoded;

        public void Encode(Video vedio)
        {
            Console.WriteLine("Encoding vedio...");
            Thread.Sleep(3000);
            OnVideoEncoded(vedio);
        }

        // 3 - Raise the event
        // This method is responsable to notify the subscripers that something happends
        protected virtual void OnVideoEncoded(Video video) 
        {
            if(VideoEncoded != null) 
            {
                VideoEncoded(this, new VideoEventArgs() { Video = video});
            }

        }
    }
}
