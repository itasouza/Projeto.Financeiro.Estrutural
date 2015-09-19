using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Financeiro.Dominio;
using Projeto.Financeiro.Dominio.contrato;

namespace Projeto.Financeiro.RepositorioEF
{
    public class BoletoRepositorioEF : IRepositorio<tb_boleto_emitido>
    {

        private readonly Contexto contexto;

        public BoletoRepositorioEF()
        {
            contexto = new Contexto();
        }

        //salvar ou altera o registro
        public void SalvarRegistro(tb_boleto_emitido entidade)
        {
            if (entidade.IDBOLETO > 0)
              {

                var Alterar = contexto.Boleto.First(x => x.IDBOLETO == entidade.IDBOLETO);
                Alterar.IDCLIENTEFORNECEDOR = entidade.IDCLIENTEFORNECEDOR;
                Alterar.DATA_VENCIMENTO = entidade.DATA_VENCIMENTO;
                Alterar.VALOR_BOLETO = entidade.VALOR_BOLETO;
                Alterar.PERCENTUAL_JUROS = entidade.PERCENTUAL_JUROS;
                Alterar.PERCENTUAL_MULTA = entidade.PERCENTUAL_MULTA;
                Alterar.PERCENTUAL_DESCONTO = entidade.PERCENTUAL_DESCONTO;
                Alterar.OUTROS_ACRESCIMOS = entidade.OUTROS_ACRESCIMOS;
                Alterar.DEMONSTRATIVO = entidade.DEMONSTRATIVO;
                Alterar.INSTRUCOES_CAIXA = entidade.INSTRUCOES_CAIXA;
                Alterar.NOSSO_NUMERO = entidade.NOSSO_NUMERO;
                Alterar.DATA_PAGAMENTO = entidade.DATA_PAGAMENTO;
                Alterar.VALOR_PAGO = entidade.VALOR_PAGO;
                Alterar.IDEMPRESA = entidade.IDEMPRESA;
                Alterar.IDUSUARIO = entidade.IDUSUARIO;
                Alterar.STATUS = entidade.STATUS;


                //implementar IEntidade nos Models para salvar as datas DATA_ALTERACAO e DATA_INCLUSAO
            }
            else
            {
                contexto.Boleto.Add(entidade);
            }

            contexto.SaveChanges();
        }

        //excluir o registro (altera o status do registro)
        public void ExcluirRegistro(tb_boleto_emitido entidade)
        {
            //não vou excluir o registro, apenas trocar o status para 'S'
            char StatusRegistro = 'S';
            var Excluir = contexto.Boleto.First(x => x.IDBOLETO == entidade.IDBOLETO);
                Excluir.STATUS = StatusRegistro;
            //contexto.Set<tb_Boleto>().Remove(BoletoExcluir);
            contexto.SaveChanges();
        }

        //listar por id os registros ativos
        public tb_boleto_emitido ListarPorId(string id)
        {
            int idInt;
            Int32.TryParse(id, out idInt);
            var Consulta = contexto.Boleto.First(x => x.IDBOLETO == idInt && x.STATUS != 'S');
            return Consulta;
        }

        //listar todos os registros ativos
        public IEnumerable<tb_boleto_emitido> ListarTodos()
        {
            return contexto.Boleto.Where(x => x.STATUS != 'S');
        }


    }
}
