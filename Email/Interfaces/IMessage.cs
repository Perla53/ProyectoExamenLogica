using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Email.Interfaces
{
    internal interface IMessage
    {
        void Send(string destinatario, string contenido);
    }
}
