namespace learn;
using System;
class Program
{
    //Array problem - count number of positive, negitive and zeros and print their ratio in 6 decimal values 0.123456
    public static void plusMinusRatio(List<int> arr) 
    {
        decimal posRatio = 0M;
        decimal negRatio = 0M;
        decimal zerRatio = 0M;
        foreach(int n in arr)
        {
            //Console.WriteLine(n);
            if (n == 0)
                zerRatio++;
            else if (n > 0)
                posRatio++;
            else
              negRatio++;  
        }
        Console.WriteLine(string.Format("{0:N6}", posRatio/(decimal)arr.Count));
        Console.WriteLine(string.Format("{0:N6}", negRatio/(decimal)arr.Count));
        Console.WriteLine(string.Format("{0:N6}", zerRatio/(decimal)arr.Count));
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Length of array");
        int n = Convert.ToInt32 (Console.ReadLine().Trim());
        Console.WriteLine("Elements");
        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
        plusMinusRatio(arr);
    }
}
