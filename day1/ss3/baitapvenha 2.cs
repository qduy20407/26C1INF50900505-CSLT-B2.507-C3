using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CSLT.ss3
{
    internal class baitapvenha_2
    {
        public static void Main222(string[] args)
        {
            dicegame();
            gamedoanso();
            ex06();
            ex07();
        }
        static void dicegame()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("-- Game Xúc Xắc ---");

            Console.WriteLine(" nhập số tiền bạn có: ");
            decimal soTien = decimal.Parse(Console.ReadLine());
            int soLanChoi = 0;
            int soLanThua = 0;
            int soLanDacBiet = 0;
            bool tieptuc = true;

            do
            {
                soLanChoi++;
                Console.WriteLine($"Bạn có {soTien} đồng. Bạn đặt bao nhiêu?");
                decimal soTienDat = decimal.Parse(Console.ReadLine());
                do
                {
                    bool ok = decimal.TryParse(Console.ReadLine(), out decimal result);
                    if (ok && result <= soTien && result > 1000)
                    {
                        soTienDat = result;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Vui lòng nhập một số hợp lệ hoặc số tiền đặt " +
                            $"cược không được vượt quá số tiền hiện có {soTien}. Hoặc trên 1000 đồng");
                        Console.Write("Bạn đặt bao nhiêu? ");
                    }
                }
                while (true);

                Random rand = new Random();
                int dice1 = rand.Next(1, 7);
                int dice2 = rand.Next(1, 7);
                int sum = dice1 + dice2;


                string guess;
                do
                {
                    Console.Write("Bạn đoán tài (T), xỉu (X) hay lục (L)? ");
                    guess = Console.ReadLine().ToLower();
                    if (guess != "t" && guess != "x" && guess != "l")
                    {
                        Console.WriteLine("Vui lòng nhập T, X hoặc L.");
                    }
                    else
                    {
                        break;
                    }
                }
                while (true);

                bool isWin = false;
                bool isSpecial = false;
                if (guess == "t" && sum > 6)
                {
                    isWin = true;
                }
                else if (guess == "x" && sum < 6)
                {
                    isWin = true;
                }
                else if (guess == "l" && sum == 6)
                {
                    isWin = true;
                    isSpecial = true;
                }
                Console.WriteLine($"Kết quả gieo súc sắc: {dice1} + {dice2} = {sum}");
                if (isWin)
                {
                    if (isSpecial)
                    {
                        soLanDacBiet++;
                        soTien += soTienDat * 3;
                        Console.WriteLine($"Bạn thắng đặc biệt! Tổng số tiền hiện tại: {soTien} đồng.");
                    }
                    else
                    {
                        soTien += soTienDat;
                        Console.WriteLine($"Bạn thắng! Tổng số tiền hiện tại: {soTien} đồng.");
                    }
                }
                else
                {
                    soTien -= soTienDat;
                    soLanThua++;
                    Console.WriteLine($"Bạn thua! Tổng số tiền hiện tại: {soTien} đồng.");
                }
                Console.Write("\nBạn có muốn chơi tiếp không? (C/K): ");
                string input = Console.ReadLine();
                if (input.ToLower() == "k")
                {
                    tieptuc = false;
                }

            }
            while (tieptuc);
            Console.WriteLine($"\nTrò chơi kết thúc!");
            Console.WriteLine($"Tổng số lần chơi: {soLanChoi}");
            Console.WriteLine($"Tổng số lần thắng: {soLanChoi - soLanThua - soLanDacBiet}");
            Console.WriteLine($"Tổng số lần thua: {soLanThua}");
            Console.WriteLine($"Tổng số lần thắng đặc biệt: {soLanDacBiet}");
        }
        static void gamedoanso()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Random rand = new Random();
            int soBiMat = rand.Next(1, 101);


            Console.WriteLine("nhập số tiền ban đầu: ");
            decimal soTien = decimal.Parse(Console.ReadLine());
            while (soTien > 0)
            {
                decimal soTienCuoc = 0;
                while (true)
                {
                    Console.Write("Nhập số tiền cược: ");
                    bool valid = decimal.TryParse(Console.ReadLine(), out soTienCuoc);

                    if (valid && soTienCuoc > 0 && soTienCuoc <= soTien)
                    {
                        break;
                    }
                    Console.WriteLine($"Số tiền cược không hợp lệ! Phải > 0 và <= {soTien:N0} VNĐ.");

                }
                int maxLuot = 0;
                decimal heSoThuong = 0;
                string tenLevel = "";

                Console.WriteLine("chọn độ khó (1: Dễ, 2: Trung bình, 3: Khó): ");
                int doKho = int.Parse(Console.ReadLine());
                switch (doKho)
                {
                    case 1:
                        maxLuot = 10;
                        heSoThuong = 1.5m;
                        tenLevel = "Dễ";
                        break;
                    case 2:
                        maxLuot = 7;
                        heSoThuong = 2.0m;
                        tenLevel = "Trung bình";
                        break;
                    case 3:
                        maxLuot = 5;
                        heSoThuong = 3.0m;
                        tenLevel = "Khó";
                        break;
                    default:
                        Console.WriteLine("Độ khó không hợp lệ!");
                        return;
                }
                bool isWin = false;
                Console.WriteLine($"--- BẮT ĐẦU CHƠI (Mức: {tenLevel} - {maxLuot} lượt đoán) ---");
                Console.WriteLine("Máy tính đã chọn 1 số ngẫu nhiên từ 1 đến 100.");
                
                for (int luot = 1; luot <= maxLuot; luot++)
                {
                    int guess = 0;
                    while (true)
                    {
                        Console.Write($"Lượt {luot}/{maxLuot} - Nhập số đoán (1-100): ");
                        if (int.TryParse(Console.ReadLine(), out guess) && guess >= 1 && guess <= 100)
                        {
                            break;
                        }
                        Console.WriteLine("Vui lòng nhập một số nguyên từ 1 đến 100!");
                    }

                    if (guess == soBiMat)
                    {
                        isWin = true;
                        Console.WriteLine($"🎉 CHÚC MỪNG! Bạn đã đoán đúng số {soBiMat} ở lượt thứ {luot}!");
                        break;
                    }
                    else if (guess < soBiMat)
                    {
                        Console.WriteLine("-> Số bạn đoán BỎ HƠN số cần tìm.");
                    }
                    else
                    {
                        Console.WriteLine("-> Số bạn đoán LỚN HƠN số cần tìm.");
                    }
                    if (isWin)
                    {
                        decimal tienThuong = soTienCuoc * heSoThuong;
                        soTien += tienThuong;
                        Console.WriteLine($"Bạn nhận thêm {tienThuong:N0} VNĐ tiền thưởng!");
                    }
                    else
                    {
                        soTien -= soTienCuoc;
                        Console.WriteLine($" RẤT TIẾC! Bạn đã hết lượt đoán. Số đúng là: {soBiMat}");
                        Console.WriteLine($"Bạn bị trừ {soTienCuoc:N0} VNĐ tiền cược.");
                    }
                    if (soTien <= 0)
                    {
                        Console.WriteLine("Bạn đã hết tiền! Trò chơi kết thúc.");
                        break;
                    }

                    Console.WriteLine($"Số tiền hiện tại của bạn: {soTien:N0} VNĐ");
                    Console.Write("Bạn có muốn tiếp tục chơi không? (y/n): ");
                    string tiepTuc = Console.ReadLine().ToLower();

                    if (tiepTuc != "y" && tiepTuc != "yes")
                    {
                        Console.WriteLine("Cảm ơn bạn đã tham gia trò chơi. Tạm biệt!");
                        break;
                    }
                }

            }
            

        }
        static void ex06()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Nhập số lượng số hạng (n): ");
            int n = int.Parse(Console.ReadLine());

            double sum = 0.0;

            Console.Write("Chuỗi Harmonic: ");
            for (int i = 1; i <= n; i++)
            {
                if (i < n)
                {
                    Console.Write($"1/{i} + ");
                }
                else
                {
                    Console.Write($"1/{i}");
                }

                // Ép kiểu (double) để phép chia lấy kết quả số thực thay vì số nguyên
                sum += 1.0 / i;
            }

            Console.WriteLine($"\nTổng của chuỗi Harmonic gồm {n} số hạng là: {sum:F4}");
        }


        static void ex07()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Nhập giá trị bắt đầu: ");
            int start = int.Parse(Console.ReadLine());

            Console.Write("Nhập giá trị kết thúc: ");
            int end = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nCác số hoàn hảo trong khoảng từ {start} đến {end} là:");

            for (int i = start; i <= end; i++)
            {
                if (IsPerfect(i))
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }
        static bool IsPerfect(int number)
        {
            if (number <= 1) return false;

            int sum = 0;
            for (int i = 1; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                }
            }

            return sum == number;
        }
    }
}

