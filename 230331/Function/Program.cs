string _day = DateTime.Now.Day.ToString();
string _month = DateTime.Now.Month.ToString();
string _year = DateTime.Now.Year.ToString();

DateTime _finishDateTime = new DateTime(2023, 3, 31, 21, 20, 0);
int _seconds = 0;
DateTime _diffDateTime;

while (true)
{
    Console.Clear ();
    _seconds = AddSeconds (_seconds);
    Console .WriteLine ("День: " + _day);

    Console .WriteLine ( $"Месяц: {_month}" );

    Console .WriteLine ( $"Год: {_year}" );

    Console .WriteLine ($"Время: {GetHours ( )}:{GetMinutes(DateTime.Now)}:{GetSeconds(DateTime.Now)}");
    Console .WriteLine ($"Секунды: "+_seconds);
    _diffDateTime = new DateTime(_finishDateTime .Ticks - DateTime.Now.Ticks);
    Console .WriteLine ( $"Время до конца пары: {GetMinutes(_diffDateTime)}:{GetSeconds(_diffDateTime)}" ) ;
    Thread .Sleep (1000);
}

Console .ReadLine ();
//PROGRAM END

int AddSeconds( int seconds )
{
    return seconds + GetSeconds (DateTime.Now);
}
int GetSeconds(DateTime dateTimeParam)
{
    return dateTimeParam .Second;
}
int GetMinutes(DateTime dateTimeParam )
{
    return DateTime .Now .Minute;
}
int GetHours()
{
    return DateTime .Now .Hour;
}