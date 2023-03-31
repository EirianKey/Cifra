int [ ] _array = new int [10];
int [ ] _array2 = new int [5];
int [ ] _array3 = new int [3];

_array = FillArray ( _array.Length );
_array2 = FillArray ( _array2.Length );
_array3 = FillArray ( _array3.Length );

Console .WriteLine (Join(" - ", _array ));
Console .WriteLine ( Join ( " - " , _array2 ) );
Console .WriteLine ( Join ( " - " , _array3 ) );
Console .WriteLine ("Сумма 1 массива: "+ArraySum(_array));
Console .WriteLine ( "Сумма 1 массива: " + ArraySum ( _array2 ));
Console .WriteLine ( "Сумма 1 массива: " + ArraySum ( _array3 ));

Console .ReadLine ();
//PROGRAM END;

int ArraySum(int [ ] array)
{
    int result = 0;
    foreach (var item in array)
    {
        result += item;
    }
    return result;
}

int[] FillArray(int arrayLenght)
{
    int [] array = new int [arrayLenght];
    for (int i = 0 ; i < array.Length ; i++)
    {
        array[i] = new Random().Next(0,100);

    }
    return array;
}
string Join(string separator, int[]array)
{ 
    string result = "";
    foreach ( int item in array )
    {
        result += item + separator;
    }
    return result;
}
