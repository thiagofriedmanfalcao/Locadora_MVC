using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using View;

namespace locadora_mvc
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ClienteView.SetClientes(); //Cadastra os Clientes
            FilmeView.SetFilmes(); //Cadastra os filmes
            FilmesLocadosView.AddFilmeLocado(); //Adiciona uma locação de um cliente com seus determinados filmes locados

            ClienteView.GetCliQtdFilmeLocados(); //Busca os clientes e sua determinada quantidade de filmes locados      
            LocacaoView.GetLocacoes();
            FilmeView.GetQtdLocacaoPorFilme(); //Busca a quantidade de Locações por Filme      
        }

    }
}
