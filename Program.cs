using System;
using System.Collections.Generic;

namespace test_pull_request
{
  class Program
  {
    static void Main(string[] args)
    {
      TestArray();
      //   TestList();
      //   TestQuiz();
      TestQuiz2();
    }

    static void TestQuiz2()
    {
      Console.WriteLine("Umur kamu berapa?");
      int umur = int.Parse(Console.ReadLine());

      Console.WriteLine(
          umur < 17
              ? "kamu masih bocah"
              : (umur < 32 ? "kamu sudah dewasa" : "kamu sudah tua")
      );
    }

    static void TestQuiz()
    {
      string soal = "mobil";
      string jawaban = "car";

      Console.WriteLine("apa bahasa inggrisnya {0}?", soal);
      string jawab = Console.ReadLine();
      Console.WriteLine(
          jawab == jawaban ? "kamu Benar" : "kamu salah, jawabannya adalah \"{0}\"",
          jawaban
      );
    }

    static void TestList()
    {
      List<string> listKata = new List<string>();
      listKata.Add("kaki");
      listKata.Add("kaku");
      listKata.AddRange(new string[] { "kamu", "kamu", "aku" });

      string inputKata = Console.ReadLine();

      if (listKata.Contains(inputKata))
      {
        Console.WriteLine("ketemu");
      }
      else
      {
        Console.WriteLine("gak ketemu");
      }
    }

    static void TestArray()
    {
      string kata = "01234567";
      string[] huruf = new string[kata.Length]; // ["", "", "", "", "", ...]
      huruf[0] = "a";
      huruf[1] = "";
      huruf[3] = "a";
      huruf[4] = "a";

      Console.WriteLine("{0} {1}", kata.Length, huruf.ToString());
      foreach (var item in huruf)
      {
        Console.Write(item);
      }
      Console.Write("\n");
    }
  }
}
