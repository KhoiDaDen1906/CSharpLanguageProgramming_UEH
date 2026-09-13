internal class Game_doan_so
{
    /// <summary>
    /// Máy tính random ngẫu nhiên 1 số từ 1 - 100
    /// Người dùng đoán số. Nếu người dùng đoán đúng thì thông báo.
    /// Nếu không đúng thì trả về kết quả là số đó lớn/nhỏ hơn mà hệ thống
    /// random. Số lần đoán phụ thuộc vào level mà người chơi chọn.
    ///easy: 
    ///medium: 
    ///hard: 
    /// Sau mỗi lượt chơi hỏi người chơi có muốn chơi tiếp hay không. 
    /// Thống kê số lần chơi của người chơi. 
    /// </summary>
    private static void Main()
    {
        bool tiep_tuc_choi = true;
        int so_lan_doan, dem_thang = 0;
        int tong_so_van_choi = 0;
    
        do
        {
            tong_so_van_choi++;
        
        // Người dùng chọn cấp độ chơi.
        Console.Write("Chọn cấp độ (1 - easy/ 2 - medium/ 3 - hard): ");
        int int_level = int.Parse(Console.ReadLine());
        if (int_level == 1)
        {
            Console.WriteLine("Bạn đã chọn cấp độ easy");
            so_lan_doan = 10;
        }
        else if (int_level == 2)
        {
            Console.WriteLine("Bạn đã chọn cấp độ medium");
            so_lan_doan = 7;
        }
        else
        {
            Console.WriteLine("Bạn đã chọn cấp độ hard");
            so_lan_doan = 5;
        }
        
        // Hệ thống tạo số ngẫu nhiên từ 1-100
        Random random = new Random();
        int num_system = random.Next(1, 101); // Tạo số ngẫu nhiên từ 1-100.

        //Hỏi người dùng đoán số mấy.
        for (int i = 0 ; i <= so_lan_doan; i++)
        {
            Console.Write("Nhập số của bạn: ");
            int num_user = int.Parse(Console.ReadLine());
            
            // So sánh số
            if (num_user == num_system)
            {
                Console.WriteLine("Bạn đã đoán đúng, quả là thiên tài!");
                Console.WriteLine($"Bạn đã đoán đúng sau {i+1} lần!");
                dem_thang++;
                break;
            }
            else if (num_user < num_system)
            {
                Console.WriteLine("Số của bạn nhỏ hơn số của hệ thống!");
            }
            else
            {
                Console.WriteLine("Số của bạn lớn hơn số của hệ thống!");
            }
        }
        Console.WriteLine($"Số random của hệ thống là {num_system}");
        
        //Hỏi người chơi có muốn chơi tiếp không.
        Console.Write("Bạn có muốn chơi tiếp không (yes/no)? ");
        string tiep_tuc = Console.ReadLine();
        if (tiep_tuc == "no")
        {
            tiep_tuc_choi = false;
            Console.WriteLine($"Bạn đã chơi tổng cộng {tong_so_van_choi} ván");
            Console.WriteLine($"Số lần thắng: {dem_thang}");
        }
        } while (tiep_tuc_choi == true);
    } 
}