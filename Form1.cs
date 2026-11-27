using DevExpress.XtraEditors;
using HomeLog.Data;
using Microsoft.EntityFrameworkCore;

namespace HomeLog
{
    public partial class Form1 : XtraForm
    {
        private readonly HomeLogContext db = new();

        public Form1()
        {
            InitializeComponent();
            db.Database.EnsureCreated();
            db.Cihazlar.Load();
            gridControl1.DataSource = db.Cihazlar.Local.ToBindingList();

            
            var v = gridView1;
            v.Columns["CihazID"].Visible = false;
            v.Columns["KategoriID"].Visible = false;
            v.Columns["Kategori"].Visible = false;

            v.Columns["CihazAdi"].Caption = "Cihaz Adı";
            v.Columns["SatinAlmaTarihi"].Caption = "Satın Alma";
            v.Columns["GarantiSuresiAy"].Caption = "Garanti (Ay)";
            v.Columns["GarantiBitisTarihi"].Caption = "Garanti Bitiş";
            v.Columns["GarantiDevamEdiyor"].Caption = "Garanti Sürüyor mu?";

            v.OptionsBehavior.Editable = false;
            v.BestFitColumns();

        }
    }
}