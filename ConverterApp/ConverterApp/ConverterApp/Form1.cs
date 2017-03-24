using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConverterApp
    // This program was written by Gail Mosdell
    // It forms the base of a converter program for the OS-Assessment Two for Cert IV
    // Date : February 2017
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        // Global Variables and Constants
        double[] dbl_UofM;
        double[] dbl_Convert;

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_CM_to_Inches_Click(object sender, EventArgs e)
        {
            const double CM_TO_INCH = 0.3937;
            dbl_UofM = new double[5];
            

            dbl_Convert = new double[5];
            // validate user entry and convert to a double
            
            //First Value

            if (!double.TryParse(txt_UnitOfMeasure1.Text, out dbl_UofM[0] ))
            {
                MessageBox.Show("A numeric must be entered. Please re-enter the value.");
                txt_UnitOfMeasure1.Clear();
                txt_UnitOfMeasure1.Focus();
                txt_Convert1.Clear();
                lbl_Convert.Text = "";
                lbl_Display.Text = "";
            }
            else
            {
                dbl_Convert[0] = dbl_UofM[0] * CM_TO_INCH;
                txt_Convert1.Text = dbl_Convert[0].ToString();
                lbl_Display.Text = txt_UnitOfMeasure1.Text + " centimetres is converted to ";
                lbl_Convert.Text = " inches.";
            }

            //Second Vale

            if (!double.TryParse(txt_UnitOfMeasure2.Text, out dbl_UofM[1]))
            {
                MessageBox.Show("A numeric must be entered. Please re-enter the value.");
                txt_UnitOfMeasure1.Clear();
                txt_UnitOfMeasure1.Focus();
                txt_Convert2.Clear();
                lbl_Convert.Text = "";
                lbl_Display.Text = "";
            }
            else
            {
                dbl_Convert[1] = dbl_UofM[1] * CM_TO_INCH;
                txt_Convert2.Text = dbl_Convert[1].ToString();
                lbl_Display.Text = txt_UnitOfMeasure2.Text + " centimetres is converted to ";
                lbl_Convert.Text = " inches.";
            }

            //Third Value

            if (!double.TryParse(txt_UnitOfMeasure3.Text, out dbl_UofM[2]))
            {
                MessageBox.Show("A numeric must be entered. Please re-enter the value.");
                txt_UnitOfMeasure1.Clear();
                txt_UnitOfMeasure1.Focus();
                txt_Convert3.Clear();
                lbl_Convert.Text = "";
                lbl_Display.Text = "";
            }
            else
            {
                dbl_Convert[2] = dbl_UofM[2] * CM_TO_INCH;
                txt_Convert3.Text = dbl_Convert[2].ToString();
                lbl_Display.Text = txt_UnitOfMeasure3.Text + " centimetres is converted to ";
                lbl_Convert.Text = " inches.";
            }

            //Fourth Value

            if (!double.TryParse(txt_UnitOfMeasure4.Text, out dbl_UofM[3]))
            {
                MessageBox.Show("A numeric must be entered. Please re-enter the value.");
                txt_UnitOfMeasure1.Clear();
                txt_UnitOfMeasure1.Focus();
                txt_Convert4.Clear();
                lbl_Convert.Text = "";
                lbl_Display.Text = "";
            }
            else
            {
                dbl_Convert[3] = dbl_UofM[3] * CM_TO_INCH;
                txt_Convert4.Text = dbl_Convert[3].ToString();
                lbl_Display.Text = txt_UnitOfMeasure4.Text + " centimetres is converted to ";
                lbl_Convert.Text = " inches.";
            }

            //Fifth Value

            if (!double.TryParse(txt_UnitOfMeasure5.Text, out dbl_UofM[4]))
            {
                MessageBox.Show("A numeric must be entered. Please re-enter the value.");
                txt_UnitOfMeasure1.Clear();
                txt_UnitOfMeasure1.Focus();
                txt_Convert5.Clear();
                lbl_Convert.Text = "";
                lbl_Display.Text = "";
            }
            else
            {
                dbl_Convert[4] = dbl_UofM[4] * CM_TO_INCH;
                txt_Convert5.Text = dbl_Convert[4].ToString();
                lbl_Display.Text = txt_UnitOfMeasure5.Text + " centimetres is converted to ";
                lbl_Convert.Text = " inches.";
            }
        }

        private void btn_M_to_Feet_Click(object sender, EventArgs e)
        {
            // Create Code for this procedure
        }

        
    }
}
