using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace Controllers {
    public class LocacaoController : Controller {

        public static List<Locacao> Locacoes(){
            return Locacao.Locacoes();
        }
    
    }
}