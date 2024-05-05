using FilaNumerosInteiros;

internal class Program
{
    private static void Main()
    {
        Fila fila1 = new Fila();
        Fila fila2 = new Fila();
        Fila filaaux = new Fila();
      
        int opcfila;
        int numero;
        int opccopia = 0;

        int Menu()
        {
            Console.Clear();
            Console.WriteLine("MENU PRINCIPAL");
            Console.WriteLine();
            Console.WriteLine("1-Inserir número na(s) fila(s)");
            Console.WriteLine("2-Imprimir a fila(s)");
            Console.WriteLine("3-Verificar tamanho das filas");
            Console.WriteLine("4-Tranferir elementos da fila para fila auxiliar");
            Console.WriteLine("5-Imprimir números ímpares");
            Console.WriteLine("6-Imprimir números pares");
            Console.WriteLine("7- Ver o maior e o menor número e a média da fila");
            Console.WriteLine("0-Sair");
            Console.Write("Informar a opção desejada: ");
            return int.Parse(Console.ReadLine());
        }

        do
        {
            switch (Menu())
            {
                case 1:
                    Console.WriteLine("Informe em qual fila deseja adicionar números inteiros, fila 1 ou fila 2? ");
                    opcfila = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o(s) número(s) que deseja incluir na fila: ");
                    while (!int.TryParse(Console.ReadLine(), out numero)) //TryParse converte pra bool, melhora cód verificação
                    {
                        Console.WriteLine("Por favor, insira um número inteiro válido:");
                        break;
                    }

                    if (opcfila == 1)
                    {
                        fila1.push(new Numero(numero));
                    }
                    else if (opcfila == 2)
                    {
                        fila2.push(new Numero(numero));
                    }
                    else
                    {
                        Console.WriteLine("Opção inválida.");
                        break;
                    }

                    break;
                case 2:
                    Console.WriteLine("Fila 1");
                    fila1.print();
                    Console.WriteLine("Fila 2");
                    fila2.print();
                    break;
                case 3:
                    {
                        int qtdfila1 = fila1.tamanho();
                        int qtsfila2 = fila2.tamanho();
                        if (qtdfila1 == qtsfila2)
                        {
                            Console.WriteLine("As filas são iguais de tamanho!\n");
                        }
                        else if (qtdfila1 > qtsfila2)
                        {
                            Console.WriteLine("A fila 1 é maior!\n");
                        }
                        else
                        {
                            Console.WriteLine("A fila 2 é maior!\n");
                        }
                    }
                    Console.ReadKey();
                    break;
                case 4:
                    Console.WriteLine("Deseja tranferir os valores da fila 1 ou da fila 2? Digite 1 ou 2.");
                    while (!int.TryParse(Console.ReadLine(), out numero)) //TryParse converte pra bool, melhora cód verificação
                    {
                        Console.WriteLine("Por favor, insira um número inteiro válido:");
                    }

                    if (opccopia == 1)
                    {
                        fila1.CopiarFila();
                        filaaux.print();
                    }
                    else
                    {
                        fila2.CopiarFila();
                        filaaux.print();
                    }
                    break;

                case 5:
                    fila1.Par();
                    fila2.Par();
                    break;
                case 6:
                    fila1.Impar();
                    fila2.Impar();
                    break;
                case 7:
                    Console.WriteLine("Informe em qual fila deseja ver o maior, menor e a média: 1 ou 2? ");
                    opcfila = int.Parse(Console.ReadLine());
                    while (!int.TryParse(Console.ReadLine(), out numero))
                    {
                        Console.WriteLine("Por favor, insira um número inteiro válido:");
                        break;
                    }
                    if (opcfila == 1)
                    {
                        fila1.MMMedia();
                    }
                    else if (opcfila == 2)
                    {
                        fila2.MMMedia();
                    }
                    else
                    {
                        Console.WriteLine("Opção inválida.");
                        break;
                    }
                    break;
                case 0:
                    Console.WriteLine("Sair");
                    break;
                default:
                    Console.WriteLine("Opção não existe");
                    break;
            }

        } while (true);
    }


}