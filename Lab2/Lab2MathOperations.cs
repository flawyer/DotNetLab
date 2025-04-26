using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstVB
{
     public class MathOperations
    {
        public int Add(int a,int b)
        {
            return a + b;
        }
        public double Add(double a,double b)
        {
            return a + b;
        }
        public int Multiply(int a,int b)
        {
            return a + b;
        }
        public double Multiply(double a , double b)
        {
            return a + b;
        }
        public double Division(double a,double b)
        {
            return a / b;
        }

    }
    
      interface IAddition
        {
            double Add(double a, double b);
        }
        interface ISubstraction
        {
            double Substract(double a, double b);
        }
        interface IMultiplication
        {
            double Multiply(double a, double b);
        }
        interface IDivison
        {
            double Multiply(double a, double b);
        }
        public class CallInterface : IAddition, ISubstraction, IMultiplication, IDivison
        {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public double Add(double a, double b)
        {
            return a + b;
        }
        public double Substract(double a,double b)
        {
            return a - b;
        }
    
        public double Multiply(double a, double b)
        {
            return a * b;
        }
        public double Division(double a, double b)
        {
            try { 
            return a / b;
            }
            catch (Exception e)
            {
                return 0;
            }
        }
    }
      

    

  
}
