using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HostManageTool
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();

            //FrmNoReg noReg = new FrmNoReg();
            //noReg.Show(this);
        }


        private string hostFileName = System.Environment.SystemDirectory + @"\drivers\etc\hosts";

        private int sec = 30;

        /// <summary>
        /// 是否已注册
        /// </summary>
        private bool Reged = false;

        private void FrmMain_Load(object sender, EventArgs e)
        {
            try
            {
                rtbxHostsInfo.Text = File.ReadAllText(hostFileName);

                Program.cpuId = Computer.GetCpuID().Replace("|", "");
                Program.diskId = Computer.GetDiskID().Replace("|", "");
                Program.computerName = Computer.GetComputerName().Replace("|", "");

                if (File.Exists(Program.keyFile) == false)
                {
                    //无注册文件，肯定未注册
                    //MessageBox.Show(this, "软件未注册，无法保存。", "出错啦", MessageBoxButtons.OK, MessageBoxIcon.Error);    
                    timerCheckReg.Enabled = true;
                    menuStrip1.Enabled = false;
                    toolStrip1.Enabled = false;
                    this.Text = $"host管理工具[未注册]";
                    return;
                }
                else
                {
                    StreamReader myreader = File.OpenText(Program.keyFile);//读取记事本文件
                    string desRegCode = myreader.ReadToEnd();//从当前位置读取到文件末尾
                    myreader.Close();
                    myreader.Dispose();
                    string regCode = Bonn.Helper.Des3.Decrypt(desRegCode);
                    string[] regInfo = regCode.Split('|');
                    if (Program.Config.Email.Trim() != regInfo[4])
                    {
                        //throw new Exception("请填写申请注册码时邮箱");
                        timerCheckReg.Enabled = true;
                        menuStrip1.Enabled = false;
                        toolStrip1.Enabled = false;
                        this.Text = $"host管理工具[未注册]";
                        return;
                    }
                    if (Program.AppName != regInfo[5] || Program.cpuId != regInfo[3] || Program.diskId != regInfo[2] || Program.computerName != regInfo[1])
                    {
                        //throw new Exception("机器码与注册码不匹配，请重新注册。");
                        timerCheckReg.Enabled = true;
                        menuStrip1.Enabled = false;
                        toolStrip1.Enabled = false;
                        return;
                    }
                    this.Text = $"host管理工具[已注册给{Program.Config.Email}]";
                    timerCheckReg.Enabled = false;
                    tsslblRegInfo.Text = $"已注册";
                    menuStrip1.Enabled = true;
                    toolStrip1.Enabled = true;
                    Reged = true;
                }
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
                if (Reged == false)
                {
                    MessageBox.Show(this, "软件未注册，无法保存。", "出错啦", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                File.WriteAllText(hostFileName, rtbxHostsInfo.Text);
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

        private void 关于AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAbout about = new FrmAbout();
            about.ShowDialog(this);
        }

        private void 注册RToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReg reg = new FrmReg();
            reg.ShowDialog(this);
            if (reg.Reged)
            {
                this.Text = $"host管理工具[已注册给{Program.Config.Email}]";
                timerCheckReg.Enabled = false;
                tsslblRegInfo.Text = $"已注册";
                menuStrip1.Enabled = true;
                toolStrip1.Enabled = true;
            }
        }

        private void rtbxHostsInfo_TextChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
        }

        private void timerCheckReg_Tick(object sender, EventArgs e)
        {
            sec--;
            tsslblRegInfo.Text = $"未注册，{sec}秒后可编辑";
            if (sec <= 0)
            {
                timerCheckReg.Enabled = false;
                tsslblRegInfo.Text = $"未注册";
                menuStrip1.Enabled = true;
                toolStrip1.Enabled = true;
                return;
            }
        }
    }
}
