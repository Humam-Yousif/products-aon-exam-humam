using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace ProductsAonExam.Models.DTOs
{
    public class ProductInputDTO
    {
        [Required]
        public string ProductName { get; set; }
        [AllowNull]
        public string ProductDescription { get; set; }
        [Required]
        public double ProductPrice { get; set; }
        [Required]
        public string ProductCompany { get; set; }
        [Required]
        public string ProductType { get; set; }
    }
}
