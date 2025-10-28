Module modulo_geral
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public diretorio, sql, aux_cpf, resp, status As String  'Declaração de Variáveis
    Public cont As Integer
    Public dir_banco = Application.StartupPath & "\banco\BancodeDados.mdb"

    Sub conecta_banco_access()
        Try
            'String de Conexão SQL-SERVER
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & dir_banco)
            'MsgBox("Conexão OK", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        Catch ex As Exception
            MsgBox("Erro ao Conectar", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub


    Sub carregar_dados()
        With admin.dgv_dados
            sql = "select * from cadastro order by Nome asc"
            rs = db.Execute(sql)
            cont = 1
            .Rows.Clear()
            Do While rs.EOF = False
                .Rows.Add(cont, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value, rs.Fields(5).Value, rs.Fields(6).Value, status)
                rs.MoveNext()
                cont = cont + 1
            Loop
        End With
    End Sub
End Module
