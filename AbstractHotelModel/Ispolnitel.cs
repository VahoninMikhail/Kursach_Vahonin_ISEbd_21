using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AbstractHotelModel
{
    public class Ispolnitel
    {
        public int Id { get; set; }

        [Required]
        public string IspolnitelFIO { get; set; }

        [ForeignKey("IspolnitelId")]
        public virtual List<Zakaz> Zakazs { get; set; }
    }
}
