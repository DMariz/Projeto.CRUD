using System.Collections.Generic;

namespace ComidasCRUD.Interfaces
{
    public interface Repositorio<L>
    {
        List<L> Lista();
        L RetornaPorId(int id);        
        void Insere(L entidade);        
        void Exclui(int id);        
        void Atualiza(int id, L entidade);
        int ProximoId();
    }
}