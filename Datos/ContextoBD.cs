using Entidades.Configuraciones;
using Entidades.Configuraciones.PlanesDeEstudio;
using Entidades.Modelos.PlanesDeEstudio.AreasDeConocimiento;
using Entidades.Modelos.PlanesDeEstudio.Carreras;
using Entidades.Modelos.PlanesDeEstudio.Etapas;
using Entidades.Modelos.PlanesDeEstudio.Materias;
using Entidades.Modelos.PlanesDeEstudio.PlanEstudios;
using Entidades.Configuraciones.CurriculumVite;
using Entidades.Modelos.CurriculumVite;
using Microsoft.EntityFrameworkCore;

namespace Datos
{
    public class ContextoBD : DbContext
    {
        public ContextoBD(DbContextOptions<ContextoBD> options)
            : base(options)
        {
        }

        // Planes de Estudio DbSets
        public DbSet<E_Carrera> Carreras { get; set; }
        public DbSet<E_PlanEstudio> PlanEstudios { get; set; }
        public DbSet<E_PlanEstudioMateria> PlanEstudioMaterias { get; set; }
        public DbSet<E_Materia> Materias { get; set; }
        public DbSet<E_Etapa> Etapas { get; set; }
        public DbSet<E_AreaConocimiento> AreasConocimiento { get; set; }

        // CurriculumVite DbSets
        public DbSet<E_Distincion> Distinciones { get; set; }
        public DbSet<E_Experiencia> Experiencias { get; set; }
        public DbSet<E_TipoContacto> TipoContactos { get; set; }
        public DbSet<E_ContactoDocente> ContactoDocentes { get; set; }
        public DbSet<E_Proyecto> Proyectos { get; set; }
        public DbSet<E_Educacion> Educaciones { get; set; }
        public DbSet<E_Publicacion> Publicaciones { get; set; }
        public DbSet<E_TesisDirigida> TesisDirigidas { get; set; }
        public DbSet<E_Documento> Documentos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Planes de Estudio Configurations
            modelBuilder.ApplyConfiguration(new CarreraConfig());
            modelBuilder.ApplyConfiguration(new PlanEstudiosConfig());
            modelBuilder.ApplyConfiguration(new PlanEstudioMateriaConfig());
            modelBuilder.ApplyConfiguration(new MateriaConfig());
            modelBuilder.ApplyConfiguration(new EtapaConfig());
            modelBuilder.ApplyConfiguration(new AreaConocimientoConfig());

            // CurriculumVite Configurations
            modelBuilder.ApplyConfiguration(new E_DistincionConfig());
            modelBuilder.ApplyConfiguration(new E_ExperienciaConfig());
            modelBuilder.ApplyConfiguration(new E_TipoContactoConfig());
            modelBuilder.ApplyConfiguration(new E_ContactoDocenteConfig());
            modelBuilder.ApplyConfiguration(new E_ProyectoConfig());
            modelBuilder.ApplyConfiguration(new E_EducacionConfig());
            modelBuilder.ApplyConfiguration(new E_PublicacionConfig());
            modelBuilder.ApplyConfiguration(new E_TesisDirigidaConfig());
            modelBuilder.ApplyConfiguration(new E_DocumentoConfig());
        }
    }
}
