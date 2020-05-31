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

        Dim i As Integer

        LbLUsadas.Text = ""
        LblPalabra.Text = ""

        laPalabra = laPalabra.ToUpper

        For i = 0 To laPalabra.Length - 1
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
        'posicion=Numero de la lerta que coincide en "laPalabra"
        Dim posicion As Integer = Integer.Parse(laPalabra.IndexOf(e.KeyChar.ToString.ToUpper))
        Dim posicionLP As Integer = Integer.Parse(LblPalabra.Text.IndexOf(LblPalabra.Text)) '*****************
        Dim letraPresionada As String = e.KeyChar.ToString.ToUpper
        Dim cantDeLetras As Integer = laPalabra.Length - 1
        Dim aciertos As Integer

        'numDeCaracter.Text = posicion.ToString + 1 '#BORRAR**********************************
        Label6.Text = laPalabra '#BORRAR****************************************************

        If LbLUsadas.Text.Contains(e.KeyChar.ToString.ToUpper) Then

            MsgBox("Letra repetida!", vbCritical)
        Else
            LbLUsadas.Text += e.KeyChar.ToString.ToUpper


            If laPalabra.Contains(e.KeyChar.ToString.ToUpper) Then
                'esta
                aciertos += 1
                'hay que programar
                Label5.Text = LblPalabra.Text.Remove(posicion, 1).Insert(posicion, letraPresionada) '#BORRAR********************


                For l As Integer = 0 To laPalabra.Length - 1

                    If LblPalabra.Text(l) = "-" Then
                        LblPalabra.Text = LblPalabra.Text.Remove(posicion, 1).Insert(posicion, letraPresionada)
                        'LblPalabra.Text = LblPalabra.Text.Insert(posicion, letraPresionada)
                    End If

                Next

                'debe mostrar la letra ingresada en todas las posiciones en la que aparezca la palabra
                'si acerto la palabra debe preguntar si desea jugar de nuevo
                'If aciertos > cantDeLetras Then
                'MsgBox("Gano!!!")
                'End If
            Else
                'no esta
                errores += 1
                If NoEsta() Then
                    If MsgBox("Has perdido! Quieres jugar de nuevo?", vbYesNo) = MsgBoxResult.Yes Then
                        Application.Restart()
                    Else
                        Application.Exit()
                    End If
                End If
            End If

        End If
    End Sub

End Class