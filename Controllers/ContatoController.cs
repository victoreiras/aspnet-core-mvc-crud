using aspnet_core_mvc_crud.Models;
using Microsoft.AspNetCore.Mvc;

namespace aspnet_core_mvc_crud.Controllers;

public class ContatoController : Controller
{
    [HttpGet]
    public IActionResult Listar()
    {
        var listaDeContatos = new List<Contato>{
            new Contato {Id = 1, Nome = "Victor", Sobrenome = "Eiras", Telefone = "(11)941042558", Email = "victor.eiras@gmail.com"}
        };

        return View(listaDeContatos);
    }
}