Public Class TAPITA

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Visible = False 'ocultamos el formulario 
        TAPITAvs1.Visible = True 'mostramos el formulario de 1vs1

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Visible = False 'ocultamos el formulario
        TAPITAvsIA.Visible = True 'mostramos el formulario de 1vsIA
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Visible = False 'ocultamos el formulario 
        Ayuda.Visible = True 'mostramos el formulario de ayuda para el usuario
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Visible = False
        prueba.Visible = True

    End Sub

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        End
    End Sub
End Class
