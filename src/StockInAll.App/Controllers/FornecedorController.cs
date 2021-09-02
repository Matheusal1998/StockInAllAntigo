using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StockInAll.App.ViewModels;

namespace StockInAll.App.Controllers
{
    //[Authorize]
    public class FornecedorController : Controller
    {
        private readonly ILogger<FornecedorController> _logger;

        #region Dependência
        public FornecedorController(ILogger<FornecedorController> logger)
        {
            _logger = logger;
        }

        #endregion

        #region Actions
        [Route("lista-fornecedores")]
        public IActionResult Index()
        {
            var fornecedor1 = new FornecedorViewModel{ Id = Guid.NewGuid(), Nome = "Logitech", Ramo = "periféricos", DataCriacao = DateTime.Now };
            var listaFornecedores = new List<FornecedorViewModel>();
            listaFornecedores.Add(fornecedor1);

            return View(listaFornecedores);
        }

        [Route("criar-novo-fornecedor")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route("criar-novo-fornecedor")]
        public IActionResult Create(FornecedorViewModel model)
        {
            return View();
        }

        #endregion

        #region Privates

        #endregion
    }
}
