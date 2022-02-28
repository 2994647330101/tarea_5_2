Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim texto As String = TextBox1.Text
        Dim n As Decimal = Convert.ToDecimal(texto)
        Dim i, j As Integer
        Dim cantidadmultiplosdecuatro As Integer = 0
        Dim indice = j
        Try
            j = 1

            'formula para calculo n! = 1 x 2 x 3 x 4 x 5 x ... x (n-1) x n

            For i = 1 To n Step 1
                j = j * i
            Next
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            End Try
        Label2.Text = j.ToString
        While (indice <= n)
            If (indice Mod 4 = 0) Then

                cantidadmultiplosdecuatro = cantidadmultiplosdecuatro + 1
            End If
            indice = indice + 1
        End While
        Label3.Text = indice.ToString


    End Sub

End Class
