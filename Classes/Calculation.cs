using averagely.Interfaces;

namespace averagely.Classes;

public class Calculation:ICalculation
{
    public  decimal OverallCalculation()
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
    public decimal AverageCalculation()
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
}