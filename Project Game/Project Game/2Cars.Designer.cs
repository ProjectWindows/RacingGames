namespace Project_Game
{
    partial class _2Cars
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_2Cars));
            this.plNen = new System.Windows.Forms.Panel();
            this.pcbDuong2 = new System.Windows.Forms.PictureBox();
            this.pcbDuong1 = new System.Windows.Forms.PictureBox();
            this.plNen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDuong2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDuong1)).BeginInit();
            this.SuspendLayout();
            // 
            // plNen
            // 
            this.plNen.BackColor = System.Drawing.Color.DarkGray;
            this.plNen.Controls.Add(this.pcbDuong2);
            this.plNen.Controls.Add(this.pcbDuong1);
            this.plNen.Location = new System.Drawing.Point(12, 12);
            this.plNen.Name = "plNen";
            this.plNen.Size = new System.Drawing.Size(380, 424);
            this.plNen.TabIndex = 0;
            // 
            // pcbDuong2
            // 
            this.pcbDuong2.Image = ((System.Drawing.Image)(resources.GetObject("pcbDuong2.Image")));
            this.pcbDuong2.Location = new System.Drawing.Point(-3, -222);
            this.pcbDuong2.Name = "pcbDuong2";
            this.pcbDuong2.Size = new System.Drawing.Size(385, 632);
            this.pcbDuong2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbDuong2.TabIndex = 0;
            this.pcbDuong2.TabStop = false;
            // 
            // pcbDuong1
            // 
            this.pcbDuong1.Image = ((System.Drawing.Image)(resources.GetObject("pcbDuong1.Image")));
            this.pcbDuong1.Location = new System.Drawing.Point(-2, -638);
            this.pcbDuong1.Name = "pcbDuong1";
            this.pcbDuong1.Size = new System.Drawing.Size(385, 632);
            this.pcbDuong1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbDuong1.TabIndex = 0;
            this.pcbDuong1.TabStop = false;
            // 
            // _2Cars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 512);
            this.Controls.Add(this.plNen);
            this.Name = "_2Cars";
            this.Text = "_2Cars";
            this.plNen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbDuong2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDuong1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plNen;
        private System.Windows.Forms.PictureBox pcbDuong2;
        private System.Windows.Forms.PictureBox pcbDuong1;
    }
}