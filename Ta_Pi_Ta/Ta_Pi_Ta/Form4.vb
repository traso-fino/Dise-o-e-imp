Public Class TAPITAvsIA
    Dim turno As Boolean 'defino a turno como booleano
    Dim c1 As Integer 'definimos las cajas donde se alojan los valores
    Dim c2 As Integer
    Dim c3 As Integer
    Dim c4 As Integer
    Dim c5 As Integer
    Dim c6 As Integer
    Dim c7 As Integer
    Dim c8 As Integer
    Dim c9 As Integer
    Dim contador As Integer 'definimos un contador

    Private Function bot()
        'jugada(1, 5, 9)
        If c5 = 0 Then 'consulto si esta libre la caja 5
            PictureBox5.Enabled = True ' se habilita la caja 5
            PictureBox5.Image = My.Resources.O2 'dentro de la caja se vera la imagen o
            c5 = 2 'se define a la caja 5 como O
            turno = True 'el turno cambia a la persona
        End If

        If c5 = 2 Then 'si el 5 esta presionado por el 5, entonces prosigo
            If c1 = 0 Then 'si la caja 1 esta libre, entonces lo agrego
                PictureBox1.Enabled = True ' se habilita la caja 5
                PictureBox1.Image = My.Resources.O2 'dentro de la caja se vera la imagen o
                c1 = 2 'la caja cambia a O
                turno = True 'el turno cambia a la persona
            End If
            If c5 = 2 And c1 = 2 And c9 = 0 And turno = False Then 'si la caja 5 y 1 tienen O y es el turno de la cpu entonces
                PictureBox9.Enabled = True ' se habilita la caja 5
                PictureBox9.Image = My.Resources.O2 'dentro de la caja se vera la imagen o
                c9 = 2 'la caja pasa a estado O
                turno = True 'el turno se cambia
                MsgBox("gano la cpu")
            End If
        End If

        'jugada 4,5 y 6

        If c5 = 0 Then
            PictureBox5.Enabled = True
            PictureBox5.Image = My.Resources.O2
            c5 = 2
            turno = True
        End If

        If c5 = 2 Then
            If c4 = 0 And turno = False Then
                PictureBox4.Enabled = True
                PictureBox4.Image = My.Resources.O2
                c4 = 2
                turno = True
            End If
            If c5 = 2 And c4 = 2 And c6 = 0 And turno = False Then
                PictureBox6.Enabled = True
                PictureBox6.Image = My.Resources.O2
                c6 = 2
                turno = True
                MsgBox("gano la cpu")
            End If
        End If

        'jugada 7,5 y 3

        If c5 = 0 Then
            PictureBox5.Enabled = True
            PictureBox5.Image = My.Resources.O2
            c5 = 2
            turno = True
        End If

        If c5 = 2 Then
            If c7 = 0 And turno = False Then
                PictureBox7.Enabled = True
                PictureBox7.Image = My.Resources.O2
                c7 = 2
                turno = True
            End If
            If c5 = 2 And c7 = 2 And c3 = 0 And turno = False Then
                PictureBox3.Enabled = True
                PictureBox3.Image = My.Resources.O2
                c3 = 2
                turno = True
                MsgBox("gano la cpu")
            End If
        End If

        'jugada 2,5 y 8

        If c5 = 0 Then
            PictureBox5.Enabled = True
            PictureBox5.Image = My.Resources.O2
            c5 = 2
            turno = True
        End If

        If c5 = 2 Then
            If c2 = 0 And turno = False Then
                PictureBox2.Enabled = True
                PictureBox2.Image = My.Resources.O2
                c2 = 2
                turno = True
            End If
            If c5 = 2 And c2 = 2 And c8 = 0 And turno = False Then
                PictureBox8.Enabled = True
                PictureBox8.Image = My.Resources.O2
                c8 = 2
                turno = True
                MsgBox("gano la cpu")
            End If
        End If

        'jugada 9,5 y 1

        If c5 = 0 Then
            PictureBox5.Enabled = True
            PictureBox5.Image = My.Resources.O2
            c5 = 2
            turno = True
        End If

        If c5 = 2 Then
            If c9 = 0 And turno = False Then
                PictureBox9.Enabled = True
                PictureBox9.Image = My.Resources.O2
                c9 = 2
                turno = True
            End If
            If c5 = 2 And c9 = 2 And c1 = 0 And turno = False Then
                PictureBox1.Enabled = True
                PictureBox1.Image = My.Resources.O2
                c1 = 2
                turno = True
                MsgBox("gano la cpu")
            End If
        End If

        'jugada 6,5 y 4

        If c5 = 0 Then
            PictureBox5.Enabled = True
            PictureBox5.Image = My.Resources.O2
            c5 = 2
            turno = True
        End If

        If c5 = 2 Then
            If c6 = 0 And turno = False Then
                PictureBox6.Enabled = True
                PictureBox6.Image = My.Resources.O2
                c6 = 2
                turno = True
            End If
            If c5 = 2 And c5 = 2 And c4 = 0 And turno = False Then
                PictureBox4.Enabled = True
                PictureBox4.Image = My.Resources.O2
                c4 = 2
                turno = True
                MsgBox("gano la cpu")
            End If
        End If

        'jugada 3,5 y 7

        If c5 = 0 Then
            PictureBox5.Enabled = True
            PictureBox5.Image = My.Resources.O2
            c5 = 2
            turno = True
        End If

        If c5 = 2 Then
            If c3 = 0 And turno = False Then
                PictureBox3.Enabled = True
                PictureBox3.Image = My.Resources.O2
                c3 = 2
                turno = True
            End If
            If c5 = 2 And c3 = 2 And c7 = 0 And turno = False Then
                PictureBox7.Enabled = True
                PictureBox7.Image = My.Resources.O2
                c7 = 2
                turno = True
                MsgBox("gano la cpu")
            End If
        End If

        'jugada 8,5 y 2

        If c5 = 0 Then
            PictureBox5.Enabled = True
            PictureBox5.Image = My.Resources.O2
            c5 = 2
            turno = True
        End If

        If c5 = 2 Then
            If c8 = 0 And turno = False Then
                PictureBox8.Enabled = True
                PictureBox8.Image = My.Resources.O2
                c8 = 2
                turno = True
            End If
            If c5 = 2 And c8 = 2 And 2 = 0 And turno = False Then
                PictureBox2.Enabled = True
                PictureBox2.Image = My.Resources.O2
                c2 = 2
                turno = True
                MsgBox("gano la cpu")
            End If
        End If

        'jugada 1,2 y 3

        If c1 = 0 Then
            PictureBox1.Enabled = True
            PictureBox1.Image = My.Resources.O2
            c1 = 2
            turno = True
        End If

        If c1 = 2 Then
            If c2 = 0 And turno = False Then
                PictureBox2.Enabled = True
                PictureBox2.Image = My.Resources.O2
                c2 = 2
                turno = True
            End If
            If c1 = 2 And c2 = 2 And c3 = 0 And turno = False Then
                PictureBox3.Enabled = True
                PictureBox3.Image = My.Resources.O2
                c3 = 2
                turno = True
                MsgBox("gano la cpu")
            End If
        End If


        'jugada 1,4 y 7

        If c1 = 0 Then
            PictureBox1.Enabled = True
            PictureBox1.Image = My.Resources.O2
            c1 = 2
            turno = True
        End If

        If c1 = 2 Then
            If c4 = 0 And turno = False Then
                PictureBox4.Enabled = True
                PictureBox4.Image = My.Resources.O2
                c4 = 2
                turno = True
            End If
            If c1 = 2 And c4 = 2 And c7 = 0 And turno = False Then
                PictureBox7.Enabled = True
                PictureBox7.Image = My.Resources.O2
                c7 = 2
                turno = True
                MsgBox("gano la cpu")
            End If
        End If

        'jugada 7,8 y 9

        If c7 = 0 Then
            PictureBox7.Enabled = True
            PictureBox7.Image = My.Resources.O2
            c7 = 2
            turno = True
        End If

        If c7 = 2 Then
            If c8 = 0 And turno = False Then
                PictureBox8.Enabled = True
                PictureBox8.Image = My.Resources.O2
                c8 = 2
                turno = True
            End If
            If c7 = 2 And c8 = 2 And c9 = 0 And turno = False Then
                PictureBox9.Enabled = True
                PictureBox9.Image = My.Resources.O2
                c9 = 2
                turno = True
                MsgBox("gano la cpu")
            End If
        End If

        'jugada 9,6 y 3

        If c9 = 0 Then
            PictureBox9.Enabled = True
            PictureBox9.Image = My.Resources.O2
            c9 = 2
            turno = True
        End If

        If c9 = 2 Then
            If c6 = 0 And turno = False Then
                PictureBox6.Enabled = True
                PictureBox6.Image = My.Resources.O2
                c6 = 2
                turno = True
            End If
            If c9 = 2 And c6 = 2 And c3 = 0 And turno = False Then
                PictureBox3.Enabled = True
                PictureBox3.Image = My.Resources.O2
                c3 = 2
                turno = True
                MsgBox("gano la cpu")
            End If
        End If
    End Function
    'Se las definio como cajas, porque es donde va alojada la imagen/valor
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        PictureBox1.Enabled = True 'habilitamos los picturebox
        PictureBox2.Enabled = True
        PictureBox3.Enabled = True
        PictureBox4.Enabled = True
        PictureBox5.Enabled = True
        PictureBox6.Enabled = True
        PictureBox7.Enabled = True
        PictureBox8.Enabled = True
        PictureBox9.Enabled = True
        'Sabiendo que X es Jugador y O es Pc
        'comienza el X debe seleccionarse una 
        Randomize()
        turno = Int(Rnd()) 'realizamos el sorteo del turno
        If turno = 0 Then 'si cae 0, comienza la cpu
            PictureBox5.Enabled = True ' se habilita la caja 5
            PictureBox5.Image = My.Resources.O2 'dentro de la caja se vera la imagen o
            MsgBox("Comienza la Cpu") 'mensaje de inicio
            c5 = 2
            turno = True
        Else 'sino
            MsgBox("Tu comienzas") 'mensaje de inicio 2 
            turno = 1
        End If
        If turno = True Then 'Esto muestra de quien es el turno 
            Label2.Text = "ES EL TURNO DEL JUGADOR X"
        Else
            turno = False
            Label2.Text = "ES EL TURNO DEL JUGADOR O"
        End If
    End Sub
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        If turno = True Then ' si el turno es verdadero comienza a jugar el p1
            PictureBox1.Image = My.Resources.X ' Definimos que el primer movimiento sera en el medio 
            turno = False ' el turno se anula
            c1 = 1 'defino si el pictbx tiene la imagen X entonces lo guarda en la variable "Caja 1"
            PictureBox1.Enabled = False 'inabilitamos el picturebox para que el usuario no pueda volver a seleccionarlo
        Else 'sino
            PictureBox1.Image = My.Resources.O2 ' el P2 comienza y empieza moviendo
            turno = True ' su turno comienza
            c1 = 2 'defino si el pictbx tiene la imagen 0 entonces lo guarda en la variable "Caja 1"
            PictureBox1.Enabled = False 'inabilitamos el picturebox para que el usuario no pueda volver a seleccionarlo
        End If
        contador = contador + 1 'restamos un movimiento al contador
        bot()
        If c1 = 1 And c5 = 1 And c9 = 1 Then 'agregamos jugadas ganadoras
            MsgBox("GANO EL JUGADOR X")
        End If
        If c1 = 1 And c2 = 1 And c3 = 1 Then 'agregamos jugadas ganadoras
            MsgBox("GANO EL JUGADOR X")
        End If
        If c1 = 1 And c4 = 1 And c7 = 1 Then 'agregamos jugadas ganadoras
            MsgBox("GANO EL JUGADOR X")
        End If
        If c1 = 2 And c5 = 2 And c9 = 2 Then 'agregamos jugadas ganadoras
            MsgBox("GANO EL JUGADOR 0")
        End If
        If c1 = 2 And c2 = 2 And c3 = 2 Then 'agregamos jugadas ganadoras
            MsgBox("GANO EL JUGADOR 0")
        End If
        If c1 = 2 And c4 = 2 And c7 = 2 Then 'agregamos jugadas ganadoras
            MsgBox("GANO EL JUGADOR 0")
        End If
        If contador = 9 Then 'si no hay mas movimientos, se declara el empate
            MsgBox("EMPATE")
        End If
        Label2.Text = turno
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        If turno = True Then ' si el turno es verdadero comienza a jugar el p1
            PictureBox2.Image = My.Resources.X ' Definimos que el primer movimiento sera en el medio 
            turno = False ' el turno se anula
            c2 = 1 'defino si el pictbx tiene la imagen X entonces lo guarda en la variable "Caja 2"
            PictureBox2.Enabled = False 'inabilitamos el picturebox para que el usuario no pueda volver a seleccionarlo
        Else 'sino
            PictureBox2.Image = My.Resources.O2 ' el P2 comienza y empieza moviendo
            turno = True ' su turno comienza
            c2 = 2 'defino si el pictbx tiene la imagen O entonces lo guarda en la variable "Caja 2"
            PictureBox2.Enabled = False 'inabilitamos el picturebox para que el usuario no pueda volver a seleccionarlo
        End If
        contador = contador + 1 'le restmamos un movimiento al contador
        bot()
        If c1 = 1 And c2 = 1 And c3 = 1 Then 'agregamos jugadas ganadoras
            MsgBox("GANO EL JUGADOR X")
        End If
        If c2 = 1 And c5 = 1 And c8 = 1 Then 'agregamos jugadas ganadoras
            MsgBox("GANO EL JUGADOR X")
        End If
        If c1 = 2 And c2 = 2 And c3 = 2 Then 'agregamos jugadas ganadoras
            MsgBox("GANO EL JUGADOR 0")
        End If
        If c2 = 2 And c5 = 2 And c8 = 2 Then 'agregamos jugadas ganadoras
            MsgBox("GANO EL JUGADOR 0")
        End If
        If contador = 9 Then 'si no quedan movimientos, se declara el empate
            MsgBox("EMPATE")
        End If
        Label2.Text = turno
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        If turno = True Then ' si el turno es verdadero comienza a jugar el p1
            PictureBox3.Image = My.Resources.X ' Definimos que el primer movimiento sera en el medio 
            turno = False ' el turno se anula
            c3 = 1 'defino si el pictbx tiene la imagen X entonces lo guarda en la variable "Caja 3"
            PictureBox3.Enabled = False 'inabilitamos el picturebox para que el usuario no pueda volver a seleccionarlo
        Else 'sino
            PictureBox3.Image = My.Resources.O2 ' el P2 comienza y empieza moviendo
            turno = True ' su turno comienza
            c3 = 2 'defino si el pictbx tiene la imagen O entonces lo guarda en la variable "Caja 3"
            PictureBox3.Enabled = False 'inabilitamos el picturebox para que el usuario no pueda volver a seleccionarlo
        End If
        contador = contador + 1 'se le resta una jugada
        bot()
        If c1 = 1 And c2 = 1 And c3 = 1 Then 'agregamos jugadas ganadoras
            MsgBox("GANO EL JUGADOR X")
        End If
        If c3 = 1 And c6 = 1 And c9 = 1 Then 'agregamos jugadas ganadoras
            MsgBox("GANO EL JUGADOR X")
        End If
        If c7 = 1 And c5 = 1 And c3 = 1 Then 'agregamos jugadas ganadoras
            MsgBox("GANO EL JUGADOR X")
        End If
        If c1 = 2 And c2 = 2 And c3 = 2 Then 'agregamos jugadas ganadoras
            MsgBox("GANO EL JUGADOR 0")
        End If
        If c3 = 2 And c6 = 2 And c9 = 2 Then 'agregamos jugadas ganadoras
            MsgBox("GANO EL JUGADOR 0")
        End If
        If c7 = 2 And c5 = 2 And c3 = 2 Then 'agregamos jugadas ganadoras
            MsgBox("GANO EL JUGADOR 0")
        End If
        If contador = 9 Then ' si no quedan movimientos, se declara el empate 
            MsgBox("EMPATE")
        End If
        Label2.Text = turno
        'System.Threading.Thread.Sleep(1000)
    End Sub
    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        If turno = True Then ' si el turno es verdadero comienza a jugar el p1
            PictureBox4.Image = My.Resources.X ' Definimos que el primer movimiento sera en el medio 
            turno = False ' el turno se anula
            c4 = 1 'defino si el pictbx tiene la imagen X entonces lo guarda en la variable "Caja 4"
            PictureBox4.Enabled = False 'inabilitamos el picturebox para que el usuario no pueda volver a seleccionarlo
        Else 'sino
            PictureBox4.Image = My.Resources.O2 ' el P2 comienza y empieza moviendo
            turno = True ' su turno comienza
            c4 = 2 'defino si el pictbx tiene la imagen O entonces lo guarda en la variable "Caja 4"
            PictureBox4.Enabled = False 'inabilitamos el picturebox para que el usuario no pueda volver a seleccionarlo
        End If
        contador = contador + 1 'restamos un movimiento
        bot()
        If c1 = 1 And c4 = 1 And c7 = 1 Then 'agregamos jugadas ganadoras
            MsgBox("GANO EL JUGADOR X")
        End If
        If c4 = 1 And c5 = 1 And c6 = 1 Then 'agregamos jugadas ganadoras
            MsgBox("GANO EL JUGADOR X")
        End If
        If c1 = 2 And c4 = 2 And c7 = 2 Then 'agregamos jugadas ganadoras
            MsgBox("GANO EL JUGADOR 0")
        End If
        If c4 = 2 And c5 = 2 And c6 = 2 Then 'agregamos jugadas ganadoras
            MsgBox("GANO EL JUGADOR 0")
        End If
        If contador = 9 Then 'si no nos quedan movimientos, se declara el empate
            MsgBox("EMPATE")
        End If
        Label2.Text = turno
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        If turno = True Then ' si el turno es verdadero comienza a jugar el p1
            PictureBox5.Image = My.Resources.X ' Definimos que el primer movimiento sera en el medio 
            turno = False ' el turno se anula
            c5 = 1 'defino si el pictbx tiene la imagen X entonces lo guarda en la variable "Caja 5"
            PictureBox5.Enabled = False 'inabilitamos el picturebox para que el usuario no pueda volver a seleccionarlo
        Else 'sino
            PictureBox5.Image = My.Resources.O2 ' el P2 comienza y empieza moviendo
            turno = True ' su turno comienza
            c5 = 2 'defino si el pictbx tiene la imagen O entonces lo guarda en la variable "Caja 5"
            PictureBox5.Enabled = False 'inabilitamos el picturebox para que el usuario no pueda volver a seleccionarlo
        End If
        contador = contador + 1 'le restamos un movimiento
        bot()
        If c1 = 1 And c5 = 1 And c9 = 1 Then 'agregamos jugadas ganadoras
            MsgBox("GANO EL JUGADOR X")
        End If
        If c2 = 1 And c5 = 1 And c8 = 1 Then 'agregamos jugadas ganadoras
            MsgBox("GANO EL JUGADOR X")
        End If
        If c4 = 1 And c5 = 1 And c6 = 1 Then 'agregamos jugadas ganadoras
            MsgBox("GANO EL JUGADOR X")
        End If
        If c7 = 1 And c5 = 1 And c3 = 1 Then 'agregamos jugadas ganadoras
            MsgBox("GANO EL JUGADOR X")
        End If
        If c1 = 2 And c5 = 2 And c9 = 2 Then 'agregamos jugadas ganadoras
            MsgBox("GANO EL JUGADOR 0")
        End If
        If c2 = 2 And c5 = 2 And c8 = 2 Then 'agregamos jugadas ganadoras
            MsgBox("GANO EL JUGADOR 0")
        End If
        If c4 = 2 And c5 = 2 And c6 = 2 Then 'agregamos jugadas ganadoras
            MsgBox("GANO EL JUGADOR 0")
        End If
        If c7 = 2 And c5 = 2 And c3 = 2 Then 'agregamos jugadas ganadoras
            MsgBox("GANO EL JUGADOR 0")
        End If
        If contador = 9 Then ' si no quedan movimientos, definimos el empate
            MsgBox("EMPATE")
        End If
        Label2.Text = turno
    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        If turno = True Then ' si el turno es verdadero comienza a jugar el p1
            PictureBox6.Image = My.Resources.X ' Definimos que el primer movimiento sera en el medio 
            turno = False ' el turno se anula
            c6 = 1 'defino si el pictbx tiene la imagen X entonces lo guarda en la variable "Caja 6"
            PictureBox6.Enabled = False 'inabilitamos el picturebox para que el usuario no pueda volver a seleccionarlo
        Else 'sino
            PictureBox6.Image = My.Resources.O2 ' el P2 comienza y empieza moviendo
            turno = True ' su turno comienza
            c6 = 2 'defino si el pictbx tiene la imagen O entonces lo guarda en la variable "Caja 6"
            PictureBox6.Enabled = False 'inabilitamos el picturebox para que el usuario no pueda volver a seleccionarlo
        End If
        contador = contador + 1 'restamos una jugada 
        bot()
        If c3 = 1 And c6 = 1 And c9 = 1 Then 'agregamos jugadas ganadoras
            MsgBox("GANO EL JUGADOR X")
        End If
        If c4 = 1 And c5 = 1 And c6 = 1 Then 'agregamos jugadas ganadoras
            MsgBox("GANO EL JUGADOR X")
        End If
        If c3 = 2 And c6 = 2 And c9 = 2 Then 'agregamos jugadas ganadoras
            MsgBox("GANO EL JUGADOR 0")
        End If
        If c4 = 2 And c5 = 2 And c6 = 2 Then 'agregamos jugadas ganadoras
            MsgBox("GANO EL JUGADOR 0")
        End If
        If contador = 9 Then 'si no tenemos mas movimientos, se declara el empate
            MsgBox("EMPATE")
        End If
        Label2.Text = turno
    End Sub

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
        If turno = True Then ' si el turno es verdadero comienza a jugar el p1
            PictureBox7.Image = My.Resources.X ' Definimos que el primer movimiento sera en el medio 
            turno = False ' el turno se anula
            c7 = 1 'defino si el pictbx tiene la imagen X entonces lo guarda en la variable "Caja 7"
            PictureBox7.Enabled = False 'inabilitamos el picturebox para que el usuario no pueda volver a seleccionarlo
        Else 'sino
            PictureBox7.Image = My.Resources.O2 ' el P2 comienza y empieza moviendo
            turno = True ' su turno comienza
            c7 = 2 'defino si el pictbx tiene la imagen O entonces lo guarda en la variable "Caja 7"
            PictureBox7.Enabled = False 'inabilitamos el picturebox para que el usuario no pueda volver a seleccionarlo
        End If
        contador = contador + 1 'restamos una jugada posible
        bot()
        If c1 = 1 And c4 = 1 And c7 = 1 Then 'agregamos jugadas ganadoras
            MsgBox("GANO EL JUGADOR X")
        End If
        If c7 = 1 And c5 = 1 And c3 = 1 Then 'agregamos jugadas ganadoras
            MsgBox("GANO EL JUGADOR X")
        End If
        If c7 = 1 And c8 = 1 And c9 = 1 Then 'agregamos jugadas ganadoras
            MsgBox("GANO EL JUGADOR X")
        End If
        If c1 = 2 And c4 = 2 And c7 = 2 Then 'agregamos jugadas ganadoras
            MsgBox("GANO EL JUGADOR 0")
        End If
        If c7 = 2 And c5 = 2 And c3 = 2 Then 'agregamos jugadas ganadoras
            MsgBox("GANO EL JUGADOR 0")
        End If
        If c7 = 2 And c8 = 2 And c9 = 2 Then 'agregamos jugadas ganadoras
            MsgBox("GANO EL JUGADOR 0")
        End If
        If contador = 9 Then 'si no quedan mas jugadas, definimos el empate
            MsgBox("EMPATE")
        End If
        Label2.Text = turno
    End Sub

    Private Sub PictureBox8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox8.Click
        If turno = True Then ' si el turno es verdadero comienza a jugar el p1
            PictureBox8.Image = My.Resources.X ' Definimos que el primer movimiento sera en el medio 
            turno = False ' el turno se anula
            c8 = 1 'defino si el pictbx tiene la imagen X entonces lo guarda en la variable "Caja 8"
            PictureBox8.Enabled = False 'inabilitamos el picturebox para que el usuario no pueda volver a seleccionarlo
        Else 'sino
            PictureBox8.Image = My.Resources.O2 ' el P2 comienza y empieza moviendo
            turno = True ' su turno comienza
            c8 = 2 'defino si el pictbx tiene la imagen O entonces lo guarda en la variable "Caja 8"
            PictureBox8.Enabled = False 'inabilitamos el picturebox para que el usuario no pueda volver a seleccionarlo
        End If
        contador = contador + 1
        bot()
        If c2 = 1 And c5 = 1 And c8 = 1 Then 'agregamos jugadas ganadoras
            MsgBox("GANO EL JUGADOR X")
        End If
        If c2 = 2 And c5 = 2 And c8 = 2 Then 'agregamos jugadas ganadoras
            MsgBox("GANO EL JUGADOR 0")
        End If
        If c7 = 2 And c8 = 2 And c9 = 2 Then 'agregamos jugadas ganadoras
            MsgBox("GANO EL JUGADOR 0")
        End If
        If contador = 9 Then 'si no quedan mas jugadas, definimos el empate
            MsgBox("EMPATE")
        End If
        Label2.Text = turno
    End Sub

    Private Sub PictureBox9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox9.Click
        If turno = True Then ' si el turno es verdadero comienza a jugar el p1
            PictureBox9.Image = My.Resources.X ' Definimos que el primer movimiento sera en el medio 
            turno = False ' el turno se anula
            c9 = 1 'defino si el pictbx tiene la imagen X entonces lo guarda en la variable "Caja 9"
            PictureBox9.Enabled = False 'inabilitamos el picturebox para que el usuario no pueda volver a seleccionarlo
        Else 'sino
            PictureBox9.Image = My.Resources.O2 ' el P2 comienza y empieza moviendo
            turno = True ' su turno comienza
            c9 = 2 'defino si el pictbx tiene la imagen O entonces lo guarda en la variable "Caja 9"
            PictureBox9.Enabled = False 'inabilitamos el picturebox para que el usuario no pueda volver a seleccionarlo
        End If
        contador = contador + 1
        bot()
        If c1 = 1 And c5 = 1 And c9 = 1 Then 'agregamos jugadas ganadoras
            MsgBox("GANO EL JUGADOR X")
        End If
        If c3 = 1 And c6 = 1 And c9 = 1 Then 'agregamos jugadas ganadoras
            MsgBox("GANO EL JUGADOR X")
        End If
        If c1 = 2 And c5 = 2 And c9 = 2 Then 'agregamos jugadas ganadoras
            MsgBox("GANO EL JUGADOR 0")
        End If
        If c3 = 2 And c6 = 2 And c9 = 2 Then 'agregamos jugadas ganadoras
            MsgBox("GANO EL JUGADOR 0")
        End If
        If c7 = 2 And c8 = 2 And c9 = 2 Then 'agregamos jugadas ganadoras
            MsgBox("GANO EL JUGADOR 0")
        End If
        If contador = 9 Then 'si no quedan mas jugadas, se define a empate
            MsgBox("EMPATE")
        End If
        Label2.Text = turno
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ' Cierra el formulario actual
        Me.Close()

        ' Crea una nueva instancia del formulario y lo muestra
        Dim nuevoFormulario As New TAPITAvsIA()
        nuevoFormulario.Show()

    End Sub

    Private Sub TAPITAvsIA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
        TAPITA.Visible = True
    End Sub
End Class



