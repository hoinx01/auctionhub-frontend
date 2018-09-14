using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Web.Areas.Common.Models.Account;
using AutoMapper;
using Common.Data.Rest.Caller.Interfaces;
using Common.Data.Rest.Models.Account;
using Microsoft.AspNetCore.Mvc;

namespace Application.Web.Areas.Common.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountRestCaller accountRestCaller;
        public AccountController(
            IAccountRestCaller accountRestCaller
            )
        {
            this.accountRestCaller = accountRestCaller;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            var loginViewModel = new LoginViewModel()
            {
                LoginName = "hoinx01",
                Password="123456"
            };
            return View(loginViewModel);
        }
        [HttpPost]
        public async Task<AccountModel> Login(LoginViewModel loginModel)
        {
            var loginRequest = Mapper.Map<LoginRequest>(loginModel);
            var loginResponse = await accountRestCaller.Login(loginRequest);
            return Mapper.Map<AccountModel>(loginResponse);
        }
    }
}