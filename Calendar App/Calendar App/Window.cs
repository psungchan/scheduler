using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar_App
{
    public partial class Window : Form
    {

        private AppControl control;
        private string currentMonth;
        private string currentDay;
        private int currentYear;

        public Window()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        //when the month is clicked...
        private void monthChooser_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
