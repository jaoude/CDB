using CDB.BLL.Abstraction;
using CDB.BLL.Dto.Request;
using CDB.Core.Models;
using CDB.DAL.Abstraction.UnitOfWork;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CDB.BLL.Implementation;
using CDB.Common;
using Microsoft.AspNetCore.Identity;
using CDB.DAL;

namespace CDB.BLL.Implementation
{
    public class AccountService : BaseService, IAccountService
    {

        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<ApplicationUser> _userManager;


        public AccountService(
            RoleManager<IdentityRole> roleManager,
            UserManager<ApplicationUser> userManager,
            IUnitOfWork uow,
            ILogger<ClientService> logger, IModelMapHelper mapper) : base(uow, logger, mapper)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }


        public async Task CreateRolesAndAdminUser()
        {
            // const string adminRoleName = Constants.ADMIN_ROLE_NAME;
            string[] roleNames = { Constants.ADMIN_ROLE_NAME, Constants.MANAGER_ROLE_NAME, Constants.MEMBER_ROLE_NAME };

            foreach (string roleName in roleNames)
            {
                await CreateRole(roleName);
            }

            // Get these value from "appsettings.json" file.
            await AddUserToRole(Constants.ADMIN_USER_EMAIL, Constants.ADMIN_USER_PASSWORD, Constants.ADMIN_ROLE_NAME);
        }

        private async Task CreateRole(string roleName)
        {
            bool roleExists = await _roleManager.RoleExistsAsync(roleName);

            if (!roleExists)
            {
                IdentityResult roleResult = await _roleManager.CreateAsync(new IdentityRole(roleName));
            }
        }


        private async Task AddUserToRole(string userEmail, string userPwd, string roleName)
        {
            ApplicationUser appUser = await _userManager.FindByEmailAsync(userEmail);
            if (appUser != null)
                await _userManager.AddToRoleAsync(appUser, roleName);
            else
            {
                appUser = new ApplicationUser() { Email = userEmail, UserName = userEmail };

                IdentityResult taskCreateAppUser = await _userManager.CreateAsync(appUser, userPwd);

                if (taskCreateAppUser.Succeeded)
                {
                    await _userManager.AddToRoleAsync(appUser, roleName);
                }
            }
        }
    }
}
