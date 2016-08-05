using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace ML_function
{
    public partial class Form1 : Form
    {
        int countIteration = 0;
        double[] theta = { 0, 0 };
        double[,] data ={
{6.1101,17.592},
{5.5277,9.1302},
{ 8.5186,13.662},
{ 7.0032,11.854},
{ 5.8598,6.8233},
{ 8.3829,11.886},
{ 7.4764,4.3483},
{ 8.5781,12},
{ 6.4862,6.5987},
{ 5.0546,3.8166},
{ 5.7107,3.2522},
{ 14.164,15.505},
{ 5.734,3.1551},
{ 8.4084,7.2258},
{ 5.6407,0.71618},
{ 5.3794,3.5129},
{ 6.3654,5.3048},
{ 5.1301,0.56077},
{ 6.4296,3.6518},
{ 7.0708,5.3893},
{ 6.1891,3.1386},
{ 20.27,21.767},
{ 5.4901,4.263},
{ 6.3261,5.1875},
{ 5.5649,3.0825},
{ 18.945,22.638},
{ 12.828,13.501},
{ 10.957,7.0467},
{ 13.176,14.692},
{ 22.203,24.147},
{ 5.2524,-1.22},
{ 6.5894,5.9966},
{ 9.2482,12.134},
{ 5.8918,1.8495},
{ 8.2111,6.5426},
{ 7.9334,4.5623},
{ 8.0959,4.1164},
{ 5.6063,3.3928},
{ 12.836,10.117},
{ 6.3534,5.4974},
{ 5.4069,0.55657},
{ 6.8825,3.9115},
{ 11.708,5.3854},
{ 5.7737,2.4406},
{ 7.8247,6.7318},
{ 7.0931,1.0463},
{ 5.0702,5.1337},
{ 5.8014,1.844},
{ 11.7,8.0043},
{ 5.5416,1.0179},
{ 7.5402,6.7504},
{ 5.3077,1.8396},
{ 7.4239,4.2885},
{ 7.6031,4.9981},
{ 6.3328,1.4233},
{ 6.3589,-1.4211},
{ 6.2742,2.4756},
{ 5.6397,4.6042},
{ 9.3102,3.9624},
{ 9.4536,5.4141},
{ 8.8254,5.1694},
{ 5.1793,-0.74279},
{ 21.279,17.929},
{ 14.908,12.054},
{ 18.959,17.054},
{ 7.2182,4.8852},
{ 8.2951,5.7442},
{ 10.236,7.7754},
{ 5.4994,1.0173},
{ 20.341,20.992},
{ 10.136,6.6799},
{ 7.3345,4.0259},
{ 6.0062,1.2784},
{ 7.2259,3.3411},
{ 5.0269,-2.6807},
{ 6.5479,0.29678},
{ 7.5386,3.8845},
{ 5.0365,5.7014},
{ 10.274,6.7526},
{ 5.1077,2.0576},
{ 5.7292,0.47953},
{ 5.1884,0.20421},
{ 6.3557,0.67861},
{ 9.7687,7.5435},
{ 6.5159,5.3436},
{ 8.5172,4.2415},
{ 9.1802,6.7981},
{ 6.002,0.92695},
{ 5.5204,0.152},
{ 5.0594,2.8214},
{ 5.7077,1.8451},
{ 7.6366,4.2959},
{ 5.8707,7.2029},
{ 5.3054,1.9869},
{ 8.2934,0.14454},
{ 13.394,9.0551},
{ 5.4369,0.61705}
};
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            plotData(data);

        }
        public double costFunction(double[,] data,double []theta)
        {
            int size=data.GetLength(0);
            double temp = 0;
            for (int i = 0; i < size; i++)
            {
                temp += Math.Pow((theta[0] + theta[1] * data[i,0] - data[i,1]), 2);
            }
            return temp/(2*size);
        }
        public double[] gradientDescent(double[,] data, double[] theta,double alpha,int iter,int demonstrationSpeed)
        {
            int size = data.GetLength(0);
            int saveCountIteration = countIteration;
            for (; countIteration <= saveCountIteration+iter; countIteration++)
            {
                double temp;
                for (int i = 0; i < size; i++)
                {
                    temp = theta[0] + theta[1] * data[i, 0] - data[i, 1];
                    theta[0] -= temp * alpha / size;
                    theta[1] -= data[i, 0] * temp * alpha / size;
                }
                chart1.Series[0].Points.AddXY(countIteration, costFunction(data, theta));
                if (demonstrationSpeed != 0 && countIteration % demonstrationSpeed == 0)
                {
                    Console.Write(countIteration);
                    plotHypothesis(data, theta);
                    Refresh();
                    System.Threading.Thread.Sleep(1000);
                }
               

            }
            // Console.Write(theta[0] + "    " + theta[1]);
            return theta;
        }
        public void plotData(double[,] data)
        {
            for (int i = 0; i < data.GetLength(0); i++) {
                chart.Series[0].Points.AddXY(data[i, 0], data[i, 1]);
            }
        }
        public void plotHypothesis(double[,] data,double[] theta)
        {
            
            chart.Series[1].Points.Clear();
            for (int i = 0; i < data.GetLength(0); i++)
            {
                
                chart.Series[1].Points.AddXY(data[i, 0], theta[0]+theta[1]*data[i, 0]);
                //chart.Series[1].Points.Invalidate();
            }
            chart.Invalidate();
        }

        private void run_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null & textBox2.Text != null)
            {
                double alpha = Double.Parse(textBox1.Text);
                int iteration = Int32.Parse(textBox2.Text);
                int demonstrationSpeed = trackBar1.Value;
               // Thread myThread = new Thread(gradientDescent(data, theta, alpha, iteration, demonstrationSpeed)); //Создаем новый объект потока (Thread)
                //myThread.Start(); //запускаем поток

                theta = gradientDescent(data, theta,alpha ,iteration, demonstrationSpeed);
                plotHypothesis(data, theta);
            }
            else
            {
                MessageBox.Show("Введите значения");
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != ',')
            {
                e.Handled = true;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {   
            if(trackBar1.Value!=0)
            label4.Text = trackBar1.Value + " Итераций / сек";
            else
             label4.Text = "Демонстрация отключена";
        }
        public void hyperbol()
        {
            double y = 0;
            for ( double x = -5; x < 5; x += 0.01)
            {
                y = -x * x;
                chart.Series[1].Points.AddXY(x,y);
            }

        }

    }
}
