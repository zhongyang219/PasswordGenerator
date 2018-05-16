namespace PasswordGenerator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.includeNums = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.passwordLengthBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.includeLowercase = new System.Windows.Forms.CheckBox();
            this.includeCaptial = new System.Windows.Forms.CheckBox();
            this.includeSpecCharctor = new System.Windows.Forms.CheckBox();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.CopyButton = new System.Windows.Forms.Button();
            this.aboutButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.savePasswordButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // includeNums
            // 
            this.includeNums.AutoSize = true;
            this.includeNums.Location = new System.Drawing.Point(18, 35);
            this.includeNums.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.includeNums.Name = "includeNums";
            this.includeNums.Size = new System.Drawing.Size(108, 28);
            this.includeNums.TabIndex = 0;
            this.includeNums.Text = "包含数字";
            this.includeNums.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.passwordLengthBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.includeLowercase);
            this.groupBox1.Controls.Add(this.includeCaptial);
            this.groupBox1.Controls.Add(this.includeSpecCharctor);
            this.groupBox1.Controls.Add(this.includeNums);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(496, 174);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "选项";
            // 
            // passwordLengthBox
            // 
            this.passwordLengthBox.Location = new System.Drawing.Point(120, 122);
            this.passwordLengthBox.MaxLength = 3;
            this.passwordLengthBox.Name = "passwordLengthBox";
            this.passwordLengthBox.Size = new System.Drawing.Size(109, 31);
            this.passwordLengthBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "密码位数：";
            // 
            // includeLowercase
            // 
            this.includeLowercase.AutoSize = true;
            this.includeLowercase.Location = new System.Drawing.Point(318, 35);
            this.includeLowercase.Name = "includeLowercase";
            this.includeLowercase.Size = new System.Drawing.Size(144, 28);
            this.includeLowercase.TabIndex = 1;
            this.includeLowercase.Text = "包含小写字母";
            this.includeLowercase.UseVisualStyleBackColor = true;
            // 
            // includeCaptial
            // 
            this.includeCaptial.AutoSize = true;
            this.includeCaptial.Location = new System.Drawing.Point(150, 35);
            this.includeCaptial.Name = "includeCaptial";
            this.includeCaptial.Size = new System.Drawing.Size(144, 28);
            this.includeCaptial.TabIndex = 1;
            this.includeCaptial.Text = "包含大写字母";
            this.includeCaptial.UseVisualStyleBackColor = true;
            // 
            // includeSpecCharctor
            // 
            this.includeSpecCharctor.AutoSize = true;
            this.includeSpecCharctor.Location = new System.Drawing.Point(18, 77);
            this.includeSpecCharctor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.includeSpecCharctor.Name = "includeSpecCharctor";
            this.includeSpecCharctor.Size = new System.Drawing.Size(144, 28);
            this.includeSpecCharctor.TabIndex = 0;
            this.includeSpecCharctor.Text = "包含特殊符号";
            this.includeSpecCharctor.UseVisualStyleBackColor = true;
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new System.Drawing.Point(166, 208);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(190, 41);
            this.GenerateButton.TabIndex = 2;
            this.GenerateButton.Text = "生成随机密码(&G)";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(72, 267);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.ReadOnly = true;
            this.passwordBox.Size = new System.Drawing.Size(370, 31);
            this.passwordBox.TabIndex = 3;
            // 
            // CopyButton
            // 
            this.CopyButton.Location = new System.Drawing.Point(72, 318);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(158, 41);
            this.CopyButton.TabIndex = 4;
            this.CopyButton.Text = "复制到剪贴板(&C)";
            this.CopyButton.UseVisualStyleBackColor = true;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // aboutButton
            // 
            this.aboutButton.Location = new System.Drawing.Point(223, 399);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(131, 41);
            this.aboutButton.TabIndex = 5;
            this.aboutButton.Text = "关于(&A)...";
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(367, 399);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(131, 41);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "退出(&X)";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // savePasswordButton
            // 
            this.savePasswordButton.Location = new System.Drawing.Point(258, 318);
            this.savePasswordButton.Name = "savePasswordButton";
            this.savePasswordButton.Size = new System.Drawing.Size(184, 41);
            this.savePasswordButton.TabIndex = 6;
            this.savePasswordButton.Text = "保存密码到文件(&S)";
            this.savePasswordButton.UseVisualStyleBackColor = true;
            this.savePasswordButton.Click += new System.EventHandler(this.savePasswordButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(520, 458);
            this.Controls.Add(this.savePasswordButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.CopyButton);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "随机密码生成器";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.onFormClosing);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onKeyPress);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox includeNums;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox passwordLengthBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox includeLowercase;
        private System.Windows.Forms.CheckBox includeCaptial;
        private System.Windows.Forms.CheckBox includeSpecCharctor;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Button CopyButton;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button savePasswordButton;
    }
}

