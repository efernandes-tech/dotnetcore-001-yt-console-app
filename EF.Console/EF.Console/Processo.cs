using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Console
{
    public class Processo : IProcesso
    {
        public Processo()
        {

        }

        public string getProcesso()
        {
            return "Processo rodando...";
        }
    }
}
