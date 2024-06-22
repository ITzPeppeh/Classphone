using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classphone
{
    class CalculatorClass
    {
        //private List<double> CalculatorList = new List<double>();
        private double result;
        private string LastSign = "";

        public CalculatorClass()
        {
            result = 0;
        }

        public double GetResult()
        {
            double res = result;
            result = 0;
            LastSign = "";
            return res;
        }


        public void SetNumber(double num, string sign)                                  //Aggiunge il numero passato per parametro al risultato
        {
            if (LastSign == "")
            {
                if (sign == "sqrt")
                {
                    result = Math.Sqrt(num);
                }
                else
                {
                    result = num;
                    LastSign = sign;
                }
            }
            else
            {
                switch (LastSign)
                {
                    case "+":
                        result += num;
                        break;
                    case "-":
                        result -= num;
                        break;
                    case "*":
                        result *= num;
                        break;
                    case "/":
                        result /= num;
                        break;
                }
                if(sign == "sqrt")
                    result = Math.Sqrt(result);
                else
                    LastSign = sign;
            }

        }

        public void Clear()
        {
            result = 0;
            LastSign = "";
        }

    }
}
