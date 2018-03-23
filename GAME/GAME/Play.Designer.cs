namespace GAME
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbCachChoi = new System.Windows.Forms.Label();
            this.txtDiem = new System.Windows.Forms.TextBox();
            this.lbDiem = new System.Windows.Forms.Label();
            this.plAnh = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBegin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.plCC = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.plAnh.SuspendLayout();
            this.plCC.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.plCC);
            this.panel1.Controls.Add(this.txtDiem);
            this.panel1.Controls.Add(this.lbDiem);
            this.panel1.Controls.Add(this.plAnh);
            this.panel1.Controls.Add(this.btnBegin);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 506);
            this.panel1.TabIndex = 0;
            // 
            // lbCachChoi
            // 
            this.lbCachChoi.AutoSize = true;
            this.lbCachChoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCachChoi.Location = new System.Drawing.Point(3, 13);
            this.lbCachChoi.Name = "lbCachChoi";
            this.lbCachChoi.Size = new System.Drawing.Size(49, 19);
            this.lbCachChoi.TabIndex = 1;
            this.lbCachChoi.Text = "label2";
            // 
            // txtDiem
            // 
            this.txtDiem.Location = new System.Drawing.Point(80, 325);
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.Size = new System.Drawing.Size(134, 20);
            this.txtDiem.TabIndex = 2;
            // 
            // lbDiem
            // 
            this.lbDiem.AutoSize = true;
            this.lbDiem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiem.Location = new System.Drawing.Point(11, 322);
            this.lbDiem.Name = "lbDiem";
            this.lbDiem.Size = new System.Drawing.Size(63, 22);
            this.lbDiem.TabIndex = 1;
            this.lbDiem.Text = "Điểm :";
            // 
            // plAnh
            // 
            this.plAnh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("plAnh.BackgroundImage")));
            this.plAnh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.plAnh.Controls.Add(this.label1);
            this.plAnh.Location = new System.Drawing.Point(3, 3);
            this.plAnh.Name = "plAnh";
            this.plAnh.Size = new System.Drawing.Size(231, 158);
            this.plAnh.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // btnBegin
            // 
            this.btnBegin.BackColor = System.Drawing.Color.Aqua;
            this.btnBegin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBegin.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBegin.Location = new System.Drawing.Point(0, 377);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.Size = new System.Drawing.Size(234, 56);
            this.btnBegin.TabIndex = 1;
            this.btnBegin.Text = "BEGIN";
            this.btnBegin.UseVisualStyleBackColor = false;
            this.btnBegin.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Aqua;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(0, 439);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(234, 56);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 400;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // plCC
            // 
            this.plCC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.plCC.Controls.Add(this.lbCachChoi);
            this.plCC.Location = new System.Drawing.Point(3, 167);
            this.plCC.Name = "plCC";
            this.plCC.Size = new System.Drawing.Size(228, 138);
            this.plCC.TabIndex = 2;
            // 
            // Play
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 509);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Play";
            this.Text = "Play";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Play_FormClosed);
            this.Load += new System.EventHandler(this.Play_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.plAnh.ResumeLayout(false);
            this.plAnh.PerformLayout();
            this.plCC.ResumeLayout(false);
            this.plCC.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel plAnh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbDiem;
        private System.Windows.Forms.Button btnBegin;
        private System.Windows.Forms.TextBox txtDiem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbCachChoi;
        private System.Windows.Forms.Panel plCC;
    }
}