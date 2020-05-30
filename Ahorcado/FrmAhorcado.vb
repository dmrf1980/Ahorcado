Public Class FrmAhorcado

    Public laPalabra As String
    Dim errores As Integer = 0

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

        Dim letraPresionada As String = e.KeyChar.ToString.ToUpper

        Dim cantDeLetras As Integer = laPalabra.Length - 1

        numDeCaracter.Text = posicion.ToString + 1
        Label6.Text = laPalabra

        If LbLUsadas.Text.Contains(e.KeyChar.ToString.ToUpper) Then
            MsgBox("Letra repetida!", vbCritical)
        Else
            LbLUsadas.Text += e.KeyChar.ToString.ToUpper

            If laPalabra.Contains(e.KeyChar.ToString.ToUpper) Then
                'esta
                'hay que programar

                Label5.Text = LblPalabra.Text.Insert(posicion, letraPresionada)

                'Dim laPalabraArray As String
                'laPalabraArray = LblPalabra.Text
                'laPalabraArray.ToArray()
                Do
                    For l As Integer = 0 To laPalabra.Length - 1
                        If LblPalabra.Text(l) = "-" Then
                            LblPalabra.Text = LblPalabra.Text.Remove(posicion, 1)
                            LblPalabra.Text = LblPalabra.Text.Insert(posicion, letraPresionada)
                        End If

                    Next
                Loop Until LblPalabra.Text <> "-"


                'debe mostrar la letra ingresada en todas las posiciones en la que aparezca la palabra

                'si acerto la palabra debe preguntar si desea jugar de nuevo

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