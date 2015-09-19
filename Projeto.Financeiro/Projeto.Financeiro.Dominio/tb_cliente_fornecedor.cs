using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Projeto.Financeiro.Dominio
{
    public class tb_cliente_fornecedor
    {
        [Display(Name = "Controle do Cliente/Fornecedor:")]
        public int IDCLIENTEFORNECEDOR { get; set; }

        [Display(Name = "Código do Cliente/Fornecedor:")]
        [Required(ErrorMessage = "Campo Obrigatório:")]
        public String CODIGO { get; set; }

        [Display(Name = "Tipo {cliente ou Forncedor}:")]
        [Required(ErrorMessage = "Campo Obrigatório:")]
        public String TIPO { get; set; }

        [Display(Name = "Razão Social:")]
        [Required(ErrorMessage = "Campo Obrigatório:")]
        public String RAZAO_SOCIAL { get; set; }

        [Display(Name = "Endereço:")]
        public String ENDERECO { get; set; }

        [Display(Name = "Número:")]
        public String NUMERO { get; set; }

        [Display(Name = "Complemento:")]
        public String COMPLEMENTO { get; set; }

        [Display(Name = "Bairro:")]
        public String BAIRRO { get; set; }

        [Display(Name = "Telefone:")]
        public String TELEFONE { get; set; }

        [Display(Name = "Celular:")]
        public String CELULAR { get; set; }

        [Display(Name = "Cidade:")]
        public String CIDADE { get; set; }

        [Display(Name = "UF:")]
        public String UF { get; set; }

        [Display(Name = "Cep::")]
        public String CEP { get; set; }

        [Display(Name = "CNPJ:")]
        public String CNPJ { get; set; }

        [Display(Name = "Nome do Administrador:")]
        public String NOME_ADMINISTRADOR { get; set; }

        [Display(Name = "Data de Nascimento:")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public String DATA_NASCIMENTO { get; set; }

        [Display(Name = "Email {Cliente / Fornecedor}:")]
        public String EMAIL { get; set; }

        [Display(Name = "MSN:")]
        public String MSN { get; set; }

        [Display(Name = "Skype:")]
        public String SKYPE { get; set; }

        [Display(Name = "Home Page:")]
        public String HOME_PAGE { get; set; }

        [Display(Name = "Nome do Escritório Contador:")]
        public String CONTADOR_ESCRITORIO { get; set; }

        [Display(Name = "Nome do Contador:")]
        public String CONTADOR_NOME { get; set; }

        [Display(Name = "Telefone Contador:")]
        public String CONTADOR_TELEFONE { get; set; }

        [Display(Name = "Celular Celular:")]
        public String CONTADOR_CELULAR { get; set; }

        [Display(Name = "Email Contador:")]
        public String CONTADOR_EMAIL { get; set; }

        [Display(Name = "Nome do Despachante:")]
        public String DESPACHANTE_NOME { get; set; }

        [Display(Name = "Telefone do Despachante:")]
        public String DESPACHANTE_TELEFONE { get; set; }

        [Display(Name = "Celular do Despachante:")]
        public String DESPACHANTE_CELULAR { get; set; }

        [Display(Name = "Email do Despachante:")]
        public String DESPACHANTE_EMAIL { get; set; }

        //dados de vinculo com empresa é usuário
        [Display(Name = "Controle da Empresa:")]
        [Required(ErrorMessage = "Campo Obrigatório:")]
        public virtual tb_empresa IDEMPRESA { get; set; }

        [Display(Name = "Controle do Usuário:")]
        [Required(ErrorMessage = "Campo Obrigatório:")]
        public virtual tb_usuario IDUSUARIO { get; set; }
        //dados de vinculo com empresa é usuário


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