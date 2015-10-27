/*
 * Created by: Nicholas  Ellul
 * Created on: 27-10-2015
 * Created for: ICS3U
 * Daily Assignment – Unit 4-02
 * This program...
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoundingProgram
{
    public partial class frmRoundNumber : Form
    {
        public void RoundMyNumber(ref double userInput, double roundedOffDigits)
        {
            //rounds number to specified amount of decimal spaces
            userInput = Math.Floor((userInput * Math.Pow(10,roundedOffDigits) + 0.5) / 100);

        }
        public frmRoundNumber()
        {
            InitializeComponent();
        }

        private void btnRound_Click(object sender, EventArgs e)
        {
            //input
            double userInput;
            double roundedOffDigits;
            string roundedAnswerAsString;

            userInput = Convert.ToDouble(this.txtUserInput.Text);
            roundedOffDigits = Convert.ToDouble(this.nudDecimalsToKeep.Value);

            //process
            RoundMyNumber(ref userInput, roundedOffDigits);
            roundedAnswerAsString = Convert.ToString(userInput);
        
            //output
            this.txtOutput.Text = roundedAnswerAsString;

            //roundUsingSINotation
            // roundedAnswer = Math.Round(userInput, roundedOffDigits);
            // roundedAnswerAsString = Convert.ToString(roundedAnswer);
        }
    }
}
