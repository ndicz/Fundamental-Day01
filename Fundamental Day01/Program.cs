//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
    using System;

namespace Fundamental // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //---------------------------------NO 1 --------------------------//

            //Console.WriteLine("Masukan Angka: ");
            //string input = Console.ReadLine();
            //char[] numbers = input.ToCharArray();

            //int sum = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += Convert.ToInt32(numbers[i].ToString());
            //}

            //Console.WriteLine("Hasil Penjumlahan " + sum);


            //---------------------------------NO 2 --------------------------//

            //Console.WriteLine("Masukan Angka: ");
            //string input2 = Console.ReadLine();
            //char[] numbers2 = input2.ToCharArray();

            //int count = 0;

            //for (int i = 0; i < numbers2.Length; i++)
            //{
            //    count++;

            //}

            //Console.WriteLine("Hasil Count " + count);

            //---------------------------------NO 3 --------------------------//
            // Console.WriteLine("Masukan Angka: ");
            // string input3 = Console.ReadLine();
            // char[] numbers3 = input3.ToString().ToCharArray();
            // Array.Reverse(numbers3);
            // string spasireverse = string.Join(" ", numbers3);

            //Console.WriteLine(spasireverse);


            //---------------------------------NO 4 --------------------------//

            //int max = int.MinValue;

            //for (int i = 1; i > 0; i++)
            //{
            //    Console.Write("Masukkan angka: ");
            //    int input = Convert.ToInt32(Console.ReadLine());
            //    if (input == 0)
            //    {
            //        break;
            //    }
            //    if (input > max)
            //    {
            //        max = input;
            //    }
            //}
            //Console.WriteLine("Angka terbesar: " + max);


            //---------------------------------NO 5 --------------------------//

            //Console.Write("Masukkan bilangan: ");
            //int num = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= num; i++)
            //{
            //    if (num % i == 0)
            //    {
            //        Console.Write(i + " ");
            //    }



            //}

            //---------------------------------NO 6 --------------------------//

            //Console.Write("Masukkan batas atas bilangan prima: ");
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 2; i <= n; i++)
            //{
            //    if (Enumerable.Range(2, (int)Math.Sqrt(i) - 1).All(x => i % x != 0))
            //        Console.WriteLine(i);
            //}

            //---------------------------------NO 7 --------------------------//
            //Console.WriteLine("Masukkan Kalimat:");

            //string input = Console.ReadLine();
            //string[] words = input.Split(" ");
            //string[] output = words.Select(s => s.First() + new string('*', s.Length - 2) + s.Last()).ToArray();
            //string finalOutput = string.Join(" ", output);
            //Console.WriteLine(finalOutput);


            //---------------------------------NO 8 --------------------------//
            //var currentDay = DateTime.Now;
            //var daysUntilSaturday = ((int)DayOfWeek.Saturday - (int)currentDay.DayOfWeek + 7) % 7;
            //var nextSaturday = currentDay.AddDays(daysUntilSaturday);
            //Console.WriteLine("Hari Sabtu {0}", nextSaturday.ToString("dd/MM/yyyy"));
            //Console.WriteLine("{0} hari lagi", daysUntilSaturday);


            //---------------------------------NO 9 --------------------------//
            //Console.Write("Masukkan angka : ");
            //string text = Console.ReadLine();

            //Console.Write("Masukkan kombinasi angka yang ingin dicari: ");
            //string numberToSearch = Console.ReadLine();

            //int startIndex = text.IndexOf(numberToSearch);
            //int count = 0;
            //while (startIndex != -1)
            //{
            //    count++;
            //    startIndex = text.IndexOf(numberToSearch, startIndex + numberToSearch.Length);
            //}
            // Console.WriteLine($"Total Kata Yang Muncul {count} Dari Teks {text}" );

            //---------------------------------NO 10 --------------------------//

            //int[] numbers = new int[5];
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write("Masukkan angka ke-{0}: ", i + 1);
            //    numbers[i] = int.Parse(Console.ReadLine());
            //}
            //Array.Sort(numbers);
            //int secondGreatest = numbers[numbers.Length - 2];
            //Console.WriteLine("Second Greatest Number: {0}", secondGreatest);

            //---------------------------------NO 11 --------------------------//

            //Console.Write("Masukan Kurwal : ");
            //string inputan = Console.ReadLine();
            //Console.Write("Maka Hasilnya Adalah" + CheckKurawal(inputan));

            //---------------------------------NO 12 --------------------------//
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 10; j >= 5 + i; j--)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("====================================================");
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + i - 1 + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("====================================================");

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }

            for (int i = 3; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }


            Console.WriteLine("====================================================");
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5 - i; j++)
                {
                    Console.Write("  ");
                }
                for (int j = i; j >= 1; j--)
                {
                    Console.Write(j + " ");
                }
                for (int j = 2; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }

        public static bool CheckKurawal(string input)
        {
            int count = 0;
            foreach (var item in input)
            {
                if (item == '{')
                    count++;
                if (item == '}')
                    count--;
                if (count < 0)
                    return false;
            }
            return true;
        }
    }
}
