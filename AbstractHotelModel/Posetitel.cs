using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AbstractHotelModel
{
    public class Posetitel
    {
        public int Id { get; set; }

        [Required]
        public string PosetitelFIO { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string Zaschita { get; set; }

        public int Bonuses { get; set; }

        public bool Active { get; set; }

        [ForeignKey("PosetitelId")]
        public virtual List<Zakaz> Zakazs { get; set; }
    }
}
