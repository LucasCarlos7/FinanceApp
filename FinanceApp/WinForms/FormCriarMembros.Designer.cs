namespace FinanceApp.WinForms;

partial class FormCriarMembros
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        lbTextoPrincipal = new Label();
        label1 = new Label();
        txtNomeCompleto = new TextBox();
        label2 = new Label();
        label3 = new Label();
        txtDataNascimento = new MaskedTextBox();
        cbGrauParentesco = new ComboBox();
        btnSalvarNovoMembro = new Button();
        SuspendLayout();
        // 
        // lbTextoPrincipal
        // 
        lbTextoPrincipal.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        lbTextoPrincipal.Location = new Point(25, 13);
        lbTextoPrincipal.Name = "lbTextoPrincipal";
        lbTextoPrincipal.Size = new Size(465, 62);
        lbTextoPrincipal.TabIndex = 0;
        lbTextoPrincipal.Text = "Os membros poderão ser vinculados à transações e facilitar a visão geral de gastos";
        lbTextoPrincipal.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label1.Location = new Point(26, 100);
        label1.Name = "label1";
        label1.Size = new Size(112, 17);
        label1.TabIndex = 0;
        label1.Text = "Nome completo *";
        label1.TextAlign = ContentAlignment.TopCenter;
        // 
        // txtNomeCompleto
        // 
        txtNomeCompleto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        txtNomeCompleto.Location = new Point(25, 120);
        txtNomeCompleto.Multiline = true;
        txtNomeCompleto.Name = "txtNomeCompleto";
        txtNomeCompleto.PlaceholderText = "Nome e sobrenome";
        txtNomeCompleto.Size = new Size(465, 29);
        txtNomeCompleto.TabIndex = 1;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label2.Location = new Point(26, 185);
        label2.Name = "label2";
        label2.Size = new Size(124, 17);
        label2.TabIndex = 0;
        label2.Text = "Data de nascimento";
        label2.TextAlign = ContentAlignment.TopCenter;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label3.Location = new Point(26, 269);
        label3.Name = "label3";
        label3.Size = new Size(124, 17);
        label3.TabIndex = 0;
        label3.Text = "Grau de parentesco";
        label3.TextAlign = ContentAlignment.TopCenter;
        // 
        // txtDataNascimento
        // 
        txtDataNascimento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        txtDataNascimento.Location = new Point(25, 205);
        txtDataNascimento.Mask = "00/00/0000";
        txtDataNascimento.Name = "txtDataNascimento";
        txtDataNascimento.Size = new Size(465, 29);
        txtDataNascimento.TabIndex = 2;
        txtDataNascimento.ValidatingType = typeof(DateTime);
        // 
        // cbGrauParentesco
        // 
        cbGrauParentesco.DropDownStyle = ComboBoxStyle.DropDownList;
        cbGrauParentesco.Font = new Font("Segoe UI", 12F);
        cbGrauParentesco.FormattingEnabled = true;
        cbGrauParentesco.Location = new Point(24, 289);
        cbGrauParentesco.Name = "cbGrauParentesco";
        cbGrauParentesco.Size = new Size(465, 29);
        cbGrauParentesco.TabIndex = 3;
        // 
        // btnSalvarNovoMembro
        // 
        btnSalvarNovoMembro.BackColor = Color.Green;
        btnSalvarNovoMembro.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        btnSalvarNovoMembro.ForeColor = SystemColors.Control;
        btnSalvarNovoMembro.Location = new Point(164, 362);
        btnSalvarNovoMembro.Name = "btnSalvarNovoMembro";
        btnSalvarNovoMembro.Size = new Size(187, 45);
        btnSalvarNovoMembro.TabIndex = 4;
        btnSalvarNovoMembro.Text = "Criar membro";
        btnSalvarNovoMembro.UseVisualStyleBackColor = false;
        btnSalvarNovoMembro.Click += btnSalvarNovoMembro_Click;
        // 
        // FormCriarMembros
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.ButtonHighlight;
        ClientSize = new Size(515, 450);
        Controls.Add(btnSalvarNovoMembro);
        Controls.Add(cbGrauParentesco);
        Controls.Add(txtDataNascimento);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(txtNomeCompleto);
        Controls.Add(label1);
        Controls.Add(lbTextoPrincipal);
        Name = "FormCriarMembros";
        Text = "FormCriarMembros";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lbTextoPrincipal;
    private Label label1;
    private TextBox txtNomeCompleto;
    private Label label2;
    private Label label3;
    private MaskedTextBox txtDataNascimento;
    private ComboBox cbGrauParentesco;
    private Button btnSalvarNovoMembro;
}