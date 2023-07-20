namespace averagely 
{ 
    class Program 
    { 
        static void Main() 
        { 
            System.Console.WriteLine("\nWelcome to my calculation project\n"); 
            System.Console.WriteLine("First, please enter that how many grades you have got"); 
 
            System.Console.Write("History: ");
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
            System.Console.WriteLine("Your average grade is " + result/5); 
            System.Console.WriteLine(); 
        } 
    } 
}