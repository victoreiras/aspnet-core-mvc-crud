using System.ComponentModel.DataAnnotations;

namespace aspnet_core_mvc_crud.Models;

public class Contato
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Campo obrigatório")]
    public string Nome { get; set; }

    [Required(ErrorMessage = "Campo obrigatório")]
    public string Sobrenome { get; set; }

    [Required(ErrorMessage = "Campo obrigatório")]
    public string Telefone { get; set; }

    [Required(ErrorMessage = "Campo obrigatório")]
    public string Email { get; set; }
}