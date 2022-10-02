string[] createArray()
{
    string[] myArr = new string[0];           //задаем массив, пока пустой так как конечный размер его мы не знаем
    int c = 0;
    for (int i = 0; i < subs.Length; i++)              //бежим по исходному массиву 
    {
        if (subs[i].Length <= 3)                          //проверяем подстроки на лету 
        {
            Array.Resize(ref myArr, myArr.Length + 1);       //так как изначально массив-приемник пуст, то увеличиваем его значение на 1
            myArr[c] = subs[i];                              //копируем значение из одного массива в другой с правильным индексом в приемнике 
            c++;                                             //увеличиваем индес для приема
         }
     }
    return myArr;
}

void printArray(string[] array)
{
    if (array.Length == 0)
    {
      Console.Write("All string is too large!!!!");            //если все подстроки длиннее 3х симолов то ругаемся  
    }
    for (int i = 0; i < array.Length; i++) 
        Console.Write(array[i] + " ");
        Console.WriteLine();
}

if (args.Length == 0)
{
   Console.WriteLine("Enter string to parse:");     //получаем
   string str = Console.ReadLine();
   string[] subs = str.Split(' ');    //разделитель пробел 
   string[] newArray = createArray(subs);                        //вызываем метод который принимает ручной ввод и делает массив 
   printArray(newArray);
}
else
{
    string[] newArray = createArray(args);                        
    printArray(newArray);
}
