namespace _3
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
            label2 = new Label();
            btnHo = new Button();
            txtHo = new TextBox();
            txtTen = new TextBox();
            button2 = new Button();
            btnHoTen = new Button();
            btnKetThuc = new Button();
            lblHoTen = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(172, 120);
            label1.Name = "label1";
            label1.Size = new Size(71, 25);
            label1.TabIndex = 0;
            label1.Text = "Họ lót: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(172, 175);
            label2.Name = "label2";
            label2.Size = new Size(47, 25);
            label2.TabIndex = 1;
            label2.Text = "Tên: ";
            label2.Click += label2_Click;
            // 
            // btnHo
            // 
            btnHo.Location = new Point(172, 248);
            btnHo.Name = "btnHo";
            btnHo.Size = new Size(101, 39);
            btnHo.TabIndex = 2;
            btnHo.Text = "Họ Lót";
            btnHo.UseVisualStyleBackColor = true;
            btnHo.Click += button1_Click;
            // 
            // txtHo
            // 
            txtHo.Location = new Point(263, 120);
            txtHo.Name = "txtHo";
            txtHo.Size = new Size(393, 31);
            txtHo.TabIndex = 4;
            // 
            // txtTen
            // 
            txtTen.BackColor = Color.MistyRose;
            txtTen.Location = new Point(263, 175);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(393, 31);
            txtTen.TabIndex = 5;
            // 
            // button2
            // 
            button2.Location = new Point(354, 248);
            button2.Name = "button2";
            button2.Size = new Size(123, 39);
            button2.TabIndex = 6;
            button2.Text = "Tên";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnHoTen
            // 
            btnHoTen.Location = new Point(555, 248);
            btnHoTen.Name = "btnHoTen";
            btnHoTen.Size = new Size(101, 39);
            btnHoTen.TabIndex = 7;
            btnHoTen.Text = "Họ và Tên";
            btnHoTen.UseVisualStyleBackColor = true;
            btnHoTen.Click += button3_Click;
            // 
            // btnKetThuc
            // 
            btnKetThuc.Location = new Point(301, 334);
            btnKetThuc.Name = "btnKetThuc";
            btnKetThuc.Size = new Size(234, 47);
            btnKetThuc.TabIndex = 8;
            btnKetThuc.Text = "Thoát Chương Trình";
            btnKetThuc.UseVisualStyleBackColor = true;
            btnKetThuc.Click += btnKetThuc_Click;
            // 
            // lblHoTen
            // 
            lblHoTen.BackColor = SystemColors.Highlight;
            lblHoTen.ForeColor = SystemColors.ControlLightLight;
            lblHoTen.Location = new Point(-1, -3);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(799, 120);
            lblHoTen.TabIndex = 9;
            lblHoTen.Click += lblHoTen_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblHoTen);
            Controls.Add(btnKetThuc);
            Controls.Add(btnHoTen);
            Controls.Add(button2);
            Controls.Add(txtTen);
            Controls.Add(txtHo);
            Controls.Add(btnHo);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnHo;
        private TextBox txtHo;
        private TextBox txtTen;
        private Button button2;
        private Button btnHoTen;
        private Button btnKetThuc;
        private Label lblHoTen;
    }
}
