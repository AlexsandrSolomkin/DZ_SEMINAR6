// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

//========================================================================================================================================================================================

//Решение:

// Console.WriteLine("y = k1 * x + b1\nДанные по первой прямой b1: ");
// double b1 = double.Parse(Console.ReadLine()!);

// Console.WriteLine("y = k1 * x + b1\nДанные по первой прямой k1: ");
// double k1 = double.Parse(Console.ReadLine()!);

// Console.WriteLine("y = k2 * x + b2\nДанные по второй прямой b2: ");
// double b2 = double.Parse(Console.ReadLine()!);

// Console.WriteLine("y = k2 * x + b2\nДанные по второй прямой k2: ");
// double k2 = double.Parse(Console.ReadLine()!);

// double xCoor = СoordinatesX(b1, k1, b2, k2);

// Console.WriteLine($"Координаты точки пересечения двух прямых, равны: ({Math.Round(xCoor, 1)}; {Math.Round(СoordinatesY(b1, k1, xCoor), 1)})");

// double СoordinatesX(double bFirst, double kFirst, double bSecond, double kSecond){
//     double x = 1;
//     double res1 = kFirst * x + bFirst;
//     double res2 = kSecond * x + bSecond;
//     double res = res1 - res2;
//     while((res > 0.1) || (res < -0.1)){
        
//         if(res1 > res2){
//             x = x + 0.1;
//         } else {
//             x = x - 0.1;
//         }

//         res1 = kFirst * x + bFirst;
//         res2 = kSecond * x + bSecond;
//         res = res1 - res2;
//     }
//     return x;
// }

// double СoordinatesY(double bFirst, double kFirst, double x){
//     double y = kFirst * x + b1;
//     return y;
// }

//========================================================================================================================================================================================