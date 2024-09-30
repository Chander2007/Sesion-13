using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using person.models;

namespace person
{
    public partial class Form1 : Form
    {
        List<Person> persons;
        public Form1()
        {
            InitializeComponent();
            persons = new List<Person>();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Person person = new Person();
            person.firstName = tbName.Text;
            person.lastName = tbLastName.Text;
            person.birhtdate = dtpBirthDate.Value;

            persons.Add(person);
            ShowPersons();
            ClearTb();

        }
        private void ShowPersons()
        {
            dgvPersons.DataSource = null;
            dgvPersons.DataSource = persons;
        }
        private void ClearTb()
        {
            tbName.Clear();
            tbLastName.Clear();
            dtpBirthDate.Value = DateTime.Now;
            tbName.Focus();
        }
    }
}
