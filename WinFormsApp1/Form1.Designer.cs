namespace WinFormsApp1
{
    partial class grilla
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnAddUser = new Button();
            btnDea = new Button();
            txtCode = new TextBox();
            txtPin = new TextBox();
            txtUser = new TextBox();
            label5 = new Label();
            cbFun = new ComboBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 77);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 0;
            label1.Text = "Codigo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 119);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 1;
            label2.Text = "Pin:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.Location = new Point(78, 18);
            label3.Name = "label3";
            label3.Size = new Size(387, 37);
            label3.TabIndex = 2;
            label3.Text = "Añadir Mesero(a)/Encargado(a)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 161);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 3;
            label4.Text = "Nombre:";
            // 
            // btnAddUser
            // 
            btnAddUser.Location = new Point(783, 58);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(115, 34);
            btnAddUser.TabIndex = 4;
            btnAddUser.Text = "Añadir";
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // btnDea
            // 
            btnDea.Location = new Point(783, 109);
            btnDea.Name = "btnDea";
            btnDea.Size = new Size(115, 34);
            btnDea.TabIndex = 5;
            btnDea.Text = "Desactivar";
            btnDea.UseVisualStyleBackColor = true;
            btnDea.Click += btnDea_Click;
            // 
            // txtCode
            // 
            txtCode.Location = new Point(111, 74);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(70, 23);
            txtCode.TabIndex = 6;
            // 
            // txtPin
            // 
            txtPin.Location = new Point(111, 116);
            txtPin.Name = "txtPin";
            txtPin.Size = new Size(70, 23);
            txtPin.TabIndex = 7;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(111, 158);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(655, 23);
            txtUser.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(56, 200);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 9;
            label5.Text = "Función:";
            // 
            // cbFun
            // 
            cbFun.FormattingEnabled = true;
            cbFun.Items.AddRange(new object[] { "01 - Mesero(a)", "02 - Encaregado(a)" });
            cbFun.Location = new Point(126, 197);
            cbFun.Name = "cbFun";
            cbFun.Size = new Size(121, 23);
            cbFun.TabIndex = 10;
            cbFun.Text = "--Selecionar--";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(52, 243);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(846, 261);
            dataGridView1.TabIndex = 11;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // grilla
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(931, 535);
            Controls.Add(dataGridView1);
            Controls.Add(cbFun);
            Controls.Add(label5);
            Controls.Add(txtUser);
            Controls.Add(txtPin);
            Controls.Add(txtCode);
            Controls.Add(btnDea);
            Controls.Add(btnAddUser);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "grilla";
            Text = "Tienda (V.Alpha-0.0.1)";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnAddUser;
        private Button btnDea;
        private TextBox txtCode;
        private TextBox txtPin;
        private TextBox txtUser;
        private Label label5;
        private ComboBox cbFun;
        private DataGridView dataGridView1;
    }
}
