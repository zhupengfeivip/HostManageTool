using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }


        private string fileName = System.Environment.SystemDirectory + @"\drivers\etc\hosts";

        private void FrmMain_Load(object sender, EventArgs e)
        {
            try
            {
                rtbxHostsInfo.Text = File.ReadAllText(fileName);
                btnSave.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "出错啦", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                File.WriteAllText(fileName, rtbxHostsInfo.Text);
                btnSave.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "出错啦", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void btnComment_Click(object sender, EventArgs e)
        {
            try
            {
                //得到光标行第一个字符的索引即从第1个字符开始到光标行的第1个字符索引
                int index = rtbxHostsInfo.GetFirstCharIndexOfCurrentLine();
                //得到光标行的行号,第1行从0开始。
                int lineNum = rtbxHostsInfo.GetLineFromCharIndex(index);
                int nextIndex = rtbxHostsInfo.GetFirstCharIndexFromLine(lineNum + 1);
                if (nextIndex < 0)
                    nextIndex = rtbxHostsInfo.TextLength;//最后一行
                //当前行前三个字符以#开始，去掉空格，表示已注释
                if (rtbxHostsInfo.Text.Substring(index, nextIndex - index).Replace(" ", "").StartsWith("#"))
                {
                    MessageBox.Show(this, "当前行已注释，不需要重新注释。", "出错啦", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    return;
                }
                rtbxHostsInfo.Text = rtbxHostsInfo.Text.Insert(index, "# ");
                rtbxHostsInfo.Select(index, nextIndex - index + 1);
                btnSave.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "出错啦", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void btnCancelComment_Click(object sender, EventArgs e)
        {
            try
            {
                //得到光标行第一个字符的索引即从第1个字符开始到光标行的第1个字符索引
                int index = rtbxHostsInfo.GetFirstCharIndexOfCurrentLine();
                //得到光标行的行号,第1行从0开始。
                int lineNum = rtbxHostsInfo.GetLineFromCharIndex(index);
                int nextIndex = rtbxHostsInfo.GetFirstCharIndexFromLine(lineNum + 1);
                if (nextIndex < 0)
                    nextIndex = rtbxHostsInfo.TextLength;//最后一行
                //当前行前三个字符以#开始，去掉空格，表示已注释
                if (rtbxHostsInfo.Text.Substring(index, nextIndex - index).Replace(" ", "").StartsWith("#") == false)
                {
                    MessageBox.Show(this, "当前行未注释，不需要取消注释。", "出错啦", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    return;
                }
                rtbxHostsInfo.Text = rtbxHostsInfo.Text.Remove(index, 2);
                rtbxHostsInfo.Select(index, nextIndex - index - 2);
                btnSave.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "出错啦", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
