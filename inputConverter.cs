using System;

namespace calculator
{
    public class inputConverter
    {
        public double toInt(string inputText) {
            double convertedNumber;
            if ( !double.TryParse(inputText, out convertedNumber) ) throw new Exception(" Expected a numeric value ! ");
            return convertedNumber;
        }
    }
}
