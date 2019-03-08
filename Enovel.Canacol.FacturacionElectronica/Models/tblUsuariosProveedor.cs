//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Enovel.Canacol.FacturacionElectronica.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblUsuariosProveedor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblUsuariosProveedor()
        {
            this.tblCamaraComercio = new HashSet<tblCamaraComercio>();
            this.tblRadicado = new HashSet<tblRadicado>();
            this.tblRut = new HashSet<tblRut>();
            this.UsuarioActivacion = new HashSet<UsuarioActivacion>();
        }
    
        public int ID { get; set; }
        public string UsuarioNit { get; set; }
        public string Password { get; set; }
        public string RazonSocial { get; set; }
        public Nullable<int> IDCalidadTributaria { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string RepresentanteLegal { get; set; }
        public string RutaRut { get; set; }
        public string RutaCamaraComercio { get; set; }
        public string Estado { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> LastLoginDate { get; set; }
        public string FEErrorMessage { get; set; }
        public virtual tblCalidadTributaria tblCalidadTributaria { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCamaraComercio> tblCamaraComercio { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblRadicado> tblRadicado { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblRut> tblRut { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UsuarioActivacion> UsuarioActivacion { get; set; }
    }
}
