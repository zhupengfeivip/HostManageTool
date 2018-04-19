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
    public partial class FrmReg : Form
    {
        public FrmReg()
        {
            InitializeComponent();
        }



        /// <summary>
        /// 是否已注册
        /// </summary>
        public bool Reged = false;


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmReg_Load(object sender, EventArgs e)
        {
            try
            {

                txtEmail.Text = Program.Config.Email;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "出错啦", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEmail.Text.Trim().Length == 0)
                {
                    MessageBox.Show(this, "邮箱不能为空。", "出错啦", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    return;
                }

                string email = txtEmail.Text.Trim().Replace("|", "");
                string sign = "";
                sign += $"{Program.AppName}|";
                sign += $"{email}|";
                sign += $"{Program.cpuId}|";
                sign += $"{Program.diskId}|";
                sign += $"{Program.computerName}|";
                sign += $"{Program.Config.RunDateTime}|";
                if (radioButton1.Checked)
                    sign += $"1|";
                else if (radioButton1.Checked)
                    sign += $"2|";
                else
                    sign += $"3|";
                rtbxMechineCode.Text = Bonn.Helper.Des3.Encrypt(sign);

                Program.Config.Email = txtEmail.Text.Trim().Replace("|", "");
                Bonn.Helper.XmlHelper.XmlSerializeToFile(Program.Config, Program.configPath);

                MessageBox.Show(this, "生成成功。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "出错啦", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (rtbxRegCode.Text.Trim().Length == 0)
                {
                    MessageBox.Show(this, "注册码不能为空。", "出错啦", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    return;
                }
                string regCode = Bonn.Helper.Des3.Decrypt(rtbxRegCode.Text.Trim());
                string[] regInfo = regCode.Split('|');
                if (txtEmail.Text.Trim() != regInfo[4])
                {
                    MessageBox.Show(this, "请填写申请注册码时邮箱。", "出错啦", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    return;
                }
                if (Program.AppName != regInfo[5] || Program.cpuId != regInfo[3] || Program.diskId != regInfo[2] || Program.computerName != regInfo[1])
                {
                    MessageBox.Show(this, "机器码与注册码不匹配，请重新注册。", "出错啦", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    return;
                }

                //保存编辑的内容
                FileStream stream = new FileStream(Program.keyFile, FileMode.Create);//fileMode指定是读取还是写入
                StreamWriter writer = new StreamWriter(stream, Encoding.Default);
                writer.Write(rtbxRegCode.Text.Trim());//写完后不会换行
                writer.Close();//释放内存
                stream.Close();//释放内存

                MessageBox.Show(this, "注册成功。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reged = true;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "出错啦", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void btnCopyMachineCode_Click(object sender, EventArgs e)
        {
            try
            {
                if (rtbxMechineCode.Text.Length <= 0)
                {
                    MessageBox.Show(this, "机器码不能为空。", "出错啦", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    return;
                }
                Clipboard.SetDataObject(rtbxMechineCode.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "出错啦", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void btnToRegCode_Click(object sender, EventArgs e)
        {
            try
            {
                IDataObject iData = Clipboard.GetDataObject();

                // Determines whether the data is in a format you can use.
                if (iData.GetDataPresent(DataFormats.Text))
                {
                    // Yes it is, so display it in a text box.
                    rtbxRegCode.Text = (String)iData.GetData(DataFormats.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "出错啦", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
    }
}
