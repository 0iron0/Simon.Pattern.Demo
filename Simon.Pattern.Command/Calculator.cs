using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Simon.Pattern.Command
{
    public class User
    {
        private Calculator mCalculator = new Calculator();
        private ArrayList mCommands = new ArrayList();
        private int mCurrent = 0;

        public void Redo(int level)
        {
            for (int i = 0; i < level; i++)
            {
                if (this.mCurrent < this.mCommands.Count - 1)
                {
                    Command cmd = this.mCommands[this.mCurrent++] as Command;
                    cmd.Execute();
                }
            }
        }

        public void Undo(int level)
        {
            for (int i = 0; i < level; i++)
            {
                if (this.mCurrent > 0)
                {
                    Command cmd = this.mCommands[--this.mCurrent] as Command;
                    cmd.UnExecute();
                }
            }
        }

        public void Compute(char @operator, int operand)
        {
            Command cmd = new CalculateCommand(@operator, operand, this.mCalculator);
            cmd.Execute();
            this.mCommands.Add(cmd);
            this.mCurrent++;
        }
    }

    public class Calculator
    {
        private int mValue = 0;

        public void Operation(char @operator, int operand)
        {
            switch (@operator)
            {
                case '+': this.mValue += operand; break;
                case '-': this.mValue -= operand; break;
                case '*': this.mValue *= operand; break;
                case '/': this.mValue /= operand; break;
                default:
                    throw new ArgumentException("@operator");
            }
            Console.WriteLine("current value is {0, 3}(following {1} {2})",
                mValue,
                @operator,
                operand);
        }
    }

    public abstract class Command
    {
        public abstract void Execute();
        public abstract void UnExecute();
    }

    public class CalculateCommand : Command
    {
        private char @operator;
        private int mOperand;
        private Calculator mCalculator;

        public CalculateCommand(char @operator, int operand, Calculator calculator)
        {
            this.@operator = @operator;
            this.mOperand = operand;
            this.mCalculator = calculator;
        }

        public override void Execute()
        {
            this.mCalculator.Operation(this.@operator, this.mOperand);
        }

        public override void UnExecute()
        {
            this.mCalculator.Operation(Undo(@operator), this.mOperand);
        }

        private char Undo(char @operator)
        {
            char undo;
            switch (@operator)
            {
                case '+': undo = '-'; break;
                case '-': undo = '+'; break;
                case '*': undo = '/'; break;
                case '/': undo = '*'; break;
                default: undo = ' '; break;
            }
            return undo;
        }
    }
}
