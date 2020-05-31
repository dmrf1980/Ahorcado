Public Class Form1

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click

        If TxtPalabra.TextLength = 0 Then
            MsgBox("Ingrese la palabra secreta!", vbCritical)
            TxtPalabra.Focus()
        Else
            FrmAhorcado.laPalabra = TxtPalabra.Text
            FrmAhorcado.Show()
            Me.Hide()
        End If

    End Sub


End Class