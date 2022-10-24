// Решение 

using static System.Console;
Write("Введите размер массива, минимальное и максимальное значения через пробел ");
int[] parameters = GetParams(ReadLine());
int[] baseArray = GetArrayFromString(parameters[0], parameters[1], parameters[2]);

int [] GetParams(string inString);
{
    string[] param = inString.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] result = new int[inString.Length];
    for(int i = 0; i < inString.Length; i++)
    {
        result[i] = int.Parse(param[i]);
    }
    return result;
}

int [] GetArrayFromString(int size, int minValue, int maxValue);
{
    int[] res = new int[size];
    for(int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue,maxValue+1);
        if(res[i] >= 100 && res[i] <= 999)
        {
            WriteLine(res[i]);
        }
    }
    return res;
}





// string[] array = { "Hello", "2", "world", ":-)" };
// int index = 0;
// int n = array.Length;
// string width = "   ";
// string find = width;

// while (index < n)
// {
    // if (array[index] == find)
    // {
       //  WriteLine(array[index]);
        // return;
   // }
    // index++;
// }

// WriteLine("Такое значение отсутствует");
