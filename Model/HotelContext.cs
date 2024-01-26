using HotelEF;
using Microsoft.EntityFrameworkCore;

namespace HotelEF
{
  public class HotelContext : DbContext
  {
      public DbSet<Cargo> Cargos {get; set;} = null;
      public DbSet<Cliente> Clientes {get; set;} = null;
      public DbSet<Endereco> Enderecos {get; set;} = null;
      public DbSet<Filial> Filial {get; set;} = null;
      public DbSet<Funcionario> Funcionario {get; set;} = null;
      public DbSet<ItemConsumivel> ItemConsumivel {get; set;} = null;
      public DbSet<Reserva> Reserva {get; set;} = null;
      public DbSet<ItemConsumo> ItemConsumo {get; set;} = null;
      public DbSet<Pagamento> Pagamentos {get; set;} = null;
      public DbSet<Quarto> Quarto {get; set;} = null;
      public DbSet<Servico> Servico {get; set;} = null;
      public DbSet<Telefone> Telefone {get; set;} = null;
      public DbSet<Conta> Conta {get; set;} = null;

      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
      {
          optionsBuilder.UseSqlServer(@"Server=LAPTOP-P8BTRSBI\SQLEXPRESS;Database=HotelCodeFirst;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True;");
      }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Many To Many - Reserva - ItemsConsumidos
            modelBuilder.Entity<Reserva>()
              .HasMany(x => x.ItemsConsumidos)
              .WithMany(x => x.Reservas)
              .UsingEntity<Conta>();

            modelBuilder.Entity<Conta>()
              .HasOne(x => x.ItemConsumivel)
              .WithOne()
              .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Conta>()
              .HasOne(x => x.Reserva)
              .WithOne()
              .OnDelete(DeleteBehavior.NoAction);

            // Many to Many - Servico -> Reserva
            modelBuilder.Entity<Reserva>()
              .HasMany(x => x.Servicos)
              .WithMany(x => x.Reservas)
              .UsingEntity<ServicoReserva>();

            modelBuilder.Entity<ServicoReserva>()
              .HasOne(x => x.Servico)
              .WithOne()
              .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<ServicoReserva>()
              .HasOne(x => x.Reserva)
              .WithOne()
              .OnDelete(DeleteBehavior.NoAction);  

          // Many to Many - Reserva -> Consumo
            modelBuilder.Entity<Reserva>()
              .HasMany(x => x.Consumos)
              .WithMany(x => x.Reservas)
              .UsingEntity<ConsumoReserva>();

            modelBuilder.Entity<ConsumoReserva>()
              .HasOne(x => x.Consumo)
              .WithOne()
              .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<ConsumoReserva>()
              .HasOne(x => x.Reserva)
              .WithOne()
              .OnDelete(DeleteBehavior.NoAction);      
        }
    }
}