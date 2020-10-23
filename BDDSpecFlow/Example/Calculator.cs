namespace BDDSpecFlow.Example
{
    public class Calculator
    {
        public int FirstNumber { get; set; }

        public int SecondNumber { get; set; }

        public int Soma()
        {
            return FirstNumber + SecondNumber;
        }

        public int Subtracao()
        {
            return FirstNumber - SecondNumber;
        }
    }
}
