using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using WinFormsApp1.Lib;


namespace WinFormsApp1.Modelo
{

    public partial class PossMenu : Form
    {
        public bool login = false;
        internal ModelUser loggedUser;
        public string du;
        public PossMenu()
        {
            InitializeComponent();
            new logs("PM: OPEN", false, 0);
            Login l = new Login(this);
            l.Show();
            dateUpdate();

            timerReloj.Interval = 1000;
            timerReloj.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dateUpdate();
        }

        private void dateUpdate()
        {
            DateTime hoy = DateTime.Now;
            string update;
            update = "Fecha: " + hoy.ToString("dd/mm/yyyy") + " Hora: " + hoy.ToString("HH:mm:ss");
            du = update;

            labelDate.Text = update;
            if (!login) this.Hide();
        }

        public void logged()
        {
            getUser();
            login = true;
        }

        private void tableNumberSetter(bool Adding, int number)
        {
            string txt = txtTableNo.Text;

            if (Adding)
            {
                txt = txt + number.ToString();
            }
            else
            {
                if (number == 0)
                {
                    if (txt.Length == 0) return;
                    txt = txtTableNo.Text.Substring(0, txtTableNo.Text.Length - 1);
                }
                else
                {
                    txt = "";
                }
            }

            txtTableNo.Text = txt;
        }

        private void labelDate_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtTableNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            tableNumberSetter(true, 4);
        }

        private void btnT1_Click(object sender, EventArgs e)
        {
            tableNumberSetter(true, 1);
        }

        private void btnT2_Click(object sender, EventArgs e)
        {
            tableNumberSetter(true, 2);
        }

        private void btnT3_Click(object sender, EventArgs e)
        {
            tableNumberSetter(true, 3);
        }

        private void btnT5_Click(object sender, EventArgs e)
        {
            tableNumberSetter(true, 5);
        }

        private void btnT6_Click(object sender, EventArgs e)
        {
            tableNumberSetter(true, 6);
        }

        private void btnT7_Click(object sender, EventArgs e)
        {
            tableNumberSetter(true, 7);
        }

        private void btnT8_Click(object sender, EventArgs e)
        {
            tableNumberSetter(true, 8);
        }

        private void btnT9_Click(object sender, EventArgs e)
        {
            tableNumberSetter(true, 9);
        }

        private void btnT0_Click(object sender, EventArgs e)
        {
            tableNumberSetter(true, 0);
        }

        private void btnTD_Click(object sender, EventArgs e)
        {
            tableNumberSetter(false, 0);
        }

        private void btnTE_Click(object sender, EventArgs e)
        {
            tableNumberSetter(false, 1);
        }

        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            NuevoPedido nuevoPedido = new NuevoPedido(this);
            string table = txtTableNo.Text;
            bool v = table.IndexOf(" ") == -1;
            if (!v || table == "")
            {
                new logs("Se intento abrir crear un pedido sin seleccionar una mesa", false, 0);
                MessageBox.Show("No se ha marcado ningun numero de mesa",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            this.Hide();
            nuevoPedido.Show();
            nuevoPedido.valueSetter(txtTableNo.Text);
        }
        private void getUser()
        {
            new logs("PM: Get user", false, 0);
            loginUser lu = new loginUser(0);
            lu.getCurrentLoggedUsersCodes();
        }
        private void updateLabels()
        {

        }

        private void labelManager_Click(object sender, EventArgs e)
        {

        }
    }
}
