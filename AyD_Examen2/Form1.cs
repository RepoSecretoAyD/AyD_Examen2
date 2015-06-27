using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using AyD_Examen2.Roman_Converter;
using AyD_Examen2.SpellOutCheckAmount;
using AyD_Examen2.Template_Engine;

namespace AyD_Examen2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            splitContainer1.BorderStyle = BorderStyle.Fixed3D;
            tabPage3.BorderStyle = BorderStyle.Fixed3D;
            tabPage2.BorderStyle = BorderStyle.Fixed3D;
        }

        private void NumberToRomanConvertButton_Click(object sender, EventArgs e)
        {
            NumberToRomanOutputLabel.Text = RomanConverter.IntToRoman(Convert.ToInt32(NumberToRomanInputTextBox.Text));
        }

        private void RomanToNumberConvertButton_Click(object sender, EventArgs e)
        {
            RomanToNumberOutputLabel.Text = RomanConverter.RomanToInt(RomanToNumberInputTextBox.Text).ToString(CultureInfo.InvariantCulture);
        }

        private void CheckAmountConvertButton_Click(object sender, EventArgs e)
        {
            CheckAmountOutputTextBox.Text = new CheckAmount(Convert.ToDouble(CheckAmountInputTextBox.Text)).ToString();
        }

        private void TemplateEngineConvertButton_Click(object sender, EventArgs e)
        {
            var mapInput = TemplateEngineMapInputTextBox.Text;
            var mapInputList = mapInput.Split(';');
            var dict= mapInputList.Select(inputPair => inputPair.Split(',')).ToDictionary(splitInputPair => splitInputPair[0].Trim(), splitInputPair => splitInputPair[1].Trim());
            TemplateEngineOutputTextBox.Text = TemplateEngine.Evaluate(TemplateEngineTextInputTextBox.Text, dict);
        }
    }
}
