using System;

namespace expression_mathematique
{
    public class OperandX : Node
    {
        public override void display(int level = 0)
        {
            Console.WriteLine(indent(level) + "Constante: x");
        }

        public override void derive()
        {
            throw new System.NotImplementedException();
        }
    }
}