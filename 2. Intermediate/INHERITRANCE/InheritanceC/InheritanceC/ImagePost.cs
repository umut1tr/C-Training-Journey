using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceC
{
    // ImagePost derives from Post and adds a property ( ImageURL) and two constructors
    class ImagePost : Post
    {

        public string ImageURL { get; set; }

        public ImagePost() { }

        public ImagePost(string title, string sentByUsername, string imageURL, bool isPublic)
        {
            // the following properties and the GetNexID method are inherited from Post
            this.ID = GetNextID();
            this.Title = title;
            this.SentByUsername = sentByUsername;
            this.IsPublic = isPublic;

            // Property ImageURL is a member of ImagePost, but not of Post
            this.ImageURL = imageURL;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} - by {3}", this.ID, this.Title, this.ImageURL, this.SentByUsername);
        }

    }
}
