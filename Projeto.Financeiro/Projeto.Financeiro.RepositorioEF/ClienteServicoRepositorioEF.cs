using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Financeiro.Dominio;
using Projeto.Financeiro.Dominio.contrato;


namespace Projeto.Financeiro.RepositorioEF
{

    public class ClienteServicoRepositorioEF : IRepositorio<tb_cliente_servico>
    {

        private readonly Contexto contexto;

        public ClienteServicoRepositorioEF()
        {
            contexto = new Contexto();
        }

        //salvar ou altera o registro
        public void SalvarRegistro(tb_cliente_servico entidade)
        {
            if (entidade.IDCLIENTESERVICO > 0)
            {

               var Alterar = contexto.ClienteServico.First(x => x.IDCLIENTESERVICO == entidade.IDCLIENTESERVICO);
                Alterar.COMISSAO_SERVICO = entidade.COMISSAO_SERVICO;
                Alterar.DATA_CONTRATO = entidade.DATA_CONTRATO;
                Alterar.IDCLIENTEFORNECEDOR = entidade.IDCLIENTEFORNECEDOR;
                Alterar.IDPRODUTO = entidade.IDPRODUTO;
                Alterar.IDPARCEIRO = entidade.IDPARCEIRO;
                Alterar.COMISSAO_PARCEIRO = entidade.COMISSAO_PARCEIRO;
                Alterar.IDVENDEDOR = entidade.IDVENDEDOR;
                Alterar.COMISSAO_VENDEDOR = entidade.COMISSAO_VENDEDOR;
                Alterar.IDADVOGADO = entidade.IDADVOGADO;
                Alterar.COMISSAO_ADVOGADO = entidade.COMISSAO_ADVOGADO;
                Alterar.STATUS = entidade.STATUS;

                //implementar IEntidade nos Models para salvar as datas DATA_ALTERACAO e DATA_INCLUSAO
            }
            else
            {
                contexto.ClienteServico.Add(entidade);
            }

            contexto.SaveChanges();
        }

        //excluir o registro (altera o status do registro)
        public void ExcluirRegistro(tb_cliente_servico entidade)
        {
            //não vou excluir o registro
            var Excluir = contexto.ClienteServico.First(x => x.IDCLIENTESERVICO == entidade.IDCLIENTESERVICO);
            contexto.Set<tb_cliente_servico>().Remove(Excluir);
            contexto.SaveChanges();
        }

        //listar por id os registros
        public tb_cliente_servico ListarPorId(string id)
        {
            int idInt;
            Int32.TryParse(id, out idInt);
            var Consulta = contexto.ClienteServico.First(x => x.IDCLIENTESERVICO == idInt);
            return Consulta;
        }

        //listar todos os registros 
        public IEnumerable<tb_cliente_servico> ListarTodos()
        {
            return contexto.ClienteServico;
        }


    }
}
