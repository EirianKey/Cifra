string _dyrectory = "";
string _fileName = "Data.txt";
string _fullPath = "";
string _data = "";

_data = ReadFile ( );

while ( true ) 
{
    PrintData ( );
   string line = Console.ReadLine ();
    if ( line == "exit" )
    {
        break;
    }
    AppendData ( line );
    Console .Clear ( );
}
WriteDataToFile ( );

Console .ReadLine ( );

void AppendData(string data)
{
    _data += Environment .NewLine + data;
}

string ReadFile()
{
    _dyrectory = Directory .GetCurrentDirectory ( );//путь до экзе файла
    _dyrectory = new DirectoryInfo ( _dyrectory ) .Parent .Parent .Parent .FullName;//выйти по катологу на 3 уровня вверх
    _fullPath = Path .Combine ( _dyrectory , _fileName );//комбинировать путь +папка или +файл
    return File .ReadAllText ( _fullPath );//чтение файла и запись в стринг переменную
}

void PrintData()
{
    Console .WriteLine ( "DATA: \n" + Environment .NewLine + _data );
    Console .WriteLine ( "----------------------------------------" );
}
void WriteDataToFile()
{
    File .WriteAllText ( _fullPath , _data );//запись стринг данных в файл по пути _FullPath
    Console .WriteLine ( "Файл сохранен" );
}
