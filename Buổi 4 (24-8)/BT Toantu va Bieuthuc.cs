using Microsoft.VisualBasic;

internal class Toantu_va_Bieuthuc
{
    /// <summary>
    /// Write a C# Sharp program that takes two numbers as input and    
    /// performs an operation (+,-,*,x,/) on them and displays the result of that
    /// operation.
    /// </summary>
    /// <param name="args"></param>
    static void Bai_1()
    {
        float a , b;
        Console.WriteLine("Enter the first number: ");
        a = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number: ");
        b = float.Parse(Console.ReadLine());

        Console.WriteLine($"a + b = {a+b}");
        Console.WriteLine($"a - b = {a-b}");
        Console.WriteLine($"a * b = {a*b}");
        Console.WriteLine($"a x b = {a*b}");
        Console.WriteLine($"a / b = {a/b}");

    }
    /// <summary>
    /// Write a C# Sharp program to display certain values of the function x = y2
    /// + 2y + 1 (using integer numbers for y, ranging from -5 to +5).
    /// </summary>
    static void Bai_2()
    {
        int y , x;

        for (y = -5; y <= 5; y++)
        {
            x = y*y + 2*y + 1;
            Console.WriteLine($"Với y = {y} thì x = {x}");
        }
    
    }
    /// <summary>
    /// Write a C# Sharp program that takes distance and time (hours, minutes,
    /// seconds) as input and displays speed in kilometers per hour (km/h) and
    /// miles per hour (miles/h).
    /// </summary>
    static void Bai_3()
    {
        float km , hours, minutes, seconds;

        Console.WriteLine("Enter distance (km): ");
        km = float.Parse(Console.ReadLine());

        Console.WriteLine("Enter hours: ");
        hours = float.Parse(Console.ReadLine());

        Console.WriteLine("Enter minutes: ");
        minutes = float.Parse(Console.ReadLine());

        Console.WriteLine("Enter seconds: ");
        seconds = float.Parse(Console.ReadLine());

        float total_hours = hours + minutes/60 + seconds/3600;
        float miles = km * 0.621371f;
        float speed_km_h = km /total_hours;
        float speed_miles_h  = miles / total_hours;

        Console.WriteLine($" Your speed is {speed_km_h} km/h or {speed_miles_h} miles/h");

    }
    /// <summary>
    /// Write a C# Sharp program that takes the radius of a sphere as input and
    /// calculates and displays the surface and volume of the sphere. V =4/3*π*r3
    /// </summary>
    static void Bai_4()
    {
        double radius , pi = 3.14f;

        Console.WriteLine("Enter the Radius: ");
        radius = double.Parse(Console.ReadLine());

        double volume = 4/3 * pi * Math.Pow(radius,3);
        Console.WriteLine($"The volume of the sphere is: {volume}");
    }
    /// <summary>
    /// 
    /// </summary>
    static void Bai_5()
    {
        char kytu;
        Console.WriteLine("Press only one letter or one number (0....9): ");
        kytu = char.Parse(Console.ReadLine());

        if( kytu == 'u'||kytu == 'U'||
            kytu == 'e'||kytu == 'E'||
            kytu == 'o'||kytu == 'O'||
            kytu == 'a'||kytu == 'A'||
            kytu == 'i'||kytu == 'I'  ) 
            Console.WriteLine("It's Vowel");
        
            else if (kytu >= 0 && kytu <= 9) Console.WriteLine("It's Digit");

            else Console.WriteLine("Other symbols");

    }
    private static void Main6(string[] args)
    {
        Bai_1();
        Console.WriteLine("Press any button to move to Ex2: ");
        Console.ReadKey();
        Bai_2();
        Console.WriteLine("Press any button to move to Ex3: ");
        Console.ReadKey();
        Bai_3();
        Console.WriteLine("Press any button to move to Ex4: ");
        Console.ReadKey();
        Bai_4();
        Console.WriteLine("Press any button to move to Ex5: ");
        Console.ReadKey();
        Bai_5();
        
    }
}