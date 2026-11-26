namespace HomeLog.Models
{
    public class BakimKaydi
    {
        public int BakimID { get; set; }

        public int CihazID { get; set; }
        public Cihaz? Cihaz { get; set; }

        public DateTime BakimTarihi { get; set; } = DateTime.Today;
        public string Aciklama { get; set; } = string.Empty;
        public decimal Ucret { get; set; }
    }
}