Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

//Вызываем метод генерации массива кубов
int[] arrayN = genArrayCub(N);
//Вызываем метод печати массива
printArray(arrayN);

//генерируем массив кубов
int[] genArrayCub(int N)
{
    int[] number = new int[N];
    for (int i = 0, j = 1; i < N; i++, j++)
    {
        number[i] = (int)Math.Pow(j, 3);
    }
    return number;
}

//Печатаем массив
void printArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write(array[i]);
        else Console.Write(", " + array[i]);
    }
    Console.Write("]");
}