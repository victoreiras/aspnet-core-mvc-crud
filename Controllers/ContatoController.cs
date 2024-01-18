using aspnet_core_mvc_crud.Data;
using aspnet_core_mvc_crud.Models;
using Microsoft.AspNetCore.Mvc;

namespace aspnet_core_mvc_crud.Controllers;

public class ContatoController : Controller
{
    private readonly AppDbContext _db;

    public ContatoController(AppDbContext db)
    {
        _db = db;
    }

    [HttpGet]
    public IActionResult Listar()
    {
        var listaDeContatos = _db.Contatos.ToList();

        if (listaDeContatos == null)
            return NotFound();

        return View(listaDeContatos);
    }

    [HttpGet]
    public IActionResult Cadastrar()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Cadastrar(Contato contato)
    {
        if (!ModelState.IsValid)
            return NotFound();

        _db.Contatos.Add(contato);
        _db.SaveChanges();

        return RedirectToAction("Listar");
    }
}