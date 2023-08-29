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
                ShowMenu();
                int option = int.Parse(Console.ReadLine()!);
            switch(option)
            {
                case 1:
                    OverallCalculation();
                    Report();
                    break;
                
                case 2 :
                    AverageCalculation();
                    Report();
                    break;
                
                default :
                    ReportLastInfo();
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

        private static void ShowMenu()
        {
            Console.WriteLine("\n<---Hello , Welcome to our university---->\n");
            Console.WriteLine("Do you want to know your overall and average score?\n\n1.Overall\n2.Average\n ");
            Console.Write($"You should choose one of them {'1'} or {'2'} : ");
        }

        private  static decimal OverallCalculation()
        {
            Console.Write("History: ");
            decimal history=Convert.ToDecimal(Console.ReadLine());

            Console.Write("motherTongue: ");
            decimal motherTongue=Convert.ToDecimal(Console.ReadLine());

            Console.Write("math: ");
            decimal math=Convert.ToDecimal(Console.ReadLine());

            Console.Write("biology: ");
            decimal biology=Convert.ToDecimal(Console.ReadLine());

            Console.Write("chemistry: ");
            decimal chemistry=Convert.ToDecimal(Console.ReadLine());
            
            decimal result=Convert.ToDecimal(motherTongue+history+math+biology+chemistry);
            Console.WriteLine("Your overall grade is " + result);
            Console.WriteLine();
            return result;
        }

        private static decimal AverageCalculation()
        {
            Console.Write("History: ");
            double averageHistory=Convert.ToDouble(Console.ReadLine());

            Console.Write("motherTongue: ");
            double averageMotherTongue=Convert.ToDouble(Console.ReadLine());

            Console.Write("math: ");
            double averageMath=Convert.ToDouble(Console.ReadLine());

            Console.Write("biology: ");
            double averageBiology=Convert.ToDouble(Console.ReadLine());

            Console.Write("chemistry: ");
            double averageChemistry=Convert.ToDouble(Console.ReadLine());
     
            decimal averageResult=Convert.ToDecimal(averageHistory+averageMotherTongue+averageMath+averageBiology+averageChemistry);
            Console.WriteLine("Your average grade is " + averageResult/5); 
            Console.WriteLine();
            return averageResult;
        }
        private static void Report()
        {
                Console.WriteLine(" --Thank you-- \n"); 
        }

        private static void ReportLastInfo()
        {
            Console.WriteLine("Sorry , you entered invalid input\n<---Try again later--->");
        }

    } 
}