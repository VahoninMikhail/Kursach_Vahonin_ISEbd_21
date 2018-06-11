using System.ComponentModel.DataAnnotations;

namespace AbstractHotelModel
{
    public class Administrator
    {
        public int Id { get; set; }

        [Required]
        public string AdminFIO { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string Zaschita { get; set; }
    }
}
