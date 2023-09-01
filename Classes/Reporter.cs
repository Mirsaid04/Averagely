using averagely.Interfaces;

namespace averagely.Classes;

public class Reporter : IReporter
{
    public void ShowMenu()
    {
        Console.WriteLine("\n<---Hello , Welcome to our university---->\n");
        Console.WriteLine("Do you want to know your overall and average score?\n\n1.Overall\n2.Average\n ");
        Console.Write($"You should choose one of them {'1'} or {'2'} : ");
    }
    public void ShowGratitude()
    {
        Console.WriteLine(" --Thank you-- \n"); 
    }
    public void ReportLastInfo()
    {
        Console.WriteLine("Sorry , you entered invalid input\n<---Try again later--->");
    }
}