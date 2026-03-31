using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Title = "Cantina ";
       
        List<string> pedido = new();
        decimal total = 0;
       
        while (true) // Heurística #3------------------------------------------------
        {
            MostrarMenu(total, pedido.Count);
           
                            //Heurística #1------------------------------------------------------------------------
            Console.Write("PASSO 1 - Escolha (0-7): "); //Heurística #9------------------------------------------------
            string opcao = Console.ReadLine();
           
           
            switch (opcao)
            {
                case "1":
                    AdicionarItem("X-Burger", 15.00m, pedido, ref total);
                    break;
                case "2":
                    AdicionarItem("Cheeseburger", 18.00m, pedido, ref total);
                    break;
                case "3":
                    AdicionarItem("Batata", 10.00m, pedido, ref total);
                    break;
                case "4":
                    AdicionarItem("Refrigerante", 6.00m, pedido, ref total);
                    break;
                case "5":
                    AdicionarItem("Coxinha", 2.00m, pedido, ref total);
                    break;
                case "6":
                    AdicionarItem("Sanduiche", 12.00m, pedido, ref total);
                    break;
                case "7":
                    AdicionarItem("kibe", 3.00m, pedido, ref total);
                    break;
                case "8":
                    ConfirmarPedido(pedido, total);
                    break;
                case "9":
                    return; // Heurística #3
                case "0":
                    Console.WriteLine("❌ Adicione itens primeiro!");  //Heurística #3------------------------------------------------
                    break;
                default:
                    Console.WriteLine("Código não encontrado. Nossos códigos vão de 1 a 9. Tente novamente.❌ Opção inválida!");
                    break; // Heurística #9
        }
           
            Console.WriteLine("Pressione ENTER para continuar..."); // Heurística #3------------------------------------------------
            Console.ReadLine();
            Console.Clear();
   
        }
     }  
       
    static void MostrarMenu(decimal total, int qtdItens)
    {
        Console.Clear();
        Console.WriteLine("CANTINA"); //Heurística #9------------------------------------------------------------------------------------------------
        Console.WriteLine("==================");
        Console.WriteLine("1 - X-Burger     R$15");
        Console.WriteLine("2 - Cheeseburger R$18");
        Console.WriteLine("3 - Batata       R$10");
        Console.WriteLine("4 - Refrigerante R$6 ");
        Console.WriteLine("5 - Coxinha      R$2 ");
        Console.WriteLine("6 - Sanduiche    R$12");
        Console.WriteLine("7 - kibe         R$3 ");
        Console.WriteLine("8 - Confirmar Pedido ");
        Console.WriteLine("9 - FINALIZAR");
        Console.WriteLine("0 - SAIR");
        Console.WriteLine("==================");
        Console.WriteLine($"Itens: {qtdItens} | Total: R${total:F2}");
    }

   static void AdicionarItem(string nome, decimal preco, List<string> pedido, ref decimal total)
    {
                      //Heurística #1------------------------------------------------------------------------------------------------
        Console.Write($"PASSO 2 - Quantos {nome}? ");
        if (int.TryParse(Console.ReadLine(), out int qtd) && qtd > 0)
        {
            for (int i = 0; i < qtd; i++)
                pedido.Add(nome);
            total += preco * qtd;
            Console.WriteLine($"✅ {qtd} {nome} adicionado(s)!");
        }
        else
        {
            Console.WriteLine("❌ Número inválido!");  //Heurística #9------------------------------------------------------------------------
        }
    }
   
    static void ConfirmarPedido(List<string> pedido, decimal total)
    {
        if (pedido.Count == 0)
        {
            Console.WriteLine("❌ Pedido vazio!");  //Heurística #9------------------------------------------------------------------------
            return;
        }
       
        Console.Clear();   //Heurística #1------------------------------------------------------------------------------------------------
        Console.WriteLine("PASSO 3 - PEDIDO CONFIRMADO!");
        Console.WriteLine("====================");
       
        foreach (string item in pedido)
            Console.WriteLine(item);
           
        Console.WriteLine("====================");
        Console.WriteLine($"TOTAL: R${total:F2}");
        Console.WriteLine("Retire no balcão!"); //Heurística #1------------------------------------------------
       
        Console.ReadLine();
    }
}
