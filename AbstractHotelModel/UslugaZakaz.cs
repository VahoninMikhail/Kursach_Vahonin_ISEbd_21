namespace AbstractHotelModel
{
    public class UslugaZakaz
    {
        public int Id { get; set; }

        public int UslugaId { get; set; }

        public int ZakazId { get; set; }

        public int Count { get; set; }

        public decimal Price { get; set; }

        public virtual Usluga Usluga { get; set; }

        public virtual Zakaz Zakaz { get; set; }
    }
}
