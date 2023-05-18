using System;

class Program
{
  static void Main(string[] args)
  {
    int road_size = int.Parse(Console.ReadLine());
    int range = int.Parse(Console.ReadLine());
    int[] road = new int[road_size];
    Input(ref road);
    Console.WriteLine(Sort(road, range));
  }

  static void Input(ref int[] road)
  {
    for (int i = 0; i < road.Length; i++)
    {
      road[i] = int.Parse(Console.ReadLine());
    }
  }

  static int Sort(int[] road, int range)
  {
    int max = 0;
    int temp = 0;
    for (int i = range; i < road.Length - range; i++)
    {
      temp = road[i];
      for (int j = 1; j <= range; j++)
      {
        temp = temp + road[i - j] + road[i + j];
      }
      max = FindMax(temp, max);
    }
    return max;
  }

  static int FindMax(int a, int b)
  {
    if (a > b)
    {
      return a;
    }
    return b;
  }
}