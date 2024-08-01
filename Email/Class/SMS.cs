using Email.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Email.Class
{
    public class SMS:IMessage
    {
        public void Send(string destinatario, string contenido)
        {
            Console.WriteLine("Enviando SMS a " + destinatario + " Contenido:" + contenido);
        }
    }
}
