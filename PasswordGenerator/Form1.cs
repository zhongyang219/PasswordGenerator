using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGenerator
{
    //用于表示字符类型的枚举
    enum CharType
    {
        CK_NUMBERS,         //数字
        CK_CAPTIAL,         //大写字母
        CK_LOWERCASE,       //小写字母
        CK_SPECALCHAR       //特殊字符
    }

    public partial class Form1 : Form
    {
        //私有的字段
        List<CharType> m_optionCheck = new List<CharType>();    //储存生成的密码的字符类型
        Random m_randon = new Random();     //用于生成随机数
        //string m_specalChar;   //特殊字符
        string m_lastPassword = "";         //上一次保存过的密码

        //方法

        public Form1()
        {
            InitializeComponent();
            //设置控件的初始状态（从设置中读取状态）
            includeNums.Checked = Properties.Settings.Default.IncludeNum;
            includeCaptial.Checked = Properties.Settings.Default.IncludeCapital;
            includeLowercase.Checked = Properties.Settings.Default.IncludeLowercase;
            includeSpecCharctor.Checked = Properties.Settings.Default.IncludeSpecCharator;
            passwordLengthBox.Text = Properties.Settings.Default.PasswordLength;
            specCharacters.Text = Properties.Settings.Default.SpecCharacters;
            charTypeProbEqualButton.Checked = Properties.Settings.Default.CharTypeProbEqual;
            charProbEqualButton.Checked = !Properties.Settings.Default.CharTypeProbEqual;
            generateGUID.Checked = Properties.Settings.Default.GenerateGUID;
            //初始化控件的启用或禁用状态
            SetControlEnableState();
        }

        //获取选项复选框的状态
        private void GetOptionState()
        {
            m_optionCheck.Clear();
            if (includeNums.Checked)
                m_optionCheck.Add(CharType.CK_NUMBERS);
            if (includeCaptial.Checked)
                m_optionCheck.Add(CharType.CK_CAPTIAL);
            if (includeLowercase.Checked)
                m_optionCheck.Add(CharType.CK_LOWERCASE);
            if (includeSpecCharctor.Checked)
                m_optionCheck.Add(CharType.CK_SPECALCHAR);
        }

        private void SetControlEnableState()
        {
            specCharacters.Enabled = includeSpecCharctor.Checked && !generateGUID.Checked;
            restoreDefault.Enabled = includeSpecCharctor.Checked && !generateGUID.Checked;

            includeNums.Enabled = !generateGUID.Checked;
            includeCaptial.Enabled = !generateGUID.Checked;
            includeLowercase.Enabled = !generateGUID.Checked;
            includeSpecCharctor.Enabled = !generateGUID.Checked;
            label1.Enabled = !generateGUID.Checked;
            passwordLengthBox.Enabled = !generateGUID.Checked;
            charTypeProbEqualButton.Enabled = !generateGUID.Checked;
            charProbEqualButton.Enabled = !generateGUID.Checked;
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            CopyButton.Text = "复制到剪贴板(&C)";
            if (generateGUID.Checked)
            {
                string newGuid = Guid.NewGuid().ToString();
                passwordBox.Text = newGuid;
                return;
            }

            GetOptionState();
            passwordBox.Text = "";
            if (passwordLengthBox.Text.Length == 0)      //如果密码长度文本框没有输入字符
            {
                MessageBox.Show("请输入要生成的密码长度！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(m_optionCheck.Count == 0)        //如果没有选中任何一个复选框
            {
                MessageBox.Show("请选择一种要包含的字符类型！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int passwordLength = 0;     //保存输入的密码的长度
            try
            {
                passwordLength = int.Parse(passwordLengthBox.Text);
            }
            catch(FormatException)
            {
                MessageBox.Show("你只能在“密码位数”文本框中输入数字！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(passwordLength == 0)     //如果密码长度设置为0
            {
                MessageBox.Show("密码长度不能为0！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //选中了“每一种字符出现的概率均等”时
            if (charTypeProbEqualButton.Checked)
            {
                for (int i = 0; i< passwordLength; i++)
                {
                    int index = m_randon.Next(m_optionCheck.Count);  //随机确定生成哪一种字符
                    CharType charType = m_optionCheck[index];
                    char currentChar = '\0';
                    switch(charType)
                    {
                        case CharType.CK_NUMBERS:
                            currentChar = Convert.ToChar(m_randon.Next(48, 58));    //随机生成一个0~9的数字
                            break;
                        case CharType.CK_CAPTIAL:
                            currentChar = Convert.ToChar(m_randon.Next(65, 91));    //随机生成一个大写字母
                            break;
                        case CharType.CK_LOWERCASE:
                            currentChar = Convert.ToChar(m_randon.Next(97, 123));    //随机生成一个小写字母
                            break;
                        case CharType.CK_SPECALCHAR:
                            int randon = m_randon.Next(specCharacters.Text.Length);
                            currentChar = specCharacters.Text[randon];     //随机生成一个特殊字符
                            break;
                    }
                    passwordBox.Text += currentChar;
                }
            }
            //选中了“每个字符出现的概率均等”时
            else if (charProbEqualButton.Checked)
            {
                string characters = "";     //所有可能的字符
                if (includeNums.Checked)
                    characters += "0123456789";
                if (includeCaptial.Checked)
                    characters += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                if (includeLowercase.Checked)
                    characters += "abcdefghijklmnopqrstuvwxyz";
                if (includeSpecCharctor.Checked)
                    characters += specCharacters.Text;
                for (int i = 0; i < passwordLength; i++)
                {
                    int index = m_randon.Next(characters.Length);
                    char currentChar = characters[index];
                    passwordBox.Text += currentChar;
                }
            }
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            if(passwordBox.TextLength > 0)
            {
                passwordBox.SelectAll();
                passwordBox.Copy();
                //MessageBox.Show("密码已复制到剪贴板。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CopyButton.Text="已复制 √";
            }
        }

        private void onKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')      //按回车键执行生成随机密码操作
                GenerateButton_Click(new object(), new EventArgs());
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            //弹出“关于”对话框
            (new AboutForm()).ShowDialog();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //退出程序
            Close();
        }

        private void savePasswordButton_Click(object sender, EventArgs e)
        {
            //保存当前生成的密码到log文件
            if(passwordBox.TextLength > 0 && passwordBox.Text != m_lastPassword)    //仅当已生成密码且当前生成的密码和之前保存的密码不同才保存密码
            {
                StreamWriter streamWriter = new StreamWriter(".\\password.log", true, Encoding.UTF8);
                streamWriter.Write(DateTime.Now.ToString());
                streamWriter.Write("：");
                streamWriter.WriteLine(passwordBox.Text);
                streamWriter.Close();
                m_lastPassword = passwordBox.Text;
                MessageBox.Show("密码已保存到password.log中。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void onFormClosing(object sender, FormClosingEventArgs e)
        {
            //窗口关闭时保存设置
            Properties.Settings.Default.IncludeNum = includeNums.Checked;
            Properties.Settings.Default.IncludeCapital = includeCaptial.Checked;
            Properties.Settings.Default.IncludeLowercase = includeLowercase.Checked;
            Properties.Settings.Default.IncludeSpecCharator = includeSpecCharctor.Checked;
            Properties.Settings.Default.PasswordLength = passwordLengthBox.Text;
            Properties.Settings.Default.SpecCharacters = specCharacters.Text;
            Properties.Settings.Default.CharTypeProbEqual = charTypeProbEqualButton.Checked;
            Properties.Settings.Default.GenerateGUID = generateGUID.Checked;
            Properties.Settings.Default.Save();
        }

        private void restoreDefault_Click(object sender, EventArgs e)
        {
            specCharacters.Text = "~!@#$%^&*()_-+={}[]|\\<>/?";
        }

        private void includeSpecCharctor_CheckedChanged(object sender, EventArgs e)
        {
            SetControlEnableState();
        }

        private void generateGUID_CheckedChanged(object sender, EventArgs e)
        {
            SetControlEnableState();
        }
    }
}
