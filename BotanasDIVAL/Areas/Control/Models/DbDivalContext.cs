﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

namespace BotanasDIVAL.Models
{
    public partial class DbDivalContext : DbContext
    {
        private readonly IConfiguration configuration;
        public DbDivalContext(IConfiguration config)
        {
            this.configuration = config;
        }

        public DbDivalContext(DbContextOptions<DbDivalContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Almacen> Almacen { get; set; }
        public virtual DbSet<Categorias> Categorias { get; set; }
        public virtual DbSet<Compra> Compras { get; set; }
        public virtual DbSet<DetalleCompra> DetalleCompra { get; set; }
        public virtual DbSet<DetallePedido> DetallePedido { get; set; }
        public virtual DbSet<DetalleVenta> DetalleVenta { get; set; }
        public virtual DbSet<Ingredientes> Ingredientes { get; set; }
        public virtual DbSet<Inventario> Inventario { get; set; }
        public virtual DbSet<ListasIngredientes> ListasIngredientes { get; set; }
        public virtual DbSet<Pedidos> Pedidos { get; set; }
        public virtual DbSet<Presentaciones> Presentaciones { get; set; }
        public virtual DbSet<Productos> Productos { get; set; }
        public virtual DbSet<Recetas> Recetas { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<UnidadesMedida> UnidadesMedida { get; set; }
        public virtual DbSet<Venta> Ventas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql(configuration.GetConnectionString("BotanasDIVALContext"));        
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Almacen>(entity =>
            {
                entity.HasKey(e => e.IdAlmacen);

                entity.ToTable("almacen");

                entity.HasIndex(e => e.IdAlmacen)
                    .HasName("Id_Inventario_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.IdIngrediente)
                    .HasName("fk_Almac_Ingred_idx");

                entity.HasIndex(e => e.Status)
                    .HasName("fk_Invent_Status_idx");

                entity.Property(e => e.IdAlmacen)
                    .HasColumnName("Id_Almacen")
                    .HasColumnType("int(10)");

                entity.Property(e => e.Cantidad).HasColumnType("int(5)");

                entity.Property(e => e.FechaCaducidad)
                    .HasColumnName("Fecha_Caducidad")
                    .HasColumnType("date");

                entity.Property(e => e.IdIngrediente)
                    .HasColumnName("Id_Ingrediente")
                    .HasColumnType("int(10)");

                entity.Property(e => e.Observaciones).HasColumnType("varchar(100)");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnType("varchar(1)");

                entity.HasOne(d => d.IdIngredienteNavigation)
                    .WithMany(p => p.Almacen)
                    .HasForeignKey(d => d.IdIngrediente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Almac_Ingred");

                entity.HasOne(d => d.StatusNavigation)
                    .WithMany(p => p.Almacen)
                    .HasPrincipalKey(p => p.Status1)
                    .HasForeignKey(d => d.Status)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Almac_Status");
            });

            modelBuilder.Entity<Categorias>(entity =>
            {
                entity.HasKey(e => e.IdCategoria);

                entity.ToTable("categorias");

                entity.HasIndex(e => e.IdCategoria)
                    .HasName("Id_Categoría_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.Status)
                    .HasName("fk_Categ_Status_idx");

                entity.Property(e => e.IdCategoria)
                    .HasColumnName("Id_Categoria")
                    .HasColumnType("int(3)");

                entity.Property(e => e.NombreCategoria)
                    .IsRequired()
                    .HasColumnName("Nombre_Categoria")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Observaciones).HasColumnType("varchar(100)");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnType("varchar(1)");

                entity.HasOne(d => d.StatusNavigation)
                    .WithMany(p => p.Categorias)
                    .HasPrincipalKey(p => p.Status1)
                    .HasForeignKey(d => d.Status)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Categ_Status");
            });

            modelBuilder.Entity<Compra>(entity =>
            {
                entity.HasKey(e => e.IdCompra);

                entity.ToTable("compras");

                entity.HasIndex(e => e.IdCompra)
                    .HasName("Id_Compra_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.Status)
                    .HasName("fk_Comp_Status_idx");

                entity.Property(e => e.IdCompra)
                    .HasColumnName("Id_Compra")
                    .HasColumnType("int(10)");

                entity.Property(e => e.FechaCompra)
                    .HasColumnName("Fecha_Compra")
                    .HasColumnType("date");

                entity.Property(e => e.LugarCompra)
                    .HasColumnName("Lugar_Compra")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Observaciones).HasColumnType("varchar(100)");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnType("varchar(1)");

                entity.Property(e => e.TotalCompra).HasColumnName("Total_Compra");

                entity.HasOne(d => d.StatusNavigation)
                    .WithMany(p => p.Compras)
                    .HasPrincipalKey(p => p.Status1)
                    .HasForeignKey(d => d.Status)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Comp_Status");
            });

            modelBuilder.Entity<DetalleCompra>(entity =>
            {
                entity.HasKey(e => e.IdDetCompra);

                entity.ToTable("detalle_compra");

                entity.HasIndex(e => e.IdCompra)
                    .HasName("fk_DetComp_Comp_idx");

                entity.HasIndex(e => e.IdDetCompra)
                    .HasName("Id_DetCompra_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.IdIngrediente)
                    .HasName("fk_DetComp_Ingred_idx");

                entity.HasIndex(e => e.Status)
                    .HasName("fk_DetComp_Status_idx");

                entity.Property(e => e.IdDetCompra)
                    .HasColumnName("Id_DetCompra")
                    .HasColumnType("int(10)");

                entity.Property(e => e.IdCompra)
                    .HasColumnName("Id_Compra")
                    .HasColumnType("int(10)");

                entity.Property(e => e.IdIngrediente)
                    .HasColumnName("Id_Ingrediente")
                    .HasColumnType("int(10)");

                entity.Property(e => e.Observaciones).HasColumnType("varchar(100)");

                entity.Property(e => e.Precio).HasColumnName("Precio");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnType("varchar(1)");

                entity.HasOne(d => d.IdCompraNavigation)
                    .WithMany(p => p.DetalleCompra)
                    .HasForeignKey(d => d.IdCompra)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_DetComp_Comp");

                entity.HasOne(d => d.IdIngredienteNavigation)
                    .WithMany(p => p.DetalleCompra)
                    .HasForeignKey(d => d.IdIngrediente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_DetComp_Ingred");

                entity.HasOne(d => d.StatusNavigation)
                    .WithMany(p => p.DetalleCompra)
                    .HasPrincipalKey(p => p.Status1)
                    .HasForeignKey(d => d.Status)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_DetComp_Status");
            });

            modelBuilder.Entity<DetallePedido>(entity =>
            {
                entity.HasKey(e => e.IdDetPedido);

                entity.ToTable("detalle_pedido");

                entity.HasIndex(e => e.CodProducto)
                    .HasName("fk_detalle_pedido_productos1_idx");

                entity.HasIndex(e => e.IdDetPedido)
                    .HasName("Id_DetPedido_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.IdPedido)
                    .HasName("fk_detalle_pedido_pedidos1_idx");

                entity.HasIndex(e => e.Status)
                    .HasName("fk_detalle_pedido_status1_idx");

                entity.Property(e => e.IdDetPedido)
                    .HasColumnName("Id_DetPedido")
                    .HasColumnType("int(10)");

                entity.Property(e => e.Cantidad).HasColumnType("int(4)");

                entity.Property(e => e.CodProducto)
                    .IsRequired()
                    .HasColumnName("Cod_Producto")
                    .HasColumnType("varchar(8)");

                entity.Property(e => e.IdPedido)
                    .HasColumnName("Id_Pedido")
                    .HasColumnType("int(10)");

                entity.Property(e => e.Observaciones).HasColumnType("varchar(100)");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnType("varchar(1)");

                entity.HasOne(d => d.CodProductoNavigation)
                    .WithMany(p => p.DetallePedido)
                    .HasPrincipalKey(p => p.CodProducto)
                    .HasForeignKey(d => d.CodProducto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_DetPedido_Productos");

                entity.HasOne(d => d.IdPedidoNavigation)
                    .WithMany(p => p.DetallePedido)
                    .HasForeignKey(d => d.IdPedido)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_DetPedido_Pedidos");

                entity.HasOne(d => d.StatusNavigation)
                    .WithMany(p => p.DetallePedido)
                    .HasPrincipalKey(p => p.Status1)
                    .HasForeignKey(d => d.Status)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_DetPedido_Status");
            });

            modelBuilder.Entity<DetalleVenta>(entity =>
            {
                entity.HasKey(e => e.IdDetVenta);

                entity.ToTable("detalle_venta");

                entity.HasIndex(e => e.CodProducto)
                    .HasName("fk_DetVta_Prod_idx");

                entity.HasIndex(e => e.IdDetVenta)
                    .HasName("Id_DVta_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.IdVenta)
                    .HasName("fk_Vent_Fact_idx");

                entity.HasIndex(e => e.Status)
                    .HasName("fk_DetVta_Status_idx");

                entity.Property(e => e.IdDetVenta)
                    .HasColumnName("Id_DetVenta")
                    .HasColumnType("int(10)");

                entity.Property(e => e.Cantidad).HasColumnType("int(4)");

                entity.Property(e => e.CodProducto)
                    .IsRequired()
                    .HasColumnName("Cod_Producto")
                    .HasColumnType("varchar(8)");

                entity.Property(e => e.IdVenta)
                    .HasColumnName("Id_Venta")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Observaciones).HasColumnType("varchar(100)");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnType("varchar(1)");

                entity.HasOne(d => d.CodProductoNavigation)
                    .WithMany(p => p.DetalleVenta)
                    .HasPrincipalKey(p => p.CodProducto)
                    .HasForeignKey(d => d.CodProducto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_DetVta_Prod");

                entity.HasOne(d => d.IdVentaNavigation)
                    .WithMany(p => p.DetalleVenta)
                    .HasForeignKey(d => d.IdVenta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_DetVta_Vta");

                entity.HasOne(d => d.StatusNavigation)
                    .WithMany(p => p.DetalleVenta)
                    .HasPrincipalKey(p => p.Status1)
                    .HasForeignKey(d => d.Status)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_DetVta_Status");
            });

            modelBuilder.Entity<Ingredientes>(entity =>
            {
                entity.HasKey(e => e.IdIngrediente);

                entity.ToTable("ingredientes");

                entity.HasIndex(e => e.IdIngrediente)
                    .HasName("Id_Ingrediente_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.IdUniMed)
                    .HasName("fk_Ingred_UniMed_idx");

                entity.HasIndex(e => e.Status)
                    .HasName("fk_Ingred_Status_idx");

                entity.Property(e => e.IdIngrediente)
                    .HasColumnName("Id_Ingrediente")
                    .HasColumnType("int(10)");

                entity.Property(e => e.IdUniMed)
                    .HasColumnName("Id_UniMed")
                    .HasColumnType("int(2)");

                entity.Property(e => e.NombreIngrediente)
                    .IsRequired()
                    .HasColumnName("Nombre_Ingrediente")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.Observaciones).HasColumnType("varchar(100)");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnType("varchar(1)");

                entity.HasOne(d => d.IdUniMedNavigation)
                    .WithMany(p => p.Ingredientes)
                    .HasForeignKey(d => d.IdUniMed)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Ingred_UniMed");

                entity.HasOne(d => d.StatusNavigation)
                    .WithMany(p => p.Ingredientes)
                    .HasPrincipalKey(p => p.Status1)
                    .HasForeignKey(d => d.Status)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Ingred_Status");
            });

            modelBuilder.Entity<Inventario>(entity =>
            {
                entity.HasKey(e => e.IdInventario);

                entity.ToTable("inventario");

                entity.HasIndex(e => e.CodProducto)
                    .HasName("fk_Invent_Prod_idx");

                entity.HasIndex(e => e.IdInventario)
                    .HasName("Id_Almacén_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.Status)
                    .HasName("fk_Almac_Status_idx");

                entity.Property(e => e.IdInventario)
                    .HasColumnName("Id_Inventario")
                    .HasColumnType("int(10)");

                entity.Property(e => e.Cantidad).HasColumnType("int(5)");

                entity.Property(e => e.CodProducto)
                    .IsRequired()
                    .HasColumnName("Cod_Producto")
                    .HasColumnType("varchar(8)");

                entity.Property(e => e.FechaCaducidad)
                    .HasColumnName("Fecha_Caducidad")
                    .HasColumnType("date");

                entity.Property(e => e.FechaElaboracion)
                    .HasColumnName("Fecha_Elaboracion")
                    .HasColumnType("date");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnName("Fecha_Registro")
                    .HasColumnType("date");

                entity.Property(e => e.Observaciones).HasColumnType("varchar(100)");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnType("varchar(1)");

                entity.HasOne(d => d.CodProductoNavigation)
                    .WithMany(p => p.Inventario)
                    .HasPrincipalKey(p => p.CodProducto)
                    .HasForeignKey(d => d.CodProducto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Invent_Product");

                entity.HasOne(d => d.StatusNavigation)
                    .WithMany(p => p.Inventario)
                    .HasPrincipalKey(p => p.Status1)
                    .HasForeignKey(d => d.Status)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Invent_Status");
            });

            modelBuilder.Entity<ListasIngredientes>(entity =>
            {
                entity.HasKey(e => e.IdListasIngred);

                entity.ToTable("listas_ingredientes");

                entity.HasIndex(e => e.IdIngrediente)
                    .HasName("fk_ListIngred_Ingred_idx");

                entity.HasIndex(e => e.IdListasIngred)
                    .HasName("Id_ListasIngred_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.IdReceta)
                    .HasName("fk_ListIngred_Rece_idx");

                entity.HasIndex(e => e.Status)
                    .HasName("fk_ListIngred_Status_idx");

                entity.Property(e => e.IdListasIngred)
                    .HasColumnName("Id_ListasIngred")
                    .HasColumnType("int(10)");

                entity.Property(e => e.IdIngrediente)
                    .HasColumnName("Id_Ingrediente")
                    .HasColumnType("int(10)");

                entity.Property(e => e.IdReceta)
                    .HasColumnName("Id_Receta")
                    .HasColumnType("int(10)");

                entity.Property(e => e.Observaciones).HasColumnType("varchar(100)");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnType("varchar(1)");

                entity.HasOne(d => d.IdIngredienteNavigation)
                    .WithMany(p => p.ListasIngredientes)
                    .HasForeignKey(d => d.IdIngrediente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ListIngred_Ingred");

                entity.HasOne(d => d.IdRecetaNavigation)
                    .WithMany(p => p.ListasIngredientes)
                    .HasForeignKey(d => d.IdReceta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ListIngred_Receta");

                entity.HasOne(d => d.StatusNavigation)
                    .WithMany(p => p.ListasIngredientes)
                    .HasPrincipalKey(p => p.Status1)
                    .HasForeignKey(d => d.Status)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ListIngred_Status");
            });

            modelBuilder.Entity<Pedidos>(entity =>
            {
                entity.HasKey(e => e.IdPedido);

                entity.ToTable("pedidos");

                entity.HasIndex(e => e.IdPedido)
                    .HasName("Id_Pedidos_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.Status)
                    .HasName("fk_pedidos_status1_idx");

                entity.Property(e => e.IdPedido)
                    .HasColumnName("Id_Pedido")
                    .HasColumnType("int(10)");

                entity.Property(e => e.Cliente)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.FechaEntrega)
                    .HasColumnName("Fecha_Entrega")
                    .HasColumnType("date");

                entity.Property(e => e.FechaPedido)
                    .HasColumnName("Fecha_Pedido")
                    .HasColumnType("date");

                entity.Property(e => e.Observaciones).HasColumnType("varchar(100)");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnType("varchar(1)");

                entity.Property(e => e.TotalPedido).HasColumnName("Total_Pedido");

                entity.HasOne(d => d.StatusNavigation)
                    .WithMany(p => p.Pedidos)
                    .HasPrincipalKey(p => p.Status1)
                    .HasForeignKey(d => d.Status)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Pedi_Status");
            });

            modelBuilder.Entity<Presentaciones>(entity =>
            {
                entity.HasKey(e => e.IdPresentacion);

                entity.ToTable("presentaciones");

                entity.HasIndex(e => e.IdPresentacion)
                    .HasName("Id_Presentación_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.IdUniMed)
                    .HasName("fk_Present_UniMed_idx");

                entity.HasIndex(e => e.Status)
                    .HasName("fk_Present_Status_idx");

                entity.Property(e => e.IdPresentacion)
                    .HasColumnName("Id_Presentacion")
                    .HasColumnType("int(3)");

                entity.Property(e => e.IdUniMed)
                    .HasColumnName("Id_UniMed")
                    .HasColumnType("int(2)");

                entity.Property(e => e.Observaciones).HasColumnType("varchar(100)");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnType("varchar(1)");

                entity.HasOne(d => d.IdUniMedNavigation)
                    .WithMany(p => p.Presentaciones)
                    .HasForeignKey(d => d.IdUniMed)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Present_UniMed");

                entity.HasOne(d => d.StatusNavigation)
                    .WithMany(p => p.Presentaciones)
                    .HasPrincipalKey(p => p.Status1)
                    .HasForeignKey(d => d.Status)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Present_Status");
            });

            modelBuilder.Entity<Productos>(entity =>
            {
                entity.HasKey(e => new { e.IdProducto, e.CodProducto });

                entity.ToTable("productos");

                entity.HasIndex(e => e.CodProducto)
                    .HasName("Cod_Producto_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.IdPresentacion)
                    .HasName("fk_Product_Present");

                entity.HasIndex(e => e.IdProducto)
                    .HasName("Id_Producto_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.IdReceta)
                    .HasName("fk_Prod_Rece_idx");

                entity.HasIndex(e => e.Status)
                    .HasName("fk_Product_Status_idx");

                entity.Property(e => e.IdProducto)
                    .HasColumnName("Id_Producto")
                    .HasColumnType("int(10)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CodProducto)
                    .HasColumnName("Cod_Producto")
                    .HasColumnType("varchar(15)");

                entity.Property(e => e.CostoUnit)
                    .HasColumnName("Costo_Unit")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.IdPresentacion)
                    .HasColumnName("Id_Presentacion")
                    .HasColumnType("int(3)");

                entity.Property(e => e.IdReceta)
                    .HasColumnName("Id_Receta")
                    .HasColumnType("int(10)");

                entity.Property(e => e.Observaciones).HasColumnType("varchar(100)");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnType("varchar(1)");

                entity.HasOne(d => d.IdPresentacionNavigation)
                    .WithMany(p => p.Productos)
                    .HasForeignKey(d => d.IdPresentacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Product_Present");

                entity.HasOne(d => d.IdRecetaNavigation)
                    .WithMany(p => p.Productos)
                    .HasForeignKey(d => d.IdReceta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Product_Receta");

                entity.HasOne(d => d.StatusNavigation)
                    .WithMany(p => p.Productos)
                    .HasPrincipalKey(p => p.Status1)
                    .HasForeignKey(d => d.Status)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Product_Status");
            });

            modelBuilder.Entity<Recetas>(entity =>
            {
                entity.HasKey(e => e.IdReceta);

                entity.ToTable("recetas");

                entity.HasIndex(e => e.IdCategoria)
                    .HasName("fk_Rece_Categ_idx");

                entity.HasIndex(e => e.IdReceta)
                    .HasName("Id_Receta_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.IdUniMed)
                    .HasName("fk_Recer_UniMed_idx");

                entity.HasIndex(e => e.Status)
                    .HasName("fk_Recet_Status_idx");

                entity.Property(e => e.IdReceta)
                    .HasColumnName("Id_Receta")
                    .HasColumnType("int(10)");

                entity.Property(e => e.CostoKilo)
                    .HasColumnName("Costo_Kilo")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.IdCategoria)
                    .HasColumnName("Id_Categoria")
                    .HasColumnType("int(3)");

                entity.Property(e => e.IdUniMed)
                    .HasColumnName("Id_UniMed")
                    .HasColumnType("int(2)");

                entity.Property(e => e.Observaciones).HasColumnType("varchar(100)");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnType("varchar(1)");

                entity.HasOne(d => d.IdCategoriaNavigation)
                    .WithMany(p => p.Recetas)
                    .HasForeignKey(d => d.IdCategoria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Receta_Catego");

                entity.HasOne(d => d.IdUniMedNavigation)
                    .WithMany(p => p.Recetas)
                    .HasForeignKey(d => d.IdUniMed)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Receta_UniMed");

                entity.HasOne(d => d.StatusNavigation)
                    .WithMany(p => p.Recetas)
                    .HasPrincipalKey(p => p.Status1)
                    .HasForeignKey(d => d.Status)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Receta_Status");
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.HasKey(e => e.IdStatus);

                entity.ToTable("status");

                entity.HasIndex(e => e.IdStatus)
                    .HasName("Id_Status")
                    .IsUnique();

                entity.HasIndex(e => e.Status1)
                    .HasName("Status")
                    .IsUnique();

                entity.Property(e => e.IdStatus)
                    .HasColumnName("Id_Status")
                    .HasColumnType("int(2)");

                entity.Property(e => e.DescripcionStatus)
                    .IsRequired()
                    .HasColumnName("Descripcion_Status")
                    .HasColumnType("varchar(25)");

                entity.Property(e => e.Observaciones).HasColumnType("varchar(100)");

                entity.Property(e => e.Status1)
                    .IsRequired()
                    .HasColumnName("Status")
                    .HasColumnType("varchar(1)");
            });

            modelBuilder.Entity<UnidadesMedida>(entity =>
            {
                entity.HasKey(e => e.IdUniMed);

                entity.ToTable("unidades_medida");

                entity.HasIndex(e => e.IdUniMed)
                    .HasName("Id_UniMed_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.Status)
                    .HasName("fk_UniMed_Status_idx");

                entity.Property(e => e.IdUniMed)
                    .HasColumnName("Id_UniMed")
                    .HasColumnType("int(2)");

                entity.Property(e => e.DescripcionUniMed)
                    .IsRequired()
                    .HasColumnName("Descripcion_UniMed")
                    .HasColumnType("varchar(25)");

                entity.Property(e => e.Observaciones).HasColumnType("varchar(100)");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnType("varchar(1)");

                entity.HasOne(d => d.StatusNavigation)
                    .WithMany(p => p.UnidadesMedida)
                    .HasPrincipalKey(p => p.Status1)
                    .HasForeignKey(d => d.Status)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_UniMed_Status");
            });

            modelBuilder.Entity<Venta>(entity =>
            {
                entity.HasKey(e => e.IdVenta);

                entity.ToTable("ventas");

                entity.HasIndex(e => e.IdVenta)
                    .HasName("Id_Vta_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.Status)
                    .HasName("fk_Vta_Status_idx");

                entity.Property(e => e.IdVenta)
                    .HasColumnName("Id_Venta")
                    .HasColumnType("int(10)");

                entity.Property(e => e.FechaVenta)
                    .HasColumnName("Fecha_Venta")
                    .HasColumnType("date");

                entity.Property(e => e.Observaciones).HasColumnType("varchar(100)");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnType("varchar(1)");

                entity.Property(e => e.TotalVenta).HasColumnName("Total_Venta");

                entity.HasOne(d => d.StatusNavigation)
                    .WithMany(p => p.Ventas)
                    .HasPrincipalKey(p => p.Status1)
                    .HasForeignKey(d => d.Status)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Vta_Status");
            });
        }
    }
}
