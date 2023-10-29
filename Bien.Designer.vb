<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bien
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
        Me.gb1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pic1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.gb1.SuspendLayout()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gb1
        '
        Me.gb1.Controls.Add(Me.pic1)
        Me.gb1.Controls.Add(Me.Label3)
        Me.gb1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb1.Location = New System.Drawing.Point(12, 12)
        Me.gb1.Name = "gb1"
        Me.gb1.Size = New System.Drawing.Size(305, 238)
        Me.gb1.TabIndex = 10
        Me.gb1.TabStop = False
        Me.gb1.Text = "Hải Hành"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(62, 212)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(164, 23)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Giá: 12.000.000&Đ"
        '
        'pic1
        '
        Me.pic1.BackgroundImage = Global.trienlamtranh.My.Resources.Resources._20230918_130150_300x226
        Me.pic1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pic1.Location = New System.Drawing.Point(20, 36)
        Me.pic1.Name = "pic1"
        Me.pic1.Size = New System.Drawing.Size(267, 158)
        Me.pic1.TabIndex = 6
        Me.pic1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(104, 256)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(115, 37)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Mua"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Bien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(333, 298)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.gb1)
        Me.Name = "Bien"
        Me.Text = "Bien"
        Me.gb1.ResumeLayout(False)
        Me.gb1.PerformLayout()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gb1 As GroupBox
    Friend WithEvents pic1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
End Class
