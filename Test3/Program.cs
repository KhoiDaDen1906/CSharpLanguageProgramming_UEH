internal class Program
{
    private static void Main(string[] args)
    {
        // 1. Add / sum 2 numbers.
        int a = 5;
        int b = 7;
        Console.WriteLine($"Tổng 2 số là: {a + b}");

        // 2. to Swap Values of Two Variables.
        Console.WriteLine($"Before swap number 1 = {a}, number 2 = {b}");
        int temp = a;
        a = b;
        b = temp;
        Console.WriteLine($"After swap number 1 = {a}, number 2 = {b}");

        //3. to Multiply two Floating Point Numbers
        float number1 = 3.5f, number2 = 5.5f;
        float result = number1 * number2;
        Console.WriteLine($"Tích của hai số là: {result}");

        //4. to convert feet to meter
        float feet = 5f;
        float meter = feet * 0.3048f;
        Console.WriteLine($"Kết quả là: {meter}");

        //5. to convert Celsius to Fahrenheit and vice versa
        float Do_C = 37.3f;
        float Do_F = Do_C * 9/5 +32f;
        Console.WriteLine($"Kết quả đổi từ Độ C sang Độ F là: {Do_F}");

        //6. to find the Size of data types
        Console.WriteLine($"Độ lớn của int: {sizeof(int)}");
        Console.WriteLine($"Độ lớn của double: {sizeof(double)}");
        Console.WriteLine($"Độ lớn của float: {sizeof(float)}");

        //7. to Print ASCII Value (tip: read character, print number of this char)
        char g = 'H';
        int ASCII_Value = (int)g;
        Console.WriteLine($"ASCII_Value là: {ASCII_Value}");

        //8. to Calculate Area of Circle
        float R = 10f;
        float pi = 3.14f;
        float area_of_cc = pi * R * R;
        Console.WriteLine($"Diện tích hình tròn là: {area_of_cc}");

        //9. to Calculate Area of Square
        float canh = 5f;
        float area_of_sq = canh * canh;
        Console.WriteLine($"Diện tích hình vuông là: {area_of_sq}");

        //10. to convert days to years, weeks and days
        int ngay = 1000;
        int nam = ngay / 365;

        int con_du = ngay % 365;
        int tuan = con_du / 7;
        int so_ngay_con_lai = con_du % 7;

        Console.WriteLine("So nam: " + nam);
        Console.WriteLine("So tuan: " + tuan);
        Console.WriteLine("So ngay con lai: " + so_ngay_con_lai);

        
    }
}



