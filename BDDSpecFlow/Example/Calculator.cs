namespace BDDSpecFlow.Example
{
    public class Calculator
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }

        public int Sum()
        {
            return FirstNumber + SecondNumber;
        }

        public int Subtraction()
        {
            return FirstNumber - SecondNumber;
        }
    }
}
