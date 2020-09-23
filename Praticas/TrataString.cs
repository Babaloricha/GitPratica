using System;
using System.Collections.Generic;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;

namespace Praticas
{
    public class TrataString
    {
        public String resultado { get; set; }
        public String expressao;
        public void TrataValorMonetario(string valor)
        {
            
            expressao = @"^[1 - 9]\d{ 0,2} (\.\d{ 3})*,\d{ 2}$";
            resultado = "b     1.1111,23                 a";
            retiraLetraEspaco();
            //resultado = Regex.Replace(resultado, expressao, "");
        }
        
        public void retiraLetraEspaco()
        {
            var retirar = @"[A-Za-z ]";
            resultado = Regex.Replace(resultado, retirar, "");
        }

        public bool VerificaFormato()
        {
            expressao = @"^[1 - 9]\d{ 0,2} (\.\d{ 3})*,\d{ 2}$";
            return Regex.IsMatch(resultado, expressao);
        }
    }
}
