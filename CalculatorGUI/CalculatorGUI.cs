using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorGUI
{
    public partial class CalculatorGUI : Form
    {
        Stack stack;
        Operators.Adder adder;
        Operators.Subtractor subtractor;
        Operators.Multiplier multiplier;
        Operators.Divider divider;
        Operators.ResultPresenter resultPresenter;
        Operand.Operand operand;
        public CalculatorGUI(Stack stack, Operators.Adder adder, Operators.Subtractor subtractor, Operators.Divider divider,
            Operators.Multiplier multiplier, Operators.ResultPresenter resultPresenter, Operand.Operand operand)
        {
            this.stack = stack;
            this.adder = adder;
            this.subtractor = subtractor;
            this.multiplier = multiplier;
            this.divider = divider;
            this.operand = operand;

            this.Text = "RPN Calculator";
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
        }

        private void numBox_TextChanged(object sender, EventArgs e)
        {}

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            this.operand.complete(stack);
        }
        private void buttonZero_Click(object sender, EventArgs e)
        {
            this.operand.addDigit(0);
        }

        private void buttonOne_Click(object sender, EventArgs e)
        {
            this.operand.addDigit(1);
        }

        private void buttonTwo_Click(object sender, EventArgs e)
        {
           this.operand.addDigit(2);
        }

        private void buttonThree_Click(object sender, EventArgs e)
        {
            this.operand.addDigit(3);
        }

        private void buttonFour_Click(object sender, EventArgs e)
        {
            this.operand.addDigit(4);
        }

        private void buttonFive_Click(object sender, EventArgs e)
        {
            this.operand.addDigit(5);
        }

        private void buttonSix_Click(object sender, EventArgs e)
        {
            this.operand.addDigit(6);
        }

        private void buttonSeven_Click(object sender, EventArgs e)
        {
            this.operand.addDigit(7);
        }

        private void buttonEight_Click(object sender, EventArgs e)
        {
            this.operand.addDigit(8);
        }

        private void buttonNine_Click(object sender, EventArgs e)
        {
            this.operand.addDigit(9);
        }
        private void buttonPlus_Click(object sender, EventArgs e)
        {
            this.adder.operate(stack);
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            this.subtractor.operate(stack);
        }

        private void buttonMul_Click(object sender, EventArgs e)
        {
            this.multiplier.operate(stack);
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            this.divider.operate(stack);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            this.operand.reset(stack);
        }
    }
}
