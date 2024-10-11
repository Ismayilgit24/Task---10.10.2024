//using System.Globalization;

//namespace Task
//{
//	internal class Program
//	{
//		static void Main(string[] args)
//		{
//			int[] array = { 1, 2, 3, 4, 5 };
//			CustomResize(ref array, 10, 11, 12, 13, 15);


//		}


//		public static void CustomResize(ref int[] array, params int[] nums)
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
