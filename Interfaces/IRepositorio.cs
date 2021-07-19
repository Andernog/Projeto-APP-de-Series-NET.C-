using System.Collections.Generic;

namespace Dio.series.Interfaces
{
    public interface IRepositorio<T>
    {
         List<T> Lista();

         T retornaPorID(int ID);

         void Insere( T Entidade);

         void Exclui(int Id);

         void Atualiza(int id, T entidade);

         int proximoId ();

    }

}










