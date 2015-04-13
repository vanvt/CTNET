using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClientForm
{
    public partial class Form1 : Form
    {
        private bool isLoad = false;
        LopHocPhanDKWS.LopHocPhanDKWSI wsi = new LopHocPhanDKWS.LopHocPhanDKWSI();
        LopHocPhanDKWS.LopHocPhanDKWS ws = new LopHocPhanDKWS.LopHocPhanDKWS();
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("FAL2014");
            comboBox1.Items.Add("FAL2015");
            comboBox1.Items.Add("SPR2015");
            comboBox1.SelectedIndex = 0;
            isLoad = true;
        }
        public class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                wsi = ws.getLopHocPhanDKByMasv(textBox1.Text);
                if (wsi != null)
                {
                    dataGridView1.Rows.Clear();
                    for(int i = 0; i<wsi.LopHocPhans.Count();i++)
                    {
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[colMalhp.Index].Value = wsi.LopHocPhans[i].Malhp;
                        dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[colTenLhp.Index].Value = wsi.HocPhans[i].Tenhp;
                        dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[colTenGiaoVien.Index].Value = wsi.CanBoGiaoViens[i].Tencbgv;
                        dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[colHocKy.Index].Value = wsi.HocKys[i].Tenhk;
                    } 
                }
            }
            catch(Exception ex){
                MessageBox.Show(ex.Message);
            }
            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoad)
            {
                dataGridView1.Rows.Clear();

                for (int i = 0; i < wsi.LopHocPhans.Count(); i++)
                {
                    if (wsi.HocKys[i].Mahk == comboBox1.SelectedItem.ToString())
                    {
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[colMalhp.Index].Value = wsi.LopHocPhans[i].Malhp;
                        dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[colTenLhp.Index].Value = wsi.HocPhans[i].Tenhp;
                        dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[colTenGiaoVien.Index].Value = wsi.CanBoGiaoViens[i].Tencbgv;
                        dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[colHocKy.Index].Value = wsi.HocKys[i].Tenhk;
                    }
                }
            }
            
        }
    }
}
