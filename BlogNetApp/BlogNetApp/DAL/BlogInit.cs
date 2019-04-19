using BlogNetApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace BlogNetApp.DAL
{
    public class BlogInit : System.Data.Entity.DropCreateDatabaseIfModelChanges<BlogContext>
    {
        protected override void Seed(BlogContext context)
        {
            var users = new List<User>
            {
            new User{Username="Use1",Password="qwerty",Registerdate=DateTime.Parse("2004-09-01")},
             new User{Username="Use2",Password="qwerty1",Registerdate=DateTime.Parse("2005-09-01")},
              new User{Username="Use3",Password="qwerty2",Registerdate=DateTime.Parse("2002-09-01")},
               new User{Username="Use4",Password="qwerty3",Registerdate=DateTime.Parse("2001-09-01")},
                new User{Username="User5",Password="qwerty4",Registerdate=DateTime.Parse("2005-09-01")},

            };

            users.ForEach(s => context.Users.Add(s));
            context.SaveChanges();
            var categories = new List<Category>
            {
            new Category{CategoryID=100,CategoryName="Default"},
            new Category{CategoryID=101,CategoryName="Books"},
            new Category{CategoryID=102,CategoryName="Special"},
            };
            categories.ForEach(s => context.Categories.Add(s));
            context.SaveChanges();
            var posts = new List<Post>
            {
            new Post{UserID=1,CategoryID=100,Title="About me",Description="None",Tag=Tag.Random},
             new Post{UserID=2,CategoryID=101,Title="About me",Description="None",Tag=Tag.Random},
              new Post{UserID=3,CategoryID=102,Title="About me",Description="None",Tag=Tag.Random},
               new Post{UserID=4,CategoryID=100,Title="About me",Description="None",Tag=Tag.Random},
               new Post{UserID=5,CategoryID=102,Title="About me",Description="None",Tag=Tag.Random},

            };
            posts.ForEach(s => context.Posts.Add(s));
            context.SaveChanges();
        }
    }
}