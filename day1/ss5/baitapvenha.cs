using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT.ss5
{
    internal class baitapvenha
    {
        public static void Main(string[] args)
        {
            ex01(args);
        }
        static void ex01(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            
            int[] arr = GenerateRandomArray(10, 1, 20);

            Console.WriteLine("=== MẢNG BAN ĐẦU ===");
            PrintArray(arr);
            Console.WriteLine("\n-----------------------------------\n");

           
            double avg = CalculateAverage(arr);
            Console.WriteLine($"1. Giá trị trung bình: {avg:F2}");

            
            int searchValue = 10;
            bool contains = ContainsValue(arr, searchValue);
            Console.WriteLine($"2. Mảng có chứa {searchValue} không? {(contains ? "Có" : "Không")}");

          
            int target = arr[0];
            int index = FindIndex(arr, target);
            Console.WriteLine($"3. Chỉ số (index) của giá trị {target} là: {index}");

        
            int removeVal = arr[0];
            int[] arrAfterRemove = RemoveElement(arr, removeVal);
            Console.Write($"4. Mảng sau khi xóa phần tử {removeVal}: ");
            PrintArray(arrAfterRemove);

          
            var (min, max) = FindMinMax(arr);
            Console.WriteLine($"5. Giá trị nhỏ nhất (Min): {min}, Giá trị lớn nhất (Max): {max}");

            
            int[] reversedArr = ReverseArray(arr);
            Console.Write("6. Mảng sau khi đảo ngược: ");
            PrintArray(reversedArr);

            List<int> duplicates = FindDuplicates(arr);
            Console.Write("7. Các giá trị trùng lặp trong mảng: ");
            Console.WriteLine(duplicates.Count > 0 ? string.Join(", ", duplicates) : "Không có giá trị trùng lặp");

            int[] uniqueArr = RemoveDuplicates(arr);
            Console.Write("8. Mảng sau khi loại bỏ phần tử trùng lặp: ");
            PrintArray(uniqueArr);
        }

        static int[] GenerateRandomArray(int size, int minValue, int maxValue)
        {
            Random rand = new Random();
            int[] result = new int[size];
            for (int i = 0; i < size; i++)
            {
                result[i] = rand.Next(minValue, maxValue + 1);
            }
            return result;
        }

        static void PrintArray(int[] arr)
        {
            Console.WriteLine($"[{string.Join(", ", arr)}]");
        }

        static double CalculateAverage(int[] arr)
        {
            if (arr == null || arr.Length == 0) return 0;
            int sum = 0;
            foreach (int item in arr)
            {
                sum += item;
            }
            return (double)sum / arr.Length;
        }

        static bool ContainsValue(int[] arr, int value)
        {
            foreach (int item in arr)
            {
                if (item == value) return true;
            }
            return false;
        }

        static int FindIndex(int[] arr, int value)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == value) return i;
            }
            return -1;
        }

        static int[] RemoveElement(int[] arr, int value)
        {
            int count = 0;
            foreach (int item in arr)
            {
                if (item == value) count++;
            }

            int[] newArr = new int[arr.Length - count];
            int newIndex = 0;
            foreach (int item in arr)
            {
                if (item != value)
                {
                    newArr[newIndex++] = item;
                }
            }
            return newArr;
        }

        static (int min, int max) FindMinMax(int[] arr)
        {
            if (arr == null || arr.Length == 0)
                throw new ArgumentException("Mảng không được rỗng");

            int min = arr[0];
            int max = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min) min = arr[i];
                if (arr[i] > max) max = arr[i];
            }

            return (min, max);
        }
        static int[] ReverseArray(int[] arr)
        {
            int[] reversed = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                reversed[i] = arr[arr.Length - 1 - i];
            }
            return reversed;
        }

        static List<int> FindDuplicates(int[] arr)
        {
            HashSet<int> seen = new HashSet<int>();
            HashSet<int> duplicates = new HashSet<int>();

            foreach (int item in arr)
            {
                if (!seen.Add(item)) 
                {
                    duplicates.Add(item);
                }
            }

            return duplicates.ToList();
        }

        static int[] RemoveDuplicates(int[] arr)
        {
            HashSet<int> uniqueSet = new HashSet<int>(arr);
            return uniqueSet.ToArray();
        }
        static void ex02(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

         
            Console.WriteLine("=== CHƯƠNG TRÌNH 1: SẮP XẾP MẢNG (BUBBLE SORT) ===");
            int[] dataList = new int[10];

          
            for (int idx = 0; idx < 10; idx++)
            {
                Console.Write($"Nhập số thứ {idx + 1}: ");
                while (!int.TryParse(Console.ReadLine(), out dataList[idx]))
                {
                    Console.Write("Dữ liệu nhập không phải số. Vui lòng nhập lại: ");
                }
            }

            Console.Write("\nDữ liệu gốc: ");
            DisplayCollection(dataList);

          
            PerformBubbleSort(dataList);

            Console.Write("Dữ liệu sau sắp xếp: ");
            DisplayCollection(dataList);

            Console.WriteLine("\n--------------------------------------------------\n");

          
            Console.WriteLine("=== CHƯƠNG TRÌNH 2: TÌM KIẾM TỪ (LINEAR SEARCH) ===");

            Console.Write("Nhập đoạn văn bản: ");
            string inputSentence = Console.ReadLine();

            Console.Write("Nhập từ cần tra cứu: ");
            string keyword = Console.ReadLine();

        
            char[] punctuationChars = new char[] { ' ', ',', '.', '!', '?', ';', ':', '-' };
            string[] parsedWords = inputSentence.Split(punctuationChars, StringSplitOptions.RemoveEmptyEntries);

       
            int matchPosition = ExecuteLinearSearch(parsedWords, keyword);

            if (matchPosition != -1)
            {
                Console.WriteLine($"\n=> Kết quả: Từ \"{keyword}\" CÓ xuất hiện trong đoạn văn (tại vị trí thứ {matchPosition + 1}).");
            }
            else
            {
                Console.WriteLine($"\n=> Kết quả: Từ \"{keyword}\" KHÔNG có trong đoạn văn.");
            }
        }

    
        static void PerformBubbleSort(int[] collection)
        {
            int totalElements = collection.Length;

            for (int step = 0; step < totalElements - 1; step++)
            {
                bool hasSwapped = false;

                for (int pos = 0; pos < totalElements - 1 - step; pos++)
                {
                    if (collection[pos] > collection[pos + 1])
                    {
                      
                        int tempVal = collection[pos];
                        collection[pos] = collection[pos + 1];
                        collection[pos + 1] = tempVal;

                        hasSwapped = true;
                    }
                }

             
                if (!hasSwapped) break;
            }
        }
       
        static int ExecuteLinearSearch(string[] wordCollection, string searchTerm)
        {
            for (int index = 0; index < wordCollection.Length; index++)
            {
              
                if (string.Equals(wordCollection[index], searchTerm, StringComparison.OrdinalIgnoreCase))
                {
                    return index; 
                }
            }
            return -1; 
        }

    
        static void DisplayCollection(int[] items)
        {
            Console.WriteLine($"[{string.Join(", ", items)}]");
        }
    }

}

    


