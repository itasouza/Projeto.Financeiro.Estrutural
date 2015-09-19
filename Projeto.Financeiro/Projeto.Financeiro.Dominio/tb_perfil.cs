using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Projeto.Financeiro.Dominio
{
    public class tb_perfil
    {
        [Display(Name = "Controle do Perfil:")]
        public int IDPERFIL { get; set; }

        [Display(Name = "Descrição do Perfil:")]
        [Required(ErrorMessage = "Campo Obrigatório:")]
        public String DESCRICAO_PERFIL { get; set; }

        [Display(Name = "Controle da Empresa:")]
        [Required(ErrorMessage = "Campo Obrigatório:")]
        public tb_empresa IDEMPRESA { get; set; }

        [Display(Name = "Visualiza Perfil?:")]
        public String PERFIL { get; set; }

        [Display(Name = "Visualiza Empresa?:")]
        public String EMPRESA { get; set; }
        [Display(Name = "Inclui Empresa?:")]
        public String EMPRESA_I { get; set; }
        [Display(Name = "Altera Empresa?:")]
        public String EMPRESA_A { get; set; }
        [Display(Name = "Exclui Empresa?:")]
        public String EMPRESA_E { get; set; }
        [Display(Name = "Navega Registro Empresa?:")]
        public String EMPRESA_NAVEGA { get; set; }

        [Display(Name = "Visualiza Cliente?:")]
        public String CLIENTE { get; set; }
        [Display(Name = "Inclui Cliente?:")]
        public String CLIENTE_I { get; set; }
        [Display(Name = "Altera Cliente?:")]
        public String CLIENTE_A { get; set; }
        [Display(Name = "Exclui Cliente?:")]
        public String CLIENTE_E { get; set; }
        [Display(Name = "Navega Cliente?:")]
        public String CLIENTE_NAVEGA { get; set; }

        [Display(Name = "Visualiza Plano Contas?:")]
        public String PLANOCONTAS { get; set; }
        [Display(Name = "Inclui Plano Contas?:")]
        public String PLANOCONTAS_I { get; set; }
        [Display(Name = "Altera Plano Contas?:")]
        public String PLANOCONTAS_A { get; set; }
        [Display(Name = "Exclui Plano Contas?:")]
        public String PLANOCONTAS_E { get; set; }
        [Display(Name = "Navega Plano Contas?:")]
        public String PLANOCONTAS_NAVEGA { get; set; }


        [Display(Name = "Visualiza Usuário?:")]
        public String USUARIO { get; set; }
        [Display(Name = "Inclui Usuário?:")]
        public String USUARIO_I { get; set; }
        [Display(Name = "Altera Usuário?:")]
        public String USUARIO_A { get; set; }
        [Display(Name = "Exclui Usuário?:")]
        public String USUARIO_E { get; set; }
        [Display(Name = "Navega Usuário?:")]
        public String USUARIO_NAVEGA { get; set; }


        [Display(Name = "Visualiza Banco?:")]
        public String BANCO { get; set; }
        [Display(Name = "Inclui Banco?:")]
        public String BANCO_I { get; set; }
        [Display(Name = "Altera Banco?:")]
        public String BANCO_A { get; set; }
        [Display(Name = "Exclui Banco?:")]
        public String BANCO_E { get; set; }
        [Display(Name = "Navega Banco?:")]
        public String BANCO_NAVEGA { get; set; }

        [Display(Name = "Visualiza Contas Pagar?:")]
        public String CONTASPAGAR { get; set; }
        [Display(Name = "Inclui Contas Pagar?:")]
        public String CONTASPAGAR_I { get; set; }
        [Display(Name = "Altera Contas Pagar?:")]
        public String CONTASPAGAR_A { get; set; }
        [Display(Name = "Exclui Contas Pagar?:")]
        public String CONTASPAGAR_E { get; set; }
        [Display(Name = "Navega Contas Pagar?:")]
        public String CONTASPAGAR_NAVEGA { get; set; }


        [Display(Name = "Visualiza Contas Receber?:")]
        public String CONTASRECEBER { get; set; }
        [Display(Name = "Inclui Contas Receber?:")]
        public String CONTASRECEBER_I { get; set; }
        [Display(Name = "Altera Contas Receber?:")]
        public String CONTASRECEBER_A { get; set; }
        [Display(Name = "Exclui Contas Receber?:")]
        public String CONTASRECEBER_E { get; set; }
        [Display(Name = "Navega Contas Receber?:")]
        public String CONTASRECEBER_NAVEGA { get; set; }



        [Display(Name = "Visualiza Recibo?:")]
        public String RECIBO { get; set; }
        [Display(Name = "Inclui Recibo?:")]
        public String RECIBO_I { get; set; }
        [Display(Name = "Altera Recibo?:")]
        public String RECIBO_A { get; set; }
        [Display(Name = "Exclui Recibo?:")]
        public String RECIBO_E { get; set; }
        [Display(Name = "Navega Recibo?:")]
        public String RECIBO_NAVEGA { get; set; }

        [Display(Name = "Visualiza Boleto?:")]
        public String BOLETO { get; set; }
        [Display(Name = "Inclui Boleto?:")]
        public String BOLETO_I { get; set; }
        [Display(Name = "Altera Boleto?:")]
        public String BOLETO_A { get; set; }
        [Display(Name = "Exclui Boleto?:")]
        public String BOLETO_E { get; set; }
        [Display(Name = "Navega Boleto?:")]
        public String BOLETO_NAVEGA { get; set; }

        [Display(Name = "Visualiza Produto/Serviço?:")]
        public String PRODUTO_SERVICO { get; set; }
        [Display(Name = "Inclui Produto/Serviço?:")]
        public String PRODUTO_SERVICO_I { get; set; }
        [Display(Name = "Altera Produto/Serviço?:")]
        public String PRODUTO_SERVICO_A { get; set; }
        [Display(Name = "Exclui Produto/Serviço?:")]
        public String PRODUTO_SERVICO_E { get; set; }
        [Display(Name = "Navega Produto/Serviço?:")]
        public String PRODUTO_SERVICO_NAVEGA { get; set; }


        [Display(Name = "Registro ativo ou Inativo")]
        public Char STATUS { get; set; }
        [Display(Name = "Data da Inclusão do Registro")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DATA_INC { get; set; }
        [Display(Name = "Data da Alteração do Registro")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DATA_ALT { get; set; }
    }
}