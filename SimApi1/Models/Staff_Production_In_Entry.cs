using System.ComponentModel.DataAnnotations;

namespace SimApi1.Models
{
    public class Staff_Production_In_Entry
    {
        [Key]
        public Guid Gu_In_Entry_Id { get; set; }
        public int In_Entry_Id { get; set; }
        public int Staff_Id { get; set; }
        public string Prod_Mast_Id { get; set; }
        public string Prod_Name { get; set; }
        public DateTime Date { get; set; }
        public double Qty { get; set; }


    }
}
