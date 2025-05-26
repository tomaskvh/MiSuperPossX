namespace WinFormsApp1
{
    partial class NuevoPedido
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
            labelMesa = new Label();
            btnBack = new Button();
            SuspendLayout();
            // 
            // labelMesa
            // 
            labelMesa.AutoSize = true;
            labelMesa.Font = new Font("Segoe UI", 11F);
            labelMesa.Location = new Point(128, 15);
            labelMesa.Name = "labelMesa";
            labelMesa.Size = new Size(67, 20);
            labelMesa.TabIndex = 0;
            labelMesa.Text = "Mesa: 00";
            labelMesa.Click += labelMesa_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(12, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(92, 28);
            btnBack.TabIndex = 1;
            btnBack.Text = "< Volver";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // NuevoPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1091, 637);
            Controls.Add(btnBack);
            Controls.Add(labelMesa);
            Name = "NuevoPedido";
            Text = "NuevoPedido";
            Load += NuevoPedido_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelMesa;
        private Button btnBack;
    }
}