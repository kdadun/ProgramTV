using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agility2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Text = "Wybierz telewizję";
            label3.Text = "Wybierz dzień";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadProgram();
        }

        public void LoadProgram()
        {
            string tvp1 = "tvp-1-hd-380?dzien=0";
            string polsat = "polsat-38?dzien=0";
            string tvn = "tvn-357?dzien=0";
            string tvp2 = "tvp-2-hd-145?dzien=0";
            string tvn7 = "tvn-7-326?dzien=0";
            string tvnTurbo = "tvn-turbo-hd-143?dzien=0";
            string canalPlus = "canal-hd-288?dzien=0";
            string ttv = "ttv-33?dzien=0";

            List<string> program = new List<string>();
            List<string> hour = new List<string>();
            var html = (String)null;

            HtmlWeb web = new HtmlWeb();
            try
            {
                if (comboBox1.SelectedItem.ToString() == "TVP1")
                {
                    if (comboBox2.SelectedItem.ToString() == "Dzisiaj")
                    {
                        html = @"https://programtv.onet.pl/program-tv/" + tvp1.ToString();
                        lblProgramTV.Text = "Dzisiaj w telewizji TVP1";
                    }
                    else if (comboBox2.SelectedItem.ToString() == "Jutro")
                    {
                        string tvp1j = "tvp-1-hd-380?dzien=1";
                        html = @"https://programtv.onet.pl/program-tv/" + tvp1j.ToString();
                        lblProgramTV.Text = "Jutro w telewizji TVP1";
                    }
                    else if (comboBox2.SelectedItem.ToString() == "Pojutrze")
                    {
                        string tvp1j2 = "tvp-1-hd-380?dzien=2";
                        html = @"https://programtv.onet.pl/program-tv/" + tvp1j2.ToString();
                        lblProgramTV.Text = "Pojutrze w telewizji TVP1";
                    }

                }
                else if (comboBox1.SelectedItem.ToString() == "Polsat")
                {
                    if (comboBox2.SelectedItem.ToString() == "Dzisiaj")
                    {
                        html = @"https://programtv.onet.pl/program-tv/" + polsat.ToString();
                        lblProgramTV.Text = "Dzisiaj w telewizji Polsat";
                    }
                    else if (comboBox2.SelectedItem.ToString() == "Jutro")
                    {
                        string polsatJ = "polsat-38?dzien=1";
                        html = @"https://programtv.onet.pl/program-tv/" + polsatJ.ToString();
                        lblProgramTV.Text = "Jutro w telewizji Polsat";
                    }
                    else if (comboBox2.SelectedItem.ToString() == "Pojutrze")
                    {
                        string polsatJ2 = "polsat-38?dzien=2";
                        html = @"https://programtv.onet.pl/program-tv/" + polsatJ2.ToString();
                        lblProgramTV.Text = "Pojutrze w telewizji Polsat";
                    }
                }
                else if (comboBox1.SelectedItem.ToString() == "TVN")
                {
                    if (comboBox2.SelectedItem.ToString() == "Dzisiaj")
                    {
                        html = @"https://programtv.onet.pl/program-tv/" + tvn.ToString();
                        lblProgramTV.Text = "Dzisiaj w telewizji TVN";
                    }
                    else if (comboBox2.SelectedItem.ToString() == "Jutro")
                    {
                        string tvnJ = "tvn-357?dzien=1";
                        html = @"https://programtv.onet.pl/program-tv/" + tvnJ.ToString();
                        lblProgramTV.Text = "Jutro w telewizji TVN";
                    }
                    else if (comboBox2.SelectedItem.ToString() == "Pojutrze")
                    {
                        string tvnJ2 = "tvn-357?dzien=2";
                        html = @"https://programtv.onet.pl/program-tv/" + tvnJ2.ToString();
                        lblProgramTV.Text = "Pojutrze w telewizji TVN";
                    }
                }
                else if (comboBox1.SelectedItem.ToString() == "TVP2")
                {
                    if (comboBox2.SelectedItem.ToString() == "Dzisiaj")
                    {
                        html = @"https://programtv.onet.pl/program-tv/" + tvp2.ToString();
                        lblProgramTV.Text = "Dzisiaj w telewizji TVP2";
                    }
                    else if (comboBox2.SelectedItem.ToString() == "Jutro")
                    {
                        string tvp2J = "tvp-2-hd-145?dzien=1";
                        html = @"https://programtv.onet.pl/program-tv/" + tvp2J.ToString();
                        lblProgramTV.Text = "Jutro w telewizji TVP2";
                    }
                    else if (comboBox2.SelectedItem.ToString() == "Pojutrze")
                    {
                        string tvp2J = "tvp-2-hd-145?dzien=2";
                        html = @"https://programtv.onet.pl/program-tv/" + tvp2J.ToString();
                        lblProgramTV.Text = "Pojutrze telewizji TVP2";
                    }
                }
                else if (comboBox1.SelectedItem.ToString() == "TVN7")
                {
                    if (comboBox2.SelectedItem.ToString() == "Dzisiaj")
                    {
                        html = @"https://programtv.onet.pl/program-tv/" + tvn7.ToString();
                        lblProgramTV.Text = "Dzisiaj w telewizji TVN7";
                    }
                    else if (comboBox2.SelectedItem.ToString() == "Jutro")
                    {
                        string tvn7j = "tvn-7-326?dzien=1";
                        html = @"https://programtv.onet.pl/program-tv/" + tvn7j.ToString();
                        lblProgramTV.Text = "Jutro w telewizji TVN7";
                    }
                    else if (comboBox2.SelectedItem.ToString() == "Pojutrze")
                    {
                        string tvn7j2 = "tvn-7-326?dzien=2";
                        html = @"https://programtv.onet.pl/program-tv/" + tvn7j2.ToString();
                        lblProgramTV.Text = "Pojutrze w telewizji TVN7";
                    }
                }
                else if (comboBox1.SelectedItem.ToString() == "TVN Turbo")
                {
                    if (comboBox2.SelectedItem.ToString() == "Dzisiaj")
                    {

                        html = @"https://programtv.onet.pl/program-tv/" + tvnTurbo.ToString();
                        lblProgramTV.Text = "Program telewizji TVN Turbo";
                    }
                    else if (comboBox2.SelectedItem.ToString() == "Jutro")
                    {
                        string tvnTurboj = "tvn-turbo-hd-143?dzien=1";
                        html = @"https://programtv.onet.pl/program-tv/" + tvnTurboj.ToString();
                        lblProgramTV.Text = "Jutro w telewizji TVN Turbo";
                    }
                    else if (comboBox2.SelectedItem.ToString() == "Pojutrze")
                    {
                        string tvnTurboj2 = "tvn-turbo-hd-143?dzien=2";
                        html = @"https://programtv.onet.pl/program-tv/" + tvnTurboj2.ToString();
                        lblProgramTV.Text = "Pojutrze w telewizji TVN Turbo";
                    }
                }
                else if (comboBox1.SelectedItem.ToString() == "Canal +")
                {
                    if (comboBox2.SelectedItem.ToString() == "Dzisiaj")
                    {
                        html = @"https://programtv.onet.pl/program-tv/" + canalPlus.ToString();
                        lblProgramTV.Text = "Dzisiaj w telewizji Canal +";
                    }
                    else if (comboBox2.SelectedItem.ToString() == "Jutro")
                    {
                        string canalPlusj = "canal-hd-288?dzien=1";
                        html = @"https://programtv.onet.pl/program-tv/" + canalPlusj.ToString();
                        lblProgramTV.Text = "Jutro w telewizji Canal +";
                    }
                    else if (comboBox2.SelectedItem.ToString() == "Pojutrze")
                    {
                        string canalPlusj2 = "canal-hd-288?dzien=2";
                        html = @"https://programtv.onet.pl/program-tv/" + canalPlusj2.ToString();
                        lblProgramTV.Text = "Pojutrze w telewizji Canal +";
                    }
                }
                else if (comboBox1.SelectedItem.ToString() == "TTV")
                {
                    if (comboBox2.SelectedItem.ToString() == "Dzisiaj")
                    {
                        html = @"https://programtv.onet.pl/program-tv/" + ttv.ToString();
                        lblProgramTV.Text = "Dzisiaj w telewizji TTV";
                    }
                    else if (comboBox2.SelectedItem.ToString() == "Jutro")
                    {
                        string ttvj = "ttv-33?dzien=1";
                        html = @"https://programtv.onet.pl/program-tv/" + ttvj.ToString();
                        lblProgramTV.Text = "Jutro w telewizji TTV";
                    }
                    else if (comboBox2.SelectedItem.ToString() == "Pojutrze")
                    {
                        string ttvj2 = "ttv-33?dzien=2";
                        html = @"https://programtv.onet.pl/program-tv/" + ttvj2.ToString();
                        lblProgramTV.Text = "Pojutrze w w telewizji TTV";
                    }
                }
           

            var htmldoc = web.Load(html);
            var findhours = htmldoc.DocumentNode.SelectNodes("//div[@class='emissions']//div[@class='hours']//span[@class='hour']");
            var findtitle = htmldoc.DocumentNode.SelectNodes("//div[@class='emissions']//div[@class='titles']//a[@href]");
            if (findhours != null && findtitle != null)
            {
                foreach (var y in findtitle)
                {
                    program.Add(y.InnerText);
                }
                foreach (var x in findhours)
                {
                    hour.Add(x.InnerText);
                }
            }
            else
            {
                MessageBox.Show("node = null");
            }

            var programPolsat = hour.Zip(program, (h, p) => new { Hours = h, Program = p });

            DataTable table = new DataTable();
            table.Columns.Add("Godzina", typeof(string));
            table.Columns.Add("Program", typeof(string));


            foreach (var prog in programPolsat)
            {
                DataRow row = table.NewRow();
                row[0] = prog.Hours.ToString();
                row[1] = prog.Program.ToString();

                table.Rows.Add(row);
            }
            dataGridView1.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       
    }
}
