/*Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.*/

string NewString = ReadString("Введите числа через запятую: ");
int size = 1;
char sim = ',';

for (int i = 0; i < NewString.Length; i++)
{
    if (NewString[i] == sim)
        size++;
}

int[] array = new int[size];
int j = 0;
string result = String.Empty;
for (int i = 0; i < NewString.Length; i++)
{
    int temp = 0;
    if (NewString[i] == sim)
    {
        temp = Convert.ToInt32(result);
        array[j] = temp;
        j++;
        result = String.Empty;
    }
    else
    {
        result = result + NewString[i];
    }
}
array[j] = Convert.ToInt32(result);

int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
        count++;
}
if (count == 0)
    Console.WriteLine($"Пользователь не ввел чисел больше 0");
if (count == 1)
    Console.WriteLine($"Пользователь  ввел {count} число больше 0");
if (count > 1 && count < 5)
    Console.WriteLine($"Пользователь  ввел {count} числа больше 0");
if (count > 4)
    Console.WriteLine($"Пользователь  ввел {count} чисел больше 0");

string ReadString(string message)
{
    Console.Write(message);
    return Console.ReadLine();
}
