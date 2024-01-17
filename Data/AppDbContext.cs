using aspnet_core_mvc_crud.Models;
using Microsoft.EntityFrameworkCore;

namespace aspnet_core_mvc_crud.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }

    public DbSet<Contato> Contatos { get; set; }
}