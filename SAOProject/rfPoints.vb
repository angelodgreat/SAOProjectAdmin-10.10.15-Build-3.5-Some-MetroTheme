Public Class rfPoints
    Dim studNo As String
    Dim surname As String
    Dim firstName As String
    Dim middle As String

    Dim studentInfo As ArrayList

    Public Function GetNum() As String
        Return studNo
    End Function

    Public Function GetName() As String
        Return surname + ", " + firstName + " " + middle
    End Function

    Public Function GetPoints() As Integer
        Return Integer.Parse(txtPoints.Text)
    End Function

    Public Sub SetPoints(ByVal points As Integer)
        txtPoints.Text = points.ToString()
    End Sub

    Public Sub setRemarks(ByVal remarks As String)
        txtRemarks.Text = remarks
    End Sub

    Public Sub init(ByVal num As String, ByVal lName As String, ByVal fName As String, ByVal mId As String)
        studNo = num
        surname = lName
        firstName = fName
        middle = mId
    End Sub
    Private Sub FrmPoints_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Closing
        If MsgBox("Are you sure you want to exit?", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
            End
        Else
            e.Cancel = True
        End If
    End Sub
    Private Sub Points_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNum.Text = studNo
        txtName.Text = firstName & " " & middle & " " & surname
        Dim query = "SELECT * FROM ceuratingforms.pointsinfo WHERE StudNo = '" & studNo & "'"
        If (count(query, 3)) <> 0 Then
            studentInfo = RetrieveQuery(query, 3)
            txtPoints.Text = studentInfo(0)(1).ToString()
            txtRemarks.Text = studentInfo(0)(2).ToString()
        Else
            Dim points As Integer = 0
            query = "INSERT INTO ceuratingforms.pointsinfo VALUES ('" & studNo & "' , " & points & " , ' ' )"
            If ExecuteQuery(query) Then
                txtPoints.Text = 0
                txtRemarks.Text = String.Empty
            Else
                MsgBox("Student points not initialized.")
            End If
        End If

        If GetAccess() <> "Admin" Then
            txtPoints.Enabled = False
            txtRemarks.Enabled = False
            txtPoints.PasswordChar = "•"
            txtRemarks.PasswordChar = "•"
            tilVForms.Visible = False
            tilAdd.Location = New Point(165, 101)
            tilHome.Location = New Point(246, 101)
        Else
            txtPoints.Enabled = True
            txtRemarks.Enabled = True
            txtPoints.PasswordChar = String.Empty
            txtRemarks.PasswordChar = String.Empty
        End If
    End Sub

    Private Sub tilHome_Click(sender As Object, e As EventArgs) Handles tilHome.Click
        Dim nextform = New rfAdminHome
        nextform.Show()
        Hide()
    End Sub

    Private Sub tilAdd_Click(sender As Object, e As EventArgs) Handles tilAdd.Click
        Dim nextForm As New rfRatingForms
        nextForm.init(Me)
        nextForm.Show()
        Enabled = False
    End Sub

    Private Sub tilVForms_Click(sender As Object, e As EventArgs) Handles tilVForms.Click
        If GetPoints() = 0 Then
            MsgBox("Student has not submitted any forms yet.")
        Else
            Dim nextForm As New rfViewForms
            nextForm.init(Me)
            nextForm.Show()
            Enabled = False
        End If
    End Sub
End Class