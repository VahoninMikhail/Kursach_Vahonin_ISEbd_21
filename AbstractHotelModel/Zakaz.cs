using System;

namespace AbstractHotelModel
{
    public class Zakaz
    {
        public int Id { get; set; }

        public int PosetitelId { get; set; }

        public int UslugaId { get; set; }

        public int? IspolnitelId { get; set; }

        public int Count { get; set; }

        public decimal Sum { get; set; }

        public ZakazStatus Status { get; set; }

        public DateTime DateCreate { get; set; }

        public DateTime? DateImplement { get; set; }
    }
}
