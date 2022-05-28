using HHLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HHBot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        HHModel model = new HHModel();
        string vacUrl = "http://api.hh.ru/vacancies?text=Программист";

        private void TestButton_Click(object sender, EventArgs e)
        {
            ResBox.Text = model.RequestGet(vacUrl);
        }

        private void buttonParse_Click(object sender, EventArgs e)
        {
            string tmpRes = model.RequestGet(vacUrl);
            ResBox.Text = model.JsonParseStringItems(tmpRes);
        }
    }
}
