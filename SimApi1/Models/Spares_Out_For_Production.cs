using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimApi1.Models
{
    public class Spares_Out_For_Production
    {
        [Key]
        public long Out_Id { get; set; }
        [ForeignKey("Staff_Id")]
        public long Staff_Id { get; set; }
        [ForeignKey("Comp_Dtls_Id")]
        public long Comp_Dtls_Id { get; set; }
        public double Qty { get; set; }
        public DateTime Date { get; set; }
        public Staff_Master staff_master { get; set; }
        public Component_Details component_Details { get; set; }

        

    }
}
