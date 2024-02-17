// Задача: Написать программу, которая из имеющегося массива
//  строк формирует новый массив из строк, длина которых меньше,
//   либо равна 3 символам. Первоначальный массив можно 
//   ввести с клавиатуры, либо задать на старте 
//   выполнения алгоритма. 

string[] matrix1 = { "ya", ":-)", "text", "yes", "no", "london", "wow" };
int symbol_quantity = 3;

string[] buildArrayOfShortWords(string[] matrix, int len)
{
    int count_short_words = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (matrix1[i].Length <= len)
        {
            count_short_words++;
        }
    }
    Console.WriteLine($"Количество слов с длиной символов не более {symbol_quantity} равно {count_short_words}");
    
    string[] matrix2 = new string[count_short_words];
    int j = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (matrix1[i].Length <= len)
        {
            matrix2[j] += matrix[i];
            j++;
        }
    }
    return matrix2;
}

Console.WriteLine($"Массив выбранных слов: [{string.Join(";", buildArrayOfShortWords(matrix1, symbol_quantity))}]");