using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dio.Series.Interfaces
{
    public interface IRepositorio<T>
    {
        List<T> Lista();
        T RetornaPorID(int id);
        void Insert(T entidade);
        void Exclui(int id);
        void Atualiza(int id, T entidade);
        int ProximoId();
        
    }
}