using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TarefasApi.Models;

namespace TarefasApi.Data;

public class ApplicationDbContext : IdentityDbContext<Usuario>
{

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<Tarefas> Tarefa { get; set; }
}
 