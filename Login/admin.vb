Public Class admin
    Private Sub admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco_access()
    End Sub

    Private Sub dgv_dados_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dados.CellContentClick
        Try
            With dgv_dados

                If .CurrentRow.Cells(3).Selected = True Then
                    aux_cpf = .CurrentRow.Cells(1).Value
                    sql = $"select * from cadastro where CPF ='{aux_cpf}'"
                    rs = db.Execute(sql)
                    txt_cpf.Text = rs.Fields(1).Value
                    txt_nome.Text = rs.Fields(2).Value
                    cmb_data_nasc.Value = rs.Fields(3).Value
                    txt_fone.Text = rs.Fields(4).Value
                    txt_email.Text = rs.Fields(5).Value
                    rs.Fields(6).Value = "ATIVA"
                ElseIf .CurrentRow.Cells(6).Selected = True Then
                    aux_cpf = .CurrentRow.Cells(1).Value
                    Dim status_atual As String
                    status_atual = .CurrentRow.Cells(6).Value

                    If status_atual = "ATIVA" Then
                        resp = MsgBox("Deseja realmente bloquear esta conta?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                        If resp = MsgBoxResult.Yes Then
                            sql = $"UPDATE cadastro SET [Status] = 'BLOQUEADA' WHERE cpf='{aux_cpf}'"
                            db.Execute(sql)
                        End If
                    ElseIf status_atual = "BLOQUEADA" Then
                        resp = MsgBox("Deseja reativar esta conta?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "ATENÇÃO")
                        If resp = MsgBoxResult.Yes Then
                            sql = $"UPDATE cadastro SET [Status] = 'ATIVA' WHERE cpf='{aux_cpf}'"
                            db.Execute(sql)
                        End If
                    End If
                    carregar_dados()
                Else
                    Exit Sub
                End If
            End With
        Catch ex As Exception
            MsgBox("Erro de processamento!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub


    Private Sub txt_cpf_DoubleClick(sender As Object, e As EventArgs) Handles txt_cpf.DoubleClick
        txt_cpf.Clear()
        txt_nome.Clear()
        cmb_data_nasc.Value = Now
        txt_fone.Clear()
        txt_email.Clear()
        txt_cpf.Focus()
    End Sub

    Private Sub btn_cadastro_Click(sender As Object, e As EventArgs) Handles btn_cadastro.Click
        Try
            sql = $"select * from cadastro where CPF='{txt_cpf.Text}'"
            rs = db.Execute(sql)
            If rs.EOF = False Then 'Se existir o cpf na tabela
                sql = $"update cadastro set Nome='{txt_nome.Text}',
                                            Data_Nascimento='{cmb_data_nasc.Value.ToShortDateString}',
                                           Fone='{txt_fone.Text}',
                                           Email='{txt_email.Text}',
                                           where CPF='{txt_cpf.Text}'"
                rs = db.Execute(UCase(sql))
                MsgBox("Dados alterados com sucesso!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
            Else
                sql = $"insert into cadastro (CPF,Nome,Data_Nascimento,Fone,Email) values
                       ('{txt_cpf.Text}', '{txt_nome.Text}', '{cmb_data_nasc.Value.ToShortDateString}',
                        '{txt_fone.Text}','{txt_email.Text}')"
                rs = db.Execute(UCase(sql))
                MsgBox("Dados gravados com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")

            End If
            carregar_dados()
            txt_cpf.Clear()
            txt_nome.Clear()
            cmb_data_nasc.Value = Now
            txt_fone.Clear()
            txt_email.Clear()
            txt_cpf.Focus()

        Catch ex As Exception
            MsgBox("Erro ao gravar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")

        End Try
    End Sub
End Class




