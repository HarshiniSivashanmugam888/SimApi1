using System.ComponentModel.DataAnnotations;

namespace SimApi1.Models
{
    public class Product_Details
    {
        [Key]
        public Guid Gu_Prod_Details_Id { get; set; }
        public int Prod_Details_Id { get; set; }
        public string Prod_Name { get; set; }
        public int Comp_Details_Id { get; set; }
        public double Qty { get; set; }

    }
}
