using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare variables
            String fullName = "Dan Ries";
            String location = "Portland, OR";
            DateTime today = DateTime.Now.Date;
            DateTime christmas = new DateTime(2018, 12, 25);

            // output
            Console.WriteLine("My name is " + fullName + " and I live in " + location + ".");
            Console.WriteLine("Today is " + DateTime.Today.ToShortDateString() + ".");
            Console.WriteLine("There are " + (christmas - today).TotalDays + " days until Christmas!");

            // program example
            // declare variables
            double width, height, woodLength, glassArea;
            string widthString, heightString;

            // prompt user for input and assign
            Console.WriteLine("Please enter width: ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);
            Console.WriteLine("Please enter height: ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            // calculate
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);

            // output
            Console.WriteLine("The length of the wood is " +
            woodLength + " feet");
            Console.WriteLine("The area of the glass is " +
            glassArea + " square metres");
            // end program
            Console.WriteLine("Press the any key to exit...");
            Console.ReadLine();
        }
    }
}
