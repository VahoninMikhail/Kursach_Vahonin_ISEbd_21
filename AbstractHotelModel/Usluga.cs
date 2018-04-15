using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AbstractHotelModel
{
    public class Usluga
    {
        public int Id { get; set; }

        [Required]
        public string UslugaName { get; set; }

        [Required]
        public decimal Price { get; set; }

        [ForeignKey("UslugaId")]
        public virtual List<Zakaz> Zakazs { get; set; }
    }
}
