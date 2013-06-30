using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using KK.Common;

namespace classtest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ErrorHandler.Execute(
                () => setGrid()
                );
        }
        private void setGrid()
        {
            DataBaseAccess dao = DataBaseAccess.GetInstance();
            this.dataGridView1.DataSource = dao.GetTable("select * from TestTable1");
        }
    }
}
