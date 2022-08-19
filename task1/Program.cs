// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]
// 1 способ. Массив задается рандомно 

//  int [] array = new int [8];

//  int FillArray(int [] array)
//  {
//      int length = array.Length;
//      for ( int i  = 0; i < length; i++ )
//      {
//        array[i] = new Random().Next(0,10);
//     }
//      return length;
//    }
//  void PrintArray(int[] arr)
//  {
//      int count = arr.Length;
//      for( int j = 0; j < count; j++ )
//      {
//          Console.WriteLine(arr[j]);
//      }
//  }

// FillArray(array);
// PrintArray(array);

// 2 способ
 int [] array = new int [8];

 int FillArray(int [] array)
 {
     int length = array.Length;
     for ( int i  = 0; i < 8; i++ )
     {
       
        Console.WriteLine($"Введите {i+1} элементов массива: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
     }
     return length;
 }
 FillArray(array);
 Console.WriteLine(string.Join(",",array));
