using Microsoft.EntityFrameworkCore;

namespace dotNetCore6Static.Models;

public partial class personContext : DbContext
{
 
    public personContext(DbContextOptions<personContext> options)
        : base(options)
    {
    }
    public virtual DbSet<Person> personList { get; set; }
}
