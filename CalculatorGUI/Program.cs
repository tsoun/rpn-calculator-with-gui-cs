using System;
using System.Collections;
using System.Windows.Forms;

namespace Calculator
{
    class MainApp
    {
        public static Stack stack;
        static Operators.Adder adder;
        static Operators.Subtractor subtractor;
        static Operators.Multiplier multiplier;
        static Operators.Divider divider;
        static Operators.ResultPresenter resultPresenter;
        static Operand.Operand operand;
        public static CalculatorGUI.CalculatorGUI calc;

        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            stack = new Stack();
            adder = new Operators.Adder();
            subtractor = new Operators.Subtractor();
            multiplier = new Operators.Multiplier();
            divider = new Operators.Divider();
            resultPresenter = new Operators.ResultPresenter();
            operand = new Operand.Operand();
            calc = new CalculatorGUI.CalculatorGUI(stack, adder, subtractor, divider, multiplier, resultPresenter, operand);

            Application.Run(calc);
        }

    }
}

namespace Operators
{
    interface Operator
    {
        void operate(Stack stack);
    }

    public class Adder : Operator
    {
        public void operate(Stack stack)
        {
            try
            {
                int d1 = (int)stack.Pop();
                int d2 = (int)stack.Pop();
                int d3 = d1 + d2;

                stack.Push(d3);
                Calculator.MainApp.calc.numBox.Text += " + => " + d3.ToString();
            }
            catch
            {
                Console.WriteLine("Empty or with one element list.");
            }
        }
    }
    public class Subtractor : Operator
    {
        public void operate(Stack stack)
        {
            try
            {
                int d1 = (int)stack.Pop();
                int d2 = (int)stack.Pop();
                int d3 = d2 - d1;

                stack.Push(d3);
                Calculator.MainApp.calc.numBox.Text += " - => " + d3.ToString();
            }
            catch
            {
                Console.WriteLine("Empty or with one element list.");
            }
        }

    }
    public class Multiplier : Operator
    {
        public void operate(Stack stack)
        {
            try
            {
                int d1 = (int)stack.Pop();
                int d2 = (int)stack.Pop();
                int d3 = d1 * d2;

                stack.Push(d3);
                Calculator.MainApp.calc.numBox.Text += " * => " + d3.ToString();
            }
            catch
            {
                Console.WriteLine("Empty or with one element list.");
            }
        }

    }
    public class Divider : Operator
    {
        public void operate(Stack stack)
        {
            try
            {
                int d1 = (int)stack.Pop();
                int d2 = (int)stack.Pop();
                int d3 = d2 / d1;

                stack.Push(d3);
                Calculator.MainApp.calc.numBox.Text += " / => " + d3.ToString();
            }
            catch
            {
                Console.WriteLine("Empty or with one element list.");
            }
        }

    }

    public class ResultPresenter : Operator
    {
        public void operate(Stack stack)
        {
            try
            {
                int d1 = (int)stack.Pop();
                Calculator.MainApp.calc.numBox.Text += " " + d1.ToString();
            }
            catch
            {
                Console.WriteLine("Empty or with one element list.");
            }
        }
    }
}

namespace Operand
{
    public class Operand
    {
        private int val = 0;
        public void addDigit(int i)
        {
            val = val * 10 + i;
        }
        public void complete(Stack stack)
        {
            stack.Push(val);
            Calculator.MainApp.calc.numBox.Text += " " + val.ToString();
            val = 0;
        }
        public void reset(Stack stack)
        {
            stack = new Stack();
            val = 0;
            Calculator.MainApp.calc.numBox.Text = val.ToString();
        }
    }
}