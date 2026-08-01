using System.ComponentModel.DataAnnotations;
[Required]
public string Nombre { get; set; }

[Required]
public string Apellido { get; set; }

[Range(1, 120)]
public int Edad { get; set; }

[EmailAddress]
public string Correo { get; set; }