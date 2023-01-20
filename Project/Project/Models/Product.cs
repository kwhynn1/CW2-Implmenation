using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class Product
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string ProductName { get; set; }
        [StringLength(100)]
        public string ProductDescription { get; set; }
        public string Category { get; set; }

        [Range(1,100)]
        public decimal Price { get; set; }
        [StringLength(100)]
        public string ImageName { get; set; }
    }
}
