using averagely.Classes;
using averagely.Interfaces;

namespace averagely 
{ 
    class Program 
    { 
        static void Main() 
        { 
            try
            {
                var yesOrNo = ("");
            do
            {
                ICalculation calculateR = new Calculation();
                IReporter reporteR = new Reporter();
                reporteR.ShowMenu();
                int option = int.Parse(Console.ReadLine()!);
            switch(option)
            {
                case 1:
                    calculateR.OverallCalculation();
                    reporteR.ShowGratitude();
                    break;
                
                case 2 :
                    calculateR.AverageCalculation();
                    reporteR.ShowGratitude();
                    break;
                
                default :
                    reporteR.ReportLastInfo();
                    break;
            };
            Console.Write("Do you want to continue [y/n]: "); 
            yesOrNo=Console.ReadLine()!; 
            }while(yesOrNo=="y");
            }
            
            catch(FormatException FormatException)
            {
                Console.WriteLine("Opps,We could not convert your input value.");
                Console.WriteLine("Look like the value you provided is not integer.");
            }
            catch(OverflowException OverflowException)
            {
                Console.WriteLine("Value you provided was either too large or too small. ");
            }
            catch(Exception exception)
            {
                Console.WriteLine("Opps,something went wrong , contact support");
            }
        }
    } 
}