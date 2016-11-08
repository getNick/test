using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lb2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();  
        }
        private double SpirmanValue()
        {
            double temp = 0;
            int n = getCountObj();
            for (int i = 0; i < n; i++)
            {
                temp += double.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString()); ;
            }
            temp = 1 - ((6 * temp) / (n * (Math.Pow(n, 2) - 1)));
            return temp;
        }
        private double[,] getRang(double[,] temp)
        {
            temp = sortBubble(temp);
            for (int i = 0; i < temp.GetLength(0);)
            {
                int countElem = countElementInArr(temp[i, 1], temp);
                double rang = calculateRang(i, countElem);
                for (; countElem != 0; countElem--, i++)
                {
                    temp[i, 2] = rang;
                    //Console.WriteLine(temp[i, 0] + "  " + temp[i, 1] + " " + temp[i, 2]);
                }
            }
            return temp;
        }
        private double[,] sortBubble(double[,] arr)
        {
            int longArr = arr.GetLength(0);
            double temp;
            bool exit = false;
            while (!exit)
            {
                exit = true;
                for (int i = 0; i < longArr - 1; i++)
                {
                    if (arr[i,1] < arr[i + 1,1])
                    {
                        temp = arr[i,1];
                        arr[i,1] = arr[i + 1,1];
                        arr[i + 1,1] = temp;

                        temp = arr[i, 0];
                        arr[i, 0] = arr[i + 1, 0];
                        arr[i + 1, 0] = temp;
                        
                        exit = false;
                    }
                }
            }
            /*for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.WriteLine(arr[i,0]+"  "+arr[i, 1]);
            }*/

            return arr;
        }
        private int countElementInArr(double temp, double [,]data)
        {
            int count = 0;
            for(int i = 0; i < data.GetLength(0); i++)
            {
                if (data[i, 1] == temp)
                {
                    count++;
                }
            }
            return count;
        }
        private double calculateRang(int lastRang,int countElem)
        {
            double rang = 0;
            lastRang++;
            for (int i= 0; i<countElem;i++,lastRang++)
            {
                rang += lastRang;
            }
            return rang/countElem;
        }
        private void pressDigit(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void tbCountObj_TextChanged(object sender, EventArgs e)
        {
            try {
                dataGridView1.Columns.Clear();
                int count = getCountObj();
                dataGridView1.Columns.Add("Object", "Object");
                dataGridView1.RowCount = count;
                for (int i = 0; i < count; i++)
                {
                    dataGridView1.Rows[i].Cells[0].Value = i + 1;
                }
            }
            catch (Exception)
            {

            }

            try
            {
                int count = getCountExp();
                for (int i = 0; i < count; i++)
                {
                    dataGridView1.Columns.Add("expert" + (i + 1), "expert" + (i + 1));
                }
            }
            catch (Exception)
            {

            }

        }
        private int getCountObj()
        {
            int count = int.Parse(tbCountObj.Text);
            return count;
        }
        private int getCountObj2()
        {
            int count = int.Parse(tbCountObj2.Text);
            return count;
        }
        private int getCountExp()
        {
            int count = int.Parse(tbCountExp.Text);
            return count;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try { 
            int countExp = getCountExp();
            int countObj = getCountObj();
            dataGridView1.ColumnCount = countExp + 1;
                for (int i = 0; i < countExp; i++)
                {
                    dataGridView1.Columns.Add("rang" + (i + 1), "rang" + (i + 1));
                }
            
            for (int j = 1; j <=countExp; j++)
            {
                double[,] temp = new double[countObj, 3];
                for (int i = 0; i < countObj; i++)
                {
                    temp[i, 0] = double.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString());
                    temp[i, 1] = double.Parse(dataGridView1.Rows[i].Cells[j].Value.ToString());
                }
                temp = getRang(temp);
                for (int i = 0; i < countObj; i++)
                {
                    dataGridView1.Rows[((int)temp[i, 0]) - 1].Cells[j+ countExp].Value = temp[i, 2];
                }
             }
                //опредиление степени согласованости 
                if (comboBox1.SelectedIndex == 0)
                {
                    if (dataGridView1.ColumnCount == countExp * 2 + 1)
                    {
                        dataGridView1.Columns.Add("square(d)", "square(d)");
                    }
                    for (int i = 0; i < countObj; i++)
                    {
                        double n = 0;
                        n = Math.Pow(double.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString()) - double.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString()), 2.0);
                        dataGridView1.Rows[i].Cells[5].Value = n;
                    }
                    label1.Text = "Коэффициент Спирмена = " + SpirmanValue();
                }
                else
                {
                    if (dataGridView1.ColumnCount == countExp * 2 + 1)
                    {
                        dataGridView1.Columns.Add("sumRang", "sumRang");
                        dataGridView1.Columns.Add("square(d)", "square(d)");
                    }
                    double srAlgeb = 0;
                    for (int i = 0; i < countObj; i++)
                    {
                        double n = 0;
                        for (int j = 0; j < countExp; j++)
                        {
                            n += double.Parse(dataGridView1.Rows[i].Cells[countExp+ 1 + j].Value.ToString());//сумма рангов каждого объекта
                        }
                        dataGridView1.Rows[i].Cells[countExp * 2 + 1].Value = n;
                        srAlgeb += n;
                    }
                    srAlgeb /= countObj;
                    double sumOtk = 0;//сумма квадратов отклонений сумм рангов
                    for (int i = 0; i < countObj; i++)
                    {
                        double n = double.Parse(dataGridView1.Rows[i].Cells[countExp * 2 + 1].Value.ToString());
                        sumOtk += Math.Pow(srAlgeb - n, 2.0);
                        dataGridView1.Rows[i].Cells[countExp * 2 + 2].Value = sumOtk;
                    }
                    label1.Text = "Коэффициент конкордации = " + konkordation(sumOtk);


                }
            
                double[] sumRang = new double[2];
                for (int i = 0; i <countObj ; i++)
                {
                    sumRang[0] += double.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
                    sumRang[1] += double.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
                }
            
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Укажите количество объктов и экспертов");
            }
        }
        private double konkordation(double s)
        {
            s = (12 * s) / (Math.Pow(getCountExp(), 2.0) * (Math.Pow(getCountObj(), 3.0) - getCountObj()));
            return s;
        }
        private void btnRandomValue_Click(object sender, EventArgs e)
        {
            try {
                Random rnd = new Random();
                for (int i = 0; i < getCountObj(); i++)
                {
                    for (int j = 0; j < getCountExp(); j++)
                    {
                        dataGridView1.Rows[i].Cells[j + 1].Value = rnd.Next(1, 11);
                    }
                }
            }catch(System.FormatException)
            {
                MessageBox.Show("Укажите количество объктов и экспертов");
            }
            btnCalculate_Click(null, null);
        }

        private void tbCountObj2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridView2.Columns.Clear();
                int count = getCountObj2();
                dataGridView2.Columns.Add("Object", "Object");
                dataGridView2.Columns.Add("Value", "Value");
                dataGridView2.RowCount = count+4;
                for (int i = 0; i < count; i++)
                {
                    dataGridView2.Rows[i].Cells[0].Value = i + 1;
                }
            }
            catch (Exception)
            {

            }
        }
        private void calculate()
        {
            int count = getCountObj2();
            double temp = 1;
            double temp2 = 1;
            //среднее геометрическое
            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < count; j++)
                {
                    temp *= double.Parse(dataGridView2.Rows[i].Cells[j + 2].Value.ToString());
                    temp2 *= double.Parse(dataGridView2.Rows[j].Cells[i + 2].Value.ToString());
                }
                dataGridView2.Rows[i].Cells[count + 2].Value = Math.Pow(temp, 1.0 / count);
                dataGridView2.Rows[count].Cells[i + 2].Value = Math.Pow(temp2, 1.0 / count);
                temp = 1;
                temp2 = 1;
            }
            //Компонента вектора приоритов
            temp = 0;
            temp2 = 0;
            for (int i = 0; i < count; i++)
            {
                temp += double.Parse(dataGridView2.Rows[i].Cells[count + 2].Value.ToString());
                temp2 += double.Parse(dataGridView2.Rows[count].Cells[i + 2].Value.ToString());
            }
            for (int i = 0; i < count; i++)
            {
                dataGridView2.Rows[i].Cells[count + 3].Value = double.Parse(dataGridView2.Rows[i].Cells[count + 2].Value.ToString()) / temp;
                dataGridView2.Rows[count + 1].Cells[i + 2].Value = double.Parse(dataGridView2.Rows[count].Cells[i + 2].Value.ToString()) / temp2;
            }
            //Оценка отношения согласованости
            for (int i = 0; i < count; i++)
            {
                temp = 0;
                temp2 = 0;
                for (int j = 0; j < count; j++)
                {
                    temp += double.Parse(dataGridView2.Rows[i].Cells[j + 2].Value.ToString());
                    temp2 += double.Parse(dataGridView2.Rows[j].Cells[i + 2].Value.ToString());
                }
                dataGridView2.Rows[i].Cells[count + 4].Value = temp * double.Parse(dataGridView2.Rows[i].Cells[count + 3].Value.ToString());
                dataGridView2.Rows[count + 2].Cells[i + 2].Value = temp2 * double.Parse(dataGridView2.Rows[count + 1].Cells[i + 2].Value.ToString());
            }
            //Максимальное значение лямди
            double lamdaMaxi = double.Parse(dataGridView2.Rows[0].Cells[count + 4].Value.ToString());
            double lamdaMaxj = double.Parse(dataGridView2.Rows[count + 2].Cells[2].Value.ToString());
            int indexMaxi = 0;
            int indexMaxj = 2;
            for (int i = 0; i < count; i++)
            {
                if (double.Parse(dataGridView2.Rows[i].Cells[count + 4].Value.ToString()) > lamdaMaxi)
                {
                    lamdaMaxi = double.Parse(dataGridView2.Rows[i].Cells[count + 4].Value.ToString());
                    indexMaxi = i;
                }
                if (double.Parse(dataGridView2.Rows[count + 2].Cells[i + 2].Value.ToString()) > lamdaMaxj)
                {
                    lamdaMaxj = double.Parse(dataGridView2.Rows[count + 2].Cells[i + 2].Value.ToString());
                    indexMaxj = i + 2;
                }
            }
            temp = 0;
            temp2 = 0;
            for (int i = 0; i < count; i++)
            {
                temp = 0;
                temp2 = 0;
                for (int j = 0; j < count; j++)
                {
                    temp += Math.Pow(Convert.ToDouble(dataGridView2.Rows[i].Cells[j + 2].Value) -
                        (Convert.ToDouble(dataGridView2.Rows[i].Cells[count + 4].Value) / Convert.ToDouble(dataGridView2.Rows[count + 2].Cells[i + 2].Value)), 2);
                }
                dataGridView2.Rows[i].Cells[count + 5].Value = temp;
            }
            //индекс согласованости
            double indexAccessi = (lamdaMaxi - count) / (count - 1);
            double indexAccessj = (lamdaMaxj - count) / (count - 1);
            richTextBox1.Text = "LamdaMaxi=" + lamdaMaxi.ToString() + '\n' + "ОС=" + indexAccessi;
            richTextBox2.Text = "LamdaMaxj =" + lamdaMaxj.ToString() + '\n' + "ОС=" + indexAccessj;
           
            if (indexAccessi > 0.1)
            {
                MessageBox.Show("Оценка согласованности=" + Convert.ToInt32(indexAccessi * 100) + "%\n Необходимо провести корректировку");
               // correctionValue();
            }
            else
            {
                MessageBox.Show("Оценка согласованности=" + Convert.ToInt32(indexAccessi * 100) + "%\n");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int count = getCountObj2();
            if (dataGridView2.ColumnCount != count + 6)//добавление столбцов
            {
                for (int i = 0; i < count; i++)
                {
                    dataGridView2.Columns.Add("Obj" + (i + 1), "Obj" + (i + 1));
                }
                dataGridView2.Columns.Add("Vi", "Vi");
                dataGridView2.Columns.Add("Pi", "Pi");
                dataGridView2.Columns.Add("lamda", "lamda");
                dataGridView2.Columns.Add("Si", "Si");
            }
            for (int i = 0; i < count; i++)
            {//матрица оценки мнений эксперта
                for (int j = 0; j < count; j++)
                {
                    dataGridView2.Rows[j].Cells[i+2].Value = double.Parse(dataGridView2.Rows[i].Cells[1].Value.ToString())/ double.Parse(dataGridView2.Rows[j].Cells[1].Value.ToString());
                }
            }
            calculate();
        }
        private void correctionValue()
        {
            int count = getCountObj2();
            
            double max = Convert.ToDouble(dataGridView2.Rows[0].Cells[count + 5].Value);
            int indexMax = 0;
            for (int i = 0; i < count; i++)
            {
                if(Convert.ToDouble(dataGridView2.Rows[i].Cells[count + 5].Value) > max)
                {
                    max = Convert.ToDouble(dataGridView2.Rows[i].Cells[count + 5].Value);
                    indexMax = i;
                }
            }
            for (int i = 0; i < count; i++)
            {
                dataGridView2.Rows[indexMax].Cells[i + 2].Value = Convert.ToDouble(dataGridView2.Rows[indexMax].Cells[count + 3].Value) / Convert.ToDouble(dataGridView2.Rows[count + 1].Cells[i + 2].Value);
                dataGridView2.Rows[i].Cells[indexMax + 2].Value = Convert.ToDouble(dataGridView2.Rows[indexMax].Cells[i + 2].Value);
            }
            calculate();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                tbCountExp.Text ="2";
                tbCountExp.ReadOnly = true;
            }
            else
            {
                tbCountExp.ReadOnly = false;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Random rnd = new Random();
            try
            {
                int count = getCountObj2();
                for (int i = 0; i < count; i++)
                {
                    dataGridView2.Rows[i].Cells[1].Value = rnd.Next(1, 9);
                }
                button2_Click(null, null);
            }
            catch (Exception)
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            correctionValue();
        }
    }
}
