﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Windows;

namespace ProyectoFinal.Model
{
    public class Articulos
    {
        [Key]
        public int ArticuloId { get; set; }
        public int UsuarioId { get; set; }
        public string Descripcion { get; set; }
        //public int  CategoriaId { get; set; }
        public decimal Stock { get; set; }
        public decimal Precio { get; set; }
        public decimal Costo { get; set; }

        [ForeignKey("ArticulosId")]
        public List<ComprasDetalle> ComprasDetalle { get; set; }

       // [ForeignKey("ArticulosId")]
      //  public List<VentasDetalle> VentasDetalle { get; set; }


        public Articulos()
        {
            ArticuloId = 0;
            UsuarioId = 0;
            Descripcion = string.Empty;
            Stock = 0;
            Precio = 0;
            Costo = 0;

            ComprasDetalle = new List<ComprasDetalle>();
           // VentasDetalle = new List<VentasDetalle>();
        }
    }
}

