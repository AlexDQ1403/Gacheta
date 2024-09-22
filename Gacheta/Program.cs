using DataGA.Entidad;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
public class HotelDbContext : DbContext
{
    public HotelDbContext(DbContextOptions<HotelDbContext> options)
        : base(options)
    {
    }

    public DbSet<Cuarto> Cuartos { get; set; }
    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Parqueadero> Parqueaderos { get; set; }
    public DbSet<Lavanderia> Lavanderias { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Relación uno a muchos entre Cuarto y Cliente
        modelBuilder.Entity<Cliente>()
            .HasOne(c => c.Cuarto)
            .WithMany(cu => cu.Clientes)
            .HasForeignKey(c => c.CuartoId)
            .OnDelete(DeleteBehavior.Cascade);  // Cuando se elimina un cuarto, también se eliminan sus clientes

        // Relación uno a uno entre Cuarto y Parqueadero
        modelBuilder.Entity<Cuarto>()
            .HasOne(c => c.Parqueadero)
            .WithMany(p => p.Cuartos)
            .HasForeignKey(c => c.ParqueaderoId);

        // Relación uno a uno entre Cuarto y Lavandería
        modelBuilder.Entity<Cuarto>()
            .HasOne(c => c.Lavanderia)
            .WithMany(l => l.Cuartos)
            .HasForeignKey(c => c.LavanderiaId);
    }
}
