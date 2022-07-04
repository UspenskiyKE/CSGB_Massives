// See https://aka.ms/new-console-template for more information

Console.WriteLine("Введите исходные строки в массив. Для окончания ввода введите последним элементом \"***\"");
int i = 0;
int j = 0;
string s="";
string[] m = Array.Empty<string>();

while (s!= "***")
{
    Array.Resize(ref m,m.Length+1);
    Console.WriteLine("m["+i+"]:");
    s=Console.ReadLine();
    m[i] = s;
    i = i + 1;
}
Console.WriteLine();
Console.WriteLine("Массив из строк, длина которых <=3");

string[] r =  chooseFromMassive( m);
Console.WriteLine();

for(j=0;j<r.Length;j++) {
Console.WriteLine("r["+j+"]= "+r[j]);
}

 string[] chooseFromMassive(string[] mass)
{
    string[] result = Array.Empty<string>();
    int m = 0;
    string st;
    for ( i=0; i<mass.Length;i++)
    {
        st = mass[i];
        if (st.Length <= 3)
        {
            Array.Resize(ref result,result.Length+1);
            result[m] = st;
            m += 1;
        }
    }

    return result;
}