using System.Data.Entity.ModelConfiguration;
using IEL.Estagio.Domain.Entities;

namespace IEL.Estagio.Infra.Data.EntityConfig
{
    public class VagaConfiguration : EntityTypeConfiguration<Vaga>
    {
        public VagaConfiguration()
        {
            ToTable("Tab_Vaga");

            // Primary Key
            this.HasKey(t => t.idvaga);

            // Properties
            this.Property(t => t.cod_notes)
                .HasMaxLength(30);

            this.Property(t => t.tipo_vaga)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.flg_publica_web)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.flg_ativo)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.pode_candidatar)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.contato)
                .HasMaxLength(200);

            this.Property(t => t.ddd_telefone)
                .HasMaxLength(3);

            this.Property(t => t.telefone)
                .HasMaxLength(15);

            this.Property(t => t.email)
                .HasMaxLength(150);

            this.Property(t => t.contato2)
                .HasMaxLength(200);

            this.Property(t => t.ddd_telefone2)
                .HasMaxLength(3);

            this.Property(t => t.telefone2)
                .HasMaxLength(15);

            this.Property(t => t.email2)
                .HasMaxLength(150);

            this.Property(t => t.bairro)
                .HasMaxLength(150);

            this.Property(t => t.num_na_empresa)
                .HasMaxLength(50);

            this.Property(t => t.sexo)
                .HasMaxLength(25);

            this.Property(t => t.necessita_habilitacao)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.possuir_veiculo)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.deficiente)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.tipo_deficiente)
                .HasMaxLength(100);

            this.Property(t => t.turno)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.descr_a_combinar)
                .HasMaxLength(200);

            this.Property(t => t.ch_dia)
                .HasMaxLength(5);

            this.Property(t => t.dias_semana)
                .HasMaxLength(50);

            this.Property(t => t.por_semana)
                .HasMaxLength(5);

            this.Property(t => t.possibilidade_contratacao)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.transporte)
                .HasMaxLength(200);

            this.Property(t => t.alimentacao)
                .HasMaxLength(200);

            this.Property(t => t.outros_beneficios)
                .HasMaxLength(200);

            this.Property(t => t.supervisor)
                .HasMaxLength(150);

            this.Property(t => t.cargo_supervisor)
                .HasMaxLength(150);

            this.Property(t => t.motivo_suspensao)
                .HasMaxLength(200);

            this.Property(t => t.usu_cancelamento)
                .HasMaxLength(100);

            this.Property(t => t.usu_cadastro)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.usu_alteracao)
                .HasMaxLength(100);

            this.Property(t => t.flg_permite_formandos)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.supervisor_num_conselhoprof)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Tab_Vaga");
            this.Property(t => t.idvaga).HasColumnName("idvaga");
            this.Property(t => t.idempresa).HasColumnName("idempresa");
            this.Property(t => t.idareaestagio).HasColumnName("idareaestagio");
            this.Property(t => t.idunidade).HasColumnName("idunidade");
            this.Property(t => t.cod_notes).HasColumnName("cod_notes");
            this.Property(t => t.tipo_vaga).HasColumnName("tipo_vaga");
            this.Property(t => t.flg_publica_web).HasColumnName("flg_publica_web");
            this.Property(t => t.flg_ativo).HasColumnName("flg_ativo");
            this.Property(t => t.qtd_vagas).HasColumnName("qtd_vagas");
            this.Property(t => t.qtd_max_vagas).HasColumnName("qtd_max_vagas");
            this.Property(t => t.pode_candidatar).HasColumnName("pode_candidatar");
            this.Property(t => t.qtd_vagas_candidatar).HasColumnName("qtd_vagas_candidatar");
            this.Property(t => t.qtd_vaga_cancelada).HasColumnName("qtd_vaga_cancelada");
            this.Property(t => t.contato).HasColumnName("contato");
            this.Property(t => t.ddd_telefone).HasColumnName("ddd_telefone");
            this.Property(t => t.telefone).HasColumnName("telefone");
            this.Property(t => t.email).HasColumnName("email");
            this.Property(t => t.contato2).HasColumnName("contato2");
            this.Property(t => t.ddd_telefone2).HasColumnName("ddd_telefone2");
            this.Property(t => t.telefone2).HasColumnName("telefone2");
            this.Property(t => t.email2).HasColumnName("email2");
            this.Property(t => t.bairro).HasColumnName("bairro");
            this.Property(t => t.num_na_empresa).HasColumnName("num_na_empresa");
            this.Property(t => t.sexo).HasColumnName("sexo");
            this.Property(t => t.pre_req_adicional).HasColumnName("pre_req_adicional");
            this.Property(t => t.necessita_habilitacao).HasColumnName("necessita_habilitacao");
            this.Property(t => t.possuir_veiculo).HasColumnName("possuir_veiculo");
            this.Property(t => t.deficiente).HasColumnName("deficiente");
            this.Property(t => t.tipo_deficiente).HasColumnName("tipo_deficiente");
            this.Property(t => t.observacao).HasColumnName("observacao");
            this.Property(t => t.testes_aplicados).HasColumnName("testes_aplicados");
            this.Property(t => t.duracao).HasColumnName("duracao");
            this.Property(t => t.turno).HasColumnName("turno");
            this.Property(t => t.descr_a_combinar).HasColumnName("descr_a_combinar");
            this.Property(t => t.hora_inicio).HasColumnName("hora_inicio");
            this.Property(t => t.hora_fim).HasColumnName("hora_fim");
            this.Property(t => t.hora_almoco_ini).HasColumnName("hora_almoco_ini");
            this.Property(t => t.hora_almoco_fim).HasColumnName("hora_almoco_fim");
            this.Property(t => t.ch_dia).HasColumnName("ch_dia");
            this.Property(t => t.dias_semana).HasColumnName("dias_semana");
            this.Property(t => t.por_semana).HasColumnName("por_semana");
            this.Property(t => t.possibilidade_contratacao).HasColumnName("possibilidade_contratacao");
            this.Property(t => t.dt_recesso_inicio).HasColumnName("dt_recesso_inicio");
            this.Property(t => t.dt_recesso_fim).HasColumnName("dt_recesso_fim");
            this.Property(t => t.dt_recesso_inicio2).HasColumnName("dt_recesso_inicio2");
            this.Property(t => t.dt_recesso_fim2).HasColumnName("dt_recesso_fim2");
            this.Property(t => t.valor_bolsa).HasColumnName("valor_bolsa");
            this.Property(t => t.valor_transporte).HasColumnName("valor_transporte");
            this.Property(t => t.transporte).HasColumnName("transporte");
            this.Property(t => t.alimentacao).HasColumnName("alimentacao");
            this.Property(t => t.outros_beneficios).HasColumnName("outros_beneficios");
            this.Property(t => t.supervisor).HasColumnName("supervisor");
            this.Property(t => t.cargo_supervisor).HasColumnName("cargo_supervisor");
            this.Property(t => t.obs_caracteristica).HasColumnName("obs_caracteristica");
            this.Property(t => t.atividades).HasColumnName("atividades");
            this.Property(t => t.expectativa_aprendizagem).HasColumnName("expectativa_aprendizagem");
            this.Property(t => t.dt_abertura).HasColumnName("dt_abertura");
            this.Property(t => t.dt_suspensao).HasColumnName("dt_suspensao");
            this.Property(t => t.motivo_suspensao).HasColumnName("motivo_suspensao");
            this.Property(t => t.dt_fechamento).HasColumnName("dt_fechamento");
            this.Property(t => t.dt_prox_acompanhamento).HasColumnName("dt_prox_acompanhamento");
            this.Property(t => t.idmotivo_cancelamento).HasColumnName("idmotivo_cancelamento");
            this.Property(t => t.dt_ult_cancelamento).HasColumnName("dt_ult_cancelamento");
            this.Property(t => t.usu_cancelamento).HasColumnName("usu_cancelamento");
            this.Property(t => t.idresponsavel).HasColumnName("idresponsavel");
            this.Property(t => t.dt_cadastro).HasColumnName("dt_cadastro");
            this.Property(t => t.usu_cadastro).HasColumnName("usu_cadastro");
            this.Property(t => t.dt_alteracao).HasColumnName("dt_alteracao");
            this.Property(t => t.usu_alteracao).HasColumnName("usu_alteracao");
            this.Property(t => t.flg_permite_formandos).HasColumnName("flg_permite_formandos");
            this.Property(t => t.idperfilvaga).HasColumnName("idperfilvaga");
            this.Property(t => t.valor_sel_diferenciada).HasColumnName("valor_sel_diferenciada");
            this.Property(t => t.supervisor_idconselhoprof).HasColumnName("supervisor_idconselhoprof");
            this.Property(t => t.supervisor_num_conselhoprof).HasColumnName("supervisor_num_conselhoprof");
            this.Property(t => t.idwebvaga).HasColumnName("idwebvaga");

            // Relationships
            //this.HasRequired(t => t.Tab_Areaestagio)
            //    .WithMany(t => t.Tab_Vaga)
            //    .HasForeignKey(d => d.idareaestagio);
            //this.HasOptional(t => t.Tab_ConselhoProfissional)
            //    .WithMany(t => t.Tab_Vaga)
            //    .HasForeignKey(d => d.supervisor_idconselhoprof);
            this.HasRequired(t => t.Empresa)
                .WithMany(t => t.Vaga)
                .HasForeignKey(d => d.idempresa);
            //this.HasOptional(t => t.Tab_Motivo)
            //    .WithMany(t => t.Tab_Vaga)
            //    .HasForeignKey(d => d.idmotivo_cancelamento);
            //this.HasRequired(t => t.Tab_Perfil_Vaga)
            //    .WithMany(t => t.Tab_Vaga)
            //    .HasForeignKey(d => d.idperfilvaga);
            //this.HasRequired(t => t.Tab_Unidade)
            //    .WithMany(t => t.Tab_Vaga)
            //    .HasForeignKey(d => d.idunidade);
            //this.HasOptional(t => t.Tab_Usuario)
            //    .WithMany(t => t.Tab_Vaga)
            //    .HasForeignKey(d => d.idresponsavel);
            //this.HasOptional(t => t.Tab_WebVaga)
            //    .WithMany(t => t.Tab_Vaga)
            //    .HasForeignKey(d => d.idwebvaga);
        }
    }
}
