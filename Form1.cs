using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Übung_21
{
    public partial class Form1 : Form
    {
        double ans = 0;
        double x = 0;
        double y = 0;
        double z = 0;
        double a = 0;
        double b = 0;
        double c = 0;
        int counter = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void cmdRead_Click(object sender, EventArgs e)
        {
        }

        private void cmdCos_Click(object sender, EventArgs e)
        {
            if (checkBoxSecond.Checked)
            {
                textBox1.Text += "Acos(";
            }
            else
            {
                textBox1.Text += "Cos(";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void cmdZero_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void checkBoxSecond_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxSecond.Checked)
            {
                cmdAnswer.Text = "Ans";
                cmdBinary.Text = "->bin";
                cmdBracketClose.Text = "(";
                cmdBracketOpen.Text = ")";
                cmdCalc.Text = "Calc";
                cmdCeiling.Text = "Ceiling";
                cmdClearAll.Text = "ClrAll";
                cmdClearOne.Text = "Clr1";
                cmdComplex.Text = "i";
                cmdConstants.Text = "Pi";
                cmdConstants2.Text = "g";
                cmdConstants3.Text = "e-";
                cmdConvert.Text = "->hex";
                cmdCos.Text = "Cos";
                cmdDegToRad.Text = "°->rad";
                cmdDerivate.Text = "Deriv";
                cmdDivision.Text = "/";
                cmdDot.Text = ".";
                cmdDown.Text = "v";
                cmdEight.Text = "8";
                cmdEquation.Text = "LinEq";
                cmdExponents.Text = "e^";
                cmdFive.Text = "5";
                cmdFour.Text = "4";
                cmdIntegral.Text = "Integr";
                cmdLeft.Text = "<-";
                cmdLn.Text = "ln";
                cmdMinus.Text = "-";
                cmdMultiply.Text = "*";
                cmdNewVariable.Text = "setx";
                cmdNine.Text = "9";
                cmdOne.Text = "1";
                cmdPlus.Text = "+";
                cmdPosition.Text = "Pos";
                cmdRandom.Text = "rand";
                cmdRight.Text = "->";
                cmdRound.Text = "Round";
                cmdSaveAnswer.Text = "Save Ans";
                cmdSeven.Text = "7";
                cmdSign.Text = "+/-";
                cmdSin.Text = "Sin";
                cmdSix.Text = "6";
                cmdSqrt.Text = "Sqrt";
                cmdSquared.Text = "^x";
                cmdSwitch.Text = "1/x";
                cmdTan.Text = "Tan";
                cmdThree.Text = "3";
                cmdTwo.Text = "2";
                cmdUp.Text = "^";
                cmdZero.Text = "0";
            }
            else
            {
                cmdAnswer.Text = "Ans";
                cmdBinary.Text = "->oct";
                cmdBracketClose.Text = "[";
                cmdBracketOpen.Text = "]";
                cmdCalc.Text = "Calc";
                cmdCeiling.Text = "Floor";
                cmdClearAll.Text = "Manipulate";
                cmdClearOne.Text = "Clr1";
                cmdComplex.Text = "Re";
                cmdConstants.Text = "e";
                cmdConstants2.Text = "c";
                cmdConstants3.Text = "me";
                cmdConvert.Text = "->dec";
                cmdCos.Text = "Acos";
                cmdDegToRad.Text = "rad->°";
                cmdDerivate.Text = "Diff";
                cmdDivision.Text = "%";
                cmdDot.Text = ",";
                cmdDown.Text = "v";
                cmdEight.Text = "8";
                cmdEquation.Text = "ExEqu";
                cmdExponents.Text = "E^";
                cmdFive.Text = "E";
                cmdFour.Text = "D";
                cmdIntegral.Text = "Integr";
                cmdLeft.Text = "<-";
                cmdLn.Text = "log";
                cmdMinus.Text = "-";
                cmdMultiply.Text = "!";
                cmdNewVariable.Text = "getx";
                cmdNine.Text = "9";
                cmdOne.Text = "A";
                cmdPlus.Text = "+";
                cmdPosition.Text = "Pos";
                cmdRandom.Text = "rand";
                cmdRight.Text = "->";
                cmdRound.Text = "Truncate";
                cmdSaveAnswer.Text = "Save Ans";
                cmdSeven.Text = "7";
                cmdSign.Text = "|x|";
                cmdSin.Text = "Asin";
                cmdSix.Text = "F";
                cmdSqrt.Text = "xSqrt";
                cmdSquared.Text = "^2";
                cmdSwitch.Text = "x/y";
                cmdTan.Text = "Atan";
                cmdThree.Text = "C";
                cmdTwo.Text = "B";
                cmdUp.Text = "^";
                cmdZero.Text = "0";
            }
        }

        private void cmdOne_Click(object sender, EventArgs e)
        {
            if (checkBoxSecond.Checked)
            {
                textBox1.Text += "A";
            }
            else
            {
                textBox1.Text += "1";
            }
        }

        private void cmdTwo_Click(object sender, EventArgs e)
        {

            if (checkBoxSecond.Checked)
            {
                textBox1.Text += "B";
            }
            else
            {
                textBox1.Text += "2";
            }
        }

        private void cmdThree_Click(object sender, EventArgs e)
        {

            if (checkBoxSecond.Checked)
            {
                textBox1.Text += "C";
            }
            else
            {
                textBox1.Text += "3";
            }
        }

        private void cmdFour_Click(object sender, EventArgs e)
        {

            if (checkBoxSecond.Checked)
            {
                textBox1.Text += "D";
            }
            else
            {
                textBox1.Text += "4";
            }
        }

        private void cmdFive_Click(object sender, EventArgs e)
        {

            if (checkBoxSecond.Checked)
            {
                textBox1.Text += "E";
            }
            else
            {
                textBox1.Text += "5";
            }
        }

        private void cmdSix_Click(object sender, EventArgs e)
        {
            if (checkBoxSecond.Checked)
            {
                textBox1.Text += "F";
            }
            else
            {
                textBox1.Text += "6";
            }
        }

        private void cmdSeven_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void cmdEight_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void cmdNine_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void cmdDot_Click(object sender, EventArgs e)
        {
            if (checkBoxSecond.Checked)
            {
                textBox1.Text += ",";
            }
            else
            {
                textBox1.Text += ".";
            }
        }

        private void cmdConstants_Click(object sender, EventArgs e)
        {

            if (checkBoxSecond.Checked)
            {
                textBox1.Text += "e";
            }
            else
            {
                textBox1.Text += "Pi";
            }
        }

        private void cmdBracketOpen_Click(object sender, EventArgs e)
        {

            if (checkBoxSecond.Checked)
            {
                textBox1.Text += "[";
            }
            else
            {
                textBox1.Text += "(";
            }
        }

        private void cmdBracketClose_Click(object sender, EventArgs e)
        {

            if (checkBoxSecond.Checked)
            {
                textBox1.Text += "]";
            }
            else
            {
                textBox1.Text += ")";
            }
        }

        private void cmdSin_Click(object sender, EventArgs e)
        {
            if (checkBoxSecond.Checked)
            {
                textBox1.Text += "Asin(";
            }
            else
            {
                textBox1.Text += "Sin(";
            }
        }

        private void cmdTan_Click(object sender, EventArgs e)
        {
            if (checkBoxSecond.Checked)
            {
                textBox1.Text += "Atan(";
            }
            else
            {
                textBox1.Text += "Tan(";
            }
        }

        private void cmdConstants2_Click(object sender, EventArgs e)
        {
            if (checkBoxSecond.Checked)
            {
                textBox1.Text += "c";
            }
            else
            {
                textBox1.Text += "g";
            }
        }

        private void cmdConstants3_Click(object sender, EventArgs e)
        {
            if (checkBoxSecond.Checked)
            {
                textBox1.Text += "me";
            }
            else
            {
                textBox1.Text += "(e-)";
            }
        }

        private void cmdDivision_Click(object sender, EventArgs e)
        {
            if (checkBoxSecond.Checked)
            {
                textBox1.Text += "%";
            }
            else
            {
                textBox1.Text += "/";
            }
        }

        private void cmdMultiply_Click(object sender, EventArgs e)
        {
            if (checkBoxSecond.Checked)
            {
                textBox1.Text += "!(";
            }
            else
            {
                textBox1.Text += "*";
            }
        }

        private void cmdRound_Click(object sender, EventArgs e)
        {
            if (checkBoxSecond.Checked)
            {
                textBox1.Text += "Truncate(";
            }
            else
            {
                textBox1.Text += "Round(";
            }
        }

        private void cmdCeiling_Click(object sender, EventArgs e)
        {
            if (checkBoxSecond.Checked)
            {
                textBox1.Text += "Floor(";
            }
            else
            {
                textBox1.Text += "Ceiling(";
            }
        }

        private void cmdExponents_Click(object sender, EventArgs e)
        {
            if (checkBoxSecond.Checked)
            {
                textBox1.Text += "E^(";
            }
            else
            {
                textBox1.Text += "e^(";
            }
        }

        private void cmdSquared_Click(object sender, EventArgs e)
        {
            if (checkBoxSecond.Checked)
            {
                textBox1.Text += "^(2)";
            }
            else
            {
                textBox1.Text += "^(";
            }
        }

        private void cmdSqrt_Click(object sender, EventArgs e)
        {
            if (checkBoxSecond.Checked)
            {
                textBox1.Text += "Sqrt(";
            }
            else
            {
                textBox1.Text += "Sqrt(";
            }
        }

        private void cmdDegToRad_Click(object sender, EventArgs e)
        {
            if (checkBoxSecond.Checked)
            {
                textBox1.Text += "rad->°";
            }
            else
            {
                textBox1.Text += "°->rad";
            }
        }

        private void cmdSwitch_Click(object sender, EventArgs e)
        {
            if (checkBoxSecond.Checked)
            {
                textBox1.Text += "c";
            }
            else
            {
                textBox1.Text += "g";
            }
        }

        private void cmdConvert_Click(object sender, EventArgs e)
        {
            if (checkBoxSecond.Checked)
            {
                textBox1.Text += "->dec";
            }
            else
            {
                textBox1.Text += "->hex";
            }
        }

        private void cmdBinary_Click(object sender, EventArgs e)
        {
            if (checkBoxSecond.Checked)
            {
                textBox1.Text += "->oct";
            }
            else
            {
                textBox1.Text += "->bin";
            }
        }

        private void cmdComplex_Click(object sender, EventArgs e)
        {
            if (checkBoxSecond.Checked)
            {
                textBox1.Text += "Re(";
            }
            else
            {
                textBox1.Text += "i";
            }
        }

        private void cmdPlus_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+";
        }

        private void cmdMinus_Click(object sender, EventArgs e)
        {
            textBox1.Text += "-";
        }

        private void cmdRandom_Click(object sender, EventArgs e)
        {
            textBox1.Text += "rand(";
        }

        private void cmdLn_Click(object sender, EventArgs e)
        {
            if (checkBoxSecond.Checked)
            {
                textBox1.Text += "log(";
            }
            else
            {
                textBox1.Text += "ln(";
            }
        }

        private void cmdSaveAnswer_Click(object sender, EventArgs e)
        {
            ans = Convert.ToDouble(textBox1.Text);
        }

        private void cmdNewVariable_Click(object sender, EventArgs e)
        {
            if (checkBoxSecond.Checked)
            {
                switch (counter)
                {
                    case 0:
                        x = Convert.ToDouble(textBox1.Text);
                        lblInfo.Text = "x->";
                        counter++;
                        break;
                    case 1:
                        y = Convert.ToDouble(textBox1.Text);
                        lblInfo.Text = "y->";
                        counter++;
                        break;
                    case 2:
                        z = Convert.ToDouble(textBox1.Text);
                        lblInfo.Text = "z->";
                        counter++;
                        break;
                    case 3:
                        a = Convert.ToDouble(textBox1.Text);
                        lblInfo.Text = "a->";
                        counter++;
                        break;
                    case 4:
                        b = Convert.ToDouble(textBox1.Text);
                        lblInfo.Text = "b->";
                        counter++;
                        break;
                    case 5:
                        c = Convert.ToDouble(textBox1.Text);
                        lblInfo.Text = "c->";
                        counter = 0;
                        break;
                }
            }
            else
            {

                switch (counter)
                {
                    case 0:
                        x = Convert.ToDouble(textBox1.Text);
                        lblInfo.Text = "->x";
                        counter++;
                        break;
                    case 1:
                        y = Convert.ToDouble(textBox1.Text);
                        lblInfo.Text = "->y";
                        counter++;
                        break;
                    case 2:
                        z = Convert.ToDouble(textBox1.Text);
                        lblInfo.Text = "->z";
                        counter++;
                        break;
                    case 3:
                        a = Convert.ToDouble(textBox1.Text);
                        lblInfo.Text = "->a";
                        counter++;
                        break;
                    case 4:
                        b = Convert.ToDouble(textBox1.Text);
                        lblInfo.Text = "->b";
                        counter++;
                        break;
                    case 5:
                        c = Convert.ToDouble(textBox1.Text);
                        lblInfo.Text = "->c";
                        counter = 0;
                        break;
                }
            }
        }

        private void cmdClearAll_Click(object sender, EventArgs e)
        {
            if (checkBoxSecond.Checked)
            {
                textBox1.Enabled = !textBox1.Enabled;
            }
            else
            {
                textBox1.Text = "";
            }
        }

        private void cmdClearOne_Click(object sender, EventArgs e)
        {
            if (textBox1.Enabled)
            {
                textBox1.Text = textBox1.Text.Remove(Convert.ToInt32(textBox1.Cursor), Convert.ToInt32(textBox1.Cursor));
            }
            else
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }

        private void cmdIntegral_Click(object sender, EventArgs e)
        {
            textBox1.Text += "Integr(";
        }

        private void cmdSign_Click(object sender, EventArgs e)
        {
            if (checkBoxSecond.Checked)
            {
                textBox1.Text += "|";
            }
            else
            {
                if (textBox1.Text.StartsWith("-"))
                {
                    textBox1.Text = textBox1.Text.Substring(1);
                }
                else
                {
                    textBox1.Text = "-" + textBox1.Text;
                }
            }
        }

        private void cmdCalc_Click(object sender, EventArgs e)
        {

        }

        private int Interpretations(string content)
        {
            List<string> calculation = new List<string>();

            if (content.Length == 0)
            {
                return 0;
            }
            else
            {
                for (int index = 0; index < content.Length; index++)
                {
                    if (content[index].Equals('A'))
                    {
                        index++;
                        if (content[index].Equals('n'))
                        {
                            calculation.Add(ans.ToString());
                            index+=2;
                        }
                        else if (content[index].Equals('c'))
                        {
                            index += 3;
                            calculation.Add(Convert.ToString(Acos(Convert.ToDouble(content.Substring(index, content.IndexOf(')', index) - 1)))));
                            index = content.IndexOf(')', index) - 1;
                        }
                        else if (content[index].Equals('s'))
                        {
                            index += 3;
                            calculation.Add(Convert.ToString(Asin(Convert.ToDouble(content.Substring(index, content.IndexOf(')', index) - 1)))));
                            index = content.IndexOf(')', index) - 1;
                        }
                        else if (content[index].Equals('t'))
                        {
                            index += 3;
                            calculation.Add(Convert.ToString(Atan(Convert.ToDouble(content.Substring(index, content.IndexOf(')', index) - 1)))));
                            index = content.IndexOf(')', index) - 1;
                        }
                    }
                    else if (content[index].Equals('C') && content[index + 1].Equals('o'))
                    {
                        index += 3;
                        calculation.Add(Convert.ToString(Cos(Convert.ToDouble(content.Substring(index, content.IndexOf(')', index) - 1)))));
                        index = content.IndexOf(')', index) - 1;
                    }
                    else if (content[index].Equals('S') && content[index + 1].Equals('i'))
                    {
                        index += 3;
                        calculation.Add(Convert.ToString(Sin(Convert.ToDouble(content.Substring(index, content.IndexOf(')', index) - 1)))));
                        index = content.IndexOf(')', index) - 1;
                    }
                    else if (content[index].Equals('T') && content[index + 1].Equals('a'))
                    {
                        index += 3;
                        calculation.Add(Convert.ToString(Tan(Convert.ToDouble(content.Substring(index, content.IndexOf(')', index) - 1)))));
                        index = content.IndexOf(')', index) - 1;
                    }
                    else if (content[index].Equals('F') && content[index + 1].Equals('l'))
                    {
                        index += 5;
                        calculation.Add(Convert.ToString(Math.Floor(Convert.ToDouble(content.Substring(index, content.IndexOf(')', index) - 1)))));
                        index = content.IndexOf(')', index) - 1;
                    }
                    else if (content[index].Equals('T') && content[index + 1].Equals('r'))
                    {
                        index += 8;
                        calculation.Add(Convert.ToString(Math.Truncate(Convert.ToDouble(content.Substring(index, content.IndexOf(')', index) - 1)))));
                        index = content.IndexOf(')', index) - 1;
                    }
                    else if (content[index].Equals('R') && content[index + 1].Equals('o'))
                    {
                        index += 5;
                        calculation.Add(Convert.ToString(Math.Round(Convert.ToDouble(content.Substring(index, content.IndexOf(')', index) - 1)))));
                        index = content.IndexOf(')', index) - 1;
                    }
                    else if (content[index].Equals('r') && content[index + 1].Equals('a'))
                    {
                        index += 4;
                        Random rand = new Random(Convert.ToInt32(content.Substring(index, content.IndexOf(')', index) - 1)));
                        calculation.Add(Convert.ToString(rand));
                        index = content.IndexOf(')', index) - 1;
                    }
                    else if (content[index].Equals('R') && content[index + 1].Equals('e'))
                    {
                        index += 2;
                        calculation.Add(Convert.ToString(Real(content.Substring(index, content.IndexOf(')', index) - 1))));
                        index = content.IndexOf(')', index) - 1;
                    }
                    else if (content[index].Equals('g') && content[index + 1].Equals('e'))
                    {
                        index += 4;
                        calculation.Add(Convert.ToString(ans));
                    }
                    else if (content[index].Equals('s') && content[index + 1].Equals('e'))
                    {
                        index += 4;
                        ans = Convert.ToDouble(content.Substring(index, content.IndexOf(')', index) - 1));
                        index = content.IndexOf(')', index) - 1;
                    }
                    else if (content[index].Equals('e'))
                    {
                        if (content[index + 1].Equals('-'))
                        {
                            index++;
                            calculation.Add(Convert.ToString(0.0000000000000000001602176634));
                        }
                        else if (content[index + 1].Equals('^'))
                        {
                            index += 3;
                            calculation.Add(Convert.ToString(Math.Pow(Math.E, Convert.ToDouble(content.Substring(index, content.IndexOf(')', index) - 1)))));
                            index = content.IndexOf(')', index) - 1;
                        }
                        else
                        {
                            calculation.Add(Convert.ToString(Math.E));
                        }
                    }
                    else if (content[index].Equals('P') && content[index + 1].Equals('i'))
                    {
                        index++;
                        calculation.Add(Convert.ToString(Math.PI));
                    }
                    else if (content[index].Equals('m') && content[index + 1].Equals('e'))
                    {
                        index++;
                        calculation.Add(Convert.ToString(0.00000000000000000000000000000091093837015));
                    }
                    else if (content[index].Equals('g'))
                    {
                        calculation.Add(Convert.ToString(9.80665));
                    }
                    else if (content[index].Equals('c'))
                    {
                        calculation.Add(Convert.ToString(299792458));
                    }
                    else if (content[index].Equals('-') && content[index].Equals('>'))
                    {
                        index += 2;
                        if (content[index].Equals('h'))
                        {
                            calculation[calculation.Count - 1] = DecToHex(Convert.ToInt32(calculation[calculation.Count - 1]));
                        }
                        else if (content[index].Equals('b'))
                        {
                            calculation[calculation.Count - 1] = DecToBin(Convert.ToInt32(calculation[calculation.Count - 1]));
                        }
                        else if (content[index].Equals('d'))
                        {
                            calculation[calculation.Count - 1] = Convert.ToString(HexToDec(Convert.ToString(calculation[calculation.Count - 1])));
                        }
                        else if (content[index].Equals('o'))
                        {
                            calculation[calculation.Count - 1] = DecToOct(Convert.ToInt32(calculation[calculation.Count - 1]));
                        }
                        index += 2;
                    }
                    else if (content[index].Equals('°'))
                    {
                        index += 5;
                        calculation[calculation.Count - 1] = Convert.ToString(DegToRad(Convert.ToInt32(calculation[calculation.Count - 1])));
                    }
                    else if (content[index].Equals('r') && content[index].Equals('a') && content[index].Equals('d'))
                    {
                        index += 5;
                        calculation[calculation.Count - 1] = Convert.ToString(RadToDeg(Convert.ToInt32(calculation[calculation.Count - 1])));
                    }
                    else if (content[index].Equals('|'))
                    {
                        calculation.Add(Convert.ToString(Math.Abs(Convert.ToDouble(content.Substring(index, content.IndexOf('|', index) - 1)))));
                        index = content.IndexOf('|', index) - 1;
                    }
                    else if (content[index].Equals('^') && content[index + 1].Equals('('))
                    {
                        index++;
                        calculation[calculation.Count - 1] = Convert.ToString(Math.Pow(Convert.ToDouble(calculation[calculation.Count - 1]), Convert.ToDouble(content.Substring(index, content.IndexOf(')', index) - 1))));
                        index = content.IndexOf(')', index) - 1;
                    }
                    else if (content[index].Equals('S') && content[index + 1].Equals('q'))
                    {
                        index += 3;
                        calculation.Add(Convert.ToString(Math.Sqrt(Convert.ToDouble(content.Substring(index, content.IndexOf(')', index) - 1)))));
                        index = content.IndexOf(')', index) - 1;
                    }
                    else if (content[index].Equals('*'))
                    {
                        calculation.Add("*");
                    }
                    else if (content[index].Equals('+'))
                    {
                        calculation.Add("+");
                    }
                    else if (content[index].Equals('/'))
                    {
                        calculation.Add("/");
                    }
                    else if (content[index].Equals('%'))
                    {
                        calculation.Add("%");
                    }
                    else if (content[index].Equals('!'))
                    {
                        index++;
                        calculation.Add(Convert.ToString(Fact(Convert.ToDouble(content.Substring(index, content.IndexOf(')', index) - 1)))));
                        index = content.IndexOf(')', index) - 1;
                    }
                    else
                    {
                        string number = "";
                        do
                        {
                            number += content[index];
                            index++;
                        } while (content[index].Equals('0') || content[index].Equals('1') || content[index].Equals('2') || content[index].Equals('3') || content[index].Equals('4') || content[index].Equals('5') || content[index].Equals('6') || content[index].Equals('7') || content[index].Equals('8') || content[index].Equals('9') || content[index].Equals('.') || content[index].Equals(',') || content[index].Equals('A') || content[index].Equals('B') || content[index].Equals('C') || content[index].Equals('D') || content[index].Equals('E') || content[index].Equals('F'));
                        index--;
                        calculation.Add(number);
                    }
                }
            }

            int res = Convert.ToInt32(calculation[0]);

            for (int i = 1; i < calculation.Count; i++)
            {
                if(calculation[i] == "+")
                {
                    res += Convert.ToInt32(calculation[i + 1]);
                    i++;
                }
                else if (calculation[i] == "-")
                {
                    res -= Convert.ToInt32(calculation[i + 1]);
                    i++;
                }
                else if (calculation[i] == "*")
                {
                    res *= Convert.ToInt32(calculation[i + 1]);
                    i++;
                }
                else if (calculation[i] == "/")
                {
                    res /= Convert.ToInt32(calculation[i + 1]);
                    i++;
                }
                else if (calculation[i] == "%")
                {
                    res %= Convert.ToInt32(calculation[i + 1]);
                    i++;
                }
            }
            return res;
        }

        private void cmdAnswer_Click(object sender, EventArgs e)
        {
            textBox1.Text += "Ans";
        }

        public double Acos(double val)
        {
            return Math.Acos(val);
        }

        public double Cos(double val)
        {
            return Math.Cos(val);
        }

        public double Asin(double val)
        {
            return Math.Asin(val);
        }

        public double Sin(double val)
        {
            return Math.Sin(val);
        }

        public double Atan(double val)
        {
            return Math.Atan(val);
        }

        public double Tan(double val)
        {
            return Math.Tan(val);
        }

        public double Abs(double val)
        {
            return Math.Abs(val);
        }

        public double Sqrt(double val, double exp)
        {
            double res = val;

            while (exp > 1)
            {
                res = Sqrt(Math.Sqrt(val), exp - 1);
            }

            return res;
        }

        public double Pow(double val, double exp)
        {
            return Pow(Math.Pow(val, 2), exp);
        }

        public double DegToRad(double deg)
        {
            return deg * Math.PI / 180;
        }

        public double RadToDeg(double rad)
        {
            return rad / Math.PI * 180;
        }

        public string DecToHex(int dec)
        {
            string hex = "";

            while (dec > 15)
            {
                switch (dec % 16)
                {
                    case 0:
                        hex += "0";
                        break;
                    case 1:
                        hex += "1";
                        break;
                    case 2:
                        hex += "2";
                        break;
                    case 3:
                        hex += "3";
                        break;
                    case 4:
                        hex += "4";
                        break;
                    case 5:
                        hex += "5";
                        break;
                    case 6:
                        hex += "6";
                        break;
                    case 7:
                        hex += "7";
                        break;
                    case 8:
                        hex += "8";
                        break;
                    case 9:
                        hex += "9";
                        break;
                    case 10:
                        hex += "A";
                        break;
                    case 11:
                        hex += "B";
                        break;
                    case 12:
                        hex += "C";
                        break;
                    case 13:
                        hex += "D";
                        break;
                    case 14:
                        hex += "E";
                        break;
                    case 15:
                        hex += "F";
                        break;
                }
                DecToHex((dec - dec % 16) / 16);
            }
            hex += dec;
            return hex;
        }

        public int HexToDec(string hex)
        {
            int dec = 0;

            for (int i = 0; i < hex.Length; i++)
            {
                switch (hex[i])
                {
                    case '1':
                        dec += Convert.ToInt32(Math.Pow(i * 4, 2) * 1);
                        break;
                    case '2':
                        dec += Convert.ToInt32(Math.Pow(i * 4, 2) * 2);
                        break;
                    case '3':
                        dec += Convert.ToInt32(Math.Pow(i * 4, 2) * 3);
                        break;
                    case '4':
                        dec += Convert.ToInt32(Math.Pow(i * 4, 2) * 4);
                        break;
                    case '5':
                        dec += Convert.ToInt32(Math.Pow(i * 4, 2) * 5);
                        break;
                    case '6':
                        dec += Convert.ToInt32(Math.Pow(i * 4, 2) * 6);
                        break;
                    case '7':
                        dec += Convert.ToInt32(Math.Pow(i * 4, 2) * 7);
                        break;
                    case '8':
                        dec += Convert.ToInt32(Math.Pow(i * 4, 2) * 8);
                        break;
                    case '9':
                        dec += Convert.ToInt32(Math.Pow(i * 4, 2) * 9);
                        break;
                    case 'A':
                        dec += Convert.ToInt32(Math.Pow(i * 4, 2) * 10);
                        break;
                    case 'B':
                        dec += Convert.ToInt32(Math.Pow(i * 4, 2) * 11);
                        break;
                    case 'C':
                        dec += Convert.ToInt32(Math.Pow(i * 4, 2) * 12);
                        break;
                    case 'D':
                        dec += Convert.ToInt32(Math.Pow(i * 4, 2) * 13);
                        break;
                    case 'E':
                        dec += Convert.ToInt32(Math.Pow(i * 4, 2) * 14);
                        break;
                    case 'F':
                        dec += Convert.ToInt32(Math.Pow(i * 4, 2) * 15);
                        break;
                }
            }
            return dec;
        }

        public string DecToBin(int dec)
        {
            string bin = "";

            while (dec > 1)
            {
                switch (dec % 2)
                {
                    case 0:
                        bin += "0";
                        break;
                    case 1:
                        bin += "1";
                        break;
                }
                DecToBin((dec - dec % 2) / 2);
            }
            bin += dec;
            return bin;
        }

        public string DecToOct(int dec)
        {
            string oct = "";

            while (dec > 7)
            {
                switch (dec % 8)
                {
                    case 0:
                        oct += "0";
                        break;
                    case 1:
                        oct += "1";
                        break;
                    case 2:
                        oct += "2";
                        break;
                    case 3:
                        oct += "3";
                        break;
                    case 4:
                        oct += "4";
                        break;
                    case 5:
                        oct += "5";
                        break;
                    case 6:
                        oct += "6";
                        break;
                    case 7:
                        oct += "7";
                        break;
                }
                DecToOct((dec - dec % 7) / 7);
            }
            oct += dec;
            return oct;
        }

        public double Real(string complex)
        {
            string[] splits = complex.Split('+', '-');

            return Convert.ToDouble(splits[0]);
        }

        public double Complex(string complex)
        {
            string[] splits = complex.Split('+', '-');

            return Convert.ToDouble(splits[1].Trim('i'));
        }

        public double Fact(double val)
        {
            if(val > 0)
                return val * Fact(val - 1);

            return 1;
        }
    }
}
