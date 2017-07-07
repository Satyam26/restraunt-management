Imports System.Data.SqlClient
Public Class Feedback
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
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Feedback))
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.AccessibleDescription = resources.GetString("TextBox1.AccessibleDescription")
        Me.TextBox1.AccessibleName = resources.GetString("TextBox1.AccessibleName")
        Me.TextBox1.Anchor = CType(resources.GetObject("TextBox1.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.AutoSize = CType(resources.GetObject("TextBox1.AutoSize"), Boolean)
        Me.TextBox1.BackgroundImage = CType(resources.GetObject("TextBox1.BackgroundImage"), System.Drawing.Image)
        Me.TextBox1.Dock = CType(resources.GetObject("TextBox1.Dock"), System.Windows.Forms.DockStyle)
        Me.TextBox1.Enabled = CType(resources.GetObject("TextBox1.Enabled"), Boolean)
        Me.TextBox1.Font = CType(resources.GetObject("TextBox1.Font"), System.Drawing.Font)
        Me.TextBox1.ImeMode = CType(resources.GetObject("TextBox1.ImeMode"), System.Windows.Forms.ImeMode)
        Me.TextBox1.Location = CType(resources.GetObject("TextBox1.Location"), System.Drawing.Point)
        Me.TextBox1.MaxLength = CType(resources.GetObject("TextBox1.MaxLength"), Integer)
        Me.TextBox1.Multiline = CType(resources.GetObject("TextBox1.Multiline"), Boolean)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.PasswordChar = CType(resources.GetObject("TextBox1.PasswordChar"), Char)
        Me.TextBox1.RightToLeft = CType(resources.GetObject("TextBox1.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.TextBox1.ScrollBars = CType(resources.GetObject("TextBox1.ScrollBars"), System.Windows.Forms.ScrollBars)
        Me.TextBox1.Size = CType(resources.GetObject("TextBox1.Size"), System.Drawing.Size)
        Me.TextBox1.TabIndex = CType(resources.GetObject("TextBox1.TabIndex"), Integer)
        Me.TextBox1.Text = resources.GetString("TextBox1.Text")
        Me.TextBox1.TextAlign = CType(resources.GetObject("TextBox1.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.TextBox1.Visible = CType(resources.GetObject("TextBox1.Visible"), Boolean)
        Me.TextBox1.WordWrap = CType(resources.GetObject("TextBox1.WordWrap"), Boolean)
        '
        'Button1
        '
        Me.Button1.AccessibleDescription = resources.GetString("Button1.AccessibleDescription")
        Me.Button1.AccessibleName = resources.GetString("Button1.AccessibleName")
        Me.Button1.Anchor = CType(resources.GetObject("Button1.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(192, Byte), CType(0, Byte))
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.Dock = CType(resources.GetObject("Button1.Dock"), System.Windows.Forms.DockStyle)
        Me.Button1.Enabled = CType(resources.GetObject("Button1.Enabled"), Boolean)
        Me.Button1.FlatStyle = CType(resources.GetObject("Button1.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.Button1.Font = CType(resources.GetObject("Button1.Font"), System.Drawing.Font)
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
        'Label1
        '
        Me.Label1.AccessibleDescription = resources.GetString("Label1.AccessibleDescription")
        Me.Label1.AccessibleName = resources.GetString("Label1.AccessibleName")
        Me.Label1.Anchor = CType(resources.GetObject("Label1.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = CType(resources.GetObject("Label1.AutoSize"), Boolean)
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Dock = CType(resources.GetObject("Label1.Dock"), System.Windows.Forms.DockStyle)
        Me.Label1.Enabled = CType(resources.GetObject("Label1.Enabled"), Boolean)
        Me.Label1.Font = CType(resources.GetObject("Label1.Font"), System.Drawing.Font)
        Me.Label1.ForeColor = System.Drawing.Color.Brown
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.ImageAlign = CType(resources.GetObject("Label1.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label1.ImageIndex = CType(resources.GetObject("Label1.ImageIndex"), Integer)
        Me.Label1.ImeMode = CType(resources.GetObject("Label1.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label1.Location = CType(resources.GetObject("Label1.Location"), System.Drawing.Point)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = CType(resources.GetObject("Label1.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label1.Size = CType(resources.GetObject("Label1.Size"), System.Drawing.Size)
        Me.Label1.TabIndex = CType(resources.GetObject("Label1.TabIndex"), Integer)
        Me.Label1.Text = resources.GetString("Label1.Text")
        Me.Label1.TextAlign = CType(resources.GetObject("Label1.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label1.Visible = CType(resources.GetObject("Label1.Visible"), Boolean)
        '
        'Button2
        '
        Me.Button2.AccessibleDescription = resources.GetString("Button2.AccessibleDescription")
        Me.Button2.AccessibleName = resources.GetString("Button2.AccessibleName")
        Me.Button2.Anchor = CType(resources.GetObject("Button2.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(0, Byte), CType(0, Byte))
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
        'Label2
        '
        Me.Label2.AccessibleDescription = resources.GetString("Label2.AccessibleDescription")
        Me.Label2.AccessibleName = resources.GetString("Label2.AccessibleName")
        Me.Label2.Anchor = CType(resources.GetObject("Label2.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = CType(resources.GetObject("Label2.AutoSize"), Boolean)
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Dock = CType(resources.GetObject("Label2.Dock"), System.Windows.Forms.DockStyle)
        Me.Label2.Enabled = CType(resources.GetObject("Label2.Enabled"), Boolean)
        Me.Label2.Font = CType(resources.GetObject("Label2.Font"), System.Drawing.Font)
        Me.Label2.ForeColor = System.Drawing.Color.Brown
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.ImageAlign = CType(resources.GetObject("Label2.ImageAlign"), System.Drawing.ContentAlignment)
        Me.Label2.ImageIndex = CType(resources.GetObject("Label2.ImageIndex"), Integer)
        Me.Label2.ImeMode = CType(resources.GetObject("Label2.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Label2.Location = CType(resources.GetObject("Label2.Location"), System.Drawing.Point)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = CType(resources.GetObject("Label2.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.Label2.Size = CType(resources.GetObject("Label2.Size"), System.Drawing.Size)
        Me.Label2.TabIndex = CType(resources.GetObject("Label2.TabIndex"), Integer)
        Me.Label2.Text = resources.GetString("Label2.Text")
        Me.Label2.TextAlign = CType(resources.GetObject("Label2.TextAlign"), System.Drawing.ContentAlignment)
        Me.Label2.Visible = CType(resources.GetObject("Label2.Visible"), Boolean)
        '
        'ComboBox1
        '
        Me.ComboBox1.AccessibleDescription = resources.GetString("ComboBox1.AccessibleDescription")
        Me.ComboBox1.AccessibleName = resources.GetString("ComboBox1.AccessibleName")
        Me.ComboBox1.Anchor = CType(resources.GetObject("ComboBox1.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.ComboBox1.BackgroundImage = CType(resources.GetObject("ComboBox1.BackgroundImage"), System.Drawing.Image)
        Me.ComboBox1.Dock = CType(resources.GetObject("ComboBox1.Dock"), System.Windows.Forms.DockStyle)
        Me.ComboBox1.Enabled = CType(resources.GetObject("ComboBox1.Enabled"), Boolean)
        Me.ComboBox1.Font = CType(resources.GetObject("ComboBox1.Font"), System.Drawing.Font)
        Me.ComboBox1.ImeMode = CType(resources.GetObject("ComboBox1.ImeMode"), System.Windows.Forms.ImeMode)
        Me.ComboBox1.IntegralHeight = CType(resources.GetObject("ComboBox1.IntegralHeight"), Boolean)
        Me.ComboBox1.ItemHeight = CType(resources.GetObject("ComboBox1.ItemHeight"), Integer)
        Me.ComboBox1.Items.AddRange(New Object() {resources.GetString("ComboBox1.Items"), resources.GetString("ComboBox1.Items1"), resources.GetString("ComboBox1.Items2"), resources.GetString("ComboBox1.Items3"), resources.GetString("ComboBox1.Items4")})
        Me.ComboBox1.Location = CType(resources.GetObject("ComboBox1.Location"), System.Drawing.Point)
        Me.ComboBox1.MaxDropDownItems = CType(resources.GetObject("ComboBox1.MaxDropDownItems"), Integer)
        Me.ComboBox1.MaxLength = CType(resources.GetObject("ComboBox1.MaxLength"), Integer)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.RightToLeft = CType(resources.GetObject("ComboBox1.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.ComboBox1.Size = CType(resources.GetObject("ComboBox1.Size"), System.Drawing.Size)
        Me.ComboBox1.TabIndex = CType(resources.GetObject("ComboBox1.TabIndex"), Integer)
        Me.ComboBox1.Text = resources.GetString("ComboBox1.Text")
        Me.ComboBox1.Visible = CType(resources.GetObject("ComboBox1.Visible"), Boolean)
        '
        'Feedback
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
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Enabled = CType(resources.GetObject("$this.Enabled"), Boolean)
        Me.Font = CType(resources.GetObject("$this.Font"), System.Drawing.Font)
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ImeMode = CType(resources.GetObject("$this.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Location = CType(resources.GetObject("$this.Location"), System.Drawing.Point)
        Me.MaximumSize = CType(resources.GetObject("$this.MaximumSize"), System.Drawing.Size)
        Me.MinimumSize = CType(resources.GetObject("$this.MinimumSize"), System.Drawing.Size)
        Me.Name = "Feedback"
        Me.RightToLeft = CType(resources.GetObject("$this.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.StartPosition = CType(resources.GetObject("$this.StartPosition"), System.Windows.Forms.FormStartPosition)
        Me.Text = resources.GetString("$this.Text")
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim orderlist As String
    Dim con As SqlConnection
    Dim cmd, cmd2 As SqlCommand
    Dim showda As SqlDataAdapter
    Dim ds As DataSet
    Dim dr As SqlDataReader
    Dim query As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ComboBox1.SelectedItem <> Nothing Then
            If TextBox1.Text.Trim.Length > 0 Then
                Dim customerForm As New CustomerForm
                customerForm.Show()
                'feedback submission logic
                Try
                    con = New SqlConnection
                    con.ConnectionString = "Data source= vb;initial catalog=project1;user id = stud1;pwd = stud1"
                    con.Open()
                    cmd = New SqlCommand
                    cmd.Connection = con

                    query = "insert into feedback values('" + ComboBox1.SelectedItem.ToString() + "'"
                    query = query + "," + "'" + TextBox1.Text + "')"
                    cmd.CommandText = query
                    cmd.ExecuteNonQuery()
                    MsgBox("Thank you for you precious feedback")
                    Me.Close()
                Catch ex As Exception
                    MsgBox(query)
                    MsgBox("error in insertion" + ex.Message)
                End Try
            Else
                MsgBox("Please Write Some Message")
            End If
        Else
            MsgBox("Please Select Table No. ")
        End If



    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim customerForm As New CustomerForm
        customerForm.Show()
        Me.Hide()

    End Sub
End Class
