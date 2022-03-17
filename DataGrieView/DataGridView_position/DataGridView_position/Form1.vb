Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        '清空一開始的藍色標的
        DataGridView1.ClearSelection()


        Try
            If Me.DataGridView1.Rows.Count >= 2 Then
                '將指標位置更換製最新一筆資料
                DataGridView1.CurrentCell = DataGridView1.Rows(Me.DataGridView1.Rows.Count - 2).Cells(0)
                '將藍色選擇框煥至最新一筆資料
                DataGridView1.Rows(Me.DataGridView1.Rows.Count - 2).Selected = True
            ElseIf Me.DataGridView1.Rows.Count = 1 Then
                DataGridView1.CurrentCell = DataGridView1.Rows(Me.DataGridView1.Rows.Count - 1).Cells(0)
                DataGridView1.Rows(Me.DataGridView1.Rows.Count - 1).Selected = True
            Else
                DataGridView1.CurrentCell = DataGridView1.Rows(Me.DataGridView1.Rows.Count).Cells(0)
                DataGridView1.Rows(Me.DataGridView1.Rows.Count).Selected = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try




    End Sub
End Class
