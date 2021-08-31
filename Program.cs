using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDeDisenio
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanciar la clase EmailManager
            EmailManager em = new EmailManager();

            //redundancia al utilizar los metodos getter y setter tradicionales
            // observamos redundancia ya que ya que "em" se repite un importante numero de veces y podemos mejorarlo
            //em.cliente = "Roberto Perez";
            //em.desde ="anohter@hotmail.com";
            //em.para = "your-mail@gmail.com";
            //em.asunto = "Saludo";
            //em.cuerpo = "Gracias por sus comentarios";




            // PATRON DE DISEÑO CASCADA
            // nueva forma de instanciar
            EmailManager nuevoEmail = new EmailManager()
                .Cliente("Roberto Perez")
                .Desde("another@hotmail.com")
                .Para("your-nauk@gmail.com")
                .Asunto("Saludo")
                .Cuerpo("Gracias por sus comentarios");

            nuevoEmail.enviar();

            // como resultado se logra eliminar codigo duplicado logrando mas legibilidad y simplicidad de uso
        }
    }
}
