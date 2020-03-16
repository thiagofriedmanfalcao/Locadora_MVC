using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Models;
using System.Linq;

namespace Controllers {
    public class FilmeLocadosController : Controller {

        public static void AddFilmeLocado(){
            
            Cliente Cliente1 = ClienteController.Clientes().ElementAt(0); //Busca o Primeiro Cliente Cadastrado
            Cliente Cliente3 = ClienteController.Clientes().ElementAt(2); //Busca o Terceiro Cliente Cadastrado
            Cliente Cliente5 = ClienteController.Clientes().ElementAt(4); //Busca o Quinto Cliente Cadastrado

            Filme Filme1  = FilmeController.Filmes().ElementAt(0);  //Busca o Primeiro Filme Cadastrado
            Filme Filme2  = FilmeController.Filmes().ElementAt(1);  //Busca o Segunda Filme Cadastrado
            Filme Filme3  = FilmeController.Filmes().ElementAt(2);  //Busca o Terceiro Filme Cadastrado
            Filme Filme4  = FilmeController.Filmes().ElementAt(3);  //Busca o Quarto Filme Cadastrado
            Filme Filme5  = FilmeController.Filmes().ElementAt(4);  //Busca o Quinto Filme Cadastrado
            Filme Filme6  = FilmeController.Filmes().ElementAt(5);  //Busca o Sexto Filme Cadastrado
            Filme Filme7  = FilmeController.Filmes().ElementAt(6);  //Busca o Sétimo Filme Cadastrado
            Filme Filme8  = FilmeController.Filmes().ElementAt(7);  //Busca o Oitavo Filme Cadastrado
            Filme Filme9  = FilmeController.Filmes().ElementAt(8);  //Busca o Nono Filme Cadastrado
            Filme Filme10 = FilmeController.Filmes().ElementAt(9);  //Busca o Décimo Filme Cadastrado            

            List<Filme> filmesLocados = new List<Filme>();
            filmesLocados.Add(Filme1);
            filmesLocados.Add(Filme10);
            Locacao Locacao1 = new Locacao(1, DatasController.DataAtual(), DatasController.CalculaDtDevolucao(Cliente1.diasDevolucao), Cliente1, filmesLocados);

            filmesLocados = new List<Filme>();
            filmesLocados.Add(Filme3);
            filmesLocados.Add(Filme8);
            Locacao Locacao2 = new Locacao(2, DatasController.DataAtual(), DatasController.CalculaDtDevolucao(Cliente1.diasDevolucao), Cliente1, filmesLocados);

            filmesLocados = new List<Filme>();
            filmesLocados.Add(Filme5);
            filmesLocados.Add(Filme4);
            filmesLocados.Add(Filme3);
            Locacao Locacao3 = new Locacao(3, DatasController.DataAtual(), DatasController.CalculaDtDevolucao(Cliente3.diasDevolucao), Cliente3, filmesLocados);

            filmesLocados = new List<Filme>();
            filmesLocados.Add(Filme5);
            filmesLocados.Add(Filme10);
            filmesLocados.Add(Filme1);
            filmesLocados.Add(Filme8);
            filmesLocados.Add(Filme3);
            Locacao Locacao4 = new Locacao(4, DatasController.DataAtual(), DatasController.CalculaDtDevolucao(Cliente5.diasDevolucao), Cliente5, filmesLocados);

            filmesLocados = new List<Filme>();
            filmesLocados.Add(Filme7);
            filmesLocados.Add(Filme9);
            Locacao Locacao5 = new Locacao(5, DatasController.DataAtual(), DatasController.CalculaDtDevolucao(Cliente5.diasDevolucao), Cliente5, filmesLocados);

        }        
    
    }
}