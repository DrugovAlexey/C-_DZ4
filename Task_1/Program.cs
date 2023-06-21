int redin(string tex)
{
    Console.WriteLine(tex);
    string number = Console.ReadLine();
    int number2 = Convert.ToInt32(number);
    return number2;
}
int redin1(string tex1)
{
    Console.WriteLine(tex1);
    string number1 = Console.ReadLine();
    int number3 = Convert.ToInt32(number1);
    return number3;
}
int number2 = redin($"Введите число 1");
int number3 = redin1($"Введите число 2");

int Resalt(int number)
{

int index = 1;
int res = number2;

while(index < number3)
{
    res = res * number2;
    index++;
}
return res;
}

int res = Resalt(number3);




Console.Write(res);
