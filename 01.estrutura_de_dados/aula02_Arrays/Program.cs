int[] array = new int[3];
array[2] = 3;
Console.WriteLine($"Isso é um array estático {array.Length}");

var lista = new List<int>();
lista.Add(1);
lista.Add(2);
lista.Add(3);
lista.Add(4);
lista.Add(5);
lista.Add(6);
lista.Add(7);
lista.Add(8);

lista.Remove(5); //remove a primeira ocorrencia do número 5, retornando uma bool
lista.RemoveAt(0); //remove pelo indice
lista.Clear(); //remove tudo

int index = lista.IndexOf(3);
bool tem = lista.Contains(3);

foreach (int i in lista)
    Console.WriteLine(i);

lista.Sort(); //organiza

var tupla = (a: 1, b: 2);
Console.WriteLine(tupla.a);