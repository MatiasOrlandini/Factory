﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelo
{
    [Table("Linea_Remito")]
    public class LineaRemito
    {
        [Key]
        public Int32 CODIGO_LINEA { get; set; }
        public Int32 CANTIDAD { get; set; }
        public decimal PRECIO { get; set; }
        public Int32 CODIGO_INSUMO { get; set; }
        [ForeignKey("CODIGO_INSUMO")]
        public Insumo INSUMO { get; set; }
        public Int32 CODIGO_REMITO { get; set; }
        [ForeignKey("CODIGO_REMITO")]
        public Remito REMITO { get; set; }
        public Int32 CODIGO_ENTREGA { get; set; }
        [ForeignKey("CODIGO_ENTREGA")]
        public Entrega ENTREGA { get; set; }
        public decimal SUB_TOTAL
        {
            get
            {
                decimal subtotal = this.PRECIO * this.CANTIDAD;
                return subtotal;
            }
        }
    }
}
