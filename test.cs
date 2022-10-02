
if (args.Length == 0)                                       //проверяем командную строку и если она пуста
{                
    string[] newArray = createArray();                        //вызываем метод который принимает ручной ввод и делает массив 
    printArray(newArray);
}
