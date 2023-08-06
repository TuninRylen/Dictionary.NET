namespace Dictionary
{
    partial class FormViewer
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
            this.txt_WordEngAc = new System.Windows.Forms.TextBox();
            this.txt_WordEng = new System.Windows.Forms.TextBox();
            this.txt_WordTrAc = new System.Windows.Forms.TextBox();
            this.txt_WordTr = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_WordEngAc
            // 
            this.txt_WordEngAc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_WordEngAc.Location = new System.Drawing.Point(6, 99);
            this.txt_WordEngAc.Multiline = true;
            this.txt_WordEngAc.Name = "txt_WordEngAc";
            this.txt_WordEngAc.ReadOnly = true;
            this.txt_WordEngAc.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_WordEngAc.Size = new System.Drawing.Size(448, 118);
            this.txt_WordEngAc.TabIndex = 11;
            // 
            // txt_WordEng
            // 
            this.txt_WordEng.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_WordEng.Location = new System.Drawing.Point(6, 30);
            this.txt_WordEng.Multiline = true;
            this.txt_WordEng.Name = "txt_WordEng";
            this.txt_WordEng.ReadOnly = true;
            this.txt_WordEng.Size = new System.Drawing.Size(448, 47);
            this.txt_WordEng.TabIndex = 10;
            // 
            // txt_WordTrAc
            // 
            this.txt_WordTrAc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_WordTrAc.Location = new System.Drawing.Point(6, 100);
            this.txt_WordTrAc.Multiline = true;
            this.txt_WordTrAc.Name = "txt_WordTrAc";
            this.txt_WordTrAc.ReadOnly = true;
            this.txt_WordTrAc.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_WordTrAc.Size = new System.Drawing.Size(448, 118);
            this.txt_WordTrAc.TabIndex = 9;
            // 
            // txt_WordTr
            // 
            this.txt_WordTr.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_WordTr.Location = new System.Drawing.Point(6, 35);
            this.txt_WordTr.Multiline = true;
            this.txt_WordTr.Name = "txt_WordTr";
            this.txt_WordTr.ReadOnly = true;
            this.txt_WordTr.Size = new System.Drawing.Size(448, 47);
            this.txt_WordTr.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(16, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(440, 430);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_WordTr);
            this.groupBox1.Controls.Add(this.txt_WordTrAc);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(15, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(466, 234);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Türkçe Kelime ve Anlamı";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_WordEng);
            this.groupBox2.Controls.Add(this.txt_WordEngAc);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(15, 283);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(466, 230);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "English Word And Meaning";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(487, 43);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(470, 470);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Picture-Resim";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 529);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 39);
            this.button1.TabIndex = 15;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(969, 580);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormViewer";
            this.Text = "FormViewer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormViewer_FormClosed);
            this.Load += new System.EventHandler(this.FormViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_WordEngAc;
        private System.Windows.Forms.TextBox txt_WordEng;
        private System.Windows.Forms.TextBox txt_WordTrAc;
        private System.Windows.Forms.TextBox txt_WordTr;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
    }
}