using System;

namespace expression_mathematique
{
    public class OperandConstant : Node
    {
        private readonly int value;

        public OperandConstant(int value)
        {
            this.value = value;
        }

        public override void display(int level = 0)
        {
            Console.WriteLine(indent(level) + "Constante: " + value);
        }

        public override void derive()
        {
            throw new System.NotImplementedException();
        }
    }
}