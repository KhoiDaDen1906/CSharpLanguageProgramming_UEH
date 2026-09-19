using System.ComponentModel.DataAnnotations;

internal class Functions_Methods_Ex
{
    /// <summary>
    /// Write a C# function to find the maximum of three numbers.
    ///- Improve the next version that accept at least 1 parameter
    /// </summary>
    /// <param name="args"></param>
    private static int Find_max_of_3num(int a, int b , int c)
    {
        int max = a;
        if (b > max) max = b;
        if (c > max) max = c;
        return max;
    }
    private static int Find_max_of_n_num(int first_num, params int[] list_num)
    {
        int max = first_num;
        foreach (int num in list_num)
        {
            if (num > max) max = num;
        }
        return max;
    }
    private static void Ex1()
    {
        // Normal version.
        System.Console.WriteLine("Enter the first number: ");
        int a = int.Parse(Console.ReadLine() ?? "1");
        System.Console.WriteLine("Enter the second number: ");
        int b = int.Parse(Console.ReadLine() ?? "2");
        System.Console.WriteLine("Enter the third number: ");
        int c = int.Parse(Console.ReadLine() ?? "3");

        int max_of_3 = Find_max_of_3num(a,b,c);
        Console.WriteLine($"The maximum number is {max_of_3}");

        // Improved Version.
        System.Console.Write("About the Improved Version: ");
        int max_of_n = Find_max_of_n_num(23,45,67,87,12,2,3,4,5,6,7,8,9,1,234,654);
        System.Console.WriteLine($"The aximum number is {max_of_n}");
    }

    /// <summary>
    /// Write a C# function to calculate the factorial of a number (a non-negative
    /// integer). The function accepts the number as an argument.
    /// </summary>
    /// <param name="args"></param>
    static int Calculate_Factorial(int n)
    {
        int result = 1; 
        for (int i = 2 ; i <= n; i ++ )
        {
            result *= i;
        }
        return (result);
    }
    static void Ex2()
    {
        System.Console.WriteLine("Enter a number to calculate factorial: ");
        int num = int.Parse(Console.ReadLine() ?? "5");

        int calc_factorial = Calculate_Factorial(num);
        // Vòng lặp để in ra biểu thức của chuỗi:
        for (int i = 1 ; i <= num ; i ++)
        {
            System.Console.Write(i);

            if (i < num)
            {
                System.Console.Write("x");
            }
        }
        System.Console.WriteLine($" = {num}! = {calc_factorial} ");
    }
    /// <summary>
    /// Write a C# function that takes a number as a parameter and checks whether
    /// the number is prime or not.
    /// </summary>
    static bool Prime_num(int n)
    {
        if (n < 2)
        {
            return false;
        }
        for (int i = 2 ; i <= n/2 ; i++)
        {
            if (n % i == 0)
            {
                return false;
            }
        }
        return true;
    }
    static void Ex3()
    {
        System.Console.WriteLine("Enter a number: ");
        int num = int.Parse(Console.ReadLine() ?? "1");

        bool prime_num = Prime_num(num);

        if (prime_num == true)
        {
            System.Console.WriteLine($"{num} is Prime number!");
        }
        else System.Console.WriteLine($"{num} is not Prime number!");
    }
    /// <summary>
    /// Write a C# function to print
    /// 1. all prime numbers that less than a number (enter prompt keyboard).
    /// 2. the first N prime numbers
    /// </summary>
    /// <param name="args"></param>
    static void Ex4_1_Pnumber_lessthan_anum()
    {
        System.Console.Write("Enter the length of the range to check how many prime numbers in there:  ");
        int n = int.Parse(Console.ReadLine() ?? "10");
        int count = 0; 
        for ( int i = 2 ; i < n ; i ++)
        {
            if (Prime_num(i))
            {   
                count ++;
                System.Console.Write(i);
                System.Console.WriteLine();
            }
        }
        System.Console.WriteLine($"There are {count} Prime numbers in the range! ");
    }

    static void Ex4_2_Print_first_N_Pnum()
    {
        System.Console.Write("Enter how many numbers of Prime number: ");
        int N = int.Parse(Console.ReadLine() ?? "5");

        int count = 0;
        int current_number = 2;

        while(count < N)
        {
            if (Prime_num(current_number))
            {
                System.Console.WriteLine(current_number);
                count ++;
            }
            current_number ++;
        }
        System.Console.WriteLine();


        
    }
    /// <summary>
    /// Write a C# function to check whether a number is "Perfect" or not. Then print
    /// all perfect number that less than 1000.
    /// </summary>
    /// <param name="args"></param>
    static bool Perfect_number(int n)
    {
        if (n < 6)
        {
            return false;
        }
        int sum = 0;
        for (int i = 1 ; i <= n/2 ; i ++)
        {
            if (n % i == 0)
            {
                sum += i;
            }
        }
        return sum == n;
    }
    static void Ex5()
    {
        System.Console.WriteLine("All the perfect numbers less than 1000 are: ");

        for (int i = 1 ; i < 1000 ; i ++)
        {
            if (Perfect_number(i))
            {
                System.Console.WriteLine(i + " ");
            }
        }
        System.Console.WriteLine();
    }
    /// <summary>
    /// Write a C# function to check whether a string is a pangram or not.
    /// </summary>
    /// <param name="args"></param>
    static bool Pangram_check(string text)
    {
        string text_lower = text.ToLower();

        for (char letter = 'a'; letter <= 'z' ; letter ++)
        {
            if (text_lower.Contains(letter) == false)
            {
                return false;
            }
        }
        return true;
    }
    static void Ex6()
    {
        while(true) // Tạo vòng lặp cho người dùng nhập đến khi nào chán thì thoát.
        {
        System.Console.WriteLine("Enter a string (or type 'no' to exit the program): ");
        string chuoi_ky_tu = Console.ReadLine() ?? " ";

        if(chuoi_ky_tu.ToLower() == "no")
            {
                System.Console.WriteLine("Goodbye! Thanks for enjoying the program!");
                break;
            } 
        else if (Pangram_check(chuoi_ky_tu))
            {
                System.Console.WriteLine("This string is a Pangram!");
            }
        else    System.Console.WriteLine(" This string not a Pangram!");

        System.Console.WriteLine();
        }
    }
    private static void Main12345(string[] args)
    {
    //    Ex1();
    //    System.Console.Write("Press any key to move to another Ex: ");
    //    Console.ReadKey();

    //    Ex2();
    //    System.Console.Write("Press any key to move to another Ex: ");
    //    Console.ReadKey();

    //    Ex3();
    //    System.Console.Write("Press any key to move to another Ex: ");
    //    Console.ReadKey();

    //    Ex4_1_Pnumber_lessthan_anum();
    //    System.Console.Write("Press any key to move to another Ex: ");
    //    Console.ReadKey();

    //     Ex4_2_Print_first_N_Pnum();
    //    System.Console.Write("Press any key to move to another Ex: ");
    //    Console.ReadKey();

    //     Ex5();
    //    System.Console.Write("Press any key to move to another Ex: ");
    //    Console.ReadKey();

        Ex6();
       System.Console.Write("Press any key to move to another Ex: ");
       Console.ReadKey();




    }
}