using System.ComponentModel.DataAnnotations;

namespace SimApi1.Models
{
    public class Component_Master
    {
        [Key]
        public long Comp_Mast_Id { get; set; }
        public string Comp_Name { get; set; }
        public string Unit { get; set; }
        public string Value { get; set; }
        public double Min_Qty { get; set; }
        public List<Component_Details> component_Details { get; set; }
        public List<Stock> stocks { get; set; }
       

    }
}
