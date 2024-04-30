using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaFuncionario
{
    public class Horista : Funcionario
    {
        protected int qtdeHorasSemana;
        public Horista()
        {}
        public Horista(int codigo, string nome, double salario, int qtdeHorasSemana) : base(codigo, nome, salario)
        {
            QtdeHorasSemana = qtdeHorasSemana;
        }

        public override void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine("Horas semanais: " + QtdeHorasSemana);
        }

        // Propriedades para os campos específicos
        public int QtdeHorasSemana
        {
            get { return qtdeHorasSemana; }
            set { qtdeHorasSemana = value; }
        }
    }
}