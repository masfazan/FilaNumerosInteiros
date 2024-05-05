using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaNumerosInteiros
{
    internal class Fila
    {
        Numero head;
        Numero tail;
        public Fila()
        {
            this.head = null;
            this.tail = null;

        } //fila

        Boolean FilaVazia()
        {
            if (head == null && head == null) 
                return true;
            else
                return false;
        }

        public void push(Numero aux)
        {
            if (FilaVazia() == true)
            {
                head = tail = aux;
            }

            else
            {
                tail.setProx(aux);//set porque atribui valor
                tail = aux;
            }
        }

        public void pop()
        {
            if (FilaVazia() == false)
            {
                if (tail == head)
                {
                    head = tail = null;
                }
                else
                {
                    this.head = head.getProx();
                }
            }
        }

        public int tamanho()
        {
            Numero aux = head;
            int cont = 0;
            if (FilaVazia())
            {
                return 0;
            }
            else
            {
                do
                {
                    cont++;
                    aux = aux.getProx();
                } while (aux != null);
            }
            return cont;
        }

        public void Par()
        {
            Numero aux = head;
            int par = 0;
            while (aux != null)
            {
                {
                    if (aux.getNumero() % 2 == 0) ; //resto zero = par
                    {
                        par++;
                        Console.WriteLine($"Número par: {aux.getNumero()}");

                    }
                }
                aux = aux.getProx();//vai receber o valor do próx
            }
            Console.WriteLine("Quantidade de números pares: " + par);
        }

        public void Impar()
        {
            Numero aux = head;
            int impar = 0;
            while (aux != null)
            {
                {
                    if (aux.getNumero() % 2 != 0) ; //resto diferente de zero = impar
                    {
                        impar++;
                        Console.WriteLine($"Número ímpar: {aux.getNumero()}");

                    }
                }
                aux = aux.getProx();//vai receber o valor do próx
            }
            Console.WriteLine("Quantidade de números ímpares: " + impar);
        }
        public void print()
        {
            Numero aux = head;

            if (FilaVazia())
            {
                Console.WriteLine("Fila vazia");

            }
            else
            {
                do
                {
                    Console.WriteLine(aux.ToString());
                    aux = aux.getProx();
                } while (aux != null);
                Console.ReadKey();
            }
        }
        public Fila CopiarFila()
        {
            Numero aux = head;
            Fila filaaux = new Fila();
            if (FilaVazia())
            {
                Console.WriteLine("A fila selecionada está vazia.");
            }
            else
            {
                for (; aux != null; aux = aux.getProx()) ;
                filaaux.push(new Numero(aux.getNumero()));
            }
            return filaaux;
        }

        public void MMMedia()
        {
            Numero aux = head;
            int size = this.tamanho();
            int contador = 0;
            int soma = 0;
            int maior = 0;
            int menor = Int32.MaxValue; //inicializa com o maior valor possível e encontra o menor valor por meio de comparação
            float media = 0;

            if (FilaVazia())
            {
                Console.WriteLine("Não há conteúdo na fila escolhida");
            }
            else
            {
                do
                {
                    soma += aux.getNumero();//ajuda na média, a cada incremento o valor do numero(aux) é somado
                    contador++;

                    if (menor > aux.getNumero())//menor se aux for menor que variável menor, então atualiza o menor
                        menor = aux.getNumero();
                    if (maior > aux.getNumero())//maior
                        maior = aux.getNumero();
                    aux = aux.getProx();//ponteiro aponta para o próx, até ser null while (aux != null);

                } while (aux != null);//até o último valor

                media = (soma / size);
                Console.WriteLine($"Média: {media}");
                Console.WriteLine($"Menor: {menor}");
                Console.WriteLine($"Maior: {maior}");
            }


        }



    }
}
    

