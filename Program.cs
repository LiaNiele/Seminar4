// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

void Degree(int a, int b){
    int result = 1;
    for(int curr = 1; curr<=b; curr++){                 //счетчик от 1 до b. умножаем число а на результат b количество раз 
        result = result * a;
    }
    Console.WriteLine($"А в степени В равно {result}");
}

Console.WriteLine("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());
Degree(a,b);



// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

void Number(int num){
    
    int count = Convert.ToString(num).Length;                   //вводим счетчик, равный количеству символов в строке
    int cut = 0;                                                //промежуточная переменная
    int result = 0;                                             //результат сложения цифр в числе

    for (int i = 0; i < count; i++){                           
        cut = num - num % 10;                                  
        result = result + (num - cut);                          // находим крайнюю правую цифру, записываем ее в сумму
        num = num / 10;                                         //далее отсекаем ее и повторяем цикл
    }
    Console.WriteLine($"Сумма цифр в числе равна {result}");
}
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Number(num);



// Напишите программу, которая задаёт массив из произвольного элементов и выводит их на экран.


int[] CreateArray(int size){                    //программа,создающая массив из рандомных чисел от 0 до 99
    int[] array = new int[size];
    for (int i=0; i < size; i++){
        array[i] = new Random().Next(0,100);
    }
    return array;
}

void ShowArray(int[] array){                    //функция вывода массива на экран
    Console.Write("[ ");
    for(int i=0; i<array.Length; i++){
        Console.Write(array[i]+" ");
    }
    Console.Write("]");
}

int size = new Random().Next(1,11);             //размер массива задается случайно от 1 до 10
Console.WriteLine($"Кол-во элементов массива: {size}");
ShowArray(CreateArray(size));






