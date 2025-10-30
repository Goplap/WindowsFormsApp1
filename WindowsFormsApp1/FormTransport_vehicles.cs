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
    public partial class FormTransport_vehicles : Form
    {
        public FormTransport_vehicles()
        {
            InitializeComponent();
        }

        private void FormTransport_vehicles_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'transportLogisticDataSet.TRANSPORT_VEHICLE' table. You can move, or remove it, as needed.
            this.tRANSPORT_VEHICLETableAdapter.Fill(this.transportLogisticDataSet.TRANSPORT_VEHICLE);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.tRANSPORT_VEHICLETableAdapter.Update(this.transportLogisticDataSet.TRANSPORT_VEHICLE);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
