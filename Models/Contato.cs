using System.ComponentModel.DataAnnotations;

namespace aspnet_core_mvc_crud.Models;

public class Contato
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "Campo obrigatório")]
    public string Nome { get; set; }

    [Required(ErrorMessage = "Campo obrigatório")]
    public string Sobrenome { get; set; }

    [Required(ErrorMessage = "Campo obrigatório")]
    [Phone]
    public string Telefone { get; set; }

    [Required(ErrorMessage = "Campo obrigatório")]
    [DataType(DataType.EmailAddress)]
    [EmailAddress]
    public string Email { get; set; }
}