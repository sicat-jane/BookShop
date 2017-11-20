using System.ComponentModel.DataAnnotations;

namespace BookShop.Models
{
    public class Book
    {
        [ScaffoldColumn(false)]
        public string ISBN { get; set; }

        [Required, StringLength(100), Display(Name = "Title")]
        public string BookTitle { get; set; }

        [Required, StringLength(100), Display(Name = "Author")]
        public string Author { get; set; }

        public string ImagePath { get; set; }

        [Display(Name = "Price")]
        public double? UnitPrice { get; set; }

        public int? CategoryID { get; set; }

        public virtual Category Category { get; set; }
    }
}