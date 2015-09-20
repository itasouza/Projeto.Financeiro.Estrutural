using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Financeiro.Dominio;
using Projeto.Financeiro.Dominio.contrato;

namespace Projeto.Financeiro.RepositorioEF
{
    public class ProdutoServicoRepositorioEF : IRepositorio<tb_produto_servico>
    {

        private readonly Contexto contexto;

        public ProdutoServicoRepositorioEF()
        {
            contexto = new Contexto();
        }

        //salvar ou altera o registro
        public void SalvarRegistro(tb_produto_servico entidade)
        {
            if (entidade.IDPRODUTO > 0)
            {

                var Alterar = contexto.ProdutoServico.First(x => x.IDPRODUTO == entidade.IDPRODUTO);

                Alterar.DESCRICAO = entidade.DESCRICAO;
                Alterar.IDEMPRESA = entidade.IDEMPRESA;
                Alterar.IDPERFIL = entidade.IDPERFIL;
                Alterar.STATUS = entidade.STATUS;


                //implementar IEntidade nos Models para salvar as datas DATA_ALTERACAO e DATA_INCLUSAO
            }
            else
            {
                contexto.ProdutoServico.Add(entidade);
            }

            contexto.SaveChanges();
        }

        //excluir o registro (altera o status do registro)
        public void ExcluirRegistro(tb_produto_servico entidade)
        {
            //não vou excluir o registro, apenas trocar o status para 'S'
            char StatusRegistro = 'S';
            var Excluir = contexto.ProdutoServico.First(x => x.IDPRODUTO == entidade.IDPRODUTO);
                Excluir.STATUS = StatusRegistro;
            //contexto.Set<tb_ProdutoServico>().Remove(ProdutoServicoExcluir);
            contexto.SaveChanges();
        }

        //listar por id os registros ativos
        public tb_produto_servico ListarPorId(string id)
        {
            int idInt;
            Int32.TryParse(id, out idInt);
            var Consulta = contexto.ProdutoServico.First(x => x.IDPRODUTO == idInt && x.STATUS != 'S');
            return Consulta;
        }

        //listar todos os registros ativos
        public IEnumerable<tb_produto_servico> ListarTodos()
        {
            return contexto.ProdutoServico.Where(x => x.STATUS != 'S');
        }


    }
}
