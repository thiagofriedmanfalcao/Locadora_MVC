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
            ClienteView.GetClientes(); //Busca os clientes e sua determinada quantidade de filmes locados

            FilmeView.SetFilmes(); //Cadastra os filmes
        }

    }
}
