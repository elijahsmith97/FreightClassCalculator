/**
 * Author: Elijah Smith
 * Date Completed: 6/25/2018
 * Version: 1.0
 * This program uses Freight Class calculations to convert suggested Density into the correct Freight Class.
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

namespace FreightClass
{
    public partial class Form1 : Form
    {
        double height;
        double width;
        double depth;
        double weight;
        List<DimensionClass> dimensionsList = new List<DimensionClass>();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalc(object sender, EventArgs e)
        {
            FreightClassCalc fc = new FreightClassCalc();
            DimensionClass dc = new DimensionClass();

            if (double.TryParse(textHeight.Text, out height) &&
                double.TryParse(textWidth.Text, out width) &&
                double.TryParse(textDepth.Text, out depth) &&
                double.TryParse(textWeight.Text, out weight))
            {
                textDensity.Text = fc.getDensity(height, width, depth, weight, ref dc).ToString();
                textFreightClass.Text = fc.getFreightClass(fc.getDensity(height, width, depth, weight, ref dc)).ToString();
                dimensionsList.Add(dc);
                btnClear.Enabled = true;
            }
        }

        private void btnAdd(object sender, EventArgs e)
        {
            FreightClassCalc fc1 = new FreightClassCalc();

            String density = "Item Density: " + textDensity.Text;
            String freight = "Freight Class: " + textFreightClass.Text;
            textHeight.Clear();
            textWidth.Clear();
            textDepth.Clear();
            textWeight.Clear();
            historyLog.Items.Add(density);
            historyLog.Items.Add(freight);
            historyLog.Items.Add("");

            textTotalDensity.Text = fc1.getDensity(dimensionsList).ToString();
            textFreightTotal.Text = (fc1.getFreightClass(Double.Parse(textTotalDensity.Text))).ToString();
            textDensity.Clear();
            textFreightClass.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
