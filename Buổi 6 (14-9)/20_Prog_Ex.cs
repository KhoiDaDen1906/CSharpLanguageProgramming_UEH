using System.ComponentModel;
using System.Runtime.ConstrainedExecution;

internal class _20_Prog_Ex
{
    /// <summary>
    /// Tính tổng hai số nguyên.
    /// </summary>
    /// <param name="args"></param>
    static int Sum_2_IntNumbers(int a , int b)
    {
        return a + b;
    }
    static void Ex1()
    {
        System.Console.WriteLine("Enter the first number: ");
        int a = int.Parse(Console.ReadLine() ?? "1");
        System.Console.WriteLine("Enter the second number: ");
        int b = int.Parse(Console.ReadLine() ?? "1");

        int sum = Sum_2_IntNumbers(a,b);

        System.Console.WriteLine($"Sum of 2 number is {sum}");
    }
    /// <summary>
    /// Kiểm tra số chẵn lẻ.
    /// </summary>
    /// <param name="args"></param>
    static bool ChanLe_Check(int a)
    {
        if (a % 2 != 0)
        {
            return false;
        }
        return true;
    }
    static void Ex2()
    {
        System.Console.WriteLine("Enter a number: ");
        int a = int.Parse(Console.ReadLine() ?? "1");

        if (ChanLe_Check(a))
        {
            System.Console.WriteLine($"{a} là số chẵn");
        }
        else System.Console.WriteLine($"{a} là số lẻ");
    }
    /// <summary>
    /// Tìm số lớn nhất trong ba số
    /// </summary>
    /// <param name="args"></param>
    static int Max_Check(int a, int b , int c)
    {
        int max = a; 
        if (b > max) max = b;
        if (c > max) max = c ;
        return max;
    }
    static void Ex3()
    {
        System.Console.WriteLine("Enter the first number: ");
        int a = int.Parse(Console.ReadLine() ?? "1");
        System.Console.WriteLine("Enter the second number: ");
        int b = int.Parse(Console.ReadLine() ?? "2");
        System.Console.WriteLine("Enter the third number: ");
        int c = int.Parse(Console.ReadLine() ?? "3");

        int max = Max_Check (a,b,c);

        System.Console.WriteLine($"The maximum of 3 numbers is {max}");
    }
    /// <summary>
    /// Tính giai thừa của một số.
    /// </summary>
    /// <param name="args"></param>
    static int Factorial_Calc(int a)
    {
        int result = 1;
        for (int i = 1 ; i <= a; i ++)
        {
            result *= i;
        }
        return result;
    }
    static void Ex4()
    {
        System.Console.WriteLine("Enter a number you want to calculate factorial: ");
        int a = int.Parse(Console.ReadLine() ?? "5");

        int ket_qua = Factorial_Calc(a);
        
        System.Console.Write("The result is: ");

        for (int i = 1 ; i <= a ; i ++)
        {
            System.Console.Write(i);
            
            if (i < a)
            {
                System.Console.Write("x");
            }
        }
        System.Console.WriteLine($" = {a}! = {ket_qua}");
    }
    /// <summary>
    ///  Đảo ngược chuỗi ký tự
    /// </summary>
    /// <param name="args"></param>
    static string Reverse_String(string text)
    {
        char[] char_Array = text.ToCharArray();
        Array.Reverse(char_Array);
        return new string(char_Array);
    }
    static void Ex5()
    {
        System.Console.WriteLine("Enter a string: ");
        string text = Console.ReadLine() ?? "abcdef";

        string reverse_text = Reverse_String(text);

        System.Console.WriteLine($"The new reverse string is: {reverse_text}");
    }
    /// <summary>
    /// Kiểm tra số nguyên tố.
    /// </summary>
    /// <param name="args"></param>
    static bool Prime_num_check(int a)
    {
        if (a < 2)
        {
            return false;
        }
        for (int i = 2; i < a/2; i ++) // điều kiện có thể là i * i <= n
        {
            if (a % i == 0)
            {
                return false;
            }
        }
        return true;
    }
    static void Ex6()
    {
        while(true)
        {
        System.Console.WriteLine("Enter a number (or type 'no' if you want to exist the program):  ");
        string input = Console.ReadLine() ?? "";
        
        if (input.ToLower() == "no")
            {
                break;
            }
        int a = int.Parse(input);

        if (Prime_num_check(a))
        {
            System.Console.WriteLine($"{a} is prime number!");
        }
        else System.Console.WriteLine($"{a} is not prime number");
        }
    }
    /// <summary>
    ///  In dãy Fibonacci.
    /// </summary>
    /// <param name="args"></param>
    static void Ex7_Fibonacci_series(int n)
    {
     int a = 0 ;
     int b = 1 ;
     for (int i = 1 ; i <= n ; i++)
        {
            System.Console.WriteLine(a + " ");

            int c = a + b;
            a = b;
            b = c; 
        }
        System.Console.WriteLine();
    }
    /// <summary>
    /// Đếm số lượng nguyên âm trong chuỗi.
    /// </summary>
    /// <param name="args"></param>
    static int Dem_Nguyen_Am(string text)
    {
        int count = 0;
        string chuoi_thuong = text.ToLower();
        foreach(char c in chuoi_thuong)
        {
            if (c == 'o' || c == 'a' || c == 'e' || c == 'u' || c == 'i')
            {
                count++ ;
            }
        }
        return count;
    } 
    static void Ex8()
    {
        System.Console.WriteLine("Enter a string: ");
        string text = Console.ReadLine() ?? "Hello World";

        int so_ky_tu = Dem_Nguyen_Am(text);

        System.Console.WriteLine($"The string has {so_ky_tu} vowels");
    }
    /// <summary>
    /// Tính lũy thừa (khong sai Math.Pow()).
    /// </summary>
    /// <param name="args"></param>
    static double Tinh_luy_thua(double x , int y)
    {
        double result = 1.0;

        for (int i = 0; i < y; i++)
        {
            result *= x;
        }
        if (y < 0)
        {
            for (int i = 0 ; i < y ; i ++)
            {
                result *= x;
            }
            return 1/result;
        }
        return result;
    }
    static void Ex9()
    {
        System.Console.Write("Enter the base: ");
        double x = double.Parse(Console.ReadLine() ?? "2");
        System.Console.Write(" Enter the exponent: ");
        int y = int.Parse(Console.ReadLine() ?? "2");

        double ket_qua_luythua = Tinh_luy_thua(x,y);

        System.Console.WriteLine($"The result is {ket_qua_luythua}");
    }
    /// <summary>
    /// Tính điểm trung bình của mảng.
    /// </summary>
    /// <param name="args"></param>
    static double Tinh_trung_binh(int [] arr)
    {
        double sum = 0;
        int count = 0;
        foreach(double n in arr)
        {
            sum += n;
            count ++;
        }
        double trung_binh = sum/count;
        return trung_binh;
    }
    static void Ex10()
    {
        int[] mang_array = {1,2,3,4,5,6,7,8,9,10};
        double mean = Tinh_trung_binh(mang_array);
        System.Console.WriteLine($"Trung bình của các số trong mảng là: {mean}");
    }
    /// <summary>
    ///  Kiểm tra chuỗi đối xứng (Palindrome)
    /// </summary>
    /// <param name="args"></param>
    static bool Kiem_Tra_Doi_Xung (string text)
    {
        string chuoi_thuong = text.ToLower();
        int left = 0;
        int right = text.Length -1;

        while (left < right)
        {
            if (chuoi_thuong [left] != chuoi_thuong [right])
            {
                return false;
            }
            left ++;
            right --;
        } 
        return true;
    }
    static void Ex11()
    {
        System.Console.WriteLine("Enter a string: ");
        string chuoi = Console.ReadLine() ?? "Radar";

        bool doi_xung = Kiem_Tra_Doi_Xung(chuoi);

        if (doi_xung)
        {
            System.Console.WriteLine("The given string is Palindrome");
        }
        else System.Console.WriteLine("The given string is not Palindrome");
    }
    /// <summary>
    /// Chuyển đổi nhiệt độ (C-->F)
    /// </summary>
    /// <param name="args"></param>
    static double Celcius_to_Fahrenheit(double celcius)
    {
        double fahrenheit = celcius * 1.8 + 32;
        return fahrenheit;
    }
    static void Ex12()
    {
        System.Console.WriteLine("Enter the Celcius degree: ");
        double c = double.Parse(Console.ReadLine() ?? "50");

        double f = Celcius_to_Fahrenheit(c);

        System.Console.WriteLine($"The Fahrenheit degree is: {f}");
    }
    /// <summary>
    /// Tìm giá trị nhỏ nhất trong mảng.
    /// </summary>
    /// <param name="args"></param>
    static int Find_min(int [] arr)
    {
        int min_val = arr[0];
        foreach (int n in arr)
        {
            if (n < min_val)
            {
                min_val = n;
            }
        } 
        return min_val;       
    }
    static void Ex13()
    {
        int[] mang_so = {23,84,73,45,12,10,19,17,100,123,142};
        int min = Find_min(mang_so);
        System.Console.WriteLine($"The minimum of the array is: {min}");
    }
    /// <summary>
    /// Tính tổng các chữ số của một số nguyên.
    /// </summary>
    /// <param name="args"></param>
    static int TongChuSoCuaSoNguyen(int n)
    {
        if (n < 0) n = n * -1; // chuyen so am ve so duong.
        int sum = 0;

        while (n > 0)
        {
            int chu_so_cuoi = n % 10;
            sum += chu_so_cuoi;
            n = n / 10;
        }
        return sum;
    }
    static void Ex14()
    {
        System.Console.WriteLine("Enter an integer number: ");
        int n = int.Parse(Console.ReadLine() ?? "1234");

        int tong_cac_chu_so = TongChuSoCuaSoNguyen(n);

        System.Console.WriteLine($" The sum of the digits {n} is {tong_cac_chu_so}");
    }
    /// <summary>
    /// Sắp xếp mảng tăng dần.
    /// </summary>
    /// <param name="args"></param>
    static void Sorting_array(int [] arr)
    {
        int bien_tam;
        for (int i = 0; i < arr.Length -1 ; i ++) // vi du co 4 phan tu thi quet 3 lan.
        {
            for (int j = 0; j < arr.Length -1 - i  ; j ++) // sau moi vong sort thi so lon nhat nam o cuoi roi.
            {                                               // nen khong can phai sort lai => - i .
               if (arr[j] > arr [j+1])
                {
                    bien_tam = arr[j];
                    arr[j] = arr [j+1];
                    arr[j+1] = bien_tam;
                }
            }
        }
        System.Console.WriteLine("Array after being sorted: ");
        foreach (int n in arr)
        {
            System.Console.Write(n + " ");
        }
        System.Console.WriteLine();
    }
    static void Ex15()
    {
        int [] mang_so = {3,5,7,1,2,9,8,6,10,4};
        Sorting_array(mang_so);
        
    }
    /// <summary>
    /// Xóa ký tự trùng lặp
    /// </summary>
    /// <param name="args"></param>
    static string Xoa_Kytu_trunglap(string text)
    {
        string result = "";
        foreach( char c in text)
        {
            if (!result.Contains(c))
            {
                result += c;
            }
        }
        return result;
    }
    static void Ex16()
    {
        System.Console.WriteLine("Enter a word: ");
        string word = Console.ReadLine() ?? "programming";

        string xoa_ky_tu = Xoa_Kytu_trunglap(word);

        System.Console.WriteLine($"Word afetr removing duplicate characters: {xoa_ky_tu}");
    }
    /// <summary>
    /// Tìm ước chung lớn nhất (UCLN)
    /// </summary>
    /// <param name="args"></param>
    static int UCLN (int a , int b)
    {
        while (b != 0)
        {
            int r = a % b;
            a = b ;
            b = r;
        }
        return a;
    }
    static void Ex17()
    {
        System.Console.WriteLine("Enter the first number: ");
        int num1 = int.Parse(Console.ReadLine() ?? "100");
        System.Console.WriteLine("Enter the second number: ");
        int num2 = int.Parse(Console.ReadLine() ?? "50");

        int ucln = UCLN (num1 , num2);

        System.Console.WriteLine($"GCD of 2 numbers is: {ucln}");
    }
    /// <summary>
    /// Chuyển đổi hệ thập phân sang nhị phân
    /// </summary>
    /// <param name="args"></param>
    static string Decimal_To_Binary(int n)
    {
        string result = "";
        if (n == 0)
        {
            result = "0";
            return result;
        }
        while (n > 0)
        {
            int phan_du = n % 2;
            n = n / 2;

            result = phan_du + result; // dao nguoc, doc tu duoi len
        }
        return result;
    }
    static void Ex18()
    {
        System.Console.WriteLine("Enter a number: ");
        int num = int.Parse(Console.ReadLine() ?? "10");

        string binary = Decimal_To_Binary(num);

        System.Console.WriteLine($"Convert {num} in decimal into {binary} in Binary");
    }
    /// <summary>
    /// Kiểm tra năm nhuận
    /// </summary>
    /// <param name="args"></param>
    static bool Kiemtranamnhuan (int n)
    {
        while (true)
        {
            if (n % 400 == 0)
            {
                return true;
            }
            if (n % 4 == 0 && n % 100 != 0)
            {
                return true;
            }
            else return false;
        }
    }
    static void Ex19()
    {
        System.Console.WriteLine("Enter the year you wanna check: ");
        int year = int.Parse(Console.ReadLine() ?? "2025");

        if (Kiemtranamnhuan(year))
        {
            System.Console.WriteLine("This is leap year!");
        }
        else System.Console.WriteLine("This is not leap year!");
    }
    /// <summary>
    /// Đếm số từ trong câu
    /// </summary>
    /// <param name="args"></param>
    static int Dem_Tu_Trongcau(string sentence)
    {
        int count = 0;
        bool o_trong_tu = false;

        foreach(char c in sentence)
        {
            if (c == ' ')
            {
                o_trong_tu = false;
            }
            if (c != ' ')
            {
                if (o_trong_tu == false)
                {
                    count ++;
                    o_trong_tu = true;
                }
            }
        }
        return count;
    }
    static void Ex20()
    {
        System.Console.WriteLine("Enter a sentence: ");
        string cau = Console.ReadLine() ?? "My name is Khoi";

        int dem_tu = Dem_Tu_Trongcau(cau);

        System.Console.WriteLine($"There are {dem_tu} words in this sentence!");
    }
    private static void Main1234567(string[] args)
    {
        // Ex1();
        // System.Console.WriteLine("Type any key to move to the next Ex: ");
        // Console.ReadKey();

        // Ex2();
        // System.Console.WriteLine("Type any key to move to the next Ex: ");
        // Console.ReadKey();

        // Ex3();
        // System.Console.WriteLine("Type any key to move to the next Ex: ");
        // Console.ReadKey();

        // Ex4();
        // System.Console.WriteLine("Type any key to move to the next Ex: ");
        // Console.ReadKey();

        // Ex5();
        // System.Console.WriteLine("Type any key to move to the next Ex: ");
        // Console.ReadKey();

        // Ex6();
        // System.Console.WriteLine("Type any key to move to the next Ex: ");
        // Console.ReadKey();

        // Ex7_Fibonacci_series(6);
        // System.Console.WriteLine("Type any key to move to the next Ex: ");
        // Console.ReadKey();

        // Ex8();
        // System.Console.WriteLine("Type any key to move to the next Ex: ");
        // Console.ReadKey();

        // Ex9();
        // System.Console.WriteLine("Type any key to move to the next Ex: ");
        // Console.ReadKey();

        // Ex10();
        // System.Console.WriteLine("Type any key to move to the next Ex: ");
        // Console.ReadKey();

        // Ex11();
        // System.Console.WriteLine("Type any key to move to the next Ex: ");
        // Console.ReadKey();

        // Ex12();
        // System.Console.WriteLine("Type any key to move to the next Ex: ");
        // Console.ReadKey();
        
        // Ex13();
        // System.Console.WriteLine("Type any key to move to the next Ex: ");
        // Console.ReadKey();

        // Ex14();
        // System.Console.WriteLine("Type any key to move to the next Ex: ");
        // Console.ReadKey();

        // Ex15();
        // System.Console.WriteLine("Type any key to move to the next Ex: ");
        // Console.ReadKey();

        // Ex16();
        // System.Console.WriteLine("Type any key to move to the next Ex: ");
        // Console.ReadKey();

        // Ex17();
        // System.Console.WriteLine("Type any key to move to the next Ex: ");
        // Console.ReadKey();

        // Ex18();
        // System.Console.WriteLine("Type any key to move to the next Ex: ");
        // Console.ReadKey();

        // Ex19();
        // System.Console.WriteLine("Type any key to move to the next Ex: ");
        // Console.ReadKey();

        Ex20();
        System.Console.WriteLine("Type any key to move to the next Ex: ");
        Console.ReadKey();






    }
}