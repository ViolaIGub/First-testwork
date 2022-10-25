// Решение 

using static System.Console;
Write("Введите размер массива, минимальное и максимальное значения через пробел ");
int[] parameters = GetParams(ReadLine());
int[] baseArray = GetArrayFromString(parameters[0], parameters[1], parameters[2]);
WriteLine(String.Join(" ", baseArray));
int count = FindSize(baseArray, 100, 999);
WriteLine(count);
int[] newArray = GetNewArray(count, 100, 999);
WriteLine(String.Join(" ", newArray));

int [] GetParams(string inStrung)
{
    string[] param = inStrung.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] result = new int[param.Length];
    for(int i = 0; i < param.Length; i++)
    {
        result[i] = int.Parse(param[i]);
    }
    return result;
}

int [] GetArrayFromString(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for(int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue,maxValue+1);         
    }
    return res;
}

int FindSize(int[] baseArray, int left, int right)
{
    int resalt = 0;
    for(int i = 0; i < baseArray.Length; i++)
    {
        if (baseArray[i] >= left && baseArray[i] <= right)
        {
            resalt++;
        }
    }
    return resalt;
}

int [] GetNewArray(int count, int left, int right)
{
    int[] solution = new int[count];
    for(int i = 0; i < count; i++)
    {
        solution[i] = baseArray[i];
    }
    return solution;
}
