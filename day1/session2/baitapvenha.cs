using System.Text;
using System.Globalization;

internal class Program
{
    static void ex01()
    {
        Console.WriteLine("=== BAI TAP 1 ===");
        decimal chiSoCu = 0;
        decimal chiSoMoi = 0;
        Console.OutputEncoding = Encoding.UTF8;
        while (true)
        {
            Console.Write("Nhập chỉ số điện cũ (kWh): ");
            bool isCuValid = decimal.TryParse(Console.ReadLine(), out chiSoCu);

            Console.Write("Nhập chỉ số điện mới (kWh): ");
            bool isMoiValid = decimal.TryParse(Console.ReadLine(), out chiSoMoi);

            if (isCuValid && isMoiValid && chiSoCu >= 0 && chiSoMoi >= chiSoCu)
            {
                break;
            }

            Console.WriteLine("Lỗi");
        }
        decimal soKwh = chiSoMoi - chiSoCu;
        decimal tienChuaThue = 0;
        const decimal BAC_1 = 1806m;
        const decimal BAC_2 = 1866m;
        const decimal BAC_3 = 2167m;
        const decimal BAC_4 = 2729m;
        const decimal BAC_5 = 3050m;
        if (soKwh <= 50)
        {
            tienChuaThue = soKwh * BAC_1;
        }
        else if (soKwh <= 100)
        {
            tienChuaThue = (50 * BAC_1) + (soKwh - 50) * BAC_2;
        }
        else if (soKwh <= 200)
        {
            tienChuaThue = (50 * BAC_1) + (50 * BAC_2) + (soKwh - 100) * BAC_3;
        }
        else if (soKwh <= 300)
        {
            tienChuaThue = (50 * BAC_1) + (50 * BAC_2) + (100 * BAC_3) + (soKwh - 200) * BAC_4;
        }
        else
        {
            tienChuaThue = (50 * BAC_1) + (50 * BAC_2) + (100 * BAC_3) + (100 * BAC_4) + (soKwh - 300) * BAC_5;
        }
        decimal thueVAT = tienChuaThue * 0.08m;
        decimal tongTien = tienChuaThue + thueVAT;
        tienChuaThue = Math.Round(tienChuaThue);
        thueVAT = Math.Round(thueVAT);
        tongTien = Math.Round(tongTien);
        Console.WriteLine("Chỉ số cũ: {0} kWh", chiSoCu);
        Console.WriteLine("Chỉ số mới: {0} kWh", chiSoMoi);
        Console.WriteLine("Điện tiêu thụ: {0} kWh", soKwh);
        Console.WriteLine("Tiền điện (chưa thuế): {0:#,##0} VNĐ", tienChuaThue);
        Console.WriteLine("Thuế VAT (8%): {0:#,##0} VNĐ", thueVAT);
        Console.WriteLine("TỔNG TIỀN THANH TOÁN: {0:#,##0} VNĐ", tongTien);
    }
    static void ex02()
    {
        Console.WriteLine("=== BAI TAP 2 ===");
        Console.OutputEncoding = Encoding.UTF8;
        double chieuCao = 0;
        double canNang = 0;
        while (true)
        {
            Console.WriteLine("Nhập vào chiều cao (m): ");
            bool isChieuCaoValid = double.TryParse(Console.ReadLine(), out chieuCao);

            Console.WriteLine("Nhập vào cân nặng (kg): ");
            bool isCanNangValid = double.TryParse(Console.ReadLine(), out canNang);
            if (isChieuCaoValid && isCanNangValid && chieuCao > 0 && canNang > 0)
            {
                break;
            }
            Console.WriteLine("Lỗi");

        }
        double BMI = canNang / Math.Pow(chieuCao, 2);
        Console.WriteLine("Chỉ số BMI của bạn: {0:F2}", BMI);
        if (BMI < 18.5)
        {
            Console.WriteLine("phân loại sức khỏe: thiếu cân");
        }
        else if (BMI >= 18.5 && BMI < 23)
        {
            Console.WriteLine("phân loại sức khỏe: bình thường");
        }
        else if (BMI >= 23 && BMI < 25)
        {
            Console.WriteLine("phân loại sức khỏe: thừa cân");
        }
        else
        {
            Console.WriteLine("phân loại sức khỏe: béo phì");
        }
        double cannangtoithieu = 18.5 * Math.Pow(chieuCao, 2);
        double cannangtoida = 22.9 * Math.Pow(chieuCao, 2);
        Console.WriteLine("khuyên dùng: cân nặng lý tưởng từ {0:F2} kg đến {1:F2} kg", cannangtoithieu, cannangtoida);
    }
    enum CurrencyType
    {
        USD,
        EUR,
        JPY,
        GBP
    }
    static void ex03()
    {
        Console.WriteLine("=== BAI TAP 3 ===");
        Console.OutputEncoding = Encoding.UTF8;

        Console.WriteLine("nhập số tiền VNĐ: ");
        decimal vnd = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Chọn ngoại tệ (1: USD, 2: EUR, 3: JPY, 4: GBP): ");
        int choice = int.Parse(Console.ReadLine());
        CurrencyType currency = (CurrencyType)(choice - 1);
        decimal phiDichVu = vnd * 0.005m;
        decimal vndConLai = vnd - phiDichVu;
        decimal tyGia = 0;
        switch(currency)
        {
            case CurrencyType.USD:
                tyGia = 25400m;
                break;
            case CurrencyType.EUR:
                tyGia = 27200m;
                break;
            case CurrencyType.JPY:
                tyGia = 165m;
                break;
            case CurrencyType.GBP:
                tyGia = 32100m;
                break;
        
        }
        decimal ketQua = vndConLai / tyGia;
        Console.WriteLine($"Phí dịch vụ (0.5%): {phiDichVu:N0} VNĐ");
        Console.WriteLine($"Tiền VNĐ tính đổi:   {vndConLai:N0} VNĐ");
        Console.WriteLine($"Số tiền nhận được:  {ketQua:N2} {currency}");
    }
    static void ex04()
    {
        Console.WriteLine("=== BAI TAP 4 ===");
        Console.OutputEncoding = Encoding.UTF8;
        Console.Write("Nhập ngày sinh (dd/MM/yyyy): ");
        string input = Console.ReadLine();
        DateTime birthDate;
        bool isValid = DateTime.TryParseExact(input, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out birthDate);
        if (!isValid)
        {
            Console.WriteLine("Ngày sinh không đúng định dạng dd/MM/yyyy");
            return;
        }
        DateTime today = DateTime.Now.Date;
        int age = today.Year - birthDate.Year;

        if (today < birthDate.AddYears(age))
        {
            age--;
        }
        TimeSpan livedTime = today - birthDate;
        int totalDaysLived = (int)livedTime.TotalDays;
        DateTime nextBirthday = new DateTime(today.Year, birthDate.Month, birthDate.Day);

        if (nextBirthday < today)
        {
            nextBirthday = nextBirthday.AddYears(1);
        }

        TimeSpan timeLeft = nextBirthday - today;
        int daysUntilNextBirthday = (int)timeLeft.TotalDays;

        Console.WriteLine($"Tuổi hiện tại: {age} tuổi");
        Console.WriteLine($"Tổng số ngày đã sống: {totalDaysLived} ngày");
        Console.WriteLine($"Số ngày còn lại đến sinh nhật kế tiếp: {daysUntilNextBirthday} ngày");
    }
    static void ex05()
    {
        Console.WriteLine("=== BAI TAP 5 ===");
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("Nhập điểm số: ");
    }

    public static void Main(string[] args)
    {
        ex01();
        ex02();
        ex03();
        ex04();
        ex05();
    }
}