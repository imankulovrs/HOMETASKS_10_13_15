Console.WriteLine("ВВЕДИТЕ ЦЕЛОЕ  ЧИСЛО");
string number = Console.ReadLine();

if(number.Length >= 3){
int newNumber = Convert.ToInt32(number.Substring(0, 3));
int thirdNumber = newNumber % 10;
Console.WriteLine(thirdNumber);
} else {
    Console.WriteLine("Третьей цифры нет");
}
