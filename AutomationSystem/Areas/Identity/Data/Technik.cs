using System.ComponentModel.DataAnnotations;

namespace AutomationSystem.Areas.Identity.Data
{
    public class Technik
    {
       
        public int Id {  get; set; }
        public string Type { get; set; }

        public string Brand { get; set; }

        public string Model { get; set; }

        public string Description { get; set; }
    }
}
