namespace Examen_final_proga2_marjorie
{
    partial class Consulta_matricula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consulta_matricula));
            this.tx_idAlumno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DGVmatricula = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVmatricula)).BeginInit();
            this.SuspendLayout();
            // 
            // tx_idAlumno
            // 
            this.tx_idAlumno.Location = new System.Drawing.Point(157, 31);
            this.tx_idAlumno.Name = "tx_idAlumno";
            this.tx_idAlumno.Size = new System.Drawing.Size(100, 20);
            this.tx_idAlumno.TabIndex = 17;
            this.tx_idAlumno.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tx_idAlumno_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "IDalumno:";
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
            this.DGVmatricula.Location = new System.Drawing.Point(12, 103);
            this.DGVmatricula.Name = "DGVmatricula";
            this.DGVmatricula.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVmatricula.Size = new System.Drawing.Size(542, 236);
            this.DGVmatricula.TabIndex = 15;
            // 
            // Consulta_matricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(584, 353);
            this.Controls.Add(this.tx_idAlumno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGVmatricula);
            this.Name = "Consulta_matricula";
            this.Text = "Consulta_matricula";
            this.Load += new System.EventHandler(this.Consulta_matricula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVmatricula)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tx_idAlumno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGVmatricula;
    }
}