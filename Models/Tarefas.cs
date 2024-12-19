using System.ComponentModel.DataAnnotations;

namespace TarefasApi.Models;

public class Tarefas
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage ="Título obrigatório!")]
    [Range(5,500,ErrorMessage ="O Título deve ter entre 5 e 100 caracteres")]
    
    public string Titulo { get; set; }

    [MaxLength(500,ErrorMessage =  "A descrição não pode exceder 500 caracteres")]
    public string Descricao { get; set; }

    public bool StatusInicial { get; set; } = true;

    public DateTime DataCriacao { get; set; } = DateTime.Now;

    public string UsuarioId { get; set; }
    public Usuario Usuario { get; set; }

}
