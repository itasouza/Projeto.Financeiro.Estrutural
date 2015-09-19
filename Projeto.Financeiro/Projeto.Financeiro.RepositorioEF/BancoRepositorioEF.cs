using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Financeiro.Dominio;
using Projeto.Financeiro.Dominio.contrato;

namespace Projeto.Financeiro.RepositorioEF
{
    public class BancoRepositorioEF : IRepositorio<tb_banco>
    {

        private readonly Contexto contexto;

        public BancoRepositorioEF()
        {
            contexto = new Contexto();
        }

        //salvar ou altera o registro
        public void SalvarRegistro(tb_banco entidade)
        {
            if (entidade.IDBANCO > 0)
            {


               var Alterar = contexto.Banco.First(x => x.IDBANCO == entidade.IDBANCO);
                Alterar.NOME_GERENTE = entidade.NOME_GERENTE;
                Alterar.TELEFONE = entidade.TELEFONE;
                Alterar.CELULAR = entidade.CELULAR;
                Alterar.IDEMPRESA = entidade.IDEMPRESA;
                Alterar.IDUSUARIO = entidade.IDUSUARIO;
                Alterar.BOLETO_CHAVECONTA = entidade.BOLETO_CHAVECONTA;
                Alterar.BOLETO_BANCO = entidade.BOLETO_BANCO;
                Alterar.BOLETO_AGENCIA = entidade.BOLETO_AGENCIA;
                Alterar.BOLETO_CONTA = entidade.BOLETO_CONTA;
                Alterar.BOLETO_CODIGO = entidade.BOLETO_CODIGO;
                Alterar.BOLETO_NOMECEDENTE = entidade.BOLETO_NOMECEDENTE;
                Alterar.BOLETO_CPFCNPJ = entidade.BOLETO_CPFCNPJ;
                Alterar.BOLETO_INICIONOSSONUMERO = entidade.BOLETO_INICIONOSSONUMERO;
                Alterar.BOLETO_FIMNOSSONUMERO = entidade.BOLETO_FIMNOSSONUMERO;
                Alterar.BOLETO_PROXIMONUMERO = entidade.BOLETO_PROXIMONUMERO;
                Alterar.BOLETO_ARQUIVOLICENCA = entidade.BOLETO_ARQUIVOLICENCA;
                Alterar.BOLETO_EMAILCEDENTE = entidade.BOLETO_EMAILCEDENTE;
                Alterar.BOLETO_CAMINHOLOGOTIPO = entidade.BOLETO_CAMINHOLOGOTIPO;
                Alterar.BOLETO_IDENTIFICACAO = entidade.BOLETO_IDENTIFICACAO;
                Alterar.STATUS = entidade.STATUS;


                //implementar IEntidade nos Models para salvar as datas DATA_ALTERACAO e DATA_INCLUSAO
            }
            else
            {
                contexto.Banco.Add(entidade);
            }

            contexto.SaveChanges();
        }

        //excluir o registro (altera o status do registro)
        public void ExcluirRegistro(tb_banco entidade)
        {
            //não vou excluir o registro, apenas trocar o status para 'S'
            char StatusRegistro = 'S';
            var Excluir = contexto.Banco.First(x => x.IDBANCO == entidade.IDBANCO);
                Excluir.STATUS = StatusRegistro;
            //contexto.Set<tb_banco>().Remove(BancoExcluir);
            contexto.SaveChanges();
        }

        //listar por id os registros ativos
        public tb_banco ListarPorId(string id)
        {
            int idInt;
            Int32.TryParse(id, out idInt);
            var Consulta = contexto.Banco.First(x => x.IDBANCO == idInt && x.STATUS != 'S');
            return Consulta;
        }

        //listar todos os registros ativos
        public IEnumerable<tb_banco> ListarTodos()
        {
            return contexto.Banco.Where(x => x.STATUS != 'S');
        }


    }
}
