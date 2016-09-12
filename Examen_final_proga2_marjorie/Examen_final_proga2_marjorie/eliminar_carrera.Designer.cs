namespace Examen_final_proga2_marjorie
{
    partial class eliminar_carrera
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(eliminar_carrera));
            this.tx_nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tx_idAlumno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DGVcarrera = new System.Windows.Forms.DataGridView();
            this.btnborrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVcarrera)).BeginInit();
            this.SuspendLayout();
            // 
            // tx_nombre
            // 
            this.tx_nombre.Location = new System.Drawing.Point(154, 158);
            this.tx_nombre.Name = "tx_nombre";
            this.tx_nombre.Size = new System.Drawing.Size(100, 20);
            this.tx_nombre.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Nombre:";
            // 
            // tx_idAlumno
            // 
            this.tx_idAlumno.Location = new System.Drawing.Point(154, 85);
            this.tx_idAlumno.Name = "tx_idAlumno";
            this.tx_idAlumno.Size = new System.Drawing.Size(100, 20);
            this.tx_idAlumno.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "IDcarrera:";
            // 
            // DGVcarrera
            // 
            this.DGVcarrera.AllowUserToAddRows = false;
            this.DGVcarrera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVcarrera.DefaultCellStyle = dataGridViewCellStyle1;
            this.DGVcarrera.Location = new System.Drawing.Point(47, 245);
            this.DGVcarrera.Name = "DGVcarrera";
            this.DGVcarrera.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVcarrera.Size = new System.Drawing.Size(301, 177);
            this.DGVcarrera.TabIndex = 27;
            // 
            // btnborrar
            // 
            this.btnborrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnborrar.Location = new System.Drawing.Point(379, 118);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(53, 53);
            this.btnborrar.TabIndex = 33;
            this.btnborrar.Text = "Eliminar";
            this.btnborrar.UseVisualStyleBackColor = true;
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(60, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 194);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Eliminar Carrera";
            // 
            // eliminar_carrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(452, 434);
            this.Controls.Add(this.btnborrar);
            this.Controls.Add(this.tx_nombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tx_idAlumno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGVcarrera);
            this.Controls.Add(this.groupBox1);
            this.Name = "eliminar_carrera";
            this.Text = "eliminar_carrera";
            this.Load += new System.EventHandler(this.eliminar_carrera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVcarrera)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tx_nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tx_idAlumno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGVcarrera;
        private System.Windows.Forms.Button btnborrar;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}