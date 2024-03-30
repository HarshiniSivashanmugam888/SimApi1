using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimApi1.Models
{
    public class Staff_Production_In_Entry
    {
        [Key]
        public long Entry_Id { get; set; }
        [ForeignKey("Staff_Id")]
        public long Staff_Id { get; set; }
        [ForeignKey("Prod_Mast_Id")]
        public long Prod_Mast_Id { get; set; }
        public double Qty { get; set; }
        public DateTime Date { get; set; }
        public Staff_Master staff_Master { get; set; }
        public Product_Master product_Master { get; set; }
       


    }
}
