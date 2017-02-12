Public Class rfApproveForms
    Dim previousForm As Form

    Public Sub init(ByRef form As Form)
        previousForm = form
    End Sub
    Private Sub tabVRF_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tabVRF.SelectedIndexChanged
        DisplayContent()
    End Sub

    Private Sub tilExit_Click(sender As Object, e As EventArgs) Handles tilExit.Click
        previousForm.Enabled = True
        previousForm.Focus()
        Hide()
    End Sub

    Private Sub frmVForms_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If previousForm.Name = "frmAdHome" Then
            btnApprove.Visible = True
        End If
        tabVRF.SelectedIndex = -1
        tabVRF.SelectedIndex = 0


    End Sub

    Private Sub btnApprove_Click(sender As Object, e As EventArgs) Handles btnApprove.Click
        Dim query As String
        Select Case tabVRF.SelectedIndex
            Case 0
                query = "UPDATE ratingform1 SET appr = 1 WHERE appr = 0"
                query = "Select StudNo, totalPoints from ratingform1 WHERE appr = 0"
                Dim results = RetrieveQuery(query, 2)
                For Each result As ArrayList In results
                    Dim poist As Integer
                    Dim stud As String
                    stud = result(0).ToString
                    poist = Integer.Parse(result(1)).ToString()
                    Dim query1 = "Select TotalPoints from pointsinfo where StudNo = '" & stud & "'"
                    Dim studpoint = RetrieveQuery(query1, 1)
                    Dim total = Integer.Parse(studpoint(0)(0)).ToString()
                    Dim tol As Integer = poist + total
                    query = "UPDATE pointsinfo set TotalPoints = " & tol & " Where StudNo = '" & stud & "'"
                    ExecuteQuery(query)
                Next
                ExecuteQuery(query)
            Case 1
                query = "UPDATE ratingform2 SET appr = 1 WHERE appr = 0"
                query = "Select StudentNo, TWP from ratingform2 WHERE appr = 0"
                Dim results = RetrieveQuery(query, 2)
                For Each result As ArrayList In results
                    Dim poist As Integer
                    Dim stud As String
                    stud = result(0).ToString
                    poist = Integer.Parse(result(1)).ToString()
                    Dim query1 = "Select TotalPoints from pointsinfo where StudNo = '" & stud & "'"
                    Dim studpoint = RetrieveQuery(query1, 1)
                    Dim total = Integer.Parse(studpoint(0)(0)).ToString()
                    Dim tol As Integer = poist + total
                    query = "UPDATE pointsinfo set TotalPoints = " & tol & " Where StudNo = '" & stud & "'"
                    ExecuteQuery(query)
                Next
                ExecuteQuery(query)
            Case 2
                query = "UPDATE ratingform3 SET appr = 1 WHERE appr = 0"
                query = "Select StudentNo, TWP from ratingform3 WHERE appr = 0"
                Dim results = RetrieveQuery(query, 2)
                For Each result As ArrayList In results
                    Dim poist As Integer
                    Dim stud As String
                    stud = result(0).ToString
                    poist = Integer.Parse(result(1)).ToString()
                    Dim query1 = "Select TotalPoints from pointsinfo where StudNo = '" & stud & "'"
                    Dim studpoint = RetrieveQuery(query1, 1)
                    Dim total = Integer.Parse(studpoint(0)(0)).ToString()
                    Dim tol As Integer = poist + total
                    query = "UPDATE pointsinfo set TotalPoints = " & tol & " Where StudNo = '" & stud & "'"
                    ExecuteQuery(query)
                Next
                ExecuteQuery(query)
            Case 3
                query = "UPDATE ratingform4 SET appr = 1 WHERE appr = 0"
                query = "Select StudentNo, twp from ratingform4 WHERE appr = 0"
                Dim results = RetrieveQuery(query, 2)
                For Each result As ArrayList In results
                    Dim poist As Integer
                    Dim stud As String
                    stud = result(0).ToString
                    poist = Integer.Parse(result(1)).ToString()
                    Dim query1 = "Select TotalPoints from pointsinfo where StudNo = '" & stud & "'"
                    Dim studpoint = RetrieveQuery(query1, 1)
                    Dim total = Integer.Parse(studpoint(0)(0)).ToString()
                    Dim tol As Integer = poist + total
                    query = "UPDATE pointsinfo set TotalPoints = " & tol & " Where StudNo = '" & stud & "'"
                    ExecuteQuery(query)
                Next
                ExecuteQuery(query)
            Case 4
                query = "UPDATE ratingform5 SET appr = 1 WHERE appr = 0"
                query = "Select StudentNo, twp from ratingform5 WHERE appr = 0"
                Dim results = RetrieveQuery(query, 2)
                For Each result As ArrayList In results
                    Dim poist As Integer
                    Dim stud As String
                    stud = result(0).ToString
                    poist = Integer.Parse(result(1)).ToString()
                    Dim query1 = "Select TotalPoints from pointsinfo where StudNo = '" & stud & "'"
                    Dim studpoint = RetrieveQuery(query1, 1)
                    Dim total = Integer.Parse(studpoint(0)(0)).ToString()
                    Dim tol As Integer = poist + total
                    query = "UPDATE pointsinfo set TotalPoints = " & tol & " Where StudNo = '" & stud & "'"
                    ExecuteQuery(query)
                Next
                ExecuteQuery(query)
            Case 5
                query = "UPDATE ratingform6 SET appr = 1 WHERE appr = 0"
                query = "Select StudentNo, twp from ratingform6 WHERE appr = 0"
                Dim results = RetrieveQuery(query, 2)
                For Each result As ArrayList In results
                    Dim poist As Integer
                    Dim stud As String
                    stud = result(0).ToString
                    poist = Integer.Parse(result(1)).ToString()
                    Dim query1 = "Select TotalPoints from pointsinfo where StudNo = '" & stud & "'"
                    Dim studpoint = RetrieveQuery(query1, 1)
                    Dim total = Integer.Parse(studpoint(0)(0)).ToString()
                    Dim tol As Integer = poist + total
                    query = "UPDATE pointsinfo set TotalPoints = " & tol & " Where StudNo = '" & stud & "'"
                    ExecuteQuery(query)
                Next
                ExecuteQuery(query)
            Case 6
                query = "UPDATE ratingform7 SET appr = 1 WHERE appr = 0"
                query = "Select StudentNo, twp from ratingform7 WHERE appr = 0"
                Dim results = RetrieveQuery(query, 2)
                For Each result As ArrayList In results
                    Dim poist As Integer
                    Dim stud As String
                    stud = result(0).ToString
                    poist = Integer.Parse(result(1)).ToString()
                    Dim query1 = "Select TotalPoints from pointsinfo where StudNo = '" & stud & "'"
                    Dim studpoint = RetrieveQuery(query1, 1)
                    Dim total = Integer.Parse(studpoint(0)(0)).ToString()
                    Dim tol As Integer = poist + total
                    query = "UPDATE pointsinfo set TotalPoints = " & tol & " Where StudNo = '" & stud & "'"
                    ExecuteQuery(query)
                Next
                ExecuteQuery(query)
        End Select
        DisplayContent()
    End Sub

    Private Sub DisplayContent()
        Dim query As String
        Dim approval As Integer = 1

        Select Case tabVRF.SelectedIndex()
            Case 0 'Rating Form 1
                If previousForm.Name = "frmAdHome" Then
                    query = "SELECT rfid, StudentNo, titleAct, totalPoints FROM ratingform1 WHERE  appr = 0"
                End If

                Dim numResults = count(query, 4)

                If numResults <> 0 Then
                    Dim results = RetrieveQuery(query, 4)
                    Dim row As Integer

                    rf1Grid.RowCount = numResults

                    For row = 0 To numResults - 1
                        rf1Grid.Rows(row).Cells(0).Value = results(row)(0).ToString()
                        rf1Grid.Rows(row).Cells(1).Value = results(row)(1).ToString()
                        rf1Grid.Rows(row).Cells(2).Value = results(row)(2).ToString()
                        rf1Grid.Rows(row).Cells(3).Value = results(row)(3).ToString()
                    Next
                Else
                    MsgBox("No forms in database.")
                End If
            Case 1 'Rating Form 2
                If previousForm.Name = "frmAdHome" Then
                    query = "SELECT rfid, StudentNo, TitleAct, TWP from ratingform2 WHERE appr = 0"
                End If

                Dim numResults = count(query, 4)

                If numResults <> 0 Then
                    Dim results = RetrieveQuery(query, 4)
                    Dim row As Integer

                    rf2Grid.RowCount = numResults

                    For row = 0 To numResults - 1
                        rf2Grid.Rows(row).Cells(0).Value = results(row)(0).ToString()
                        rf2Grid.Rows(row).Cells(1).Value = results(row)(1).ToString()
                        rf2Grid.Rows(row).Cells(2).Value = results(row)(2).ToString()
                        rf2Grid.Rows(row).Cells(3).Value = results(row)(3).ToString()
                    Next
                Else
                    MsgBox("No forms in database.")
                End If
            Case 2 'Rating Form 3 
                If previousForm.Name = "frmAdHome" Then
                    query = "SELECT rfid, StudentNo, TitleAct, TWP FROM ratingform3 WHERE appr = 0"
                End If

                Dim numResults = count(query, 4)

                If numResults <> 0 Then
                    Dim results = RetrieveQuery(query, 4)
                    Dim row As Integer

                    rf3Grid.RowCount = numResults

                    For row = 0 To numResults - 1
                        rf3Grid.Rows(row).Cells(0).Value = results(row)(0).ToString()
                        rf3Grid.Rows(row).Cells(1).Value = results(row)(1).ToString()
                        rf3Grid.Rows(row).Cells(2).Value = results(row)(2).ToString()
                        rf3Grid.Rows(row).Cells(3).Value = results(row)(3).ToString()
                    Next
                Else
                    MsgBox("No forms in database.")
                End If
            Case 3 'Rating Form 4
                If previousForm.Name = "frmAdHome" Then
                    query = "SELECT rfid, StudentNo, TitleAct, twp FROM ratingform4 WHERE appr = 0"
                End If

                Dim numResults = count(query, 4)

                If numResults <> 0 Then
                    Dim results = RetrieveQuery(query, 4)
                    Dim row As Integer

                    rf4Grid.RowCount = numResults

                    For row = 0 To numResults - 1
                        rf4Grid.Rows(row).Cells(0).Value = results(row)(0).ToString()
                        rf4Grid.Rows(row).Cells(1).Value = results(row)(1).ToString()
                        rf4Grid.Rows(row).Cells(2).Value = results(row)(2).ToString()
                        rf4Grid.Rows(row).Cells(3).Value = results(row)(3).ToString()
                    Next
                Else
                    MsgBox("No forms in database.")
                End If

            Case 4 'Rating Form 5
                If previousForm.Name = "frmAdHome" Then
                    query = "SELECT rfid, StudentNo, Role, twp FROM ratingform5 WHERE appr = 0"
                End If

                Dim numResults = count(query, 4)

                If numResults <> 0 Then
                    Dim results = RetrieveQuery(query, 4)
                    Dim row As Integer

                    rf5Grid.RowCount = numResults

                    For row = 0 To numResults - 1
                        rf5Grid.Rows(row).Cells(0).Value = results(row)(0).ToString()
                        rf5Grid.Rows(row).Cells(1).Value = results(row)(1).ToString()
                        rf5Grid.Rows(row).Cells(2).Value = results(row)(2).ToString()
                        rf5Grid.Rows(row).Cells(3).Value = results(row)(3).ToString()
                    Next
                Else
                    MsgBox("No forms in database.")
                End If


            Case 5 'Rating Form 6
                If previousForm.Name = "frmAdHome" Then
                    query = "SELECT rfid, StudentNo,  Position, twp FROM ratingform6 WHERE appr = 0"
                End If

                Dim numResults = count(query, 4)

                If numResults <> 0 Then
                    Dim results = RetrieveQuery(query, 4)
                    Dim row As Integer

                    rf6Grid.RowCount = numResults

                    For row = 0 To numResults - 1
                        rf6Grid.Rows(row).Cells(0).Value = results(row)(0).ToString()
                        rf6Grid.Rows(row).Cells(1).Value = results(row)(1).ToString()
                        rf6Grid.Rows(row).Cells(2).Value = results(row)(2).ToString()
                        rf6Grid.Rows(row).Cells(3).Value = results(row)(3).ToString()
                    Next
                Else
                    MsgBox("No forms in database.")
                End If

            Case 6 'Rating Form 7
                If previousForm.Name = "frmAdHome" Then
                    query = "SELECT rfid, StudentNo, posit, twp FROM ratingform7 WHERE appr = 0"
                End If

                Dim numResults = count(query, 4)

                If numResults <> 0 Then
                    Dim results = RetrieveQuery(query, 4)
                    Dim row As Integer

                    rf7Grid.RowCount = numResults

                    For row = 0 To numResults - 1
                        rf7Grid.Rows(row).Cells(0).Value = results(row)(0).ToString()
                        rf7Grid.Rows(row).Cells(1).Value = results(row)(1).ToString()
                        rf7Grid.Rows(row).Cells(2).Value = results(row)(2).ToString()
                        rf7Grid.Rows(row).Cells(3).Value = results(row)(3).ToString()
                    Next
                Else
                    MsgBox("No forms in database.")
                End If
        End Select
        If previousForm.Name = "frmAdHome" Then
            DirectCast(previousForm, rfAdminHome).FetchNotifications()
        End If

    End Sub
End Class