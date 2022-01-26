using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaContaCorrente lista = new ListaContaCorrente();
            ContaCorrente contaGui = new ContaCorrente(13212323, 9456879);
            lista.Adicionar(contaGui);

            lista.Adicionar(new ContaCorrente(123, 12345689));
            lista.Adicionar(new ContaCorrente(123, 12345689));
            lista.Adicionar(new ContaCorrente(123, 12345689));
            lista.Adicionar(new ContaCorrente(123, 12345689));
            lista.Adicionar(new ContaCorrente(123, 12345689));
            lista.Adicionar(new ContaCorrente(123, 12345689));

            lista.EscreverListaNaTela();

            lista.Remover(contaGui);

            Console.WriteLine("*************************************************");
            lista.EscreverListaNaTela();


            Console.ReadLine();
        }

        static void TestaArrayDeContaCorrente()
        {
            ContaCorrente[] contas = new ContaCorrente[]
            {
                new ContaCorrente(12, 123456789),
                new ContaCorrente(12, 123456789),
                new ContaCorrente(12, 123456789)
            };

            Console.WriteLine(contas);
        }

        static void TesteArrayInt()
        {
            int[] idades = new int[5];

            idades[0] = 15;
            idades[1] = 28;
            idades[2] = 35;
            idades[3] = 50;
            idades[4] = 28;

            int cont = 0;
            int media = 0;
            for (int i = 0; i <= 5; i++)
            {
                media += idades[i];
                cont++;
            }
            
            Console.WriteLine(media/cont);
        }
    }
}
