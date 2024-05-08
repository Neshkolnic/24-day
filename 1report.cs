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
    public partial class report1 : Form
    {
        public report1()
        {
            InitializeComponent();
        }

        private void report1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "confectioneryDBDataSet.OrderDetails". При необходимости она может быть перемещена или удалена.
            this.orderDetailsTableAdapter.Fill(this.confectioneryDBDataSet.OrderDetails);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "confectioneryDBDataSet.Products". При необходимости она может быть перемещена или удалена.
            this.productsTableAdapter.Fill(this.confectioneryDBDataSet.Products);

            this.reportViewer1.RefreshReport();
        }
    }
}
