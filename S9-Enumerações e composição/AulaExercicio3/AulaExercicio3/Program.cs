using AulaExercicio3.Entities;
using System;

namespace AulaExercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Post post;
            Console.WriteLine("Welcome to twitter :) post somehting yes? ");
            Console.WriteLine("Post title: ");
            string title = Console.ReadLine();
            Console.WriteLine("Post content: ");
            string content = Console.ReadLine();
            post = new Post(DateTime.Now, title, content);
            bool isRunning = true;
            while (isRunning)
            {
                int commentcount = 1;
                Comments comment = new Comments();
                Console.WriteLine(post);
                Console.WriteLine("COMMENTS: ");
                Console.WriteLine("=========================");
                if (post.Comments.Count > 0)
                {
                    foreach (Comments comm in post.Comments)
                    {
                        Console.WriteLine("Comment " + commentcount++ + ": " + comm.Comment);
                    }
                }
                Console.WriteLine("=========================");

                Console.WriteLine("Comment: 1, Like: 2");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Post a comment: ");
                        comment.Comment = Console.ReadLine();
                        post.Comments.Add(comment);
                        break;
                    case 2:
                        post.Likes++;
                        break;
                }
            }
        }
    }
}
