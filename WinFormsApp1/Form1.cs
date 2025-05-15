using System.Data;
using WinFormsApp1.Dato;
using WinFormsApp1.Modelo;

namespace WinFormsApp1
{
    public partial class grilla : Form
    {
        DataTable Data;
        User dato = new User();
        public grilla()
        {
            InitializeComponent();
            Init();
            Console.WriteLine("Aplicacion Iniciada Exitosamente");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            Save();
            Init();
            Clean();
            Consultar();
        }

        private void btnDea_Click(object sender, EventArgs e)
        {

        }

        private void Init()
        {
            Data = new DataTable();
            Data.Columns.Add("Codigo");
            Data.Columns.Add("Pin");
            Data.Columns.Add("Nombre");
            Data.Columns.Add("Función");
            dataGridView1.DataSource = Data;
        }

        private void Save()
        {
            ModelUser modelo = new ModelUser()
            {
                Codigo=txtCode.Text,
                Pin=txtPin.Text,
                Name=txtUser.Name,
                Funcion=cbFun.Text
            };
            dato.SaveUser(modelo);
        }
        private void Consultar()
        {
            foreach (var item in dato.Consultar())
            {
                DataRow fila = Data.NewRow();
                fila[0] = item.Codigo;
                fila[1] = item.Pin;
                fila[2] = item.Name;
                fila[3] = item.Funcion;
                Data.Rows.Add(fila);
            }
        }
        
        private void Clean() {
            txtCode.Text = "";
            txtPin.Text = "";
            txtUser.Text = "";
            cbFun.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
