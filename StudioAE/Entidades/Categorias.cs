using System;

public class Categorias
{
    [Key]
    public int CategoriasId { get; set; }
    public int UsuarioId { get; set; }
    public string NombreCategorias { get; set; }

    public Categorias()
	{
        CategoriasId = 0;
        UsuarioId = 0;
        NombreCategorias = string.Empty;
	}
}
