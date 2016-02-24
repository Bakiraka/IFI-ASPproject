using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace ProjetIFI.Models
{
    public class Bateaux
    {
        public int ID { get; set; }
        public string Title { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }
        public string Type { get; set; }
        public decimal Price { get; set; }
    }

    public class MovieDBContext : DbContext
    {
        public DbSet<Bateaux> Bateaux { get; set; }
    }
}