public interface IDbContextFactory
    {
        public QRCodeIVMContext GetDbContext();
    }

    public class DbContextFactory : IDbContextFactory
    {
        public QRCodeIVMContext GetDbContext(){
            QRCodeIVMContext newDBContext = new QRCodeIVMContext();
            return newDBContext;
        }
    }