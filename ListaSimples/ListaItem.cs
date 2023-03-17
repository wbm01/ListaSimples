using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaSimples
{
    internal class ListaItem
    {
        public Item Inicio { get; set; }
        public Item Fim { get; set; }

        public ListaItem()
        {
            Inicio = null;
            Fim = null;
        }

        public void Inserir(Item i)
        {
            if (EhVazia())
            {
                Inicio = i;
                Fim = i;
            }
            else
            {
                if (i.Valor <= Inicio.Valor)
                {
                    InserirInicio(i);
                }
                else
                {
                    if (i.Valor >= Fim.Valor)
                    {
                        InserirFim(i);
                    }
                    else
                    {
                        InserirMeio(i);
                    }
                }
            }
        }

        public void InserirInicio(Item i)
        {
            i.Proximo = Inicio;
            Inicio = i;
        }

        public void InserirFim(Item i)
        {
            Fim.Proximo = i;
            Fim = i;
        }

        public void InserirMeio(Item i)
        {
            Item aux;
            aux = Inicio;
            Item aux2 = aux.Proximo;

            while(aux2 != null)
            {
                if(i.Valor<= aux2.Valor)
                {
                    i.Proximo = aux2;
                    aux.Proximo = i;
                    return;
                }
                else
                {
                    aux = aux2;
                    aux2 = aux2.Proximo;
                }
            }
        }

        public bool Percorrer(Item f)
        {
            Item aux = Inicio;

            while (aux != null)
            {

                if (aux.Valor == f.Valor)
                {
                    return true;
                }

                aux = aux.Proximo;
            }
            return false;

        }
            

        public bool EhVazia() {

            return true;
        }

        public void Imprimir()
        {
            if (EhVazia())
            {
                Console.WriteLine("Lista vazia");
            }
            else
            {
                Item aux = Inicio;
                while (aux != null)
                {
                    Console.WriteLine(aux.Valor);
                    aux = aux.Proximo;
                }
            }
        }
    }
}
