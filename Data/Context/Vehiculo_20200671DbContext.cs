using Vehiculo_20200671.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Vehiculo_20200671.Data.Context;

 public class Vehiculo_20200671DbContext:DbContext
 {
     public Vehiculo_20200671DbContext(DbContextOptions options):base(options)
    {
        
    }

public virtual DbSet<vehiculo> Vehiculos {get; set;} = null!;
public override int SaveChanges()
    {
        return base.SaveChanges();
    }
    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        return base.SaveChangesAsync(cancellationToken);
    }
 }
 public interface Vehiculo_20200671
 {
   public DbSet<vehiculo> vehiculos {get; set;}
    public int SaveChanges();
    public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
 }