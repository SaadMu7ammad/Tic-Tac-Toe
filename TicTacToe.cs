using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        string turn = "O"; 
        int count = 0;  //count the clicks to handle the draw event

        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button b = new Button(); //make an object of Button a
            b = (Button)sender;   // the sender of Object type casted to a button to make any of buttons click been detected
            if (turn == "X")
            {
                turn = "O";
                ++count;
            }
            else
            {
                turn = "X";
                ++count;
            }
             b.Text = turn;
            b.Enabled=false;
            HorizontalChecker();  //Horizontal Boxes
            VerticalChecker();   //Vertical Boxes
            DiagonalChecker();   //Diagonal Boxes
            if (count == 9) // mean that not any of the checker detects a win situation
            {
                MessageBox.Show("Draw ","No Win !" );
                Application.Exit();
            }
        }

        public void HorizontalChecker()
        {
            if (a1.Text == a2.Text && a2.Text == a3.Text && a1.Enabled == false)
            {
                MessageBox.Show("Congratulations " + turn + " Win ","There is A Winner");
                Application.Exit();
            }
            else if (b1.Text == b2.Text && b2.Text == b3.Text && b1.Enabled == false)
            {
                MessageBox.Show("Congratulations " + turn + " Win ", "There is A Winner");
                Application.Exit();
            }
            else if (c1.Text == c2.Text && c2.Text == c3.Text && c1.Enabled == false)
            {
                MessageBox.Show("Congratulations " + turn + " Win ", "There is A Winner");
                Application.Exit();
            }
        }
        public void VerticalChecker()
        {
            if (a1.Text == b1.Text && b1.Text == c1.Text && a1.Enabled == false)
            {
                MessageBox.Show("Congratulations " + turn + " Win ", "There is A Winner");
                Application.Exit();
            }
            else if (a2.Text == b2.Text && b2.Text == c2.Text && a2.Enabled == false)
            {
                MessageBox.Show("Congratulations " + turn + " Win ", "There is A Winner");
                Application.Exit();
            }
            else if (a3.Text == b3.Text && b3.Text == c3.Text && a3.Enabled == false)
            {
                MessageBox.Show("Congratulations " + turn + " Win ", "There is A Winner");
                Application.Exit();
            }
        }
        public void DiagonalChecker()
        {
            if (a1.Text == b2.Text && b2.Text == c3.Text && a1.Enabled == false)
            {
                MessageBox.Show("Congratulations " + turn + " Win ", "There is A Winner");
                Application.Exit();
            }
            else if (a3.Text == b2.Text && b2.Text == c1.Text && a3.Enabled == false)
            {
                MessageBox.Show("Congratulations " + turn + " Win ", "There is A Winner");
                Application.Exit();
            }
          
        }

        private void aboutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("By Saad Muhammad ", "About");
        }
    }
}
