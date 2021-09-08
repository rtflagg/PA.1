using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace PA1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<Post> twitterPost = PostFile.GetPosts();


        
            

            Console.WriteLine("1. Display Posts\n2. Add a Post\n3. Delete Post\n4. Exit"); //menu 
             string input= Console.ReadLine();
 
                switch(input)
                {
                    case "1": //ALL GOOD
                    twitterPost.Sort(Post.CompareByDate);

                    Console.WriteLine("");
                    Console.WriteLine("Sorted by date and time");
                    PostUtility.PrintAllPosts(twitterPost);
                    break;
        
                    case "2":
                    PostUtility.AddPosts(twitterPost);
                    Console.WriteLine("Post added to file");
                    break;
 
                    case "3":
                    PostUtility.DeletePosts(twitterPost);
                    Console.WriteLine("The post has been deleted");
                    break;
 
                    case "4":
                    Environment.Exit(0); //exit program
                    break;
 
                    default:
                    Console.WriteLine("Invalid choice, please try again!"); 
                    break;
                }

        }
    
    } 
}

