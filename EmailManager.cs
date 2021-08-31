using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDeDisenio
{
    class EmailManager
    {
        //METODOS GETTER Y SETTER DE TODA LA VIDA
        public string cliente { get; set; }
        public string desde { get; set; }
        public string para { get; set; }
        public string asunto { get; set; }
        public string cuerpo { get; set; }


        //METODOS QUE NOS AYUDAN A EVITAR REDUNDANCIA
        public EmailManager Cliente (string cliente)
        {
            this.cliente = cliente;
            return this;
        }

        public EmailManager Desde(string desde)
        {
            this.desde = desde;
            return this;
        }

        public EmailManager Para (string para)
        {
            this.para = para;
            return this;
        }

        public EmailManager Asunto (string asunto)
        {
            this.asunto = asunto;
            return this;
        }

        public EmailManager Cuerpo (string cuerpo)
        {
            this.cuerpo = cuerpo;
            return this;
        }

        public void enviar()
        {
            Console.WriteLine("El Email ha sido enviado correctamente");
        }

    }
}
