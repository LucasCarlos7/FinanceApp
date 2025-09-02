using FinanceApp.WinForms;

using Microsoft.Extensions.DependencyInjection;

namespace FinanceApp;

public partial class FormPrincipal : Form
{
    private readonly IServiceProvider _serviceProvider;
    public FormPrincipal(IServiceProvider serviceProvider)
    {
        InitializeComponent();
        _serviceProvider = serviceProvider;
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
        using (var form = _serviceProvider.GetRequiredService<FormCriarMembros>())
        {
            form.ShowDialog();
        }
    }

}
