using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba1
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void tbValue1_Enter(object sender, EventArgs e)
        {
            if (tbValueAfter.Text == "y1")
            {
                tbValueAfter.Text = null;
            }
        }

        private void tbValue1_Leave(object sender, EventArgs e)
        {
            if (tbValueAfter.Text == "")
            {
                tbValueAfter.Text = "y1";
            }
        }

        private void tbValue2_Enter(object sender, EventArgs e)
        {
            if (tbValueBefore.Text == "y2")
            {
                tbValueBefore.Text = null;
            }
        }

        private void tbValue2_Leave(object sender, EventArgs e)
        {
            if (tbValueBefore.Text == "")
            {
                tbValueBefore.Text = "y2";
            }
        }

        private void tbAdequacy1_Enter(object sender, EventArgs e)
        {
            if (tbAdequacy1.Text == "y1")
            {
                tbAdequacy1.Text = null;
            }
        }

        private void tbAdequacy2_Enter(object sender, EventArgs e)
        {
            if (tbAdequacy2.Text == "y2")
            {
                tbAdequacy2.Text = null;
            }
        }

        private void tbAdequacy1_Leave(object sender, EventArgs e)
        {
            if (tbAdequacy1.Text == "")
            {
                tbAdequacy1.Text = "y1";
            }
        }

        private void tbAdequacy2_Leave(object sender, EventArgs e)
        {
            if (tbAdequacy2.Text == "")
            {
                tbAdequacy2.Text = "y2";
            }
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            tbValueAfter.Text = "0,3;0,8";
            tbValueBefore.Text = "0,4;0,9";
            tbAdequacy1.Text = "0,4;0,7";
            tbAdequacy2.Text = "0,3;0,8";
            tbOpt1.Text = "0,6";
            tbOpt2.Text = "0,7";
        }
        public double[,] generateValue(double y1after, double y1before, double y2after, double y2before)
        {
            double[,] data = new double[10, 2];
            for (int i = 0; i < data.GetLength(0); i++)
            {
                data[i, 0] = ((double)rnd.Next((int)(y1after * 10), (int)(y1before * 10))) / 10.0;
                data[i, 1] = ((double)rnd.Next((int)(y2after * 10), (int)(y2before * 10))) / 10.0;
            }
           for( int i=0;i<10;i++)
            {
                Console.WriteLine(data[i,0]+" "+data[i,1]);
            }
            return data;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab=tabPage2;
            for(int i = 0; i < 12; i++)
            {
                chart1.Series[i].Points.Clear();
            }
            chart1.Invalidate();
            double[,] temp=div(tbValueAfter.Text);
            double y1after = temp[0, 0];
            double y1before = temp[0, 1];
            temp = div(tbValueBefore.Text);
            double y2after = temp[0, 0];
            double y2before = temp[0, 1];
            double [,]data=generateValue(y1after,y1before,y2after,y2before);
            temp = div(tbAdequacy1.Text);
            double y1adequacyAfter = temp[0, 0];
            double y1adequacyBefore = temp[0, 1];
            temp = div(tbAdequacy2.Text);
            double y2adequacyAfter = temp[0, 0];
            double y2adequacyBefore = temp[0, 1];
            printBorderAdequacy(y1adequacyAfter, y1adequacyBefore, y2adequacyAfter, y2adequacyBefore);
            double y1optAfter= double.Parse(tbOpt1.Text)-0.1;
            double y1optBefore = double.Parse(tbOpt1.Text) + 0.1;
            double y2optAfter = double.Parse(tbOpt2.Text) - 0.1;
            double y2optBefore = double.Parse(tbOpt2.Text) + 0.10001;
            printBorderOptima(y1optAfter, y1optBefore, y2optAfter, y2optBefore, y1adequacyAfter, y1adequacyBefore, y2adequacyAfter, y2adequacyBefore);
            printPerfectPoint(data, y1optAfter, y1optBefore, y2optAfter, y2optBefore, y1adequacyAfter, y1adequacyBefore, y2adequacyAfter, y2adequacyBefore);
        }
        public void printPerfectPoint(double[,]data, double b1, double b2, double b3, double b4, double ab1, double ab2, double ab3, double ab4)
        {
            for(int i=0; i<data.GetLength(0); i++)
            {
                if ((data[i, 0] >= b1 & data[i, 0]<=b2) && (data[i, 1] >= b3 & data[i, 1]<= b4))
                {
                    chart1.Series[0].Points.AddXY(data[i, 0], data[i, 1]);
                }
                else if(((data[i, 0] >= b1 & data[i, 0] <=b2)|(data[i, 1] >= b3 & data[i, 1]<=b4))&& (data[i, 0] >= ab1 & data[i, 0] <= ab2 && data[i, 1] >= ab3 & data[i, 1] <= ab4))
                {
                    chart1.Series[1].Points.AddXY(data[i, 0], data[i, 1]);
                }
                else if (data[i, 0] >= ab1 &  data[i, 0]<=ab2 && data[i, 1] >= ab3 & data[i, 1] <= ab4)
                {
                    chart1.Series[2].Points.AddXY(data[i, 0], data[i, 1]);
                }
                else
                {
                    chart1.Series[3].Points.AddXY(data[i, 0], data[i, 1]);
                }

            }
        }
        public void printBorderAdequacy(double b1, double b2, double b3, double b4)
        {
            for (double i = b3; i <= b4; i+=0.1)
            {
                chart1.Series[4].Points.AddXY(b1,i);
                chart1.Series[5].Points.AddXY(b2,i);
            }
            for (double i = b1; i <= b2; i += 0.1)
            {
                chart1.Series[6].Points.AddXY(i,b3);
                chart1.Series[7].Points.AddXY(i,b4);
            }
        }
        public void printBorderOptima(double b1, double b2, double b3, double b4, double ad1, double ad2, double ad3, double ad4)
        {
            for (double i = ad3; i <= ad4; i += 0.1)
            {
                chart1.Series[8].Points.AddXY(b1, i);
                chart1.Series[9].Points.AddXY(b2, i);
            }
            for (double i = ad1; i <= ad2; i += 0.1)
            {
                chart1.Series[10].Points.AddXY(i, b3);
                chart1.Series[11].Points.AddXY(i, b4);
            }
        }
        public double[,] div(string str)
        {
            double[,] data = new double[1, 2];
            string numbers = null;

            for (int i = 0; i < str.Length; i++)
            {
                if (str.ElementAt(i) != ';')
                {
                    numbers += str.ElementAt(i);
                }
                else
                {
                    //Console.WriteLine(numbers);
                    data[0, 0] = double.Parse(numbers);
                    numbers = null;
                }
            }
            //Console.WriteLine(numbers);
            data[0, 1] = double.Parse(numbers);
            numbers = null;
            return data;
        }
    }
}
