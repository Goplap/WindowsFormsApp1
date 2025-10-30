using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'transportLogisticDataSet.DRIVER' table. You can move, or remove it, as needed.
            this.dRIVERTableAdapter.Fill(this.transportLogisticDataSet.DRIVER);
            // TODO: This line of code loads data into the 'transportLogisticDataSet.RECIPIENT' table. You can move, or remove it, as needed.
            this.rECIPIENTTableAdapter.Fill(this.transportLogisticDataSet.RECIPIENT);
            // TODO: This line of code loads data into the 'transportLogisticDataSet.DELIVERY' table. You can move, or remove it, as needed.
            this.dELIVERYTableAdapter.Fill(this.transportLogisticDataSet.DELIVERY);
            // TODO: This line of code loads data into the 'transportLogisticDataSet.CARGO_TYPE' table. You can move, or remove it, as needed.
            this.cARGO_TYPETableAdapter.Fill(this.transportLogisticDataSet.CARGO_TYPE);
            // TODO: This line of code loads data into the 'transportLogisticDataSet.ROUTE' table. You can move, or remove it, as needed.
            this.rOUTETableAdapter.Fill(this.transportLogisticDataSet.ROUTE);

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void типиВантажуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCargoTypes myForm = new FormCargoTypes();
            myForm.Show();
        }

        private void доставкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDeliveries myForm = new FormDeliveries();
            myForm.Show();
        }

        private void водіїToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDrivers myForm = new FormDrivers();
            myForm.Show();
        }

        private void одержувачіToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRecipients myForm = new FormRecipients();
            myForm.Show();
        }

        private void маршрутиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRoutes myForm = new FormRoutes();
            myForm.Show();
        }

        private void постачальникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSuppliers myForm = new FormSuppliers();
            myForm.Show();
        }

        private void транспортToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTransport_vehicles myForm = new FormTransport_vehicles();
            myForm.Show();
        }

        private void запитиДоБДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQueries queryForm = new FormQueries();
            queryForm.Show();
        }
    }
}
