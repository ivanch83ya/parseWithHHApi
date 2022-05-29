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
        string vacUrl = "http://api.hh.ru/vacancies?text=";

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string tmpRes = model.RequestGet(vacUrl+searchBox.Text);
            List<Vacancy> vacancies = model.JsonParseStringItems(tmpRes);

            lblCount.Text = "Вакансий всего: " + vacancies.Count();

            GridView.Rows.Clear();

            foreach (Vacancy vac in vacancies)
            {
                DataGridViewRow row = (DataGridViewRow)GridView.Rows[0].Clone();
                row.Cells[0].Value = vac.id;
                row.Cells[1].Value = vac.name;
                row.Cells[2].Value = vac.salary_from;
                row.Cells[3].Value = vac.salary_to;
                row.Cells[4].Value = vac.salary_currency;
                row.Cells[5].Value = vac.employer_name;
                row.Cells[6].Value = vac.address;
                row.Cells[7].Value = vac.info;
                GridView.Rows.Add(row);
                
            }
        }
    }
}
