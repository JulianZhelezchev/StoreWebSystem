using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace StoreWebSystem.Models
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public byte[] ImageContent { get; set; }
        public string ImageMimeType { get; set; }

        public IFormFile ImageFile { get; set; }
        public CategoryDto Category { get; set; }
       
        public decimal BuyPrice { get; set; }
        public decimal SellPrice { get; set; }
        public int Quantity { get; set; }
        public int CategoryId { get; set; }
        public string ProductCode { get; set; }
    }
}
