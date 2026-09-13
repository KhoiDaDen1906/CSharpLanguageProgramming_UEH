using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata.Ecma335;

internal class BTvonglap
{
    /// <summary>
    /// Write a program to check whether a triangle is Equilateral, Isosceles or Scalene.
    /// </summary>
    static void Ex1()
    {
        double a , b , c;
        bool thoa_man = false;
        do
        {
        System.Console.WriteLine("Nhập vào độ dài của cạnh thứ nhất: ");
         a = double.Parse(Console.ReadLine() ?? "1");
        System.Console.WriteLine("Nhập vào độ dài của cạnh thứ hai: ");
         b = double.Parse(Console.ReadLine() ?? "1");
        System.Console.WriteLine("Nhập vào độ dài của cạnh thứ ba: ");
         c = double.Parse(Console.ReadLine() ?? "1");
        
        thoa_man = (a + b > c && a + c > b && b + c > a );

        if (thoa_man == false)
            {
                System.Console.WriteLine(" 3 Cạnh bạn nhập chưa hợp lệ! Vui lòng nhập lại");
            }
        } while (thoa_man == false); // bắt người dùng nhập đến khi nào thoả mãn điều kiện là một tam giác thì ngưng.

        if (a == b && b == c)
        {
            System.Console.WriteLine("Tam giác này là tam giác đều");
        }
        else if ( a == b || b == c || a == c)
        {
                System.Console.WriteLine("Tam giác này là tam giác cân");
        }
        else if (Math.Pow(a,2) + Math.Pow(b,2) == Math.Pow(c,2) || Math.Pow(a,2) + Math.Pow(c,2) == Math.Pow(b,2) || Math.Pow(c,2) + Math.Pow(b,2) == Math.Pow(a,2))
        {
            System.Console.WriteLine("Tam giác này là tam giác vuông");
        }
        else System.Console.WriteLine("Tam giác này là tam giác bình thường");
    }
/// <summary>
/// Write a program to read 10 numbers and find their average and sum.
/// </summary>
/// <param name="args"></param>

    static void Ex2()
    {
        System.Console.WriteLine("Nhập số đầu tiên: ");
        double a = double.Parse(Console.ReadLine() ?? "1");
        System.Console.WriteLine("Nhập số thứ hai: ");
        double b = double.Parse(Console.ReadLine() ?? "1");
        System.Console.WriteLine("Nhập số thứ ba: ");
        double c = double.Parse(Console.ReadLine() ?? "1");
        System.Console.WriteLine("Nhập số thứ tư: ");
        double d = double.Parse(Console.ReadLine() ?? "1");
        System.Console.WriteLine("Nhập số thứ năm: ");
        double e = double.Parse(Console.ReadLine() ?? "1");
        System.Console.WriteLine("Nhập số thứ sáu: ");
        double f = double.Parse(Console.ReadLine() ?? "1");
        System.Console.WriteLine("Nhập số thứ bảy: ");
        double g = double.Parse(Console.ReadLine() ?? "1");
        System.Console.WriteLine("Nhập số thứ tám: ");
        double h = double.Parse(Console.ReadLine() ?? "1");
        System.Console.WriteLine("Nhập số thứ chín: ");
        double i = double.Parse(Console.ReadLine() ?? "1");
        System.Console.WriteLine("Nhập số thứ mười: ");
        double j = double.Parse(Console.ReadLine() ?? "1");
        double sum = a+b+c+d+e+f+g+h+i+j;
        double average = sum/10;

        System.Console.WriteLine($"Tổng của 10 số là: {sum}");
        System.Console.WriteLine($"Trung bình của 10 số là: {average}");
    }
    /// <summary>
    /// Write a program to display the multiplication table of a given integer.
    /// </summary>
    /// <param name="args"></param>
    static void Ex3()
    {
        for (int i = 1 ; i <= 10; i ++ )
       { 
            for (int j = 1; j <=9; j ++)
            {
                System.Console.Write($"{j} x {i,2} = {i*j,2}     |     "); // {i,2} giúp căn lề qua phải 2 khoảng trống, muốn căn lề trái thì -2
            }
            System.Console.WriteLine();
       }
    }
    /// <summary>
    /// Write a program to display a pattern like triangles with a number.
    /// </summary>
    /// <param name="args"></param>
    static void Ex4_and_5()
    {   // Pic1
        for (int i = 1; i <= 4; i++)
        {
           for (int j = 1; j <= i ; j++)
            {
                System.Console.Write($"{j} ");
            } 
            System.Console.WriteLine();
        }
        System.Console.WriteLine();
        //Pic2 
        int count = 1;
        for (int i = 1; i <= 4; i++)
        {
           for (int j = 1; j <= i ; j++)
            {
                System.Console.Write($"{count} ");
                count ++;
            } 
            System.Console.WriteLine();
            
        }
        System.Console.WriteLine();
        // Pic3
        int count_2 = 1;
        for (int i = 1; i <= 4; i++)
        {
            for (int n = 1 ; n <= 4-i; n ++ )
            {
                System.Console.Write(" ");
            }
           for (int j = 1; j <= i ; j++)
            {
                System.Console.Write($"{count_2} ");
                count_2 ++;
            } 
            System.Console.WriteLine();
        }
    }
    /// <summary>
    /// Write a program to display the n terms of harmonic series and their
    /// sum. 1 + 1/2 + 1/3 + 1/4 + 1/5 ... 1/n terms
    /// </summary>
    /// <param name="args"></param>
    static void Ex6()
    {
        System.Console.WriteLine("Enter the length of the series you want: ");
        int n = int.Parse(Console.ReadLine() ?? "5");

        if (n <= 0)
        {
            System.Console.WriteLine("Error! Please try again (the length must be larger than 1):  ");
            return;
        } 
            System.Console.Write($"1");
            double sum = 1.0; 
        for (int i = 2; i <= n; i ++)
        {
            System.Console.Write($" + 1/{i}");
            sum += 1.0/i;
        }
        System.Console.Write($" = {sum}");
        System.Console.WriteLine();
    }
    /// <summary>
    /// Write a program to find the ‘perfect’ numbers within a given number range.
    /// </summary>
    /// <param name="args"></param>
    static void Ex7()
    {
        System.Console.WriteLine("Enter the range to check perfect number ");
        System.Console.WriteLine("Start at: ");
        int a = int.Parse(Console.ReadLine() ?? "1");
        System.Console.WriteLine("End at: ");
        int b = int.Parse(Console.ReadLine() ?? "10000"); 
        
        System.Console.WriteLine();
        int count = 0;
        
        for (int n = a; n <= b ; n ++ )
        { 
            int sum = 0;
            for (int m = 1; m <= n/2; m ++)
            {
                if (n % m ==0)
                {
                    sum += m;
                }
            }    
                if (sum == n)
                {
                    System.Console.Write(n + " ");
                    count ++;
                }
        }
        System.Console.WriteLine();
        System.Console.WriteLine($"This range has {count} perfect numbers");
        
    } 
    /// <summary>
    /// Write a program to determine whether a given number is prime or not.
    /// </summary>
    /// <param name="args"></param>
    static void Ex8()
    {
        System.Console.WriteLine("Enter a number: ");
        int num = int.Parse(Console.ReadLine() ?? "5");
        bool prime = true;
        
        if (num < 2)
        {
            prime = false;
        }
        else
        {
            for (int m = 2; m <= num - 1; m ++)
            {
                if (num % m == 0)
                {
                    prime = false;
                    break;
                }
            }
        }
        if (prime)
        {
            System.Console.WriteLine($"{num} is prime number");
        }
        else System.Console.WriteLine($"{num} is not prime number");
    }    
    private static void Main1234(string[] args)
    {
        // Ex1();
        // Console.WriteLine("Press any button to move to the next Ex: ");
        // Console.ReadKey();

        // Ex2();
        // Console.WriteLine("Press any button to move to the next Ex: ");
        // Console.ReadKey();

        // Ex3();
        // Console.WriteLine("Press any button to move to the next Ex: ");
        // Console.ReadKey();

        // Ex4_and_5();
        // Console.WriteLine("Press any button to move to the next Ex: ");
        // Console.ReadKey();

        // Ex6();
        // Console.WriteLine("Press any button to move to the next Ex: ");
        // Console.ReadKey();

        // Ex7();
        // Console.WriteLine("Press any button to move to the next Ex: ");
        // Console.ReadKey();

        Ex8();
        Console.WriteLine("Press any button to move to the next Ex: ");
        Console.ReadKey();


    }
}