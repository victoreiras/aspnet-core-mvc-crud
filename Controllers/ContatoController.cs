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
        if (ModelState.IsValid)
        {
            _db.Contatos.Add(contato);
            _db.SaveChanges();

            TempData["MensagemSucesso"] = "Cadastro realizado com sucesso!";
        }
        else
            TempData["MensagemErro"] = "Algum erro ocorreu ao realizar o cadastro!";

        return RedirectToAction("Listar");
    }

    [HttpGet]
    public IActionResult Editar(int id)
    {
        var contato = _db.Contatos.FirstOrDefault(c => c.Id == id);

        return View(contato);
    }

    [HttpPost]
    public IActionResult Editar(Contato contato)
    {
        if (ModelState.IsValid)
        {
            _db.Contatos.Update(contato);
            _db.SaveChanges();

            TempData["MensagemSucesso"] = "Edição realizada com sucesso!";
        }
        else
            TempData["MensagemErro"] = "Algum erro ocorreu ao realizar a edição!";

        return RedirectToAction("Listar");
    }

    [HttpGet]
    public IActionResult Excluir(int id)
    {
        var contato = _db.Contatos.FirstOrDefault(c => c.Id == id);

        return View(contato);
    }

    [HttpPost]
    public IActionResult Excluir(Contato contato)
    {
        if (ModelState.IsValid)
        {
            _db.Contatos.Remove(contato);
            _db.SaveChanges();

            TempData["MensagemSucesso"] = "Exclusão realizada com sucesso!";
        }
        else
            TempData["MensagemErro"] = "Algum erro ocorreu ao realizar a exclusão!";

        return RedirectToAction("Listar");
    }
}