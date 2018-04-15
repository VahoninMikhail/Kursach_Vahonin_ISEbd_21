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

        [ForeignKey("PosetitelId")]
        public virtual List<Zakaz> Zakazs { get; set; }
    }
}
