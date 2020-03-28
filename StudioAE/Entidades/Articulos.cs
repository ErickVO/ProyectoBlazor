using System;

public class Articulos
{
    [Key]
    public int ArticulosId { get; set; }
    public int UsuariosId { get; set; }
    public string NombreArticulos { get; set; }
    public string Categorias { get; set; }
    public int Stock { get; set; }
    public decimal Precio { get; set; }

    [ForeignKey("ArticulosId")]
    public List<ComprasDetalle> ComprasDetalle { get; set; }

    [ForeignKey("ArticulosId")]
    public List<VentasDetalle> VentasDetalle { get; set; }

    public Articulos()
	{



	}
}
