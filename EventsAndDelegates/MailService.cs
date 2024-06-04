using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    public class MailService
    {
        public void onVideoEncoded(object sender, VideoEventArgs args)
        {
            Console.WriteLine($"MailService: Sending an email...Video Title = {args.Video.Title}");
        }
    }
}
