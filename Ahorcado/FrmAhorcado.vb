Public Class FrmAhorcado

    Public laPalabra As String
    Dim errores As Integer = 0

    'Hice el evento "FormClosed" porque el depurador a veces no se cierra con el boton de la ventana y
    'me genera errores de compilacion cuando lo vuelvo a ejecutar
    'de esta manera me aseguro de que lo haga
    Private Sub FrmAhorcado_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub

    Private Sub FrmAhorcado_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        LbLUsadas.Text = ""
        LblPalabra.Text = ""

        laPalabra = laPalabra.ToUpper

        For i As Integer = 0 To laPalabra.Length - 1
            If laPalabra(i) = "" Then
                LblPalabra.Text += "/"
            Else
                LblPalabra.Text += "-"
            End If
        Next

    End Sub

    Private Function NoEsta() As Boolean
        Dim perdio As Boolean
        Select Case errores
            Case 1
                Lbl_1.Visible = True
            Case 2
                Lbl_2.Visible = True
            Case 3
                Lbl_3.Visible = True
            Case 4
                Lbl_4.Visible = True
            Case 5
                Lbl_5.Visible = True
            Case 6
                Lbl_6.Visible = True
                perdio = True
        End Select
        NoEsta = perdio
    End Function

    Private Sub FrmAhorcado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        Dim letraPresionada As Char = e.KeyChar.ToString.ToUpper
        Dim laPalabraNueva As String = ""

        If LbLUsadas.Text.Contains(letraPresionada) Then

            MsgBox("Letra repetida!", vbCritical)
        Else
            LbLUsadas.Text += letraPresionada


            If laPalabra.Contains(letraPresionada) Then
                'esta
                'hay que programar

                For i As Integer = 0 To laPalabra.Length - 1
                    If laPalabra(i) = letraPresionada Then
                        laPalabraNueva += letraPresionada
                    Else
                        laPalabraNueva += LblPalabra.Text(i)
                    End If
                Next
                LblPalabra.Text = laPalabraNueva

                'debe mostrar la letra ingresada en todas las posiciones en la que aparezca la palabra
                If laPalabra = laPalabraNueva.Replace("/", "") Then

                    'si acerto la palabra debe preguntar si desea jugar de nuevo
                    If MsgBox("Acertaste!! Quieres jugar de nuevo?", vbYesNo) = MsgBoxResult.Yes Then
                        Application.Restart()
                    Else
                        Application.Exit()
                    End If
                End If
            Else
                'no esta
                errores += 1
                If NoEsta() Then
                    If MsgBox("Has perdido!! Quieres jugar de nuevo?", vbYesNo) = MsgBoxResult.Yes Then
                        Application.Restart()
                    Else
                        Application.Exit()
                    End If
                End If
            End If
        End If
    End Sub

End Class