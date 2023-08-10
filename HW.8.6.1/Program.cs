using System;
using System.IO;
//В заданиях использую диск H, так как на нем расположены все файлы по обучению
try
{
    DirectoryInfo dirInfo = new DirectoryInfo(@"1111");
    dirInfo.Delete(true); // Удаление со всем содержимым
    Console.WriteLine("Каталог удален");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}