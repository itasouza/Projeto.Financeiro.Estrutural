using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Projeto.Financeiro.Dominio
{
    public class tb_usuario
    {
        [Display(Name = "Controle do Usuário:")]
        public int IDUSUARIO { get; set; }

        //dados de vinculo com empresa é perfil
        [Display(Name = "Selecione a Empresa:")]
        [Required(ErrorMessage = "Campo Obrigatório:")]
        public virtual tb_empresa IDEMPRESA { get; set; }

        [Display(Name = "Selecione o Perfil de Acesso:")]
        [Required(ErrorMessage = "Campo Obrigatório:")]
        public virtual tb_perfil IDPERFIL { get; set; }
        //dados de vinculo com empresa é perfil

        [Display(Name = "Nome do Usuário:")]
        [Required(ErrorMessage = "Campo Obrigatório:")]
        public String NOME_USUARIO { get; set; }

        [Display(Name = "Telefone:")]
        public String TELEFONE { get; set; }

        [Display(Name = "Email:")]
        [EmailAddress(ErrorMessage = "E-mail inválido")]
        public String EMAIL { get; set; }

        [Display(Name = "Celular:")]
        public String CELULAR { get; set; }

        [Display(Name = "É um vendedor?:")]
        public String VENDEDOR { get; set; }

        [Display(Name = "É um parceiro?:")]
        public String PARCEIRO { get; set; }

        [Display(Name = "É um parceiro Jurídico?:")]
        public String JURIDICO { get; set; }

        [Display(Name = "Endereço:")]
        public String ENDERECO { get; set; }

        [Display(Name = "Número:")]
        public String NUMERO { get; set; }

        [Display(Name = "Complemento:")]
        public String COMPLEMENTO { get; set; }

        [Display(Name = "Bairro:")]
        public String BAIRRO { get; set; }

        [Display(Name = "Cidade:")]
        public String CIDADE { get; set; }

        [Display(Name = "Cep:")]
        public String CEP { get; set; }

        [Display(Name = "CNPJ:")]
        public String CNPJ { get; set; }

        [Display(Name = "CPF:")]
        public String CPF { get; set; }


        [Display(Name = "Senha de Acesso:")]
        [Required(ErrorMessage = "Campo Obrigatório:")]
        [DataType(DataType.Password)]
        public String SENHA { get; set; }

        [Display(Name = "Login de Acesso:")]
        [Required(ErrorMessage = "Campo Obrigatório:")]
        [EmailAddress(ErrorMessage = "E-mail inválido")]
        public String LOGIN { get; set; }

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