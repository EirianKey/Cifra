using System .Text;

string _line;
StringBuilder _valueStringBilder = new StringBuilder();
float _value = 0;

//ввод
Console.WriteLine("Vvedite stroku");
_line = Console.ReadLine();
//обработка
ParseLine (true);
if ( _valueStringBilder.Length == 0)
{
    Console.WriteLine("Error. Number is not found");
}
else
{
    _value = float.Parse(_valueStringBilder.ToString());
}

//вывод
Console.WriteLine("Number = " + _value);

void ParseLine(bool exitOnFirstLetter)
{
    for ( int i = 0 ; i < _line .Length ; i++ )
    {
        char letter = _line[i];
        if ( char .IsDigit ( letter ) )
        {
            _valueStringBilder .Append ( letter );
            continue;
        }
        else if ( letter == '.' || letter == ',' )
        {
            _valueStringBilder .Append ( ',' );
            continue;
        }
        if ( exitOnFirstLetter ) return;
    }
}