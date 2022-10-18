// Решение 

string [] array = {"Hello", "2", "world", ":-)"};
int index = 0;
int n = array.Length;
string width = "   ";
string find = width;

while (index < n)
{
    if (array [index] == find)
    {
        Console.WriteLine(array [index]);
        return;
    }
    index++;
}

Console.WriteLine("Такое значение отсутствует");
