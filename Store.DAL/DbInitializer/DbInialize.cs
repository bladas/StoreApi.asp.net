using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Win32.SafeHandles;
using Store.DAL.Entities;
using Store.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Store.DAL.DbInitialize
{
    public class DBInitializer : IDisposable
    {
        private bool _disposed = false;
        private SafeHandle _handle = new SafeFileHandle(IntPtr.Zero, true);

        private readonly IUnitOfWork _unitOfWork;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<User> _userManager;
        public DBInitializer(IServiceProvider serviceProvider)
        {
            _unitOfWork = serviceProvider.GetRequiredService<IUnitOfWork>();
            _roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            _userManager = serviceProvider.GetRequiredService<UserManager<User>>();
        }

        public async Task SeedData()
        {
            await SeedRoles();
        }

        public async Task SeedRoles()
        {
            if (!await _roleManager.RoleExistsAsync("User"))
            {
                await _roleManager.CreateAsync(new IdentityRole("User"));
            }

            if (!await _roleManager.RoleExistsAsync("Admin"))
            {
                await _roleManager.CreateAsync(new IdentityRole("Admin"));
            }

         
        }

       
        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
                return;

            if (disposing)
            {
                _handle.Dispose();
                //Free any other managed objects here.
            }

            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            //Suppress finalization.
            GC.SuppressFinalize(this);
        }

    }
}

