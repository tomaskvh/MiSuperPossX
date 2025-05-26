namespace WinFormsApp1
{
    partial class Login
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
            label1 = new Label();
            labelPin = new Label();
            btnTE = new Button();
            btnT9 = new Button();
            btnT6 = new Button();
            btnT0 = new Button();
            btnT8 = new Button();
            btnT5 = new Button();
            btnTD = new Button();
            btnT7 = new Button();
            btnT4 = new Button();
            btnT3 = new Button();
            btnT2 = new Button();
            btnT1 = new Button();
            txtTableNo = new TextBox();
            button1 = new Button();
            labelName = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(12, 6);
            label1.Name = "label1";
            label1.Size = new Size(136, 28);
            label1.TabIndex = 0;
            label1.Text = "MiSuperPossX";
            // 
            // labelPin
            // 
            labelPin.AutoSize = true;
            labelPin.Font = new Font("Segoe UI", 11F);
            labelPin.Location = new Point(61, 60);
            labelPin.Name = "labelPin";
            labelPin.Size = new Size(209, 20);
            labelPin.TabIndex = 1;
            labelPin.Text = "Ingresar coidgo encargado(a):";
            labelPin.TextAlign = ContentAlignment.TopRight;
            // 
            // btnTE
            // 
            btnTE.Font = new Font("Segoe UI", 12F);
            btnTE.Location = new Point(438, 233);
            btnTE.Name = "btnTE";
            btnTE.Size = new Size(75, 42);
            btnTE.TabIndex = 34;
            btnTE.Text = "X";
            btnTE.UseVisualStyleBackColor = true;
            btnTE.Click += btnTE_Click;
            // 
            // btnT9
            // 
            btnT9.Font = new Font("Segoe UI", 12F);
            btnT9.Location = new Point(438, 185);
            btnT9.Name = "btnT9";
            btnT9.Size = new Size(75, 42);
            btnT9.TabIndex = 33;
            btnT9.Text = "9";
            btnT9.UseVisualStyleBackColor = true;
            btnT9.Click += btnT9_Click;
            // 
            // btnT6
            // 
            btnT6.Font = new Font("Segoe UI", 12F);
            btnT6.Location = new Point(438, 137);
            btnT6.Name = "btnT6";
            btnT6.Size = new Size(75, 42);
            btnT6.TabIndex = 32;
            btnT6.Text = "6";
            btnT6.UseVisualStyleBackColor = true;
            btnT6.Click += btnT6_Click;
            // 
            // btnT0
            // 
            btnT0.Font = new Font("Segoe UI", 12F);
            btnT0.Location = new Point(357, 233);
            btnT0.Name = "btnT0";
            btnT0.Size = new Size(75, 42);
            btnT0.TabIndex = 31;
            btnT0.Text = "0";
            btnT0.UseVisualStyleBackColor = true;
            btnT0.Click += btnT0_Click;
            // 
            // btnT8
            // 
            btnT8.Font = new Font("Segoe UI", 12F);
            btnT8.Location = new Point(357, 185);
            btnT8.Name = "btnT8";
            btnT8.Size = new Size(75, 42);
            btnT8.TabIndex = 30;
            btnT8.Text = "8";
            btnT8.UseVisualStyleBackColor = true;
            btnT8.Click += btnT8_Click;
            // 
            // btnT5
            // 
            btnT5.Font = new Font("Segoe UI", 12F);
            btnT5.Location = new Point(357, 137);
            btnT5.Name = "btnT5";
            btnT5.Size = new Size(75, 42);
            btnT5.TabIndex = 29;
            btnT5.Text = "5";
            btnT5.UseVisualStyleBackColor = true;
            btnT5.Click += btnT5_Click;
            // 
            // btnTD
            // 
            btnTD.Font = new Font("Segoe UI", 12F);
            btnTD.Location = new Point(276, 233);
            btnTD.Name = "btnTD";
            btnTD.Size = new Size(75, 42);
            btnTD.TabIndex = 28;
            btnTD.Text = "<";
            btnTD.UseVisualStyleBackColor = true;
            btnTD.Click += btnTD_Click;
            // 
            // btnT7
            // 
            btnT7.Font = new Font("Segoe UI", 12F);
            btnT7.Location = new Point(276, 185);
            btnT7.Name = "btnT7";
            btnT7.Size = new Size(75, 42);
            btnT7.TabIndex = 27;
            btnT7.Text = "7";
            btnT7.UseVisualStyleBackColor = true;
            btnT7.Click += btnT7_Click;
            // 
            // btnT4
            // 
            btnT4.Font = new Font("Segoe UI", 12F);
            btnT4.Location = new Point(276, 137);
            btnT4.Name = "btnT4";
            btnT4.Size = new Size(75, 42);
            btnT4.TabIndex = 26;
            btnT4.Text = "4";
            btnT4.UseVisualStyleBackColor = true;
            btnT4.Click += btnT4_Click;
            // 
            // btnT3
            // 
            btnT3.Font = new Font("Segoe UI", 12F);
            btnT3.Location = new Point(438, 89);
            btnT3.Name = "btnT3";
            btnT3.Size = new Size(75, 42);
            btnT3.TabIndex = 25;
            btnT3.Text = "3";
            btnT3.UseVisualStyleBackColor = true;
            btnT3.Click += btnT3_Click;
            // 
            // btnT2
            // 
            btnT2.Font = new Font("Segoe UI", 12F);
            btnT2.Location = new Point(357, 89);
            btnT2.Name = "btnT2";
            btnT2.Size = new Size(75, 42);
            btnT2.TabIndex = 24;
            btnT2.Text = "2";
            btnT2.UseVisualStyleBackColor = true;
            btnT2.Click += btnT2_Click;
            // 
            // btnT1
            // 
            btnT1.Font = new Font("Segoe UI", 12F);
            btnT1.Location = new Point(276, 89);
            btnT1.Name = "btnT1";
            btnT1.Size = new Size(75, 42);
            btnT1.TabIndex = 23;
            btnT1.Text = "1";
            btnT1.UseVisualStyleBackColor = true;
            btnT1.Click += btnT1_Click;
            // 
            // txtTableNo
            // 
            txtTableNo.Location = new Point(276, 60);
            txtTableNo.Name = "txtTableNo";
            txtTableNo.Size = new Size(143, 23);
            txtTableNo.TabIndex = 22;
            txtTableNo.KeyDown += txtTableNo_KeyDown;
            // 
            // button1
            // 
            button1.Location = new Point(425, 60);
            button1.Name = "button1";
            button1.Size = new Size(88, 23);
            button1.TabIndex = 35;
            button1.Text = "Siguiente >";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 11F);
            labelName.Location = new Point(12, 34);
            labelName.Name = "labelName";
            labelName.Size = new Size(314, 20);
            labelName.TabIndex = 36;
            labelName.Text = "Hola, NOMBRE NOMBRE APELLIDO APELLIDO";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(533, 292);
            Controls.Add(labelName);
            Controls.Add(button1);
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
            Controls.Add(txtTableNo);
            Controls.Add(labelPin);
            Controls.Add(label1);
            Name = "Login";
            Text = "Credenciales";
            FormClosing += Login_FormClosing;
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Label label1;
        private Label labelPin;
        private Button btnTE;
        private Button btnT9;
        private Button btnT6;
        private Button btnT0;
        private Button btnT8;
        private Button btnT5;
        private Button btnTD;
        private Button btnT7;
        private Button btnT4;
        private Button btnT3;
        private Button btnT2;
        private Button btnT1;
        private TextBox txtTableNo;
        private Button button1;
        private Label labelName;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}