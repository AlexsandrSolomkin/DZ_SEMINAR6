// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

//=================================================================================================================

//Решение:

// Console.WriteLine("Сколько чисел будет учавствовать в сравнении?");
// int num = int.Parse(Console.ReadLine()!);
// string numText = "Ведите число, которое хотите проверить, положительное оно или нет.";

// double[] numArray = CreateArray(num, numText);
// int plusElement = PlusElementCount(numArray, num);
// Console.WriteLine($"Положительных значений: {plusElement}");

// double[] CreateArray(int arrayLenght, string text){
//     double[] array = new double[arrayLenght];
//     for(int i = 0; i < arrayLenght; i++){
//         Console.WriteLine(text);
//         array[i] = double.Parse(Console.ReadLine()!);
//     }
//     return array;
// }

// int PlusElementCount(double[] array, int arrayLenght){
//     int count = 0;
//     for(int i = 0; i < arrayLenght; i++){
//         if (array[i] > 0){
//             count++;
//         }
//     }
//     return count;
// }

//=================================================================================================================