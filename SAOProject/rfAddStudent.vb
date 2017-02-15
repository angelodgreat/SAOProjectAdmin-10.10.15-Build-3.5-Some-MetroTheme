Public Class rfAddStudent

    Dim previousForm As Form



    Public Sub Init(ByVal form As Form)
        previousForm = form
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If String.IsNullOrEmpty(txtNum.Text) Then
            tipError.Show("Please enter student number.", txtNum)
            txtNum.Select()
        ElseIf String.IsNullOrEmpty(txtSurname.Text) Then
            tipError.Show("Please enter last name.", txtSurname)
            txtSurname.Select()
        ElseIf String.IsNullOrEmpty(txtFirstname.Text) Then
            tipError.Show("Please enter first name.", txtFirstname)
            txtFirstname.Select()
        ElseIf comCollege.SelectedIndex = -1 Then
            tipError.Show("Please select school/college.", comCollege)
            comCollege.Select()
        ElseIf comCourse.SelectedIndex = -1 Then
            tipError.Show("Please select course.", comCourse)
            comCourse.Select()
        ElseIf comYear.SelectedIndex = -1 Then
            tipError.Show("Please select year.", comYear)
            comYear.Select()
        Else
            Dim num As String = txtNum.Text
            Dim surname As String = txtSurname.Text
            Dim firstName As String = txtFirstname.Text
            Dim mid As String = txtMi.Text
            Dim college As String = comCollege.SelectedItem.ToString()
            Dim course As String = comCourse.SelectedItem.ToString()
            Dim yr As String = comYear.SelectedItem.ToString()

            Dim test As String = "SELECT StudentNo FROM ceuratingforms.studinfo WHERE StudentNo = '" & num & "'"
            If count(test, 1) <> 0 Then
                tipError.Show("Student number already registered!", txtNum)
            Else
                Dim query As String = "INSERT INTO ceuratingforms.studinfo VALUES( '" & num & "' , '" & surname & "' , '" & firstName & "' , '" & mid & "' , '" & college & "' , '" & course & "' , '" & yr & "')"
                If ExecuteQuery(query) Then
                    MsgBox("Student added!")
                    Clear()
                End If
            End If
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Clear()
    End Sub

    Private Sub Clear()
        txtNum.Text = String.Empty
        txtSurname.Text = String.Empty
        txtFirstname.Text = String.Empty
        txtMi.Text = String.Empty
        comCollege.SelectedIndex = -1
        comCourse.SelectedIndex = -1
        comYear.SelectedIndex = -1
        txtNum.Select()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        previousForm.Enabled = True
        previousForm.Select()
        Hide()
    End Sub

    Private Sub MetroPanel2_Paint(sender As Object, e As PaintEventArgs) Handles MetroPanel2.Paint

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

    Private Sub frmAddStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim year As Integer = Integer.Parse(Date.Now.Year)
        For year = year + 10 To year Step -1
            comYear.Items.Add(year.ToString())
        Next
        txtNum.Select()
    End Sub

    Private Sub rfAddStudent_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Hide()
    End Sub
End Class