using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace AbstractHotelModel
{
    public class Zakaz
    {
        public int Id { get; set; }

        public int PosetitelId { get; set; }

        public ZakazStatus ZakazStatus { get; set; }

        public DateTime DateCreate { get; set; }

        public DateTime DateImplement { get; set; }

        public virtual Posetitel Posetitel { get; set; }

        [ForeignKey("ZakazId")]
        public virtual List<Oplata> Oplats { get; set; }

        [ForeignKey("ZakazId")]
        public virtual List<UslugaZakaz> UslugaZakazs { get; set; }
    }
}
