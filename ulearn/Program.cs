/*
 * Создано в SharpDevelop.
 * Пользователь: 1
 * Дата: 04.07.2018
 * Время: 9:36
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;

namespace ulearn
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("enter time");
			int hour;
				//int.Parse(Console.ReadLine());
				while (!int.TryParse(Console.ReadLine(),out hour)||(hour>24||hour<0))
			{
				Console.WriteLine("try again");
				//hour = int.Parse(Console.ReadLine());
					
			}
			if (hour>12)
			{
				hour=-12;
				
			}
			Console.WriteLine("gradien: "+hour*30);
			
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}