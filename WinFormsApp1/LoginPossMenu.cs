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
using static System.Net.Mime.MediaTypeNames;

namespace WinFormsApp1
{
    public partial class LoginPossMenu : Form
    {
        public PossMenu pm;
        internal numberPicket np = new numberPicket();
        internal int mangerCode;
        internal ModelUser manager;
        public LoginPossMenu(PossMenu pmm)
        {
            InitializeComponent();
            this.pm = pmm;

            keyBord();
            timerReloj.Interval = 1000;
            timerReloj.Start();

            getAutenticatedUserCode();
            updateUserData();

            new logs("LPM: OP OK", false, 0);
        }

        private void getAutenticatedUserCode()
        {
            loginUser loginUser = new loginUser(0);
            string[] lu = loginUser.getCurrentLoggedUsersCodes();

            mangerCode = int.Parse(lu[0]);
        }

        private void updateUserData()
        {
            loginUser loginUser = new loginUser(mangerCode);
            manager = loginUser.userData();

            labelMesero.Text = "Encargado(a): " + manager.name;
            labelManager.Text = "Codigo encargado(a): " + mangerCode.ToString();
            labelManagerHelllo.Text = "Hola, " + manager.name;

        }

        private void keyBord()
        {
            btnT0.Click += (s, e) => np.tableNumberSetter(true, 0, txtTableNo);
            btnT1.Click += (s, e) => np.tableNumberSetter(true, 1, txtTableNo);
            btnT2.Click += (s, e) => np.tableNumberSetter(true, 2, txtTableNo);
            btnT3.Click += (s, e) => np.tableNumberSetter(true, 3, txtTableNo);
            btnT4.Click += (s, e) => np.tableNumberSetter(true, 4, txtTableNo);
            btnT5.Click += (s, e) => np.tableNumberSetter(true, 5, txtTableNo);
            btnT6.Click += (s, e) => np.tableNumberSetter(true, 6, txtTableNo);
            btnT7.Click += (s, e) => np.tableNumberSetter(true, 7, txtTableNo);
            btnT8.Click += (s, e) => np.tableNumberSetter(true, 8, txtTableNo);
            btnT9.Click += (s, e) => np.tableNumberSetter(true, 9, txtTableNo);
            btnTD.Click += (s, e) => np.tableNumberSetter(false, 0, txtTableNo);
            btnTE.Click += (s, e) => np.tableNumberSetter(false, 1, txtTableNo);

        }

        private void timerReloj_Tick(object sender, EventArgs e)
        {
            labelDate.Text = pm.du;
        }

        private void managerCode_Click(object sender, EventArgs e)
        {
            
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
                new logs("LPM: Clossing OK", false, 3);
                this.pm.Close();
        }
    }
}
