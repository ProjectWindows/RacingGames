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
            this.plNen = new System.Windows.Forms.Panel();
            this.pcbPlayer = new System.Windows.Forms.PictureBox();
            this.pcbDuong1 = new System.Windows.Forms.PictureBox();
            this.pcbDuong2 = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbDiem = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.plNen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDuong1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDuong2)).BeginInit();
            this.SuspendLayout();
            // 
            // plNen
            // 
            this.plNen.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.plNen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.plNen.Controls.Add(this.pcbPlayer);
            this.plNen.Controls.Add(this.pcbDuong1);
            this.plNen.Controls.Add(this.pcbDuong2);
            this.plNen.Location = new System.Drawing.Point(12, 12);
            this.plNen.Name = "plNen";
            this.plNen.Size = new System.Drawing.Size(561, 627);
            this.plNen.TabIndex = 0;
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
            this.pcbDuong1.Location = new System.Drawing.Point(-3, -754);
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
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Red;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Papyrus", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(650, 123);
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
            this.label1.Location = new System.Drawing.Point(618, 402);
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
            this.lbDiem.Location = new System.Drawing.Point(692, 402);
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
            // Play
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 655);
            this.Controls.Add(this.lbDiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.plNen);
            this.Name = "Play";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Play_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Play_KeyUp);
            this.plNen.ResumeLayout(false);
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
    }
}

