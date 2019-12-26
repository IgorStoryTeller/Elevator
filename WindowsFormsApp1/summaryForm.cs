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
    public partial class summaryForm : Form
    {
        Elevator elevator;
        public summaryForm(Elevator el)
        {
            InitializeComponent();
            elevator = el;
        }

        private void summaryForm_Load(object sender, EventArgs e)
        {
            label3.Text = elevator.totalWeigh.ToString();
        }
    }
}
