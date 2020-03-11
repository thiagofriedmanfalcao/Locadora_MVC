using System;
using Models;
using Controllers;

namespace View {
    public class FilmeView {
        public static void SetFilmes(){
            FilmeController.AddFilme(1, "O Homem das Cavernas", DatasController.FormataData("2006-06-11"), "Ação",  10.0, 20);
            FilmeController.AddFilme(2, "A Guerra do Fogo",     DatasController.FormataData("2003-01-05"), "Aventura", 15.20, 20);
            FilmeController.AddFilme(3, "A Era do Gelo",        DatasController.FormataData("2003-03-13"), "Comédia", 22.50, 20);
            FilmeController.AddFilme(4, "Fantasia",             DatasController.FormataData("2006-06-15"), "Docuficção", 33.10, 20);
            FilmeController.AddFilme(5, "O Poderoso Chefão",    DatasController.FormataData("2012-02-09"), "Espionagem", 12.0, 20);
            FilmeController.AddFilme(6, "Cidadão Kane",         DatasController.FormataData("2011-06-10"), "Documentário", 9.30, 20);
            FilmeController.AddFilme(7, "Casablanca",           DatasController.FormataData("2006-10-25"), "Aventura", 2.50, 20);
            FilmeController.AddFilme(8, "Tubarão",              DatasController.FormataData("1994-06-10"), "Musical", 11.5, 20);
            FilmeController.AddFilme(9, "Star Wars",            DatasController.FormataData("2011-11-23"), "Aventura", 27.8, 20);
            FilmeController.AddFilme(10, "Fargo",               DatasController.FormataData("2011-12-27"), "Musical", 19.23, 20);            
        }     

    }
}