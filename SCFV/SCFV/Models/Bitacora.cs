//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SCFV.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Bitacora
    {
        public int manteId { get; set; }
        public int usuarioId { get; set; }
        public string accion { get; set; }
        public string tabla { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
    
        public virtual Usuario Usuario { get; set; }
    }
}
