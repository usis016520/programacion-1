<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblRespuestaRomano = New System.Windows.Forms.Label()
        Me.txtnumero = New System.Windows.Forms.TextBox()
        Me.lblnumero = New System.Windows.Forms.Label()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblRespuestaRomano
        '
        Me.lblRespuestaRomano.AutoSize = True
        Me.lblRespuestaRomano.Location = New System.Drawing.Point(346, 94)
        Me.lblRespuestaRomano.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRespuestaRomano.Name = "lblRespuestaRomano"
        Me.lblRespuestaRomano.Size = New System.Drawing.Size(131, 17)
        Me.lblRespuestaRomano.TabIndex = 11
        Me.lblRespuestaRomano.Text = "Numero Romano: ?"
        '
        'txtnumero
        '
        Me.txtnumero.Location = New System.Drawing.Point(202, 90)
        Me.txtnumero.Margin = New System.Windows.Forms.Padding(4)
        Me.txtnumero.Name = "txtnumero"
        Me.txtnumero.Size = New System.Drawing.Size(135, 22)
        Me.txtnumero.TabIndex = 10
        '
        'lblnumero
        '
        Me.lblnumero.AutoSize = True
        Me.lblnumero.Location = New System.Drawing.Point(142, 94)
        Me.lblnumero.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblnumero.Name = "lblnumero"
        Me.lblnumero.Size = New System.Drawing.Size(55, 17)
        Me.lblnumero.TabIndex = 9
        Me.lblnumero.Text = "Capital:"
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(172, 175)
        Me.btnCalcular.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(197, 58)
        Me.btnCalcular.TabIndex = 8
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(619, 322)
        Me.Controls.Add(Me.lblRespuestaRomano)
        Me.Controls.Add(Me.txtnumero)
        Me.Controls.Add(Me.lblnumero)
        Me.Controls.Add(Me.btnCalcular)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Calculadora Basica"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblRespuestaRomano As Label
    Friend WithEvents txtnumero As TextBox
    Friend WithEvents lblnumero As Label
    Friend WithEvents btnCalcular As Button
End Class
