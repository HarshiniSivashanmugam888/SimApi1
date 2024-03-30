using System.ComponentModel.DataAnnotations;

namespace SimApi1.Models
{
    public class Staff_Master
    {
        [Key]
        public long Staff_Id { get; set; }
        public string Satff_Name { get; set; }
        public string Employee_Id { get; set; }
        public string Designation { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public List<Spares_Out_For_Production> spares_OutFor_Productions { get; set; }
        public List<Staff_Production_In_Entry> staff_Production_In_Entries { get; set; }
    }
}
