using System.Data.Entity.ModelConfiguration;
using IEL.Estagio.Domain.Entities;

namespace IEL.Estagio.Infra.Data.EntityConfig
{
    public class EmpresaConfiguration : EntityTypeConfiguration<Empresa>
    {
        public EmpresaConfiguration()
        {
            ToTable("Tab_Empresa");

            // Primary Key
            this.HasKey(t => t.idempresa);

            // Properties
            this.Property(t => t.cod_notes)
                .HasMaxLength(30);

            this.Property(t => t.cnpj)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.flg_pessoa_fisica)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.num_registro_conselho)
                .HasMaxLength(50);

            this.Property(t => t.nome_fantasia)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.razao_social)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.tipo_especial)
                .IsFixedLength()
                .HasMaxLength(2);

            this.Property(t => t.tipo_empresa)
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.porte)
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.site_web)
                .HasMaxLength(255);

            this.Property(t => t.horario_funcionamento)
                .HasMaxLength(50);

            this.Property(t => t.email_rh)
                .HasMaxLength(200);

            this.Property(t => t.email_financeiro)
                .HasMaxLength(200);

            this.Property(t => t.email_contrato)
                .HasMaxLength(200);

            this.Property(t => t.email_dp)
                .HasMaxLength(200);

            this.Property(t => t.ativo)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.flg_termo_devolvido)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.flg_fatura_sem_tce_ass)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.flg_bolsa_sem_tce_ass)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.usu_cadastro)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.usu_alteracao)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Tab_Empresa");
            this.Property(t => t.idempresa).HasColumnName("idempresa");
            this.Property(t => t.cod_notes).HasColumnName("cod_notes");
            this.Property(t => t.cnpj).HasColumnName("cnpj");
            this.Property(t => t.flg_pessoa_fisica).HasColumnName("flg_pessoa_fisica");
            this.Property(t => t.num_registro_conselho).HasColumnName("num_registro_conselho");
            this.Property(t => t.nome_fantasia).HasColumnName("nome_fantasia");
            this.Property(t => t.razao_social).HasColumnName("razao_social");
            this.Property(t => t.tipo_especial).HasColumnName("tipo_especial");
            this.Property(t => t.tipo_empresa).HasColumnName("tipo_empresa");
            this.Property(t => t.porte).HasColumnName("porte");
            this.Property(t => t.site_web).HasColumnName("site_web");
            this.Property(t => t.num_funcionarios).HasColumnName("num_funcionarios");
            this.Property(t => t.horario_funcionamento).HasColumnName("horario_funcionamento");
            this.Property(t => t.idareaatuacao).HasColumnName("idareaatuacao");
            this.Property(t => t.email_rh).HasColumnName("email_rh");
            this.Property(t => t.email_financeiro).HasColumnName("email_financeiro");
            this.Property(t => t.email_contrato).HasColumnName("email_contrato");
            this.Property(t => t.email_dp).HasColumnName("email_dp");
            this.Property(t => t.idresponsavel).HasColumnName("idresponsavel");
            this.Property(t => t.dt_visita_realizada).HasColumnName("dt_visita_realizada");
            this.Property(t => t.unid_primeiro_cadastro).HasColumnName("unid_primeiro_cadastro");
            this.Property(t => t.unid_controle_taxa).HasColumnName("unid_controle_taxa");
            this.Property(t => t.ativo).HasColumnName("ativo");
            this.Property(t => t.flg_termo_devolvido).HasColumnName("flg_termo_devolvido");
            this.Property(t => t.flg_fatura_sem_tce_ass).HasColumnName("flg_fatura_sem_tce_ass");
            this.Property(t => t.flg_bolsa_sem_tce_ass).HasColumnName("flg_bolsa_sem_tce_ass");
            this.Property(t => t.dt_cadastro).HasColumnName("dt_cadastro");
            this.Property(t => t.usu_cadastro).HasColumnName("usu_cadastro");
            this.Property(t => t.dt_alteracao).HasColumnName("dt_alteracao");
            this.Property(t => t.usu_alteracao).HasColumnName("usu_alteracao");

            // Relationships
            //this.HasOptional(t => t.Tab_Areaatuacao)
            //    .WithMany(t => t.Tab_Empresa)
            //    .HasForeignKey(d => d.idareaatuacao);
            //this.HasRequired(t => t.Tab_Unidade)
            //    .WithMany(t => t.Tab_Empresa)
            //    .HasForeignKey(d => d.unid_controle_taxa);
            //this.HasRequired(t => t.Tab_Unidade1)
            //    .WithMany(t => t.Tab_Empresa1)
            //    .HasForeignKey(d => d.unid_primeiro_cadastro);
            //this.HasOptional(t => t.Tab_Usuario)
            //    .WithMany(t => t.Tab_Empresa)
            //    .HasForeignKey(d => d.idresponsavel);
        }
    }
}
