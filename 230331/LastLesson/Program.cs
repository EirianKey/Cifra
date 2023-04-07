

using LastLesson;

//Number numberClass = new Number();
//Number numberClass2 = new Number();
//numberClass .Value = 12;

//numberClass2 .ReadText ( );

//numberClass2 .ReadValue ( );
User[] users = new User[10];

for (int i = 0; i < users.Length; i++)
{
    users[i] = new User();
    users [ i ] .Create ( );
}
users [ 2 ] .Name = "";

PrintUsers ( );
TrimUsers ( );
Console .WriteLine ("_-_-_-_-_-_-_-_-_-_-_-");
users [ 0 ] .PrintAgeDifference(users);

Console .ReadKey();



void PrintUsers()
{
    for ( int i = 0 ; i < users .Length ; i++ )
    {
        Console .WriteLine ( "Имя: " + users [ i ] .Name + " Фамилия: " + users [i].Surname+ " Возраст: " + users [ i ] .Age );
        if ( users [i].Validate() == false ) 
        {
            Console .Write ( "    -- Не корректно" );
        }
    }

}

void TrimUsers()
{
    for ( int i = 0 ; i < users .Length ; i++ )
    {
        users [ i ] .Trim ( );
    }

}