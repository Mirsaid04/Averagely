namespace averagely 
{ 
    class Program 
    { 
        static void Main() 
        { 
            Console.WriteLine("\n<---Hello , Welcome to our university---->\n");
            Console.WriteLine("Do you want to know your overall or average score?\n\n1.Overall\n2.Average\n ");
            Console.Write($"You should choose one of them {1} or {2} : ");

            int choosedNumber=int.Parse(Console.ReadLine()!);

            if(choosedNumber==1)
            {
            Console.Write("History: ");
            double history=Convert.ToDouble(System.Console.ReadLine());

            System.Console.Write("motherTongue: ");
            double motherTongue=Convert.ToDouble(System.Console.ReadLine());

            System.Console.Write("math: ");
            double math=Convert.ToDouble(System.Console.ReadLine());

            System.Console.Write("biology: ");
            double biology=Convert.ToDouble(System.Console.ReadLine());

            System.Console.Write("chemistry: ");
            double chemistry=Convert.ToDouble(System.Console.ReadLine());
     
           decimal result=Convert.ToDecimal(motherTongue+history+math+biology+chemistry);
            System.Console.WriteLine("Your overall grade is " + result); 
            System.Console.WriteLine(); 
            System.Console.WriteLine("/\\ --Thank you-- /\\\n"); 
            }
            else if (choosedNumber==2)
            {
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
            Console.WriteLine("Your average grade is " + result/5); 
            Console.WriteLine();
            Console.WriteLine("/\\ --Thank you-- /\\\n"); 

            }
            else 
            {
            Console.WriteLine("Sorry , you entered invalid input\n<---Try again later--->");
            }
        } 
    } 
}