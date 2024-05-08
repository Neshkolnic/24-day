using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22_day
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void orderDetailsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.orderDetailsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.confectioneryDBDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "confectioneryDBDataSet.OrderDetails". При необходимости она может быть перемещена или удалена.
            this.orderDetailsTableAdapter.Fill(this.confectioneryDBDataSet.OrderDetails);

        }
    }
}
