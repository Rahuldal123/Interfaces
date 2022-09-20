using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    public interface Iorder
    {
        string DisplayDetails();
    }
    public interface Icustomer
    {
        string DisplayDetails();
    }
    public class Transaction : Iorder, Icustomer
    {
        string Iorder.DisplayDetails()
        {
            return $"order details";
        }

        string Icustomer.DisplayDetails()
        {
            return $"customer details";
        }
    



        static void Main(string[] args)
           {

            Iorder o1 = new Transaction();
            
            Console.WriteLine(o1.DisplayDetails());

            Icustomer c1 = new Transaction();
            Console.WriteLine(c1.DisplayDetails());

          
        }
    }
}
