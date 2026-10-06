using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT.ss6
{
    internal class baitapvenha
    {
        public static void Main(string[] args)
        {
            ex01();
            ex02();
        }
        static void ex01()
        {
            Console.WriteLine("=== BÀI 1: MẢNG ZÍC ZẮC CƠ BẢN ===");

            
            int[][] jaggedArray = new int[3][];

            jaggedArray[0] = new int[] { 1, 5, 9 };         
            jaggedArray[1] = new int[] { 2, 8 };           
            jaggedArray[2] = new int[] { 4, 7, 3, 6 };       

           
            Console.WriteLine("Các phần tử trong mảng zíc zắc:");
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Console.Write($"Hàng {i}: ");
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write($"{jaggedArray[i][j],4}");
                }
                Console.WriteLine();
            }
        }
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhập số hàng của mảng: ");
            int rows = int.Parse(Console.ReadLine());

            int[][] array = new int[rows][];
            Random rand = new Random();

            
            for (int i = 0; i < rows; i++)
            {
                Console.Write($"Nhập số cột cho hàng {i}: ");
                int cols = int.Parse(Console.ReadLine());
                array[i] = new int[cols];

                for (int j = 0; j < cols; j++)
                {
                    array[i][j] = rand.Next(1, 100);
                }
            }

          
            Console.WriteLine("\n--- MẢNG BAN ĐẦU ---");
            PrintArray(array);

          
            PrintMaxValues(array);

         
            SortRowsAscending(array);
            Console.WriteLine("\n--- MẢNG SAU KHI SẮP XẾP TĂNG DẦN TỪNG HÀNG ---");
            PrintArray(array);

         
            PrintPrimeNumbers(array);

            
            Console.Write("\nNhập số cần tìm vị trí: ");
            int searchNum = int.Parse(Console.ReadLine());
            SearchValue(array, searchNum);
        }

      
        static void PrintArray(int[][] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"Hàng {i}: ");
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write($"{arr[i][j],4}");
                }
                Console.WriteLine();
            }
        }

       
        static void PrintMaxValues(int[][] arr)
        {
            Console.WriteLine("\n--- SỐ LỚN NHẤT ---");
            int maxAll = int.MinValue;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length == 0) continue;
                int maxRow = arr[i][0];
                for (int j = 1; j < arr[i].Length; j++)
                {
                    if (arr[i][j] > maxRow) maxRow = arr[i][j];
                }
                Console.WriteLine($"Số lớn nhất của hàng {i} là: {maxRow}");
                if (maxRow > maxAll) maxAll = maxRow;
            }

            Console.WriteLine($"=> Số lớn nhất toàn bộ mảng là: {maxAll}");
        }

        
        static void SortRowsAscending(int[][] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Array.Sort(arr[i]);
            }
        }

       
        static bool IsPrime(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
        static void PrintPrimeNumbers(int[][] arr)
        {
            Console.WriteLine("\n--- CÁC SỐ NGUYÊN TỐ TRONG MẢNG ---");
            bool found = false;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    if (IsPrime(arr[i][j]))
                    {
                        Console.WriteLine($"Giá trị {arr[i][j]} tại vị trí [Hàng {i}, Cột {j}]");
                        found = true;
                    }
                }
            }
            if (!found) Console.WriteLine("Không có số nguyên tố nào trong mảng.");
        }

        static void SearchValue(int[][] arr, int value)
        {
            Console.WriteLine($"\n--- KẾT QUẢ TÌM KIẾM SỐ {value} ---");
            bool found = false;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    if (arr[i][j] == value)
                    {
                        Console.WriteLine($"Thấy tại vị trí: Hàng {i}, Cột {j}");
                        found = true;
                    }
                }
            }
            if (!found) Console.WriteLine($"Không tìm thấy số {value} trong mảng.");
        }
        public struct Member
        {
            public int Id;
            public string FullName;
            public int CompletedTasks;

            public Member(int id, string fullName, int completedTasks)
            {
                Id = id;
                FullName = fullName;
                CompletedTasks = completedTasks;
            }

            public override string ToString()
            {
                return $"[ID: {Id,-4}] | Họ và tên: {FullName,-20} | Số CV hoàn thành: {CompletedTasks}";
            }
        }
        static void ex02()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Member[][] companyGroups = new Member[3][];
            companyGroups[0] = new Member[5];
            companyGroups[1] = new Member[3]; 
            companyGroups[2] = new Member[6]; 

            bool initialized = false;
            int choice;

            do
            {
                Console.WriteLine("\n================ QUẢN LÝ THÀNH VIÊN CÔNG TY X ================");
                Console.WriteLine("1. Khởi tạo danh sách thành viên (Mặc định / Nhập tay)");
                Console.WriteLine("2. In danh sách toàn bộ thành viên theo nhóm");
                Console.WriteLine("3. Tìm thông tin thành viên theo ID");
                Console.WriteLine("4. Tìm thành viên hoàn thành nhiều công việc nhất");
                Console.WriteLine("0. Thoát chương trình");
                Console.WriteLine("==============================================================");
                Console.Write("Lựa chọn của bạn (0-4): ");

                if (!int.TryParse(Console.ReadLine(), out choice)) continue;

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("\n[1] Bạn muốn: (1) Nạp dữ liệu mẫu sẵn | (2) Nhập thủ công từ bàn phím?");
                        Console.Write("Nhập 1 hoặc 2: ");
                        int subChoice = int.Parse(Console.ReadLine());
                        if (subChoice == 1)
                        {
                            InitializePredefinedData(companyGroups);
                            Console.WriteLine("-> Khởi tạo dữ liệu mẫu thành công!");
                        }
                        else
                        {
                            InputFromKeyboard(companyGroups);
                            Console.WriteLine("-> Nhập dữ liệu hoàn tất!");
                        }
                        initialized = true;
                        break;

                    case 2:
                        if (!CheckInitialized(initialized)) break;
                        PrintAllMembers(companyGroups);
                        break;

                    case 3:
                        if (!CheckInitialized(initialized)) break;
                        Console.Write("Nhập ID thành viên cần tìm: ");
                        int searchId = int.Parse(Console.ReadLine());
                        FindMemberById(companyGroups, searchId);
                        break;

                    case 4:
                        if (!CheckInitialized(initialized)) break;
                        FindTopPerformer(companyGroups);
                        break;

                    case 0:
                        Console.WriteLine("Đã thoát chương trình.");
                        break;

                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ, vui lòng thử lại!");
                        break;
                }
            } while (choice != 0);
        }

        static bool CheckInitialized(bool isInit)
        {
            if (!isInit)
            {
                Console.WriteLine("Lỗi: Vui lòng thực hiện Chức năng 1 (Khởi tạo dữ liệu) trước!");
                return false;
            }
            return true;
        }
        static void InitializePredefinedData(Member[][] groups)
        {
            groups[0][0] = new Member(101, "Nguyen Van A", 12);
            groups[0][1] = new Member(102, "Tran Thi B", 8);
            groups[0][2] = new Member(103, "Le Van C", 15);
            groups[0][3] = new Member(104, "Pham Minh D", 6);
            groups[0][4] = new Member(105, "Hoang Anh E", 20);

            groups[1][0] = new Member(201, "Vo Thi F", 18);
            groups[1][1] = new Member(202, "Dang Van G", 11);
            groups[1][2] = new Member(203, "Bui Thi H", 25);

            groups[2][0] = new Member(301, "Ngo Van I", 7);
            groups[2][1] = new Member(302, "Duong Thi K", 14);
            groups[2][2] = new Member(303, "Ly Van L", 19);
            groups[2][3] = new Member(304, "Doan Thi M", 22);
            groups[2][4] = new Member(305, "Trinh Van N", 10);
            groups[2][5] = new Member(306, "Mai Thi O", 16);
        }
        static void InputFromKeyboard(Member[][] groups)
        {
            for (int i = 0; i < groups.Length; i++)
            {
                Console.WriteLine($"\n--- NHẬP DỮ LIỆU NHÓM {i + 1} ({groups[i].Length} thành viên) ---");
                for (int j = 0; j < groups[i].Length; j++)
                {
                    Console.WriteLine($"* Thành viên {j + 1}:");
                    Console.Write("  ID: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.Write("  Họ tên: ");
                    string name = Console.ReadLine();
                    Console.Write("  Số công việc hoàn thành: ");
                    int tasks = int.Parse(Console.ReadLine());

                    groups[i][j] = new Member(id, name, tasks);
                }
            }
        }

        static void PrintAllMembers(Member[][] groups)
        {
            Console.WriteLine("\n================ DANH SÁCH THÀNH VIÊN ================");
            for (int i = 0; i < groups.Length; i++)
            {
                Console.WriteLine($"\n>>> NHÓM {i + 1} ({groups[i].Length} thành viên):");
                for (int j = 0; j < groups[i].Length; j++)
                {
                    Console.WriteLine($"  {j + 1}. {groups[i][j]}");
                }
            }
        }
        static void FindMemberById(Member[][] groups, int searchId)
        {
            for (int i = 0; i < groups.Length; i++)
            {
                for (int j = 0; j < groups[i].Length; j++)
                {
                    if (groups[i][j].Id == searchId)
                    {
                        Console.WriteLine("\n[TÌM THẤY THÀNH VIÊN]");
                        Console.WriteLine($"Thuộc Nhóm : {i + 1}");
                        Console.WriteLine($"Thông tin  : {groups[i][j]}");
                        return;
                    }
                }
            }
            Console.WriteLine($"\nKhông tìm thấy thành viên nào có ID = {searchId}.");
        }

        static void FindTopPerformer(Member[][] groups)
        {
            Member topMember = groups[0][0];
            int topGroup = 1;

            for (int i = 0; i < groups.Length; i++)
            {
                for (int j = 0; j < groups[i].Length; j++)
                {
                    if (groups[i][j].CompletedTasks > topMember.CompletedTasks)
                    {
                        topMember = groups[i][j];
                        topGroup = i + 1;
                    }
                }
            }

            Console.WriteLine("\n================ THÀNH VIÊN XUẤT SẮC NHẤT ================");
            Console.WriteLine($"Thuộc Nhóm                  : {topGroup}");
            Console.WriteLine($"Mã ID                       : {topMember.Id}");
            Console.WriteLine($"Họ và tên                   : {topMember.FullName}");
            Console.WriteLine($"Số công việc đã hoàn thành  : {topMember.CompletedTasks}");
            Console.WriteLine("==========================================================");
        }
    }
   

}
