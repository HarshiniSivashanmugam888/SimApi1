using System.ComponentModel.DataAnnotations;

namespace SimApi1.Models
{
    public class Product_Master
    {
        [Key]
        public long Prod_Mast_Id { get; set; }
        public string Prod_Name { get; set; }
        public List<Product_Details> product_Details { get; set; }
        public List<Staff_Production_In_Entry> staff_Production_In_Entries { get; set; }
       
     
    }
}
