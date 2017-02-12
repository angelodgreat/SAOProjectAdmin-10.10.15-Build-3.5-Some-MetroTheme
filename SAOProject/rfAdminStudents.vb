Imports System.Collections.Generic
Public Class rfAdminStudents
    Dim studentList As New ArrayList()
    Dim currentStudent As Integer
    Dim hahaha As String

    Private Sub AdminStudents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim year As Integer = Integer.Parse(Date.Now.Year)
        For year = year + 10 To year Step -1
            comYear.Items.Add(year.ToString())
        Next

        Dim query As String = "SELECT StudentNo FROM studinfo"


        Dim studentNums As ArrayList = RetrieveQuery(query, 1)
        For Each studentNum As ArrayList In studentNums
            txtSearch.AutoCompleteCustomSource.Add(studentNum(0).ToString)
        Next

        Dim query1 = "SELECT LName, FName, MiddleIni FROM studinfo"

        Dim studentNames As ArrayList = RetrieveQuery(query1, 3)
        For Each studentName As ArrayList In studentNames
            Dim name As String = studentName(0).ToString & ", " & studentName(1).ToString & " " & studentName(2).ToString
            txtSearch.AutoCompleteCustomSource.Add(name)
        Next

        txtSearch.Select()


    End Sub

    Private Sub FrmAdHome_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Closing
        If MsgBox("Are you sure you want to exit?", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
            End
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub tilHome_Click(sender As Object, e As EventArgs) Handles tilHome.Click
        Dim nextForm As New rfAdminHome()
        nextForm.Show()
        Hide()
    End Sub

    Private Sub DisplayStudent()
        hahaha = studentList(currentStudent)(0).ToString()
        txtNum.Text = studentList(currentStudent)(0).ToString()
        txtSurname.Text = studentList(currentStudent)(1).ToString()
        txtFirstname.Text = studentList(currentStudent)(2).ToString()
        txtMid.Text = studentList(currentStudent)(3).ToString()
        comCollege.SelectedIndex = comCollege.Items.IndexOf(studentList(currentStudent)(4).ToString())
        comCourse.SelectedIndex = comCourse.Items.IndexOf(studentList(currentStudent)(5).ToString())
        comYear.SelectedIndex = comYear.Items.IndexOf(studentList(currentStudent)(6).ToString())
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If String.IsNullOrEmpty(txtSearch.Text) Then
            tipError.Show("Please enter a search query.", txtSearch)
            txtSearch.Select()
        Else
            Dim search() As String = {String.Empty, String.Empty, String.Empty}
            Dim name As String = txtSearch.Text
            If name.Length > 8 Then
                search(0) = name.Substring(0, txtSearch.Text.IndexOf(","))

                name = name.Remove(0, name.IndexOf(",") + 2)
                Dim temp() As String = New String() {}

                temp = name.Split(" ")

                search(2) = temp.Last

                temp = temp.RemoveAt(temp.Length - 1)

                Dim index As Integer

                For index = 0 To temp.Length - 1
                    search(1) &= temp(index)
                    If index < temp.Length - 1 Then
                        search(1) &= " "
                    End If
                Next
            End If

            Dim query = "SELECT * FROM studinfo WHERE StudentNo = '" & txtSearch.Text & "' OR LName = '" & search(0) & "' AND FName = '" & search(1) & "' AND MiddleIni = '" & search(2) & "' "

            If count(query, 7) <> 0 Then
                studentList = RetrieveQuery(query, 7)
                comYear.Items.AddRange(studentList.ToArray)

                btnEdit.Enabled = True
                btnDelete.Enabled = True
                btnPoints.Enabled = True

                currentStudent = 0
                DisplayStudent()
            Else
                MsgBox("Your search has returned zero results.")
            End If
        End If
    End Sub


    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MsgBox("Are you sure you want to delete this student?", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
            studentList.RemoveAt(currentStudent)
            Dim num As String = txtNum.Text
            Dim query = "DELETE FROM studinfo WHERE StudentNo = '" & num & "'"
            If ExecuteQuery(query) Then
                query = "DELETE FROM pointsinfo WHERE StudNo = '" & num & "'"
                If Not ExecuteQuery(query) Then
                    MsgBox("Points not removed from database.")
                End If

                If studentList.Count = 1 Then
                    currentStudent = 0
                    DisplayStudent()
                Else
                    Clear()
                End If
                MsgBox("Student deleted!")
            Else
                MsgBox("Student not deleted!")
            End If
        End If
    End Sub

    Private Sub Clear()
        txtNum.Text = String.Empty
        txtSurname.Text = String.Empty
        txtFirstname.Text = String.Empty
        txtMid.Text = String.Empty
        comCollege.SelectedIndex = -1
        comYear.SelectedIndex = -1

        txtSearch.Select()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

        btnEdit.Visible = False
        btnDelete.Visible = False
        btnSave.Visible = True
        btnCancel.Visible = True

        txtNum.Enabled = True
        txtSurname.Enabled = True
        txtFirstname.Enabled = True
        txtMid.Enabled = True
        comCollege.Enabled = True
        comCourse.Enabled = True
        comYear.Enabled = True

        txtSurname.Select()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Reset()
    End Sub

    Private Sub Reset()

        btnEdit.Visible = True
        btnDelete.Visible = True
        btnSave.Visible = False
        btnCancel.Visible = False

        txtNum.Enabled = False
        txtSurname.Enabled = False
        txtFirstname.Enabled = False
        txtMid.Enabled = False
        comCollege.Enabled = False
        comCourse.Enabled = False
        comYear.Enabled = False

        Dim search() As String = {String.Empty, String.Empty, String.Empty}
        Dim name As String = txtSearch.Text
        If name.Length > 8 Then
            search(0) = name.Substring(0, txtSearch.Text.IndexOf(","))

            name = name.Remove(0, name.IndexOf(",") + 2)
            Dim temp() As String = New String() {}

            temp = name.Split(" ")

            search(2) = temp.Last

            temp = temp.RemoveAt(temp.Length - 1)

            Dim index As Integer

            For index = 0 To temp.Length - 1
                search(1) &= temp(index)
                If index < temp.Length - 1 Then
                    search(1) &= " "
                End If
            Next
        End If

        Dim query = "SELECT * FROM studinfo WHERE StudentNo = '" & txtSearch.Text & "' OR LName = '" & search(0) & "' AND FName = '" & search(1) & "' AND MiddleIni = '" & search(2) & "' "

        If count(query, 7) <> 0 Then
            studentList = RetrieveQuery(query, 7)
            currentStudent = 0
            DisplayStudent()
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrEmpty(txtNum.Text) Then
            MsgBox("Please enter Student Number.")
            txtNum.Select()
        ElseIf String.IsNullOrEmpty(txtSurname.Text) Then
            MsgBox("Please enter Last Name.")
            txtSurname.Select()
        ElseIf String.IsNullOrEmpty(txtFirstname.Text) Then
            MsgBox("Please enter First Name.")
            txtFirstname.Select()
        ElseIf String.IsNullOrEmpty(txtMid.Text) Then
            MsgBox("Please enter Middle Initial.")
            txtMid.Select()
        ElseIf comCollege.SelectedIndex = -1 Then
            MsgBox("Please pick a College/School.")
            comCollege.Select()
        ElseIf comCourse.SelectedIndex = -1 Then
            MsgBox("Please pick a Course.")
            comCourse.Select()
        ElseIf comYear.SelectedIndex = -1 Then
            MsgBox("Please enter Year of Graduation.")
            comYear.Select()
        Else
            Dim num As String = txtNum.Text
            Dim surname As String = txtSurname.Text
            Dim firstName As String = txtFirstname.Text
            Dim mid As String = txtMid.Text
            Dim college As String = comCollege.SelectedItem.ToString()
            Dim course As String = comCourse.SelectedItem.ToString()
            Dim yr As String = comYear.SelectedItem.ToString()

            Dim query = "UPDATE studinfo SET StudentNo ='" & num & "', LName = '" & surname & "' , FName = '" & firstName & "' , MiddleIni = '" & mid & "' , College_School = '" & college & "' , Course = '" & course & "' , YearGrad = '" & yr & "' WHERE StudentNo ='" & hahaha & "'"

            If ExecuteQuery(query) Then
                MsgBox("Changes have been saved!")
            Else
                MsgBox("Changes were not saved!")
            End If

            Reset()
        End If
    End Sub

    Private Sub comCollege_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comCollege.SelectedIndexChanged
        comCourse.Items.Clear()
        Select Case comCollege.SelectedIndex
            Case 0 'SAM
                comCourse.Items.Clear()
                comCourse.Items.Add("BS Accountancy")
                comCourse.Items.Add("BS Legal Management")
                comCourse.Items.Add("BS Business Administration")
            Case 1 'DENT
                comCourse.Items.Add("Pre-Dentistry(AAPD)")
                comCourse.Items.Add("Dentistry")
            Case 2 'SELAMS
                comCourse.Items.Add("BS Secondary Education")
                comCourse.Items.Add("BS Elementary Education")
                comCourse.Items.Add("BS Library and Information Science")
                comCourse.Items.Add("BS Social Work")
                comCourse.Items.Add("Secondary Teacher Certificate")
                comCourse.Items.Add("Elementary Teacher Certificate")
                comCourse.Items.Add("BA Mass Communication")
                comCourse.Items.Add("BA Political Science")
                comCourse.Items.Add("Bachelor of Music")
                comCourse.Items.Add("Bachelor of Music - Music Education")
            Case 3 'MEDTECH
                comCourse.Items.Add("BS Medical Technology")
            Case 4 'NURSING
                comCourse.Items.Add("BS Nursing")
            Case 5 'OPTO
                comCourse.Items.Add("Pre-Optometry(POD)")
                comCourse.Items.Add("Doctor of Optometry")
            Case 6 'PHARMA
                comCourse.Items.Add("BS Pharmacy")
                comCourse.Items.Add("BS Pharmacy CP")
                comCourse.Items.Add("Doctor of Pharmacy")
            Case 7 'SCITECH
                comCourse.Items.Add("BS Biology")
                comCourse.Items.Add("BS Cosmetic Science")
                comCourse.Items.Add("BS Psychology")
                comCourse.Items.Add("BS Computer Engineering")
                comCourse.Items.Add("BS Computer Science")
                comCourse.Items.Add("BS Information Technology")
            Case 8 'HRM
                comCourse.Items.Add("BS Hotel and Restaurant Management")
                comCourse.Items.Add("BS Tourism Management")
                comCourse.Items.Add("BS Nutrition and Dietetics")
        End Select
    End Sub

    Private Sub btnPoints_Click(sender As Object, e As EventArgs) Handles btnPoints.Click
        Dim studNo = txtNum.Text
        Dim surname As String = txtSurname.Text
        Dim firstname As String = txtFirstname.Text
        Dim mi As String = txtMid.Text

        Dim nextForm = New rfPoints()
        nextForm.init(studNo, surname, firstname, mi)
        nextForm.Show()
        Me.Hide()
    End Sub

    Private Sub tilAdd_Click(sender As Object, e As EventArgs) Handles tilAdd.Click
        Dim nextForm As New rfAddStudent()
        nextForm.Init(Me)
        Enabled = False
        nextForm.Show()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        txtNum.Text = String.Empty
        txtSurname.Text = String.Empty
        txtFirstname.Text = String.Empty
        txtMid.Text = String.Empty
        comCollege.SelectedIndex = -1
        comCourse.SelectedIndex = -1
        comYear.SelectedIndex = -1
    End Sub
End Class