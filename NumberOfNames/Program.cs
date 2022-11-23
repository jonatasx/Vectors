//reads the respectives numbers of name inserted
//first insert the number of names that you want to
/* after you had inserted the number,
write the respective names then press enter */
int N;
N = int.Parse(Console.ReadLine());
string[] vet = new string[N];

for (int i =0; i < N; i++)
{
    vet[i] = Console.ReadLine();
}

Console.WriteLine("Nomes lidos:");
foreach (string elemento in vet)
{
    Console.WriteLine(elemento); 
}
Console.ReadLine();