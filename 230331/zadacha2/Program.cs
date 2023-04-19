Console .Write ("Введите размер массива: ");
int n = int.Parse (Console.ReadLine ());
int [ ] mas = new int [12];
Random r = new Random();
int count = 0;

while (count<n)
{
    int a = r.Next(-10,11);
    bool b = false;
    for (int i = 0 ; i<=count ; i++ )
        if ( mas [i]==a ) b = true;
    if(b==false)
    {
        mas[count] = a;
        count++;
    }
}
foreach(int i in mas) Console.Write (i+" ");
Console .WriteLine ();
int max = mas[0], min = mas[0];
for ( int i = 0 ; i < mas.Length ; i++ )
{
    if ( mas [ i ] > max ) max = mas [ i ];
    if (mas [ i ] < min ) min = mas [ i ];
}
int [ ]result = new int [n-2];
int j =0;
for ( int i = 0 ; i < n; i++ )
{
    if ( mas [i]!=max && mas [i] != min ) result [j++] = mas [i];
}
foreach ( int i in result ) Console .WriteLine (i+" ");
Console .WriteLine ();


