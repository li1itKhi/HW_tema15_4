Random random = new Random();

//массив 1 и 2, подсчет среднего арифметического

int[]arr=new int[2]; //инициализация массива с размерностью 2 по условию задачи.

for(int i=0; i<arr.Length; i++) 
{
    arr[i] = random.Next(1, 101); //заполнение массива

    Console.Write(arr[i]+" "); //вывод
}
Console.WriteLine(); 

int[] arr2 = new int[2]; 

for (int i = 0; i < arr2.Length; i++)
{
    arr2[i] = random.Next(1, 101); //заполнение 2 массива

    Console.Write(arr2[i] + " "); //вывод
}
Console.WriteLine();

Console.Write("Среднее арифметическое 1 и 2 массива: ");

double []arr_result=new double[2]; //создаем массив типа double для записи среднего арифметического 1 и 2 массива

for(int i=0; i < arr_result.Length; i++)
{
    arr_result[i] = (arr[i] + arr2[i])/2;

    Console.Write(arr_result+" "); //вывод результата
}

Console.WriteLine();

//массив 3 и 4, подсчет среднего арифметического

int[] arr3 = new int[2]; //инициализация массива с размерностью 2 по условию задачи.

for (int i = 0; i < arr3.Length; i++)
{
    arr3[i] = random.Next(1, 101); //заполнение 3 массива

    Console.Write(arr3[i] + " "); //вывод
}
Console.WriteLine();

int[] arr4 = new int[2];

for (int i = 0; i < arr4.Length; i++)
{
    arr4[i] = random.Next(1, 101); //заполнение 4 массива

    Console.Write(arr4[i] + " "); //вывод
}
Console.WriteLine();

Console.Write("Среднее арифметическое 3 и 4 массива: ");

double[] arr_result2 = new double[2]; //создаем массив типа double для записи среднего арифметического 3 и 4 массива

for (int i = 0; i < arr_result2.Length; i++)
{
    arr_result2[i] = (arr3[i] + arr4[i]) / 2;

    Console.Write(arr_result2 + " "); //вывод результата
}

Console.WriteLine();

//создаем еще один массив, который будет хранить в себе результат произведения arr_result и arr_result2

double[] result_mult=new double[2];

Console.WriteLine("Произведение средних 2-х массивов: ");

for (int i=0; i<result_mult.Length; i++)
{
    result_mult[i] = arr_result[i] * arr_result2[i];

    Console.WriteLine(result_mult[i]+" ");
}