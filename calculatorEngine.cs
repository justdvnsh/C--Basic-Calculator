using System;

namespace calculator
{
    public class calculatorEngine
    {
        public double Calculate(string operation, double argFirstNumber, double argSecondNumber) {
            double result;
            switch(operation.ToLower()){
                case "add":
                case "+":
                    result = argFirstNumber + argSecondNumber;
                    break;
                case "sub":
                case "-":
                    result = argFirstNumber - argSecondNumber;
                    break;
                case "multiply":
                case "*":
                    result = argFirstNumber * argSecondNumber;
                    break;
                case "divide":
                case "/":
                    result = argFirstNumber / argSecondNumber;
                    break;
                default:
                throw new InvalidOperationException();
            }

            return result;
        }
    }
}
