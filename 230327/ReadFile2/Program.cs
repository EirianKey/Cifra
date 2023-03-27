using System .Linq;

string _dyrectory = "";
string _fileName = "Data.txt";
string _fullPath = "";
List<string> _data = new List<string>();//массив строк

_data = ReadFile ( );

while ( true )
{
    PrintData ( );
    string line = Console.ReadLine ();
    if ( line == "exit" )
    {
        break;
    }
    if (line == "remove")
    {
        Console .WriteLine ("Какую строку удаляем? (номер от нуля): ");
        int lineNumber = int.Parse(Console.ReadLine ());
        _data.RemoveAt(lineNumber);
        continue;
    }
    AppendData ( line );
    Console .Clear ( );
}
WriteDataToFile ( );

Console .ReadLine ( );

void AppendData ( string data )
{
    _data.Add(data);
}

List<string> ReadFile ( )
{
    _dyrectory = Directory .GetCurrentDirectory ( );//путь до экзе файла
    _dyrectory = new DirectoryInfo ( _dyrectory ) .Parent .Parent .Parent .FullName;//выйти по катологу на 3 уровня вверх
    _fullPath = Path .Combine ( _dyrectory , _fileName );//комбинировать путь +папка или +файл
    return File .ReadAllLines ( _fullPath ).ToList();//чтение файла и запись в стринг переменную
}

void PrintData ( )
{
    Console .WriteLine ( "DATA:" );
    Console .WriteLine ( string .Join ( Environment .NewLine, _data ) );
    Console .WriteLine ( "----------------------------------------" );
}
void WriteDataToFile ( )
{
    File .WriteAllLines ( _fullPath , _data );//запись стринг данных в файл по пути _FullPath
    Console .WriteLine ( "Файл сохранен" );
}

