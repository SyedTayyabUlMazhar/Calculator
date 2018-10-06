using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_BETA_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void zero_Click(object sender, EventArgs e)
        {
            display.Text += zero.Text;
        }

        private void one_Click(object sender, EventArgs e)
        {
            display.Text += one.Text;
        }

        private void two_Click(object sender, EventArgs e)
        {
            display.Text += two.Text;
        }

        private void three_Click(object sender, EventArgs e)
        {
            display.Text += three.Text;
        }

        private void four_Click(object sender, EventArgs e)
        {
            display.Text += four.Text;
        }

        private void five_Click(object sender, EventArgs e)
        {
            display.Text += five.Text;
        }

        private void six_Click(object sender, EventArgs e)
        {
            display.Text += six.Text;
        }

        private void seven_Click(object sender, EventArgs e)
        {
            display.Text += seven.Text;
        }

        private void eight_Click(object sender, EventArgs e)
        {
            display.Text += eight.Text;
        }

        private void nine_Click(object sender, EventArgs e)
        {
            display.Text += nine.Text;
        }

        private void point_Click(object sender, EventArgs e)
        {
            display.Text += point.Text;
        }

        private void divide_Click(object sender, EventArgs e)
        {
            display.Text += divide.Text;
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            display.Text += multiply.Text;
        }

        private void add_Click(object sender, EventArgs e)
        {
            display.Text += add.Text;
        }

        private void subtract_Click(object sender, EventArgs e)
        {
            display.Text += subtract.Text;
        }

        /*
        private void equal_Click(object sender, EventArgs e)
        {
            
                
                string exp = display.Text; // 28.25

                string expCopy = exp;

                if (expCopy[0] != '+' && expCopy[0] != '-') expCopy = expCopy.Insert(0, "+");

                char Operator; // the operator that we will evaluate ('x')
                int index;     // the index of the operator that we will evaluate

                char[] operators = { 'x', '/', '+', '-' };
                for (int j = 0, k = 1; k < 4; j +=2, k+=2)
                {
                    bool hasOperatorJ = (expCopy.IndexOf(operators[j], 1) != -1);
                    bool hasOperatorK = (expCopy.IndexOf(operators[k], 1) != -1);

                    int indexOfOperatorJ = expCopy.IndexOf(operators[j], 1);
                    int indexOfOperatorK = expCopy.IndexOf(operators[k], 1);

                    while (hasOperatorJ || hasOperatorK) //while atleast one of 'x' and '/' or '+' and '-' is present when searching from [1] 
                    {

                        // If both 'x' and '/' when 'j'=0 are present, OR if both '+' and '-' when j=2 are present 
                        if (hasOperatorJ && hasOperatorK)
                        {
                            //then the index = the index of operator which precedes the other
                            index = (indexOfOperatorJ < indexOfOperatorK) ? indexOfOperatorJ : indexOfOperatorK;
                        }
                        else // if one of them is present
                        {
                            //then the index = the index of the operator which is present
                            index = (hasOperatorJ) ? indexOfOperatorJ : indexOfOperatorK;
                        }

                        Operator = expCopy[index];

                        string op1 = "", op2 = ""; // operands of 'Operator'
                        string resultOfOperation = ""; // the result of expression ---> op1 Operator op2

                        int i;

                        //get 'op1'
                        for (i = index - 1; expCopy[i] != '+' && expCopy[i] != '-'; i--)
                        {
                            op1 = op1.Insert(0, expCopy[i].ToString());
                        }
                        op1 = op1.Insert(0, expCopy[i].ToString());

                        //get 'op2'
                        for (i = index + 1; (expCopy[i] != '+' && expCopy[i] != '-' && expCopy[i] != operators[j] && expCopy[i] != operators[j + 1]); i++)
                        {
                            op2 += expCopy[i];
                            if (i == expCopy.Length - 1) break;
                        }

                        if (Operator == 'x' || Operator == '/')
                            resultOfOperation = (Operator == operators[j]) ?
                                                (Convert.ToDouble(op1) * Convert.ToDouble(op2)).ToString()
                                                :
                                                (Convert.ToDouble(op1) / Convert.ToDouble(op2)).ToString();
                        else
                            resultOfOperation = (Operator == operators[j]) ?
                                           (Convert.ToDouble(op1) + Convert.ToDouble(op2)).ToString()
                                           :
                                           (Convert.ToDouble(op1) - Convert.ToDouble(op2)).ToString();

                        if (resultOfOperation[0] != '-') resultOfOperation = resultOfOperation.Insert(0, "+");

                        int op1Start = index - op1.Length;
                        int op2End = index + op2.Length;

                        // Remove the expression we just calculated, then insert in its' place the result
                        expCopy = expCopy.Remove(op1Start, op2End - op1Start + 1).Insert(op1Start, resultOfOperation);

                        hasOperatorJ = (expCopy.IndexOf(operators[j], 1) != -1);
                        hasOperatorK = (expCopy.IndexOf(operators[j + 1], 1) != -1);
                        indexOfOperatorJ = expCopy.IndexOf(operators[j], 1);
                        indexOfOperatorK = expCopy.IndexOf(operators[j + 1], 1);
                    }
                }

                display.Text = expCopy;

                
            }
            */

        private void equal_Click(object sender, EventArgs e) => display.Text = EvaluateExpression(display.Text);

        public string GetOperand1(int indexOfOperator, string expression)
        {
            string operand1 = "";
            int i;
            for (i = indexOfOperator - 1; expression[i] != '+' && expression[i] != '-'; i--)
            {
                operand1 = operand1.Insert(0, expression[i].ToString());
            }

            operand1 = operand1.Insert(0, expression[i].ToString());

            return operand1;
        }

        public string GetOperand2(int indexOfOperator, string expression)
        {
            string operand2 = "";

            int i;
            for (i = indexOfOperator + 1; !new[] { '+', '-', 'x', '/' }.Contains(expression[i]); i++)
            {
                operand2 += expression[i];
                if (i == expression.Length - 1) break;
            }

            return operand2;
        }

        public string GetResultOfOperation(string operand1, char Operator, string operand2)
        {
            double operand1AsDouble = Convert.ToDouble(operand1);
            double operand2AsDouble = Convert.ToDouble(operand2);
            string result = "";
            switch (Operator)
            {
                case '/': result = (operand1AsDouble / operand2AsDouble).ToString(); break;
                case 'x': result = (operand1AsDouble * operand2AsDouble).ToString(); break;
                case '+': result = (operand1AsDouble + operand2AsDouble).ToString(); break;
                case '-': result = (operand1AsDouble - operand2AsDouble).ToString(); break;
                default: result = ""; break;
            }
            return (result[0] != '-') ? result.Insert(0, "+") : result;
        }

        public string EvaluateExpression(string expression) => EvaluateAdditionAndSubtraction(EvaluateDivisionAndMultiplication(expression));

        public string EvaluateDivisionAndMultiplication(string expression)
        {
            if (expression[0] != '+' && expression[0] != '-') expression = expression.Insert(0, "+");

            string result = "";
            bool hasDivide = (expression.IndexOf('/', 1) != -1);
            bool hasMultiply = (expression.IndexOf('x', 1) != -1);

            int indexOfDivide = expression.IndexOf('/', 1);
            int indexOfMultiply = expression.IndexOf('x', 1);
            while (hasDivide || hasMultiply)
            {
                char operatorToEvaluate;
                int indexOfOperatorToEvaluate;

                if (hasDivide && hasMultiply) indexOfOperatorToEvaluate = (indexOfDivide < indexOfMultiply) ? indexOfDivide : indexOfMultiply;
                else indexOfOperatorToEvaluate = hasDivide ? indexOfDivide : indexOfMultiply;

                operatorToEvaluate = expression[indexOfOperatorToEvaluate];

                string operand1 = GetOperand1(indexOfOperatorToEvaluate, expression);
                string operand2 = GetOperand2(indexOfOperatorToEvaluate, expression);
                string resultOfOperation = GetResultOfOperation(operand1, operatorToEvaluate, operand2);


                int operand1Start = indexOfOperatorToEvaluate - operand1.Length;
                int operand2End = indexOfOperatorToEvaluate + operand2.Length;

                // Remove the expression we just calculated, then insert in its' place the result
                expression = expression.Remove(operand1Start, operand2End - operand1Start + 1).Insert(operand1Start, resultOfOperation);


                hasDivide = (expression.IndexOf('/', 1) != -1);
                hasMultiply = (expression.IndexOf('x', 1) != -1);

                indexOfDivide = expression.IndexOf('/', 1);
                indexOfMultiply = expression.IndexOf('x', 1);
            }
            result = expression;

            return result;
        }

        public string EvaluateAdditionAndSubtraction(string expression)
        {
            if (expression[0] != '+' && expression[0] != '-') expression = expression.Insert(0, "+");

            string result = "";
            bool hasPlus = (expression.IndexOf('+', 1) != -1);
            bool hasMinus = (expression.IndexOf('-', 1) != -1);

            int indexOfPlus = expression.IndexOf('+', 1);
            int indexOfMinus = expression.IndexOf('-', 1);
            while (hasPlus || hasMinus)
            {
                char operatorToEvaluate;
                int indexOfOperatorToEvaluate;

                if (hasPlus && hasMinus) indexOfOperatorToEvaluate = (indexOfPlus < indexOfMinus) ? indexOfPlus : indexOfMinus;
                else indexOfOperatorToEvaluate = hasPlus ? indexOfPlus : indexOfMinus;

                operatorToEvaluate = expression[indexOfOperatorToEvaluate];

                string operand1 = GetOperand1(indexOfOperatorToEvaluate, expression);
                string operand2 = GetOperand2(indexOfOperatorToEvaluate, expression);
                string resultOfOperation = GetResultOfOperation(operand1, operatorToEvaluate, operand2);


                int operand1Start = indexOfOperatorToEvaluate - operand1.Length;
                int operand2End = indexOfOperatorToEvaluate + operand2.Length;

                // Remove the expression we just calculated, then insert in its' place the result
                expression = expression.Remove(operand1Start, operand2End - operand1Start + 1).Insert(operand1Start, resultOfOperation);


                hasPlus = (expression.IndexOf('+', 1) != -1);
                hasMinus = (expression.IndexOf('-', 1) != -1);

                indexOfPlus = expression.IndexOf('+', 1);
                indexOfMinus = expression.IndexOf('-', 1);
            }
            result = expression;

            return result;
        }

        private void DEL_Click(object sender, EventArgs e)
        {
            if (display.Text.Length > 0)
                display.Text = display.Text.Remove(display.Text.Length - 1, 1);

        }
    }
}
