namespace WinFormsApp1.Modelo
{
    partial class PossMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnNewOrder = new Button();
            btnDelivery = new Button();
            btnCuenta = new Button();
            btnAddPay = new Button();
            btnCloseSession = new Button();
            label1 = new Label();
            labelDate = new Label();
            timerReloj = new System.Windows.Forms.Timer(components);
            labelMesero = new Label();
            txtTableNo = new TextBox();
            label2 = new Label();
            btnT1 = new Button();
            btnT2 = new Button();
            btnT3 = new Button();
            btnT4 = new Button();
            btnT7 = new Button();
            btnTD = new Button();
            btnT5 = new Button();
            btnT8 = new Button();
            btnT0 = new Button();
            btnT6 = new Button();
            btnT9 = new Button();
            btnTE = new Button();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            labelManager = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnNewOrder
            // 
            btnNewOrder.Location = new Point(1109, 12);
            btnNewOrder.Name = "btnNewOrder";
            btnNewOrder.Size = new Size(134, 93);
            btnNewOrder.TabIndex = 0;
            btnNewOrder.Text = "Crear Pedido";
            btnNewOrder.UseVisualStyleBackColor = true;
            btnNewOrder.Click += btnNewOrder_Click;
            // 
            // btnDelivery
            // 
            btnDelivery.Location = new Point(1109, 120);
            btnDelivery.Name = "btnDelivery";
            btnDelivery.Size = new Size(134, 93);
            btnDelivery.TabIndex = 1;
            btnDelivery.Text = "Delivery";
            btnDelivery.UseVisualStyleBackColor = true;
            btnDelivery.Click += button2_Click;
            // 
            // btnCuenta
            // 
            btnCuenta.Location = new Point(1109, 230);
            btnCuenta.Name = "btnCuenta";
            btnCuenta.Size = new Size(134, 93);
            btnCuenta.TabIndex = 2;
            btnCuenta.Text = "Cuenta";
            btnCuenta.UseVisualStyleBackColor = true;
            // 
            // btnAddPay
            // 
            btnAddPay.Location = new Point(1109, 341);
            btnAddPay.Name = "btnAddPay";
            btnAddPay.Size = new Size(134, 93);
            btnAddPay.TabIndex = 3;
            btnAddPay.Text = "Ingresar Pago";
            btnAddPay.UseVisualStyleBackColor = true;
            // 
            // btnCloseSession
            // 
            btnCloseSession.Location = new Point(1109, 452);
            btnCloseSession.Name = "btnCloseSession";
            btnCloseSession.Size = new Size(134, 93);
            btnCloseSession.TabIndex = 4;
            btnCloseSession.Text = "Cerrar Sesion";
            btnCloseSession.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(31, 12);
            label1.Name = "label1";
            label1.Size = new Size(184, 37);
            label1.TabIndex = 5;
            label1.Text = "MiSuperPossX";
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Font = new Font("Segoe UI", 11F);
            labelDate.Location = new Point(31, 51);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(252, 20);
            labelDate.TabIndex = 6;
            labelDate.Text = "Fecha: DD/MM/AAAA Hora: 00:00:00";
            labelDate.Click += labelDate_Click;
            // 
            // timerReloj
            // 
            timerReloj.Tick += timer1_Tick;
            // 
            // labelMesero
            // 
            labelMesero.AutoSize = true;
            labelMesero.Font = new Font("Segoe UI", 11F);
            labelMesero.Location = new Point(31, 71);
            labelMesero.Name = "labelMesero";
            labelMesero.Size = new Size(284, 20);
            labelMesero.TabIndex = 7;
            labelMesero.Text = "Mesero(a): NOMBRE APELLIDO APELLIDO";
            // 
            // txtTableNo
            // 
            txtTableNo.Location = new Point(51, 161);
            txtTableNo.Name = "txtTableNo";
            txtTableNo.Size = new Size(237, 23);
            txtTableNo.TabIndex = 8;
            txtTableNo.TextChanged += txtTableNo_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(51, 139);
            label2.Name = "label2";
            label2.Size = new Size(166, 19);
            label2.TabIndex = 9;
            label2.Text = "Ingresar numero de mesa";
            label2.Click += label2_Click;
            // 
            // btnT1
            // 
            btnT1.Font = new Font("Segoe UI", 12F);
            btnT1.Location = new Point(51, 190);
            btnT1.Name = "btnT1";
            btnT1.Size = new Size(75, 42);
            btnT1.TabIndex = 10;
            btnT1.Text = "1";
            btnT1.UseVisualStyleBackColor = true;
            btnT1.Click += btnT1_Click;
            // 
            // btnT2
            // 
            btnT2.Font = new Font("Segoe UI", 12F);
            btnT2.Location = new Point(132, 190);
            btnT2.Name = "btnT2";
            btnT2.Size = new Size(75, 42);
            btnT2.TabIndex = 11;
            btnT2.Text = "2";
            btnT2.UseVisualStyleBackColor = true;
            btnT2.Click += btnT2_Click;
            // 
            // btnT3
            // 
            btnT3.Font = new Font("Segoe UI", 12F);
            btnT3.Location = new Point(213, 190);
            btnT3.Name = "btnT3";
            btnT3.Size = new Size(75, 42);
            btnT3.TabIndex = 12;
            btnT3.Text = "3";
            btnT3.UseVisualStyleBackColor = true;
            btnT3.Click += btnT3_Click;
            // 
            // btnT4
            // 
            btnT4.Font = new Font("Segoe UI", 12F);
            btnT4.Location = new Point(51, 238);
            btnT4.Name = "btnT4";
            btnT4.Size = new Size(75, 42);
            btnT4.TabIndex = 13;
            btnT4.Text = "4";
            btnT4.UseVisualStyleBackColor = true;
            btnT4.Click += button5_Click;
            // 
            // btnT7
            // 
            btnT7.Font = new Font("Segoe UI", 12F);
            btnT7.Location = new Point(51, 286);
            btnT7.Name = "btnT7";
            btnT7.Size = new Size(75, 42);
            btnT7.TabIndex = 14;
            btnT7.Text = "7";
            btnT7.UseVisualStyleBackColor = true;
            btnT7.Click += btnT7_Click;
            // 
            // btnTD
            // 
            btnTD.Font = new Font("Segoe UI", 12F);
            btnTD.Location = new Point(51, 334);
            btnTD.Name = "btnTD";
            btnTD.Size = new Size(75, 42);
            btnTD.TabIndex = 15;
            btnTD.Text = "<";
            btnTD.UseVisualStyleBackColor = true;
            btnTD.Click += btnTD_Click;
            // 
            // btnT5
            // 
            btnT5.Font = new Font("Segoe UI", 12F);
            btnT5.Location = new Point(132, 238);
            btnT5.Name = "btnT5";
            btnT5.Size = new Size(75, 42);
            btnT5.TabIndex = 16;
            btnT5.Text = "5";
            btnT5.UseVisualStyleBackColor = true;
            btnT5.Click += btnT5_Click;
            // 
            // btnT8
            // 
            btnT8.Font = new Font("Segoe UI", 12F);
            btnT8.Location = new Point(132, 286);
            btnT8.Name = "btnT8";
            btnT8.Size = new Size(75, 42);
            btnT8.TabIndex = 17;
            btnT8.Text = "8";
            btnT8.UseVisualStyleBackColor = true;
            btnT8.Click += btnT8_Click;
            // 
            // btnT0
            // 
            btnT0.Font = new Font("Segoe UI", 12F);
            btnT0.Location = new Point(132, 334);
            btnT0.Name = "btnT0";
            btnT0.Size = new Size(75, 42);
            btnT0.TabIndex = 18;
            btnT0.Text = "0";
            btnT0.UseVisualStyleBackColor = true;
            btnT0.Click += btnT0_Click;
            // 
            // btnT6
            // 
            btnT6.Font = new Font("Segoe UI", 12F);
            btnT6.Location = new Point(213, 238);
            btnT6.Name = "btnT6";
            btnT6.Size = new Size(75, 42);
            btnT6.TabIndex = 19;
            btnT6.Text = "6";
            btnT6.UseVisualStyleBackColor = true;
            btnT6.Click += btnT6_Click;
            // 
            // btnT9
            // 
            btnT9.Font = new Font("Segoe UI", 12F);
            btnT9.Location = new Point(213, 286);
            btnT9.Name = "btnT9";
            btnT9.Size = new Size(75, 42);
            btnT9.TabIndex = 20;
            btnT9.Text = "9";
            btnT9.UseVisualStyleBackColor = true;
            btnT9.Click += btnT9_Click;
            // 
            // btnTE
            // 
            btnTE.Font = new Font("Segoe UI", 12F);
            btnTE.Location = new Point(213, 334);
            btnTE.Name = "btnTE";
            btnTE.Size = new Size(75, 42);
            btnTE.TabIndex = 21;
            btnTE.Text = "X";
            btnTE.UseVisualStyleBackColor = true;
            btnTE.Click += btnTE_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(374, 120);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(688, 505);
            dataGridView1.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(374, 92);
            label3.Name = "label3";
            label3.Size = new Size(235, 25);
            label3.TabIndex = 23;
            label3.Text = "Mesas actualmente en uso";
            // 
            // labelManager
            // 
            labelManager.AutoSize = true;
            labelManager.Font = new Font("Segoe UI", 11F);
            labelManager.Location = new Point(31, 92);
            labelManager.Name = "labelManager";
            labelManager.Size = new Size(142, 20);
            labelManager.TabIndex = 24;
            labelManager.Text = "Codigo Mesero: 000";
            labelManager.Click += labelManager_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1109, 551);
            button2.Name = "button2";
            button2.Size = new Size(134, 74);
            button2.TabIndex = 25;
            button2.Text = "Cerrar Turno";
            button2.UseVisualStyleBackColor = true;
            // 
            // PossMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(button2);
            Controls.Add(labelManager);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(btnTE);
            Controls.Add(btnT9);
            Controls.Add(btnT6);
            Controls.Add(btnT0);
            Controls.Add(btnT8);
            Controls.Add(btnT5);
            Controls.Add(btnTD);
            Controls.Add(btnT7);
            Controls.Add(btnT4);
            Controls.Add(btnT3);
            Controls.Add(btnT2);
            Controls.Add(btnT1);
            Controls.Add(label2);
            Controls.Add(txtTableNo);
            Controls.Add(labelMesero);
            Controls.Add(labelDate);
            Controls.Add(label1);
            Controls.Add(btnCloseSession);
            Controls.Add(btnAddPay);
            Controls.Add(btnCuenta);
            Controls.Add(btnDelivery);
            Controls.Add(btnNewOrder);
            Name = "PossMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MiSuperPossX (Ver. Alpha 0.0.1)";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNewOrder;
        private Button btnDelivery;
        private Button btnCuenta;
        private Button btnAddPay;
        private Button btnCloseSession;
        private Label label1;
        private Label labelDate;
        private System.Windows.Forms.Timer timerReloj;
        private Label labelMesero;
        private TextBox txtTableNo;
        private Label label2;
        private Button btnT1;
        private Button btnT2;
        private Button btnT3;
        private Button btnT4;
        private Button btnT7;
        private Button btnTD;
        private Button btnT5;
        private Button btnT8;
        private Button btnT0;
        private Button btnT6;
        private Button btnT9;
        private Button btnTE;
        private DataGridView dataGridView1;
        private Label label3;
        private Label labelManager;
        private Button button2;
    }
}