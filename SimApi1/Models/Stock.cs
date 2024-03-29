using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace SimApi1.Models
{
    public class Stock
    {
        [Key]
        public Guid Gu_Stock_Id { get; set; }
        public int Stock_Id { get; set; }
        public int Comp_Details_Id { get; set; }
        public double Qty { get; set; }
        public string Box_unit { get; set; }
        public double Price { get; set; }
        public string Buyer {  get; set; }

    }
}
