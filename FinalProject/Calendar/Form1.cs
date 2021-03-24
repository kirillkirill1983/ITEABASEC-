using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
           
            InitializeComponent();
            InitCalendar(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            InitForm();
            try
            {
                Regex reg = new Regex(@"^(\d{1,2})/(\d{1,2})/(\d{4})$");
                Match m = reg.Match(textBox1.Text);
                int dd = int.Parse(m.Groups[1].Value);
                int mm = int.Parse(m.Groups[2].Value);
                int yyyy = int.Parse(m.Groups[3].Value);
                InitCalendar(yyyy, mm, dd);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка ввода");
                
            }
            CalculatedLoading();

        }

        public DateTime DateInit(int year,int month,int  day)
        {
            DateTime now = new DateTime(year, month, day);
            //DateTime now = DateTime.Now;
            DateTime first = new DateTime(now.Year, now.Month, 1);
            DateTime last = new DateTime(now.Year, now.Month + 1, 1).AddDays(-1);
            return first;
        }

        public void InitCalendar(int year, int month, int day)
        {
            Label[] labelmassiv = new Label[] {label1,label2,label3,label4,label5
            ,label6,label7,label8,label9,label10,label11,label12,label13,label14,
            label15,label16,label17,label18,label19,label20,label21,label22,label23,
            label24,label25,label26,label27,label28,label29,label30,label31};

            RichTextBox[] richTextBoxArray = new RichTextBox[] { richTextBox1, richTextBox2,
            richTextBox3, richTextBox4,richTextBox5, richTextBox6,richTextBox7, richTextBox8,
            richTextBox9, richTextBox10,richTextBox11, richTextBox12,richTextBox13, richTextBox14,
            richTextBox15, richTextBox16,richTextBox17, richTextBox18,richTextBox19, richTextBox20,
             richTextBox21, richTextBox22,richTextBox23, richTextBox24,richTextBox25, richTextBox26,
            richTextBox27, richTextBox28,richTextBox29, richTextBox30,richTextBox31};

            DateTime first= DateInit(year,month,day);

            //DateTime now = new DateTime(year,month,day);
            //DateTime first = new DateTime(now.Year, now.Month, 1);
            //DateTime last = new DateTime(now.Year, now.Month + 1, 1).AddDays(-1);

            for (int i = 0; i < labelmassiv.Length; i++)
            {
                if (first.AddDays(i)<DateTime.Now.Date)
                {
                    richTextBoxArray[i].BackColor = Color.DarkGray;
                }
            }   
            for (int i = 0; i < labelmassiv.Length; i++)
            
            {
                labelmassiv[i].Text = first.AddDays(i).ToString("dddd") + "\n" +
                    first.AddDays(i).ToString("dd");
                if (first.AddDays(i).ToString("dddd") == "воскресенье" || first.AddDays(i).ToString("dddd") == "суббота")
                {
                    richTextBoxArray[i].BackColor = Color.Red;
                }
                if (first.AddDays(i).ToString("31")=="31" )
                {
                    label31.Visible = true;
                    richTextBox31.Visible = true;
                }
                if (first.AddDays(i).ToString("30") == "30")
                {
                    label30.Visible = true;
                    richTextBox30.Visible = true;
                }
                if (first.AddDays(i).ToString("29") == "29")
                {
                    label29.Visible = true;
                    richTextBox29.Visible = true;
                }
                if (first.AddDays(i).ToString("28") == "28")
                {
                    label28.Visible = true;
                    richTextBox28.Visible = true;
                }
            }

        }

        public void CalculatedLoading()
        {
            RichTextBox[] richTextBoxArray = new RichTextBox[] { richTextBox1, richTextBox2,
            richTextBox3, richTextBox4,richTextBox5, richTextBox6,richTextBox7, richTextBox8,
            richTextBox9, richTextBox10,richTextBox11, richTextBox12,richTextBox13, richTextBox14,
            richTextBox15, richTextBox16,richTextBox17, richTextBox18,richTextBox19, richTextBox20,
             richTextBox21, richTextBox22,richTextBox23, richTextBox24,richTextBox25, richTextBox26,
            richTextBox27, richTextBox28,richTextBox29, richTextBox30,richTextBox31};
           
           
            DateTime now = DateTime.Now;
            DateTime first = new DateTime(now.Year, now.Month, 1);
            DateTime last = new DateTime(now.Year, now.Month + 1, 1).AddDays(-1);
            
            int allDayInit = (int)last.Day*8;

            int sumFlaf = 0;
            for (int i = 0; i < richTextBoxArray.Length; i++)
            {
                if (richTextBoxArray[i].Text!=String.Empty)
                {
                    sumFlaf += 1;
                }
            }
            label33.Visible = true;
            label33.Text = sumFlaf.ToString();
            label36.Visible = true;
            label36.Text = (sumFlaf * 8).ToString();
           
            
            
        }
        public void InitForm() 
        {
            RichTextBox[] richTextBoxArray = new RichTextBox[] { richTextBox1, richTextBox2,
            richTextBox3, richTextBox4,richTextBox5, richTextBox6,richTextBox7, richTextBox8,
            richTextBox9, richTextBox10,richTextBox11, richTextBox12,richTextBox13, richTextBox14,
            richTextBox15, richTextBox16,richTextBox17, richTextBox18,richTextBox19, richTextBox20,
             richTextBox21, richTextBox22,richTextBox23, richTextBox24,richTextBox25, richTextBox26,
            richTextBox27, richTextBox28,richTextBox29, richTextBox30,richTextBox31};

           
            foreach (var item in richTextBoxArray)
            {
                item.BackColor = Color.White;
            }

        }
    }
}
