using System.ComponentModel.DataAnnotations;

namespace SimApi1.Models
{
    public class Spares_Out_For_Production
    {
        [Key]
        public Guid Gu_Spares_Out_Id { get; set; }
        public int Spares_Out_Id { get; set; }
        public int Staff_Id { get; set; }
        public int Comp_Details_Id { get; set; }
        public double Qty { get; set; }
        public int Prod_Mast_Id {  get; set; }

    }
}
