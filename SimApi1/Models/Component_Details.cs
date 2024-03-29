using System.ComponentModel.DataAnnotations;

namespace SimApi1.Models
{
    public class Component_Details
    {
        [Key]
        public Guid Gu_Comp_Details_Id { get; set; }
        public int Comp_Details_Id { get; set; }
        public int Comp_Mast_Id { get; set; }
        public string Comp_Name { get; set; }
        public string Unit {  get; set; }
        public string Value { get; set; }
        public double Min_Qty { get; set; }

    }
}
