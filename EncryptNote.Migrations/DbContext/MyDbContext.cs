using EncryptNote.Library.Models;
using Microsoft.EntityFrameworkCore;

namespace EncryptNote.Migrations.DbContext; 

public class MyDbContext : Microsoft.EntityFrameworkCore.DbContext
{
    public DbSet<Note> Notes { get; set; } = null!;
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=notes.db");
    }
}