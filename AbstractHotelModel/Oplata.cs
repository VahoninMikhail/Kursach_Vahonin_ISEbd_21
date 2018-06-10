using System;

namespace AbstractHotelModel
{
    public class Oplata
    {
        public int Id { get; set; }

        public int ZakazId { get; set; }

        public DateTime DateCreate { get; set; }

        public decimal Summ { get; set; }

        public virtual Zakaz Zakaz { get; set; }
    }
}
