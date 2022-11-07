using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var measureItems = new string[]
            {
            "л.",
            "м3.",
            "м.л.",
            "баррель",
            };
            cmbFirstType.DataSource = new List<string>(measureItems);
            cmbSecondType.DataSource = new List<string>(measureItems);
            cmbResultType.DataSource = new List<string>(measureItems);
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }
        private MeasureType GetMeasureType(ComboBox comboBox)
        {
            MeasureType measureType;
            switch (comboBox.Text)
            {
                case "л.":
                    measureType = MeasureType.l;
                    break;
                case "м3.":
                    measureType = MeasureType.M3;
                    break;
                case "м.л.":
                    measureType = MeasureType.ML;
                    break;
                case "баррель":
                    measureType = MeasureType.bar;
                    break;
                default:
                    measureType = MeasureType.l;
                    break;
            }
            return measureType;
        }
        private void Calculate()
        {
            try
            {
                var firstValue = double.Parse(textBox1.Text);
                var secondValue = double.Parse(textBox2.Text);
                MeasureType firstType = GetMeasureType(cmbFirstType);
                MeasureType secondType = GetMeasureType(cmbSecondType);
                MeasureType resultType = GetMeasureType(cmbResultType);

                var firstLength = new Volume(firstValue, firstType);
                var secondLength = new Volume(secondValue, secondType);
                Volume sumLength;

                switch (Operation.Text)
                {
                    case "+":
                        sumLength = firstLength + secondLength;
                        break;
                    case "-":
                        sumLength = firstLength - secondLength;
                        break;
                    case "*":
                        sumLength = firstLength * secondLength;
                        break;
                    case "/":
                        sumLength = firstLength / secondLength;
                        break;
                    default:
                        sumLength = new Volume (0, MeasureType.l);
                        break;
                }


                textResult.Text = sumLength.To(resultType).Verbose();
            }
            catch (FormatException)
            {

            }
        }

        private void Operation_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Calculate();
        }

        private void cmbFirstType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void cmbSecondType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void cmbResultType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculate();
        }
    }
}
