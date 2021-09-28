using System;
using System.Collections.Generic;
using APPsimples.Interfaces;

namespace APPsimples
{
    public class SeriesRepositorio : IRepositorio<Series>
    {
        private List<Series> listaSeries = new List<Series>();

        public void Atualiza(int id, Series objeto)
        {
            listaSeries[id] = objeto;
        }
        
        public void Exclui(int id)
        {
            listaSeries[id].Excluir();
        }
        
        public void Insere(Series objeto)
        {
            listaSeries.Add(objeto);
        }
        
        public List<Series> Lista()
        {
            return listaSeries;
        }

        public void ProximoId()
        {
            return listaSeries.Count;
        }

        public void RetornaPorId(int id)
        {
            throw new NotImplementedException();
        }   
    }
} 