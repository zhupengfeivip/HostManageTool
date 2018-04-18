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
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(111, 388);
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
            this.label2.Location = new System.Drawing.Point(39, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "机器码：";
            // 
            // rtbxMechineCode
            // 
            this.rtbxMechineCode.Location = new System.Drawing.Point(98, 48);
            this.rtbxMechineCode.Name = "rtbxMechineCode";
            this.rtbxMechineCode.Size = new System.Drawing.Size(443, 130);
            this.rtbxMechineCode.TabIndex = 4;
            this.rtbxMechineCode.Text = "";
            // 
            // rtbxRegCode
            // 
            this.rtbxRegCode.Location = new System.Drawing.Point(98, 230);
            this.rtbxRegCode.Name = "rtbxRegCode";
            this.rtbxRegCode.Size = new System.Drawing.Size(443, 152);
            this.rtbxRegCode.TabIndex = 6;
            this.rtbxRegCode.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 233);
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
            this.label4.Size = new System.Drawing.Size(317, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "注册说明：\r\n1、如果您喜欢这个软件，5元可永久注册。终生免费升级。";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(572, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(503, 36);
            this.label5.TabIndex = 8;
            this.label5.Text = "注册方法：\r\n1、在左侧填写信息，然后生成机器码。发到邮箱zhupengfeivip@163.com\r\n或者添加微信好友，zhupengfeivip，发送微信付款" +
    "或者支付宝付款截图。即可接受到注册码。";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(98, 184);
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
            // FrmReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 446);
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
    }
}