﻿namespace CHEXC
{
    partial class frmMain
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.statusUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.statuslabMenuInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStockManage = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGoodsIn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuFind = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuBaseManage = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCompany = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuSellManage = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSellGoods = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuSellFind = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDepotManage = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDepotAlarm = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.menuDepotFind = new System.Windows.Forms.ToolStripMenuItem();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusUser
            // 
            this.statusUser.BorderStyle = System.Windows.Forms.Border3DStyle.Raised;
            this.statusUser.Name = "statusUser";
            this.statusUser.Size = new System.Drawing.Size(347, 28);
            this.statusUser.Spring = true;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(15, 28);
            this.toolStripStatusLabel1.Text = "|";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(15, 28);
            this.toolStripStatusLabel2.Text = "|";
            // 
            // statusTime
            // 
            this.statusTime.Name = "statusTime";
            this.statusTime.Size = new System.Drawing.Size(347, 28);
            this.statusTime.Spring = true;
            // 
            // statuslabMenuInfo
            // 
            this.statuslabMenuInfo.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.statuslabMenuInfo.Name = "statuslabMenuInfo";
            this.statuslabMenuInfo.Overflow = System.Windows.Forms.ToolStripItemOverflow.Always;
            this.statuslabMenuInfo.Size = new System.Drawing.Size(347, 28);
            this.statuslabMenuInfo.Spring = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statuslabMenuInfo,
            this.toolStripStatusLabel1,
            this.statusUser,
            this.toolStripStatusLabel2,
            this.statusTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 354);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1094, 33);
            this.statusStrip1.Stretch = false;
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStockManage
            // 
            this.menuStockManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuGoodsIn,
            this.toolStripMenuItem2,
            this.menuFind});
            this.menuStockManage.Name = "menuStockManage";
            this.menuStockManage.Size = new System.Drawing.Size(118, 28);
            this.menuStockManage.Text = "采购管理[&C]";
            // 
            // menuGoodsIn
            // 
            this.menuGoodsIn.Name = "menuGoodsIn";
            this.menuGoodsIn.Size = new System.Drawing.Size(228, 28);
            this.menuGoodsIn.Tag = "5";
            this.menuGoodsIn.Text = "采购单[&S]";
            this.menuGoodsIn.Click += new System.EventHandler(this.menuGoodsIn_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(225, 6);
            // 
            // menuFind
            // 
            this.menuFind.Name = "menuFind";
            this.menuFind.Size = new System.Drawing.Size(228, 28);
            this.menuFind.Tag = "7";
            this.menuFind.Text = "采购单商品查询[&F]";
            this.menuFind.Click += new System.EventHandler(this.menuFind_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(194, 6);
            // 
            // menuBaseManage
            // 
            this.menuBaseManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuEmployee,
            this.menuCompany,
            this.toolStripMenuItem1});
            this.menuBaseManage.Name = "menuBaseManage";
            this.menuBaseManage.Size = new System.Drawing.Size(117, 28);
            this.menuBaseManage.Text = "基本档案[&B]";
            this.menuBaseManage.Click += new System.EventHandler(this.menuBaseManage_Click);
            // 
            // menuEmployee
            // 
            this.menuEmployee.Name = "menuEmployee";
            this.menuEmployee.Size = new System.Drawing.Size(197, 28);
            this.menuEmployee.Tag = "1";
            this.menuEmployee.Text = "员工信息[&E]";
            this.menuEmployee.Click += new System.EventHandler(this.menuEmployee_Click);
            // 
            // menuCompany
            // 
            this.menuCompany.Name = "menuCompany";
            this.menuCompany.Size = new System.Drawing.Size(197, 28);
            this.menuCompany.Tag = "2";
            this.menuCompany.Text = "供应商信息[&Q]";
            this.menuCompany.Click += new System.EventHandler(this.menuCompany_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBaseManage,
            this.menuStockManage,
            this.menuSellManage,
            this.menuDepotManage});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1094, 34);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuSellManage
            // 
            this.menuSellManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSellGoods,
            this.toolStripMenuItem3,
            this.menuSellFind});
            this.menuSellManage.Name = "menuSellManage";
            this.menuSellManage.Size = new System.Drawing.Size(116, 28);
            this.menuSellManage.Text = "销售管理[&S]";
            // 
            // menuSellGoods
            // 
            this.menuSellGoods.Name = "menuSellGoods";
            this.menuSellGoods.Size = new System.Drawing.Size(179, 28);
            this.menuSellGoods.Tag = "8";
            this.menuSellGoods.Text = "销售单[&G]";
            this.menuSellGoods.Click += new System.EventHandler(this.menuSellGoods_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(176, 6);
            // 
            // menuSellFind
            // 
            this.menuSellFind.Name = "menuSellFind";
            this.menuSellFind.Size = new System.Drawing.Size(179, 28);
            this.menuSellFind.Tag = "10";
            this.menuSellFind.Text = "商品退货[&O]";
            this.menuSellFind.Click += new System.EventHandler(this.menuSellFind_Click);
            // 
            // menuDepotManage
            // 
            this.menuDepotManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDepotAlarm,
            this.toolStripMenuItem4,
            this.menuDepotFind});
            this.menuDepotManage.Name = "menuDepotManage";
            this.menuDepotManage.Size = new System.Drawing.Size(120, 28);
            this.menuDepotManage.Text = "库存管理[&D]";
            // 
            // menuDepotAlarm
            // 
            this.menuDepotAlarm.Name = "menuDepotAlarm";
            this.menuDepotAlarm.Size = new System.Drawing.Size(182, 28);
            this.menuDepotAlarm.Tag = "12";
            this.menuDepotAlarm.Text = "库存报警[&J]";
            this.menuDepotAlarm.Click += new System.EventHandler(this.menuDepotAlarm_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(179, 6);
            // 
            // menuDepotFind
            // 
            this.menuDepotFind.Name = "menuDepotFind";
            this.menuDepotFind.Size = new System.Drawing.Size(182, 28);
            this.menuDepotFind.Tag = "13";
            this.menuDepotFind.Text = "库存查询[&M]";
            this.menuDepotFind.Click += new System.EventHandler(this.menuDepotFind_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = global::CHEXC.Properties.Resources.登录改良;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1094, 387);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "超市进销存销售管理系统";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripStatusLabel statusUser;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel statusTime;
        private System.Windows.Forms.ToolStripStatusLabel statuslabMenuInfo;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuStockManage;
        private System.Windows.Forms.ToolStripMenuItem menuGoodsIn;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem menuFind;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuBaseManage;
        private System.Windows.Forms.ToolStripMenuItem menuEmployee;
        private System.Windows.Forms.ToolStripMenuItem menuCompany;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuSellManage;
        private System.Windows.Forms.ToolStripMenuItem menuSellGoods;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem menuSellFind;
        private System.Windows.Forms.ToolStripMenuItem menuDepotManage;
        private System.Windows.Forms.ToolStripMenuItem menuDepotAlarm;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem menuDepotFind;
        private System.Windows.Forms.Timer timer2;
    }
}