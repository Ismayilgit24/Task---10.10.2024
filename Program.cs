//using System.Globalization;

//namespace Task
//{
//	internal class Program
//	{
//		static void Main(string[] args)
//		{
//			int[] array = { 1, 2, 3, 4, 5 };
//			ArrayExample(ref array, 10, 11, 12, 13, 15);


//		}


//		public static void ArrayExample(ref int[] array, params int[] nums)
//		{
//			int[] newArr = new int[array.Length + nums.Length];

//			for (int i = 0; i < array.Length; i++)
//			{
//				newArr[i] = array[i];

//			}


//			for (int i = 0; i < nums.Length; i++)
//			{
//				newArr[array.Length + i] = nums[i];

//			}
//			for (int i = 0; i < newArr.Length; i++)
//			{
//				Console.WriteLine(newArr[i]);
//			}


//		}

//	}
//}

using System;

class Program
{
	static void Main()
	{
		int number = 100;
		DisplayNumber(in number);  // 'in' açar sözü ilə arqument ötürülür
	}

	static void DisplayNumber(in int value)
	{
		value = 200;  // Bu səhv verəcək, çünki 'in' arqument dəyişdirilə bilməz
		Console.WriteLine($"Dəyər: {value}");  // Sadəcə oxumaq olar
	}
}
