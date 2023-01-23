using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [StringLength(100)]
        public string FullName { get; set; }

        [StringLength(50)]
        public string StreetAddress { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        [StringLength(6)]
        public string PostalCode { get; set; }

        [StringLength(1)]
        public string Gender { get; set; }
      
    }
}
