﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace D2K_2204_2._0
{
    public partial class Form1 : Form
    {
        ushort[] card_value = { D2KDASK.DAQ_2005, D2KDASK.DAQ_2006, D2KDASK.DAQ_2010, D2KDASK.DAQ_2016, D2KDASK.DAQ_2020,
            D2KDASK.DAQ_2022, D2KDASK.DAQ_2204, D2KDASK.DAQ_2205, D2KDASK.DAQ_2206, D2KDASK.DAQ_2208, D2KDASK.DAQ_2213, D2KDASK.DAQ_2214, D2KDASK.DAQ_2501, D2KDASK.DAQ_2502 };
        String[] Card_Name = { "DAQ-2005", "DAQ-2006", "DAQ-2010", "DAQ-2016", "DAQ-2020", "DAQ-2022", "DAQ-2204", "DAQ-2205", "DAQ-2206", "DAQ-2208", "DAQ-2213", "DAQ-2214", "DAQ-2501", "DAQ-2502" };
        int count = 0;
        short m_dev = -1;
        ushort cardT = 0;
        ushort cardnum = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "AI Read: " + Card_Name[0];
            m_dev = D2KDASK.D2K_Register_Card(card_value[cardT], 0);
            if (m_dev < 0)
            {
                //MessageBox.Show("D2K_Register_Card error!");
                MessageBox.Show("Select Device First!");
                button1.Enabled = false;
                button2.Enabled = false;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            short err;
            if (m_dev >= 0)
            {
                err = D2KDASK.D2K_Release_Card((ushort)m_dev);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            short err;

            button1.Enabled = false;
            button3.Enabled = false;

            count = 1;                                                               //采集卡通道量程配置标志位
            err = D2KDASK.D2K_AI_CH_Config((ushort)m_dev, -1, D2KDASK.AD_B_10_V);    //配置所有通道的量程
            if (err < 0)
            {
                MessageBox.Show("D2K_AI_CH_Config error!");
                return;
            }

            button2.Enabled = true;                                //停止键使能
            timer1.Enabled = true;                                 //打开定时间开始采集数据                                             
        }

        private void button2_Click(object sender, EventArgs e)                        //停止按键
        {
            short err = 0;
            uint start_pos;
            uint access_cnt;

            timer1.Enabled = false;
            err = D2KDASK.D2K_AI_AsyncClear((ushort)m_dev, out start_pos, out access_cnt);
            button2.Enabled = true;
            button1.Enabled = true;
        }
         
        private void button3_Click(object sender, EventArgs e)                        //设置按键
        {
            Form2 subForm = new Form2();
            subForm.ShowDialog();
            if (m_dev >= 0)
            {
                short ret;
                ret = D2KDASK.D2K_Release_Card((ushort)m_dev);
            }
            cardT = (ushort)subForm.comboBox1.SelectedIndex;
            cardnum = (ushort)subForm.comboBox2.SelectedIndex;
            m_dev = D2KDASK.D2K_Register_Card(card_value[cardT], cardnum);
            if (m_dev < 0)
            {
                MessageBox.Show("D2K_Register_Card error!");
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
                this.Text = "AI Read: " + Card_Name[cardT];
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //short err;

            if (count == 0)
            {
                return;
            }
            DataCollect((ushort)m_dev, 0);
        }

        private void DataCollect(ushort DC_cardnum, ushort DC_chnum)               //采集不同通道电压的函数
        {
            string str_tmp;
            short err;
            double voltage;
            err = D2KDASK.D2K_AI_VReadChannel(DC_cardnum, DC_chnum, out voltage);         //输出通道1电压
            if (err < 0)
            {
                MessageBox.Show("D2K_AI_VReadChannel error!");
                return;
            }
            str_tmp = string.Format("{0}", voltage);
            textBox1.Text = str_tmp;
        }
    }
}
