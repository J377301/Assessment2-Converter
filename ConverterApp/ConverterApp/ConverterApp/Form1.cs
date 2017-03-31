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
        double[] dbl_UofM = new double [5];
        double[] dbl_Convert = new double [5];
        int cnt = 0;
        
     
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void btn_CM_to_Inches_Click(object sender, EventArgs e)
        {
           
            //validate user entry and convert to a double 
            
            const double CM_TO_INCH = 0.3937;
            if (cnt > 4)
            {
                MessageBox.Show("No more than 5 values allowed.");
            }
            else
            {
                if (!double.TryParse(txt_UnitOfMeasure.Text, out dbl_UofM[cnt]))
                {
                    MessageBox.Show("A numeric must be entered. Please re-enter the value.");
                    txt_UnitOfMeasure.Clear();
                    txt_UnitOfMeasure.Focus();
                  
                }
                else
                {

                    dbl_Convert[cnt] = dbl_UofM[cnt] * CM_TO_INCH;
                    listBox.Items.Add(dbl_Convert[cnt].ToString() + "     cm to inch");
                    //txt_Convert.Text = dbl_Convert[i].ToString();
                    cnt++;
                }
            }
        }
        private void btn_M_to_Feet_Click(object sender, EventArgs e)
        {
            const double M_to_Feet = 3.280;

            if (cnt > 4)
            {
                MessageBox.Show("No more than 5 values allowed.");
            }
            else
            {
                if (!double.TryParse(txt_UnitOfMeasure.Text, out dbl_UofM[cnt]))
                {
                    MessageBox.Show("A numeric must be entered. Please re-enter the value.");
                    txt_UnitOfMeasure.Clear();
                    txt_UnitOfMeasure.Focus();      
                }
                else
                {

                    dbl_Convert[cnt] = dbl_UofM[cnt] * M_to_Feet;
                    listBox.Items.Add(dbl_Convert[cnt].ToString() + "     meters to feet");
                    //txt_Convert.Text = dbl_Convert[i].ToString();
                    cnt++;
                }
            }
        }

        private void btn_C_to_F_Click(object sender, EventArgs e)
        {
            const double C_to_F = 32;

            if (cnt > 4)
            {
                MessageBox.Show("No more than 5 values allowed.");
            }
            else
            {
                if (!double.TryParse(txt_UnitOfMeasure.Text, out dbl_UofM[cnt]))
                {
                    MessageBox.Show("A numeric must be entered. Please re-enter the value.");
                    txt_UnitOfMeasure.Clear();
                    txt_UnitOfMeasure.Focus();
                }
                else
                {

                    dbl_Convert[cnt] = dbl_UofM[cnt] + C_to_F;
                    listBox.Items.Add(dbl_Convert[cnt].ToString() + "     Celcius to Farenheit");
                    //txt_Convert.Text = dbl_Convert[i].ToString();
                    cnt++;
                }
            }
        }

        private void btn_CM_to_Feet_Click(object sender, EventArgs e)
        {
            const double CM_to_Feet = 0.03281;

            if (cnt > 4)
            {
                MessageBox.Show("No more than 5 values allowed.");
            }
            else
            {
                if (!double.TryParse(txt_UnitOfMeasure.Text, out dbl_UofM[cnt]))
                {
                    MessageBox.Show("A numeric must be entered. Please re-enter the value.");
                    txt_UnitOfMeasure.Clear();
                    txt_UnitOfMeasure.Focus();
                }
                else
                {

                    dbl_Convert[cnt] = dbl_UofM[cnt] * CM_to_Feet;
                    listBox.Items.Add(dbl_Convert[cnt].ToString() + "     centimeters to feet");
                    //txt_Convert.Text = dbl_Convert[i].ToString();
                    cnt++;
                }
            }
        }
        private void btn_KM_to_Miles_Click(object sender, EventArgs e)
        {
            const double KM_to_Miles = 0.6214;

            if (cnt > 4)
            {
                MessageBox.Show("No more than 5 values allowed.");
            }
            else
            {
                if (!double.TryParse(txt_UnitOfMeasure.Text, out dbl_UofM[cnt]))
                {
                    MessageBox.Show("A numeric must be entered. Please re-enter the value.");
                    txt_UnitOfMeasure.Clear();
                    txt_UnitOfMeasure.Focus();
                }
                else
                {

                    dbl_Convert[cnt] = dbl_UofM[cnt] * KM_to_Miles;
                    listBox.Items.Add(dbl_Convert[cnt].ToString() + "     kilometers to miles");
                    //txt_Convert.Text = dbl_Convert[i].ToString();
                    cnt++;
                }
            }
        }
        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
        }

    


