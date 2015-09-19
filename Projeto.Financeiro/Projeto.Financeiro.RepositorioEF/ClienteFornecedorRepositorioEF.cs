using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Financeiro.Dominio;
using Projeto.Financeiro.Dominio.contrato;

namespace Projeto.Financeiro.RepositorioEF
{
    public class ClienteFornecedorRepositorioEF : IRepositorio<tb_cliente_fornecedor>
    {

        private readonly Contexto contexto;

        public ClienteFornecedorRepositorioEF()
        {
            contexto = new Contexto();
        }

        //salvar ou altera o registro
        public void SalvarRegistro(tb_cliente_fornecedor entidade)
        {
            if (entidade.IDCLIENTEFORNECEDOR > 0)
            {
                //todo:falta dados do cliente é fornecedor
                //var Alterar = contexto.ClienteFornecedor.First(x => x.IDCLIENTEFORNECEDOR == entidade.IDCLIENTEFORNECEDOR);
                //Alterar.RAZAO_SOCIAL = entidade.RAZAO_SOCIAL;
                //Alterar.ENDERECO = entidade.ENDERECO;
                //Alterar.BAIRRO = entidade.BAIRRO;
                //Alterar.CIDADE = entidade.CIDADE;
                //Alterar.IMAGEM_LOGO = entidade.IMAGEM_LOGO;
                //Alterar.STATUS = entidade.STATUS;

                //implementar IEntidade nos Models para salvar as datas DATA_ALTERACAO e DATA_INCLUSAO
            }
            else
            {
                contexto.ClienteFornecedor.Add(entidade);
            }

            contexto.SaveChanges();
        }

        //excluir o registro (altera o status do registro)
        public void ExcluirRegistro(tb_cliente_fornecedor entidade)
        {
            //não vou excluir o registro, apenas trocar o status para 'S'
            char StatusRegistro = 'S';
            var Excluir = contexto.ClienteFornecedor.First(x => x.IDCLIENTEFORNECEDOR == entidade.IDCLIENTEFORNECEDOR);
                Excluir.STATUS = StatusRegistro;
            //contexto.Set<tb_cliente_fornecedor>().Remove(ClienteFornecedorExcluir);
            contexto.SaveChanges();
        }

        //listar por id os registros ativos
        public tb_cliente_fornecedor ListarPorId(string id)
        {
            int idInt;
            Int32.TryParse(id, out idInt);
            var Consulta = contexto.ClienteFornecedor.First(x => x.IDCLIENTEFORNECEDOR == idInt && x.STATUS != 'S');
            return Consulta;
        }

        //listar todos os registros ativos
        public IEnumerable<tb_cliente_fornecedor> ListarTodos()
        {
            return contexto.ClienteFornecedor.Where(x => x.STATUS != 'S');
        }


    }
}
