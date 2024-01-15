using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator2
{
    // Mainメソッドにより最初に呼ばれる
    public partial class Form1 : Form
    {

        string StrAnswer = ""; //Answer表示用
        string Operators = ""; //演算子格納用
        decimal Num1 = 0; //計算用1
        decimal Num2 = 0; //計算用2
        


        public Form1()
        {
            InitializeComponent();
        }

        // 電卓を初期状態に戻す
        public void InitializeCalc()
        {
            StrAnswer = "0";
            Operators = "0";
            Num1 = 0;
            Num2 = 0;
            Answer.Text = StrAnswer;
            Formula.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeCalc();
        }

        private void BtnNum_Click(object sender, EventArgs e)
        {
            if(StrAnswer == "0")
            {
                StrAnswer = ((Button)sender).Text;
            }
            else
            {
                StrAnswer += ((Button)sender).Text;
            }            
            Answer.Text = StrAnswer;
        }

        private void BtnDot_Click(object sender, EventArgs e)
        {

        }

        private void BtnSwitch_Click(object sender, EventArgs e)
        {

        }

        private void BtnErase_Click(object sender, EventArgs e)
        {

        }

    }
}
