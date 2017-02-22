Public Class rfViewForms
    Dim previousForm As rfPoints
    Dim sinfo As ArrayList
    Private Sub ViewForms_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblrfstudno.Text = previousForm.GetNum
        lblrfstudname.Text = previousForm.GetName

        tabVRF.SelectedIndex = -1
        tabVRF.SelectedIndex = 0

        Dim query = "SELECT TotalPoints from ceuratingforms.studsum WHERE StudentNo = '" & DirectCast(previousForm, rfPoints).GetNum & "'"
        Dim ct = count(query, 1)
        If ct <> 0 Then
            Dim totl = RetrieveQuery(query, 1)
            lblTotalPoints.Text = totl(0)(0).ToString
        End If
    End Sub
    Public Sub init(ByRef form As Form)
        previousForm = form
    End Sub
    Private Sub displayContent()
        Dim query As String

        Select Case tabVRF.SelectedIndex()
            Case 0 'Rating Form 1
                If previousForm.Name = "rfPoints" Then
                    query = "SELECT rfid, titleAct, totalPoints FROM ceuratingforms.ratingform1 WHERE StudentNo = '" & DirectCast(previousForm, rfPoints).GetNum() & "' and appr = 1"
                End If
                Dim numResults = count(query, 3)

                If numResults <> 0 Then
                    Dim results = RetrieveQuery(query, 3)
                    Dim row As Integer

                    rf1Grid.RowCount = numResults

                    For row = 0 To numResults - 1
                        rf1Grid.Rows(row).Cells(0).Value = results(row)(0).ToString()
                        rf1Grid.Rows(row).Cells(1).Value = results(row)(1).ToString()
                        rf1Grid.Rows(row).Cells(2).Value = results(row)(2).ToString()
                    Next
                Else
                    MsgBox("No forms in database.", MsgBoxStyle.Exclamation, "Student Affairs Office Rating Forms")
                End If
            Case 1 'Rating Form 2
                If previousForm.Name = "rfPoints" Then
                    query = "SELECT rfid, TitleAct, TWP FROM ceuratingforms.ratingform2 WHERE StudentNo = '" & DirectCast(previousForm, rfPoints).GetNum() & "' and appr = 1"
                Else
                End If
                Dim numResults = count(query, 3)

                If numResults <> 0 Then
                    Dim results = RetrieveQuery(query, 3)
                    Dim row As Integer

                    rf2Grid.RowCount = numResults

                    For row = 0 To numResults - 1
                        rf2Grid.Rows(row).Cells(0).Value = results(row)(0).ToString()
                        rf2Grid.Rows(row).Cells(1).Value = results(row)(1).ToString()
                        rf2Grid.Rows(row).Cells(2).Value = results(row)(2).ToString()
                    Next
                Else
                    MsgBox("No forms in database.", MsgBoxStyle.Exclamation, "Student Affairs Office Rating Forms")
                End If
            Case 2 'Rating Form 3 
                If previousForm.Name = "rfPoints" Then
                    query = "SELECT rfid , TitleAct, TWP FROM ceuratingforms.ratingform3 WHERE StudentNo = '" & DirectCast(previousForm, rfPoints).GetNum() & "' and appr = 1"
                End If
                Dim numResults = count(query, 3)

                If numResults <> 0 Then
                    Dim results = RetrieveQuery(query, 3)
                    Dim row As Integer

                    rf3Grid.RowCount = numResults

                    For row = 0 To numResults - 1
                        rf3Grid.Rows(row).Cells(0).Value = results(row)(0).ToString()
                        rf3Grid.Rows(row).Cells(1).Value = results(row)(1).ToString()
                        rf3Grid.Rows(row).Cells(2).Value = results(row)(2).ToString()
                    Next
                Else
                    MsgBox("No forms in database.", MsgBoxStyle.Exclamation, "Student Affairs Office Rating Forms")
                End If
            Case 3 'Rating Form 4
                If previousForm.Name = "rfPoints" Then
                    query = "SELECT rfid, TitleAct, twp FROM ceuratingforms.ratingform4 WHERE StudentNo = '" & DirectCast(previousForm, rfPoints).GetNum() & "' and appr = 1"
                End If
                Dim numResults = count(query, 3)

                If numResults <> 0 Then
                    Dim results = RetrieveQuery(query, 3)
                    Dim row As Integer

                    rf4Grid.RowCount = numResults

                    For row = 0 To numResults - 1
                        rf4Grid.Rows(row).Cells(0).Value = results(row)(0).ToString()
                        rf4Grid.Rows(row).Cells(1).Value = results(row)(1).ToString()
                        rf4Grid.Rows(row).Cells(2).Value = results(row)(2).ToString()
                    Next
                Else
                    MsgBox("No forms in database.", MsgBoxStyle.Exclamation, "Student Affairs Office Rating Forms")
                End If
            Case 4 'Rating Form 5
                If previousForm.Name = "rfPoints" Then
                    query = "SELECT rfid, Role, twp FROM ceuratingforms.ratingform5 WHERE StudentNo = '" & DirectCast(previousForm, rfPoints).GetNum() & "' and appr = 1"
                End If
                Dim numResults = count(query, 3)

                If numResults <> 0 Then
                    Dim results = RetrieveQuery(query, 3)
                    Dim row As Integer

                    rf5Grid.RowCount = numResults

                    For row = 0 To numResults - 1
                        rf5Grid.Rows(row).Cells(0).Value = results(row)(0).ToString()
                        rf5Grid.Rows(row).Cells(1).Value = results(row)(1).ToString()
                        rf5Grid.Rows(row).Cells(2).Value = results(row)(2).ToString()
                    Next
                Else
                    MsgBox("No forms in database.", MsgBoxStyle.Exclamation, "Student Affairs Office Rating Forms")
                End If
            Case 5 'Rating Form 6
                If previousForm.Name = "rfPoints" Then
                    query = "SELECT rfid, Position, twp FROM ceuratingforms.ratingform6 WHERE StudentNo = '" & DirectCast(previousForm, rfPoints).GetNum() & "' and appr = 1"
                End If
                Dim numResults = count(query, 3)

                If numResults <> 0 Then
                    Dim results = RetrieveQuery(query, 3)
                    rf6Grid.RowCount = numResults
                    Dim row As Integer

                    For row = 0 To numResults - 1
                        rf6Grid.Rows(row).Cells(0).Value = results(row)(0).ToString()
                        rf6Grid.Rows(row).Cells(1).Value = results(row)(1).ToString()
                        rf6Grid.Rows(row).Cells(2).Value = results(row)(2).ToString()
                    Next
                Else
                    MsgBox("No forms in database.", MsgBoxStyle.Exclamation, "Student Affairs Office Rating Forms")
                End If
            Case 6 'Rating Form 7
                If previousForm.Name = "rfPoints" Then
                    query = "SELECT rfid, posit, twp FROM ceuratingforms.ratingform7 WHERE StudentNo = '" & DirectCast(previousForm, rfPoints).GetNum() & "' and appr = 1"
                End If
                Dim numResults = count(query, 3)

                If numResults <> 0 Then
                    Dim results = RetrieveQuery(query, 3)
                    Dim row As Integer

                    rf7Grid.RowCount = numResults
                    For row = 0 To numResults - 1
                        rf7Grid.Rows(row).Cells(0).Value = results(row)(0).ToString()
                        rf7Grid.Rows(row).Cells(1).Value = results(row)(1).ToString()
                        rf7Grid.Rows(row).Cells(2).Value = results(row)(2).ToString()
                    Next
                Else
                    MsgBox("No forms in database.", MsgBoxStyle.Exclamation, "Student Affairs Office Rating Forms")
                End If
        End Select
    End Sub

    Private Sub tilExit_Click(sender As Object, e As EventArgs) Handles tilExit.Click
        previousForm.Enabled = True
        previousForm.Focus()
        Hide()
    End Sub

    Private Sub tabVRF_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tabVRF.SelectedIndexChanged
        displayContent()
    End Sub
End Class