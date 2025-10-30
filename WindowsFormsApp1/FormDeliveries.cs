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
    public partial class FormDeliveries : Form
    {
        public FormDeliveries()
        {
            InitializeComponent();
        }

        private void FormDeliveries_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'transportLogisticDataSet.DELIVERY' table. You can move, or remove it, as needed.
            this.dELIVERYTableAdapter.Fill(this.transportLogisticDataSet.DELIVERY);

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.dELIVERYTableAdapter.Update(this.transportLogisticDataSet.DELIVERY);
        }
    }
}
