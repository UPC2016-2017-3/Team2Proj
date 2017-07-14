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
    public partial class frmEmp2 : Form
    {
        public frmEmp2()
        {
            InitializeComponent();
        }
        tb_SellGoodsMenthod sellMenthod = new tb_SellGoodsMenthod();
       private void frmEmp2_Load_1(object sender, EventArgs e)
        {
            sellMenthod.fillEmployee(this.treeView1, imageList1);
        }
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode.Text != "")
            {
                frmSellGoods sellGood = (frmSellGoods)this.Owner;
                sellGood.txtEmpID.Text = treeView1.SelectedNode.Text;
                this.Close();

            }
            else
            {
                MessageBox.Show("选择员工信息");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
