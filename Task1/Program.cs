//Пользователь вводит с клавиатуры М чисел. Написать программу, которая
// считает сколько из них больше 0.

Task_1();

void Task_1()
{
  int sum = 0;

  for (int i = 0; i < 5; i++)
  {
    int a = ReadInt("Введите число");

    if (a > 0)
    {
    GetSumPositiveNumbers(a);
    sum++;
    }
  }
  Console.WriteLine($"Количество введенных положительных чисел равно: {sum}");
}

int ReadInt(string argument)        
{                                    
  Console.Write($"{argument}: ");
  int number;

  while (!int.TryParse(Console.ReadLine(), out number)) 
  {
      Console.WriteLine("Error! Try again.");          
  }

  return number;                                        
}

void GetSumPositiveNumbers(int number)        
{ 
    if (number > 0)
    { 
      Console.WriteLine($" {number} - Положитльное число!");
    }
    else
    {
      Console.WriteLine($" {number} - Отрицательное число!");
    }
    
}