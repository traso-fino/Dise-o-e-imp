Public Class prueba
    Dim turno As Boolean ' Defino a turno como booleano
    Dim c1 As Integer ' Definimos las cajas donde se alojan los valores
    Dim c2 As Integer
    Dim c3 As Integer
    Dim c4 As Integer
    Dim c5 As Integer
    Dim c6 As Integer
    Dim c7 As Integer
    Dim c8 As Integer
    Dim c9 As Integer
    Dim contador As Integer ' Definimos un contador

    Private Sub bot()
        ' Jugada(1, 5, 9)
        If c5 = 0 Then ' Consulto si esta libre la caja 5
            PictureBox5.Enabled = True ' Se habilita la caja 5
            PictureBox5.Image = My.Resources.O2 ' Dentro de la caja se verá la imagen O
            c5 = 2 ' Se define a la caja 5 como O
            turno = True ' El turno cambia a la persona
        End If

        If c5 = 2 Then ' Si el 5 está presionado por el 5, entonces prosigo
            If c1 = 0 Then ' Si la caja 1 está libre, entonces la agrego
                PictureBox1.Enabled = True ' Se habilita la caja 1
                PictureBox1.Image = My.Resources.O2 ' Dentro de la caja se verá la imagen O
                c1 = 2 ' La caja cambia a O
                turno = True ' El turno cambia a la persona
            End If
            If c5 = 2 And c1 = 2 And c9 = 0 And turno = False Then ' Si la caja 5 y 1 tienen O y es el turno de la CPU, entonces
                PictureBox9.Enabled = True ' Se habilita la caja 9
                PictureBox9.Image = My.Resources.O2 ' Dentro de la caja se verá la imagen O
                c9 = 2 ' La caja pasa a estado O
                turno = True ' El turno se cambia
                MsgBox("Gano la CPU")
            End If
        End If

        ' Otras jugadas aquí...

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        PictureBox1.Enabled = True ' Habilitamos los PictureBox
        PictureBox2.Enabled = True
        PictureBox3.Enabled = True
        PictureBox4.Enabled = True
        PictureBox5.Enabled = True
        PictureBox6.Enabled = True
        PictureBox7.Enabled = True
        PictureBox8.Enabled = True
        PictureBox9.Enabled = True

        Randomize()
        turno = Int(Rnd()) ' Realizamos el sorteo del turno
        If turno = 0 Then ' Si cae 0, comienza la CPU
            PictureBox5.Enabled = True ' Se habilita la caja 5
            PictureBox5.Image = My.Resources.O2 ' Dentro de la caja se verá la imagen O
            MsgBox("Comienza la CPU") ' Mensaje de inicio
            c5 = 2
            turno = True
        Else
            MsgBox("Tu comienzas") ' Mensaje de inicio 2
            turno = True
        End If

        If turno = True Then ' Esto muestra de quién es el turno
            Label2.Text = "ES EL TURNO DEL JUGADOR X"
        Else
            turno = False
            Label2.Text = "ES EL TURNO DEL JUGADOR O"
        End If
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        If turno = True Then ' Si el turno es verdadero, comienza a jugar el P1
            PictureBox1.Image = My.Resources.X ' Definimos que el primer movimiento será en el medio
            turno = False ' El turno se anula
            c1 = 1 ' Defino si el PictureBox tiene la imagen X, entonces lo guarda en la variable "Caja 1"
            PictureBox1.Enabled = False ' Inhabilitamos el PictureBox para que el usuario no pueda volver a seleccionarlo
        Else
            PictureBox1.Image = My.Resources.O2 ' El P2 comienza y empieza moviendo
            turno = True ' Su turno comienza
            c1 = 2 ' Defino si el PictureBox tiene la imagen O, entonces lo guarda en la variable "Caja 1"
            PictureBox1.Enabled = False ' Inhabilitamos el PictureBox para que el usuario no pueda volver a seleccionarlo
        End If
        contador = contador + 1 ' Restamos un movimiento del contador para saber cuántas jugadas se hacen
        bot() ' Llama a la función para que juegue la CPU

        If c1 = 1 And c2 = 1 And c3 = 1 Then ' Condiciones de que si las 3 cajas de arriba tienen X, muestra mensaje
            MsgBox("Jugador X GANA")
        End If
        If c1 = 2 And c2 = 2 And c3 = 2 Then ' Condiciones de que si las 3 cajas de arriba tienen O, muestra mensaje
            MsgBox("Jugador O GANA")
        End If

        ' Otras condiciones de victoria...
    End Sub

    'verificacion de los picturebox
    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        If turno = True Then
            PictureBox2.Image = My.Resources.X
            turno = False
            c2 = 1
            PictureBox2.Enabled = False
        Else
            PictureBox2.Image = My.Resources.O2
            turno = True
            c2 = 2
            PictureBox2.Enabled = False
        End If
        contador = contador + 1
        bot()

        ' Condiciones de victoria...
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        If turno = True Then
            PictureBox3.Image = My.Resources.X
            turno = False
            c3 = 1
            PictureBox3.Enabled = False
        Else
            PictureBox3.Image = My.Resources.O2
            turno = True
            c3 = 2
            PictureBox3.Enabled = False
        End If
        contador = contador + 1
        bot()


    End Sub
    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        If turno = True Then
            PictureBox4.Image = My.Resources.X
            turno = False
            c4 = 1
            PictureBox4.Enabled = False
        Else
            PictureBox4.Image = My.Resources.O2
            turno = True
            c4 = 2
            PictureBox4.Enabled = False
        End If
        contador = contador + 1
        bot()

        ' Condiciones de victoria...
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        If turno = True Then
            PictureBox5.Image = My.Resources.X
            turno = False
            c5 = 1
            PictureBox5.Enabled = False
        Else
            PictureBox5.Image = My.Resources.O2
            turno = True
            c5 = 2
            PictureBox5.Enabled = False
        End If
        contador = contador + 1
        bot()

        ' Condiciones de victoria...
    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        If turno = True Then
            PictureBox6.Image = My.Resources.X
            turno = False
            c6 = 1
            PictureBox6.Enabled = False
        Else
            PictureBox6.Image = My.Resources.O2
            turno = True
            c6 = 2
            PictureBox6.Enabled = False
        End If
        contador = contador + 1
        bot()

        ' Condiciones de victoria...
    End Sub

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
        If turno = True Then
            PictureBox7.Image = My.Resources.X
            turno = False
            c7 = 1
            PictureBox7.Enabled = False
        Else
            PictureBox7.Image = My.Resources.O2
            turno = True
            c7 = 2
            PictureBox7.Enabled = False
        End If
        contador = contador + 1
        bot()

        ' Condiciones de victoria...
    End Sub

    Private Sub PictureBox8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox8.Click
        If turno = True Then
            PictureBox8.Image = My.Resources.X
            turno = False
            c8 = 1
            PictureBox8.Enabled = False
        Else
            PictureBox8.Image = My.Resources.O2
            turno = True
            c8 = 2
            PictureBox8.Enabled = False
        End If
        contador = contador + 1
        bot()

        ' Condiciones de victoria...
    End Sub

    Private Sub PictureBox9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox9.Click
        If turno = True Then
            PictureBox9.Image = My.Resources.X
            turno = False
            c9 = 1
            PictureBox9.Enabled = False
        Else
            PictureBox9.Image = My.Resources.O2
            turno = True
            c9 = 2
            PictureBox9.Enabled = False
        End If
        contador = contador + 1
        bot()

        ' Condiciones de victoria...
    End Sub



End Class
