using frmfuncionario1;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

        private void btnCalcular_Click_1(object sender, EventArgs e)
        {
            Funcionarios funcionarios = new Funcionarios();

            funcionarios.Nome = txtBoxNome.Text;
            funcionarios.CPF = txtBoxCpf.Text;
            funcionarios.Dias_trabalhados = double.Parse(txtBoxDias.Text);
            funcionarios.Valor_diaria = double.Parse(txtBoxValor.Text);

            funcionarios.CalcularSalario();
            txtBoxSalarioBase.Text = funcionarios.Salario_base.ToString();
            txtBoxValorIR.Text = funcionarios.Valor_ir.ToString();
            txtBoxSalarioLiquido.Text = funcionarios.Salario_liquido.ToString();
        }
    }
}