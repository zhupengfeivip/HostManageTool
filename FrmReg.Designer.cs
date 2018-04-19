namespace HostManageTool
{
    partial class FrmReg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReg));
            this.btnOk = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbxMechineCode = new System.Windows.Forms.RichTextBox();
            this.rtbxRegCode = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.btnCopyMachineCode = new System.Windows.Forms.Button();
            this.btnToRegCode = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(111, 421);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "注册(&R)";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "机器码：";
            // 
            // rtbxMechineCode
            // 
            this.rtbxMechineCode.Location = new System.Drawing.Point(98, 81);
            this.rtbxMechineCode.Name = "rtbxMechineCode";
            this.rtbxMechineCode.Size = new System.Drawing.Size(443, 130);
            this.rtbxMechineCode.TabIndex = 4;
            this.rtbxMechineCode.Text = "";
            // 
            // rtbxRegCode
            // 
            this.rtbxRegCode.Location = new System.Drawing.Point(98, 263);
            this.rtbxRegCode.Name = "rtbxRegCode";
            this.rtbxRegCode.Size = new System.Drawing.Size(443, 152);
            this.rtbxRegCode.TabIndex = 6;
            this.rtbxRegCode.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "注册码：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(572, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 60);
            this.label4.TabIndex = 7;
            this.label4.Text = "注册说明：\r\n1、如果您喜欢这个软件，\r\n1元一个月\r\n2元六个月\r\n5元可永久注册。终生免费升级。";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(572, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(503, 36);
            this.label5.TabIndex = 8;
            this.label5.Text = "注册方法：\r\n1、在左侧填写信息，然后生成机器码。发到邮箱zhupengfeivip@163.com\r\n或者添加微信好友，zhupengfeivip，发送微信付款" +
    "或者支付宝付款截图。即可接受到注册码。";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(98, 217);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 9;
            this.btnCreate.Text = "生成(&C)";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(98, 12);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(209, 21);
            this.txtEmail.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "邮箱：";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::HostManageTool.Properties.Resources.qr_ali;
            this.pictureBox2.Location = new System.Drawing.Point(828, 156);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(262, 298);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HostManageTool.Properties.Resources.qr_wx;
            this.pictureBox1.Location = new System.Drawing.Point(574, 171);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(236, 226);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(98, 49);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(77, 16);
            this.radioButton1.TabIndex = 14;
            this.radioButton1.Text = "一个月1元";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(230, 49);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(77, 16);
            this.radioButton2.TabIndex = 15;
            this.radioButton2.Text = "六个月2元";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.Location = new System.Drawing.Point(368, 49);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(89, 16);
            this.radioButton3.TabIndex = 16;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "永久注册5元";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // btnCopyMachineCode
            // 
            this.btnCopyMachineCode.Location = new System.Drawing.Point(209, 217);
            this.btnCopyMachineCode.Name = "btnCopyMachineCode";
            this.btnCopyMachineCode.Size = new System.Drawing.Size(98, 23);
            this.btnCopyMachineCode.TabIndex = 17;
            this.btnCopyMachineCode.Text = "复制机器码(&M)";
            this.btnCopyMachineCode.UseVisualStyleBackColor = true;
            this.btnCopyMachineCode.Click += new System.EventHandler(this.btnCopyMachineCode_Click);
            // 
            // btnToRegCode
            // 
            this.btnToRegCode.Location = new System.Drawing.Point(209, 421);
            this.btnToRegCode.Name = "btnToRegCode";
            this.btnToRegCode.Size = new System.Drawing.Size(98, 23);
            this.btnToRegCode.TabIndex = 18;
            this.btnToRegCode.Text = "粘贴注册码(&N)";
            this.btnToRegCode.UseVisualStyleBackColor = true;
            this.btnToRegCode.Click += new System.EventHandler(this.btnToRegCode_Click);
            // 
            // FrmReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 482);
            this.Controls.Add(this.btnToRegCode);
            this.Controls.Add(this.btnCopyMachineCode);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rtbxRegCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rtbxMechineCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOk);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmReg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "注册";
            this.Load += new System.EventHandler(this.FrmReg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbxMechineCode;
        private System.Windows.Forms.RichTextBox rtbxRegCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Button btnCopyMachineCode;
        private System.Windows.Forms.Button btnToRegCode;
    }
}