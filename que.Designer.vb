<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class que
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
        Me.gb1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pic1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.gb1.SuspendLayout()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gb1
        '
        Me.gb1.Controls.Add(Me.Label2)
        Me.gb1.Controls.Add(Me.Label6)
        Me.gb1.Controls.Add(Me.pic1)
        Me.gb1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb1.Location = New System.Drawing.Point(12, 12)
        Me.gb1.Name = "gb1"
        Me.gb1.Size = New System.Drawing.Size(275, 179)
        Me.gb1.TabIndex = 11
        Me.gb1.TabStop = False
        Me.gb1.Text = "Quê Hương"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(105, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 17)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Đã Bán"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(61, 129)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(153, 23)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Giá: 7.000.000&Đ"
        '
        'pic1
        '
        Me.pic1.BackgroundImage = Global.trienlamtranh.My.Resources.Resources._04BBB655_0B28_47CF_8DD2_8F785BEB7C68_1_300x226
        Me.pic1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pic1.Location = New System.Drawing.Point(31, 24)
        Me.pic1.Name = "pic1"
        Me.pic1.Size = New System.Drawing.Size(222, 102)
        Me.pic1.TabIndex = 6
        Me.pic1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(93, 197)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(115, 37)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Mua"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'que
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(313, 251)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.gb1)
        Me.Name = "que"
        Me.Text = "que"
        Me.gb1.ResumeLayout(False)
        Me.gb1.PerformLayout()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gb1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents pic1 As PictureBox
    Friend WithEvents Button1 As Button
End Class
