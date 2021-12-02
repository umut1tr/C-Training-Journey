using System;

namespace InheritanceC
{
    class Program
    {
        static void Main(string[] args)
        {
            Post post1 = new Post("Thanks for the Birthday wishes", true, "Umut Türk");

            ImagePost imagePost1 = new ImagePost("Check out my new shoes", "Umut Türk", "https://images.com/shoes", true);

            VideoPost videoPost1 = new VideoPost("FailVideo", "Umut Türk", "https://videos.com/crazy", true, 120);

            
            Console.WriteLine(post1.ToString());
            Console.WriteLine(imagePost1.ToString());
            Console.WriteLine(videoPost1.ToString());

            videoPost1.Play();
            Console.WriteLine("Press any key to stop the Video");
            Console.ReadKey();
            videoPost1.Stop();
            Console.ReadLine();


        }
    }
}
