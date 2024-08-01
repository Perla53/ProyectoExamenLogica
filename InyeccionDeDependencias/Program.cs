using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InyeccionDeDependencias
{
    public class Program
    {
        public interface IMensaje
        {
            void Enviar(string destinatario, string contenido);
        }
        public class EmailMensaje : IMensaje
        {
            public void Enviar(string destinatario, string contenido)
            {
                Console.WriteLine($"Enviando correo a {destinatario} con contenido: {contenido}");
            }
        }
        public class SmsMensaje : IMensaje
        {
            public void Enviar(string destinatario, string contenido)
            {
                Console.WriteLine($"Enviando SMS a {destinatario} con contenido: {contenido}");
            }
        }
        static void Main(string[] args)
        {

        }
    }
}
