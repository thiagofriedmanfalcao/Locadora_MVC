using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{        
    public class Filmes_Locados{
        Locacao objLocacao { get; set; }
        List<Filme> listFilmes = new List<Filme>();

        public Filmes_Locados(Locacao objLocacao, List<Filme> listFilmes){
            this.objLocacao = objLocacao;
            this.listFilmes.AddRange(listFilmes);
        }
    }
}