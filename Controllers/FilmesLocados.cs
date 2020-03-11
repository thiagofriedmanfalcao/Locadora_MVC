using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Models;
using System.Linq;

namespace Controllers {
    public class FilmeLocadosController : Controller {

        public static void AddFilmeLocado(){
            
            //listClientes.ElementAt(1); //para buscar um elemento especifico da lista

            Cliente cliente1 = ClienteController.Clientes().ElementAt(1); //Busca o Primeiro Cliente Cadastrado

            Filme filme1 = FilmeController.Filmes().ElementAt(1); //Busca o Primeiro Filme Cadastrado
            Filme filme10 = FilmeController.Filmes().ElementAt(10); //Busca o Primeiro Filme Cadastrado

            List<Filme> filmesLocados = new List<Filme>();
            filmesLocados.Add(filme1);
            filmesLocados.Add(filme10);
            Locacao Locacao1 = new Locacao(1, DatasController.DataAtual(), DatasController.CalculaDtDevolucao(cliente1.diasDevolucao), cliente1, filmesLocados);
        }
    
    }
}