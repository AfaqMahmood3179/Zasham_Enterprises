using System.ComponentModel.DataAnnotations;

namespace Zasham_Enterprises.Model
{
    public class Product
    {
        [Key]
        public String productname { get; set; }
        public String productdescription { get; set; }
        public String productid { get; set; }
        public String productprice { get; set; }



    }
}
