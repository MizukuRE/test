/*
Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.
*/

void ShowArray(string[] array) {
    Console.Write("[");

    for (int i = 0; i < array.Length; i++) {
        Console.Write(array[i]);
        if (i != array.Length - 1)
            Console.Write(", ");
    }

    Console.Write("]");
    Console.WriteLine("");
}

string[] filterArray(string[] array) {
    int size = 0;
    for (int i = 0; i < array.Length; i++) {
        if (array[i].Length <= 3)
            size++;
    }

    string[] filtredArr = new string[size];
    size = 0;
    for (int i = 0; i < array.Length; i++) {
        if (array[i].Length <= 3) {
            filtredArr[size] = array[i];
            size++;
        }
    }

    return filtredArr;
}

string[] array = { "Hello", "2", "world", ":-)" };
ShowArray(array);
string[] filtredArray = filterArray(array);
ShowArray(filtredArray);
