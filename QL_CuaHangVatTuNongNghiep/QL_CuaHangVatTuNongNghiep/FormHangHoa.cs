using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_CuaHangVatTuNongNghiep
{
    public partial class FormHangHoa : Form
    {
        public FormHangHoa()
        {
            InitializeComponent();
        }
        Modify modify = new Modify();
        private void FormHangHoa_Load(object sender, EventArgs e)
        {
            dgvHangHoa.DataSource = modify.DataTable("SELECT * FROM HangHoa");
        }
    }
}
