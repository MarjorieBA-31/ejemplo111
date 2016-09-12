namespace Examen_final_proga2_marjorie
{
    partial class nueva_matricula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nueva_matricula));
            this.DGVmatricula = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tx_idCarrera = new System.Windows.Forms.TextBox();
            this.tx_idMateria = new System.Windows.Forms.TextBox();
            this.tx_idMatricula = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tx_idAlumno = new System.Windows.Forms.TextBox();
            this.tx_fecha_matricula = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnguardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVmatricula)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVmatricula
            // 
            this.DGVmatricula.AllowUserToAddRows = false;
            this.DGVmatricula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVmatricula.DefaultCellStyle = dataGridViewCellStyle1;
            this.DGVmatricula.Location = new System.Drawing.Point(31, 276);
            this.DGVmatricula.Name = "DGVmatricula";
            this.DGVmatricula.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVmatricula.Size = new System.Drawing.Size(417, 177);
            this.DGVmatricula.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tx_idCarrera);
            this.groupBox1.Controls.Add(this.tx_idMateria);
            this.groupBox1.Controls.Add(this.tx_idMatricula);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tx_idAlumno);
            this.groupBox1.Controls.Add(this.tx_fecha_matricula);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(53, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 237);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Importantes";
            // 
            // tx_idCarrera
            // 
            this.tx_idCarrera.Location = new System.Drawing.Point(135, 66);
            this.tx_idCarrera.Name = "tx_idCarrera";
            this.tx_idCarrera.Size = new System.Drawing.Size(100, 20);
            this.tx_idCarrera.TabIndex = 19;
            // 
            // tx_idMateria
            // 
            this.tx_idMateria.Location = new System.Drawing.Point(135, 115);
            this.tx_idMateria.Name = "tx_idMateria";
            this.tx_idMateria.Size = new System.Drawing.Size(100, 20);
            this.tx_idMateria.TabIndex = 20;
            // 
            // tx_idMatricula
            // 
            this.tx_idMatricula.Location = new System.Drawing.Point(135, 154);
            this.tx_idMatricula.Name = "tx_idMatricula";
            this.tx_idMatricula.Size = new System.Drawing.Size(100, 20);
            this.tx_idMatricula.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Fecha Matricula";
            // 
            // tx_idAlumno
            // 
            this.tx_idAlumno.Location = new System.Drawing.Point(135, 26);
            this.tx_idAlumno.Name = "tx_idAlumno";
            this.tx_idAlumno.Size = new System.Drawing.Size(100, 20);
            this.tx_idAlumno.TabIndex = 18;
            // 
            // tx_fecha_matricula
            // 
            this.tx_fecha_matricula.Location = new System.Drawing.Point(135, 188);
            this.tx_fecha_matricula.Name = "tx_fecha_matricula";
            this.tx_fecha_matricula.Size = new System.Drawing.Size(100, 20);
            this.tx_fecha_matricula.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "IDalumno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "IDcarrera";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "IDmateria";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "IDmatricula";
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.Color.Maroon;
            this.btnguardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnguardar.Location = new System.Drawing.Point(445, 73);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(53, 53);
            this.btnguardar.TabIndex = 31;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // nueva_matricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(550, 474);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DGVmatricula);
            this.Name = "nueva_matricula";
            this.Text = "nueva_matricula";
            this.Load += new System.EventHandler(this.nueva_matricula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVmatricula)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVmatricula;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tx_idCarrera;
        private System.Windows.Forms.TextBox tx_idMateria;
        private System.Windows.Forms.TextBox tx_idMatricula;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tx_idAlumno;
        private System.Windows.Forms.TextBox tx_fecha_matricula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnguardar;
    }
}