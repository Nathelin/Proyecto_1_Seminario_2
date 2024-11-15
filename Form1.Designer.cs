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
            groupBox1 = new GroupBox();
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
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nupCantidadMovimineto).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Tahoma", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            // groupBox1
            // 
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(btnModificar);
            groupBox1.Controls.Add(cbxTipoMovimiento);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(nupCantidadMovimineto);
            groupBox1.Location = new Point(12, 317);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(684, 167);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnModificar
            // 
            btnModificar.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModificar.Location = new Point(458, 103);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(211, 46);
            btnModificar.TabIndex = 12;
            btnModificar.Text = "Modificar stock";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // cbxTipoMovimiento
            // 
            cbxTipoMovimiento.FormattingEnabled = true;
            cbxTipoMovimiento.Items.AddRange(new object[] { "AGREGAR", "QUITAR" });
            cbxTipoMovimiento.Location = new Point(253, 118);
            cbxTipoMovimiento.Name = "cbxTipoMovimiento";
            cbxTipoMovimiento.Size = new Size(166, 31);
            cbxTipoMovimiento.TabIndex = 11;
            cbxTipoMovimiento.Text = "AGREGAR";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 126);
            label6.Name = "label6";
            label6.Size = new Size(155, 23);
            label6.TabIndex = 10;
            label6.Text = "Tipo movimiento:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 75);
            label5.Name = "label5";
            label5.Size = new Size(91, 23);
            label5.TabIndex = 9;
            label5.Text = "Cantidad:";
            // 
            // nupCantidadMovimineto
            // 
            nupCantidadMovimineto.Location = new Point(253, 68);
            nupCantidadMovimineto.Name = "nupCantidadMovimineto";
            nupCantidadMovimineto.Size = new Size(167, 30);
            nupCantidadMovimineto.TabIndex = 0;
            // 
            // lstProductos
            // 
            lstProductos.FormattingEnabled = true;
            lstProductos.ItemHeight = 23;
            lstProductos.Location = new Point(727, 142);
            lstProductos.Name = "lstProductos";
            lstProductos.Size = new Size(300, 349);
            lstProductos.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(727, 106);
            label4.Name = "label4";
            label4.Size = new Size(191, 23);
            label4.TabIndex = 7;
            label4.Text = "Listado de productos:";
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(470, 189);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(211, 46);
            btnAgregar.TabIndex = 8;
            btnAgregar.Text = "Agregar producto";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 295);
            label3.Name = "label3";
            label3.Size = new Size(328, 47);
            label3.TabIndex = 9;
            label3.Text = "Gestión de movimientos";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(11, 35);
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
            label9.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(25, 82);
            label9.Name = "label9";
            label9.Size = new Size(271, 47);
            label9.TabIndex = 12;
            label9.Text = "Gestión de productos";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(366, 47);
            label10.Name = "label10";
            label10.Size = new Size(302, 23);
            label10.TabIndex = 13;
            label10.Text = "Seminario de Lenguajes II - Teoría";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1049, 510);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label3);
            Controls.Add(btnAgregar);
            Controls.Add(label4);
            Controls.Add(lstProductos);
            Controls.Add(groupBox1);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nupCantidadMovimineto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNombre;
        private GroupBox groupBox1;
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
