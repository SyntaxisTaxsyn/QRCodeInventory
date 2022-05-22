using Microsoft.EntityFrameworkCore;
    
public class QRCodeIVMContext : DbContext
{
    public DbSet<QRCodeIVM>? QRCodes { get; set; }
    public DbSet<User>? Users {get;set;}
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var serverVersion = new MySqlServerVersion(new Version(8, 0, 27));
        optionsBuilder.UseMySql(@"server=localhost;database=QRCodeIVM;user=root;password=C@ntrol2",serverVersion);
    }
}