using System.ComponentModel.DataAnnotations;

namespace SimApi1.Models
{
    public class Product_Master
    {
        [Key]
        public Guid Gu_Prod_Mast_Id { get; set; }
        public int Prod_Mast_Id { get; set; }
        public string Prod_Mast_Name { get; set; }
     
    }
}
