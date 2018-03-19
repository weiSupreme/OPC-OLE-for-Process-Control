using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Collections;
using OPCAutomation;

namespace OPCClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// 定义变量
        /// </summary>
        OPCServer KepServer;
        OPCGroups KepGroups;
        OPCGroup KepGroup;
        OPCBrowser oPCBrowser;
        OPCItems KepItems;
        OPCItem KepItem;

        int itmHandleClient = 0;
        int itmHandleServer = 0;
        
        /// <summary>
        /// 获取本地的OPC Server
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                KepServer = new OPCServer();
                object serverList = KepServer.GetOPCServers("");
                cmbServerName.Items.Clear();
                foreach (string turn in (Array)serverList)
                {
                    cmbServerName.Items.Add(turn);
                }

                cmbServerName.SelectedIndex = 0;
                connect.Enabled = true;
            }
            catch (Exception err)
            {
                MessageBox.Show("枚举本地OPC服务器出错：" + err.Message, "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

         /// <summary>
        /// 列出OPC服务器中所有节点
        /// </summary>
        private void RecurBrowse(OPCBrowser oPCBrowser)
        {
            //展开分支
            oPCBrowser.ShowBranches();
            //展开叶子
            oPCBrowser.ShowLeafs(true);
            foreach (object turn in oPCBrowser)
            {
                //if (string.Compare(turn.ToString(),"Tags")==0)//
                if((turn.ToString().IndexOf("Tags"))>-1)
                {
                    listBox1.Items.Add(turn.ToString());
                }
                
            }
        }

        /// <summary>
        /// 建立连接按钮
        /// </summary>
        private void connect_Click(object sender, EventArgs e)  
        {

            try
            {
                KepServer.Connect(cmbServerName.Text);
                KepGroups = KepServer.OPCGroups;
                KepServer.OPCGroups.DefaultGroupIsActive = true;
                KepServer.OPCGroups.DefaultGroupDeadband = 0;
                KepServer.OPCGroups.DefaultGroupUpdateRate = 250;
                KepGroup = KepGroups.Add("OPCDOTNETGROUP");

                KepGroup.IsActive = true;
                KepGroup.IsSubscribed = true;

                oPCBrowser = KepServer.CreateBrowser();
                oPCBrowser.ShowBranches();
                oPCBrowser.ShowLeafs(true);

                listBox1.Items.Clear();
                RecurBrowse(oPCBrowser);

                KepGroup.DataChange += new DIOPCGroupEvent_DataChangeEventHandler(KepGroup_DataChange);
                //KepGroup.AsyncWriteComplete += new DIOPCGroupEvent_AsyncWriteCompleteEventHandler(KepGroup_AsyncWriteComplete);
                KepItems = KepGroup.OPCItems;
            }
            catch (Exception err)
            {
                MessageBox.Show("连接服务器出现错误：" + err.Message, "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        }

        /// <summary>
        /// 每当项数据有变化时执行的事件
        /// </summary>
        /// <param name="TransactionID">处理ID</param>
        /// <param name="NumItems">项个数</param>
        /// <param name="ClientHandles">项客户端句柄</param>
        /// <param name="ItemValues">TAG值</param>
        void KepGroup_DataChange(int TransactionID, int NumItems, ref Array ClientHandles, ref Array ItemValues, ref Array Qualities, ref Array TimeStamps)
        {
            for (int i = 1; i <= NumItems; i++)
            {
                this.TagValue.Text = ItemValues.GetValue(i).ToString();
            }
        }

        /// <summary>
        /// 【按钮】写入
        /// </summary>
        private void btnWrite_Click(object sender, EventArgs e)
        {
            OPCItem bItem = KepItems.GetOPCItem(itmHandleServer);
            int[] temp = new int[2] { 0, bItem.ServerHandle };
            Array serverHandles = (Array)temp;
            object[] valueTemp = new object[2] { "", textBox1.Text };
            Array values = (Array)valueTemp;
            Array Errors;
            int cancelID;
            KepGroup.AsyncWrite(1, ref serverHandles, ref values, out Errors, 2009, out cancelID);
            GC.Collect();
        }

        /// <summary>
        /// 关闭窗体时处理的事情
        /// </summary>
        private void MainFrom_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (KepGroup != null)
            {
                KepGroup.DataChange -= new DIOPCGroupEvent_DataChangeEventHandler(KepGroup_DataChange);
            }

            if (KepServer != null)
            {
                KepServer.Disconnect();
                KepServer = null;
            }
        }


        //选中事件
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (itmHandleClient != 0)
                {
                    this.TagValue.Text = "";

                    Array Errors;
                    OPCItem bItem = KepItems.GetOPCItem(itmHandleServer);
                    //注：OPC中以1为数组的基数
                    int[] temp = new int[2] { 0, bItem.ServerHandle };
                    Array serverHandle = (Array)temp;
                    //移除上一次选择的项
                    KepItems.Remove(KepItems.Count, ref serverHandle, out Errors);
                }
                itmHandleClient = 1;
                KepItem = KepItems.AddItem(listBox1.SelectedItem.ToString(), itmHandleClient);
                itmHandleServer = KepItem.ServerHandle;
                TagValue.Text = KepItem.ToString();
            }
            catch (Exception err)
            {
                //没有任何权限的项，都是OPC服务器保留的系统项，此处可不做处理。
                itmHandleClient = 0;
                TagValue.Text = "Error ox";
                MessageBox.Show("此项为系统保留项:" + err.Message, "提示信息");
            }
        }

        //退出按钮
        private void button2_Click(object sender, EventArgs e)
        {
            if (KepGroup != null)
            {
                KepGroup.DataChange -= new DIOPCGroupEvent_DataChangeEventHandler(KepGroup_DataChange);
            }

            if (KepServer != null)
            {
                KepServer.Disconnect();
                KepServer = null;
            }
            this.Close();
        }

    }
}
