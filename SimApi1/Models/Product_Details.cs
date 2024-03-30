using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimApi1.Models
{
    public class Product_Details
    {
        [Key]
        public long Prod_Dtls_id { get; set; }
        [ForeignKey("Product_Master")]
        public long Prod_Mast_Id { get; set; }

        public string Prod_Name { get; set; }
        [ForeignKey("Componet_Details")]
        public long Comp_Dtls_Id { get; set; }
        public double Qty { get; set; }
        public Product_Master product_Master { get; set; }
        public Component_Details component_Details { get; set; }
       

    }
}
