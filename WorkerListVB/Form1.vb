Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Using form2 As New Form2()
            If form2.ShowDialog() <> DialogResult.OK Then
                Return
            End If
        End Using
    End Sub

    Private Sub btnSeeEmployee_Click(sender As Object, e As EventArgs) Handles btnSeeEmployee.Click
        Using form3 As New Form3()
            If form3.ShowDialog() <> DialogResult.OK Then
                Return
            End If
        End Using
    End Sub

    Private Sub btnObservations_Click(sender As Object, e As EventArgs) Handles btnObservations.Click
        Using form4 As New Form4()
            If form4.ShowDialog() <> DialogResult.OK Then
                Return
            End If
        End Using
    End Sub


End Class
