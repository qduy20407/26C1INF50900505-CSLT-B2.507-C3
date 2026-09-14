using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT.ss3
{
    internal class baitapvenha
    {

        public static void Main(string[] args)
        {
            ex01();
            ex02();
            ex03();
            ex04(); 
            ex05();
            ex06();
            ex07();
            ex08();
            ex09();
            ex10();
        }

        static void ex01()

        {
            Console.WriteLine("--------Bài tập 1:----------------");
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("nhập tuổi:  ");
            int tuoi = int.Parse(Console.ReadLine());

            Console.WriteLine("nhập giờ chiếu");
            int giochieu = int.Parse(Console.ReadLine());

            decimal giave = 0;
            if (tuoi > 60)
            {
                giave = 50000;
            }
            else if (tuoi < 12)
            {
                giave = 50000;
            }
            else if (tuoi >= 12 && tuoi <= 60)
            {
                if (giochieu < 17)
                {
                    giave = 80000;
                }
                else
                {
                    giave = 110000;
                }
            }
            Console.WriteLine("giá vé là: {0} VNĐ ", giave);
        }
        static void ex02()
        {
            Console.WriteLine("--------Bài tập 2:----------------");
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("nhập ROLE:  ");
            string role = Console.ReadLine();

            switch (role)
            {
                case "ADMIN":
                    Console.WriteLine("[Thông báo]:Toàn quyền quản trị hệ thống");
                    break;
                case "MANAGER":
                    Console.WriteLine("[Thông báo]:Quyền quản lý nhân sự và xem báo cáo");
                    break;
                case "EMPLOYEE":
                    Console.WriteLine("[Thông báo]:Quyền tạo và chỉnh sửa hồ sơ cá nhân");
                    break;
                case "GUEST":
                    Console.WriteLine("[Thông báo]:Chỉ có quyền xem thông tin công khai");
                    break;
                default:
                    Console.WriteLine("[Thông báo]:Mã vai trò không hợp lệ");
                    break;
            }
        }
        static void ex03()
        {
            Console.WriteLine("--------Bài tập 3:----------------");
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("nhập số dư tài khoản:  ");
            decimal soDu = decimal.Parse(Console.ReadLine());

            Console.WriteLine("nhập số tiền muốn rút: ");
            decimal soTienRut = decimal.Parse(Console.ReadLine());
            decimal soduconlai = soDu - soTienRut;
            if (soTienRut <= 0)
            {
                Console.WriteLine("Số tiền rút không hợp lệ");
                return;
            }
            else if (soTienRut % 50000 != 0)
            {
                Console.WriteLine("Số tiền rút không hợp lệ. Vui lòng nhập số tiền là bội số của 50.000 VNĐ.");
                return;
            }
            else if (soTienRut > soDu)
            {
                Console.WriteLine("Số dư không đủ để rút số tiền này.");
                return;
            }
            else if (soTienRut > 5000000)
            {
                Console.WriteLine("Số tiền rút vượt quá giới hạn 5.000.000 VNĐ.");
                return;
            }
            else
            {
                Console.WriteLine($"Giao dịch thành công! Số dư còn lại: {soduconlai} VNĐ");
            }

        }
        static void ex04()
        {
            Console.WriteLine("--------Bài tập 4:----------------");
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("nhập phím bấm:  ");
            int phim = int.Parse(Console.ReadLine());

            switch (phim)
            {
                case 1:
                    Console.WriteLine("[Tổng đài]Yêu cầu tư vấn thẻ đã được ghi nhận");
                    break;
                case 2:
                    Console.WriteLine("[Tổng đài]Yêu cầu tra cứu số dư tài khoản đã được ghi nhận");
                    break;
                case 3:
                    Console.WriteLine("[Tổng đài]Yêu cầu khóa thẻ khẩn cấp đã được ghi nhận");
                    break;
                case 4:
                    Console.WriteLine("[Tổng đài]Yêu cầu tra cứu tỷ giá ngoại tệ đã được ghi nhận");
                    break;
                default:
                    Console.WriteLine("[Tổng đài]Lựa chọn không hợp lệ. Vui lòng thử lại!");
                    break;
            }
        }
        static void ex05()
        {
            Console.WriteLine("--------Bài tập 5:----------------");
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("nhập số km:  ");
            int km = int.Parse(Console.ReadLine());
            decimal tien = 0;
            if (km <= 0)
            {
                Console.WriteLine("Số km không hợp lệ!");
                return;
            }
            else if (km == 1)
            {
                tien = 15000;
            }
            else if (km > 1 && km <= 10)
            {
                tien = 15000 + (km - 1) * 12000;
            }
            else
            {
                tien = 15000 + 9 * 12000 + (km - 10) * 10000;
            }
            decimal tiensaugiam = 0;
            decimal khuyenmai = 0;
            if (km > 30)
            {
                tiensaugiam = tien * 0.9m;
                khuyenmai = tien * 0.1m;
            }
            Console.WriteLine($"tổng tiền trước giảm: {tien} VNĐ");
            Console.WriteLine($"số tiền được giảm:-{khuyenmai} VNĐ");
            Console.WriteLine($"tổng tiền sau giảm: {tiensaugiam} VNĐ");

        }
        static void ex06()
        {
            Console.WriteLine("--------Bài tập 6:----------------");
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập mã trạng thái đơn hàng:  ");
            int trangthai = int.Parse(Console.ReadLine());

            switch (trangthai)
            {
                case 1:
                    Console.WriteLine("[Trạng thái ]Chờ xác nhận thanh toán.");
                    break;
                case 2:
                    Console.WriteLine("[Trạng thái]Đang đóng gói và bàn giao đơn vị vận chuyển.");
                    break;
                case 3:
                    Console.WriteLine("[Trạng thái]Đơn hàng đang trên đường giao đến bạn.");
                    break;
                case 4:
                    Console.WriteLine("[Trạng thái]Đơn hàng đã hoàn thành. Cảm ơn bạn!");
                    break;
                case 5:
                    Console.WriteLine("[Trạng thái]Đơn hàng đã hủy. Xuất phiếu hoàn tiền.");
                    break;
                default:
                    Console.WriteLine("[Trạng thái]Lựa chọn không hợp lệ.");
                    break;
            }

        }
        static void ex07()
        {
            Console.WriteLine("--------Bài tập 7:----------------");
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập chiều cao:  ");
            double chieucao = double.Parse(Console.ReadLine());

            Console.WriteLine("Nhập cân nặng:  ");
            double cannang = double.Parse(Console.ReadLine());

            double IBM = cannang / Math.Pow(chieucao, 2);
            Console.WriteLine("Chỉ số IBM của bạn là: {0:F2}", IBM);
            if (IBM < 18.5)
            {
                Console.WriteLine("[Đánh giá] gầy - Nên bổ sung dinh dưỡng.");
            }
            else if (IBM >= 18.5 && IBM < 25)
            {
                Console.WriteLine("[Đánh giá] Cân đối - Tiếp tục duy trì.");
            }
            else if (IBM >= 25 && IBM < 30)
            {
                Console.WriteLine("[Đánh giá] Thừa cân - Nên tăng cường luyện tập.");
            }
            else
            {
                Console.WriteLine("[Đánh giá] Béo phì - Cần sự tư vấn từ bác sĩ.");
            }
        }

        static void ex08()
        {
            Console.WriteLine("--------Bài tập 8:----------------");
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập loại xe:  ");
            string loaiXe = Console.ReadLine();

            Console.WriteLine("nhập thời gian (1: Ban ngày, 2: Ban đêm).:  ");
            int thoiGian = int.Parse(Console.ReadLine());

            switch (loaiXe)
            {
                case "BIKE":
                    if (thoiGian == 1)
                    {
                        Console.WriteLine("Phí gửi xe máy ban ngày: 5000 VNĐ");
                    }
                    else if (thoiGian == 2)
                    {
                        Console.WriteLine("Phí gửi xe máy ban đêm: 10000 VNĐ");
                    }
                    else
                    {

                        Console.WriteLine($"không hợp lệ");
                    }
                    break;
                case "CAR":
                    if (thoiGian == 1)
                    {
                        Console.WriteLine("Phí gửi xe ô tô ban ngày: 30000 VNĐ");
                    }
                    else if (thoiGian == 2)
                    {
                        Console.WriteLine("Phí gửi xe ô tô ban đêm: 60000 VNĐ");
                    }
                    else
                    {

                        Console.WriteLine($"không hợp lệ");
                    }
                    break;
                default:
                    Console.WriteLine("Loại xe không hợp lệ.");
                    break;
            }

        }
        static void ex09()
        {
            Console.WriteLine("--------Bài tập 9:----------------");
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập Điểm trung bình tích lũy (GPA: hệ 4.0):  ");
            double gpa = double.Parse(Console.ReadLine());


            Console.WriteLine("Điểm rèn luyện (DRL: hệ 100):  ");
            int drl = int.Parse(Console.ReadLine());
            if (gpa < 0 || gpa > 4.0)
            {
                Console.WriteLine("Điểm GPA không hợp lệ. Vui lòng nhập giá trị từ 0 đến 4.0.");
                return;
            }
            if (drl < 0 || drl > 100)
            {
                Console.WriteLine("Điểm DRL không hợp lệ. Vui lòng nhập giá trị từ 0 đến 100.");
                return;
            } 
         
 

            if (gpa >= 3.6 && drl >= 90)
            {
                Console.WriteLine("[kết quả] Học bổng Xuất sắc (Mức 100%).");

            }
            else if (gpa >= 3.2 && drl >= 80)
            {
                Console.WriteLine("[kết quả]  Học bổng Khá/Giỏi (Mức 50%).");
            }
            else
            {
                Console.WriteLine("[kết quả] Không đủ điều kiện nhận học bổng.");
            }
        }
        static void ex10()
        {
            Console.WriteLine("--------Bài tập 10:----------------");
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("nhập số tiền muốn quy đổi VNĐ: ");
            decimal sotien = decimal.Parse(Console.ReadLine());

            Console.Write("Nhập mã ngoại tệ (\"USD\", \"EUR\", \"JPY\"):  ");
           string ngoaite = Console.ReadLine();

            switch (ngoaite)
            {
               case "USD":
                    decimal usd = sotien / 25400;
                    Console.WriteLine($"Số tiền quy đổi sang USD: {usd:N2} USD");
                    break;
                case "EUR":
                    decimal eur = sotien / 27200;
                    Console.WriteLine($"Số tiền quy đổi sang EUR: {eur:N2} EUR");
                    break;
                case "JPY":
                    decimal jpy = sotien / 165;
                    Console.WriteLine($"Số tiền quy đổi sang JPY: {jpy:N2} JPY");
                    break;
                default:
                    Console.WriteLine("Mã ngoại tệ không hợp lệ.");
                    break;  
            }
        }
    }
}

