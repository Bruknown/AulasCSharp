using System;
using System.Collections.Generic;
using System.Text;

namespace AulaExercicio3.Entities
{
    class Post
    {
        public DateTime Date { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comments> Comments { get; set; }

        public Post(DateTime date, string title, string content)
        {
            Date = date;
            Title = title;
            Content = content;
            Likes = 0;
            Comments = new List<Comments>();
        }

        public override string ToString()
        {
            return "Date: "
                + Date
                + ", Title: "
                + Title
                + ", Content: "
                + Content
                + ", Likes: "
                + Likes;
                
        }
    }
}
