using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Financeiro.Dominio;
using Projeto.Financeiro.Dominio.contrato;

namespace Projeto.Financeiro.RepositorioEF
{
    public class ReciboRepositorioEF : IRepositorio<tb_recibo>
    {

        private readonly Contexto contexto;

        public ReciboRepositorioEF()
        {
            contexto = new Contexto();
        }

        //salvar ou altera o registro
        public void SalvarRegistro(tb_recibo entidade)
        {
            if (entidade.IDRECIBO > 0)
            {

               var Alterar = contexto.Recibo.First(x => x.IDRECIBO == entidade.IDRECIBO);

                Alterar.IDCLIENTEFORNECEDOR = entidade.IDCLIENTEFORNECEDOR;
                Alterar.VALOR_RECIBO = entidade.VALOR_RECIBO;
                Alterar.VALOR_EXTENSO = entidade.VALOR_EXTENSO;
                Alterar.OBSERVACAO = entidade.OBSERVACAO;
                Alterar.CIDADE = entidade.CIDADE;
                Alterar.DATA_RECIBO = entidade.DATA_RECIBO;
                Alterar.IDEMPRESA = entidade.IDEMPRESA;
                Alterar.IDUSUARIO = entidade.IDUSUARIO;
                Alterar.STATUS = entidade.STATUS;


                //implementar IEntidade nos Models para salvar as datas DATA_ALTERACAO e DATA_INCLUSAO
            }
            else
            {
                contexto.Recibo.Add(entidade);
            }

            contexto.SaveChanges();
        }

        //excluir o registro (altera o status do registro)
        public void ExcluirRegistro(tb_recibo entidade)
        {
            //não vou excluir o registro, apenas trocar o status para 'S'
            char StatusRegistro = 'S';
            var Excluir = contexto.Recibo.First(x => x.IDRECIBO == entidade.IDRECIBO);
            Excluir.STATUS = StatusRegistro;
            //contexto.Set<tb_ProdutoServico>().Remove(ProdutoServicoExcluir);
            contexto.SaveChanges();
        }

        //listar por id os registros ativos
        public tb_recibo ListarPorId(string id)
        {
            int idInt;
            Int32.TryParse(id, out idInt);
            var Consulta = contexto.Recibo.First(x => x.IDRECIBO == idInt && x.STATUS != 'S');
            return Consulta;
        }

        //listar todos os registros ativos
        public IEnumerable<tb_recibo> ListarTodos()
        {
            return contexto.Recibo.Where(x => x.STATUS != 'S');
        }


    }
}

