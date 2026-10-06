using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT.ss7
{
    internal class baitapvenha
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Nhập chuỗi chính: ");
            string str = Console.ReadLine();
            Console.WriteLine($"-> Chuỗi vừa nhập: {str}");
            Console.WriteLine("----------------------------------");

            int length = GetLength(str);
            Console.WriteLine($"2. Độ dài của chuỗi: {length}");
            Console.WriteLine("----------------------------------");

            Console.Write("3. Các ký tự trong chuỗi: ");
            foreach (char c in str)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine("\n----------------------------------");

            Console.Write("4. Chuỗi đảo ngược: ");
            for (int i = length - 1; i >= 0; i--)
            {
                Console.Write(str[i]);
            }
            Console.WriteLine("\n----------------------------------");

            int wordCount = CountWords(str);
            Console.WriteLine($"5. Tổng số từ trong chuỗi: {wordCount}");
            Console.WriteLine("----------------------------------");

            Console.Write("Nhập chuỗi thứ 2 để so sánh: ");
            string str2 = Console.ReadLine();
            bool isEqual = CompareStrings(str, str2);
            Console.WriteLine($"6. Hai chuỗi {(isEqual ? "GIỐNG" : "KHÁC")} nhau.");
            Console.WriteLine("----------------------------------");

            CountTypes(str, out int alphabets, out int digits, out int specials);
            Console.WriteLine($"7. Chữ cái: {alphabets} | Chữ số: {digits} | Ký tự đặc biệt: {specials}");
            Console.WriteLine("----------------------------------");

            CountVowelsConsonants(str, out int vowels, out int consonants);
            Console.WriteLine($"8. Nguyên âm: {vowels} | Phụ âm: {consonants}");
            Console.WriteLine("----------------------------------");

            Console.Write("Nhập 1 ký tự để kiểm tra chữ cái & kiểu chữ: ");
            char ch = Console.ReadKey().KeyChar;
            Console.WriteLine();
            CheckCharacterCase(ch);
            Console.WriteLine("----------------------------------");

            Console.Write("Nhập chuỗi con (substring) để xử lý: ");
            string subStr = Console.ReadLine();

            int pos = FindSubstringIndex(str, subStr);
            Console.WriteLine($"9. Chuỗi con {(pos != -1 ? "CÓ" : "KHÔNG")} xuất hiện trong chuỗi.");

            if (pos != -1)
                Console.WriteLine($"10. Vị trí xuất hiện đầu tiên của chuỗi con: {pos}");
            else
                Console.WriteLine("10. Không tìm thấy vị trí của chuỗi con.");

            int occurrences = CountSubstringOccurrences(str, subStr);
            Console.WriteLine($"12. Số lần chuỗi con xuất hiện: {occurrences}");

            Console.Write("Nhập chuỗi cần chèn thêm: ");
            string toInsert = Console.ReadLine();
            string newStr = InsertBeforeFirstOccurrence(str, subStr, toInsert);
            Console.WriteLine($"13. Chuỗi sau khi chèn: {newStr}");

            Console.ReadLine();
        }
        static int GetLength(string s)
        {
            int count = 0;
            foreach (char c in s)
            {
                count++;
            }
            return count;
        }

        static int CountWords(string s)
        {
            int count = 0;
            bool inWord = false;

            foreach (char c in s)
            {
                if (c != ' ' && c != '\t' && c != '\n')
                {
                    if (!inWord)
                    {
                        count++;
                        inWord = true;
                    }
                }
                else
                {
                    inWord = false;
                }
            }
            return count;
        }

        static bool CompareStrings(string s1, string s2)
        {
            if (GetLength(s1) != GetLength(s2)) return false;

            for (int i = 0; i < GetLength(s1); i++)
            {
                if (s1[i] != s2[i]) return false;
            }
            return true;
        }

        static void CountTypes(string s, out int alphabets, out int digits, out int specials)
        {
            alphabets = digits = specials = 0;
            foreach (char c in s)
            {
                if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
                    alphabets++;
                else if (c >= '0' && c <= '9')
                    digits++;
                else if (c != ' ' && c != '\t' && c != '\n')
                    specials++;
            }
        }

        static void CountVowelsConsonants(string s, out int vowels, out int consonants)
        {
            vowels = consonants = 0;
            foreach (char c in s)
            {
                char lowerC = (c >= 'A' && c <= 'Z') ? (char)(c + 32) : c;
                if (lowerC >= 'a' && lowerC <= 'z')
                {
                    if (lowerC == 'a' || lowerC == 'e' || lowerC == 'i' || lowerC == 'o' || lowerC == 'u')
                        vowels++;
                    else
                        consonants++;
                }
            }
        }
        static void CheckCharacterCase(char c)
        {
            if (c >= 'A' && c <= 'Z')
                Console.WriteLine($"Ký tự '{c}' LÀ chữ cái và là CHỮ IN HOA.");
            else if (c >= 'a' && c <= 'z')
                Console.WriteLine($"Ký tự '{c}' LÀ chữ cái và là chữ in thường.");
            else
                Console.WriteLine($"Ký tự '{c}' KHÔNG PHẢI là chữ cái.");
        }

        static int FindSubstringIndex(string s, string subStr)
        {
            int lenS = GetLength(s);
            int lenSub = GetLength(subStr);

            if (lenSub == 0 || lenSub > lenS) return -1;

            for (int i = 0; i <= lenS - lenSub; i++)
            {
                bool match = true;
                for (int j = 0; j < lenSub; j++)
                {
                    if (s[i + j] != subStr[j])
                    {
                        match = false;
                        break;
                    }
                }
                if (match) return i;
            }
            return -1;
        }

        static int CountSubstringOccurrences(string s, string subStr)
        {
            int lenS = GetLength(s);
            int lenSub = GetLength(subStr);
            if (lenSub == 0 || lenSub > lenS) return 0;

            int count = 0;
            for (int i = 0; i <= lenS - lenSub; i++)
            {
                bool match = true;
                for (int j = 0; j < lenSub; j++)
                {
                    if (s[i + j] != subStr[j])
                    {
                        match = false;
                        break;
                    }
                }
                if (match)
                {
                    count++;
                    i += lenSub - 1; 
                }
            }
            return count;
        }
        static string InsertBeforeFirstOccurrence(string str, string subStr, string toInsert)
        {
            int pos = FindSubstringIndex(str, subStr);
            if (pos == -1) return str; 

            string result = "";

            for (int i = 0; i < pos; i++)
                result += str[i];

            result += toInsert;

            for (int i = pos; i < GetLength(str); i++)
                result += str[i];

            return result;
        }
    }
}
