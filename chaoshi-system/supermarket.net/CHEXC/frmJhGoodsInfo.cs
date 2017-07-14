using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CHEXC.ClassInfo;
using CHEXC.GoodMenhod;
using System.Data.SqlClient;
namespace CHEXC
{
    public partial class frmJhGoodsInfo : Form
    {
        public frmJhGoodsInfo()
        {
            InitializeComponent();
        }
        public frmJhGoodsInfo(int intCdo)
        {
            InitializeComponent();
        }

        tb_JhGoodsInfo jhGood=new tb_JhGoodsInfo();
        tb_JhGoodsInfoMenthod jhMenthod=new tb_JhGoodsInfoMenthod();
        public static int intFalg = 0;
        private void ControlStatus()
        {
            this.toolSave.Enabled = !this.toolSave.Enabled;
            this.toolAdd.Enabled = !this.toolAdd.Enabled;
            this.toolCancel.Enabled = !this.toolCancel.Enabled;
            this.toolAmend.Enabled = !this.toolAmend.Enabled;
            this.tollDelete.Enabled = !this.tollDelete.Enabled;
        }
        public void ClearContorl()
        {
            txtGoodsNum.Text = "";
            txtGoodsRemark.Text = "";
            txtGoodsSellPrice.Text = "";
            txtJhCompName.Text = "";
            txtGoodsAllPrice.Text = "";
            txtGoodsName.Text = "";
            txtGoodsJhPrice.Text = "";
            txtGoodsID.Text = "";
            txtEmpId.Text = "";
           
        }
        public int getIntCount()
        {
            int intReslut = 0;
            if (intFalg == 1)
            {
                if (txtGoodsID.Text == "")
                {
                    MessageBox.Show("商品编号不能为空！");
                    return intReslut;
                }
                if (txtGoodsName.Text == "")
                {
                    MessageBox.Show("商品名称不能为空！");
                    return intReslut;
                }
                if (txtJhCompName.Text == "")
                {
                    MessageBox.Show("供应商名称不能为空！");
                    return intReslut;
                }
                if (txtEmpId.Text == "")
                {
                    MessageBox.Show("进货人姓名不能为空！");
                    return intReslut;
                }
                if (txtGoodsNum.Text == "")
                {
                    MessageBox.Show("数量不能为空！");
                    return intReslut;
                }
                if (txtGoodsName.Text == "")
                {
                    MessageBox.Show("进货单价不能为空！");
                    return intReslut;
                }
            }
            if (intFalg == 2)
            {
                if (txtGoodsID.Text == "")
                {
                    MessageBox.Show("商品编号不能为空！,选择要修改记录","提示");
                    return intReslut;
                }
                
            }
            if (intFalg == 3)
            {
                if (txtGoodsID.Text == "")
                {
                    MessageBox.Show("商品编号不能为空！,选择要删除记录", "提示");
                    return intReslut;
                }
            }
            jhGood.strGoodsID = txtGoodsID.Text;
            jhGood.strEmpId = txtEmpId.Text;
            jhGood.strJhCompName = txtJhCompName.Text;
            jhGood.strGoodsNum = Convert.ToInt32(txtGoodsNum.Text);
            jhGood.strGoodsName = txtGoodsName.Text;
            jhGood.strGoodsUnit = cmbGoodsUnit.Text;
            jhGood.deGoodsJhPrice = txtGoodsJhPrice.Text;
            jhGood.deGoodsAllPrice = txtGoodsAllPrice.Text;
            jhGood.deGoodsSellPrice = txtGoodsSellPrice.Text;
            jhGood.strGoodsRemark = txtGoodsRemark.Text;
            jhGood.DaGoodTime = dateTimePicker1.Value;
            if (intFalg != 3)
            {
                jhGood.Falg = 0;
            }
            else
            {
                jhGood.Falg = 1;
            }
            intReslut = 1;
            return intReslut;
        }
        private void frmJhGoodsInfo_Load(object sender, EventArgs e)
        {
            jhMenthod.tb_JhGoodsInfoFind("", 5, dataGridView1);
        }
        private void FillControls()
        {
            try
            {
                
                SqlDataReader sqldr = jhMenthod.tb_JhGoodsInfoFind(this.dataGridView1[0, this.dataGridView1.CurrentCell.RowIndex].Value.ToString(),1);

                sqldr.Read();
                if (sqldr.HasRows)
                {

                     txtEmpId.Text=sqldr[1].ToString();
                      txtGoodsName.Text=sqldr[3].ToString();
                  
                    

                   txtGoodsNum.Text=sqldr[4].ToString();
                    cmbGoodsUnit.Text=sqldr[5].ToString();
                    txtGoodsJhPrice.Text=sqldr[6].ToString();
                    txtGoodsAllPrice.Text=sqldr[11].ToString();
                  　
                    txtGoodsSellPrice.Text=sqldr[7].ToString();
                    txtGoodsRemark.Text=sqldr[8].ToString();
                    txtJhCompName.Text = sqldr[2].ToString();
                 
                    txtGoodsID.Text = sqldr[0].ToString();
                   　txtGoodsID.Enabled = false;
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolAdd_Click(object sender, EventArgs e)
        {
            ControlStatus();
            ClearContorl();
            intFalg = 1;//添加标记
            txtGoodsID.Text = jhMenthod.JhGoodsID();
             txtGoodsID.Enabled = false;
        }

        private void toolAmend_Click(object sender, EventArgs e)
        {
            ControlStatus();
            ClearContorl();
            intFalg = 2;//添加标记
        }

        private void toolrefulsh_Click(object sender, EventArgs e)
        {
            ControlStatus();
            ClearContorl();
    

        }

        private void toolExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolCancel_Click(object sender, EventArgs e)
        {
            ControlStatus();
            ClearContorl();


        }

        private void toolSave_Click(object sender, EventArgs e)
        {
            if (getIntCount() == 1)
            {
                if (intFalg == 1)
                {
                    if (jhMenthod.tb_JhGoodsInfoMenthodAdd(jhGood)==2)
                    {
                        MessageBox.Show("添加成功","提示");
                        intFalg = 0;
                        jhMenthod.tb_JhGoodsInfoFind("",5,dataGridView1);
                        ControlStatus();
                        ClearContorl();
                    }
                    else
                    {
                        MessageBox.Show("添加失败", "提示");
                        intFalg = 0;
                        jhMenthod.tb_JhGoodsInfoFind("", 5, dataGridView1);
                        ControlStatus();
                        ClearContorl();
                    }

                }
                if (intFalg == 2)
                {
                    if (jhMenthod.tb_JhGoodsInfoMenthodUpdate(jhGood)==1)
                    {
                        MessageBox.Show("修改成功", "提示");
                        intFalg = 0;
                        jhMenthod.tb_JhGoodsInfoFind("", 5, dataGridView1);
                        ControlStatus();
                        ClearContorl();
                    }
                    else
                    {
                        MessageBox.Show("修改失败", "提示");
                        intFalg = 0;
                        jhMenthod.tb_JhGoodsInfoFind("", 5, dataGridView1);
                        ControlStatus();
                        ClearContorl();
                    }

                }
                if (intFalg == 3)
                {
                    if (jhMenthod.tb_JhGoodsInfoMenthodDelete(jhGood)==1)
                    {
                        MessageBox.Show("删除成功", "提示");
                        intFalg = 0;
                        jhMenthod.tb_JhGoodsInfoFind("", 5, dataGridView1);
                        ControlStatus();
                        ClearContorl();
                    }
                    else
                    {
                        MessageBox.Show("删除失败", "提示");
                        intFalg = 0;
                        jhMenthod.tb_JhGoodsInfoFind("", 5, dataGridView1);
                        ControlStatus();
                        ClearContorl();
                    }

                }
            
            
            
            }
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (intFalg == 2 || intFalg == 3)
            {
                FillControls();
            }
        }



        private void txtGoodsJhPrice_TextChanged(object sender, EventArgs e)
        {
           if ((txtGoodsNum.Text != "")&&(txtGoodsJhPrice.Text !=""))
            {

                txtGoodsAllPrice.Text = Convert.ToString(Convert.ToInt32(txtGoodsJhPrice.Text)*Convert.ToInt32(txtGoodsNum.Text));
            }

        }


        private void txtGoodsSellPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !char.IsDigit(e.KeyChar)&&e.KeyChar!='.') 
            {
                MessageBox.Show("请输入数字");
                e.Handled = true;
            }
        }

        private void txtGoodsNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !char.IsDigit(e.KeyChar)) 
            {
                MessageBox.Show("请输入数字");
                e.Handled = true;
            }
         
        }

        private void txtGoodsJhPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !char.IsDigit(e.KeyChar) && e.KeyChar != '.') 
            {
                MessageBox.Show("请输入数字");
                e.Handled = true;
            }
    

        }

       /* private void txtGoodsNoPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !char.IsDigit(e.KeyChar) && e.KeyChar != '.') 
            {
                MessageBox.Show("请输入数字");
                e.Handled = true;
            }
        }*/
        //供应商信息
        private void button1_Click(object sender, EventArgs e)
        {
            frmGonYingShang frmgong = new frmGonYingShang();
            frmgong.Owner = this;
            frmgong.ShowDialog();
        }


        private void tollDelete_Click(object sender, EventArgs e)
        {
            ControlStatus();
            ClearContorl();
            intFalg = 3;//添加标记
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtGoodsName_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtGoodsAllPrice_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmEmp frmemployee = new FrmEmp();
            frmemployee.Owner = this;
            frmemployee.ShowDialog();
        }

        private void txtJhCompName_TextChanged(object sender, EventArgs e)
        {

        }
 

      

        

       

        

       

       

       

   

 
    }
}