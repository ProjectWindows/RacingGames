namespace ProjectGame
{
    partial class Play
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Play));
            this.plNen = new System.Windows.Forms.Panel();
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbDiem = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TocDo = new System.Windows.Forms.Timer(this.components);
            this.pgbTocDo = new System.Windows.Forms.ProgressBar();
            this.chay = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.lbTocDo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pcbXe1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pcbPlayer = new System.Windows.Forms.PictureBox();
            this.pcbDuong1 = new System.Windows.Forms.PictureBox();
            this.pcbDuong2 = new System.Windows.Forms.PictureBox();
            this.plNen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbXe1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDuong1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDuong2)).BeginInit();
            this.SuspendLayout();
            // 
            // plNen
            // 
            this.plNen.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.plNen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.plNen.Controls.Add(this.pcbXe1);
            this.plNen.Controls.Add(this.pictureBox1);
            this.plNen.Controls.Add(this.pcbPlayer);
            this.plNen.Controls.Add(this.pcbDuong1);
            this.plNen.Controls.Add(this.pcbDuong2);
            this.plNen.Location = new System.Drawing.Point(12, 12);
            this.plNen.Name = "plNen";
            this.plNen.Size = new System.Drawing.Size(561, 627);
            this.plNen.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Red;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Papyrus", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(651, 571);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(124, 54);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Papyrus", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(659, 508);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Điểm :";
            // 
            // lbDiem
            // 
            this.lbDiem.AutoSize = true;
            this.lbDiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbDiem.Font = new System.Drawing.Font("Papyrus", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiem.Location = new System.Drawing.Point(733, 508);
            this.lbDiem.Name = "lbDiem";
            this.lbDiem.Size = new System.Drawing.Size(37, 30);
            this.lbDiem.TabIndex = 2;
            this.lbDiem.Text = "00";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TocDo
            // 
            this.TocDo.Interval = 1000;
            this.TocDo.Tick += new System.EventHandler(this.TocDo_Tick);
            // 
            // pgbTocDo
            // 
            this.pgbTocDo.Location = new System.Drawing.Point(688, 454);
            this.pgbTocDo.Name = "pgbTocDo";
            this.pgbTocDo.Size = new System.Drawing.Size(100, 23);
            this.pgbTocDo.TabIndex = 5;
            // 
            // chay
            // 
            this.chay.Enabled = true;
            this.chay.Interval = 500;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(635, 402);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tốc Độ :";
            // 
            // lbTocDo
            // 
            this.lbTocDo.AutoSize = true;
            this.lbTocDo.BackColor = System.Drawing.Color.Red;
            this.lbTocDo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lbTocDo.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTocDo.Location = new System.Drawing.Point(733, 402);
            this.lbTocDo.Name = "lbTocDo";
            this.lbTocDo.Size = new System.Drawing.Size(32, 25);
            this.lbTocDo.TabIndex = 6;
            this.lbTocDo.Text = "00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(771, 402);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "km/h";
            // 
            // pcbXe1
            // 
            this.pcbXe1.Image = global::ProjectGame.Properties.Resources.Police;
            this.pcbXe1.Location = new System.Drawing.Point(79, 33);
            this.pcbXe1.Name = "pcbXe1";
            this.pcbXe1.Size = new System.Drawing.Size(50, 100);
            this.pcbXe1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbXe1.TabIndex = 3;
            this.pcbXe1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(340, 295);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pcbPlayer
            // 
            this.pcbPlayer.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pcbPlayer.Image = global::ProjectGame.Properties.Resources.carOrange;
            this.pcbPlayer.Location = new System.Drawing.Point(249, 494);
            this.pcbPlayer.Name = "pcbPlayer";
            this.pcbPlayer.Size = new System.Drawing.Size(50, 100);
            this.pcbPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbPlayer.TabIndex = 1;
            this.pcbPlayer.TabStop = false;
            // 
            // pcbDuong1
            // 
            this.pcbDuong1.Image = global::ProjectGame.Properties.Resources.Road;
            this.pcbDuong1.Location = new System.Drawing.Point(-3, -808);
            this.pcbDuong1.Name = "pcbDuong1";
            this.pcbDuong1.Size = new System.Drawing.Size(562, 800);
            this.pcbDuong1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbDuong1.TabIndex = 0;
            this.pcbDuong1.TabStop = false;
            // 
            // pcbDuong2
            // 
            this.pcbDuong2.Image = global::ProjectGame.Properties.Resources.Road;
            this.pcbDuong2.Location = new System.Drawing.Point(-3, -142);
            this.pcbDuong2.Name = "pcbDuong2";
            this.pcbDuong2.Size = new System.Drawing.Size(562, 800);
            this.pcbDuong2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbDuong2.TabIndex = 0;
            this.pcbDuong2.TabStop = false;
            // 
            // Play
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 655);
            this.Controls.Add(this.lbTocDo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pgbTocDo);
            this.Controls.Add(this.lbDiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.plNen);
            this.Name = "Play";
            this.Load += new System.EventHandler(this.Play_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Play_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Play_KeyUp);
            this.plNen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbXe1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDuong1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDuong2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel plNen;
        private System.Windows.Forms.PictureBox pcbDuong2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbDiem;
        private System.Windows.Forms.PictureBox pcbPlayer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pcbDuong1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer TocDo;
        private System.Windows.Forms.ProgressBar pgbTocDo;
        private System.Windows.Forms.Timer chay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTocDo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pcbXe1;
    }
}

