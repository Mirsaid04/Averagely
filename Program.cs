namespace averagely 
{ 
    class Program 
    { 
        static void Main() 
        { 
            string yesOrno=(""); 
            do{
            Console.WriteLine("\n<---Hello , Welcome to our university---->\n");
            Console.WriteLine("Do you want to know your overall and average score?\n\n1.Overall\n2.Average\n ");
            Console.Write($"You should choose one of them {1} or {2} : ");

            int choosedNumber=int.Parse(Console.ReadLine()!);
            switch(choosedNumber)
            {
                case 1:
                    Console.Write("History: ");
                    double history=Convert.ToDouble(System.Console.ReadLine());

                    Console.Write("motherTongue: ");
                    double motherTongue=Convert.ToDouble(System.Console.ReadLine());

                    Console.Write("math: ");
                    double math=Convert.ToDouble(System.Console.ReadLine());

                    Console.Write("biology: ");
                    double biology=Convert.ToDouble(System.Console.ReadLine());

                    Console.Write("chemistry: ");
                    double chemistry=Convert.ToDouble(System.Console.ReadLine());
     
                    decimal result=Convert.ToDecimal(motherTongue+history+math+biology+chemistry);
                    Console.WriteLine("Your overall grade is " + result); 
                    Console.WriteLine(); 
                    Console.WriteLine(" --Thank you-- \n"); 
                    break;

                case 2 :
                    Console.Write("History: ");
                    double averageHistory=Convert.ToDouble(System.Console.ReadLine());

                    Console.Write("motherTongue: ");
                    double averageMotherTongue=Convert.ToDouble(System.Console.ReadLine());

                    Console.Write("math: ");
                    double averageMath=Convert.ToDouble(System.Console.ReadLine());

                    Console.Write("biology: ");
                    double averageBiology=Convert.ToDouble(System.Console.ReadLine());

                    Console.Write("chemistry: ");
                    double averageChemistry=Convert.ToDouble(System.Console.ReadLine());
     
                    decimal averageResult=Convert.ToDecimal(averageHistory+averageMotherTongue+averageMath+averageBiology+averageChemistry);
                    Console.WriteLine("Your average grade is " + averageResult/5); 
                    Console.WriteLine();
                    Console.WriteLine(" --Thank you-- \n");      
                    break;

                default :
                    Console.WriteLine("Sorry , you entered invalid input\n<---Try again later--->");
                    break;
            };
            Console.Write("Do you want to continue [y/n]: "); 
            yesOrno=Console.ReadLine()!; 
            }while(yesOrno=="y");
        } 
    } 
}