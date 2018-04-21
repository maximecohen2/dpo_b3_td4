namespace expression_mathematique
{
    public abstract class Node
    {
        public abstract void display(int level = 0);

        public abstract void derive();

        protected string indent(int level)
        {
            string str = "";
            
            for (int i = 0; i < level; i++)
            {
                str += "    ";
            }

            return str;
        }
    }
}