using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmfuncionario1
{
    public class Funcionarios
    {

        public string Nome { get; set; } = string.Empty;
        public string CPF { get; set; } = string.Empty;

        public double Dias_trabalhados { get; set; }

        public double Valor_diaria { get; set; }

        public double Salario_base { get; private set; }

        public double Valor_ir { get; private set; }

        public double Salario_liquido { get; private set; }

        public void CalcularSalario()
        {
            Salario_base = Valor_diaria * Dias_trabalhados;

            if (Salario_base < 1903.98)
            {
                Salario_liquido = Salario_base;
            }
            else if (Salario_base >= 1903.99 && Salario_base <= 2826.25)
            {
                Valor_ir = (Salario_base * 7.5) / 100;
                Salario_liquido = Salario_base - Valor_ir;
            }
            else if (Salario_base >= 2826.66 && Salario_base <= 3751.05)
            {
                Valor_ir = (Salario_base * 15) / 100;
                Salario_liquido = Salario_base - Valor_ir;
            }
            else if (Salario_base >= 3751.06 && Salario_base <= 4664.68)
            {
                Valor_ir = (Salario_base * 22.5) / 100;
                Salario_liquido = Salario_base - Valor_ir;
            }
        }

    }


}
