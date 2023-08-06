namespace Dictionary
{
    partial class Add
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_WordEng = new System.Windows.Forms.TextBox();
            this.txt_WordEngAc = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_WordTr = new System.Windows.Forms.TextBox();
            this.txt_WordTrAc = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_FileLoad = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 517);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 41);
            this.button1.TabIndex = 24;
            this.button1.Text = "Geri";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(502, 14);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(453, 436);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Picture-Resim";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(16, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(420, 391);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_WordEng);
            this.groupBox2.Controls.Add(this.txt_WordEngAc);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(13, 254);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(466, 230);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "English Word And Meaning";
            // 
            // txt_WordEng
            // 
            this.txt_WordEng.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_WordEng.Location = new System.Drawing.Point(6, 30);
            this.txt_WordEng.Multiline = true;
            this.txt_WordEng.Name = "txt_WordEng";
            this.txt_WordEng.Size = new System.Drawing.Size(448, 47);
            this.txt_WordEng.TabIndex = 10;
            // 
            // txt_WordEngAc
            // 
            this.txt_WordEngAc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_WordEngAc.Location = new System.Drawing.Point(6, 99);
            this.txt_WordEngAc.Multiline = true;
            this.txt_WordEngAc.Name = "txt_WordEngAc";
            this.txt_WordEngAc.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_WordEngAc.Size = new System.Drawing.Size(448, 118);
            this.txt_WordEngAc.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_WordTr);
            this.groupBox1.Controls.Add(this.txt_WordTrAc);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(13, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(466, 234);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Türkçe Kelime ve Anlamı";
            // 
            // txt_WordTr
            // 
            this.txt_WordTr.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_WordTr.Location = new System.Drawing.Point(6, 35);
            this.txt_WordTr.Multiline = true;
            this.txt_WordTr.Name = "txt_WordTr";
            this.txt_WordTr.Size = new System.Drawing.Size(448, 47);
            this.txt_WordTr.TabIndex = 8;
            // 
            // txt_WordTrAc
            // 
            this.txt_WordTrAc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_WordTrAc.Location = new System.Drawing.Point(6, 100);
            this.txt_WordTrAc.Multiline = true;
            this.txt_WordTrAc.Name = "txt_WordTrAc";
            this.txt_WordTrAc.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_WordTrAc.Size = new System.Drawing.Size(448, 118);
            this.txt_WordTrAc.TabIndex = 9;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(357, 508);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(268, 58);
            this.btn_Save.TabIndex = 20;
            this.btn_Save.Text = "Ekle";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_FileLoad
            // 
            this.btn_FileLoad.Location = new System.Drawing.Point(639, 449);
            this.btn_FileLoad.Name = "btn_FileLoad";
            this.btn_FileLoad.Size = new System.Drawing.Size(185, 35);
            this.btn_FileLoad.TabIndex = 19;
            this.btn_FileLoad.Text = "Resim Yükle";
            this.btn_FileLoad.UseVisualStyleBackColor = true;
            this.btn_FileLoad.Click += new System.EventHandler(this.btn_FileLoad_Click);
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(969, 580);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_FileLoad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Add";
            this.Text = "Add";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Add_FormClosing);
            this.Load += new System.EventHandler(this.Add_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_WordEng;
        private System.Windows.Forms.TextBox txt_WordEngAc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_WordTr;
        private System.Windows.Forms.TextBox txt_WordTrAc;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_FileLoad;
    }
}