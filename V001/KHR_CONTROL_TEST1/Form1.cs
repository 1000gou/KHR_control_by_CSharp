using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Extensions.Collections;
using Rcb4;

namespace KHR_CONTROL_TEST1
{
    public partial class Form1 : Form
    {
        int m_コマンド数;

        public Form1()
        {
            InitializeComponent();
        }

        private void シリアルポートを開く()
        {
            シリアルポート.Close(); // ポートをいったん閉じる
            //シリアルポート.PortName = "COM3";
            シリアルポート.Open();
        }

        private void シリアルポートを閉じる()
        {
            シリアルポート.Close();
        }

        private void 送信ボタン_Click(object sender, EventArgs e)
        {
            シリアルポートを開く();
            
            if (!シリアルポート.IsOpen)
            {
                MessageBox.Show ("COMポートが接続されていません。");
                return;
            }

            if (コマンドテキストボックス.Text == string.Empty)
            {
                MessageBox.Show ("コマンドが生成されていません。");
                return;
            }
            
            // 送信コマンド
            ByteList cmd = new ByteList ();
            cmd.CommaText = コマンドテキストボックス.Text;
              
            // 返事を受け取る配列
            m_コマンド数 = 4;
            byte[] recv = new byte[m_コマンド数];

            bool result = Command.Synchronize(シリアルポート, cmd.Bytes, ref recv);

            if(result == true){
                RCB返信テキストボックス.BackColor = SystemColors.Window;
            }else{
                RCB返信テキストボックス.BackColor = Color.Red;
            }
            
            // 返事をいったんByteListで受け取る
            cmd.Bytes = recv;
            // 返事を書き出す
            RCB返信テキストボックス.Text = cmd.CommaText;


            シリアルポートを閉じる();
        }
    }
}

