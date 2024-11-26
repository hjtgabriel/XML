namespace XML
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtPlatillo = new TextBox();
            txtPrecio = new TextBox();
            txtDescripcion = new TextBox();
            btnAgregar = new Button();
            btnmenu = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(784, 125);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.GrayText;
            label1.Font = new Font("Segoe UI Variable Display Semib", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(155, 28);
            label1.Name = "label1";
            label1.Size = new Size(442, 63);
            label1.TabIndex = 0;
            label1.Text = "Restaurante Norlita";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(33, 185);
            label2.Name = "label2";
            label2.Size = new Size(192, 27);
            label2.TabIndex = 1;
            label2.Text = "Nombre del Platillo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(145, 235);
            label3.Name = "label3";
            label3.Size = new Size(75, 27);
            label3.TabIndex = 2;
            label3.Text = "Precio:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(94, 283);
            label4.Name = "label4";
            label4.Size = new Size(126, 27);
            label4.TabIndex = 3;
            label4.Text = "Descripcion:";
            // 
            // txtPlatillo
            // 
            txtPlatillo.Location = new Point(226, 188);
            txtPlatillo.Name = "txtPlatillo";
            txtPlatillo.Size = new Size(156, 27);
            txtPlatillo.TabIndex = 4;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(226, 235);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(156, 27);
            txtPrecio.TabIndex = 5;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(226, 286);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(156, 27);
            txtDescripcion.TabIndex = 6;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(12, 344);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(194, 42);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar Platillo";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnmenu
            // 
            btnmenu.Font = new Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnmenu.Location = new Point(12, 392);
            btnmenu.Name = "btnmenu";
            btnmenu.Size = new Size(194, 42);
            btnmenu.TabIndex = 8;
            btnmenu.Text = "Mostrar Menu";
            btnmenu.UseVisualStyleBackColor = true;
            btnmenu.Click += btnmenu_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(12, 440);
            button3.Name = "button3";
            button3.Size = new Size(194, 42);
            button3.TabIndex = 9;
            button3.Text = "Eliminar Platillo";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(413, 158);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(383, 249);
            dataGridView1.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuBar;
            ClientSize = new Size(800, 494);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(btnmenu);
            Controls.Add(btnAgregar);
            Controls.Add(txtDescripcion);
            Controls.Add(txtPrecio);
            Controls.Add(txtPlatillo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtPlatillo;
        private TextBox txtPrecio;
        private TextBox txtDescripcion;
        private Button btnAgregar;
        private Button btnmenu;
        private Button button3;
        private DataGridView dataGridView1;
    }
}
