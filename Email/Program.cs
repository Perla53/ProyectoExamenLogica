namespace Email

{
    using Email.Interfaces;
    using Microsoft.Extensions.DependencyInjection;
    using Email.Class;
    using System.Diagnostics.Metrics;
    using Email.Models;
    internal class Program
    {
        static void Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();
            Models.Email email = new Models.Email();

            Console.WriteLine("A continuación ingresa los siguientes datos");


            Console.WriteLine("Email:");
            email.Destinatario = Console.ReadLine();

            Console.WriteLine("Contenido:");
            email.Contenido = Console.ReadLine();

            Console.WriteLine("Tipo de Mensaje (SMS/Email):");
            email.Tipo = Console.ReadLine();




            if (email.Tipo == "SMS")
            {
                serviceCollection.AddTransient<IMessage, SMS>();
            }
            else
            {
                serviceCollection.AddTransient<IMessage, Class.Email>();
            }

            var serviceProvider = serviceCollection.BuildServiceProvider();
            var mensajeServicio = serviceProvider.GetService<IMessage>();


            mensajeServicio.Send(email.Destinatario, email.Contenido);

        }
    }
}