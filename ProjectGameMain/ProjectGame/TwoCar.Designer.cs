namespace ProjectGame
{
    partial class TwoCar
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
            this.plGame = new System.Windows.Forms.Panel();
            this.No1 = new System.Windows.Forms.PictureBox();
            this.No2 = new System.Windows.Forms.PictureBox();
            this.Food1 = new System.Windows.Forms.PictureBox();
            this.Food2 = new System.Windows.Forms.PictureBox();
            this.ptbPlayer2 = new System.Windows.Forms.PictureBox();
            this.ptbPlayer1 = new System.Windows.Forms.PictureBox();
            this.road1 = new System.Windows.Forms.PictureBox();
            this.road2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbDiem = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.plGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.No1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.No2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Food1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Food2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPlayer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.road1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.road2)).BeginInit();
            this.SuspendLayout();
            // 
            // plGame
            // 
            this.plGame.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.plGame.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.plGame.Controls.Add(this.No1);
            this.plGame.Controls.Add(this.No2);
            this.plGame.Controls.Add(this.Food1);
            this.plGame.Controls.Add(this.Food2);
            this.plGame.Controls.Add(this.ptbPlayer1);
            this.plGame.Controls.Add(this.ptbPlayer2);
            this.plGame.Controls.Add(this.road1);
            this.plGame.Location = new System.Drawing.Point(0, 0);
            this.plGame.Name = "plGame";
            this.plGame.Size = new System.Drawing.Size(340, 627);
            this.plGame.TabIndex = 0;
            // 
            // No1
            // 
            this.No1.Image = global::ProjectGame.Properties.Resources.square__3_;
            this.No1.Location = new System.Drawing.Point(102, 53);
            this.No1.Name = "No1";
            this.No1.Size = new System.Drawing.Size(30, 29);
            this.No1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.No1.TabIndex = 1;
            this.No1.TabStop = false;
            // 
            // No2
            // 
            this.No2.Image = global::ProjectGame.Properties.Resources.square__3_;
            this.No2.Location = new System.Drawing.Point(276, 53);
            this.No2.Name = "No2";
            this.No2.Size = new System.Drawing.Size(30, 29);
            this.No2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.No2.TabIndex = 1;
            this.No2.TabStop = false;
            // 
            // Food1
            // 
            this.Food1.BackColor = System.Drawing.Color.Transparent;
            this.Food1.Image = global::ProjectGame.Properties.Resources.trontim;
            this.Food1.Location = new System.Drawing.Point(24, 53);
            this.Food1.Name = "Food1";
            this.Food1.Size = new System.Drawing.Size(30, 29);
            this.Food1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Food1.TabIndex = 2;
            this.Food1.TabStop = false;
            // 
            // Food2
            // 
            this.Food2.BackColor = System.Drawing.Color.Transparent;
            this.Food2.Image = global::ProjectGame.Properties.Resources.trontim;
            this.Food2.Location = new System.Drawing.Point(193, 53);
            this.Food2.Name = "Food2";
            this.Food2.Size = new System.Drawing.Size(30, 29);
            this.Food2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Food2.TabIndex = 2;
            this.Food2.TabStop = false;
            // 
            // ptbPlayer2
            // 
            this.ptbPlayer2.BackColor = System.Drawing.Color.Transparent;
            this.ptbPlayer2.Image = global::ProjectGame.Properties.Resources.carGrey;
            this.ptbPlayer2.Location = new System.Drawing.Point(102, 300);
            this.ptbPlayer2.Name = "ptbPlayer2";
            this.ptbPlayer2.Size = new System.Drawing.Size(42, 82);
            this.ptbPlayer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbPlayer2.TabIndex = 2;
            this.ptbPlayer2.TabStop = false;
            // 
            // ptbPlayer1
            // 
            this.ptbPlayer1.BackColor = System.Drawing.Color.Transparent;
            this.ptbPlayer1.Image = global::ProjectGame.Properties.Resources.carGrey;
            this.ptbPlayer1.Location = new System.Drawing.Point(276, 300);
            this.ptbPlayer1.Name = "ptbPlayer1";
            this.ptbPlayer1.Size = new System.Drawing.Size(42, 82);
            this.ptbPlayer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbPlayer1.TabIndex = 2;
            this.ptbPlayer1.TabStop = false;
            // 
            // road1
            // 
            this.road1.BackColor = System.Drawing.Color.Transparent;
            this.road1.Image = global::ProjectGame.Properties.Resources.road2;
            this.road1.Location = new System.Drawing.Point(-2, -142);
            this.road1.Name = "road1";
            this.road1.Size = new System.Drawing.Size(340, 800);
            this.road1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.road1.TabIndex = 0;
            this.road1.TabStop = false;
            // 
            // road2
            // 
            this.road2.BackColor = System.Drawing.Color.Transparent;
            this.road2.Image = global::ProjectGame.Properties.Resources.road2;
            this.road2.Location = new System.Drawing.Point(-2, -700);
            this.road2.Name = "road2";
            this.road2.Size = new System.Drawing.Size(340, 550);
            this.road2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.road2.TabIndex = 0;
            this.road2.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbDiem
            // 
            this.lbDiem.AutoSize = true;
            this.lbDiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbDiem.Font = new System.Drawing.Font("Papyrus", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiem.Location = new System.Drawing.Point(453, 124);
            this.lbDiem.Name = "lbDiem";
            this.lbDiem.Size = new System.Drawing.Size(37, 30);
            this.lbDiem.TabIndex = 5;
            this.lbDiem.Text = "00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Papyrus", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(379, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Điểm :";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Papyrus", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnStart.Location = new System.Drawing.Point(349, 169);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(200, 54);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = false;
            // 
            // TwoCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 724);
            this.Controls.Add(this.lbDiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.plGame);
            this.Controls.Add(this.road2);
            this.Name = "TwoCar";
            this.Text = "TwoCar";
            this.Load += new System.EventHandler(this.TwoCar_Load);
            this.plGame.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.No1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.No2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Food1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Food2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPlayer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.road1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.road2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel plGame;
        private System.Windows.Forms.PictureBox road2;
        private System.Windows.Forms.PictureBox No2;
        private System.Windows.Forms.PictureBox ptbPlayer1;
        private System.Windows.Forms.PictureBox road1;
        private System.Windows.Forms.PictureBox Food2;
        private System.Windows.Forms.PictureBox ptbPlayer2;
        private System.Windows.Forms.PictureBox No1;
        private System.Windows.Forms.PictureBox Food1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbDiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStart;
    }
}