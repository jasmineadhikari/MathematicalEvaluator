// See https://aka.ms/new-console-template for more information

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the expression:");
        string expression = Console.ReadLine();
        
        try
        {
            double result = EvaluateExpression(expression);
            Console.WriteLine($"Result: {result}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    static double EvaluateExpression(string expression)
    {
        var dataTable = new System.Data.DataTable();
        return Convert.ToDouble(dataTable.Compute(expression, string.Empty));
    }
}
