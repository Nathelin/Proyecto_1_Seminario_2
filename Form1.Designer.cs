namespace Proyecto1Seminario2Grupo13
{
    partial class Form1
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
            txtNombre = new TextBox();
            btnModificar = new Button();
            cbxTipoMovimiento = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            nupCantidadMovimineto = new NumericUpDown();
            lstProductos = new ListBox();
            label4 = new Label();
            btnAgregar = new Button();
            label3 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)nupCantidadMovimineto).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Tahoma", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(133, 46, 54);
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(1049, 70);
            label1.TabIndex = 0;
            label1.Text = "PROYECTO 1 - Grupo 13";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 179);
            label2.Name = "label2";
            label2.Size = new Size(196, 23);
            label2.TabIndex = 1;
            label2.Text = "Nombre del producto:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(23, 205);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(273, 30);
            txtNombre.TabIndex = 3;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(133, 46, 54);
            btnModificar.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModificar.ForeColor = Color.Snow;
            btnModificar.Location = new Point(470, 423);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(211, 46);
            btnModificar.TabIndex = 12;
            btnModificar.Text = "Modificar stock";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // cbxTipoMovimiento
            // 
            cbxTipoMovimiento.FormattingEnabled = true;
            cbxTipoMovimiento.Items.AddRange(new object[] { "AGREGAR", "QUITAR" });
            cbxTipoMovimiento.Location = new Point(264, 438);
            cbxTipoMovimiento.Name = "cbxTipoMovimiento";
            cbxTipoMovimiento.Size = new Size(166, 31);
            cbxTipoMovimiento.TabIndex = 11;
            cbxTipoMovimiento.Text = "AGREGAR";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 445);
            label6.Name = "label6";
            label6.Size = new Size(155, 23);
            label6.TabIndex = 10;
            label6.Text = "Tipo movimiento:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 394);
            label5.Name = "label5";
            label5.Size = new Size(91, 23);
            label5.TabIndex = 9;
            label5.Text = "Cantidad:";
            // 
            // nupCantidadMovimineto
            // 
            nupCantidadMovimineto.Location = new Point(264, 387);
            nupCantidadMovimineto.Name = "nupCantidadMovimineto";
            nupCantidadMovimineto.Size = new Size(166, 30);
            nupCantidadMovimineto.TabIndex = 0;
            // 
            // lstProductos
            // 
            lstProductos.FormattingEnabled = true;
            lstProductos.ItemHeight = 23;
            lstProductos.Location = new Point(727, 142);
            lstProductos.Name = "lstProductos";
            lstProductos.Size = new Size(300, 326);
            lstProductos.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(133, 46, 54);
            label4.Location = new Point(727, 104);
            label4.Name = "label4";
            label4.Size = new Size(239, 25);
            label4.TabIndex = 7;
            label4.Text = "Listado de productos:";
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(133, 46, 54);
            btnAgregar.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = Color.Snow;
            btnAgregar.Location = new Point(470, 189);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(211, 46);
            btnAgregar.TabIndex = 8;
            btnAgregar.Text = "Agregar producto";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label3
            // 
            label3.BackColor = Color.RosyBrown;
            label3.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Snow;
            label3.Location = new Point(23, 299);
            label3.Name = "label3";
            label3.Size = new Size(305, 47);
            label3.TabIndex = 9;
            label3.Text = "Gestión de movimientos";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(23, 355);
            label7.Name = "label7";
            label7.Size = new Size(398, 19);
            label7.TabIndex = 10;
            label7.Text = "* Seleccione un producto desde el listado de productos";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(23, 142);
            label8.Name = "label8";
            label8.Size = new Size(382, 19);
            label8.TabIndex = 11;
            label8.Text = "* Ingrese el nombre del producto que desee agregar";
            // 
            // label9
            // 
            label9.BackColor = Color.RosyBrown;
            label9.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Snow;
            label9.Location = new Point(25, 82);
            label9.Name = "label9";
            label9.Size = new Size(271, 47);
            label9.TabIndex = 12;
            label9.Text = "Gestión de productos";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.BackColor = Color.FromArgb(133, 46, 54);
            label10.ForeColor = Color.MistyRose;
            label10.Location = new Point(359, 47);
            label10.Name = "label10";
            label10.Size = new Size(322, 23);
            label10.TabIndex = 13;
            label10.Text = "Seminario de Lenguajes II - Teoría";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            label10.Click += label10_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1049, 508);
            Controls.Add(btnModificar);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(cbxTipoMovimiento);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(nupCantidadMovimineto);
            Controls.Add(label5);
            Controls.Add(label8);
            Controls.Add(label3);
            Controls.Add(btnAgregar);
            Controls.Add(label4);
            Controls.Add(lstProductos);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.Desktop;
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nupCantidadMovimineto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNombre;
        private Button btnModificar;
        private ComboBox cbxTipoMovimiento;
        private Label label6;
        private Label label5;
        private NumericUpDown nupCantidadMovimineto;
        private ListBox lstProductos;
        private Label label4;
        private Button btnAgregar;
        private Label label7;
        private Label label3;
        private Label label8;
        private Label label9;
        private Label label10;
    }
}
