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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getData(1);
        }
        public string getData(int num)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://xan.com.ua/ru/flats/find/Kharkov?page="+num);
            request.Method = "GET";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string strResponse = reader.ReadToEnd();

            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(strResponse);
            //<ul class="w-contentBlog-descrip">
            HtmlNodeCollection NoAltElements = doc.DocumentNode.SelectNodes("//ul[@class='li']");

            if (NoAltElements != null)
            {
                foreach (HtmlNode hn in NoAltElements)
                {
                    string outputText = hn.InnerText.Trim();

                    Console.WriteLine(outputText);
                }
            }
            else
            {
                MessageBox.Show("Такого элемента нет!");
            }






            //Console.Write(strResponse);
            /* raw=strResponse.Substrings("жилая площадь - ", "м?,", 0);

               for(int i=0; i < raw.Length; i++)
               {
                   Console.WriteLine(raw[i]);
               }*/


            // string text="< li > 4 этаж в 9 - этажке, полька, жилая площадь -19 м ?, эконом - класс </ li >";
            // string text1 = "жилая площадь - ";
            //string text2 = "м?,";
            // for(int i=0;i)
            // string match = Regex.Match(text, @"жилая площадь - (.*) м?,").ToString();
           // MessageBox.Show(match);
            //int firstCharacter = strResponse.IndexOf(text1);
           // Console.WriteLine(match);
            
            return strResponse;
        }
    }
}
