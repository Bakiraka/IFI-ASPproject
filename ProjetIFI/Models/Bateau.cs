using System;
using System.ComponentModel;
using System.Data.Entity;

namespace MvcMovie.Models
{
    public class Bateau
    {
        public int ID { get; set; }
        public string Nom { get; set; }
        [DisplayName("Date de construction")]
        public DateTime DateConstruction { get; set; }
        [DisplayName("Type de bateau")]
        public string TypeBateau { get; set; }
        public decimal Prix { get; set; }
    }

    public class BateauxDBContext : DbContext
    {
        public DbSet<Bateau> Bateaux { get; set; }
    }
}