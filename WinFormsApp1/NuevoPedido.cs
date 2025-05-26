using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Lib;
using WinFormsApp1.Modelo;

namespace WinFormsApp1
{
    public partial class NuevoPedido : Form
    {
        public PossMenu pm;
        public NuevoPedido(PossMenu possMenu)
        {
            InitializeComponent();
            pm = possMenu;
            new logs("NuevoPedido", false, 0);
        }

        public void valueSetter(string Table)
        {
            string lTable = "Mesa: " + Table;
            labelMesa.Text = lTable;
        }

        private void labelMesa_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            pm.Show();
            this.Close();
        }

        private void NuevoPedido_Load(object sender, EventArgs e)
        {

        }
    }
}
