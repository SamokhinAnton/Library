using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.LibrarianApp
{
    public partial class ManagerWindow : Form
    {
        public ManagerWindow()
        {
            InitializeComponent();
        }

        private int position = 100;
        private void button1_Click(object sender, EventArgs e)
        {
            Button testButton = new Button();
            testButton.BackColor = Color.LightGray;
            testButton.ForeColor = Color.Black;
            testButton.Location = new Point(10, position);
            testButton.Click += TestButtonClick;
            position += 25;
            testButton.Text = "Привет";
            
            this.Controls.Add(testButton);
            groupBox1.Controls.Add(testButton);
            tabSearch.Controls.Add(testButton);
        }

        public void TestButtonClick(object sender, EventArgs e)
        {

            Button testButton = new Button();
            testButton.BackColor = Color.LightGray;
            testButton.ForeColor = Color.Black;
            testButton.Location = new Point(100, position);
            testButton.Click += TestButtonClick;
            position += 25;
            testButton.Text = "Привет";

            this.Controls.Add(testButton);
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
