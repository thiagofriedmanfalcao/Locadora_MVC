using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Repositories;

namespace Models
{        
    public class Filme{
        public int idFilme { get; set; }
        public string nomeFilme { get; set; }
        public DateTime dtLancamento { get; set; }
        public string sinopse { get; set; }
        public double valor { get; set; }
        public int qtdEstoque { get; set; }
        public int qtdLocacoes { get; set; }

        public Filme(int idFilme, string nomeFilme, DateTime dtLancamento, string sinopse, double valor, int qtdEstoque){
            this.idFilme        = idFilme;
            this.nomeFilme      = nomeFilme;
            this.dtLancamento   = dtLancamento;
            this.sinopse        = sinopse;
            this.valor          = valor;
            this.qtdEstoque     = qtdEstoque;
            RepositoryFilme.AddFilme(this);                        
        }

        public static List<Filme> Filmes(){
            return RepositoryFilme.Filmes();
        }                

        public void totLocacoes(int qtd){
            this.qtdLocacoes += qtd;
        }

    }
}