using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaFuncionario
{
    public class Mensalista : Funcionario
    {
        protected int qtdeHorasTrabalhadas;
        public Mensalista()
        {}
        public Mensalista(int codigo, string nome, double salario, int qtdeHorasTrabalhadas) : base(codigo, nome, salario)
        {
            QtdeHorasTrabalhadas = qtdeHorasTrabalhadas;
        }

        public override void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine("Horas Trabalhadas: " + QtdeHorasTrabalhadas);
        }

        // Propriedades para os campos específicos
        public int QtdeHorasTrabalhadas
        {
            get { return qtdeHorasTrabalhadas; }
            set { qtdeHorasTrabalhadas = value; }
        }
    }
}