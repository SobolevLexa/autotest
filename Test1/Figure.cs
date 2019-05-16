namespace Test1
{
    public abstract class Figure
    {
        public double Area { get; protected set; } = 0;

        public override string ToString()
        {
            return Area.ToString();
        }
    }
}