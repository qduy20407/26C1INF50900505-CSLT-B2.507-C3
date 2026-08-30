using System.Text;

internal class Program
{
    static void ex01()
    {
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
    public static void Main(string[] args)
    {
        ex01();
    }
}