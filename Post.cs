using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace PA1
{
    public class Post : IComparable<Post>
    {
        public int postID {get; set;}

        public string Post {get; set;}

        public int Date {get; set;}

        public int CompareTo(Post temp)
        {
            return this.postID.CompareTo(temp.postID);
        }

        public static int CompareByDate(Post x, Post y)
        {
            return x.Date.CompareTo(y.Date);
        }

        public override string ToString() 
        {
            return this.postID +  this.Post + this.Date);
        }

    }
}