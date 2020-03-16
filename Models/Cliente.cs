using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Repositories;

namespace Models
{
    public class Cliente{
        public int idCliente { get; set; }
        public string nomeCliente { get; set; }
        public DateTime dtNasc { get; set; }
        public string cpf { get; set; }
        public int diasDevolucao { get; set; }
        public int qtdFilmesLocados { get; set; }

        public Cliente(int idCliente, string nomeCliente, DateTime dtNasc, string cpf, int diasDevolucao){
            this.idCliente      = idCliente;
            this.nomeCliente    = nomeCliente;
            this.dtNasc         = dtNasc;
            this.cpf            = cpf;
            this.diasDevolucao  = diasDevolucao;
            RepositoryCliente.AddCliente(this);            
        }

        public static List<Cliente> Clientes () {
            return RepositoryCliente.Clientes();
        }        

        public void addFilmesLocados(int qtdFilmes){
            this.qtdFilmesLocados += qtdFilmes;
        }        

        public override string ToString(){
            return $"Cliente: {nomeCliente} alugou {qtdFilmesLocados} filmes";
        }

    }
}