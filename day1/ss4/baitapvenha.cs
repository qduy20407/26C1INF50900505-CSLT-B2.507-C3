using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace CSLT.ss4
{
    internal class baitapvenha
    {

        public static void Main(string[] args)
        {
            ex01(args);
            ex02(args);
            ex03(args);
            ex04(args);
            ex05(args);
            ex06(args);
            ex07(args);
            ex08(args);
            ex09(args);
            ex10(args);
            ex11(args);
            ex12(args);
            ex13(args);
            ex14(args);
            ex15(args);
            ex16(args);
            ex17(args);
            ex18(args);
            ex19(args);
            ex20(args);

        }
        static int TinhTong(int a, int b)
        {
            return a + b;
        }
        static void ex01(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Bài tập 1: Tính tổng của hai số nguyên");
            Console.WriteLine("nhập số thứ nhất:");
            int soThuNhat = int.Parse(Console.ReadLine());
            Console.WriteLine("nhập số thứ hai:");
            int soThuHai = int.Parse(Console.ReadLine());


            int tong = TinhTong(soThuNhat, soThuHai);


            Console.WriteLine($"Tổng của {soThuNhat} và {soThuHai} là: {tong}");
        }
        static bool kiemtrasochan(int n)
        {
            return n % 2 == 0;
        }
        static void ex02(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Bài tập 2: Kiểm tra số chẵn");

            Console.WriteLine("nhap so can kiem tra:");
            int soCanKiemTra = int.Parse(Console.ReadLine());

            bool laSoChan = kiemtrasochan(soCanKiemTra);
            if (laSoChan)
            {
                Console.WriteLine($"{soCanKiemTra} là số chẵn.");
            }
            else
            {
                Console.WriteLine($"{soCanKiemTra} là số lẻ.");
            }
        }
        static int TimMax(int a, int b, int c)
        {
            int max = a;
            if (b > max)
            {
                max = b;
            }
            if (c > max)
            {
                max = c;
            }
            return max;
        }
        static void ex03(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Bài tập 3: Tìm số lớn nhất trong ba số nguyên");
            Console.WriteLine("nhap so thu nhat:");
            int soThuNhat = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap so thu hai:");
            int soThuHai = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap so thu ba:");
            int soThuBa = int.Parse(Console.ReadLine());

            int max = TimMax(soThuNhat, soThuHai, soThuBa);
            Console.WriteLine($"Số lớn nhất trong ba số {soThuNhat}, {soThuHai} và {soThuBa} là: {max}");
        }
        static long TinhGiaiThua(int n)
        {
            long ketQua = 1;
            for (int i = 1; i <= n; i++)
            {
                ketQua *= i;
            }
            return ketQua;
        }

        static void ex04(string[] args)
        {
            int n = 5;
            long giaiThua = TinhGiaiThua(n);
            Console.WriteLine($"Giai thừa của {n} ({n}!) là: {giaiThua}");
        }
        static string DaoNguocChuoi(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        static void ex05(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Bài tập 5: Đảo ngược chuỗi");
            Console.WriteLine("nhap chuoi can dao nguoc:");
            string chuoiCanDaoNguoc = Console.ReadLine();
            string chuoiDaoNguoc = DaoNguocChuoi(chuoiCanDaoNguoc);
            Console.WriteLine($"Chuỗi trước khi đảo ngược: {chuoiCanDaoNguoc}");
            Console.WriteLine($"Chuỗi sau khi đảo ngược: {chuoiDaoNguoc}");
        }
        static bool KiemTraNguyenTo(int n)
        {
            if (n <= 1)
                return false;
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static void ex06(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Bài tập 6: Kiểm tra số nguyên tố");
            Console.WriteLine("nhap so can kiem tra:");
            int soCanKiemTra = int.Parse(Console.ReadLine());
            bool laSoNguyenTo = KiemTraNguyenTo(soCanKiemTra);
            if (laSoNguyenTo)
            {
                Console.WriteLine($"{soCanKiemTra} là số nguyên tố.");
            }
            else
            {
                Console.WriteLine($"{soCanKiemTra} không phải là số nguyên tố.");
            }
        }
        static void InFibonacci(int n)
        {
            int a = 0, b = 1;
            Console.WriteLine($"Dãy Fibonacci với {n} số đầu tiên:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(a + " ");
                int next = a + b;
                a = b;
                b = next;
            }
            Console.WriteLine();
        }
        static void ex07(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Bài tập 7: In dãy Fibonacci");
            Console.WriteLine("nhap so luong so Fibonacci can in:");
            int n = int.Parse(Console.ReadLine());
            InFibonacci(n);
        }
        static int DemNguyenAm(string s)
        {
            int count = 0;
            string nguyenAm = "aeiouAEIOU";
            foreach (char c in s)
            {
                if (nguyenAm.Contains(c))
                {
                    count++;
                }
            }
            return count;
        }
        static void ex08(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Bài tập 8: Đếm số nguyên âm trong chuỗi");
            Console.WriteLine("nhap chuoi can dem nguyen am:");
            string chuoiCanDem = Console.ReadLine();
            int soLuongNguyenAm = DemNguyenAm(chuoiCanDem);
            Console.WriteLine($"Số lượng nguyên âm trong chuỗi \"{chuoiCanDem}\" là: {soLuongNguyenAm}");
        }
        static double TinhLuyThua(double x, int y)
        {
            return Math.Pow(x, y);
        }
        static void ex09(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Bài tập 9: Tính lũy thừa");
            Console.WriteLine("nhap co so x:");
            double coSo = double.Parse(Console.ReadLine());
            Console.WriteLine("nhap so mu y:");
            int soMu = int.Parse(Console.ReadLine());
            double ketQua = TinhLuyThua(coSo, soMu);
            Console.WriteLine($"{coSo} mũ {soMu} là: {ketQua}");
        }
        static double TinhTrungBinh(int[] arr)
        {
            if (arr == null || arr.Length == 0)
                return 0;
            int sum = 0;
            foreach (int num in arr)
            {
                sum += num;
            }
            return (double)sum / arr.Length;
        }
        static void ex10(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Bài tập 10: Tính trung bình cộng của mảng số nguyên");
            Console.WriteLine("nhap so luong phan tu trong mang:");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"nhap phan tu thu {i + 1}:");
                arr[i] = int.Parse(Console.ReadLine());
            }
            double trungBinh = TinhTrungBinh(arr);
            Console.WriteLine($"Trung bình cộng của mảng là: {trungBinh}");
        }
        static bool KiemTraDoiXung(string s)
        {
            int left = 0;
            int right = s.Length - 1;
            while (left < right)
            {
                if (s[left] != s[right])
                {
                    return false;
                }
                left++;
                right--;
            }
            return true;
        }
        static void ex11(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Bài tập 11: Kiểm tra chuỗi đối xứng");
            Console.WriteLine("nhap chuoi can kiem tra:");
            string chuoiCanKiemTra = Console.ReadLine();
            bool laDoiXung = KiemTraDoiXung(chuoiCanKiemTra);
            if (laDoiXung)
            {
                Console.WriteLine($"\"{chuoiCanKiemTra}\" là chuỗi đối xứng.");
            }
            else
            {
                Console.WriteLine($"\"{chuoiCanKiemTra}\" không phải là chuỗi đối xứng.");
            }
        }
        static double CelsiusToFahrenheit(double c)
        {
            return (c * 9 / 5) + 32;
        }
        static void ex12(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Bài tập 12: Chuyển đổi độ C sang độ F");
            Console.WriteLine("nhap nhiet do C:");
            double doC = double.Parse(Console.ReadLine());
            double doF = CelsiusToFahrenheit(doC);
            Console.WriteLine($"{doC}°C = {doF}°F");
        }
        static int TimMin(int[] arr)
        {
            if (arr == null || arr.Length == 0)
                return 0;
            int min = arr[0];
            foreach (int num in arr)
            {
                if (num < min)
                    min = num;
            }
            return min;
        }
        static void ex13(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Bài tập 13: Tìm số nhỏ nhất trong mảng số nguyên");
            Console.WriteLine("nhap so luong phan tu trong mang:");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"nhap phan tu thu {i + 1}:");
                arr[i] = int.Parse(Console.ReadLine());
            }
            int min = TimMin(arr);
            Console.WriteLine($"Số nhỏ nhất trong mảng là: {min}");
        }
        static int TongCacChuSo(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                sum += n % 10;
                n /= 10;
            }
            return sum;
        }
        static void ex14(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Bài tập 14: Tính tổng các chữ số của một số nguyên");
            Console.WriteLine("nhap so nguyen:");
            int soNguyen = int.Parse(Console.ReadLine());
            int tongChuSo = TongCacChuSo(soNguyen);
            Console.WriteLine($"Tổng các chữ số của {soNguyen} là: {tongChuSo}");
        }
        static void SapXepMangTangDan(int[] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                return;
            }
            Array.Sort(arr);
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
        static void ex15(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Bài tập 15: Sắp xếp mảng số nguyên theo thứ tự tăng dần");
            Console.WriteLine("nhap so luong phan tu trong mang:");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"nhap phan tu thu {i + 1}:");
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Mảng sau khi sắp xếp:");
            SapXepMangTangDan(arr);
        }
        static string XoaTrungLap(string s)
        {
            HashSet<char> seen = new HashSet<char>();
            StringBuilder result = new StringBuilder();
            foreach (char c in s)
            {
                if (!seen.Contains(c))
                {
                    seen.Add(c);
                    result.Append(c);
                }
            }
            return result.ToString();
        }
        static void ex16(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Bài tập 16: Xóa các ký tự trùng lặp trong chuỗi");
            Console.WriteLine("nhap chuoi can xoa trung lap:");
            string chuoiCanXoaTrungLap = Console.ReadLine();
            string chuoiSauKhiXoa = XoaTrungLap(chuoiCanXoaTrungLap);
            Console.WriteLine($"Chuỗi sau khi xóa các ký tự trùng lặp: {chuoiSauKhiXoa}");
        }
        static int UCLN(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        static void ex17(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Bài tập 17: Tìm ước chung lớn nhất (UCLN) của hai số nguyên");
            Console.WriteLine("nhap so thu nhat:");
            int soThuNhat = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap so thu hai:");
            int soThuHai = int.Parse(Console.ReadLine());
            int ucln = UCLN(soThuNhat, soThuHai);
            Console.WriteLine($"Ước chung lớn nhất (UCLN) của {soThuNhat} và {soThuHai} là: {ucln}");
        }
        static string DecimalToBinary(int n)
        {
            if (n == 0)
                return "0";
            StringBuilder binary = new StringBuilder();
            while (n > 0)
            {
                binary.Insert(0, n % 2);
                n /= 2;
            }
            return binary.ToString();
        }
        static void ex18(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Bài tập 18: Chuyển đổi số thập phân sang nhị phân");
            Console.WriteLine("nhap so thap phan:");
            int soThapPhan = int.Parse(Console.ReadLine());
            string soNhiPhan = DecimalToBinary(soThapPhan);
            Console.WriteLine($"Số {soThapPhan} trong hệ nhị phân là: {soNhiPhan}");

        }
        static bool KiemTraNamNhuan(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }
        static void ex19(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Bài tập 19: Kiểm tra năm nhuận");
            Console.WriteLine("nhap nam:");
            int year = int.Parse(Console.ReadLine());
            if (KiemTraNamNhuan(year))
            {
                Console.WriteLine($"{year} là năm nhuận.");
            }
            else
            {
                Console.WriteLine($"{year} không phải là năm nhuận.");
            }
        }
        static int DemSoTu(string sentence)
        {
            string[] words = sentence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }
        static void ex20(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Bài tập 20: Đếm số từ trong câu");
            Console.WriteLine("nhap cau can dem so tu:");
            string cauCanDem = Console.ReadLine();
            int soTu = DemSoTu(cauCanDem);
            Console.WriteLine($"Số từ trong câu là: {soTu}");
        }
    }
}