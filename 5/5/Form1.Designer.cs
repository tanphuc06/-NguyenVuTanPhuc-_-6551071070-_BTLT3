namespace _5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtNhapTen = new TextBox();
            groupBox1 = new GroupBox();
            chkUnderline = new CheckBox();
            chkItalic = new CheckBox();
            chkBold = new CheckBox();
            groupBox2 = new GroupBox();
            radBlue = new RadioButton();
            radBlack = new RadioButton();
            radGreen = new RadioButton();
            radRed = new RadioButton();
            label2 = new Label();
            lblLapTrinh = new TextBox();
            btnThoat = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.ForeColor = Color.Lime;
            label1.Location = new Point(142, 35);
            label1.Name = "label1";
            label1.Size = new Size(98, 31);
            label1.TabIndex = 0;
            label1.Text = "Nhập Tên: ";
            // 
            // txtNhapTen
            // 
            txtNhapTen.Location = new Point(246, 32);
            txtNhapTen.Name = "txtNhapTen";
            txtNhapTen.Size = new Size(416, 31);
            txtNhapTen.TabIndex = 1;
            txtNhapTen.TextChanged += txtNhapTen_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(255, 224, 192);
            groupBox1.Controls.Add(chkUnderline);
            groupBox1.Controls.Add(chkItalic);
            groupBox1.Controls.Add(chkBold);
            groupBox1.Location = new Point(480, 119);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(241, 206);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Font";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // chkUnderline
            // 
            chkUnderline.AutoSize = true;
            chkUnderline.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline);
            chkUnderline.ForeColor = Color.Blue;
            chkUnderline.Location = new Point(27, 152);
            chkUnderline.Name = "chkUnderline";
            chkUnderline.Size = new Size(127, 29);
            chkUnderline.TabIndex = 2;
            chkUnderline.Text = "Gạch chân";
            chkUnderline.UseVisualStyleBackColor = true;
            chkUnderline.CheckedChanged += chkUnderline_CheckedChanged_1;
            // 
            // chkItalic
            // 
            chkItalic.AutoSize = true;
            chkItalic.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            chkItalic.ForeColor = Color.Blue;
            chkItalic.Location = new Point(27, 99);
            chkItalic.Name = "chkItalic";
            chkItalic.Size = new Size(160, 29);
            chkItalic.TabIndex = 1;
            chkItalic.Text = "Nghiêng Italic";
            chkItalic.UseVisualStyleBackColor = true;
            chkItalic.CheckedChanged += chkItalic_CheckedChanged_1;
            // 
            // chkBold
            // 
            chkBold.AutoSize = true;
            chkBold.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            chkBold.ForeColor = Color.Blue;
            chkBold.Location = new Point(27, 41);
            chkBold.Name = "chkBold";
            chkBold.Size = new Size(121, 29);
            chkBold.TabIndex = 0;
            chkBold.Text = "Đậm Bold";
            chkBold.UseVisualStyleBackColor = true;
            chkBold.CheckedChanged += chkBold_CheckedChanged_1;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ActiveCaption;
            groupBox2.Controls.Add(radBlue);
            groupBox2.Controls.Add(radBlack);
            groupBox2.Controls.Add(radGreen);
            groupBox2.Controls.Add(radRed);
            groupBox2.Location = new Point(142, 119);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(222, 206);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Color";
            // 
            // radBlue
            // 
            radBlue.AutoSize = true;
            radBlue.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            radBlue.ForeColor = Color.Cyan;
            radBlue.Location = new Point(6, 117);
            radBlue.Name = "radBlue";
            radBlue.Size = new Size(75, 29);
            radBlue.TabIndex = 3;
            radBlue.TabStop = true;
            radBlue.Text = "Blue";
            radBlue.UseVisualStyleBackColor = true;
            radBlue.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // radBlack
            // 
            radBlack.AutoSize = true;
            radBlack.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            radBlack.Location = new Point(6, 152);
            radBlack.Name = "radBlack";
            radBlack.Size = new Size(83, 29);
            radBlack.TabIndex = 2;
            radBlack.TabStop = true;
            radBlack.Text = "Black";
            radBlack.UseVisualStyleBackColor = true;
            radBlack.CheckedChanged += radBlack_CheckedChanged_1;
            // 
            // radGreen
            // 
            radGreen.AutoSize = true;
            radGreen.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            radGreen.ForeColor = Color.Lime;
            radGreen.Location = new Point(6, 75);
            radGreen.Name = "radGreen";
            radGreen.Size = new Size(88, 29);
            radGreen.TabIndex = 1;
            radGreen.TabStop = true;
            radGreen.Text = "Green";
            radGreen.UseVisualStyleBackColor = true;
            radGreen.CheckedChanged += radGreen_CheckedChanged;
            // 
            // radRed
            // 
            radRed.AutoSize = true;
            radRed.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            radRed.ForeColor = Color.Red;
            radRed.Location = new Point(6, 40);
            radRed.Name = "radRed";
            radRed.Size = new Size(70, 29);
            radRed.TabIndex = 0;
            radRed.TabStop = true;
            radRed.Text = "Red";
            radRed.UseVisualStyleBackColor = true;
            radRed.CheckedChanged += radRed_CheckedChanged;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.ForeColor = Color.Red;
            label2.Location = new Point(142, 361);
            label2.Name = "label2";
            label2.Size = new Size(131, 31);
            label2.TabIndex = 4;
            label2.Text = "Lập Trình Bởi: ";
            // 
            // lblLapTrinh
            // 
            lblLapTrinh.ForeColor = Color.Lime;
            lblLapTrinh.Location = new Point(279, 361);
            lblLapTrinh.Name = "lblLapTrinh";
            lblLapTrinh.Size = new Size(280, 31);
            lblLapTrinh.TabIndex = 5;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(599, 334);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(112, 85);
            btnThoat.TabIndex = 6;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(800, 450);
            Controls.Add(btnThoat);
            Controls.Add(lblLapTrinh);
            Controls.Add(label2);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(txtNhapTen);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Định Dạng (Formater)";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNhapTen;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private RadioButton radBlue;
        private RadioButton radBlack;
        private RadioButton radGreen;
        private RadioButton radRed;
        private CheckBox chkUnderline;
        private CheckBox chkItalic;
        private CheckBox chkBold;
        private Label label2;
        private TextBox lblLapTrinh;
        private Button btnThoat;
    }
}
