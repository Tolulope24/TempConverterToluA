using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Created by:Tolu Adebayo
 * Created on: 13-April-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #27 - Temperature Converter
 * This program...
*/
namespace TempConverterToluA
{
    public partial class frmTempConverter : Form
    {
        public frmTempConverter()
        {
            InitializeComponent();
        }
        public void ConvertTemp (float Celsius)
        {
            // Identify Variables
            float Fahrenheit;
            Fahrenheit = (float)9 / (float)5 * Celsius + 32;
            // Display Message Box
            MessageBox.Show("The Temperature is : " + Fahrenheit + " Fahrenheit" , "Conversion");
        }


        private void frmTempConverter_Load(object sender, EventArgs e)
        {

        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            // Identify Variables
            int UserTemperature;
            // convert from int to String
            UserTemperature = Convert.ToUInt16(this.txtDegrees.Text);
            // Call the function to calculate the area passing the UserTemperature by Value
            this.ConvertTemp(UserTemperature);

        }
    }
}
