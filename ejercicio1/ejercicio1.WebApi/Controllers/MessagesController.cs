using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ejercicio1.WebApi.Controllers
{
    public class MessagesController : ApiController
    {

        // http://[NombreDelServidor]/api/[Controlador]

        //public string Message()
        //{
        //    return "¡Hola desde Web Api!";
        //}

        public string GetMessage()
        {
            return "Mapeado a un método Get!";
        }

        public void PostMessage([FromBody] Message message)
        {
            string mensajeEnviadoConLaPeticion = message.Text;
        }
    }

   public class Message
    {
        public string Text { get; set; }
    }
}
