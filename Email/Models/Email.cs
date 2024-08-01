using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Email.Models
{
    internal class Email
    {
        public string Destinatario { get; set; }
        public string Contenido { get; set; }
        public string Tipo { get; set; }
    }
}
