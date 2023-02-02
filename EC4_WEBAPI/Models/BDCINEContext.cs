using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace EC4_WEBAPI.Models
{
    public partial class BDCINEContext : DbContext
    {
        public BDCINEContext()
        {
        }

        public BDCINEContext(DbContextOptions<BDCINEContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Boletum> Boleta { get; set; }
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<DetalleCompra> DetalleCompras { get; set; }
        public virtual DbSet<Empleado> Empleados { get; set; }
        public virtual DbSet<Funcion> Funcions { get; set; }
        public virtual DbSet<Pelicula> Peliculas { get; set; }
        public virtual DbSet<Producto> Productos { get; set; }
        public virtual DbSet<Sala> Salas { get; set; }
        public virtual DbSet<Sede> Sedes { get; set; }
        public DbSet<PeliPorFecha> peliPorFechas { get; set; }
        public DbSet<STOCKSPE> STOCKSPES { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=.;database=BDCINE;integrated security=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AI");

            modelBuilder.Entity<Boletum>(entity =>
            {
                entity.HasKey(e => e.IdBoleta)
                    .HasName("PK__BOLETA__AD5482CD3177D506");

                entity.ToTable("BOLETA");

                entity.Property(e => e.IdBoleta)
                    .ValueGeneratedNever()
                    .HasColumnName("id_boleta");

                entity.Property(e => e.IdCliente).HasColumnName("id_cliente");

                entity.Property(e => e.IdFuncion).HasColumnName("id_funcion");

                entity.Property(e => e.Total).HasColumnName("total");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.Boleta)
                    .HasForeignKey(d => d.IdCliente)
                    .HasConstraintName("FK__BOLETA__id_clien__33D4B598");

                entity.HasOne(d => d.IdFuncionNavigation)
                    .WithMany(p => p.Boleta)
                    .HasForeignKey(d => d.IdFuncion)
                    .HasConstraintName("FK__BOLETA__id_funci__34C8D9D1");
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.IdCliente)
                    .HasName("PK__CLIENTE__677F38F599B49500");

                entity.ToTable("CLIENTE");

                entity.Property(e => e.IdCliente)
                    .ValueGeneratedNever()
                    .HasColumnName("id_cliente");

                entity.Property(e => e.Apellido)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("apellido");

                entity.Property(e => e.Correo)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("correo");

                entity.Property(e => e.Dni)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("dni");

                entity.Property(e => e.FechaNacimiento)
                    .HasColumnType("date")
                    .HasColumnName("fecha_nacimiento");

                entity.Property(e => e.Genero)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("genero");

                entity.Property(e => e.Nombres)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("nombres");

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(55)
                    .IsUnicode(false)
                    .HasColumnName("telefono");
            });

            modelBuilder.Entity<DetalleCompra>(entity =>
            {
                entity.HasKey(e => e.IdDetalleCompra)
                    .HasName("PK__DETALLE___BD16E279D45BECAA");

                entity.ToTable("DETALLE_COMPRA");

                entity.Property(e => e.IdDetalleCompra)
                    .ValueGeneratedNever()
                    .HasColumnName("id_detalle_compra");

                entity.Property(e => e.CantProducto).HasColumnName("cant_producto");

                entity.Property(e => e.IdBoleta).HasColumnName("id_boleta");

                entity.Property(e => e.IdProducto).HasColumnName("id_producto");

                entity.Property(e => e.SubTotal).HasColumnName("sub_total");

                entity.HasOne(d => d.IdBoletaNavigation)
                    .WithMany(p => p.DetalleCompras)
                    .HasForeignKey(d => d.IdBoleta)
                    .HasConstraintName("FK__DETALLE_C__id_bo__398D8EEE");

                entity.HasOne(d => d.IdProductoNavigation)
                    .WithMany(p => p.DetalleCompras)
                    .HasForeignKey(d => d.IdProducto)
                    .HasConstraintName("FK__DETALLE_C__id_pr__3A81B327");
            });

            modelBuilder.Entity<Empleado>(entity =>
            {
                entity.HasKey(e => e.IdEmpleados)
                    .HasName("PK__EMPLEADO__69D94C6CC98E2DB2");

                entity.ToTable("EMPLEADO");

                entity.Property(e => e.IdEmpleados)
                    .ValueGeneratedNever()
                    .HasColumnName("id_empleados");

                entity.Property(e => e.Apellidos)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("apellidos");

                entity.Property(e => e.Correo)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("correo");

                entity.Property(e => e.Dni)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("dni");

                entity.Property(e => e.FechaNacimiento)
                    .HasColumnType("date")
                    .HasColumnName("fecha_nacimiento");

                entity.Property(e => e.IdFuncion).HasColumnName("id_funcion");

                entity.Property(e => e.Nombres)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("nombres");

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("telefono");

                entity.Property(e => e.Turno)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("turno");

                entity.HasOne(d => d.IdFuncionNavigation)
                    .WithMany(p => p.Empleados)
                    .HasForeignKey(d => d.IdFuncion)
                    .HasConstraintName("FK__EMPLEADO__id_fun__30F848ED");
            });

            modelBuilder.Entity<Funcion>(entity =>
            {
                entity.HasKey(e => e.IdFuncion)
                    .HasName("PK__FUNCION__F6DE6FC96E82F829");

                entity.ToTable("FUNCION");

                entity.Property(e => e.IdFuncion)
                    .ValueGeneratedNever()
                    .HasColumnName("id_funcion");

                entity.Property(e => e.FechaFuncion)
                    .HasColumnType("date")
                    .HasColumnName("fecha_funcion");

                entity.Property(e => e.HoraFuncion)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("hora_funcion");

                entity.Property(e => e.IdPelicula).HasColumnName("id_pelicula");

                entity.Property(e => e.IdSala).HasColumnName("id_sala");

                entity.HasOne(d => d.IdPeliculaNavigation)
                    .WithMany(p => p.Funcions)
                    .HasForeignKey(d => d.IdPelicula)
                    .HasConstraintName("FK__FUNCION__id_peli__2C3393D0");

                entity.HasOne(d => d.IdSalaNavigation)
                    .WithMany(p => p.Funcions)
                    .HasForeignKey(d => d.IdSala)
                    .HasConstraintName("FK__FUNCION__id_sala__2B3F6F97");
            });

            modelBuilder.Entity<Pelicula>(entity =>
            {
                entity.HasKey(e => e.IdPelicula)
                    .HasName("PK__PELICULA__B5017F4D95FB6961");

                entity.ToTable("PELICULA");

                entity.Property(e => e.IdPelicula)
                    .ValueGeneratedNever()
                    .HasColumnName("id_pelicula");

                entity.Property(e => e.Clasificacion)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("clasificacion");

                entity.Property(e => e.DuracionHoras)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("duracion_horas");

                entity.Property(e => e.FechaEstreno)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("fecha_estreno");

                entity.Property(e => e.Genero)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("genero");

                entity.Property(e => e.NomPelicula)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("nom_pelicula");

                entity.Property(e => e.Sipnosis)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("sipnosis");
            });

            modelBuilder.Entity<Producto>(entity =>
            {
                entity.HasKey(e => e.IdProducto)
                    .HasName("PK__PRODUCTO__FF341C0D1484EE1A");

                entity.ToTable("PRODUCTO");

                entity.Property(e => e.IdProducto)
                    .ValueGeneratedNever()
                    .HasColumnName("id_producto");

                entity.Property(e => e.DesProducto)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("des_producto");

                entity.Property(e => e.NomProducto)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nom_producto");

                entity.Property(e => e.PreProducto).HasColumnName("pre_producto");

                entity.Property(e => e.StoProducto).HasColumnName("sto_producto");
            });

            modelBuilder.Entity<Sala>(entity =>
            {
                entity.HasKey(e => e.IdSala)
                    .HasName("PK__SALA__D18B015B2831AAD7");

                entity.ToTable("SALA");

                entity.Property(e => e.IdSala)
                    .ValueGeneratedNever()
                    .HasColumnName("id_sala");

                entity.Property(e => e.Aforo).HasColumnName("aforo");

                entity.Property(e => e.IdSede).HasColumnName("id_sede");

                entity.Property(e => e.NumSala).HasColumnName("num_sala");

                entity.HasOne(d => d.IdSedeNavigation)
                    .WithMany(p => p.Salas)
                    .HasForeignKey(d => d.IdSede)
                    .HasConstraintName("FK__SALA__id_sede__267ABA7A");
            });

            modelBuilder.Entity<Sede>(entity =>
            {
                entity.HasKey(e => e.IdSede)
                    .HasName("PK__SEDE__D693504B1236D1B1");

                entity.ToTable("SEDE");

                entity.Property(e => e.IdSede)
                    .ValueGeneratedNever()
                    .HasColumnName("id_sede");

                entity.Property(e => e.NomSede)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("nom_sede");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
