using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/************
 * @author:pineda, rm
 * ********
 * ******
 *********
 */
namespace CalculatorApplication
{

    //generic delegate
    public delegate Tresult Formula<T1, T2, Tresult>(T1 arg1, T2 arg2);
    public class CalculatorClass
    {

        //declare generic delegate variable
        public Formula<double, double, double>? formula;
        
        
        public double GetSum(double x, double y)
        {
            return x + y;
        }

        public double GetDifference(double x, double y)
        {
            return x - y;
        }

        public double GetProduct(double x, double y)
        {
            return x * y;
        }

        public double GetQuotient(double x, double y)
        {
            return x / y;
        }



        private Formula<double, double, double>? _calculateEvent;


        //EVENT ACCESSOR
        public event Formula<double, double, double> CalculateEvent
        {
            add
            {
                _calculateEvent += value;
                Console.WriteLine("Added the delegate");
                
            }
            remove
            {
                _calculateEvent -= value;
                Console.WriteLine("Removed the Delegate");
                
            }


        }
        public double TriggerCalculation(double x, double y)
        {
            return _calculateEvent?.Invoke(x, y) ?? 0;
        }




        

    }//end of class CalculatorClass


}//end of namespace CalculatorApplication

/*****
*** @author: pineda, rm
****
*****
*/