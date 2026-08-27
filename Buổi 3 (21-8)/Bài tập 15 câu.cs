using System.Diagnostics.CodeAnalysis;

internal class Baitap15cau
{
    static void Ex1()
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
    static void Ex2()
    {
        double height, weight;
        
        Console.Write("Your height (meters) is: ");
        height = double.Parse(Console.ReadLine());
        Console.Write("Your weight (kg) is: ");
        weight = double.Parse(Console.ReadLine());

        double BMI = Math.Round(weight / Math.Pow(height,2),2);
        Console.WriteLine($"Your BMI is: {BMI}");

        if (BMI < 18.5) Console.WriteLine("You are underweight!");
        else if (BMI >= 18.5 && BMI < 23) Console.WriteLine("You are at a normal weight!");
        else if (BMI >= 23 && BMI < 25) Console.WriteLine("You are a little overweight!");
        else System.Console.WriteLine("You are obese!");

        double min_weight = Math.Round(18.5 * Math.Pow(height,2),2);
        double max_weight = Math.Round(22.9 * Math.Pow(height,2),2);
        System.Console.WriteLine($"Advices: Your ideal weight should be around {min_weight} to {max_weight}");
    }
    enum CurrencyType {USD = 1, EUR = 2, JPY = 3, GBP = 4}
    static void Ex3()
    {
        decimal so_tien;
        Console.Write("Nhập vào số tiền: ");
        so_tien = decimal.Parse(Console.ReadLine());

        int ngoai_te;
        Console.Write("Chọn ngoại tệ (1-USD ; 2-EUR ; 3-JYP ; 4-GBP): ");
        ngoai_te = int.Parse(Console.ReadLine());
        
        decimal phi_dich_vu = so_tien * 0.005m;
        decimal tien_nhan_dc = so_tien - phi_dich_vu;

        decimal tien_sau_khi_doi = 0;
        string don_vi_tien_te = "";

        switch((CurrencyType)ngoai_te)
        {
            case CurrencyType.USD:
                tien_sau_khi_doi = Math.Round(tien_nhan_dc / 25400m,2);
                don_vi_tien_te = "USD";
                break;
            
            case CurrencyType.EUR:
                tien_sau_khi_doi = Math.Round(tien_nhan_dc / 27200m,2);
                don_vi_tien_te = "EUR";
                break;

            case CurrencyType.JPY:
                tien_sau_khi_doi = Math.Round(tien_nhan_dc / 165m,2);
                don_vi_tien_te = "JPY";
                break;
            
            case CurrencyType.GBP:
                tien_sau_khi_doi = Math.Round(tien_nhan_dc / 32100m,2);
                don_vi_tien_te = "GBP";
                break;
        }
        Console.WriteLine($"Phí dịch vụ (0,5%): {phi_dich_vu}");
        Console.WriteLine($"Tiền VNĐ tính đổi: {tien_nhan_dc}");
        Console.WriteLine($"Số tiền {don_vi_tien_te} nhận được: {tien_sau_khi_doi}");
    }
    static void Ex4()
    {
        string date;
        DateTime ngay_sinh;

        do 
        {
        Console.WriteLine("Nhập vào ngày sinh (dd/MM/yyyy)");
        date = Console.ReadLine();
        
        bool hop_le = DateTime.TryParseExact
        (date, "dd/MM/yyyy", 
        null, System.Globalization.DateTimeStyles.None, 
        out ngay_sinh);
        if (hop_le == false) 
        {
            Console.WriteLine("Nhập sai định dạng! Vui lòng nhập lại: ");
            continue;
        } 
        break;
        } 
        while (true);

        DateTime ngay_hien_tai = DateTime.Now.Date;
        int tuoi = ngay_hien_tai.Year - ngay_sinh.Year;
        
        if (ngay_hien_tai.Month < ngay_sinh.Month || 
            (ngay_hien_tai.Month == ngay_sinh.Month && ngay_hien_tai.Day < ngay_sinh.Day))
        {
            tuoi-- ;
        }

        TimeSpan da_song = ngay_hien_tai - ngay_sinh;
        int so_ngay_da_song = (int) da_song.TotalDays;

        DateTime sn_tieptheo = new DateTime (ngay_hien_tai.Year , ngay_sinh.Month , ngay_sinh.Day);
        if(sn_tieptheo < ngay_hien_tai)
        {
            sn_tieptheo = sn_tieptheo.AddYears(1);
        }
        TimeSpan tg_den_sn_tieptheo = sn_tieptheo - ngay_hien_tai;
        int ngay_con_lai = (int) tg_den_sn_tieptheo.TotalDays;

        Console.WriteLine($"Tuổi hiện tại: {tuoi} tuổi");
        System.Console.WriteLine($"Bạn đã sống tổng cộng: {so_ngay_da_song} ngày");
        System.Console.WriteLine($"Sinh nhật tiếp theo còn: {ngay_con_lai} ngày");
    }
    static void Ex5()
    {
        double diem_Csharp , diem_toanrr, diem_TA;
        int tc_Csharp, tc_toanrr, tc_TA;

        Console.WriteLine("Nhập vào điểm môn C#: ");
        diem_Csharp = double.Parse(Console.ReadLine());
        Console.WriteLine("Nhập vào số tín chỉ môn C#: ");
        tc_Csharp = int.Parse(Console.ReadLine());

        Console.WriteLine("Nhập vào điểm môn Toán rời rạc: ");
        diem_toanrr = double.Parse(Console.ReadLine());
        Console.WriteLine("Nhập vào số tín chỉ môn Toán rời rạc: ");
        tc_toanrr = int.Parse(Console.ReadLine());

        Console.WriteLine("Nhập vào điểm môn Tiếng Anh: ");
        diem_TA = double.Parse(Console.ReadLine());
        Console.WriteLine("Nhập vào số tín chỉ môn Tiếng Anh: ");
        tc_TA = int.Parse(Console.ReadLine());

        double diem_trung_binh = (diem_Csharp * tc_Csharp + diem_toanrr * tc_toanrr + diem_TA * tc_TA) 
                                / (tc_Csharp + tc_TA + tc_toanrr);
        
        char thang_diem_chu;
        double thang_diem_so;
        string hoc_luc;

        if (diem_trung_binh >= 8.5)
        {
            thang_diem_chu = 'A';
            thang_diem_so = 4.0;
            hoc_luc = "Xuất sắc/Giỏi";
        }
        else if (diem_trung_binh >= 7.0 && diem_trung_binh < 8.5)
        {
            thang_diem_chu = 'B';
            thang_diem_so = 3.0;
            hoc_luc = "Khá";
        }
        else if (diem_trung_binh >= 5.5 && diem_trung_binh < 7.0)
        {
            thang_diem_chu = 'C';
            thang_diem_so = 2.0;
            hoc_luc = "Trung bình";
        }
        else if (diem_trung_binh >= 4.0 && diem_trung_binh < 5.5)
        {
            thang_diem_chu = 'D';
            thang_diem_so = 1.0;
            hoc_luc = "Yếu";
        }
        else 
        {
            thang_diem_chu = 'F';
            thang_diem_so = 0.0;
            hoc_luc = "Kém (Trượt)";
        }

        System.Console.WriteLine($"Điểm trung bình thang 10: {diem_trung_binh:F2}");
        System.Console.WriteLine($"Điểm chữ quy đổi: {thang_diem_chu}");
        System.Console.WriteLine($"Điểm GPA thang 4: {thang_diem_so}");
        System.Console.WriteLine($"Xếp loại học lực: {hoc_luc}");   
    }
    static void Ex7()
    {
        double quang_duong, nhien_lieu;
        decimal gia_xang;
        int so_nguoi;

        System.Console.WriteLine("Nhập quãng đường đi (km): ");
        quang_duong = double.Parse(Console.ReadLine());

        System.Console.WriteLine("Nhập mức nhiên liệu tiêu thụ trung bình (lít/100km): ");
        nhien_lieu = double.Parse(Console.ReadLine());

        System.Console.WriteLine("Nhập vào giá xăng hiện tại (VNĐ/lít):");
        gia_xang = decimal.Parse(Console.ReadLine());

        System.Console.WriteLine("Nhập vào số người tham gia: ");
        so_nguoi = int.Parse(Console.ReadLine());

        double tong_lit_xang = (quang_duong/100) * nhien_lieu;
        decimal tong_cphi_tien_xang = (decimal) tong_lit_xang * gia_xang;
        decimal so_tien_moi_nguoi_tra = (decimal) tong_cphi_tien_xang / so_nguoi;
        decimal tien_moi_nguoi_da_lam_tron = Math.Ceiling(so_tien_moi_nguoi_tra/1000) *1000;

        System.Console.WriteLine($"Tổng nhiên liệu tiêu thụ: {tong_lit_xang:F2} lít"); // nhập 320,5
        System.Console.WriteLine($"Tổng chi phí xăng dầu: {tong_cphi_tien_xang:#,##0} VNĐ"); // nhập 7,5
        System.Console.WriteLine($"Chi phí mỗi người: {tien_moi_nguoi_da_lam_tron:#,##0} VNĐ"); // nhập 28300    
    }
    static void Ex8()
    {
        string chuoi_OTP , otp_he_thong = "839201";
        DateTime creation_time = DateTime.Now;
        Console.WriteLine("Nhập vào chuỗi 6 số mã OTP: ");
        chuoi_OTP = Console.ReadLine() ?? "" ; // ?? "" để đề phòng trường hợp không nhập gì => lấy chuỗi rỗng.


        Console.WriteLine("Nhập vào số phút đã trôi qua: ");
        int so_phut_troi_qua = int.Parse(Console.ReadLine() ?? "0"); // nếu không nhập gì => lấy 0
        System.Console.WriteLine("Nhập vào số giây đã trôi qua: ");
        int so_giay_troi_qua = int.Parse(Console.ReadLine() ?? "0"); // nếu không nhập gì => lấy 0
        System.Console.WriteLine($"Khoảng thời gian đã trôi qua là: {so_phut_troi_qua} phút {so_giay_troi_qua} giây ");
        DateTime thoi_gian_nhap_ma = creation_time.AddMinutes(so_phut_troi_qua).AddSeconds(so_giay_troi_qua);
        TimeSpan khoang_thoi_gian_chenh_lech = thoi_gian_nhap_ma - creation_time;

        bool dinh_dang_hop_le = int.TryParse(chuoi_OTP, out int OTP_code) && chuoi_OTP.Length == 6;
        bool ma_dung = (chuoi_OTP == otp_he_thong);

        if(dinh_dang_hop_le == false)
        {
            Console.Write("Trạng thái xác thực: Lỗi - Định dạng không hợp lệ!");
        }
        else if (ma_dung == false)
        {
            System.Console.Write("Trạng thái xác thực: Lỗi - Mã OTP không đúng!");
        }
        else if (khoang_thoi_gian_chenh_lech.TotalSeconds > 300)
        {
            System.Console.Write("Trạng thái xác thực: Lỗi - Mã OTP đã hết hạn!");
        }
        else 
        {
            System.Console.Write("Trạng thái xác thực: Thành Công! - Giao dịch được thông qua");
        }
    }
    static void Ex9()
    {
        System.Console.WriteLine("Nhập Lương Gross (VNĐ): ");
        decimal luong_gross = decimal.Parse(Console.ReadLine() ?? "");
        System.Console.WriteLine("Số người phụ thuộc: ");
        int so_nguoi = int.Parse(Console.ReadLine() ?? "0");
        
        decimal he_so_giamtru = 10.5m/100m;
        decimal giam_tru_baohiem = he_so_giamtru * luong_gross;
        decimal muc_ban_than = 11000000m;
        decimal thu_nhap_chiuthue = luong_gross - giam_tru_baohiem - muc_ban_than - (so_nguoi *4400000);
        if (thu_nhap_chiuthue <= 0)
        {
            thu_nhap_chiuthue = 0; 
        }

        decimal thue_tncn;
        if (thu_nhap_chiuthue <= 5000000m)
        {
            thue_tncn = thu_nhap_chiuthue *0.05m;
        }
        else if (thu_nhap_chiuthue > 5000000 && thu_nhap_chiuthue <= 10000000m)
        {
            thue_tncn = 5000000m * 0.05m + (thu_nhap_chiuthue - 5000000m) * 0.1m;
        }
        else
        {
            thue_tncn = 5000000m * 0.05m + 10000000 * 0.1m + (thu_nhap_chiuthue - 10000000) * 0.15m;
        }

        decimal luong_net = luong_gross - giam_tru_baohiem - thue_tncn;

        System.Console.WriteLine($"Giảm trừ bảo hiểm (10.5%): {giam_tru_baohiem:#,##0} VNĐ");
        System.Console.WriteLine($"Thu nhập chịu thuế: {thu_nhap_chiuthue:#,##0} VNĐ");
        System.Console.WriteLine($"Thuế TNCN phải nộp: {thue_tncn:#,##0} VNĐ");
        System.Console.WriteLine($"Lương NET nhận thực: {luong_net:#,##0} VNĐ");
    }
    static void Ex11()
    {
        Console.WriteLine("Nhập vào số tiền gửi ban đầu: ");
        decimal tien_gui = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Nhập vào lãi suất (%/năm): ");
        double lai_suat = double.Parse(Console.ReadLine());

        Console.WriteLine("Nhập kì hạn (tháng): ");
        int thang = int.Parse(Console.ReadLine());

        decimal so_tien_lai_don = tien_gui * (decimal)(lai_suat / 100) * (thang / 12m);
        double co_so = 1.0 + (lai_suat/100)/12;
        double tong_tien_lai_kep = (double)tien_gui * Math.Pow(co_so,thang);
        decimal so_tien_lai_kep = (decimal)tong_tien_lai_kep - tien_gui;

        Console.WriteLine($"Tổng tiền lãi đơn: {so_tien_lai_don:#,##0} VNĐ");
        Console.WriteLine($"Tổng tiền lãi kép: {so_tien_lai_kep:#,##0} VNĐ");
        if (so_tien_lai_don < so_tien_lai_kep)
        {
            System.Console.WriteLine($"Chênh lệch lợi nhuận: {so_tien_lai_kep - so_tien_lai_don:#,##0} VNĐ (Lãi kép tối ưu hơn) ");
        }
        else 
        {
            System.Console.WriteLine($"Chênh lệch lợi nhuận: {so_tien_lai_don - so_tien_lai_kep:#,##0} VNĐ (Lãi đơn tối ưu hơn)");
        }
        

    }
    enum VehicleType {Motorbike = 1, Car = 2, Truck = 3 }
    static void Ex13()
    {
        Console.WriteLine("Nhập vào kiểu xe (Motorbike-1 ; Car-2 ; Truck-3): ");
        int chon_loai_xe = int.Parse(Console.ReadLine());

        if (chon_loai_xe < 1 || chon_loai_xe > 3)
        {
            Console.WriteLine("Không có sẵn loại xe ở đây! Vui lòng nhập lại!");
            return;
        }
        VehicleType loai_xe = (VehicleType) chon_loai_xe;

        string gio_vao;
        Console.WriteLine(" Nhập giờ vào (yyyy/MM/dd HH:mm): ");
        gio_vao = Console.ReadLine();
        DateTime gio_check_in = DateTime.ParseExact(gio_vao,"yyyy/MM/dd HH:mm", null ); // để null để không phân biệt văn hoá địa lí định dạng ngày tháng.


        string gio_ve;
        Console.WriteLine("Nhập giờ về (yyyy/MM/dd HH:mm): ");
        gio_ve = Console.ReadLine();
        DateTime gio_check_out = DateTime.ParseExact(gio_ve, "yyyy/MM/dd HH:mm", null);

        TimeSpan thoi_gian_do_xe = gio_check_out - gio_check_in;
        double so_gio_thuc_te_da_do = thoi_gian_do_xe.TotalHours;
        int so_gio_bi_tinh_phi = (int) Math.Ceiling(so_gio_thuc_te_da_do);

        decimal gia_xe_trong_2gio_dau_tien = 0m; 
        decimal gia_xe_sau_2gio = 0m;
        if (loai_xe == (VehicleType)1)
        {
            gia_xe_trong_2gio_dau_tien = 5000m;
            gia_xe_sau_2gio = 2000m;
        }
        else if (loai_xe == (VehicleType)2)
        {
            gia_xe_trong_2gio_dau_tien = 20000m;
            gia_xe_sau_2gio = 10000m;
        }
        else if (loai_xe == (VehicleType)3)
        {
            gia_xe_trong_2gio_dau_tien = 50000m;
            gia_xe_sau_2gio = 25000m;
        }

        decimal phi_phat_sinh_sau_2gio = 0m;
        int so_gio_sau_2gio_dau_tien = 0;

        if(so_gio_bi_tinh_phi > 2)
        {
            so_gio_sau_2gio_dau_tien = so_gio_bi_tinh_phi - 2;
            phi_phat_sinh_sau_2gio = (decimal)so_gio_sau_2gio_dau_tien * gia_xe_sau_2gio;
        }
        
        decimal tong_chi_phi = gia_xe_trong_2gio_dau_tien + phi_phat_sinh_sau_2gio;
        decimal phu_phi_qua_dem = 0m;
        if (gio_check_in.Date != gio_check_out.Date)
        {
            phu_phi_qua_dem = 30000m;
            tong_chi_phi = tong_chi_phi + phu_phi_qua_dem;
        }

        Console.WriteLine($"Tổng thời gian đỗ: {so_gio_thuc_te_da_do:F2} giờ -> Tính phí: {so_gio_bi_tinh_phi} giờ");
        Console.WriteLine($"Phí 2 giờ đầu: {gia_xe_trong_2gio_dau_tien:#,##0} VNĐ");

        if (so_gio_bi_tinh_phi > 2)
        {
            Console.WriteLine($"Phí {so_gio_sau_2gio_dau_tien} giờ tiếp theo: {phi_phat_sinh_sau_2gio:#,##0} VNĐ ({gia_xe_sau_2gio:#,##0} x {so_gio_sau_2gio_dau_tien})");
        }

        if (phu_phi_qua_dem > 0)
        {
            Console.WriteLine($"Phụ phí qua đêm: {phu_phi_qua_dem:#,##0} VNĐ");
        }
        Console.WriteLine($"Tổng phí đỗ xe: {tong_chi_phi:#,##0} VNĐ");
    }
    private static void Main(string[] args)
    {
        // Ex1();
        // Console.WriteLine("Press any letter to move to next Ex:");
        // Console.ReadKey();

        // Ex2();
        // Console.WriteLine("Press any letter to move to next Ex:");
        // Console.ReadKey();

        // Ex3();
        // Console.WriteLine("Press any letter to move to next Ex:");
        // Console.ReadKey();

        // Ex4();
        // Console.WriteLine("Press any letter to move to next Ex:");
        // Console.ReadKey();

        // Ex5();
        // Console.WriteLine("Press any letter to move to next Ex:");
        // Console.ReadKey();

        // Ex7();
        // Console.WriteLine("Press any letter to move to next Ex:");
        // Console.ReadKey();

        // Ex8();
        // Console.WriteLine("Press any letter to move to next Ex:");
        // Console.ReadKey();

        // Ex9();
        // Console.WriteLine("Press any letter to move to next Ex:");
        // Console.ReadKey();

        // Ex11();
        // Console.WriteLine("Press any letter to move to next Ex:");
        // Console.ReadKey();

        Ex13();
        Console.WriteLine("Press any letter to move to next Ex:");
        Console.ReadKey();
    }
}