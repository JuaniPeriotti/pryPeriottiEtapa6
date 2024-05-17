namespace pryPeriottiEtapa6
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
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            btnMover = new Button();
            btnCrearVehiculos = new Button();
            lstCantidad = new ComboBox();
            timer1 = new System.Windows.Forms.Timer(components);
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnMover);
            groupBox1.Controls.Add(btnCrearVehiculos);
            groupBox1.Controls.Add(lstCantidad);
            groupBox1.Location = new Point(12, 430);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(767, 119);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Crear Vehículos";
            // 
            // btnMover
            // 
            btnMover.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnMover.Location = new Point(518, 22);
            btnMover.Name = "btnMover";
            btnMover.Size = new Size(236, 89);
            btnMover.TabIndex = 4;
            btnMover.Text = "Mover";
            btnMover.UseVisualStyleBackColor = true;
            btnMover.Click += btnMover_Click;
            // 
            // btnCrearVehiculos
            // 
            btnCrearVehiculos.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnCrearVehiculos.Location = new Point(276, 22);
            btnCrearVehiculos.Name = "btnCrearVehiculos";
            btnCrearVehiculos.Size = new Size(236, 89);
            btnCrearVehiculos.TabIndex = 3;
            btnCrearVehiculos.Text = "Crear Vehículos";
            btnCrearVehiculos.UseVisualStyleBackColor = true;
            btnCrearVehiculos.Click += btnCrearVehiculos_Click;
            // 
            // lstCantidad
            // 
            lstCantidad.DropDownStyle = ComboBoxStyle.DropDownList;
            lstCantidad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lstCantidad.FormattingEnabled = true;
            lstCantidad.Items.AddRange(new object[] { "2", "4" });
            lstCantidad.Location = new Point(6, 22);
            lstCantidad.Name = "lstCantidad";
            lstCantidad.Size = new Size(264, 29);
            lstCantidad.TabIndex = 0;
            // 
            // timer1
            // 
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(791, 561);
            Controls.Add(groupBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnCrearVehiculos;
        private ComboBox lstCantidad;
        private System.Windows.Forms.Timer timer1;
        private Button btnMover;
    }
}
