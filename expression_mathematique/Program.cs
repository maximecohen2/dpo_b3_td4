using System;

namespace expression_mathematique
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            // f(x) = (2 - x) * (x + 2)
            Node node =
                new OperatorMult(
                    new OperatorSub(
                        new OperandConstant(2), new OperandX()),
                    new OperatorAdd(
                        new OperandX(), new OperandConstant(2)));
            
            node.display();
        }
    }
}