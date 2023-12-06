using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class OutSide : Food
    {
        [DisplayName("Nombre")]
        public string name { get; set; }
        [DisplayName("Direccion")]
        public string adress { get; set; }
        [DisplayName("Barrio")]
        public string barrio { get; set; }
        [DisplayName("Localidad")]
        public Localidad localidad { get; set; }
        [DisplayName("Categoria")]
        public Categoria categoria { get; set; }     
        public int outside { get; set; }    
    }
}
