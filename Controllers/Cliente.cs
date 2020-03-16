using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Models;
using System.Linq;

namespace Controllers {
    public class ClienteController : Controller {
        public static List<Cliente> Clientes(){
            return Cliente.Clientes();
        }

        public static void AddCliente(int idCliente, string nomeCliente, DateTime dtNasc, string cpf, int diasDevolucao){
            new Cliente(idCliente, nomeCliente, dtNasc, cpf, diasDevolucao);
        }
    
    }
}