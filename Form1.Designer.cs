namespace CSharp_giaiphuongtrinhbac2
{
    partial class Form1
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
            this.lblnhapa = new System.Windows.Forms.Label();
            this.txta = new System.Windows.Forms.TextBox();
            this.txtb = new System.Windows.Forms.TextBox();
            this.lblnhapb = new System.Windows.Forms.Label();
            this.btngiaiphuongtrinh = new System.Windows.Forms.Button();
            this.lsbketqua = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtc = new System.Windows.Forms.TextBox();
            this.lblnhapc = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.lblketqua = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblnhapa
            // 
            this.lblnhapa.AutoSize = true;
            this.lblnhapa.Location = new System.Drawing.Point(62, 97);
            this.lblnhapa.Name = "lblnhapa";
            this.lblnhapa.Size = new System.Drawing.Size(42, 13);
            this.lblnhapa.TabIndex = 0;
            this.lblnhapa.Text = "Nhập a";
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(171, 90);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(100, 20);
            this.txta.TabIndex = 1;
            // 
            // txtb
            // 
            this.txtb.Location = new System.Drawing.Point(171, 155);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(100, 20);
            this.txtb.TabIndex = 3;
            // 
            // lblnhapb
            // 
            this.lblnhapb.AutoSize = true;
            this.lblnhapb.Location = new System.Drawing.Point(62, 158);
            this.lblnhapb.Name = "lblnhapb";
            this.lblnhapb.Size = new System.Drawing.Size(42, 13);
            this.lblnhapb.TabIndex = 2;
            this.lblnhapb.Text = "Nhập b";
            // 
            // btngiaiphuongtrinh
            // 
            this.btngiaiphuongtrinh.Location = new System.Drawing.Point(316, 263);
            this.btngiaiphuongtrinh.Name = "btngiaiphuongtrinh";
            this.btngiaiphuongtrinh.Size = new System.Drawing.Size(145, 35);
            this.btngiaiphuongtrinh.TabIndex = 4;
            this.btngiaiphuongtrinh.Text = "giải phương trình";
            this.btngiaiphuongtrinh.UseVisualStyleBackColor = true;
            this.btngiaiphuongtrinh.Click += new System.EventHandler(this.btngiaiphuongtrinh_Click);
            // 
            // lsbketqua
            // 
            this.lsbketqua.BackColor = System.Drawing.SystemColors.Window;
            this.lsbketqua.FormattingEnabled = true;
            this.lsbketqua.Location = new System.Drawing.Point(65, 314);
            this.lsbketqua.Name = "lsbketqua";
            this.lsbketqua.Size = new System.Drawing.Size(586, 108);
            this.lsbketqua.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(230, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(346, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "ứng dụng giải phương trinh bậc 2";
            // 
            // txtc
            // 
            this.txtc.Location = new System.Drawing.Point(171, 235);
            this.txtc.Name = "txtc";
            this.txtc.Size = new System.Drawing.Size(100, 20);
            this.txtc.TabIndex = 10;
            // 
            // lblnhapc
            // 
            this.lblnhapc.AutoSize = true;
            this.lblnhapc.Location = new System.Drawing.Point(61, 235);
            this.lblnhapc.Name = "lblnhapc";
            this.lblnhapc.Size = new System.Drawing.Size(42, 13);
            this.lblnhapc.TabIndex = 9;
            this.lblnhapc.Text = "Nhập c";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(342, 90);
            this.trackBar1.Minimum = -10;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(317, 45);
            this.trackBar1.TabIndex = 11;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(342, 155);
            this.trackBar2.Minimum = -10;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(317, 45);
            this.trackBar2.TabIndex = 12;
            this.trackBar2.Scroll += new System.EventHandler(this.txtb_Scroll);
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(342, 212);
            this.trackBar3.Minimum = -10;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(317, 45);
            this.trackBar3.TabIndex = 13;
            this.trackBar3.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(338, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 21);
            this.label5.TabIndex = 14;
            this.label5.Text = " ax2 + bx + c = 0";
            // 
            // lblketqua
            // 
            this.lblketqua.AutoSize = true;
            this.lblketqua.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblketqua.Location = new System.Drawing.Point(62, 314);
            this.lblketqua.Name = "lblketqua";
            this.lblketqua.Size = new System.Drawing.Size(56, 16);
            this.lblketqua.TabIndex = 15;
            this.lblketqua.Text = "kết quả ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(800, 492);
            this.Controls.Add(this.lblketqua);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.trackBar3);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.txtc);
            this.Controls.Add(this.lblnhapc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lsbketqua);
            this.Controls.Add(this.btngiaiphuongtrinh);
            this.Controls.Add(this.txtb);
            this.Controls.Add(this.lblnhapb);
            this.Controls.Add(this.txta);
            this.Controls.Add(this.lblnhapa);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnhapa;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.Label lblnhapb;
        private System.Windows.Forms.Button btngiaiphuongtrinh;
        private System.Windows.Forms.ListBox lsbketqua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtc;
        private System.Windows.Forms.Label lblnhapc;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblketqua;
    }
}

