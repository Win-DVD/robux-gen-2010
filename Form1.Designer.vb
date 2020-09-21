<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.Sto = New System.Windows.Forms.Button()
        Me.Play = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Sto
        '
        Me.Sto.Location = New System.Drawing.Point(588, 41)
        Me.Sto.Name = "Sto"
        Me.Sto.Size = New System.Drawing.Size(37, 23)
        Me.Sto.TabIndex = 0
        Me.Sto.Text = "Stop"
        Me.Sto.UseVisualStyleBackColor = True
        '
        'Play
        '
        Me.Play.Location = New System.Drawing.Point(589, 12)
        Me.Play.Name = "Play"
        Me.Play.Size = New System.Drawing.Size(36, 23)
        Me.Play.TabIndex = 1
        Me.Play.Text = "Play"
        Me.Play.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(564, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Audio Settings"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 510)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(613, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Generate Robux"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 481)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(613, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Bobux Stealer 1.0"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(637, 545)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Play)
        Me.Controls.Add(Me.Sto)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Main"
        Me.Text = "Robux Generator 2010 1.1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Sto As System.Windows.Forms.Button
    Friend WithEvents Play As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button

End Class
