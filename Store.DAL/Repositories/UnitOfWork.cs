using Store.DAL.Interfaces;
using Store.DAL.EF;
using Store.DAL.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Threading.Tasks;

namespace Store.DAL.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private AppDBContext db;
        public UserManager<User> UserManager { get; }
        public RoleManager<IdentityRole> RoleManager { get; }
        public SignInManager<User> SignInManager { get; }

        private IProductRepository _productRepository;
        public UnitOfWork(AppDBContext context, SignInManager<User> signInManager, UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            db = context;
            UserManager = userManager;
            RoleManager = roleManager;
            SignInManager = signInManager;
        }
        public IProductRepository ProductRepository =>
            _productRepository ?? (_productRepository = new ProductRepository(db));

        public async Task SaveAsync()
        {
            await db.SaveChangesAsync();
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    UserManager.Dispose();
                    RoleManager.Dispose();

                }
                this.disposed = true;
            }
        }
    }
}
