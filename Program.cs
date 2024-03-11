class Program
{
    static void Main(string[] args)
    {
        const int basicSalary = 200;
        int[] salaryRanges = new int[9]; //{0,0,0,0,0,0,0,0,0}
        int[] grossSales = { 500, 2000, 5000, 4500, 6000, 8000, 7000, 10000 };
        int finalSalary = 0;

        foreach (int item in grossSales)
        {
            finalSalary = (int)(0.09 * item) + basicSalary;

            if (finalSalary >= 200 && finalSalary <= 299)
            {
                salaryRanges[0]++;
            }
            else if (finalSalary >= 300 && finalSalary <= 399)
            {
                salaryRanges[1]++;
            }
            else if (finalSalary >= 400 && finalSalary <= 499)
            {
                salaryRanges[2]++;
            }
            else if (finalSalary >= 500 && finalSalary <= 599)
            {
                salaryRanges[3]++;
            }
            else if (finalSalary >= 600 && finalSalary <= 699)
            {
                salaryRanges[4]++;
            }
            else if (finalSalary >= 700 && finalSalary <= 799)
            {
                salaryRanges[5]++;
            }
            else if (finalSalary >= 800 && finalSalary <= 899)
            {
                salaryRanges[6]++;
            }
            else if (finalSalary >= 900 && finalSalary <= 999)
            {
                salaryRanges[7]++;
            }
            else
            {
                salaryRanges[8]++;
            }
        }

        Console.WriteLine("Salary Range       Number of Sales Person");
        Console.WriteLine($"200-299             {salaryRanges[0]}");
        Console.WriteLine($"300-399             {salaryRanges[1]}");
        Console.WriteLine($"400-499             {salaryRanges[2]}");
        Console.WriteLine($"500-599             {salaryRanges[3]}");
        Console.WriteLine($"600-699             {salaryRanges[4]}");
        Console.WriteLine($"700-799             {salaryRanges[5]}");
        Console.WriteLine($"800-899             {salaryRanges[6]}");
        Console.WriteLine($"900-999             {salaryRanges[7]}");
        Console.WriteLine($"1000 and above      {salaryRanges[8]}");
    }
}