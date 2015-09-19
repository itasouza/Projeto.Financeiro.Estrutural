using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Projeto.Financeiro.Dominio
{
    public class tb_banco
    {
        [Display(Name = "Controle do Banco:")]
        public int IDBANCO { get; set; }

        [Display(Name = "Nome do Gerente:")]
        public String NOME_GERENTE { get; set; }

        [Display(Name = "Telefone:")]

        public String TELEFONE { get; set; }
        [Display(Name = "Celular:")]
        public String CELULAR { get; set; }


        //dados de vinculo com empresa é usuário
        [Display(Name = "Controle da Empresa:")]
        [Required(ErrorMessage = "Campo Obrigatório:")]
        public virtual tb_empresa IDEMPRESA { get; set; }

        [Display(Name = "Controle do Usuário:")]
        [Required(ErrorMessage = "Campo Obrigatório:")]
        public virtual tb_usuario IDUSUARIO { get; set; }
        //dados de vinculo com empresa é usuário


        [Display(Name = "Chave da Conta:")]
        public String BOLETO_CHAVECONTA { get; set; }
        [Display(Name = "Nome do Banco:")]
        public String BOLETO_BANCO { get; set; }
        [Display(Name = "Agência:")]
        public String BOLETO_AGENCIA { get; set; }
        [Display(Name = "Conta:")]
        public String BOLETO_CONTA { get; set; }
        [Display(Name = "Código:")]
        public String BOLETO_CODIGO { get; set; }
        [Display(Name = "Nome do Cedente:")]
        public String BOLETO_NOMECEDENTE { get; set; }
        [Display(Name = "Cnpj/ CPF Do Cedente:")]
        public String BOLETO_CPFCNPJ { get; set; }
        [Display(Name = "Início Nosso Número:")]
        public String BOLETO_INICIONOSSONUMERO { get; set; }
        [Display(Name = "Fim Nosso Número:")]
        public String BOLETO_FIMNOSSONUMERO { get; set; }
        [Display(Name = "Próximo Número:")]
        public String BOLETO_PROXIMONUMERO { get; set; }
        [Display(Name = "Arquivo Licença:")]
        public String BOLETO_ARQUIVOLICENCA { get; set; }
        [Display(Name = "Email do Cedente:")]
        public String BOLETO_EMAILCEDENTE { get; set; }
        [Display(Name = "Caminho do Logotipo:")]
        public String BOLETO_CAMINHOLOGOTIPO { get; set; }
        [Display(Name = "Boleto Identificação:")]
        public String BOLETO_IDENTIFICACAO { get; set; }



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