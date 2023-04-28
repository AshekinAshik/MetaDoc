using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class OrderDTO
    {
        public int Id { get; set; }
        [Required]
        public int OrderQuantity { get; set; } // Quantity of Selected Products
        [Required]
        public DateTime OrderDate { get; set; }
        [Required]
        public int TotalCost { get; set; }
        public int Product_Id { get; set; }
    }
}
