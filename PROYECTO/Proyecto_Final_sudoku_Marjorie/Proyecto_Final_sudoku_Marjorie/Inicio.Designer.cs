namespace Proyecto_Final_sudoku_Marjorie
{
    partial class Inicio
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.lb_sudoku1 = new System.Windows.Forms.Label();
            this.lb_sudoku2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.principal = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_sudoku1
            // 
            this.lb_sudoku1.AutoSize = true;
            this.lb_sudoku1.BackColor = System.Drawing.Color.Transparent;
            this.lb_sudoku1.Font = new System.Drawing.Font("Snap ITC", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sudoku1.ForeColor = System.Drawing.Color.DeepPink;
            this.lb_sudoku1.Location = new System.Drawing.Point(125, 30);
            this.lb_sudoku1.Name = "lb_sudoku1";
            this.lb_sudoku1.Size = new System.Drawing.Size(299, 82);
            this.lb_sudoku1.TabIndex = 7;
            this.lb_sudoku1.Text = "Sudoku";
            this.lb_sudoku1.Click += new System.EventHandler(this.lb_sudoku1_Click);
            // 
            // lb_sudoku2
            // 
            this.lb_sudoku2.AutoSize = true;
            this.lb_sudoku2.BackColor = System.Drawing.Color.Transparent;
            this.lb_sudoku2.Font = new System.Drawing.Font("Snap ITC", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sudoku2.ForeColor = System.Drawing.Color.Navy;
            this.lb_sudoku2.Location = new System.Drawing.Point(125, 30);
            this.lb_sudoku2.Name = "lb_sudoku2";
            this.lb_sudoku2.Size = new System.Drawing.Size(299, 82);
            this.lb_sudoku2.TabIndex = 6;
            this.lb_sudoku2.Text = "Sudoku";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 500;
            // 
            // principal
            // 
            this.principal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.principal.BackColor = System.Drawing.Color.Transparent;
            this.principal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("principal.BackgroundImage")));
            this.principal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.principal.FlatAppearance.BorderSize = 0;
            this.principal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.principal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.principal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.principal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.principal.Location = new System.Drawing.Point(194, 209);
            this.principal.Margin = new System.Windows.Forms.Padding(1);
            this.principal.Name = "principal";
            this.principal.Size = new System.Drawing.Size(154, 42);
            this.principal.TabIndex = 8;
            this.principal.UseVisualStyleBackColor = false;
            this.principal.Click += new System.EventHandler(this.principal_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Red;
            this.linkLabel1.Location = new System.Drawing.Point(548, 9);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(32, 15);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Salir";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 115);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(539, 145);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(601, 286);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.principal);
            this.Controls.Add(this.lb_sudoku1);
            this.Controls.Add(this.lb_sudoku2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_sudoku1;
        private System.Windows.Forms.Label lb_sudoku2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button principal;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}