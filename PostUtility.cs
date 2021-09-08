using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace PA1
{
    public class PostUtility
    {
        public static void PrintAllPosts(List<Post> posts)
        {
            foreach(Post post in posts)
            {
                Console.WriteLine(post.ToString());
            }
        }

        public static List<Post> AddPosts() //add a new post to posts.txt file
        {
            List<Post> twitterPost = new List<Post>(); //new list
            StreamWriter inFile = null;

            try
            {
               inFile = new StreamWriter("posts.txt"); //open new file
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                return twitterPost;
            }

            Console.WriteLine("What is the post ID?"); //enter post id
            userInput1 = int.Parse(Console.ReadLine()); //store id as user input 1
            Console.WriteLine("What is the post content?"); //enter post content
            userInput2 = Console.ReadLine(); //store post into user input 2
            Console.WriteLine("What is the post date & time? EX. 06/09/2000/03:22PM"); //enter date and time
            userInput3 = int.Parse(Console.ReadLine()); //store date and time in user input 3
            twitterPost.Add(new Post()).Split("#") {postID = userInput1, Post=userInput2, Date = userInput3}; //add new post to the list and split

            inFile.Close(); //close file

            


        }


        public static List<Post> DeletePosts() //delete post from posts.txt
        {
            List<Post> twitterPost = new List<Post>(); //new list
            StreamReader inFile = null;    //new StreamReader("posts.txt");
            try
            {
                inFile = new StreamReader("posts.txt");
            }
            catch(Exception e)
            {
                Console.WriteLine("ERROR, {0}", e);
                return twitterPost;
            }

            Console.WriteLine("What is the ID of the post you want to delete?")? //enter post id
            userInput = int.Parse(Console.ReadLine()); //takes user input and turns into post id
            twitterPost.Contains(new Post {postID = userInput}); //checks if user input matches post id

            twitterPost.Remove(new Post() {postID = userInput}); //removes post with equal id number

            inFile.ReadLine(); //Update read

            inFile.Close(); //close file
        }
        
    }
}