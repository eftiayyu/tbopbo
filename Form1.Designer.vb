<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txtKata = New System.Windows.Forms.TextBox()
        Me.txtTerjemahan = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtKata
        '
        Me.txtKata.Location = New System.Drawing.Point(29, 163)
        Me.txtKata.Multiline = True
        Me.txtKata.Name = "txtKata"
        Me.txtKata.Size = New System.Drawing.Size(311, 300)
        Me.txtKata.TabIndex = 0
        '
        'txtTerjemahan
        '
        Me.txtTerjemahan.Location = New System.Drawing.Point(515, 163)
        Me.txtTerjemahan.Multiline = True
        Me.txtTerjemahan.Name = "txtTerjemahan"
        Me.txtTerjemahan.Size = New System.Drawing.Size(311, 300)
        Me.txtTerjemahan.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(29, 129)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(149, 28)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "INDOMANDARIN"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(677, 129)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(149, 28)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "MANDARININDO"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBox1.Font = New System.Drawing.Font("Mongolian Baiti", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextBox1.Location = New System.Drawing.Point(251, 23)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(379, 95)
        Me.TextBox1.TabIndex = 6
        Me.TextBox1.Text = resources.GetString("TextBox1.Text")
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(860, 482)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtTerjemahan)
        Me.Controls.Add(Me.txtKata)
        Me.Name = "Form1"
        Me.Text = "~~ASIK - ABISIN"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtKata As TextBox
    Friend WithEvents txtTerjemahan As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox1 As TextBox
End Class
