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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TxtApellido = New System.Windows.Forms.TextBox()
        Me.TxtDNI = New System.Windows.Forms.TextBox()
        Me.BtnGrabar = New System.Windows.Forms.Button()
        Me.DGVPersonas = New System.Windows.Forms.DataGridView()
        Me.TxtFNacimiento = New System.Windows.Forms.DateTimePicker()
        CType(Me.DGVPersonas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(807, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(807, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Apellido"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(807, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "DNI"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(807, 190)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "FNacimiento"
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(879, 90)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(203, 20)
        Me.TxtNombre.TabIndex = 4
        '
        'TxtApellido
        '
        Me.TxtApellido.Location = New System.Drawing.Point(879, 124)
        Me.TxtApellido.Name = "TxtApellido"
        Me.TxtApellido.Size = New System.Drawing.Size(203, 20)
        Me.TxtApellido.TabIndex = 5
        '
        'TxtDNI
        '
        Me.TxtDNI.Location = New System.Drawing.Point(879, 156)
        Me.TxtDNI.Name = "TxtDNI"
        Me.TxtDNI.Size = New System.Drawing.Size(203, 20)
        Me.TxtDNI.TabIndex = 6
        '
        'BtnGrabar
        '
        Me.BtnGrabar.Location = New System.Drawing.Point(934, 235)
        Me.BtnGrabar.Name = "BtnGrabar"
        Me.BtnGrabar.Size = New System.Drawing.Size(98, 54)
        Me.BtnGrabar.TabIndex = 8
        Me.BtnGrabar.Text = "Grabar"
        Me.BtnGrabar.UseVisualStyleBackColor = True
        '
        'DGVPersonas
        '
        Me.DGVPersonas.AllowUserToAddRows = False
        Me.DGVPersonas.AllowUserToDeleteRows = False
        Me.DGVPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVPersonas.Location = New System.Drawing.Point(33, 37)
        Me.DGVPersonas.Name = "DGVPersonas"
        Me.DGVPersonas.ReadOnly = True
        Me.DGVPersonas.Size = New System.Drawing.Size(702, 578)
        Me.DGVPersonas.TabIndex = 10
        '
        'TxtFNacimiento
        '
        Me.TxtFNacimiento.Location = New System.Drawing.Point(879, 184)
        Me.TxtFNacimiento.Name = "TxtFNacimiento"
        Me.TxtFNacimiento.Size = New System.Drawing.Size(203, 20)
        Me.TxtFNacimiento.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1094, 646)
        Me.Controls.Add(Me.TxtFNacimiento)
        Me.Controls.Add(Me.DGVPersonas)
        Me.Controls.Add(Me.BtnGrabar)
        Me.Controls.Add(Me.TxtDNI)
        Me.Controls.Add(Me.TxtApellido)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DGVPersonas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents TxtApellido As TextBox
    Friend WithEvents TxtDNI As TextBox
    Friend WithEvents BtnGrabar As Button
    Friend WithEvents DGVPersonas As DataGridView
    Friend WithEvents TxtFNacimiento As DateTimePicker
End Class
