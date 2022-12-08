Boolean flag = true;
int num = 0;

//Вызов метода ввода 
vvod();
// Вызов checkPalindrom
checkPalindrom(num);

//Метод проверки на количество введенных цифр
int vvod()
{

    while (flag == true)
    {
        Console.WriteLine("Введите 5 цифр: ");
        num = Convert.ToInt32(Console.ReadLine());

        if (num < 100000 && num >= 10000) flag = !flag;
        else Console.WriteLine("Вы ввели не 5 цифр, пробуйте снова!");
    }
    return num;
}

//Метод проверки палиндрома
void checkPalindrom(int num)
{
    int[] masNum = new int[5];
    int g = num;

    for (int i = masNum.Length - 1; i >= 0; i--)
    {
        masNum[i] = g % 10;
        g = g / 10;
    }

    for (int i = 0, j = masNum.Length - 1; i <= masNum.Length / 2; i++, j--)
    {
        if (masNum[i] != masNum[j])
        {
            Console.WriteLine("Это не палиндром");
            break;
        }
        else if (i == masNum.Length / 2)
        {
            Console.WriteLine("Это палиндром");
        }
    }
}