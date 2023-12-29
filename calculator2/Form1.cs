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

        private void btn0_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {

        }

        private void btn2_Click(object sender, EventArgs e)
        {

        }

        private void btn3_Click(object sender, EventArgs e)
        {

        }

        private void btn4_Click(object sender, EventArgs e)
        {

        }

        private void btn5_Click(object sender, EventArgs e)
        {

        }

        private void btn6_Click(object sender, EventArgs e)
        {

        }

        private void btn7_Click(object sender, EventArgs e)
        {

        }

        private void btn8_Click(object sender, EventArgs e)
        {

        }

        private void btn9_Click(object sender, EventArgs e)
        {

        }

        private void btnDot_Click(object sender, EventArgs e)
        {

        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {

        }

        private void btnErase_Click(object sender, EventArgs e)
        {

        }

    }
}
