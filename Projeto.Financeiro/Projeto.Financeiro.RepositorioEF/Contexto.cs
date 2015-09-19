using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Financeiro.Dominio;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Validation;

namespace Projeto.Financeiro.RepositorioEF
{
    public class Contexto:DbContext
    {
 
        public  Contexto() : base("BancoDados")
        {

        }

        //alterando o SaveChanges() para gravar a data de inclusão é alteração
        public override int SaveChanges()
        {
            var Contexto = ((IObjectContextAdapter)this).ObjectContext;

            IEnumerable<ObjectStateEntry> objectStateEntries =
            from e in Contexto.ObjectStateManager.GetObjectStateEntries(EntityState.Added | EntityState.Modified)
            where
                e.IsRelationship == false &&
                e.Entity != null &&
                typeof(IEntidade).IsAssignableFrom(e.Entity.GetType())
            select e;

            var dataAtual = DateTime.Now;

            foreach (var entry in objectStateEntries)
            {
                dynamic entityBase = entry.Entity;

                if (entry.State == EntityState.Added || entityBase.DataCriacao == DateTime.MinValue)
                {
                    entityBase.DATA_INCLUSAO = dataAtual;

                }

                entityBase.DATA_ALTERACAO = dataAtual;
            }

            try
            {
                return base.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }
        }


        public DbSet<tb_banco> Banco { get; set; }
        public DbSet<tb_boleto_emitido> Boleto { get; set; }
        public DbSet<tb_cliente_fornecedor> ClienteFornecedor { get; set; }
        public DbSet<tb_cliente_servico> ClienteServico { get; set; }
        public DbSet<tb_empresa> Empresa { get; set; }
        public DbSet<tb_perfil> Perfil { get; set; }
        public DbSet<tb_plano_contas> PlanoContas { get; set; }
        public DbSet<tb_produto_servico> ProdutoServico { get; set; }
        public DbSet<tb_recibo> Recibo { get; set; }
        public DbSet<tb_usuario> Usuario { get; set; }

  


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<tb_banco>().ToTable("Banco");
            modelBuilder.Entity<tb_boleto_emitido>().ToTable("Boleto");
            modelBuilder.Entity<tb_cliente_fornecedor>().ToTable("ClienteFornecedor");
            modelBuilder.Entity<tb_cliente_servico>().ToTable("ClienteServico");
            modelBuilder.Entity<tb_empresa>().ToTable("Empresa");
            modelBuilder.Entity<tb_perfil>().ToTable("Perfil");
            modelBuilder.Entity<tb_plano_contas>().ToTable("PlanoContas");
            modelBuilder.Entity<tb_produto_servico>().ToTable("ProdutoServico");
            modelBuilder.Entity<tb_recibo>().ToTable("Recibo");
            modelBuilder.Entity<tb_usuario>().ToTable("Usuario");
        }


    }
}
