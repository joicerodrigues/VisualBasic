<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.pic4 = New System.Windows.Forms.PictureBox()
        Me.pic3 = New System.Windows.Forms.PictureBox()
        Me.pic2 = New System.Windows.Forms.PictureBox()
        Me.pic1 = New System.Windows.Forms.PictureBox()
        CType(Me.pic4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 50
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(193, 453)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "sair"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'pic4
        '
        Me.pic4.Image = Global.atividade.My.Resources.Resources.kisspng_character_television_show_image_cartoon_portable_n_5d38e2d5e3a896_5179803015640091739325
        Me.pic4.Location = New System.Drawing.Point(258, 244)
        Me.pic4.Name = "pic4"
        Me.pic4.Size = New System.Drawing.Size(195, 194)
        Me.pic4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic4.TabIndex = 3
        Me.pic4.TabStop = False
        Me.pic4.Visible = False
        '
        'pic3
        '
        Me.pic3.Image = Global.atividade.My.Resources.Resources.kisspng_desktop_wallpaper_image_clip_art_portable_network_phineas_5b63423cab2e71_6107907515332316767012
        Me.pic3.Location = New System.Drawing.Point(12, 244)
        Me.pic3.Name = "pic3"
        Me.pic3.Size = New System.Drawing.Size(195, 194)
        Me.pic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic3.TabIndex = 2
        Me.pic3.TabStop = False
        Me.pic3.Visible = False
        '
        'pic2
        '
        Me.pic2.Image = Global.atividade.My.Resources.Resources.kisspng_desktop_wallpaper_image_television_show_pocoyo_dan_pocoyo2_mega_idea_5d1cd1a50cc0d4_8002944115621697650523
        Me.pic2.Location = New System.Drawing.Point(258, 35)
        Me.pic2.Name = "pic2"
        Me.pic2.Size = New System.Drawing.Size(195, 194)
        Me.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic2.TabIndex = 1
        Me.pic2.TabStop = False
        Me.pic2.Visible = False
        '
        'pic1
        '
        Me.pic1.Image = Global.atividade.My.Resources.Resources.kisspng_animation_cartoon_3d_computer_graphics_desktop_wal_pocoyo_5ac4565f5ba0a3_7792217015228166073753
        Me.pic1.Location = New System.Drawing.Point(12, 35)
        Me.pic1.Name = "pic1"
        Me.pic1.Size = New System.Drawing.Size(195, 194)
        Me.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic1.TabIndex = 0
        Me.pic1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(476, 488)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.pic4)
        Me.Controls.Add(Me.pic3)
        Me.Controls.Add(Me.pic2)
        Me.Controls.Add(Me.pic1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.pic4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pic1 As System.Windows.Forms.PictureBox
    Friend WithEvents pic2 As System.Windows.Forms.PictureBox
    Friend WithEvents pic3 As System.Windows.Forms.PictureBox
    Friend WithEvents pic4 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
