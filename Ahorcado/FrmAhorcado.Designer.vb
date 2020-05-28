<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAhorcado
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LbLUsadas = New System.Windows.Forms.Label()
        Me.LblPalabra = New System.Windows.Forms.Label()
        Me.Lbl_1 = New System.Windows.Forms.Label()
        Me.Lbl_3 = New System.Windows.Forms.Label()
        Me.Lbl_2 = New System.Windows.Forms.Label()
        Me.Lbl_4 = New System.Windows.Forms.Label()
        Me.Lbl_5 = New System.Windows.Forms.Label()
        Me.Lbl_6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LbLUsadas
        '
        Me.LbLUsadas.AutoSize = True
        Me.LbLUsadas.Font = New System.Drawing.Font("MS PGothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbLUsadas.Location = New System.Drawing.Point(361, 21)
        Me.LbLUsadas.Name = "LbLUsadas"
        Me.LbLUsadas.Size = New System.Drawing.Size(110, 24)
        Me.LbLUsadas.TabIndex = 0
        Me.LbLUsadas.Text = "Aca arriba"
        Me.LbLUsadas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblPalabra
        '
        Me.LblPalabra.AutoSize = True
        Me.LblPalabra.Font = New System.Drawing.Font("MS PGothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPalabra.Location = New System.Drawing.Point(363, 371)
        Me.LblPalabra.Name = "LblPalabra"
        Me.LblPalabra.Size = New System.Drawing.Size(106, 24)
        Me.LblPalabra.TabIndex = 0
        Me.LblPalabra.Text = "Aca abajo"
        Me.LblPalabra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_1
        '
        Me.Lbl_1.AutoSize = True
        Me.Lbl_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_1.Location = New System.Drawing.Point(154, 57)
        Me.Lbl_1.Name = "Lbl_1"
        Me.Lbl_1.Size = New System.Drawing.Size(99, 108)
        Me.Lbl_1.TabIndex = 1
        Me.Lbl_1.Text = "0"
        Me.Lbl_1.Visible = False
        '
        'Lbl_3
        '
        Me.Lbl_3.AutoSize = True
        Me.Lbl_3.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_3.Location = New System.Drawing.Point(121, 148)
        Me.Lbl_3.Name = "Lbl_3"
        Me.Lbl_3.Size = New System.Drawing.Size(73, 108)
        Me.Lbl_3.TabIndex = 1
        Me.Lbl_3.Text = "/"
        Me.Lbl_3.Visible = False
        '
        'Lbl_2
        '
        Me.Lbl_2.AutoSize = True
        Me.Lbl_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_2.Location = New System.Drawing.Point(167, 147)
        Me.Lbl_2.Name = "Lbl_2"
        Me.Lbl_2.Size = New System.Drawing.Size(71, 108)
        Me.Lbl_2.TabIndex = 1
        Me.Lbl_2.Text = "|"
        Me.Lbl_2.Visible = False
        '
        'Lbl_4
        '
        Me.Lbl_4.AutoSize = True
        Me.Lbl_4.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_4.Location = New System.Drawing.Point(207, 147)
        Me.Lbl_4.Name = "Lbl_4"
        Me.Lbl_4.Size = New System.Drawing.Size(73, 108)
        Me.Lbl_4.TabIndex = 1
        Me.Lbl_4.Text = "\"
        Me.Lbl_4.Visible = False
        '
        'Lbl_5
        '
        Me.Lbl_5.AutoSize = True
        Me.Lbl_5.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_5.Location = New System.Drawing.Point(132, 255)
        Me.Lbl_5.Name = "Lbl_5"
        Me.Lbl_5.Size = New System.Drawing.Size(73, 108)
        Me.Lbl_5.TabIndex = 1
        Me.Lbl_5.Text = "/"
        Me.Lbl_5.Visible = False
        '
        'Lbl_6
        '
        Me.Lbl_6.AutoSize = True
        Me.Lbl_6.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_6.Location = New System.Drawing.Point(201, 255)
        Me.Lbl_6.Name = "Lbl_6"
        Me.Lbl_6.Size = New System.Drawing.Size(73, 108)
        Me.Lbl_6.TabIndex = 1
        Me.Lbl_6.Text = "\"
        Me.Lbl_6.Visible = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(57, 363)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 10)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(74, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(12, 306)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(74, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 10)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Label3"
        '
        'FrmAhorcado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(644, 406)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Lbl_6)
        Me.Controls.Add(Me.Lbl_5)
        Me.Controls.Add(Me.Lbl_4)
        Me.Controls.Add(Me.Lbl_2)
        Me.Controls.Add(Me.Lbl_3)
        Me.Controls.Add(Me.Lbl_1)
        Me.Controls.Add(Me.LblPalabra)
        Me.Controls.Add(Me.LbLUsadas)
        Me.Name = "FrmAhorcado"
        Me.Text = "FrmAhorcado"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LbLUsadas As Label
    Friend WithEvents LblPalabra As Label
    Friend WithEvents Lbl_1 As Label
    Friend WithEvents Lbl_3 As Label
    Friend WithEvents Lbl_2 As Label
    Friend WithEvents Lbl_4 As Label
    Friend WithEvents Lbl_5 As Label
    Friend WithEvents Lbl_6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
