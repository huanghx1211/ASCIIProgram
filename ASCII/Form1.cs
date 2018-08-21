﻿using System;
using System.Text;
using System.Windows.Forms;

namespace ASCII
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void btn_ToASCII_Click(object sender, EventArgs e)
        {
            if (txt_char.Text != string.Empty)
            {
                if (Encoding.GetEncoding("unicode").GetBytes
                    (new char[] { txt_char.Text[0] })[1] == 0)
                {
                    txt_ASCII.Text = Encoding.GetEncoding(
                        "unicode").GetBytes(txt_char.Text)[0].ToString();
                }
                else
                {
                    txt_ASCII.Text = string.Empty;
                    MessageBox.Show("请输入字母！", "提示！");
                }
            }
        }

        private void btn_ToChar_Click(object sender, EventArgs e)
        {
            if (txt_ASCII2.Text != string.Empty)
            {
                byte P_int_Num;
                if (byte.TryParse(
                    txt_ASCII2.Text, out P_int_Num))
                {
                    txt_char2.Text = ((char)P_int_Num).ToString();
                }
                else
                {
                    MessageBox.Show("请输入正确的ASCII码值", "提示！");
                }
            }
        }
    }
}
