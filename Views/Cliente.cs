using System;
using Models;
using Controllers;

namespace View {
    public class ClienteView {
        public static void SetClientes(){
            ClienteController.AddCliente(1, "Thiago",  DatasController.FormataData("1994-06-10"), "094.602.329-81", 5);
            ClienteController.AddCliente(2, "Mateus",  DatasController.FormataData("2003-02-23"), "981.998.100-09", 10);
            ClienteController.AddCliente(3, "Jackson", DatasController.FormataData("1998-05-15"), "521.671.710-21", 15);
            ClienteController.AddCliente(4, "Carlos",  DatasController.FormataData("2009-09-06"), "672.506.850-23", 20);
            ClienteController.AddCliente(5, "João",    DatasController.FormataData("1988-07-19"), "865.518.360-11", 25); 
        }     

        public static void GetClientes(){
            Console.WriteLine("***Quantidade de Filmes locados por cada cliente***");
            foreach (Cliente cliente in ClienteController.Clientes())
            {
                Console.WriteLine(cliente);
            }
        }     
    }
}