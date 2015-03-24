using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ServiceClient.UserWS;

namespace ATSMProject
{
    public partial class Form1 : Form
    {
        public UserWS WS = new UserWS();
        public UserWSI WSI = new UserWSI();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                WSI.ATSMUser = new ATSMUser();
                WSI.ATSMUser.Id = int.Parse(textBox1.Text);
                WSI.ATSMUser.Password = textBox2.Text;
                WSI.Mode = "SAV";
                WSI = WS.CallService(WSI);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
