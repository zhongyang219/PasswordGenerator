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
            this.restoreDefault = new System.Windows.Forms.Button();
            this.specCharacters = new System.Windows.Forms.TextBox();
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
            this.charTypeProbEqualButton = new System.Windows.Forms.RadioButton();
            this.charProbEqualButton = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // includeNums
            // 
            this.includeNums.AutoSize = true;
            this.includeNums.Location = new System.Drawing.Point(21, 41);
            this.includeNums.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.includeNums.Name = "includeNums";
            this.includeNums.Size = new System.Drawing.Size(122, 32);
            this.includeNums.TabIndex = 0;
            this.includeNums.Text = "包含数字";
            this.includeNums.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.charProbEqualButton);
            this.groupBox1.Controls.Add(this.charTypeProbEqualButton);
            this.groupBox1.Controls.Add(this.restoreDefault);
            this.groupBox1.Controls.Add(this.specCharacters);
            this.groupBox1.Controls.Add(this.passwordLengthBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.includeLowercase);
            this.groupBox1.Controls.Add(this.includeCaptial);
            this.groupBox1.Controls.Add(this.includeSpecCharctor);
            this.groupBox1.Controls.Add(this.includeNums);
            this.groupBox1.Location = new System.Drawing.Point(14, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(579, 271);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "选项";
            // 
            // restoreDefault
            // 
            this.restoreDefault.Location = new System.Drawing.Point(414, 83);
            this.restoreDefault.Name = "restoreDefault";
            this.restoreDefault.Size = new System.Drawing.Size(153, 48);
            this.restoreDefault.TabIndex = 5;
            this.restoreDefault.Text = "恢复默认(&D)";
            this.restoreDefault.UseVisualStyleBackColor = true;
            this.restoreDefault.Click += new System.EventHandler(this.restoreDefault_Click);
            // 
            // specCharacters
            // 
            this.specCharacters.Location = new System.Drawing.Point(194, 88);
            this.specCharacters.Name = "specCharacters";
            this.specCharacters.Size = new System.Drawing.Size(205, 35);
            this.specCharacters.TabIndex = 4;
            // 
            // passwordLengthBox
            // 
            this.passwordLengthBox.Location = new System.Drawing.Point(140, 142);
            this.passwordLengthBox.MaxLength = 3;
            this.passwordLengthBox.Name = "passwordLengthBox";
            this.passwordLengthBox.Size = new System.Drawing.Size(126, 35);
            this.passwordLengthBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "密码位数：";
            // 
            // includeLowercase
            // 
            this.includeLowercase.AutoSize = true;
            this.includeLowercase.Location = new System.Drawing.Point(371, 41);
            this.includeLowercase.Name = "includeLowercase";
            this.includeLowercase.Size = new System.Drawing.Size(164, 32);
            this.includeLowercase.TabIndex = 1;
            this.includeLowercase.Text = "包含小写字母";
            this.includeLowercase.UseVisualStyleBackColor = true;
            // 
            // includeCaptial
            // 
            this.includeCaptial.AutoSize = true;
            this.includeCaptial.Location = new System.Drawing.Point(175, 41);
            this.includeCaptial.Name = "includeCaptial";
            this.includeCaptial.Size = new System.Drawing.Size(164, 32);
            this.includeCaptial.TabIndex = 1;
            this.includeCaptial.Text = "包含大写字母";
            this.includeCaptial.UseVisualStyleBackColor = true;
            // 
            // includeSpecCharctor
            // 
            this.includeSpecCharctor.AutoSize = true;
            this.includeSpecCharctor.Location = new System.Drawing.Point(21, 90);
            this.includeSpecCharctor.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.includeSpecCharctor.Name = "includeSpecCharctor";
            this.includeSpecCharctor.Size = new System.Drawing.Size(164, 32);
            this.includeSpecCharctor.TabIndex = 0;
            this.includeSpecCharctor.Text = "包含特殊符号";
            this.includeSpecCharctor.UseVisualStyleBackColor = true;
            this.includeSpecCharctor.CheckedChanged += new System.EventHandler(this.includeSpecCharctor_CheckedChanged);
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new System.Drawing.Point(194, 306);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(222, 48);
            this.GenerateButton.TabIndex = 2;
            this.GenerateButton.Text = "生成随机密码(&G)";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(84, 372);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.ReadOnly = true;
            this.passwordBox.Size = new System.Drawing.Size(431, 35);
            this.passwordBox.TabIndex = 3;
            // 
            // CopyButton
            // 
            this.CopyButton.Location = new System.Drawing.Point(84, 432);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(184, 48);
            this.CopyButton.TabIndex = 4;
            this.CopyButton.Text = "复制到剪贴板(&C)";
            this.CopyButton.UseVisualStyleBackColor = true;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // aboutButton
            // 
            this.aboutButton.Location = new System.Drawing.Point(260, 509);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(153, 48);
            this.aboutButton.TabIndex = 5;
            this.aboutButton.Text = "关于(&A)...";
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(428, 509);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(153, 48);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "退出(&X)";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // savePasswordButton
            // 
            this.savePasswordButton.Location = new System.Drawing.Point(301, 432);
            this.savePasswordButton.Name = "savePasswordButton";
            this.savePasswordButton.Size = new System.Drawing.Size(215, 48);
            this.savePasswordButton.TabIndex = 6;
            this.savePasswordButton.Text = "保存密码到文件(&S)";
            this.savePasswordButton.UseVisualStyleBackColor = true;
            this.savePasswordButton.Click += new System.EventHandler(this.savePasswordButton_Click);
            // 
            // charTypeProbEqualButton
            // 
            this.charTypeProbEqualButton.AutoSize = true;
            this.charTypeProbEqualButton.Location = new System.Drawing.Point(21, 192);
            this.charTypeProbEqualButton.Name = "charTypeProbEqualButton";
            this.charTypeProbEqualButton.Size = new System.Drawing.Size(289, 32);
            this.charTypeProbEqualButton.TabIndex = 6;
            this.charTypeProbEqualButton.TabStop = true;
            this.charTypeProbEqualButton.Text = "每一种字符出现的概率均等";
            this.charTypeProbEqualButton.UseVisualStyleBackColor = true;
            // 
            // charProbEqualButton
            // 
            this.charProbEqualButton.AutoSize = true;
            this.charProbEqualButton.Location = new System.Drawing.Point(21, 230);
            this.charProbEqualButton.Name = "charProbEqualButton";
            this.charProbEqualButton.Size = new System.Drawing.Size(268, 32);
            this.charProbEqualButton.TabIndex = 6;
            this.charProbEqualButton.TabStop = true;
            this.charProbEqualButton.Text = "每个字符出现的概率均等";
            this.charProbEqualButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(168F, 168F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(607, 580);
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
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
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
        private System.Windows.Forms.TextBox specCharacters;
        private System.Windows.Forms.Button restoreDefault;
        private System.Windows.Forms.RadioButton charProbEqualButton;
        private System.Windows.Forms.RadioButton charTypeProbEqualButton;
    }
}

