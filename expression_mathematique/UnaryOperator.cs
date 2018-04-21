namespace expression_mathematique
{
    public abstract class UnaryOperator : Node
    {
        protected Node right;

        protected UnaryOperator(Node right)
        {
            this.right = right;
        }

    }
}