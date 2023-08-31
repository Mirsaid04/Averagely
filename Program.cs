using averagely.Classes;

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
                Calculation calculate = new Calculation();
                Reporter reporter = new Reporter();
                reporter.ShowMenu();
                int option = int.Parse(Console.ReadLine()!);
            switch(option)
            {
                case 1:
                    calculate.OverallCalculation();
                    reporter.ShowGratitude();
                    break;
                
                case 2 :
                    calculate.AverageCalculation();
                    reporter.ShowGratitude();
                    break;
                
                default :
                    reporter.ReportLastInfo();
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