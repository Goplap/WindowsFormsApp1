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
    public partial class FormRoutes : Form
    {
        public FormRoutes()
        {
            InitializeComponent();
        }

        private void FormRoutes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'transportLogisticDataSet.ROUTE' table. You can move, or remove it, as needed.
            this.rOUTETableAdapter.Fill(this.transportLogisticDataSet.ROUTE);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.rOUTETableAdapter.Update(this.transportLogisticDataSet.ROUTE);
        }
    }
}
