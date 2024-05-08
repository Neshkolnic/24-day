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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "confectioneryDBDataSet1.OrderDetails". При необходимости она может быть перемещена или удалена.

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
