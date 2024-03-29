namespace WebApi.Models.Users;

using System.ComponentModel.DataAnnotations;
using WebApi.Entities;

public class UpdateRequestFacultad
{

  [Required]
  public int? id { get; set; }

  [Required]
  [MaxLength(256)]
  public string? nombre_facultad { get; set; }

  [Required]
  [MaxLength(16)]
  public string? codigo_facultad { get; set; }


}