using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dio.Series
{

    //Atributos
    public class Serie : EntidadeBase
    {
        private DIO.Series.Genero Genero { get; set; }

        public Serie(string titulo, string descricao, int ano) 
        {
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
   
        }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }
        private bool Excluido { get; set; }
        public Serie(int id, DIO.Series.Genero genero, string titulo, string descricao, int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false;
        }

        public override string ToString()
        {
            //Enviroment.NewLine https://docs.microsoft.com/en-us/dotnet/api/system.enviroment.newline?view=netcore=3.1
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Ano de Inicio: " + this.Ano + Environment.NewLine;
            retorno += "Exclusão: " + this.Excluido;
            return retorno;
        }

        //Encapsulamento
        public string retornaTitulo()
        {
            return this.Titulo;
        }

        public int retornaId()
        {
            return this.Id;
        }

        public bool retornaExcluido()
        {
            return this.Excluido;
        }

        public void Excluir() 
        {
            this.Excluido = true;
        }
    }
        
}