using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Financeiro.Dominio.contrato
{
    public interface IRepositorio<T> where T :class
    {
        //gravar um novo registro no banco
        void SalvarRegistro(T entidade);
        //excluir um novo registro no banco
        void ExcluirRegistro(T entidade);
        //listar todos os registros no banco
        IEnumerable<T> ListarTodos();
        //listar um registro no banco pelo id
        T ListarPorId(string id);
    }
}
