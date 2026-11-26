namespace HomeLog.Models
{
    public class Kategori
    {
        public int KategoriID { get; set; }
        public string KategoriAdi { get; set; } = string.Empty;
        public List<Cihaz> Cihazlar { get; set; } = new();
    }
}