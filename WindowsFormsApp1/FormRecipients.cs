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
    public partial class FormRecipients : Form
    {
        public FormRecipients()
        {
            InitializeComponent();
        }

        private void FormRecipients_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'transportLogisticDataSet.RECIPIENT' table. You can move, or remove it, as needed.
            this.rECIPIENTTableAdapter.Fill(this.transportLogisticDataSet.RECIPIENT);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.rECIPIENTTableAdapter.Update(this.transportLogisticDataSet.RECIPIENT);
        }
    }
}
