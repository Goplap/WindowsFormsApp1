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
    public partial class FormCargoTypes : Form
    {
        public FormCargoTypes()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void FormCargoTypes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'transportLogisticDataSet.CARGO_TYPE' table. You can move, or remove it, as needed.
            this.cARGO_TYPETableAdapter.Fill(this.transportLogisticDataSet.CARGO_TYPE);

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.cARGO_TYPETableAdapter.Update(this.transportLogisticDataSet.CARGO_TYPE);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
