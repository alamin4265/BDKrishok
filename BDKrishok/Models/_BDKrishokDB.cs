using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.DynamicData;

namespace Models
{
    public class _BDKrishokDB:DbContext
    {
        public _BDKrishokDB():base("BDKrishokDB")
        {

        }
        public DbSet<Country> Country { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Image> Image { get; set; }
        public DbSet<Video> Video { get; set; }
        public DbSet<FeedType> FeedType { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<Shop> Shop { get; set; }
        public DbSet<Feed> Feed { get; set; }
        public DbSet<MedicineType> MedicineType { get; set; }
        public DbSet<Medicine> Medicine { get; set; }
        public DbSet<Disease> Disease { get; set; }
    }
}