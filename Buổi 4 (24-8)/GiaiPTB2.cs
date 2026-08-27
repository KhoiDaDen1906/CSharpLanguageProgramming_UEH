internal class GiaiPTB2
{ 
    private static void Main5(string[] args)
    {
        int a , b , c;
        Console.WriteLine("Nhập số a: ");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("Nhập số b: ");
        b = int.Parse(Console.ReadLine());
        Console.WriteLine("Nhập số c: ");
        c = int.Parse(Console.ReadLine());

        if (a==0)
        {
            if (b==0)
            {
                if(c==0) Console.WriteLine("Phương trình luôn có nghiệm đúng với mọi x");
                else Console.WriteLine("Vô lý");
            }
            else
            {
                if (c==0) Console.WriteLine(" x = 0");
                else Console.WriteLine($"x = {-c/b}");
            }
        }
        else
        {
            float delta = b*b - 4*a*c;
            double x1 = (-b - Math.Sqrt(delta)) / 2*a;
            double x2 = (-b + Math.Sqrt(delta)) / 2*a;

            if(delta > 0)
            {
                Console.WriteLine($"Phương trình có 2 nghiệm phân biệt");
                Console.WriteLine($"\t x1 = {x1} ; x2 = {x2}.");
            }
            else if (delta == 0)
            {
              Console.WriteLine($"Phương trình có nghiệm kép x = {-b/(2*a)}");  
            }
            else Console.WriteLine("Phương trình vô nghiệm.");
        }
    }
}