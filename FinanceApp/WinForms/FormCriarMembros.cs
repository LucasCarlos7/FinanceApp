using FinanceApp.Core.Enums;
using FinanceApp.Shared.Helpers;
using System.Data;

namespace FinanceApp.WinForms;

public partial class FormCriarMembros : Form
{
    public FormCriarMembros()
    {
        InitializeComponent();
        Load += FormCriarMembros_Load;
    }

    private void btnSalvarNovoMembro_Click(object sender, EventArgs e)
    {

    }

    private void FormCriarMembros_Load(object sender, EventArgs e) {
        cbGrauParentesco.DataSource = Enum.GetValues(typeof(GrauParentescoEnum))
            .Cast<GrauParentescoEnum>()
            .Select(e => new { Valor = e, Texto = e.GetDescription() })
            .ToList();

        cbGrauParentesco.DisplayMember = "Texto";
        cbGrauParentesco.ValueMember = "Valor";
        cbGrauParentesco.DrawMode = DrawMode.OwnerDrawFixed;

        cbGrauParentesco.SelectedIndex = -1;

        cbGrauParentesco.DrawItem += ComboBoxGrauParentescoDrawItem;
    }

    private void ComboBoxGrauParentescoDrawItem(object sender, DrawItemEventArgs e)
    {
        if (e.Index < 0)
        {
            e.DrawBackground();
            using (Brush brush = new SolidBrush(Color.Gray))
            {
                e.Graphics.DrawString("Selecione uma opção", cbGrauParentesco.Font, brush, e.Bounds);
            }

            return;
        }

        string text = cbGrauParentesco.GetItemText(cbGrauParentesco.Items[e.Index]);

        e.DrawBackground();
        using (Brush brush1 = new SolidBrush(Color.Black))
        {
            e.Graphics.DrawString(text, cbGrauParentesco.Font, brush1, e.Bounds);
        }

        e.DrawFocusRectangle();
    }

}
