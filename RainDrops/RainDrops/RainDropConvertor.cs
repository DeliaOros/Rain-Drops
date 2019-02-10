using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace RainDrops
{
    public class RainDropConvertor
    {
        private string convertedRainDrops;

        public string ConvertedRainDrops
        {
            get
            {
                return convertedRainDrops;
            }
        }

        public RainDropConvertor(int number)
        {
            convertedRainDrops = ConvertNumberRainDropRule(number);
        }

        private string ConvertNumberRainDropRule(int numberToConvert)
        {
            if (numberToConvert == 0)
            {
                return numberToConvert.ToString();
            }
            var result = "";
            var numbers = new Dictionary<int, string> { { 3, "Pling" }, { 5, "Plang" }, { 7, "Plong" } };
            foreach (KeyValuePair<int, string> item in numbers)
            {
                if (numberToConvert % item.Key == 0)
                {
                    result += item.Value;
                }
            }
            return result;
        }

        public override string ToString()
        {
            return $"Result: " + convertedRainDrops;
        }


    }
}
