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
        Me.btnProcesar = New System.Windows.Forms.Button()
        Me.lstTablas = New System.Windows.Forms.ListBox()
        Me.txtntabla = New System.Windows.Forms.TextBox()
        Me.lblntabla = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnProcesar
        '
        Me.btnProcesar.Location = New System.Drawing.Point(49, 175)
        Me.btnProcesar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(187, 76)
        Me.btnProcesar.TabIndex = 7
        Me.btnProcesar.Text = "Generar Tabla"
        Me.btnProcesar.UseVisualStyleBackColor = True
        '
        'lstTablas
        '
        Me.lstTablas.FormattingEnabled = True
        Me.lstTablas.ItemHeight = 16
        Me.lstTablas.Location = New System.Drawing.Point(273, 71)
        Me.lstTablas.Margin = New System.Windows.Forms.Padding(4)
        Me.lstTablas.Name = "lstTablas"
        Me.lstTablas.Size = New System.Drawing.Size(301, 180)
        Me.lstTablas.TabIndex = 6
        '
        'txtntabla
        '
        Me.txtntabla.Location = New System.Drawing.Point(102, 102)
        Me.txtntabla.Margin = New System.Windows.Forms.Padding(4)
        Me.txtntabla.Name = "txtntabla"
        Me.txtntabla.Size = New System.Drawing.Size(132, 22)
        Me.txtntabla.TabIndex = 5
        '
        'lblntabla
        '
        Me.lblntabla.AutoSize = True
        Me.lblntabla.Location = New System.Drawing.Point(45, 105)
        Me.lblntabla.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblntabla.Name = "lblntabla"
        Me.lblntabla.Size = New System.Drawing.Size(48, 17)
        Me.lblntabla.TabIndex = 4
        Me.lblntabla.Text = "Tabla:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(619, 322)
        Me.Controls.Add(Me.btnProcesar)
        Me.Controls.Add(Me.lstTablas)
        Me.Controls.Add(Me.txtntabla)
        Me.Controls.Add(Me.lblntabla)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Calculadora Basica"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnProcesar As Button
    Friend WithEvents lstTablas As ListBox
    Friend WithEvents txtntabla As TextBox
    Friend WithEvents lblntabla As Label
End Class
