// Доп.Задача (Если вдруг не можете решить 43, либо хотите решить для интереса)

// Найти произведение всех элементов массива целых чисел, меньших заданного числа. Размерность массива – 10. Заполнение массива осуществить случайными числами от 50 до 100.

//========================================================================================================================================================================================

//Решение:

// int[] array = GetArray(10, 50, 100);
// Console.WriteLine(String.Join(", ", array));
// Console.WriteLine("Введите максимальное значение числа, которое будет являться границей для чисел учтенных при расчете произведения оных.\nЧисла в массиве от 50 до 100.");
// int num = int.Parse(Console.ReadLine()!);

// if((num < 49) || (num > 101)){
//     Console.WriteLine("Вы вышли за допустимые пределы значений массива!!!");
// }

// Console.WriteLine($"Произведение чисел, которые попали в диапозон от 50 до {num}, равно {Composition(array, num)}");

// double Composition(int[] arrayElement, int max){
//     double res = 1;
//     for(int i = 0; i < arrayElement.Length; i++){
//         if(arrayElement[i] < max){
//             res *= arrayElement[i];
//         }
//     }

//     if(res == 1){
//         res = 0;
//     }
//     return res;
// }

// int[] GetArray(int size, int minValue, int maxValue){
//     int[] res = new int[size];
//     for(int i = 0; i < size; i++){
//         res[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return res;
// }

//========================================================================================================================================================================================