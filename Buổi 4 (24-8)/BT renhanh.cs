internal class Program
{
    /// <summary>
    /// Write a C# Sharp program to check whether a given number is even or odd.
    /// </summary>
    /// <param name="args"></param>
    static void Ex1()
    {
        Console.WriteLine("Nhập vào một số nguyên: ");
        int so_nguyen = int.Parse(Console.ReadLine() ?? "0"); // Nếu không nhập gì mặc định là 0.

        if (so_nguyen % 2 == 0)
        {
            Console.WriteLine($"Số {so_nguyen} là số chẵn! Vì chia 2 dư 0.");
        }
        if (so_nguyen % 2 == 1)
        {
            Console.WriteLine($"Số {so_nguyen} là số lẻ! Vì chia 2 dư 1");
        }
    }
    /// <summary>
    /// Write a C# Sharp program to find the largest of three numbers.
    /// </summary>
    static void Ex2()
    {
        System.Console.WriteLine("Nhập vào số thứ nhất: ");
        double a = double.Parse(Console.ReadLine() ?? "0.0");
        System.Console.WriteLine("Nhập vào số thứ hai: ");
        double b = double.Parse(Console.ReadLine() ?? "0.0");
        System.Console.WriteLine("Nhập vào số thứ ba: ");
        double c = double.Parse(Console.ReadLine() ?? "0.0");

        double max = a;
        if (b > max) max = b;
        if (c > max) max = c;

        System.Console.WriteLine($"Số lớn nhất trong 3 số là {max}");

    }
    /// <summary>
    /// Write a C# Sharp program to accept a coordinate point in an XY
    ///coordinate system and determine in which quadrant the coordinate
    ///point lies.
    /// </summary>
    static void Ex3()
    {
        System.Console.WriteLine("Nhập vào hoành độ: ");
        float x = float.Parse(Console.ReadLine() ?? "0");

        System.Console.WriteLine("Nhập vào tung độ: ");
        float y = float.Parse(Console.ReadLine() ?? "0");

        if(x > 0 && y > 0) Console.WriteLine($"Toạ độ là ({x};{y}) và nằm ở góc phần tư thứ nhất");
        else if(x < 0 && y > 0) Console.WriteLine($"Toạ độ là ({x};{y}) và nằm ở góc phần tư thứ hai");
        else if(x < 0 && y < 0) Console.WriteLine($"Toạ độ là ({x};{y}) và nằm ở góc phần tư thứ ba");
        else if(x > 0 && y < 0) Console.WriteLine($"Toạ độ là ({x};{y}) và nằm ở góc phần tư thứ tư");
        else if(x == 0 && y == 0) Console.WriteLine($"Toạ độ là ({x};{y}) và nằm ở góc toạ độ");
        else if(x == 0 && y > 0) Console.WriteLine($"Toạ độ là ({x};{y}) và nằm trên chiều dương của trục Oy");
        else if(x == 0 && y < 0) Console.WriteLine($"Toạ độ là ({x};{y}) và nằm trên chiều âm của trục Oy");
        else if(x > 0 && y == 0) Console.WriteLine($"Toạ độ là ({x};{y}) và nằm trên chiều dương của trục Ox");
        else  Console.WriteLine($"Toạ độ là ({x};{y}) và nằm trên chiều âm của trục Ox");
    }
    /// <summary>
    /// Write a program to check whether a triangle is Equilateral, Isosceles or Scalene.
    /// </summary>
    /// <param name="args"></param>
    static void Ex4()
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
        } while (thoa_man = false); // bắt người dùng nhập đến khi nào thoả mãn điều kiện là một tam giác thì ngưng.

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
    private static void Main(string[] args)
    {
    //    Ex1();
    //    System.Console.WriteLine("Press any button to move to the next Ex: ");
    //    Console.ReadKey(); 

    //    Ex2();
    //    System.Console.WriteLine("Press any button to move to the next Ex: ");
    //    Console.ReadKey(); 

    //    Ex3();
    //    System.Console.WriteLine("Press any button to move to the next Ex: ");
    //    Console.ReadKey(); 

       Ex4();
       System.Console.WriteLine("Press any button to move to the next Ex: ");
       Console.ReadKey();
    }
}