using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalculator
{
    public partial class Form1 : Form
    {

        private double result;
        private double result2;
        private bool add = false;
        private bool subtract = false;
        private bool divide = false;
        private bool multiply = false;


        public Form1()
        {
            InitializeComponent();
        }

        // BUTTON HIGHLIGHTING
        private void Bclear_MouseLeave(object sender, EventArgs e)
        {
            Bclear.BackColor = Color.Black;
        }

        private void Bclear_MouseEnter(object sender, EventArgs e)
        {
            Bclear.BackColor = Color.Transparent;
        }

        private void Bbackspace_MouseEnter(object sender, EventArgs e)
        {
            Bbackspace.BackColor = Color.Transparent;
        }

        private void Bbackspace_MouseLeave(object sender, EventArgs e)
        {
            Bbackspace.BackColor = Color.Black;
        }

        private void Bequals_MouseEnter(object sender, EventArgs e)
        {
            Bequals.BackColor = Color.Transparent;
        }

        private void Bequals_MouseLeave(object sender, EventArgs e)
        {
            Bequals.BackColor = Color.Black;
        }

        private void Bmultiply_MouseEnter(object sender, EventArgs e)
        {
            Bmultiply.BackColor = Color.Transparent;
        }

        private void Bmultiply_MouseLeave(object sender, EventArgs e)
        {
            Bmultiply.BackColor = Color.Black;
        }

        private void B7_MouseEnter(object sender, EventArgs e)
        {
            B7.BackColor = Color.Transparent;
        }

        private void B7_MouseLeave(object sender, EventArgs e)
        {
            B7.BackColor = Color.Black;
        }

        private void B8_MouseEnter(object sender, EventArgs e)
        {
            B8.BackColor = Color.Transparent;
        }

        private void B8_MouseLeave(object sender, EventArgs e)
        {
            B8.BackColor = Color.Black;
        }

        private void B9_MouseEnter(object sender, EventArgs e)
        {
            B9.BackColor = Color.Transparent;
        }

        private void B9_MouseLeave(object sender, EventArgs e)
        {
            B9.BackColor = Color.Black;
        }

        private void Badd_MouseEnter(object sender, EventArgs e)
        {
            Badd.BackColor = Color.Transparent;
        }

        private void Badd_MouseLeave(object sender, EventArgs e)
        {
            Badd.BackColor = Color.Black;
        }

        private void B4_MouseEnter(object sender, EventArgs e)
        {
            B4.BackColor = Color.Transparent;
        }

        private void B4_MouseLeave(object sender, EventArgs e)
        {
            B4.BackColor = Color.Black;
        }

        private void B5_MouseHover(object sender, EventArgs e)
        {
            B5.BackColor = Color.Transparent;
        }

        private void B5_MouseLeave(object sender, EventArgs e)
        {
            B5.BackColor = Color.Black;
        }

        private void B6_MouseEnter(object sender, EventArgs e)
        {
            B6.BackColor = Color.Transparent;
        }

        private void B6_MouseLeave(object sender, EventArgs e)
        {
            B6.BackColor = Color.Black;
        }

        private void Bminus_MouseEnter(object sender, EventArgs e)
        {
            Bminus.BackColor = Color.Transparent;
        }

        private void Bminus_MouseLeave(object sender, EventArgs e)
        {
            Bminus.BackColor = Color.Black;
        }

        private void B1_MouseEnter(object sender, EventArgs e)
        {
            B1.BackColor = Color.Transparent;
        }

        private void B1_MouseLeave(object sender, EventArgs e)
        {
            B1.BackColor = Color.Black;
        }

        private void B2_MouseEnter(object sender, EventArgs e)
        {
            B2.BackColor = Color.Transparent;
        }

        private void B2_MouseLeave(object sender, EventArgs e)
        {
            B2.BackColor = Color.Black;
        }

        private void B3_MouseEnter(object sender, EventArgs e)
        {
            B3.BackColor = Color.Transparent;

        }

        private void B3_MouseLeave(object sender, EventArgs e)
        {
            B3.BackColor = Color.Black;
        }

        private void Bdivide_MouseEnter(object sender, EventArgs e)
        {
            Bdivide.BackColor = Color.Transparent;
        }

        private void Bdivide_MouseLeave(object sender, EventArgs e)
        {
            Bdivide.BackColor = Color.Black;
        }

        private void Bsquareroot_MouseEnter(object sender, EventArgs e)
        {
            Bsquareroot.BackColor = Color.Transparent;
        }

        private void Bsquareroot_MouseLeave(object sender, EventArgs e)
        {
            Bsquareroot.BackColor = Color.Black;
        }

        private void B0_MouseEnter(object sender, EventArgs e)
        {
            B0.BackColor = Color.Transparent;
        }

        private void B0_MouseLeave(object sender, EventArgs e)
        {
            B0.BackColor = Color.Black;
        }

        private void Bdot_MouseEnter(object sender, EventArgs e)
        {
            Bdot.BackColor = Color.Transparent;
        }

        private void Bdot_MouseLeave(object sender, EventArgs e)
        {
            Bdot.BackColor = Color.Black;
        }

        private void Bsquare_MouseEnter(object sender, EventArgs e)
        {
            Bsquare.BackColor = Color.Transparent;
        }

        private void Bsquare_MouseLeave(object sender, EventArgs e)
        {
            Bsquare.BackColor = Color.Black;
        }

        // BUTTON HIGHLIGHTING END

        private bool isZero()
        {
            return Lscore.Text == "0";
        }

        private void B1_Click(object sender, EventArgs e)
        {
            if (isZero())
                Lscore.Text = "1";

            else
                Lscore.Text += "1";
        }

        private void B2_Click(object sender, EventArgs e)
        {
            if (isZero())
                Lscore.Text = "2";

            else
                Lscore.Text += "2";
        }

        private void B3_Click(object sender, EventArgs e)
        {
            if (isZero())
                Lscore.Text = "3";

            else
                Lscore.Text += "3";
        }

        private void B4_Click(object sender, EventArgs e)
        {
            if (isZero())
                Lscore.Text = "4";

            else
                Lscore.Text += "4";
        }

        private void B5_Click(object sender, EventArgs e)
        {
            if (isZero())
                Lscore.Text = "5";

            else
                Lscore.Text += "5";
        }

        private void B6_Click(object sender, EventArgs e)
        {
            if (isZero())
                Lscore.Text = "6";

            else
                Lscore.Text += "6";
        }

        private void B7_Click(object sender, EventArgs e)
        {
            if (isZero())
                Lscore.Text = "7";

            else
                Lscore.Text += "7";
        }

        private void B8_Click(object sender, EventArgs e)
        {
            if (isZero())
                Lscore.Text = "8";

            else
                Lscore.Text += "8";
        }

        private void B9_Click(object sender, EventArgs e)
        {
            if (isZero())
                Lscore.Text = "9";

            else
                Lscore.Text += "9";
        }

        private void B0_Click(object sender, EventArgs e)
        {
            if (isZero())
                Lscore.Text = "0";

            else
                Lscore.Text += "0";
        }

        private void Bdot_Click(object sender, EventArgs e)
        {
            if (!Lscore.Text.Contains(","))
                Lscore.Text += ",";
        }

        private void Bclear_Click(object sender, EventArgs e)
        {
            Lscore.Text = "0";
        }

        private void Bbackspace_Click(object sender, EventArgs e)
        {
            if (isZero())
                Lscore.Text = "0";

            else if(Lscore.Text.Length == 1)
                Lscore.Text = "0";

            else
                Lscore.Text = Lscore.Text.Remove(Lscore.Text.Length - 1, 1);
        }

        private void Bsquare_Click(object sender, EventArgs e)
        {
            result = double.Parse(Lscore.Text);
            result = Math.Pow(result, 2);
            Lscore.Text = Convert.ToString(result);
        }

        private void Bsquareroot_Click(object sender, EventArgs e)
        {
            result = double.Parse(Lscore.Text);
            result = Math.Sqrt(result);
            Lscore.Text = Convert.ToString(result);
        }

        private void Badd_Click(object sender, EventArgs e)
        {
            result = double.Parse(Lscore.Text);
            add = true;
            Lscore.Text = "0";
        }

        private void Bequals_Click(object sender, EventArgs e)
        {
            if(add)
            {
                result2 = double.Parse(Lscore.Text);
                Lscore.Text = Convert.ToString(result + result2);
                add = false;
            }

            else if(subtract)
            {
                result2 = double.Parse(Lscore.Text);
                Lscore.Text = Convert.ToString(result - result2);
                subtract = false;
            }

            else if (multiply)
            {
                result2 = double.Parse(Lscore.Text);
                Lscore.Text = Convert.ToString(result * result2);
                multiply = false;
            }

            else if (divide)
            {
                result2 = double.Parse(Lscore.Text);
                if (result2 == 0)
                    Lscore.Text = "Can't divide by 0";

                else
                    Lscore.Text = Convert.ToString(result / result2);
                    
                multiply = false;

            }
        }

        private void Bminus_Click(object sender, EventArgs e)
        {
            result = double.Parse(Lscore.Text);
            subtract = true;
            Lscore.Text = "0";
        }

        private void Bmultiply_Click(object sender, EventArgs e)
        {
            result = double.Parse(Lscore.Text);
            multiply = true;
            Lscore.Text = "0";
        }

        private void Bdivide_Click(object sender, EventArgs e)
        {
            result = double.Parse(Lscore.Text);
            divide = true;
            Lscore.Text = "0";
        }
    }


}
