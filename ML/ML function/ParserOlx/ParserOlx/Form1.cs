using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;   
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;


namespace ParserOlx
{
    public partial class Form1 : Form
    {
        string output = null;
        List<house> list = new List<house>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < 50; i++)
            {
                getData(i);
            }
            foreach(house h in list)
            {
                chart1.Series[0].Points.AddXY(h.houseSize, h.housePrise);
                Console.WriteLine(h.houseSize + " " + h.housePrise);
            }
            writeFile();


        }
        public List<house> getData(int num)
        {
            HtmlWeb web = new HtmlWeb();
            HtmlDocument document = web.Load("http://xan.com.ua/ru/flats/find/Kharkov?page=" + num);
            HtmlNode[] nodes = document.DocumentNode.SelectNodes("//li[@class='w-contentBlog-title']").ToArray();
            HtmlNode[] nodes2 = document.DocumentNode.SelectNodes("//li[@class='w-contentBlog-main']").ToArray();
            float size = 0;
            float prise = 0;
            for(int i = 0; i < nodes.Length; i++) { 
                int indexComma=nodes[i].InnerHtml.IndexOf(",")+2;
                int indexPrise = nodes2[i].InnerHtml.IndexOf(":") + 2;
                int  sizePrise= nodes2[i].InnerHtml.IndexOf("<")-indexPrise-1;
                //output+=nodes[i].InnerHtml;
                Console.WriteLine(nodes[i].InnerHtml);
                Console.WriteLine(nodes2[i].InnerHtml);
                try {
                    if (nodes[i].InnerHtml.Substring(indexComma + 1).Contains("."))
                    {
                        size = float.Parse(nodes[i].InnerHtml.Replace('.',',').Substring(indexComma, 5));
                    }
                    else {
                        size = float.Parse(nodes[i].InnerHtml.Substring(indexComma, 2));
                    }
                    if (nodes2[i].InnerHtml.Substring(indexPrise, sizePrise).Contains("$"))
                    {
                        prise = float.Parse(nodes2[i].InnerHtml.Substring(indexPrise, sizePrise-2));
                    }
                    else
                    {
                        continue;
                    }
                }
                catch (System.FormatException)
                {
                    continue;
                }
                list.Add(new house
                {
                    houseSize = size,
                    housePrise = prise
                });
                //output +="\n"+size+"  "+prise;
                //textBox1.Text = output;
               //Console.WriteLine(size + "  " + prise);

            }
            return list;
        }
        public void writeFile()
        {
            StreamWriter str = new StreamWriter("data.txt");
            foreach (house h in list)
            {
                str.WriteLine(h.houseSize+" "+h.housePrise);
            }
            str.Close();

        }
    }
    public class house
    {
        public float houseSize { get; set; }
        public float housePrise { get; set; }
    }
}
