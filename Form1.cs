using DevExpress.XtraEditors;
using HomeLog.Data;

namespace HomeLog
{
    public partial class Form1 : XtraForm
    {
        public Form1()
        {
            InitializeComponent();
            using var db = new HomeLogContext();
            db.Database.EnsureCreated();
        }
    }
}