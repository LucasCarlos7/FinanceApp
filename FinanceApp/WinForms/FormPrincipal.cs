using FinanceApp.WinForms;

namespace FinanceApp;

public partial class FormPrincipal : Form
{
    public FormPrincipal()
    {
        InitializeComponent();
    }

    private void btnAdicionarConta_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void btnRegistrarTransacao_Click(object sender, EventArgs e)
    {
        tabPrincipal.SelectTab(pagRegistrarTransacao);
    }

    private void btnInicio_Click(object sender, EventArgs e)
    {
        tabPrincipal.SelectTab(pagInicio);
    }

    private void btnMembros_Click(object sender, EventArgs e)
    {
        tabPrincipal.SelectTab(pagMembros);
    }

    private void btnCriarMembros_Click(object sender, EventArgs e) {
        using (var form = new FormCriarMembros())
        {
            form.ShowDialog();
        }
    }

}
