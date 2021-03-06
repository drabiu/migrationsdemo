﻿using System.Data.Entity;

namespace MigrationsDemo
{
    public class Model
    {
        public class BlogContext : DbContext
        {
            public DbSet<Blog> Blogs { get; set; }
        }

        public class Blog
        {
            public int BlogId { get; set; }
            public string Name { get; set; }
            public string Url { get; set; }
        }
    }
}
