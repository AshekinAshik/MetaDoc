using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int OrderQuantity { get; set; } // i mean koyta product select korse ar ki
        [Required]
        public DateTime OrderDate { get; set; }
        [Required]
        public int TotalCost { get; set; }
        [ForeignKey("Product")]
        public int Product_Id { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
