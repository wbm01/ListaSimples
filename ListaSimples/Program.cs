// See https://aka.ms/new-console-template for more information
using ListaSimples;

ListaItem lista = new ListaItem();

Item item;

/*lista.Inserir(item);
lista.Imprimir();

item = new Item(15);
lista.Inserir(item);
lista.Imprimir();

item = new Item(30);
lista.Inserir(item);
lista.Imprimir();

item = new Item(10);
lista.Inserir(item);
lista.Imprimir();

item = new Item(5);
lista.Inserir(item);
lista.Imprimir();*/

Random random = new Random();

do
{
    Console.Clear();
    int x = random.Next();
    item = new(x);
    lista.Inserir(item);
    lista.Imprimir();
    Console.ReadLine();
}
while (true);