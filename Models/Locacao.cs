using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Repositories;

namespace Models
{    
    public class Locacao{
        public int idLocacao { get; set; }
        public DateTime dtLocacao { get; set; }
        public DateTime dtDevolucao { get; set; }
        public Cliente objCliente { get; set; }

        public Filmes_Locados objFilmesLocados { get; set; }
        public int qtdFilmesPorLocacao { get; set; }
        public double vlrTotalPorLocacao { get; set; }


        public Locacao(int idLocacao, DateTime dtLocacao, DateTime dtDevolucao, Cliente objCliente, List<Filme> listFilmes)
        {
            this.idLocacao   = idLocacao;
            this.dtLocacao   = dtLocacao;
            this.dtDevolucao = dtDevolucao;
            this.objCliente  = objCliente;

            this.objFilmesLocados  = new Filmes_Locados(this, listFilmes);
            this.objCliente.addFilmesLocados(listFilmes.Count);
            this.AddQtdFilmesPorLocacao(listFilmes.Count);
            this.AddQtdDeLocacoes(listFilmes);
            RepositoryLocacao.AddLocacao(this);                        
        }

        public static List<Locacao> Locacoes(){
            return RepositoryLocacao.Locacoes();
        }                        

        public void AddQtdFilmesPorLocacao(int qtd){
            this.qtdFilmesPorLocacao = qtd;
        }

        public void AddQtdDeLocacoes(List<Filme> listFilmes){

            foreach (Filme filme in listFilmes) {
                filme.totLocacoes(1);
                this.vlrTotalPorLocacao += filme.valor;
            }
        }

    }
}