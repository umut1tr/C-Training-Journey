using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InheritanceC
{
    class VideoPost : Post
    {
        // member fields
        protected bool isPlaying = false;
        protected int currDuration = 0;
        Timer timer;

        // Properties
        protected string VideoURL { get; set; }
        protected int Length { get; set; }
        

        public VideoPost() { }

        public VideoPost(string title, string sentByUsername, string videoURL, bool isPublic, int length)
        {
            // the following properties and the GetNexID method are inherited from Post
            this.ID = GetNextID();
            this.Title = title;
            this.SentByUsername = sentByUsername;
            this.IsPublic = isPublic;
            

            // Property ImageURL is a member of ImagePost, but not of Post
            this.VideoURL = videoURL;
            this.Length = length;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} - {3} seconds long - by {4}", this.ID, this.Title, this.VideoURL, this.Length, this.SentByUsername);
        }

        public void Play()
        {
            if (!isPlaying)
            {
                isPlaying = true;
                Console.WriteLine("Playing");
                timer = new Timer(TimerCallback, null, 0, 1000);
            }
            
            
            

        }

        public void Stop()
        {
            if (isPlaying)
            {
                isPlaying = false;
                Console.WriteLine("Video Stopped at {0} seconds", currDuration);
                currDuration = 0;
                timer.Dispose();
            }
        }

        private void TimerCallback(Object o)
        {
            if(currDuration < Length)
            {
                currDuration++;
                Console.WriteLine("Video at {0} seconds", currDuration);
                GC.Collect();
            }
            else
            {
                Stop();
            }
                        
        }
    }
}
