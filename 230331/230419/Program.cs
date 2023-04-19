
//int [ ] mas = new int [12];
//Random r = new Random();
//int S = 0;
//for ( int i = 0 ; i < mas.Length ; i++ )
//{
//    mas [ i ] = r .Next ( 10 , 100 );
//    Console.Write ($" {mas [ i ]:F2} " );
//    S+= mas [ i ];
//}
//Console .WriteLine ();
//Console .WriteLine ($"S={S:F2}");

//В массиве хранится информация о численности учеников в каждом из
//42 классов школы.Выяснить, верно ли , что общее число учеников в
//школе есть четырехзначное число.

using System .Globalization;
using System .Runtime .InteropServices .ObjectiveC;

//int [ ] clas = new int [42];
//Random p = new Random();
//int Sum = 0;

//for ( int i = 0 ; i < clas.Length ; i++ )
//{
//    clas [i] = p .Next ( 10 , 30 );
//    Console .Write ( $"{clas [i]} ");
//    Sum += clas [ i ];
//}
//Console.WriteLine ();
//Console .WriteLine (Sum);
//if (Sum >= 1000 && Sum < 10000)
//{
//    Console .WriteLine ($"в школе общее число ученков есть четырехзначное число");
//}

int [ ] mas = new int [12];
Random r = new Random();
int min = int.MaxValue;

for ( int i = 0 ; i < mas .Length ; i++ )
{
    mas [ i ] = r .Next ( 10 , 100 );
    Console .Write ( $" {mas [ i ]} " );
    if ( mas [i]<min ) min = mas [i];
}
Console .WriteLine ();
int index = -1;
for (int i = 0 ; i < mas .Length ; i++ )
{
    if ( mas [ i ] == min ) index = i;
}
int temp = mas[0];
mas [ 0 ] = mas [ index ];
mas [ index ] = temp;
foreach ( int i in mas )
{
    Console .Write ( i + "  " );
}
Console .WriteLine ();



