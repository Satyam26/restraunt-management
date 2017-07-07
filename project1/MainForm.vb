Imports System.Data.sqlclient
Public Class MainForm
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(MainForm))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Red
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(400, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "1"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Red
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(464, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 40)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "2"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Red
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(528, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 40)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "3"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Red
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(592, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 40)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "4"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Red
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(656, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 40)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "5"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label6.Location = New System.Drawing.Point(16, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "ORDER NO."
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.ForeColor = System.Drawing.Color.DarkRed
        Me.ListBox1.ItemHeight = 23
        Me.ListBox1.Location = New System.Drawing.Point(24, 80)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(336, 142)
        Me.ListBox1.TabIndex = 13
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.CadetBlue
        Me.Button1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(504, 104)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(176, 40)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "GENERATE BILL"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button2.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button2.Location = New System.Drawing.Point(608, 248)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(88, 32)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "BACK"
        '
        'ComboBox1
        '
        Me.ComboBox1.Location = New System.Drawing.Point(136, 24)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 19
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Sienna
        Me.Button3.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button3.Location = New System.Drawing.Point(504, 176)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(176, 40)
        Me.Button3.TabIndex = 20
        Me.Button3.Text = "CANCEL ORDER"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button4.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button4.Location = New System.Drawing.Point(488, 248)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(88, 32)
        Me.Button4.TabIndex = 21
        Me.Button4.Text = "CLEAR"
        '
        'MainForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(720, 366)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainForm"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim showda As SqlDataAdapter
    Dim ds As DataSet
    Dim dr As SqlDataReader

    Dim itemListArray(10) As String
    Dim quantityArray(10) As Integer
    Dim price(10) As Double
    Dim ordered As String = "1"


    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ListBox1.Visible = False
        ComboBox1.Visible = False
        checktablestatus()
        'getting price of items from database
        Try
            Dim cnt As Integer = 0
            con = New SqlConnection
            con.ConnectionString = "Data source= vb;initial catalog=project1;user id = stud1;pwd = stud1"
            con.Open()
            cmd = New SqlCommand
            cmd.Connection = con
            Dim query As String
            query = "SELECT price from menu"
            cmd.CommandText = query
            dr = cmd.ExecuteReader()
            While dr.Read()
                'MsgBox(dr.GetValue(0))
                price(cnt) = Convert.ToDouble(dr.GetValue(0))
                cnt = cnt + 1
            End While
            'removing free space of price array
            ReDim Preserve price(cnt - 1)
            con.Close()
        Catch ex As Exception
            MsgBox("error in getting price in mainform load")
        End Try

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        ComboBox1.Visible = True
        ListBox1.Visible = True
        Try
            con = New SqlConnection
            con.ConnectionString = "Data source= vb;initial catalog=project1;user id = stud1;pwd = stud1"
            con.Open()
            cmd = New SqlCommand
            cmd.Connection = con
            cmd = New SqlCommand
            cmd.Connection = con
            Dim query As String
            query = "SELECT orderno from order2 where placed ='1' AND done = '0' AND tableno='1'"
            cmd.CommandText = query
            dr = cmd.ExecuteReader()
            ComboBox1.Items.Clear()
            While dr.Read()
                ComboBox1.Items.Add(dr.GetValue(0))
            End While
        Catch ex As Exception
            MsgBox("error in getting orderno to combobox")
        End Try

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        ComboBox1.Visible = True
        ListBox1.Visible = True
        Try
            con = New SqlConnection
            con.ConnectionString = "Data source= vb;initial catalog=project1;user id = stud1;pwd = stud1"
            con.Open()
            cmd = New SqlCommand
            cmd.Connection = con
            cmd = New SqlCommand
            cmd.Connection = con
            Dim query As String
            query = "SELECT orderno from order2 where placed ='1' AND done = '0' AND tableno='2'"
            cmd.CommandText = query
            dr = cmd.ExecuteReader()
            ComboBox1.Items.Clear()
            While dr.Read()
                ComboBox1.Items.Add(dr.GetValue(0))
            End While
        Catch ex As Exception
            MsgBox("error in getting orderno to combobox")
        End Try

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        ComboBox1.Visible = True
        ListBox1.Visible = True
        Try
            con = New SqlConnection
            con.ConnectionString = "Data source= vb;initial catalog=project1;user id = stud1;pwd = stud1"
            con.Open()
            cmd = New SqlCommand
            cmd.Connection = con
            cmd = New SqlCommand
            cmd.Connection = con
            Dim query As String
            query = "SELECT all orderno from order2 where placed ='1' AND done = '0' AND tableno='3'"
            cmd.CommandText = query
            dr = cmd.ExecuteReader()
            ComboBox1.Items.Clear()
            While dr.Read() 
                ComboBox1.Items.Add(dr.GetValue(0))
            End While
        Catch ex As Exception
            MsgBox("error in getting orderno to combobox")
        End Try

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        ComboBox1.Visible = True
        ListBox1.Visible = True
        Try
            con = New SqlConnection
            con.ConnectionString = "Data source= vb;initial catalog=project1;user id = stud1;pwd = stud1"
            con.Open()
            cmd = New SqlCommand
            cmd.Connection = con
            cmd = New SqlCommand
            cmd.Connection = con
            Dim query As String
            query = "SELECT all orderno from order2 where placed ='1' AND done = '0' AND tableno='4'"
            cmd.CommandText = query
            dr = cmd.ExecuteReader()
            ComboBox1.Items.Clear()
            While dr.Read()
                ComboBox1.Items.Add(dr.GetValue(0))
            End While
        Catch ex As Exception
            MsgBox("error in getting orderno to combobox")
        End Try

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        ComboBox1.Visible = True
        ListBox1.Visible = True
        Try
            con = New SqlConnection
            con.ConnectionString = "Data source= vb;initial catalog=project1;user id = stud1;pwd = stud1"
            con.Open()
            cmd = New SqlCommand
            cmd.Connection = con
            cmd = New SqlCommand
            cmd.Connection = con
            Dim query As String
            query = "SELECT all orderno from order2 where placed ='1' AND done = '0' AND tableno='5'"
            cmd.CommandText = query
            dr = cmd.ExecuteReader()
            ComboBox1.Items.Clear()
            While dr.Read()
                ComboBox1.Items.Add(dr.GetValue(0))
            End While
            con.Close()
        Catch ex As Exception
            MsgBox("error in getting orderno to combobox")
        End Try

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim uform As New userwelcomeform
        uform.Show()
        Me.Close()
    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim orderlist As String
        Dim itemarray() As String
        Dim orderno As String
        Dim i As Integer


        orderno = Trim(ComboBox1.SelectedItem.ToString())
        ordered = ordered + "," + orderno
        Try
            con = New SqlConnection
            con.ConnectionString = "Data source= vb;initial catalog=project1;user id = stud1;pwd = stud1"
            con.Open()
            cmd = New SqlCommand
            cmd.Connection = con
            Dim query As String
            query = "SELECT orderlist from order2 where orderno=" + orderno
            cmd.CommandText = query
            'MsgBox(query)
            dr = cmd.ExecuteReader()
            If (dr.Read()) Then
                orderlist = dr.GetString(0)
                itemarray = Split(orderlist, "/")
                'ListBox1.Items.Clear()
                For i = 0 To itemarray.Length - 2
                    ListBox1.Items.Add(itemarray(i))

                Next
            End If
            con.Close()

        Catch ex As Exception
            MsgBox("error in getting order details")
        End Try

        
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ListBox1.Items.Clear()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim i As Integer = 0
        Dim total As Integer = 0
        Dim sum As Integer = 0
        Dim s, p As Integer
        Dim st As String
        Dim msg As String

        If ComboBox1.SelectedItem <> Nothing Then
            'assigning itemname and quantity value to array which will be used to calculate price
            For i = 0 To ListBox1.Items.Count - 1
                s = Convert.ToInt16(ListBox1.Items(i).Substring(ListBox1.Items(i).Length - 2, 1))
                st = ListBox1.Items(i).Substring(0, ListBox1.Items(i).IndexOf("["))
                itemListArray(i) = st
                quantityArray(i) = s
            Next
            'to resize the array and preserve the value stored
            'ReDim Preserve itemListArray(ListBox1.Items.Count - 1)
            'ReDim Preserve quantityArray(ListBox1.Items.Count - 1)

            'MsgBox(ListBox1.Items.Count)
            msg = "items quantity price total" + Environment.NewLine
            For i = 0 To ListBox1.Items.Count - 1
                sum = 0
                If String.Compare(itemListArray(i), "coffee") = 0 Then
                    p = price(0)
                ElseIf String.Compare(itemListArray(i), "tea") = 0 Then
                    p = price(1)
                ElseIf String.Compare(itemListArray(i), "sandwich") = 0 Then
                    p = price(2)
                Else
                    p = price(3)
                End If
                sum = sum + quantityArray(i) * p
                total = total + sum
                msg = msg + Convert.ToString(itemListArray(i)) + "  " + Convert.ToString(quantityArray(i)) + "  " + Convert.ToString(p) + "  " + Convert.ToString(sum) + Environment.NewLine
            Next

            msg = msg + "Total price : " + Convert.ToString(total)
            MsgBox(msg)
            ListBox1.Items.Clear()
            Dim query As String
            query = "update order2 set done = 1 where orderno in (" + ordered + ")"
            'setting starting value as 1 
            ordered = "1"

            Try
                con = New SqlConnection
                con.ConnectionString = "Data source= vb;initial catalog=project1;user id = stud1;pwd = stud1"
                con.Open()
                cmd = New SqlCommand
                cmd.Connection = con

                cmd.CommandText = query
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(query)
                MsgBox("error in updation" + ex.Message)
            End Try
            checktablestatus()
        Else
            MsgBox("No Table Selected Yet")
        End If
        ComboBox1.Text = ""
        
    End Sub
    Function checktablestatus()
        Label1.BackColor = Color.Red
        Label2.BackColor = Color.Red
        Label3.BackColor = Color.Red
        Label4.BackColor = Color.Red
        Label5.BackColor = Color.Red
        Try
            con = New SqlConnection
            con.ConnectionString = "Data source= vb;initial catalog=project1;user id = stud1;pwd = stud1"
            con.Open()
            cmd = New SqlCommand
            cmd.Connection = con
            Dim query As String
            query = "SELECT DISTINCT tableno from order2 where placed ='1' AND done = '0'"
            cmd.CommandText = query
            dr = cmd.ExecuteReader()
            Dim table As Integer
            While dr.Read()
                table = Convert.ToInt16(dr.GetString(0))
                Select Case table
                    Case 1
                        Label1.BackColor = Color.Green
                    Case 2
                        Label2.BackColor = Color.Green
                    Case 3
                        Label3.BackColor = Color.Green
                    Case 4
                        Label4.BackColor = Color.Green
                    Case 5
                        Label5.BackColor = Color.Green
                End Select
            End While
        Catch ex As Exception
            MsgBox("Sorry Connection Failed")
        End Try
    End Function

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ListBox1.Items.Clear()

        If ComboBox1.SelectedItem <> Nothing Then
            Dim query As String
            query = "update order2 set done = 1 where orderno in (" + ordered + ")"
            'setting starting value as 1 
            ordered = "1"

            Try
                con = New SqlConnection
                con.ConnectionString = "Data source= vb;initial catalog=project1;user id = stud1;pwd = stud1"
                con.Open()
                cmd = New SqlCommand
                cmd.Connection = con

                cmd.CommandText = query
                cmd.ExecuteNonQuery()
                MsgBox("order has been successfully cancelled")
            Catch ex As Exception
                MsgBox(query)
                MsgBox("error in updation" + ex.Message)
            End Try
            checktablestatus()
        Else
            MsgBox("No Table Selected Yet")
        End If
        ComboBox1.Text = ""
    End Sub
End Class
