namespace expression_mathematique
{
    public abstract class BinaryOperator : UnaryOperator
    {
        protected Node left;
        
        public BinaryOperator(Node right, Node left) : base(right)
        {
            this.left = left;
        }
    }
}