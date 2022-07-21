using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dio.Series.Interfaces;

namespace Dio.Series
{
    public class SerieRepositorio : Interfaces.IRepositorio<Serie>
    {
        private List<Serie> ListaSerie = new List<Serie>();
        public void Atualiza(int id, Serie objeto)
        {
            ListaSerie[id] = objeto;
        }

        public void Exclui(int id)
        {
            ListaSerie[id].Excluir();
        }

        public void Insere(Serie objeto)
        {
            ListaSerie.Add(objeto);
        }

        public List<Serie> Lista()
        {
            return ListaSerie;
        }

        public int ProximoId()
        {
            return ListaSerie.Count;
        }

        public Serie RetornaPorID(int id)
        {
            return ListaSerie[id];
        }

    }
}