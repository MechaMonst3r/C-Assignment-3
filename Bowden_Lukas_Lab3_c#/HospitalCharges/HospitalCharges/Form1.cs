//Name: Lukas Bowden
//Student Number: T00040951
//Date: 2020-11-09
//Description: Takes in all hospital charges, calculates the total, then displays it.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalCharges
{
    public partial class HospitalCharges : Form
    {
        public HospitalCharges()
        {
            InitializeComponent();
        }

        private void charges_btn_Click(object sender, EventArgs e)
        {
            int days;
            double result1 = 0;
            double result2 = 0;
            double meds, surgical, lab, physical, finalResult;

            //Getting the number of days entered and completeing calculation.
            if (int.TryParse(days_tb.Text, out days)) 
            {
                //If the number of days entered is 0 or less, it will display an error.
                if (days <= 0)
                {
                    MessageBox.Show("Number of days must AT LEAST be 1.");
                    clearTextBox();
                }

                else
                {
                    //Calculates stay charges and stores result in variable.
                    result1 = calcStayCharges(days);
                }
            }

            //Getting the amounts of meds, labs, surgical, and physical fees and calcualting the total.
            if (double.TryParse(meds_tb.Text, out meds) && double.TryParse(lab_tb.Text, out lab) 
                && double.TryParse(surgical_tb.Text, out surgical) && double.TryParse(physical_tb.Text, out physical)) 
            {
                result2 = calcMisCharges(meds, surgical, lab, physical);
            }

            //Calculates the total cost of everything and stores it in a variable
            finalResult = calcTotalCharges(result1, result2);

            //Prints the total results of all charges to the Form.
            results_lbl.Text = "$" + finalResult.ToString();
        }


        //Methods that complete calculations
        public int calcStayCharges(int days) 
        {
            int result = days * 350;
            return result;
        }

        public double calcMisCharges(double meds, double surgical, double lab, double physical) 
        {
            double result = meds + surgical + lab + physical;
            return result;
        }

        public double calcTotalCharges(double result1, double result2) 
        {
            double finalResult = result1 + result2;
            return finalResult;
        }

        //Clears all input if recieved invalid entry
        public void clearTextBox() 
        {
            days_tb.Text = "";
            meds_tb.Text = "";
            lab_tb.Text = "";
            surgical_tb.Text = "";
            physical_tb.Text = "";
        }
    }
}
