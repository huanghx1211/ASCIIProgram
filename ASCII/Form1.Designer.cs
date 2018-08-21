namespace ASCII
{
    partial class Frm_Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_char = new System.Windows.Forms.TextBox();
            this.txt_ASCII = new System.Windows.Forms.TextBox();
            this.txt_ASCII2 = new System.Windows.Forms.TextBox();
            this.txt_char2 = new System.Windows.Forms.TextBox();
            this.btn_ToASCII = new System.Windows.Forms.Button();
            this.btn_ToChar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_ToChar);
            this.groupBox1.Controls.Add(this.btn_ToASCII);
            this.groupBox1.Controls.Add(this.txt_char2);
            this.groupBox1.Controls.Add(this.txt_ASCII2);
            this.groupBox1.Controls.Add(this.txt_ASCII);
            this.groupBox1.Controls.Add(this.txt_char);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 124);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "字母与ASCII相互转换";
            // 
            // txt_char
            // 
            this.txt_char.Location = new System.Drawing.Point(25, 30);
            this.txt_char.Name = "txt_char";
            this.txt_char.Size = new System.Drawing.Size(100, 21);
            this.txt_char.TabIndex = 0;
            // 
            // txt_ASCII
            // 
            this.txt_ASCII.Location = new System.Drawing.Point(266, 30);
            this.txt_ASCII.Name = "txt_ASCII";
            this.txt_ASCII.Size = new System.Drawing.Size(100, 21);
            this.txt_ASCII.TabIndex = 1;
            // 
            // txt_ASCII2
            // 
            this.txt_ASCII2.Location = new System.Drawing.Point(25, 72);
            this.txt_ASCII2.Name = "txt_ASCII2";
            this.txt_ASCII2.Size = new System.Drawing.Size(100, 21);
            this.txt_ASCII2.TabIndex = 2;
            // 
            // txt_char2
            // 
            this.txt_char2.Location = new System.Drawing.Point(266, 72);
            this.txt_char2.Name = "txt_char2";
            this.txt_char2.Size = new System.Drawing.Size(100, 21);
            this.txt_char2.TabIndex = 3;
            // 
            // btn_ToASCII
            // 
            this.btn_ToASCII.Location = new System.Drawing.Point(141, 30);
            this.btn_ToASCII.Name = "btn_ToASCII";
            this.btn_ToASCII.Size = new System.Drawing.Size(109, 21);
            this.btn_ToASCII.TabIndex = 4;
            this.btn_ToASCII.Text = "转换为ASCII码";
            this.btn_ToASCII.UseVisualStyleBackColor = true;
            this.btn_ToASCII.Click += new System.EventHandler(this.btn_ToASCII_Click);
            // 
            // btn_ToChar
            // 
            this.btn_ToChar.Location = new System.Drawing.Point(141, 72);
            this.btn_ToChar.Name = "btn_ToChar";
            this.btn_ToChar.Size = new System.Drawing.Size(109, 21);
            this.btn_ToChar.TabIndex = 5;
            this.btn_ToChar.Text = "转换为字母";
            this.btn_ToChar.UseVisualStyleBackColor = true;
            this.btn_ToChar.Click += new System.EventHandler(this.btn_ToChar_Click);
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 148);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_Main";
            this.Text = "字母与ASCII相互转换";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_ToChar;
        private System.Windows.Forms.Button btn_ToASCII;
        private System.Windows.Forms.TextBox txt_char2;
        private System.Windows.Forms.TextBox txt_ASCII2;
        private System.Windows.Forms.TextBox txt_ASCII;
        private System.Windows.Forms.TextBox txt_char;
    }
}

