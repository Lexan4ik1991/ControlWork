/* Написать программу, которая из имеющегося массива строк формирует массив из строк, длина
которых меньше либо равна 3 символа */

string [] numbers1 = new string[5] { "1237", "223", "34", "4", "5886" };
string[] numbers2 = new string[numbers1.Length];

void FindNumber(string[] numbers1, string[] numbers2)
{
    int count = 0;
    for (int i = 0; i < numbers1.Length; i++)
    {
    if(numbers1[i].Length <= 3)
        {
        numbers2[count] = numbers1[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

PrintArray(numbers1);
FindNumber(numbers1, numbers2);
PrintArray(numbers2);
