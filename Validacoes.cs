using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace gestaoVinho
{
    class Validacoes
    {
        public static bool ValidarNome(string Nome)
        {
            Regex validar = new Regex(@"^[a-zA-ZãáàéêíóõúçÃÁÀÉÊÍÓÕÚÇ\s]+$");
            return validar.IsMatch(Nome);
        }
        public static bool ValidarEmail(string Email)
        {
            Regex validar = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            return validar.IsMatch(Email);
        }
    }
}
