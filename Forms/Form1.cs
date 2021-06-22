using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'airport.Person' table. You can move, or remove it, as needed.
            this.personTableAdapter.Fill(this.airport.Person);
            // TODO: This line of code loads data into the 'airport.Flight' table. You can move, or remove it, as needed.
            this.flightTableAdapter.Fill(this.airport.Flight);
            // TODO: This line of code loads data into the 'airport_DBDataSet.vTrip' table. You can move, or remove it, as needed.
            this.vTripTableAdapter.Fill(this.airport_DBDataSet.vTrip);
            // TODO: This line of code loads data into the 'airport_DBDataSet.vPerson' table. You can move, or remove it, as needed.
            this.vPersonTableAdapter.Fill(this.airport_DBDataSet.vPerson);
            // TODO: This line of code loads data into the 'airport_DBDataSet.vEmergencyFlights' table. You can move, or remove it, as needed.
            this.vEmergencyFlightsTableAdapter.Fill(this.airport_DBDataSet.vEmergencyFlights);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
