﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CONTACTO_IMPRONTO
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CONTACTO_IMPRONTO))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BTNACEPTAR = New System.Windows.Forms.Button()
        Me.BTNSALIR = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.DGVGENERAL = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXTTOTAL = New System.Windows.Forms.TextBox()
        Me.LBTIPO = New System.Windows.Forms.Label()
        Me.LBNACIONALIDAD = New System.Windows.Forms.Label()
        Me.LBIDENTIDAD = New System.Windows.Forms.Label()
        Me.LBPACIENTE = New System.Windows.Forms.Label()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVGENERAL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTNACEPTAR
        '
        Me.BTNACEPTAR.BackColor = System.Drawing.Color.Silver
        Me.BTNACEPTAR.BackgroundImage = CType(resources.GetObject("BTNACEPTAR.BackgroundImage"), System.Drawing.Image)
        Me.BTNACEPTAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNACEPTAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNACEPTAR.Location = New System.Drawing.Point(421, 533)
        Me.BTNACEPTAR.Name = "BTNACEPTAR"
        Me.BTNACEPTAR.Size = New System.Drawing.Size(56, 56)
        Me.BTNACEPTAR.TabIndex = 118
        Me.BTNACEPTAR.UseVisualStyleBackColor = False
        '
        'BTNSALIR
        '
        Me.BTNSALIR.BackColor = System.Drawing.Color.Silver
        Me.BTNSALIR.BackgroundImage = CType(resources.GetObject("BTNSALIR.BackgroundImage"), System.Drawing.Image)
        Me.BTNSALIR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTNSALIR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNSALIR.Location = New System.Drawing.Point(492, 533)
        Me.BTNSALIR.Name = "BTNSALIR"
        Me.BTNSALIR.Size = New System.Drawing.Size(56, 56)
        Me.BTNSALIR.TabIndex = 117
        Me.BTNSALIR.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(356, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(468, 25)
        Me.Label4.TabIndex = 110
        Me.Label4.Text = "BUSQUEDA DE CONTACTO PARA IMPRONTO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(388, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(393, 25)
        Me.Label3.TabIndex = 108
        Me.Label3.Text = "SISTEMA DE ADMISION EMERGENCIA"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(994, 2)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(90, 86)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 105
        Me.PictureBox4.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(8, 5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(233, 85)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 103
        Me.PictureBox2.TabStop = False
        '
        'DGVGENERAL
        '
        Me.DGVGENERAL.AllowUserToAddRows = False
        Me.DGVGENERAL.AllowUserToResizeColumns = False
        Me.DGVGENERAL.AllowUserToResizeRows = False
        Me.DGVGENERAL.BackgroundColor = System.Drawing.Color.Silver
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVGENERAL.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVGENERAL.ColumnHeadersHeight = 30
        Me.DGVGENERAL.Location = New System.Drawing.Point(12, 142)
        Me.DGVGENERAL.MultiSelect = False
        Me.DGVGENERAL.Name = "DGVGENERAL"
        Me.DGVGENERAL.ReadOnly = True
        Me.DGVGENERAL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVGENERAL.Size = New System.Drawing.Size(1069, 385)
        Me.DGVGENERAL.TabIndex = 122
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 546)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 124
        Me.Label5.Text = "TOTAL ITEMS"
        '
        'TXTTOTAL
        '
        Me.TXTTOTAL.BackColor = System.Drawing.Color.White
        Me.TXTTOTAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTTOTAL.Location = New System.Drawing.Point(96, 539)
        Me.TXTTOTAL.Name = "TXTTOTAL"
        Me.TXTTOTAL.ReadOnly = True
        Me.TXTTOTAL.Size = New System.Drawing.Size(118, 24)
        Me.TXTTOTAL.TabIndex = 123
        Me.TXTTOTAL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LBTIPO
        '
        Me.LBTIPO.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBTIPO.ForeColor = System.Drawing.Color.Blue
        Me.LBTIPO.Location = New System.Drawing.Point(156, 112)
        Me.LBTIPO.Name = "LBTIPO"
        Me.LBTIPO.Size = New System.Drawing.Size(178, 25)
        Me.LBTIPO.TabIndex = 128
        Me.LBTIPO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LBTIPO.Visible = False
        '
        'LBNACIONALIDAD
        '
        Me.LBNACIONALIDAD.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBNACIONALIDAD.ForeColor = System.Drawing.Color.Black
        Me.LBNACIONALIDAD.Location = New System.Drawing.Point(340, 114)
        Me.LBNACIONALIDAD.Name = "LBNACIONALIDAD"
        Me.LBNACIONALIDAD.Size = New System.Drawing.Size(494, 25)
        Me.LBNACIONALIDAD.TabIndex = 127
        Me.LBNACIONALIDAD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LBIDENTIDAD
        '
        Me.LBIDENTIDAD.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBIDENTIDAD.ForeColor = System.Drawing.Color.Black
        Me.LBIDENTIDAD.Location = New System.Drawing.Point(340, 89)
        Me.LBIDENTIDAD.Name = "LBIDENTIDAD"
        Me.LBIDENTIDAD.Size = New System.Drawing.Size(494, 25)
        Me.LBIDENTIDAD.TabIndex = 126
        Me.LBIDENTIDAD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LBPACIENTE
        '
        Me.LBPACIENTE.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBPACIENTE.ForeColor = System.Drawing.Color.Black
        Me.LBPACIENTE.Location = New System.Drawing.Point(340, 64)
        Me.LBPACIENTE.Name = "LBPACIENTE"
        Me.LBPACIENTE.Size = New System.Drawing.Size(494, 25)
        Me.LBPACIENTE.TabIndex = 125
        Me.LBPACIENTE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CONTACTO_IMPRONTO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(1093, 592)
        Me.ControlBox = False
        Me.Controls.Add(Me.LBTIPO)
        Me.Controls.Add(Me.LBNACIONALIDAD)
        Me.Controls.Add(Me.LBIDENTIDAD)
        Me.Controls.Add(Me.LBPACIENTE)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TXTTOTAL)
        Me.Controls.Add(Me.DGVGENERAL)
        Me.Controls.Add(Me.BTNACEPTAR)
        Me.Controls.Add(Me.BTNSALIR)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CONTACTO_IMPRONTO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CONTACTO_IMPRONTO"
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVGENERAL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BTNACEPTAR As System.Windows.Forms.Button
    Friend WithEvents BTNSALIR As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents DGVGENERAL As System.Windows.Forms.DataGridView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TXTTOTAL As System.Windows.Forms.TextBox
    Friend WithEvents LBTIPO As System.Windows.Forms.Label
    Friend WithEvents LBNACIONALIDAD As System.Windows.Forms.Label
    Friend WithEvents LBIDENTIDAD As System.Windows.Forms.Label
    Friend WithEvents LBPACIENTE As System.Windows.Forms.Label
End Class