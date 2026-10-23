using System.ComponentModel.DataAnnotations;
namespace LHPets.Models;
public class Pet
{
 public int Id { get; set; }
 [Required]
 [StringLength(100, MinimumLength = 3)]
 public string Nome { get; set; } = string.Empty;
 [Required]
 public string Especie { get; set; } = string.Empty;
 [Required]
Tutorial Guiado • Projeto LH-Pets • ASP.NET Core Web API
SENAI • Codificação para Back-End • Aula 07
 public string Raca { get; set; } = string.Empty;
 [Range(1, int.MaxValue)]
 public int ClienteId { get; set; }
}
