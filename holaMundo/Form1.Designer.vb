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
        Me.btnCajero = New System.Windows.Forms.Button()
        Me.btnPrimo = New System.Windows.Forms.Button()
        Me.lblnum = New System.Windows.Forms.Label()
        Me.txtnum = New System.Windows.Forms.TextBox()
        Me.btnParImpar = New System.Windows.Forms.Button()
        Me.lstEjercicios = New System.Windows.Forms.ListBox()
        Me.btnProcesar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCajero
        '
        Me.btnCajero.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCajero.Location = New System.Drawing.Point(386, 219)
        Me.btnCajero.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCajero.Name = "btnCajero"
        Me.btnCajero.Size = New System.Drawing.Size(113, 62)
        Me.btnCajero.TabIndex = 13
        Me.btnCajero.Text = "Cajero"
        Me.btnCajero.UseVisualStyleBackColor = True
        '
        'btnPrimo
        '
        Me.btnPrimo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrimo.Location = New System.Drawing.Point(264, 219)
        Me.btnPrimo.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPrimo.Name = "btnPrimo"
        Me.btnPrimo.Size = New System.Drawing.Size(113, 62)
        Me.btnPrimo.TabIndex = 12
        Me.btnPrimo.Text = "Primo?"
        Me.btnPrimo.UseVisualStyleBackColor = True
        '
        'lblnum
        '
        Me.lblnum.AutoSize = True
        Me.lblnum.Location = New System.Drawing.Point(202, 111)
        Me.lblnum.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblnum.Name = "lblnum"
        Me.lblnum.Size = New System.Drawing.Size(62, 17)
        Me.lblnum.TabIndex = 11
        Me.lblnum.Text = "Numero:"
        '
        'txtnum
        '
        Me.txtnum.Location = New System.Drawing.Point(272, 107)
        Me.txtnum.Margin = New System.Windows.Forms.Padding(4)
        Me.txtnum.Name = "txtnum"
        Me.txtnum.Size = New System.Drawing.Size(104, 22)
        Me.txtnum.TabIndex = 10
        '
        'btnParImpar
        '
        Me.btnParImpar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnParImpar.Location = New System.Drawing.Point(164, 219)
        Me.btnParImpar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnParImpar.Name = "btnParImpar"
        Me.btnParImpar.Size = New System.Drawing.Size(100, 62)
        Me.btnParImpar.TabIndex = 9
        Me.btnParImpar.Text = "Par o Impar?"
        Me.btnParImpar.UseVisualStyleBackColor = True
        '
        'lstEjercicios
        '
        Me.lstEjercicios.FormattingEnabled = True
        Me.lstEjercicios.ItemHeight = 16
        Me.lstEjercicios.Location = New System.Drawing.Point(507, 36)
        Me.lstEjercicios.Margin = New System.Windows.Forms.Padding(4)
        Me.lstEjercicios.Name = "lstEjercicios"
        Me.lstEjercicios.Size = New System.Drawing.Size(223, 244)
        Me.lstEjercicios.TabIndex = 8
        '
        'btnProcesar
        '
        Me.btnProcesar.Location = New System.Drawing.Point(507, 288)
        Me.btnProcesar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(224, 54)
        Me.btnProcesar.TabIndex = 7
        Me.btnProcesar.Text = "Mostrar Pares e impares"
        Me.btnProcesar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(894, 379)
        Me.Controls.Add(Me.btnCajero)
        Me.Controls.Add(Me.btnPrimo)
        Me.Controls.Add(Me.lblnum)
        Me.Controls.Add(Me.txtnum)
        Me.Controls.Add(Me.btnParImpar)
        Me.Controls.Add(Me.lstEjercicios)
        Me.Controls.Add(Me.btnProcesar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Calculadora Basica"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCajero As Button
    Friend WithEvents btnPrimo As Button
    Friend WithEvents lblnum As Label
    Friend WithEvents txtnum As TextBox
    Friend WithEvents btnParImpar As Button
    Friend WithEvents lstEjercicios As ListBox
    Friend WithEvents btnProcesar As Button
End Class
