Public Class CustomerForm
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(CustomerForm))
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.AccessibleDescription = resources.GetString("Button1.AccessibleDescription")
        Me.Button1.AccessibleName = resources.GetString("Button1.AccessibleName")
        Me.Button1.Anchor = CType(resources.GetObject("Button1.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.Dock = CType(resources.GetObject("Button1.Dock"), System.Windows.Forms.DockStyle)
        Me.Button1.Enabled = CType(resources.GetObject("Button1.Enabled"), Boolean)
        Me.Button1.FlatStyle = CType(resources.GetObject("Button1.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.Button1.Font = CType(resources.GetObject("Button1.Font"), System.Drawing.Font)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = CType(resources.GetObject("Button1.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Button1.ImageIndex = CType(resources.GetObject("Button1.ImageIndex"), Integer)
        Me.Button1.ImeMode = CType(resources.GetObject("Button1.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Button1.Location = CType(resources.GetObject("Button1.Location"), System.Drawing.Point)
        Me.Button1.Name = "Button1"
        Me.Button1.RightToLeft = CType(resources.GetObject("Button1.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Button1.Size = CType(resources.GetObject("Button1.Size"), System.Drawing.Size)
        Me.Button1.TabIndex = CType(resources.GetObject("Button1.TabIndex"), Integer)
        Me.Button1.Text = resources.GetString("Button1.Text")
        Me.Button1.TextAlign = CType(resources.GetObject("Button1.TextAlign"), System.Drawing.ContentAlignment)
        Me.Button1.Visible = CType(resources.GetObject("Button1.Visible"), Boolean)
        '
        'Button2
        '
        Me.Button2.AccessibleDescription = resources.GetString("Button2.AccessibleDescription")
        Me.Button2.AccessibleName = resources.GetString("Button2.AccessibleName")
        Me.Button2.Anchor = CType(resources.GetObject("Button2.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.Dock = CType(resources.GetObject("Button2.Dock"), System.Windows.Forms.DockStyle)
        Me.Button2.Enabled = CType(resources.GetObject("Button2.Enabled"), Boolean)
        Me.Button2.FlatStyle = CType(resources.GetObject("Button2.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.Button2.Font = CType(resources.GetObject("Button2.Font"), System.Drawing.Font)
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = CType(resources.GetObject("Button2.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Button2.ImageIndex = CType(resources.GetObject("Button2.ImageIndex"), Integer)
        Me.Button2.ImeMode = CType(resources.GetObject("Button2.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Button2.Location = CType(resources.GetObject("Button2.Location"), System.Drawing.Point)
        Me.Button2.Name = "Button2"
        Me.Button2.RightToLeft = CType(resources.GetObject("Button2.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Button2.Size = CType(resources.GetObject("Button2.Size"), System.Drawing.Size)
        Me.Button2.TabIndex = CType(resources.GetObject("Button2.TabIndex"), Integer)
        Me.Button2.Text = resources.GetString("Button2.Text")
        Me.Button2.TextAlign = CType(resources.GetObject("Button2.TextAlign"), System.Drawing.ContentAlignment)
        Me.Button2.Visible = CType(resources.GetObject("Button2.Visible"), Boolean)
        '
        'Button3
        '
        Me.Button3.AccessibleDescription = resources.GetString("Button3.AccessibleDescription")
        Me.Button3.AccessibleName = resources.GetString("Button3.AccessibleName")
        Me.Button3.Anchor = CType(resources.GetObject("Button3.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.Dock = CType(resources.GetObject("Button3.Dock"), System.Windows.Forms.DockStyle)
        Me.Button3.Enabled = CType(resources.GetObject("Button3.Enabled"), Boolean)
        Me.Button3.FlatStyle = CType(resources.GetObject("Button3.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.Button3.Font = CType(resources.GetObject("Button3.Font"), System.Drawing.Font)
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = CType(resources.GetObject("Button3.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Button3.ImageIndex = CType(resources.GetObject("Button3.ImageIndex"), Integer)
        Me.Button3.ImeMode = CType(resources.GetObject("Button3.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Button3.Location = CType(resources.GetObject("Button3.Location"), System.Drawing.Point)
        Me.Button3.Name = "Button3"
        Me.Button3.RightToLeft = CType(resources.GetObject("Button3.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Button3.Size = CType(resources.GetObject("Button3.Size"), System.Drawing.Size)
        Me.Button3.TabIndex = CType(resources.GetObject("Button3.TabIndex"), Integer)
        Me.Button3.Text = resources.GetString("Button3.Text")
        Me.Button3.TextAlign = CType(resources.GetObject("Button3.TextAlign"), System.Drawing.ContentAlignment)
        Me.Button3.Visible = CType(resources.GetObject("Button3.Visible"), Boolean)
        '
        'CustomerForm
        '
        Me.AccessibleDescription = resources.GetString("$this.AccessibleDescription")
        Me.AccessibleName = resources.GetString("$this.AccessibleName")
        Me.AutoScaleBaseSize = CType(resources.GetObject("$this.AutoScaleBaseSize"), System.Drawing.Size)
        Me.AutoScroll = CType(resources.GetObject("$this.AutoScroll"), Boolean)
        Me.AutoScrollMargin = CType(resources.GetObject("$this.AutoScrollMargin"), System.Drawing.Size)
        Me.AutoScrollMinSize = CType(resources.GetObject("$this.AutoScrollMinSize"), System.Drawing.Size)
        Me.BackColor = System.Drawing.SystemColors.ControlText
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = CType(resources.GetObject("$this.ClientSize"), System.Drawing.Size)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Enabled = CType(resources.GetObject("$this.Enabled"), Boolean)
        Me.Font = CType(resources.GetObject("$this.Font"), System.Drawing.Font)
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ImeMode = CType(resources.GetObject("$this.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Location = CType(resources.GetObject("$this.Location"), System.Drawing.Point)
        Me.MaximumSize = CType(resources.GetObject("$this.MaximumSize"), System.Drawing.Size)
        Me.MinimumSize = CType(resources.GetObject("$this.MinimumSize"), System.Drawing.Size)
        Me.Name = "CustomerForm"
        Me.RightToLeft = CType(resources.GetObject("$this.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.StartPosition = CType(resources.GetObject("$this.StartPosition"), System.Windows.Forms.FormStartPosition)
        Me.Text = resources.GetString("$this.Text")
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim feedbackform As New Feedback
        feedbackform.Show()
        Me.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim menuForm As New MenuForm
        menuForm.Show()
        Me.Close()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim optionForm As New OptionForm
        optionForm.Show()
        Me.Close()

    End Sub
End Class
