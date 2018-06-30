using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWork_DataFirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //connect to ADO.NET EF
            var db = new DatabaseFirstDemoEntities();
            //create post
            var post = new Post()
            {
                Body = "body",
                DatePublished = DateTime.Now,
                Title = "title",
                PostID = 1
            };
            db.Posts.Add(post);
            db.SaveChanges();
        }
    }
}
