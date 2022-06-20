namespace QLBanSim
{
    partial class Form_ChiTietHoaDon
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
            this.button1 = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.frmcthd_masim = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dgv_ctdh = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ctdh)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(178, 440);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Xác nhận";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Red;
            this.label18.Location = new System.Drawing.Point(116, 7);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(223, 25);
            this.label18.TabIndex = 9;
            this.label18.Text = "CHI TIẾT HÓA ĐƠN";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // frmcthd_masim
            // 
            this.frmcthd_masim.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmcthd_masim.Location = new System.Drawing.Point(82, 48);
            this.frmcthd_masim.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.frmcthd_masim.Name = "frmcthd_masim";
            this.frmcthd_masim.Size = new System.Drawing.Size(101, 24);
            this.frmcthd_masim.TabIndex = 26;
            this.frmcthd_masim.TextChanged += new System.EventHandler(this.textBox16_TextChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(26, 50);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(57, 17);
            this.label23.TabIndex = 25;
            this.label23.Text = "Mã Sim:";
            this.label23.Click += new System.EventHandler(this.label23_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(214, 45);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(51, 29);
            this.button2.TabIndex = 27;
            this.button2.Text = "Thêm";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgv_ctdh
            // 
            this.dgv_ctdh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ctdh.Location = new System.Drawing.Point(28, 88);
            this.dgv_ctdh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_ctdh.Name = "dgv_ctdh";
            this.dgv_ctdh.RowHeadersWidth = 51;
            this.dgv_ctdh.RowTemplate.Height = 24;
            this.dgv_ctdh.Size = new System.Drawing.Size(362, 313);
            this.dgv_ctdh.TabIndex = 28;
            this.dgv_ctdh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ctdh_CellClick);
            this.dgv_ctdh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ctdh_CellContentClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(280, 45);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(51, 29);
            this.button3.TabIndex = 29;
            this.button3.Text = "Sửa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(347, 45);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(51, 29);
            this.button4.TabIndex = 30;
            this.button4.Text = "Xóa";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form_ChiTietHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 483);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dgv_ctdh);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.frmcthd_masim);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form_ChiTietHoaDon";
            this.Text = "Form_ChiTietHoaDon";
            this.Load += new System.EventHandler(this.Form_ChiTietHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ctdh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox frmcthd_masim;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgv_ctdh;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}