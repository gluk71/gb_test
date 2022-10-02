string[] createArray()
{
    Console.WriteLine("Enter string to parse:");     //получаем
    string str = Console.ReadLine();
    string[] subs = str.Split(' ');    //разделитель пробел 
    //Далее беьм строку на части и проверяем на нужное и в массив который и возвращаем
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

if (args.Length == 0)                                       //проверяем командную строку и если она пуста
{                
    string[] newArray = createArray();                        //вызываем метод который принимает ручной ввод и делает массив 
    printArray(newArray);
}
