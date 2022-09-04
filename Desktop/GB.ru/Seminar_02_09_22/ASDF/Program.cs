Console.WriteLine("ВВЕДИТЕ ЦЕЛОЕ трехзначное ЧИСЛО");
int a = Convert.ToInt32(Console.ReadLine());
int secondNumber = (a / 10) %10;
Console.WriteLine(secondNumber);
