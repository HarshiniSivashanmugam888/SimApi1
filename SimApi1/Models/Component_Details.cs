using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimApi1.Models
{
    public class Component_Details
    {

        [Key]
        public long Comp_Dtls_Id { get; set; }

        [ForeignKey("Component_Master")]
        public long Comp_Mast_Id { get; set; }
        public string Comp_Name { get; set; }
        public string Unit { get; set; }
        public string Value { get; set; }
        public Component_Master Component_Master { get; set; }
        public List<Product_Details> product_Details { get; set; }
        public List<Spares_Out_For_Production> spares_OutFor_Productions { get; set; }
        public List<Stock> stocks { get; set; }
       

    }
}
