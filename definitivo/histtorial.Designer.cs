namespace definitivo
{
    partial class histtorial
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
            button1 = new Button();
            Placa = new Label();
            txtPlaca2 = new TextBox();
            dgvHistorial = new DataGridView();
            label1 = new Label();
            txtBuscar = new TextBox();
            btnbuscar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(602, 11);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Placa
            // 
            Placa.AutoSize = true;
            Placa.Location = new Point(34, 76);
            Placa.Name = "Placa";
            Placa.Size = new Size(44, 20);
            Placa.TabIndex = 2;
            Placa.Text = "Placa";
            // 
            // txtPlaca2
            // 
            txtPlaca2.Location = new Point(34, 100);
            txtPlaca2.Margin = new Padding(3, 4, 3, 4);
            txtPlaca2.Name = "txtPlaca2";
            txtPlaca2.Size = new Size(114, 27);
            txtPlaca2.TabIndex = 3;
            // 
            // dgvHistorial
            // 
            dgvHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorial.Location = new Point(293, 76);
            dgvHistorial.Margin = new Padding(3, 4, 3, 4);
            dgvHistorial.Name = "dgvHistorial";
            dgvHistorial.RowHeadersWidth = 51;
            dgvHistorial.RowTemplate.Height = 25;
            dgvHistorial.Size = new Size(375, 439);
            dgvHistorial.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 131);
            label1.Name = "label1";
            label1.Size = new Size(114, 20);
            label1.TabIndex = 6;
            label1.Text = "Confirmar Placa";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(34, 154);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(125, 27);
            txtBuscar.TabIndex = 7;
            // 
            // btnbuscar
            // 
            btnbuscar.Location = new Point(54, 206);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(94, 29);
            btnbuscar.TabIndex = 8;
            btnbuscar.Text = "Buscar";
            btnbuscar.UseVisualStyleBackColor = true;
            btnbuscar.Click += btnbuscar_Click;
            // 
            // histtorial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(699, 571);
            Controls.Add(btnbuscar);
            Controls.Add(txtBuscar);
            Controls.Add(label1);
            Controls.Add(dgvHistorial);
            Controls.Add(txtPlaca2);
            Controls.Add(Placa);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "histtorial";
            Text = "histtorial";
            Load += histtorial_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Label Placa;
        private TextBox txtPlaca2;
        private DataGridView dgvHistorial;
        private Label label1;
        private TextBox txtBuscar;
        private Button btnbuscar;
    }
}