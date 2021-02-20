using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToString("dd MM yyyy");
            var dateStart = DateTime.Now;

            var dateEnd = monthCalendar1.SelectionRange.End;
            label5.Text = dateEnd.ToString("dd MM yyyy");

            TimeSpan deltaYear = dateStart - dateEnd;

            //string countYear = $"{deltaYear.Days} дней жизни или = лет {deltaYear.Days / 365}";
            label6.Text = ((deltaYear.Days)/365).ToString();
        }
    }
}
