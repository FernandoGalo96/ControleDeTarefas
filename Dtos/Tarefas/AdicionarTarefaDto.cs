using System.ComponentModel.DataAnnotations;
using TarefasApi.Models;

namespace TarefasApi.Dtos.Tarefas;

public class AdicionarTarefaDto
{



    [Required(ErrorMessage = "Título é obrigatório")]
    [StringLength(100, ErrorMessage = "O título deve ter até 100 caracteres")]
    public string Titulo { get; set; }

    [StringLength(500, ErrorMessage = "A descrição deve ter até 500 caracteres")]
    public string Descricao { get; set; }

    public bool StatusInicial { get; set; } = true;



    public string UsuarioId { get; set; }

}
