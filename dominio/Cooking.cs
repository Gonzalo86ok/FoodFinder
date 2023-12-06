using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Cooking : Food
    {
        public string nombre { get; set; }
        public Categoria categoria { get; set; }
    }

}
