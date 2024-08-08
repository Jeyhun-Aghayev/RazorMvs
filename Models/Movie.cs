using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Razor.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Display(Name = "Filim basligi")]
        public string? Title { get; set; }
        [Display(Name = "Yayimlanma Tarihi")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        [Display(Name = "Filmler ve Filimler girisi")]
        public string? Genre { get; set; }
        [Display(Name = "Can ay kasib")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
    }
}
