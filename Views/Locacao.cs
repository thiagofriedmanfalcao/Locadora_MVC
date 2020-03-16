using System;
using Models;
using Controllers;

namespace View {
    public class LocacaoView {

        public static void GetLocacoes(){
            Console.WriteLine("\n***Quantidade de Filmes por Locação***");        
            foreach (Locacao locacao in LocacaoController.Locacoes())
            {
                Console.WriteLine("Locação " + locacao.idLocacao + ": " + locacao.qtdFilmesPorLocacao + " filmes");        
            }

            Console.WriteLine("\n***Valor Total por Locação***");        
            foreach (Locacao locacao in LocacaoController.Locacoes())
            {
                Console.WriteLine("Locação " + locacao.idLocacao + ": " + locacao.vlrTotalPorLocacao + " reais");                        
            }            
        }             

    }
}