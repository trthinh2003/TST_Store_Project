﻿using System;
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
    public partial class FormXacNhanXoaNhanVien : Form
    {
        public FormXacNhanXoaNhanVien()
        {
            InitializeComponent();
        }

        private void btnCo_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnKhong_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
