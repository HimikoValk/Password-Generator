using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PasswordManager.io.himiko.utils;
using System.IO;
using System.Net;
using System.Runtime.Remoting.Channels;
using System.Threading;
using System.Diagnostics;
using System.Resources;
using System.Runtime.CompilerServices;

namespace PasswordManager
{
    public partial class Form : System.Windows.Forms.Form
    {
        private string defaultPath = "C:\\Program Files (x86)\\PasswordManager";
        private int LenghtComboBoxValue; 
        public Form()
        {
            InitializeComponent();
            passwordTextBox.Text = "Password will be generated her!"; 
        }

        private void siticoneRoundedGradientButton1_Click(object sender, EventArgs e)
        {
            passwordTextBox.Text = ""; 

            if(savePathTextBox.Text == "")
            {
                savePathTextBox.Text = defaultPath; 
                passwordTextBox.ResetText();
                LenghtComboBoxValue = Convert.ToInt32(LenghtComboBox.Text);
                string password = PasswordUtil.INSTANCE.createPassword(LenghtComboBoxValue, PasswordProviderTextBox.Text);
                string FilePath = defaultPath + PasswordProviderTextBox.Text;
                passwordTextBox.Text = password;
                Directory.CreateDirectory(defaultPath);
               
                if (File.Exists(defaultPath + $"/{PasswordProviderTextBox.Text}.txt"))
                {
                    File.WriteAllText(defaultPath + $"/{PasswordProviderTextBox.Text}({PasswordUtil.INSTANCE.randomString(10)}).txt", password);
                }else
                {
                    File.WriteAllText(defaultPath + $"/{PasswordProviderTextBox.Text}.txt", password);
                }
                
            }else
            { 
                string savePathText = savePathTextBox.Text;
                passwordTextBox.ResetText();
                LenghtComboBoxValue = Convert.ToInt32(LenghtComboBox.Text);
                string password = PasswordUtil.INSTANCE.createPassword(LenghtComboBoxValue, PasswordProviderTextBox.Text);
                string FilePath = savePathText + PasswordProviderTextBox.Text;
                Directory.CreateDirectory(savePathText);
                File.WriteAllText(FilePath +  $"/{PasswordProviderTextBox.Text}.txt", password);
            }

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
