Public Class TAPITAvs1
    Dim turno As Boolean 'defino a turno como booleano
    Dim c1 As Integer
    Dim c2 As Integer
    Dim c3 As Integer
    Dim c4 As Integer
    Dim c5 As Integer
    Dim c6 As Integer
    Dim c7 As Integer
    Dim c8 As Integer
    Dim c9 As Integer
    Dim contador As Integer 'definimos un contador
    'Se las definio como cajas, porque es donde va alojada la imagen/valor
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        PictureBox1.Enabled = True 'habilitamos los picturebox
        PictureBox2.Enabled = True 'habilitamos los picturebox
        PictureBox3.Enabled = True 'habilitamos los picturebox
        PictureBox4.Enabled = True 'habilitamos los picturebox
        PictureBox5.Enabled = True 'habilitamos los picturebox
        PictureBox6.Enabled = True 'habilitamos los picturebox
        PictureBox7.Enabled = True 'habilitamos los picturebox
        PictureBox8.Enabled = True 'habilitamos los picturebox
        PictureBox9.Enabled = True 'habilitamos los picturebox
        'Sabiendo que X es Jugador y O es Pc
        'comienza el X debe seleccionarse una 
        turno = Int(Rnd() * 2) 'realizamos el sorteo del turno
        If turno = 0 Then 'si cae 0, comienza el jugador 0
            MsgBox("Comienza el jugador O") 'mensaje de inicio 
        Else 'sino
            MsgBox("Comienza el jugador X") 'mensaje de inicio 2
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
        Else 'sino
            PictureBox1.Image = My.Resources.O2 ' el P2 comienza y empieza moviendo
            turno = True ' su turno comienza
            c1 = 2 'defino si el pictbx tiene la imagen 0 entonces lo guarda en la variable "Caja 1"
        End If
        contador = contador + 1 'restamos un movimiento al contador
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
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        If turno = True Then ' si el turno es verdadero comienza a jugar el p1
            PictureBox2.Image = My.Resources.X ' Definimos que el primer movimiento sera en el medio 
            turno = False ' el turno se anula
            c2 = 1 'defino si el pictbx tiene la imagen X entonces lo guarda en la variable "Caja 2"
        Else 'sino
            PictureBox2.Image = My.Resources.O2 ' el P2 comienza y empieza moviendo
            turno = True ' su turno comienza
            c2 = 2 'defino si el pictbx tiene la imagen O entonces lo guarda en la variable "Caja 2"
        End If
        contador = contador + 1 'le restmamos un movimiento al contador
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
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        If turno = True Then ' si el turno es verdadero comienza a jugar el p1
            PictureBox3.Image = My.Resources.X ' Definimos que el primer movimiento sera en el medio 
            turno = False ' el turno se anula
            c3 = 1 'defino si el pictbx tiene la imagen X entonces lo guarda en la variable "Caja 3"
        Else 'sino
            PictureBox3.Image = My.Resources.O2 ' el P2 comienza y empieza moviendo
            turno = True ' su turno comienza
            c3 = 2 'defino si el pictbx tiene la imagen O entonces lo guarda en la variable "Caja 3"
        End If
        contador = contador + 1 'se le resta una jugada
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
        'System.Threading.Thread.Sleep(1000)
    End Sub
    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        If turno = True Then ' si el turno es verdadero comienza a jugar el p1
            PictureBox4.Image = My.Resources.X ' Definimos que el primer movimiento sera en el medio 
            turno = False ' el turno se anula
            c4 = 1 'defino si el pictbx tiene la imagen X entonces lo guarda en la variable "Caja 4"
        Else 'sino
            PictureBox4.Image = My.Resources.O2 ' el P2 comienza y empieza moviendo
            turno = True ' su turno comienza
            c4 = 2 'defino si el pictbx tiene la imagen O entonces lo guarda en la variable "Caja 4"
        End If
        contador = contador + 1 'restamos un movimiento
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
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        If turno = True Then ' si el turno es verdadero comienza a jugar el p1
            PictureBox5.Image = My.Resources.X ' Definimos que el primer movimiento sera en el medio 
            turno = False ' el turno se anula
            c5 = 1 'defino si el pictbx tiene la imagen X entonces lo guarda en la variable "Caja 5"
        Else 'sino
            PictureBox5.Image = My.Resources.O2 ' el P2 comienza y empieza moviendo
            turno = True ' su turno comienza
            c5 = 2 'defino si el pictbx tiene la imagen O entonces lo guarda en la variable "Caja 5"
        End If
        contador = contador + 1 'le restamos un movimiento
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
    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        If turno = True Then ' si el turno es verdadero comienza a jugar el p1
            PictureBox6.Image = My.Resources.X ' Definimos que el primer movimiento sera en el medio 
            turno = False ' el turno se anula
            c6 = 1 'defino si el pictbx tiene la imagen X entonces lo guarda en la variable "Caja 6"
        Else 'sino
            PictureBox6.Image = My.Resources.O2 ' el P2 comienza y empieza moviendo
            turno = True ' su turno comienza
            c6 = 2 'defino si el pictbx tiene la imagen O entonces lo guarda en la variable "Caja 6"
        End If
        contador = contador + 1 'restamos una jugada 
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
    End Sub

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
        If turno = True Then ' si el turno es verdadero comienza a jugar el p1
            PictureBox7.Image = My.Resources.X ' Definimos que el primer movimiento sera en el medio 
            turno = False ' el turno se anula
            c7 = 1 'defino si el pictbx tiene la imagen X entonces lo guarda en la variable "Caja 7"
        Else 'sino
            PictureBox7.Image = My.Resources.O2 ' el P2 comienza y empieza moviendo
            turno = True ' su turno comienza
            c7 = 2 'defino si el pictbx tiene la imagen O entonces lo guarda en la variable "Caja 7"
        End If
        contador = contador + 1 'restamos una jugada posible
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
    End Sub

    Private Sub PictureBox8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox8.Click
        If turno = True Then ' si el turno es verdadero comienza a jugar el p1
            PictureBox8.Image = My.Resources.X ' Definimos que el primer movimiento sera en el medio 
            turno = False ' el turno se anula
            c8 = 1 'defino si el pictbx tiene la imagen X entonces lo guarda en la variable "Caja 8"
        Else 'sino
            PictureBox8.Image = My.Resources.O2 ' el P2 comienza y empieza moviendo
            turno = True ' su turno comienza
            c8 = 2 'defino si el pictbx tiene la imagen O entonces lo guarda en la variable "Caja 8"
        End If
        contador = contador + 1
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
    End Sub

    Private Sub PictureBox9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox9.Click
        If turno = True Then ' si el turno es verdadero comienza a jugar el p1
            PictureBox9.Image = My.Resources.X ' Definimos que el primer movimiento sera en el medio 
            turno = False ' el turno se anula
            c9 = 1 'defino si el pictbx tiene la imagen X entonces lo guarda en la variable "Caja 9"
        Else 'sino
            PictureBox9.Image = My.Resources.O2 ' el P2 comienza y empieza moviendo
            turno = True ' su turno comienza
            c9 = 2 'defino si el pictbx tiene la imagen O entonces lo guarda en la variable "Caja 9"
        End If
        contador = contador + 1
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
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Me.Visible = False
        'TAPITA.Visible = True
        ' Cierra el formulario actual
        Me.Close()

        ' Crea una nueva instancia del formulario y lo muestra
        Dim nuevoFormulario As New TAPITAvs1()
        nuevoFormulario.Show()

    End Sub

    Private Sub TAPITAvs1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'ToolTip.SetToolTip(button1,"Reiniciar la partida 
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
        TAPITA.Visible = True
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class