using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace PA1
{
    class PostFile
    {

        public static List<Post> GetPosts() 
        {
            List<Post> twitterPost = new List<Post>(); //create list
            StreamReader inFile = null;   
            try
            {
                inFile = new StreamReader("posts.txt"); //open file
            }
            catch(Exception e)
            {
                Console.WriteLine("ERROR, {0}", e);
                return twitterPost;
            }

            string line = inFile.ReadLine(); //priming read
            while(line!=null)
            {
                string[] temp = line.Split("#"); //split
                int alID = int.Parse(temp[0]);
                int date = int.Parse(temp[2])
                twitterPost.Add(new Post()) {postID = alID, Post=temp[1], Date = date}; 
                line = inFile.ReadLine(); //Update read
            }
            inFile.Close(); //close file

            return twitterPost;
        }




































        public static List<Posts> PopulateList(int postID, string p, int t)
        {
            try
            {
                StreamReader inFile = new StreamReader("posts.txt"); //open file
			    string fileInput = inFile.ReadLine();
                List<string> AlPost = new List<string>(); //turn array into list
			    while (fileInput != null)
			        {
				        inputList = fileInput.Split('#'); //split data file
                        AlPost.Add(new Post(){ID=int.Parse(inputList[0])}); //assign to ID
                        AlPost.Add(new Post(){p=(inputList[1])}); //assign to post
                        AlPost.Add(new Post(){t=int.Parse(inputList[2])}); //assign to timestamp
				        fileInput = inFile.ReadLine();
			        }
			
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
 
        }
    
    
    }
}