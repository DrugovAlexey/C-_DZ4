// сумма цифр в числе


int lengthnumber(int arg)    
{
    int temporarynunber = arg;
    int lengthnunber = 0;
    while(temporarynunber > 0)
    {
        temporarynunber /= 10;
        lengthnunber += 1;
    }
    return lengthnunber;
}

int redin(string tex)
{
    Console.WriteLine(tex);
    string number = Console.ReadLine();
    int number2 = Convert.ToInt32(number);
    return number2;
}

int number2 = redin($"Введите число");
int c = lengthnumber(number2); //узнали количество цифр в числе

int x = number2;
int sum = 0;
while (x > c) // считаем сумму цифр в числе
{ 
    sum = sum + x%10;
    x = x/10;
}
System.Console.WriteLine(sum);
