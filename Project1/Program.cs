using System;
using System.Collections.Generic;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] arr1 = new string[5]
            //    {
            //    "ogorek", "pomidor", "por", "seler", "marchew"
            //};
            //for (int i=0; i<arr1.length; i++)
            //{
            //    console.writeline(arr1[i]);
            //}

            //    for (int j = 1; j < 101; j++)
            //    {
            //        Console.WriteLine(j);
            //    }

            //Console.WriteLine("Podaj dlugosc tablicy");
            //string response = Console.ReadLine();
            //int n = int.Parse(response);
            //Console.WriteLine("O ile powiekszasz?");
            //string response2 = Console.ReadLine();
            //int z = int.Parse(response2);
            //int[] arr2 = new int[n];
            //for (int i=0;i<arr2.Length;i++)
            //{
            //    if(i>0)
            //    {
            //        arr2[i] += arr2[i - 1] + z;
            //    };
            //    Console.WriteLine();
            //}

            //if (n <= 1)
            //    return;

            //int previous = arr[0];
            //arr[0] = arr[0] + z;
            //for (int i=1;i<n;i++)
            //{
            //    int current = arr[i];
            //    arr[i] = previous
            //}

            //Console.WriteLine("Kiedy byl chrzest Polski?");
            //bool validAnwser = false;
            //while(!validAnwser)
            //{
            //    int answer = int.Parse(Console.ReadLine());
            //    if (answer==966)
            //    {
            //        Console.WriteLine("Propsik");
            //        validAnwser = true;
            //    }
            //}


            //for (int j=1;j  < 11;j++)
            //{
            //    Console.WriteLine($"Podaj liczbe { j}");
            //    int podanaliczba = int.Parse(Console.ReadLine());
            //}
            //Console.ReadLine();

            ////1 foreach
            //string[] arr1 = { "Jan", "Slawek", "Mietek", "Janusz", "Wojtek" };
            //foreach (string x in arr1)
            //{
            //    Console.WriteLine(x);
            //}

            ////2 foreach
            //int[] arr2 = { 1, 3, 5, 7, 8 };
            //foreach (int y in arr2)
            //{
            //    Console.WriteLine(y + 9);
            //}

            ////3 foreach
            //int[] arr3 = { 1, 5, 2, 7, 3 };
            //foreach (int z in arr3)
            //{
            //    if ((z + 5) % 12 == 0)
            //    {
            //        Console.WriteLine(z + 5);
            //    }
            //}


            //1 skoki v2
            //int[] ints = { 1, 2, 3, 4, 5 };
            //int szukana = 3;
            //for (int i = 0; i < ints.Length; i++)
            //{
            //    if (ints[i] == szukana)
            //    {
            //        Console.WriteLine($"szukana pod indeksem {i}");
            //        break;
            //    }

            //}

            //2 skoki
            //string[] strings = { "ee", "aa", "ee", "bb", "bb", "cc", "ee", "dd", "bb", "ee", "ff", "bb", "gg", "hh", "ii", "jj" };
            //Console.WriteLine("Czego szuaksz?");
            //string szukasz = Console.ReadLine();
            //int counter = 0;
            //for (int i=0;i<strings.Length;i++)
            //{

            //    if (strings[i] == szukasz)
            //    {
            //        counter++;
            //        Console.WriteLine($"Szukana znaleziona pod indexem {i}");
            //    }

            //    if (counter == 3)
            //    {
            //        break;
            //    }
            //}

            //3  skoki
            //    int Min = 10;
            //    int Max = 30;
            //    int[] arr1 = new int[100];
            //    var count = new Dictionary <int, int>();
            //    Random randomNumbers = new Random();
            //    for (int i = 0; i < arr1.Length; i++)
            //    {
            //        arr1[i] = randomNumbers.Next(Min, Max);
            //    }
            //    foreach (var value in arr1)
            //    {
            //        if (count.ContainsKey(value))
            //        {
            //            count[value]++;
            //        }
            //        else
            //        {
            //            count[value] = 1;
            //        }
            //    }
            //    foreach (var pair in count)
            //        Console.WriteLine("{0}", pair.Key);
            //    //Console.WriteLine("Value {0} occurred {1} times.", pair.Key, pair.Value);
            //    Console.ReadKey();

            //}
            //test
            ////arrange
            //MathOperations ops = new MathOperations();
            //int x = 5;
            //int y = 2;
            //int expectedResult = 7;

            ////action
            //int result = ops.Sub(x, y);

            ////assert
            //if (expectedResult == result)
            //{
            //    Console.WriteLine("Test przeszedl");
            //}
            //else
            //{
            //    Console.WriteLine("Test nie przeszedl");
            ////}

            //konstruktor do person
            //{
            //    Person osoba1 = new Person(Console.ReadLine(), Console.ReadLine());
            //    Person osoba2 = new Person(Console.ReadLine(), Console.ReadLine());

            //    osoba1.PrintName();
            //    osoba2.PrintName();
            //}

            ////test do sumy tablic
            //MathOps ops = new MathOps();
            //double[] arr = { 1, 5, 7, 2, 72 };
            //double result = ops.AddArr(arr);
            //Console.WriteLine(result);

            ////test do iloczynu
            //MathOps ops2 = new MathOps();
            //short[] arr1 = { 12, 2, 4, 10 };
            //short result1 = ops2.ImpArr(arr1);
            //Console.WriteLine(result1);

            //Rectangle prostokat = new Rectangle(2, 4);
            //int ppPR = prostokat.Pole();
            //int obwPR = prostokat.Obwod();
            //Console.WriteLine(obwPR);
            //Console.WriteLine(ppPR);

            //Square kwadrat = new Square(3, 3);
            //int ppKW = kwadrat.Pole();
            //int obwKW = kwadrat.Obwod();
            //Console.WriteLine(ppKW);
            //Console.WriteLine(obwKW);

            //Triangle trojkat = new Triangle(1, 1, 1, 7);
            //int obwTR = trojkat.Obwod();
            //int ppTR = trojkat.Pole();
            //Console.WriteLine(obwTR);
            //Console.WriteLine(ppTR);



            //person person1 = new person("jan", "tomala", new adress("polska", "krakow", "krupnicza", countries.croatia, cities.krakow));
            //console.writeline(person1._adress.countries);


            //employee person1 = new employee(new adress("polska", "wroclaw", "oporowska", countries.brazil, cities.split));
            //console.writeline(person1.adress.countries);

        }
    }
    }
