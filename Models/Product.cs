using ProductsAonExam.Models.DTOs;

namespace ProductsAonExam.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public double ProductPrice { get; set; }
        public string ProductCompany {  get; set; }
        public string ProductType { get; set; }

        public Product() { }
        public Product(int id, ProductInputDTO productInputDTO)
        {
            Id = id;
            ProductName = productInputDTO.ProductName;
            ProductDescription = productInputDTO.ProductDescription;
            ProductPrice = productInputDTO.ProductPrice;
            ProductCompany = productInputDTO.ProductCompany;
            ProductType = productInputDTO.ProductType;
        }
    }
}
