<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class admin
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txt_cpf = New System.Windows.Forms.MaskedTextBox()
        Me.cmb_data_nasc = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.txt_fone = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_cadastro = New System.Windows.Forms.Button()
        Me.dgv_dados = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CPF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Data_Nascimento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status_Conta = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.dgv_dados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_cpf
        '
        Me.txt_cpf.Location = New System.Drawing.Point(168, 58)
        Me.txt_cpf.Mask = "999.999.999-99"
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(124, 26)
        Me.txt_cpf.TabIndex = 0
        '
        'cmb_data_nasc
        '
        Me.cmb_data_nasc.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.cmb_data_nasc.Location = New System.Drawing.Point(552, 58)
        Me.cmb_data_nasc.Name = "cmb_data_nasc"
        Me.cmb_data_nasc.Size = New System.Drawing.Size(200, 26)
        Me.cmb_data_nasc.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(164, 35)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "CPF:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(548, 35)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "DATA NASCIMENTO:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(382, 191)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 20)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "E-MAIL:"
        '
        'txt_email
        '
        Me.txt_email.Location = New System.Drawing.Point(386, 213)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(366, 26)
        Me.txt_email.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(164, 110)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 20)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "NOME:"
        '
        'txt_nome
        '
        Me.txt_nome.Location = New System.Drawing.Point(168, 132)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(584, 26)
        Me.txt_nome.TabIndex = 11
        '
        'txt_fone
        '
        Me.txt_fone.Location = New System.Drawing.Point(168, 213)
        Me.txt_fone.Mask = "+55 (99) 99999-9999"
        Me.txt_fone.Name = "txt_fone"
        Me.txt_fone.Size = New System.Drawing.Size(160, 26)
        Me.txt_fone.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(164, 189)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 20)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "FONE:"
        '
        'btn_cadastro
        '
        Me.btn_cadastro.Location = New System.Drawing.Point(809, 132)
        Me.btn_cadastro.Name = "btn_cadastro"
        Me.btn_cadastro.Size = New System.Drawing.Size(122, 66)
        Me.btn_cadastro.TabIndex = 15
        Me.btn_cadastro.Text = "CADASTRAR"
        Me.btn_cadastro.UseVisualStyleBackColor = True
        '
        'dgv_dados
        '
        Me.dgv_dados.AllowUserToAddRows = False
        Me.dgv_dados.AllowUserToDeleteRows = False
        Me.dgv_dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_dados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.CPF, Me.Nome, Me.Data_Nascimento, Me.Fone, Me.Email, Me.Status_Conta})
        Me.dgv_dados.Location = New System.Drawing.Point(3, 276)
        Me.dgv_dados.Name = "dgv_dados"
        Me.dgv_dados.ReadOnly = True
        Me.dgv_dados.RowHeadersWidth = 62
        Me.dgv_dados.RowTemplate.Height = 28
        Me.dgv_dados.Size = New System.Drawing.Size(1179, 290)
        Me.dgv_dados.TabIndex = 16
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.MinimumWidth = 8
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Width = 150
        '
        'CPF
        '
        Me.CPF.HeaderText = "CPF"
        Me.CPF.MinimumWidth = 8
        Me.CPF.Name = "CPF"
        Me.CPF.ReadOnly = True
        Me.CPF.Width = 150
        '
        'Nome
        '
        Me.Nome.HeaderText = "Nome"
        Me.Nome.MinimumWidth = 8
        Me.Nome.Name = "Nome"
        Me.Nome.ReadOnly = True
        Me.Nome.Width = 150
        '
        'Data_Nascimento
        '
        Me.Data_Nascimento.HeaderText = "Data Nascimento"
        Me.Data_Nascimento.MinimumWidth = 8
        Me.Data_Nascimento.Name = "Data_Nascimento"
        Me.Data_Nascimento.ReadOnly = True
        Me.Data_Nascimento.Width = 150
        '
        'Fone
        '
        Me.Fone.HeaderText = "Fone"
        Me.Fone.MinimumWidth = 8
        Me.Fone.Name = "Fone"
        Me.Fone.ReadOnly = True
        Me.Fone.Width = 150
        '
        'Email
        '
        Me.Email.HeaderText = "Email"
        Me.Email.MinimumWidth = 8
        Me.Email.Name = "Email"
        Me.Email.ReadOnly = True
        Me.Email.Width = 150
        '
        'Status_Conta
        '
        Me.Status_Conta.HeaderText = "Status da Conta"
        Me.Status_Conta.MinimumWidth = 8
        Me.Status_Conta.Name = "Status_Conta"
        Me.Status_Conta.ReadOnly = True
        Me.Status_Conta.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Status_Conta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Status_Conta.Width = 150
        '
        'admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(1194, 567)
        Me.Controls.Add(Me.dgv_dados)
        Me.Controls.Add(Me.btn_cadastro)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_fone)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_nome)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmb_data_nasc)
        Me.Controls.Add(Me.txt_cpf)
        Me.Name = "admin"
        Me.Text = "Página ADMIN"
        CType(Me.dgv_dados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_cpf As MaskedTextBox
    Friend WithEvents cmb_data_nasc As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_email As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents txt_fone As MaskedTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btn_cadastro As Button
    Friend WithEvents dgv_dados As DataGridView
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents CPF As DataGridViewTextBoxColumn
    Friend WithEvents Nome As DataGridViewTextBoxColumn
    Friend WithEvents Data_Nascimento As DataGridViewTextBoxColumn
    Friend WithEvents Fone As DataGridViewTextBoxColumn
    Friend WithEvents Email As DataGridViewTextBoxColumn
    Friend WithEvents Status_Conta As DataGridViewButtonColumn
End Class
