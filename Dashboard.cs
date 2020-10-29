using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlDataAccessDemo
{
    public partial class Dashboard : Form
    {
        List<Person> people = new List<Person>();
        public Dashboard()
        {
            InitializeComponent();
            // ListBox Info
            UpdatBiding();
        }
        private void UpdatBiding()
        {
            peopleFoundLBox.DataSource = people;
            peopleFoundLBox.DisplayMember = "fullInfo";
        }
        private void IdLabel_Click(object sender, EventArgs e)
        {

        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            people = db.GetPeople(int.Parse(Idtxt.Text));
            // To Show up the inforlations 
            UpdatBiding();
        }
    }
}
