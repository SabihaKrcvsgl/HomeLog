namespace HomeLog.Models
{
    public class Cihaz
    {
        public int CihazID { get; set; }
        public string CihazAdi { get; set; } = string.Empty;
        public string? Marka { get; set; }
        public string? Model { get; set; }
        public DateTime SatinAlmaTarihi { get; set; } = DateTime.Today;
        public int GarantiSuresiAy { get; set; }
        public string? Notlar { get; set; }

        public int KategoriID { get; set; }
        public Kategori? Kategori { get; set; }
        public List<BakimKaydi> BakimKayitlari { get; set; } = new();

        public DateTime GarantiBitisTarihi => SatinAlmaTarihi.AddMonths(GarantiSuresiAy);
        public bool GarantiDevamEdiyor => GarantiBitisTarihi >= DateTime.Today;
    }
}