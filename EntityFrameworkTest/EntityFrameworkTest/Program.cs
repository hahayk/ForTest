using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var vid = new Video
            {
                Title = "Hello Entity Framework",
                Description = "Description Entity Framework"
            };

            var meContext = new MeContext();
            meContext.Videos.Add(vid);
            meContext.SaveChanges();

            //meContext.Database.Delete();
        }
    }

    class Video
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }

    class MeContext : DbContext
    {
        public MeContext() : base(@"Data Source=compik;Initial Catalog=MyTestDb;Integrated Security=True") {}
        public DbSet<Video> Videos { get; set; }
    }
}
