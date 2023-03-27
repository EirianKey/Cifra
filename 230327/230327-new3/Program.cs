using _230327_new3;

string s = "Test variable";
int i = 123;

Extension .PrintVar ("Значение с", s );
Extension .PrintVar ( "Значение i", i );

try
{
    int sum = Extension.Sum(5,10);
}
catch(Exception exc)
{
    Console .WriteLine ( "Error: "+exc.Message );
}

Console.ReadLine();