using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Financeiro.Dominio;
using Projeto.Financeiro.Dominio.contrato;


namespace Projeto.Financeiro.RepositorioEF
{

    public class PerfilRepositorioEF : IRepositorio<tb_perfil>
    {

        private readonly Contexto contexto;

        public PerfilRepositorioEF()
        {
            contexto = new Contexto();
        }

        //salvar ou altera o registro
        public void SalvarRegistro(tb_perfil entidade)
        {
            if (entidade.IDPERFIL > 0)
            {

               var Alterar = contexto.Perfil.First(x => x.IDPERFIL == entidade.IDPERFIL);

                Alterar.DESCRICAO_PERFIL = entidade.DESCRICAO_PERFIL;
                Alterar.IDEMPRESA = entidade.IDEMPRESA;
                Alterar.PERFIL = entidade.PERFIL;

                Alterar.EMPRESA = entidade.EMPRESA;
                Alterar.EMPRESA_I = entidade.EMPRESA_I;
                Alterar.EMPRESA_A = entidade.EMPRESA_A;
                Alterar.EMPRESA_E = entidade.EMPRESA_E;
                Alterar.EMPRESA_NAVEGA = entidade.EMPRESA_NAVEGA;

                Alterar.CLIENTE = entidade.CLIENTE;
                Alterar.CLIENTE_I = entidade.CLIENTE_I;
                Alterar.CLIENTE_A = entidade.CLIENTE_A;
                Alterar.CLIENTE_E = entidade.CLIENTE_E;
                Alterar.CLIENTE_NAVEGA = entidade.CLIENTE_NAVEGA;

                Alterar.PLANOCONTAS = entidade.PLANOCONTAS;
                Alterar.PLANOCONTAS_I = entidade.PLANOCONTAS_I;
                Alterar.PLANOCONTAS_A = entidade.PLANOCONTAS_A;
                Alterar.PLANOCONTAS_E = entidade.PLANOCONTAS_E;
                Alterar.PLANOCONTAS_NAVEGA = entidade.PLANOCONTAS_NAVEGA;

                Alterar.USUARIO = entidade.USUARIO;
                Alterar.USUARIO_I = entidade.USUARIO_I;
                Alterar.USUARIO_A = entidade.USUARIO_A;
                Alterar.USUARIO_E = entidade.USUARIO_E;
                Alterar.USUARIO_NAVEGA = entidade.USUARIO_NAVEGA;

                Alterar.BANCO = entidade.BANCO;
                Alterar.BANCO_I = entidade.BANCO_I;
                Alterar.BANCO_A = entidade.BANCO_A;
                Alterar.BANCO_E = entidade.BANCO_E;
                Alterar.BANCO_NAVEGA = entidade.BANCO_NAVEGA;


                Alterar.CONTASPAGAR = entidade.CONTASPAGAR;
                Alterar.CONTASPAGAR_I = entidade.CONTASPAGAR_I;
                Alterar.CONTASPAGAR_A = entidade.CONTASPAGAR_A;
                Alterar.CONTASPAGAR_E = entidade.CONTASPAGAR_E;
                Alterar.CONTASPAGAR_NAVEGA = entidade.CONTASPAGAR_NAVEGA;


                Alterar.CONTASRECEBER = entidade.CONTASRECEBER;
                Alterar.CONTASRECEBER_I = entidade.CONTASRECEBER_I;
                Alterar.CONTASRECEBER_A = entidade.CONTASRECEBER_A;
                Alterar.CONTASRECEBER_E = entidade.CONTASRECEBER_E;
                Alterar.CONTASRECEBER_NAVEGA = entidade.CONTASRECEBER_NAVEGA;

                Alterar.RECIBO = entidade.RECIBO;
                Alterar.RECIBO_I = entidade.RECIBO_I;
                Alterar.RECIBO_A = entidade.RECIBO_A;
                Alterar.RECIBO_E = entidade.RECIBO_E;
                Alterar.RECIBO_NAVEGA = entidade.RECIBO_NAVEGA;


                Alterar.BOLETO = entidade.BOLETO;
                Alterar.BOLETO_I = entidade.BOLETO_I;
                Alterar.BOLETO_A = entidade.BOLETO_A;
                Alterar.BOLETO_E = entidade.BOLETO_E;
                Alterar.BOLETO_NAVEGA = entidade.BOLETO_NAVEGA;

                Alterar.PRODUTO_SERVICO = entidade.PRODUTO_SERVICO;
                Alterar.PRODUTO_SERVICO_I = entidade.PRODUTO_SERVICO_I;
                Alterar.PRODUTO_SERVICO_A = entidade.PRODUTO_SERVICO_A;
                Alterar.PRODUTO_SERVICO_E = entidade.PRODUTO_SERVICO_E;
                Alterar.PRODUTO_SERVICO_NAVEGA = entidade.PRODUTO_SERVICO_NAVEGA;


                Alterar.STATUS = entidade.STATUS;

                //implementar IEntidade nos Models para salvar as datas DATA_ALTERACAO e DATA_INCLUSAO
            }
            else
            {
                contexto.Perfil.Add(entidade);
            }

            contexto.SaveChanges();
        }

        //excluir o registro (altera o status do registro)
        public void ExcluirRegistro(tb_perfil entidade)
        {
            //não vou excluir o registro, apenas trocar o status para 'S'
            char StatusRegistro = 'S';
            var Excluir = contexto.Perfil.First(x => x.IDPERFIL == entidade.IDPERFIL);
                Excluir.STATUS = StatusRegistro;
            //contexto.Set<tb_perfil>().Remove(ClienteServicoFornecedorExcluir);
            contexto.SaveChanges();
        }

        //listar por id os registros ativos
        public tb_perfil ListarPorId(string id)
        {
            int idInt;
            Int32.TryParse(id, out idInt);
            var Consulta = contexto.Perfil.First(x => x.IDPERFIL == idInt && x.STATUS != 'S');
            return Consulta;
        }

        //listar todos os registros ativos
        public IEnumerable<tb_perfil> ListarTodos()
        {
            return contexto.Perfil.Where(x => x.STATUS != 'S');
        }


    }
}
