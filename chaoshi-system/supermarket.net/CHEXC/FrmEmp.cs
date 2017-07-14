using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CHEXC.GoodMenhod;

namespace CHEXC
{
    public partial class FrmEmp : Form
    {
        public FrmEmp()
        {
            InitializeComponent();
        }
       
        tb_JhGoodsInfoMenthod jhMenthod = new tb_JhGoodsInfoMenthod(); 
        private void Form2_Load(object sender, EventArgs e)
        {
            jhMenthod.fillEmployee(this.treeView1, imageList1);
        }
      

       

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode.Text != "")
            {
                frmJhGoodsInfo jhGood = (frmJhGoodsInfo)this.Owner;
                jhGood.txtEmpId.Text = treeView1.SelectedNode.Text;
                this.Close();

            }
            else
            {
                MessageBox.Show("选择员工信息");
            }
        }
       
    }
}
