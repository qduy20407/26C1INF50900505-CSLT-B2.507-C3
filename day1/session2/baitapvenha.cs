using System.Text;
using System.Globalization;

//internal class Program
//{
//    static void ex01()
//    {
//        Console.WriteLine("=== BAI TAP 1 ===");
//        decimal chiSoCu = 0;
//        decimal chiSoMoi = 0;
//        Console.OutputEncoding = Encoding.UTF8;
//        while (true)
//        {
//            Console.Write("Nhập chỉ số điện cũ (kWh): ");
//            bool isCuValid = decimal.TryParse(Console.ReadLine(), out chiSoCu);

    //            Console.Write("Nhập chỉ số điện mới (kWh): ");
    //            bool isMoiValid = decimal.TryParse(Console.ReadLine(), out chiSoMoi);

    //            if (isCuValid && isMoiValid && chiSoCu >= 0 && chiSoMoi >= chiSoCu)
    //            {
    //                break;
    //            }

    //            Console.WriteLine("Lỗi");
    //        }
    //        decimal soKwh = chiSoMoi - chiSoCu;
    //        decimal tienChuaThue = 0;
    //        const decimal BAC_1 = 1806m;
    //        const decimal BAC_2 = 1866m;
    //        const decimal BAC_3 = 2167m;
    //        const decimal BAC_4 = 2729m;
    //        const decimal BAC_5 = 3050m;
    //        if (soKwh <= 50)
    //        {
    //            tienChuaThue = soKwh * BAC_1;
    //        }
    //        else if (soKwh <= 100)
    //        {
    //            tienChuaThue = (50 * BAC_1) + (soKwh - 50) * BAC_2;
    //        }
//        else if (soKwh <= 200)
//{
//    tienChuaThue = (50 * BAC_1) + (50 * BAC_2) + (soKwh - 100) * BAC_3;
//}
//else if (soKwh <= 300)
//{
//    tienChuaThue = (50 * BAC_1) + (50 * BAC_2) + (100 * BAC_3) + (soKwh - 200) * BAC_4;
//}
//else
//{
//    tienChuaThue = (50 * BAC_1) + (50 * BAC_2) + (100 * BAC_3) + (100 * BAC_4) + (soKwh - 300) * BAC_5;
//}
//decimal thueVAT = tienChuaThue * 0.08m;
//decimal tongTien = tienChuaThue + thueVAT;
//tienChuaThue = Math.Round(tienChuaThue);
//thueVAT = Math.Round(thueVAT);
//tongTien = Math.Round(tongTien);
//Console.WriteLine("Chỉ số cũ: {0} kWh", chiSoCu);
//Console.WriteLine("Chỉ số mới: {0} kWh", chiSoMoi);
//Console.WriteLine("Điện tiêu thụ: {0} kWh", soKwh);
//Console.WriteLine("Tiền điện (chưa thuế): {0:#,##0} VNĐ", tienChuaThue);
//Console.WriteLine("Thuế VAT (8%): {0:#,##0} VNĐ", thueVAT);
//Console.WriteLine("TỔNG TIỀN THANH TOÁN: {0:#,##0} VNĐ", tongTien);
//    }
//    static void ex02()
//    {
//        Console.WriteLine("=== BAI TAP 2 ===");
//        Console.OutputEncoding = Encoding.UTF8;
//        double chieuCao = 0;
//        double canNang = 0;
//        while (true)
//        {
//            Console.WriteLine("Nhập vào chiều cao (m): ");
//            bool isChieuCaoValid = double.TryParse(Console.ReadLine(), out chieuCao);

//            Console.WriteLine("Nhập vào cân nặng (kg): ");
//            bool isCanNangValid = double.TryParse(Console.ReadLine(), out canNang);
//            if (isChieuCaoValid && isCanNangValid && chieuCao > 0 && canNang > 0)
//            {
//                break;
//            }
//            Console.WriteLine("Lỗi");

//        }
//        double BMI = canNang / Math.Pow(chieuCao, 2);
//        Console.WriteLine("Chỉ số BMI của bạn: {0:F2}", BMI);
//        if (BMI < 18.5)
//        {
//            Console.WriteLine("phân loại sức khỏe: thiếu cân");
//        }
//        else if (BMI >= 18.5 && BMI < 23)
//        {
//            Console.WriteLine("phân loại sức khỏe: bình thường");
//        }
//        else if (BMI >= 23 && BMI < 25)
//        {
//            Console.WriteLine("phân loại sức khỏe: thừa cân");
//        }
//        else
//        {
//            Console.WriteLine("phân loại sức khỏe: béo phì");
//        }
//        double cannangtoithieu = 18.5 * Math.Pow(chieuCao, 2);
//        double cannangtoida = 22.9 * Math.Pow(chieuCao, 2);
//        Console.WriteLine("khuyên dùng: cân nặng lý tưởng từ {0:F2} kg đến {1:F2} kg", cannangtoithieu, cannangtoida);
//    }
//    enum CurrencyType
//    {
//        USD,
//        EUR,
//        JPY,
//        GBP
//    }
//    static void ex03()
//    {
//        Console.WriteLine("=== BAI TAP 3 ===");
//        Console.OutputEncoding = Encoding.UTF8;

//        Console.WriteLine("nhập số tiền VNĐ: ");
//        decimal vnd = decimal.Parse(Console.ReadLine());

//        Console.WriteLine("Chọn ngoại tệ (1: USD, 2: EUR, 3: JPY, 4: GBP): ");
//        int choice = int.Parse(Console.ReadLine());
//        CurrencyType currency = (CurrencyType)(choice - 1);
//        decimal phiDichVu = vnd * 0.005m;
//        decimal vndConLai = vnd - phiDichVu;
//        decimal tyGia = 0;
//        switch(currency)
//        {
//            case CurrencyType.USD:
//                tyGia = 25400m;
//                break;
//            case CurrencyType.EUR:
//                tyGia = 27200m;
//                break;
//            case CurrencyType.JPY:
//                tyGia = 165m;
//                break;
//            case CurrencyType.GBP:
//                tyGia = 32100m;
//                break;

//        }
//        decimal ketQua = vndConLai / tyGia;
//        Console.WriteLine($"Phí dịch vụ (0.5%): {phiDichVu:N0} VNĐ");
//        Console.WriteLine($"Tiền VNĐ tính đổi:   {vndConLai:N0} VNĐ");
//        Console.WriteLine($"Số tiền nhận được:  {ketQua:N2} {currency}");
//    }
//    static void ex04()
//    {
//        Console.WriteLine("=== BAI TAP 4 ===");
//        Console.OutputEncoding = Encoding.UTF8;
//        Console.Write("Nhập ngày sinh (dd/MM/yyyy): ");
//        string input = Console.ReadLine();
//        DateTime birthDate;
//        bool isValid = DateTime.TryParseExact(input, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out birthDate);
//        if (!isValid)
//        {
//            Console.WriteLine("Ngày sinh không đúng định dạng dd/MM/yyyy");
//            return;
//        }
//        DateTime today = DateTime.Now.Date;
//        int age = today.Year - birthDate.Year;

//        if (today < birthDate.AddYears(age))
//        {
//            age--;
//        }
//        TimeSpan livedTime = today - birthDate;
//        int totalDaysLived = (int)livedTime.TotalDays;
//        DateTime nextBirthday = new DateTime(today.Year, birthDate.Month, birthDate.Day);

//        if (nextBirthday < today)
//        {
//            nextBirthday = nextBirthday.AddYears(1);
//        }

//        TimeSpan timeLeft = nextBirthday - today;
//        int daysUntilNextBirthday = (int)timeLeft.TotalDays;

//        Console.WriteLine($"Tuổi hiện tại: {age} tuổi");
//        Console.WriteLine($"Tổng số ngày đã sống: {totalDaysLived} ngày");
//        Console.WriteLine($"Số ngày còn lại đến sinh nhật kế tiếp: {daysUntilNextBirthday} ngày");
//    }
//    static void ex05()
//    {
//        Console.WriteLine("=== BAI TAP 5 ===");
//        Console.OutputEncoding = Encoding.UTF8;

//        Console.WriteLine("điểm C#: ");
//        Console.Write("Nhập điểm: ");
//        double diem1 = double.Parse(Console.ReadLine());
//        Console.Write("Nhập số tín chỉ: ");
//        int tc1 = int.Parse(Console.ReadLine());

//        Console.WriteLine("điểm Toán: ");
//        Console.Write("Nhập điểm: ");
//        double diem2 = double.Parse(Console.ReadLine());
//        Console.Write("Nhập số tín chỉ: ");
//        int tc2 = int.Parse(Console.ReadLine());

//        Console.WriteLine("điểm Tiếng Anh: ");
//        Console.Write("Nhập điểm: ");
//        double diem3 = double.Parse(Console.ReadLine());
//        Console.Write("Nhập số tín chỉ: ");
//        int tc3 = int.Parse(Console.ReadLine());

//        int tongTC = tc1 + tc2 + tc3;
//        double gpa10 = (diem1 * tc1 + diem2 * tc2 + diem3 * tc3) / tongTC;

//        char diemChu;
//        double gpa4;
//        string xepLoai;

//        if (gpa10 >= 8.5)
//        {
//            diemChu = 'A';
//            gpa4 = 4.0;
//            xepLoai = "Xuất sắc / Giỏi";
//        }
//        else if (gpa10 >= 7.0)
//        {
//            diemChu = 'B';
//            gpa4 = 3.0;
//            xepLoai = "Khá";
//        }
//        else
//        {
//            diemChu = 'F';
//            gpa4 = 0.0;
//            xepLoai = "Kém (Trượt)";
//        }
//        Console.WriteLine($"Điểm trung bình (Thang 10) : {gpa10:F2}");
//        Console.WriteLine($"Điểm chữ quy đổi : {diemChu}");
//        Console.WriteLine($"Điểm trung bình GPA (Thang 4) : {gpa4}");
//        Console.WriteLine($"Xếp loại học lực : {xepLoai}");
//    }
//    static void ex07()
//    {
//        Console.WriteLine("=== BAI TAP 7 ===");
//        Console.OutputEncoding = Encoding.UTF8;

//        Console.Write("Nhập khoảng cách chuyến đi (km): ");
//        double quangDuong = double.Parse(Console.ReadLine());

//        Console.Write("Nhập mức tiêu thụ nhiên liệu (lít/100km): ");
//        double mucTieuThu = double.Parse(Console.ReadLine());

//        Console.Write("Nhập giá xăng hiện tại (VNĐ/lít): ");
//        decimal giaXang = decimal.Parse(Console.ReadLine());

//        Console.Write("Nhập số người tham gia: ");
//        int soNguoi = int.Parse(Console.ReadLine());

//        double tongLitXang = (quangDuong / 100) * mucTieuThu;

//        decimal tongChiPhi = (decimal)tongLitXang * giaXang;

//        decimal tienMoiNguoiChuaLamTron = tongChiPhi / soNguoi;

//        decimal tienMoiNguoi = (decimal)Math.Ceiling((double)tienMoiNguoiChuaLamTron / 1000) * 1000;

//        Console.WriteLine($"Tổng số nhiên liệu tiêu thụ : {tongLitXang:F2} lít");
//        Console.WriteLine($"Tổng chi phí tiền xăng    : {tongChiPhi:N0} VNĐ");
//        Console.WriteLine($"chi phí mỗi người phải trả : {tienMoiNguoi:N0} VNĐ");

//    }
//    static void ex08()
//    {
//        Console.WriteLine("=== BAI TAP 8 ===");
//        Console.OutputEncoding = Encoding.UTF8;

//        string otpChuan = "839201";
//        DateTime creationTime = DateTime.Now;

//        Console.WriteLine($"Mã OTP của bạn là: {otpChuan}");
//        Console.WriteLine($"Thời điểm tạo mã : {creationTime:HH:mm:ss}");
//        Console.WriteLine($"Lưu ý: Mã có hiệu lực trong vòng 5 phút (300 giây).\n");

//        Console.Write("Nhập mã OTP xác thực: ");
//        string inputOtp = Console.ReadLine();

//        Console.Write("Nhập số giây trôi qua kể từ khi nhận mã (ví dụ: 120): ");
//        int giayTroiQua = int.Parse(Console.ReadLine());
//        DateTime verifyTime = creationTime.AddSeconds(giayTroiQua);
//        bool isNumber = int.TryParse(inputOtp, out _);
//        if (inputOtp.Length != 6 || !isNumber)
//        {
//            Console.WriteLine("LỖI: Định dạng không hợp lệ! Mã OTP phải đúng 6 chữ số.");
//            return;
//        }
//        if (inputOtp != otpChuan)
//        {
//            Console.WriteLine("LỖI: Mã OTP không chính xác");
//            return;
//        }
//        TimeSpan timeDifference = verifyTime - creationTime;
//        if (timeDifference.TotalMinutes > 5)
//        {
//            Console.WriteLine("LỖI: Mã OTP đã hết hạn (Vượt quá 5 phút)");
//            return;
//        }
//        Console.WriteLine(" TRẠNG THÁI XÁC THỰC: THÀNH CÔNG! Giao dịch đã được phê duyệt.");
//    }
//    static void ex09()
//    {
//        Console.WriteLine("=== BAI TAP 9 ===");
//        Console.OutputEncoding = Encoding.UTF8;
//        Console.Write("Nhập Lương Gross (VNĐ): ");
//        decimal luongGross = decimal.Parse(Console.ReadLine());

//        Console.Write("Nhập số người phụ thuộc: ");
//        int soNguoiPhuThuoc = int.Parse(Console.ReadLine());
//        decimal bhxh = luongGross * 0.08m;   // 8%
//        decimal bhyt = luongGross * 0.015m;  // 1.5%
//        decimal bhtn = luongGross * 0.01m;   // 1%
//        decimal tongBaoHiem = bhxh + bhyt + bhtn;
//        decimal giamTruBanThan = 11000000m;
//        decimal giamTruNguoiPhuThuoc = soNguoiPhuThuoc * 4400000m;

//        decimal thuNhapTinhThue = luongGross - tongBaoHiem - giamTruBanThan - giamTruNguoiPhuThuoc;
//        if (thuNhapTinhThue < 0)
//        {
//            thuNhapTinhThue = 0;
//        }
//        decimal thueTNCN = 0;

//        if (thuNhapTinhThue > 80000000m)
//            thueTNCN = thuNhapTinhThue * 0.35m - 9850000m;      // Bậc 7: > 80 triệu
//        else if (thuNhapTinhThue > 52000000m)
//            thueTNCN = thuNhapTinhThue * 0.30m - 5850000m;      // Bậc 6: 52 - 80 triệu
//        else if (thuNhapTinhThue > 32000000m)
//            thueTNCN = thuNhapTinhThue * 0.25m - 3250000m;      // Bậc 5: 32 - 52 triệu
//        else if (thuNhapTinhThue > 18000000m)
//            thueTNCN = thuNhapTinhThue * 0.20m - 1650000m;      // Bậc 4: 18 - 32 triệu
//        else if (thuNhapTinhThue > 10000000m)
//            thueTNCN = thuNhapTinhThue * 0.15m - 750000m;       // Bậc 3: 10 - 18 triệu
//        else if (thuNhapTinhThue > 5000000m)
//            thueTNCN = thuNhapTinhThue * 0.10m - 250000m;       // Bậc 2: 5 - 10 triệu
//        else if (thuNhapTinhThue > 0)
//            thueTNCN = thuNhapTinhThue * 0.05m;                 // Bậc 1: <= 5 triệu
//        decimal luongNet = luongGross - tongBaoHiem - thueTNCN;
//        Console.WriteLine($"Tổng giảm trừ bảo hiểm (10.5%)   : {tongBaoHiem:N0} VNĐ");
//        Console.WriteLine($"Thu nhập chịu thuế               : {thuNhapTinhThue:N0} VNĐ");
//        Console.WriteLine($"Thuế TNCN phải nộp               : {thueTNCN:N0} VNĐ");
//        Console.WriteLine($"LƯƠNG NET THỰC NHẬN              : {luongNet:N0} VNĐ");
//    }
//    enum StockStatus
//    {
//        OutOfStock,    // Hết hàng
//        LowStock,      // Sắp hết hàng
//        InStock,       // Còn hàng
//        Discontinued   // Ngừng kinh doanh
//    }
//    static void ex10()
//    {
//        Console.WriteLine("=== BAI TAP 10 ===");
//        Console.OutputEncoding = Encoding.UTF8;
//        string productId = "SP001";
//        string productName = "Áo Phông Polo Nam";

//        int? quantity = null;             // Số lượng chưa cập nhật (null)
//        int minThreshold = 10;            // Ngưỡng tối thiểu
//        DateTime? restockDate = null;     // Chưa có lịch nhập hàng (null)
//        int displayQuantity = quantity ?? 0;
//        StockStatus status;
//        if (quantity == null || quantity == 0)
//        {
//            status = StockStatus.OutOfStock;
//        }
//        else if (quantity < minThreshold)
//        {
//            status = StockStatus.LowStock;
//        }
//        else
//        {
//            status = StockStatus.InStock;
//        }
//        string restockText = restockDate?.ToString("dd/MM/yyyy") ?? "Chưa có lịch nhập";

//        Console.WriteLine($"Số lượng tồn kho       : {displayQuantity} (Cảnh báo: {(quantity.HasValue ? quantity.Value.ToString() : "null")})");
//        Console.WriteLine($"Trạng thái kho hàng     : {status}");
//        Console.WriteLine($"Dự kiến nhập hàng tiếp : {restockText}");
//    }
//    static void ex11()
//    {
//        Console.WriteLine("=== BAI TAP 11 ===");
//        Console.OutputEncoding = Encoding.UTF8;
//        Console.Write("Số tiền gửi: ");
//        decimal P = decimal.Parse(Console.ReadLine());

//        Console.Write("Lãi suất năm (%): ");
//        double r = double.Parse(Console.ReadLine());

//        Console.Write("Thời gian gửi (tháng): ");
//        int n = int.Parse(Console.ReadLine());
//        decimal laiDon = P * (decimal)(r / 100) * (decimal)(n / 12.0);
//        double tongTienKep = (double)P * Math.Pow(1 + (r / 100) / 12, n);
//        decimal laiKep = (decimal)tongTienKep - P;
//        Console.WriteLine($"Tổng tiền lãi (Lãi đơn): {laiDon:N0} VNĐ");
//        Console.WriteLine($"Tổng tiền lãi (Lãi kép): {laiKep:N0} VNĐ");
//        Console.WriteLine($"Lợi nhuận chênh lệch: {laiKep - laiDon:N0} VNĐ (Lãi kép tối ưu hơn)");
//    }
//    public static void Main(string[] args)
//    {
//        ex01();
//        ex02();
//        ex03();
//        ex04();
//        ex05();
//        ex07();
//        ex08(); 
//        ex09();
//        ex10();
//        ex11();
//    }
//}