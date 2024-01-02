namespace WebApi.Models.Users;

using System.ComponentModel.DataAnnotations;
using WebApi.Entities;

public class UpdateRequestCarrera
{

  [Required]

  public int? id { get; set; }

  [Required]

  public int? facultad { get; set; }

  [Required]
  [MaxLength(256)]
  public string? nombre_carrera { get; set; }

  [Required]
  [MaxLength(16)]
  public string? codigo_carrera{ get; set; }
}