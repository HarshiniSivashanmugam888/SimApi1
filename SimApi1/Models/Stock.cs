using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography.X509Certificates;

namespace SimApi1.Models
{
    public class Stock
    {
        [Key]
        public long Stock_Id { get; set; }
        [ForeignKey("Component_Details")]
        public long Comp_Dtls_Id { get; set; }
        public double Qty { get; set; }
        public string Box_Unit { get; set; }
        public double Price { get; set; }
        public string Buyer_Name { get; set; }
        public Component_Details component_Details { get; set; }
       

    }
}
