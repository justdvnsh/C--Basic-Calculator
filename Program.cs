using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            try {
                inputConverter inputConverter = new inputConverter();
            calculatorEngine calculatorEngine = new calculatorEngine();

            double firstNumber = inputConverter.toInt(Console.ReadLine());
            double secondNumber = inputConverter.toInt(Console.ReadLine());
            string operation = Console.ReadLine();

            double result = calculatorEngine.Calculate(operation, firstNumber, secondNumber);

            Console.WriteLine(result);
            } catch ( Exception ex ) {
                Console.WriteLine(ex.Message);
            } 
        }
    }
}
