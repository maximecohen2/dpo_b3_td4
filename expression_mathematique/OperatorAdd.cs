using System;

namespace expression_mathematique
{
    public class OperatorAdd : BinaryOperator
    {
        public OperatorAdd(Node right, Node left) : base(right, left)
        {
        }

        public override void display(int level = 0)
        {
            Console.WriteLine(indent(level) + "Opérateur: +");
            right.display(level + 1);
            left.display(level + 1);
        }

        public override void derive()
        {
            throw new System.NotImplementedException();
        }
    }
}