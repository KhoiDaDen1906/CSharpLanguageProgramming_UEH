internal partial class Ex2
{
    static void Bai_1()
    {
        float Do_C;
        
        Console.Write("Nhập vào Độ C: ");
        Do_C = float.Parse(Console.ReadLine());

        float Kevin = Do_C + 273;
        float Farenheit = Do_C *18/10 +32f;
        Console.WriteLine($"Do Kevin la: {Kevin}K");
        Console.WriteLine($"Do F la: {Farenheit}F");
    }
    static void Bai_2()
    {
        float radius;
        float Pi = 3.14f;
        Console.Write("Enter Radius: ");
        radius = float.Parse(Console.ReadLine());

        float surface = 4 * Pi * radius * radius;
        float volume = 4/3 * Pi * radius * radius * radius;

        Console.WriteLine($"The Surface of the sphere is: {surface}");
        Console.WriteLine($"The Volume of the sphere is: {volume}");
    }
    static void Bai_3()
    {
         float num1 , num2;

        Console.WriteLine("Nhap so dau tien:");
        num1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Nhap so thu hai:");
        num2 = float.Parse(Console.ReadLine());


        float sum = num1 + num2;
        float substraction = num1 - num2;
        float multiplying = num1 * num2;
        float dividing = num1 / num2;
        float mod = num1 % num2;

        Console.WriteLine($"{num1} + {num2} = {sum}");
        Console.WriteLine($"{num1} - {num2} = {substraction}");
        Console.WriteLine($"{num1} * {num2} = {multiplying}");
        Console.WriteLine($"{num1} / {num2} = {dividing}");
        Console.WriteLine($"{num1} mod {num2} = {mod}");
    }
    static void Bai_4()
    {
      float csd_cu, csd_moi;

        Console.Write("Nhập chỉ số điện cũ: ");
        csd_cu = float.Parse(Console.ReadLine());
        Console.Write("Nhập chỉ số điện mới: ");
        csd_moi = float.Parse(Console.ReadLine());
        do
        {   if (csd_moi > csd_cu)
                break;
            else
                Console.WriteLine("Chỉ số mới phải lớn hơn chỉ số cũ: ");
        } while (true);

            float dientieuthu = csd_moi - csd_cu;
            float tien_truoc_thue;

            if (dientieuthu > 0 && dientieuthu <= 50)
            tien_truoc_thue = dientieuthu * 1806;

            else if (dientieuthu > 50 && dientieuthu <= 100)
            tien_truoc_thue = (50*1806) + (dientieuthu - 51)*1866;

            else if (dientieuthu >100 && dientieuthu <=200)
            tien_truoc_thue = (50*1806) + (50*1866) + (dientieuthu - 101) * 2167;

            else if (dientieuthu > 200 && dientieuthu <= 300)
            tien_truoc_thue = (50*1806) + (50*1866) + (100*2167) + (dientieuthu - 201) * 2729;

            else
            tien_truoc_thue = (50*1806) + (50*1866) + (100*2167) + (300*2729) + (dientieuthu - 301) * 3050;

            float tien_sau_thue = tien_truoc_thue * 1.08f;

            Console.WriteLine($"Số điện tiêu thụ là: {dientieuthu} kWh");
            Console.WriteLine($"Tiền điện chưa thuế là: {tien_truoc_thue} kWh");
            Console.WriteLine($"Thuế VAT (8%): {tien_truoc_thue * 0.08} VNĐ");
            Console.WriteLine($"Tổng thanh toán: {tien_sau_thue} VNĐ ");  
    }
    private static void Main4(string[] args)
    {
        Bai_1();
        Console.WriteLine("Press any letter to move to Ex2: ");
        Console.ReadKey();
        Bai_2();
        Console.WriteLine("Press any letter to move to Ex3: ");
        Console.ReadKey();
        Bai_3();
        Console.WriteLine("Press any letter to move to Ex4: ");
        Console.ReadKey();
        Bai_4();
    }
}