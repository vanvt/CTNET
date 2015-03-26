using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ServiceClient;

namespace ATSMProject
{
    public partial class Form1 : Form
    {
        private ServiceClient.LoginUserWS.LoginUserWS _ws = new ServiceClient.LoginUserWS.LoginUserWS();
        private ServiceClient.LoginUserWS.LoginUserWSI _wsi = new ServiceClient.LoginUserWS.LoginUserWSI();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                _wsi.LoginUser = new ServiceClient.LoginUserWS.LoginUser();
                _wsi.LoginUser.LoginUserId = textBox1.Text;
                _wsi.LoginUser.Password = textBox2.Text;
                _wsi.Mode = "SEL";
                _wsi = _ws.CallService(_wsi);
                if (_wsi.LoginUser != null)
                {
                    MessageBox.Show("Login Complete");
                }
                else
                {
                    MessageBox.Show("Password incorrect");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
