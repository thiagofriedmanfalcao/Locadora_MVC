using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace Controllers {
    public class DatasController : Controller {
        public static DateTime FormataData(String dateString)
        {
            DateTime data = new DateTime();
            try
            {
                data = DateTime.Parse(dateString);
            }
            catch (System.Exception)
            {
                Console.WriteLine("DATA INFORMADA NO FORMATO INCORRETO!");
                throw;
            }

            return data;
        }        


        public static DateTime CalculaDtDevolucao(int devDias){
            DateTime dtDevolucao = DateTime.Now;
            dtDevolucao.Subtract(TimeSpan.FromDays(devDias));
            return dtDevolucao;
        }           


        public static DateTime DataAtual(){            
            return DateTime.Now;
        }           

    }
}