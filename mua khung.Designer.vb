<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mua_khung
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
        Me.picc1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.gb1.SuspendLayout()
        CType(Me.picc1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gb1
        '
        Me.gb1.Controls.Add(Me.picc1)
        Me.gb1.Controls.Add(Me.Label3)
        Me.gb1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb1.Location = New System.Drawing.Point(25, 12)
        Me.gb1.Name = "gb1"
        Me.gb1.Size = New System.Drawing.Size(267, 160)
        Me.gb1.TabIndex = 8
        Me.gb1.TabStop = False
        Me.gb1.Text = "Khung tranh màu nâu bề mặt phẳng mịn"
        '
        'picc1
        '
        Me.picc1.BackgroundImage = Global.trienlamtranh.My.Resources.Resources.khung_tranh_mau_nau_be_mat_phang_min_don_gian_va_dep_300x142
        Me.picc1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picc1.Location = New System.Drawing.Point(42, 24)
        Me.picc1.Name = "picc1"
        Me.picc1.Size = New System.Drawing.Size(187, 92)
        Me.picc1.TabIndex = 6
        Me.picc1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(68, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 23)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Giá: 300.000&Đ"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(117, 204)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Mua"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'mua_khung
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(311, 251)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.gb1)
        Me.Name = "mua_khung"
        Me.Text = "mua_khung"
        Me.gb1.ResumeLayout(False)
        Me.gb1.PerformLayout()
        CType(Me.picc1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gb1 As GroupBox
    Friend WithEvents picc1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
End Class
