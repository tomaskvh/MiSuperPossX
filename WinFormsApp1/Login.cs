using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Lib;
using WinFormsApp1.Lib.forms;
using WinFormsApp1.Modelo;

namespace WinFormsApp1
{
    public partial class Login : Form
    {
        internal numberPicket np = new numberPicket();
        internal loginUser loginUser;
        internal ModelUser modelUser;
        internal bool step1;
        internal bool conti = false;
        internal int ccode;
        public PossMenu pm;
        public Login(PossMenu pmm)
        {
            this.pm = pmm;
            InitializeComponent();
            this.pm.Hide();
            labelName.Text = "";
            step1 = false;
            new logs("Login Menu: Open", false, 0);
        }

        private void btnT1_Click(object sender, EventArgs e)
        {
            np.tableNumberSetter(true, 1, txtTableNo);
        }

        private void btnT2_Click(object sender, EventArgs e)
        {
            np.tableNumberSetter(true, 2, txtTableNo);
        }

        private void btnT3_Click(object sender, EventArgs e)
        {
            np.tableNumberSetter(true, 3, txtTableNo);
        }

        private void btnT4_Click(object sender, EventArgs e)
        {
            np.tableNumberSetter(true, 4, txtTableNo);
        }

        private void btnT5_Click(object sender, EventArgs e)
        {
            np.tableNumberSetter(true, 5, txtTableNo);
        }

        private void btnT6_Click(object sender, EventArgs e)
        {
            np.tableNumberSetter(true, 6, txtTableNo);
        }

        private void btnT7_Click(object sender, EventArgs e)
        {
            np.tableNumberSetter(true, 7, txtTableNo);
        }

        private void btnT8_Click(object sender, EventArgs e)
        {
            np.tableNumberSetter(true, 8, txtTableNo);
        }

        private void btnT9_Click(object sender, EventArgs e)
        {
            np.tableNumberSetter(true, 9, txtTableNo);
        }

        private void btnT0_Click(object sender, EventArgs e)
        {
            np.tableNumberSetter(true, 0, txtTableNo);
        }

        private void btnTD_Click(object sender, EventArgs e)
        {
            np.tableNumberSetter(false, 0, txtTableNo);
        }

        private void btnTE_Click(object sender, EventArgs e)
        {
            np.tableNumberSetter(false, 1, txtTableNo);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            loggin();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!conti)
            {
                new logs("LoginForm: Clossing Application", false, 3);
                this.pm.Close();
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void txtTableNo_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter) { loggin(); }
        }

        private void loggin()
        {
            int code;
            bool tr = int.TryParse(txtTableNo.Text, out code);
            if (!step1)
            {
                loginUser = new loginUser(code);
                bool ex = loginUser.userExists();

                if (!ex || !tr)
                {
                    MessageBox.Show("El usuario no exite",
                        "NO AUTORIZADO",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    this.pm.Close();
                }
                else
                {
                    step1 = true;
                    txtTableNo.Text = "";
                    modelUser = loginUser.userData();
                    labelName.Text = "Hola, " + modelUser.name;
                    labelPin.Text = "Digite su Pin de encargado(a):";
                }
            }
            else
            {
                new logs(modelUser.function.ToString(), false, 0);
              
                if (loginUser.autenticate(code, false) && modelUser.function == 1)
                {
                    this.conti = true;
                    LoginPossMenu lpm = new LoginPossMenu(this.pm);
                    lpm.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta o Usuario no habilitado para esta función.",
                        "NO AUTORIZADO",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    this.pm.Close();
                }
            }
        }
    }
}
