<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.cmbPort = New System.Windows.Forms.ComboBox()
        Me.btnconectar = New System.Windows.Forms.Button()
        Me.btndesconectar = New System.Windows.Forms.Button()
        Me.txtrecibe = New System.Windows.Forms.TextBox()
        Me.txtenvia = New System.Windows.Forms.TextBox()
        Me.btnenviar = New System.Windows.Forms.Button()
        Me.lblestado = New System.Windows.Forms.Label()
        Me.sppuerto = New System.IO.Ports.SerialPort(Me.components)
        Me.SuspendLayout()
        '
        'cmbPort
        '
        Me.cmbPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPort.FormattingEnabled = True
        Me.cmbPort.Location = New System.Drawing.Point(12, 12)
        Me.cmbPort.Name = "cmbPort"
        Me.cmbPort.Size = New System.Drawing.Size(121, 21)
        Me.cmbPort.TabIndex = 0
        '
        'btnconectar
        '
        Me.btnconectar.Location = New System.Drawing.Point(176, 10)
        Me.btnconectar.Name = "btnconectar"
        Me.btnconectar.Size = New System.Drawing.Size(75, 23)
        Me.btnconectar.TabIndex = 1
        Me.btnconectar.Text = "CONECTAR"
        Me.btnconectar.UseVisualStyleBackColor = True
        '
        'btndesconectar
        '
        Me.btndesconectar.Location = New System.Drawing.Point(279, 10)
        Me.btndesconectar.Name = "btndesconectar"
        Me.btndesconectar.Size = New System.Drawing.Size(114, 23)
        Me.btndesconectar.TabIndex = 2
        Me.btndesconectar.Text = "DESCONECTAR"
        Me.btndesconectar.UseVisualStyleBackColor = True
        '
        'txtrecibe
        '
        Me.txtrecibe.Location = New System.Drawing.Point(12, 52)
        Me.txtrecibe.Multiline = True
        Me.txtrecibe.Name = "txtrecibe"
        Me.txtrecibe.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtrecibe.Size = New System.Drawing.Size(381, 113)
        Me.txtrecibe.TabIndex = 3
        '
        'txtenvia
        '
        Me.txtenvia.Location = New System.Drawing.Point(12, 196)
        Me.txtenvia.Multiline = True
        Me.txtenvia.Name = "txtenvia"
        Me.txtenvia.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtenvia.Size = New System.Drawing.Size(276, 38)
        Me.txtenvia.TabIndex = 4
        '
        'btnenviar
        '
        Me.btnenviar.Location = New System.Drawing.Point(297, 196)
        Me.btnenviar.Name = "btnenviar"
        Me.btnenviar.Size = New System.Drawing.Size(75, 38)
        Me.btnenviar.TabIndex = 5
        Me.btnenviar.Text = "ENVIAR"
        Me.btnenviar.UseVisualStyleBackColor = True
        '
        'lblestado
        '
        Me.lblestado.AutoSize = True
        Me.lblestado.Location = New System.Drawing.Point(12, 168)
        Me.lblestado.Name = "lblestado"
        Me.lblestado.Size = New System.Drawing.Size(39, 13)
        Me.lblestado.TabIndex = 6
        Me.lblestado.Text = "Label1"
        '
        'sppuerto
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(416, 251)
        Me.Controls.Add(Me.lblestado)
        Me.Controls.Add(Me.btnenviar)
        Me.Controls.Add(Me.txtenvia)
        Me.Controls.Add(Me.txtrecibe)
        Me.Controls.Add(Me.btndesconectar)
        Me.Controls.Add(Me.btnconectar)
        Me.Controls.Add(Me.cmbPort)
        Me.Name = "Form1"
        Me.Text = "LEER PUERTO"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbPort As System.Windows.Forms.ComboBox
    Friend WithEvents btnconectar As System.Windows.Forms.Button
    Friend WithEvents btndesconectar As System.Windows.Forms.Button
    Friend WithEvents txtrecibe As System.Windows.Forms.TextBox
    Friend WithEvents txtenvia As System.Windows.Forms.TextBox
    Friend WithEvents btnenviar As System.Windows.Forms.Button
    Friend WithEvents lblestado As System.Windows.Forms.Label
    Friend WithEvents sppuerto As System.IO.Ports.SerialPort

End Class
