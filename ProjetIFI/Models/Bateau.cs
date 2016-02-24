using System;
using System.Data.Entity;

namespace MvcMovie.Models
{
    public class Bateau
    {
        public int ID { get; set; }
        public string Nom { get; set; }
        public DateTime DateConstruction { get; set; }
        public string TypeBateau { get; set; }
        public decimal Prix { get; set; }
        public string ImagePath { get; set; }
    }

    public class BateauxDBContext : DbContext
    {
        public DbSet<Bateau> Bateaux { get; set; }
    }
}