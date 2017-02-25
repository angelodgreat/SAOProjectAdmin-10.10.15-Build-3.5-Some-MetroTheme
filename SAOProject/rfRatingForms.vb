Public Class rfRatingForms


    Dim previousForm As rfPoints

    Public Sub init(ByVal form As Form)
        previousForm = form
    End Sub

    Private Sub rf1points()
        Select Case rf1comLvlAct.SelectedIndex
            Case 0 'College-wide
                Select Case rf1comPosition.SelectedIndex
                    Case 0, 1
                        rf1txtWeight.Text = "10"
                    Case 2, 3, 4, 5, 6
                        rf1txtWeight.Text = "9"
                    Case 7, 8, 9, 10, 11, 12
                        rf1txtWeight.Text = "8"
                    Case 13
                        rf1txtWeight.Text = "6"
                    Case 14, 15, 16
                        rf1txtWeight.Text = "4"
                    Case 17
                        rf1txtWeight.Text = "2"
                    Case Else
                        rf1txtWeight.Text = String.Empty
                End Select
            Case 1
                Select Case rf1comPosition.SelectedIndex
                    Case 0, 1
                        rf1txtWeight.Text = "20"
                    Case 2, 3, 4, 5, 6
                        rf1txtWeight.Text = "16"
                    Case 7, 8, 9, 10, 11, 12
                        rf1txtWeight.Text = "12"
                    Case 13
                        rf1txtWeight.Text = "9"
                    Case 14, 15, 16
                        rf1txtWeight.Text = "6"
                    Case 17
                        rf1txtWeight.Text = "3"
                    Case Else
                        rf1txtWeight.Text = String.Empty
                End Select
            Case 2
                Select Case rf1comPosition.SelectedIndex
                    Case 0, 1
                        rf1txtWeight.Text = "25"
                    Case 2, 3, 4, 5, 6
                        rf1txtWeight.Text = "22"
                    Case 7, 8, 9, 10, 11, 12
                        rf1txtWeight.Text = "19"
                    Case 13
                        rf1txtWeight.Text = "16"
                    Case 14, 15, 16
                        rf1txtWeight.Text = "13"
                    Case 17
                        rf1txtWeight.Text = "10"
                    Case Else
                        rf1txtWeight.Text = String.Empty
                End Select
            Case 3
                Select Case rf1comPosition.SelectedIndex
                    Case 0, 1
                        rf1txtWeight.Text = "30"
                    Case 2, 3, 4, 5, 6
                        rf1txtWeight.Text = "27"
                    Case 7, 8, 9, 10, 11, 12
                        rf1txtWeight.Text = "34"
                    Case 13
                        rf1txtWeight.Text = "21"
                    Case 14, 15, 16
                        rf1txtWeight.Text = "18"
                    Case 17
                        rf1txtWeight.Text = "15"
                    Case Else
                        rf1txtWeight.Text = String.Empty
                End Select
            Case 4
                Select Case rf1comPosition.SelectedIndex
                    Case 0, 1
                        rf1txtWeight.Text = "40"
                    Case 2, 3, 4, 5, 6
                        rf1txtWeight.Text = "37"
                    Case 7, 8, 9, 10, 11, 12
                        rf1txtWeight.Text = "34"
                    Case 13
                        rf1txtWeight.Text = "31"
                    Case 14, 15, 16
                        rf1txtWeight.Text = "28"
                    Case 17
                        rf1txtWeight.Text = "25"
                    Case Else
                        rf1txtWeight.Text = String.Empty
                End Select
            Case Else
                rf1txtWeight.Text = String.Empty
        End Select
        Dim point As Integer = Val(rf1txtPoints.Text)
        Dim weight As Integer = Val(rf1txtWeight.Text)
        rf1txtTWP.Text = point * weight
        txtPoints.Text = point
        txtWeight.Text = weight
        txtTotal.Text = Val(txtTotal.Text) + Val(rf1txtTWP.Text)
    End Sub

    Private Sub rf1comLevel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles rf1comLevel.SelectedIndexChanged
        Select Case rf1comLevel.SelectedIndex
            Case 0
                rf1txtPoints.Text = "5"
            Case 1
                rf1txtPoints.Text = "4"
            Case 2
                rf1txtPoints.Text = "3"
            Case 3
                rf1txtPoints.Text = "2"
            Case 4
                rf1txtPoints.Text = "1"
            Case Else
                rf1txtPoints.Text = String.Empty
        End Select
    End Sub

    Private Sub rf1comLvlAct_SelectedIndexChanged(sender As Object, e As EventArgs) Handles rf1comLvlAct.SelectedIndexChanged
        rf1points()
    End Sub

    Private Sub rf1comPosition_SelectedIndexChanged(sender As Object, e As EventArgs) Handles rf1comPosition.SelectedIndexChanged
        rf1points()
    End Sub
    Private Sub rf2points()
        Select Case rf2comActStat.SelectedIndex
            Case 0
                rf2comSup.Visible = True
                Select Case rf2comSup.SelectedIndex
                    Case 0
                        Select Case rf2comPosition.SelectedIndex
                            Case 0, 1, 2
                                rf2txtWeight.Text = "10"
                            Case 3, 4
                                rf2txtWeight.Text = "8"
                            Case 5, 6
                                rf2txtWeight.Text = "6"
                            Case 7
                                rf2txtWeight.Text = "5"
                            Case 8, 9
                                rf2txtWeight.Text = "3"
                            Case Else
                                rf2txtWeight.Text = String.Empty
                        End Select
                    Case 1
                        Select Case rf2comPosition.SelectedIndex
                            Case 0, 1, 2
                                rf2txtWeight.Text = "12"
                            Case 3, 4
                                rf2txtWeight.Text = "10"
                            Case 5, 6
                                rf2txtWeight.Text = "8"
                            Case 7
                                rf2txtWeight.Text = "7"
                            Case 8, 9
                                rf2txtWeight.Text = "5"
                            Case Else
                                rf2txtWeight.Text = String.Empty
                        End Select
                End Select
            Case 1
                rf2comSup.Visible = False
                Select Case rf2comPosition.SelectedIndex
                    Case 0, 1, 2
                        rf2txtWeight.Text = "8"
                    Case 3, 4
                        rf2txtWeight.Text = "6"
                    Case 5, 6
                        rf2txtWeight.Text = "4"
                    Case 7
                        rf2txtWeight.Text = "3"
                    Case 8, 9
                        rf2txtWeight.Text = "2"
                    Case Else
                        rf2txtWeight.Text = String.Empty
                End Select
            Case Else
                rf2txtWeight.Text = String.Empty
                rf2comSup.Visible = False
        End Select

        Dim points As Integer = Val(rf2txtPoints.Text)
        Dim weight As Integer = Val(rf2txtWeight.Text)
        rf2txtTWP.Text = points * weight
        txtPoints.Text = Val(txtPoints.Text) + points
        txtWeight.Text = Val(txtWeight.Text) + weight
        txtTotal.Text = Val(txtTotal.Text) + Val(rf2txtTWP.Text)
    End Sub

    Private Sub rf2comExt_SelectedIndexChanged(sender As Object, e As EventArgs) Handles rf2comExt.SelectedIndexChanged
        Select Case rf2comExt.SelectedIndex
            Case 0
                rf2txtPoints.Text = "5"
            Case 1
                rf2txtPoints.Text = "4"
            Case 2
                rf2txtPoints.Text = "3"
            Case 3
                rf2txtPoints.Text = "2"
            Case 4
                rf2txtPoints.Text = "1"
            Case Else
                rf2txtWeight.Text = String.Empty
        End Select
    End Sub

    Private Sub rf2comActStat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles rf2comActStat.SelectedIndexChanged
        rf2points()
    End Sub

    Private Sub rf2comSup_SelectedIndexChanged(sender As Object, e As EventArgs) Handles rf2comSup.SelectedIndexChanged
        rf2points()
    End Sub

    Private Sub rf2comPosition_SelectedIndexChanged(sender As Object, e As EventArgs) Handles rf2comPosition.SelectedIndexChanged
        rf2points()
    End Sub
    Private Sub rf3points()
        Select Case rf3comActStat.SelectedIndex
            Case 0
                Select Case rf3comLvlAct.SelectedIndex
                    Case 0
                        rf3txtWeight.Text = "7"
                    Case 1
                        rf3txtWeight.Text = "12"
                    Case 2
                        rf3txtWeight.Text = "17"
                    Case 3
                        rf3txtWeight.Text = "22"
                    Case 4
                        rf3txtWeight.Text = "26"
                    Case Else
                        rf3txtWeight.Text = String.Empty
                End Select
            Case 1
                rf3comPrize.Visible = True
                Select Case rf3comPrize.SelectedIndex
                    Case 0
                        Select Case rf3comLvlAct.SelectedIndex
                            Case 0
                                rf3txtWeight.Text = "15"
                            Case 1
                                rf3txtWeight.Text = "20"
                            Case 2
                                rf3txtWeight.Text = "25"
                            Case 3
                                rf3txtWeight.Text = "30"
                            Case 4
                                rf3txtWeight.Text = "35"
                            Case Else
                                rf3txtWeight.Text = String.Empty
                        End Select
                    Case 1
                        Select Case rf3comLvlAct.SelectedIndex
                            Case 0
                                rf3txtWeight.Text = "13"
                            Case 1
                                rf3txtWeight.Text = "18"
                            Case 2
                                rf3txtWeight.Text = "23"
                            Case 3
                                rf3txtWeight.Text = "28"
                            Case 4
                                rf3txtWeight.Text = "33"
                            Case Else
                                rf3txtWeight.Text = String.Empty
                        End Select
                    Case 2
                        Select Case rf3comLvlAct.SelectedIndex
                            Case 0
                                rf3txtWeight.Text = "10"
                            Case 1
                                rf3txtWeight.Text = "16"
                            Case 2
                                rf3txtWeight.Text = "21"
                            Case 3
                                rf3txtWeight.Text = "26"
                            Case 4
                                rf3txtWeight.Text = "31"
                            Case Else
                                rf3txtWeight.Text = String.Empty
                        End Select
                    Case Else
                        rf3txtWeight.Text = String.Empty
                End Select
        End Select
        Dim points As Integer = Val(rf3txtPoints.Text)
        Dim weight As Integer = Val(rf3txtWeight.Text)
        rf3txtTWP.Text = points * weight
        txtPoints.Text = Val(txtPoints.Text) + points
        txtWeight.Text = Val(txtWeight.Text) + weight
        txtTotal.Text = Val(txtTotal.Text) + Val(rf3txtTWP.Text)
    End Sub

    Private Sub rf3comActStat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles rf3comActStat.SelectedIndexChanged
        rf3points()

    End Sub

    Private Sub rf3comPrize_SelectedIndexChanged(sender As Object, e As EventArgs) Handles rf3comPrize.SelectedIndexChanged
        rf3points()
    End Sub

    Private Sub rf3comLvlAct_SelectedIndexChanged(sender As Object, e As EventArgs) Handles rf3comLvlAct.SelectedIndexChanged
        rf3points()
    End Sub

    Private Sub rf4comNatAct_SelectedIndexChanged(sender As Object, e As EventArgs) Handles rf4comNatAct.SelectedIndexChanged
        Select Case rf4comNatAct.SelectedIndex
            Case 0
                rf4txtPoints.Text = "10"
            Case 1
                rf4txtPoints.Text = "10"
            Case 2
                rf4txtPoints.Text = "10"
            Case 3
                rf4txtPoints.Text = "10"
            Case 4
                rf4txtPoints.Text = "10"
            Case Else
                rf4txtPoints.Text = String.Empty
        End Select
    End Sub
    Private Sub rf4points()
        Select Case rf4comAct.SelectedIndex
            Case 0
                rf4comAward.Visible = False
                Select Case rf4comLvlAct.SelectedIndex
                    Case 0
                        rf4txtWeight.Text = "12"
                    Case 1
                        rf4txtWeight.Text = "15"
                    Case 2
                        rf4txtWeight.Text = "20"
                    Case 3
                        rf4txtWeight.Text = "25"
                    Case 4
                        rf4txtWeight.Text = "30"
                    Case 5
                        rf4txtWeight.Text = "35"
                    Case Else
                        rf4txtWeight.Text = String.Empty
                End Select
            Case 1
                rf4comAward.Visible = True
                Select Case rf4comAward.SelectedIndex
                    Case 0
                        Select Case rf4comLvlAct.SelectedIndex
                            Case 0
                                rf4txtWeight.Text = "25"
                            Case 1
                                rf4txtWeight.Text = "30"
                            Case 2
                                rf4txtWeight.Text = "35"
                            Case 3
                                rf4txtWeight.Text = "40"
                            Case 4
                                rf4txtWeight.Text = "45"
                            Case 5
                                rf4txtWeight.Text = "50"
                            Case Else
                                rf4txtWeight.Text = String.Empty
                        End Select
                    Case 1
                        Select Case rf4comLvlAct.SelectedIndex
                            Case 0
                                rf4txtWeight.Text = "23"
                            Case 1
                                rf4txtWeight.Text = "28"
                            Case 2
                                rf4txtWeight.Text = "33"
                            Case 3
                                rf4txtWeight.Text = "38"
                            Case 4
                                rf4txtWeight.Text = "43"
                            Case 5
                                rf4txtWeight.Text = "48"
                            Case Else
                                rf4txtWeight.Text = String.Empty
                        End Select
                    Case 2
                        Select Case rf4comLvlAct.SelectedIndex
                            Case 0
                                rf4txtWeight.Text = "21"
                            Case 1
                                rf4txtWeight.Text = "26"
                            Case 2
                                rf4txtWeight.Text = "31"
                            Case 3
                                rf4txtWeight.Text = "36"
                            Case 4
                                rf4txtWeight.Text = "41"
                            Case 5
                                rf4txtWeight.Text = "46"
                            Case Else
                                rf4txtWeight.Text = String.Empty
                        End Select
                    Case Else
                        rf4txtWeight.Text = String.Empty
                End Select
            Case Else
                rf4txtWeight.Text = String.Empty
        End Select
        Dim points As Integer = Val(rf4txtPoints.Text)
        Dim weight As Integer = Val(rf4txtWeight.Text)
        rf4txtTWP.Text = points * weight
        txtPoints.Text = Val(txtPoints.Text) + points
        txtWeight.Text = Val(txtWeight.Text) + weight
        txtTotal.Text = Val(txtTotal.Text) + Val(rf4txtTWP.Text)
    End Sub

    Private Sub rf4comLvlAct_SelectedIndexChanged(sender As Object, e As EventArgs) Handles rf4comLvlAct.SelectedIndexChanged
        rf4points()
    End Sub

    Private Sub rf4comAct_SelectedIndexChanged(sender As Object, e As EventArgs) Handles rf4comAct.SelectedIndexChanged
        rf4points()
    End Sub

    Private Sub rf4comAward_SelectedIndexChanged(sender As Object, e As EventArgs) Handles rf4comAward.SelectedIndexChanged
        rf4points()
    End Sub
    Private Sub rf5points()
        Dim inpoints As Integer = 0
        If rf5rbRO1.Checked Then
            inpoints += 1
        End If
        If rf5rbRO2.Checked Then
            inpoints += 2
        End If
        If rf5rbRO3.Checked Then
            inpoints += 3
        End If
        If rf5rbRO4.Checked Then
            inpoints += 4
        End If
        If rf5rbRO5.Checked Then
            inpoints += 5
        End If
        If rf5rbSR1.Checked Then
            inpoints += 1
        End If
        If rf5rbSR2.Checked Then
            inpoints += 2
        End If
        If rf5rbSR3.Checked Then
            inpoints += 3
        End If
        If rf5rbSR4.Checked Then
            inpoints += 4
        End If
        If rf5rbSR5.Checked Then
            inpoints += 5
        End If
        If rf5rbR1.Checked Then
            inpoints += 1
        End If
        If rf5rbR2.Checked Then
            inpoints += 2
        End If
        If rf5rbR3.Checked Then
            inpoints += 3
        End If
        If rf5rbR4.Checked Then
            inpoints += 4
        End If
        If rf5rbR5.Checked Then
            inpoints += 5
        End If
        If rf5rbI1.Checked Then
            inpoints += 1
        End If
        If rf5rbI2.Checked Then
            inpoints += 2
        End If
        If rf5rbI3.Checked Then
            inpoints += 3
        End If
        If rf5rbI4.Checked Then
            inpoints += 4
        End If
        If rf5rbI5.Checked Then
            inpoints += 5
        End If
        If rf5rbC1.Checked Then
            inpoints += 1
        End If
        If rf5rbC2.Checked Then
            inpoints += 2
        End If
        If rf5rbC3.Checked Then
            inpoints += 3
        End If
        If rf5rbC4.Checked Then
            inpoints += 4
        End If
        If rf5rbC5.Checked Then
            inpoints += 5
        End If
        If rf5rbA1.Checked Then
            inpoints += 1
        End If
        If rf5rbA2.Checked Then
            inpoints += 2
        End If
        If rf5rbA3.Checked Then
            inpoints += 3
        End If
        If rf5rbA4.Checked Then
            inpoints += 4
        End If
        If rf5rbA5.Checked Then
            inpoints += 5
        End If
        If rf5rbP1.Checked Then
            inpoints += 1
        End If
        If rf5rbP2.Checked Then
            inpoints += 2
        End If
        If rf5rbP3.Checked Then
            inpoints += 3
        End If
        If rf5rbP4.Checked Then
            inpoints += 4
        End If
        If rf5rbP5.Checked Then
            inpoints += 5
        End If
        rf5txtPoints.Text = inpoints.ToString()
        Dim points As Integer = Val(rf5txtPoints.Text)
        rf5txtTWP.Text = points * 5
        txtPoints.Text = Val(txtPoints.Text) + points
        txtTotal.Text = Val(txtTotal.Text) + Val(rf5txtTWP.Text)
    End Sub

    Private Sub rf5rbRO5_CheckedChanged(sender As Object, e As EventArgs) Handles rf5rbRO5.CheckedChanged
        rf5points()
    End Sub

    Private Sub rf5rbRO4_CheckedChanged(sender As Object, e As EventArgs) Handles rf5rbRO4.CheckedChanged
        rf5points()
    End Sub

    Private Sub rf5rbRO3_CheckedChanged(sender As Object, e As EventArgs) Handles rf5rbRO3.CheckedChanged
        rf5points()
    End Sub

    Private Sub rf5rbRO2_CheckedChanged(sender As Object, e As EventArgs) Handles rf5rbRO2.CheckedChanged
        rf5points()
    End Sub

    Private Sub rf5rbRO1_CheckedChanged(sender As Object, e As EventArgs) Handles rf5rbRO1.CheckedChanged
        rf5points()
    End Sub

    Private Sub rf5rbSR5_CheckedChanged(sender As Object, e As EventArgs) Handles rf5rbSR5.CheckedChanged
        rf5points()
    End Sub

    Private Sub rf5rbSR4_CheckedChanged(sender As Object, e As EventArgs) Handles rf5rbSR4.CheckedChanged
        rf5points()
    End Sub

    Private Sub rf5rbSR3_CheckedChanged(sender As Object, e As EventArgs) Handles rf5rbSR3.CheckedChanged
        rf5points()
    End Sub

    Private Sub rf5rbSR2_CheckedChanged(sender As Object, e As EventArgs) Handles rf5rbSR2.CheckedChanged
        rf5points()
    End Sub

    Private Sub rf5rbSR1_CheckedChanged(sender As Object, e As EventArgs) Handles rf5rbSR1.CheckedChanged
        rf5points()
    End Sub

    Private Sub rf5rbR5_CheckedChanged(sender As Object, e As EventArgs) Handles rf5rbR5.CheckedChanged
        rf5points()
    End Sub

    Private Sub rf5rbR4_CheckedChanged(sender As Object, e As EventArgs) Handles rf5rbR4.CheckedChanged
        rf5points()
    End Sub

    Private Sub rf5rbR3_CheckedChanged(sender As Object, e As EventArgs) Handles rf5rbR3.CheckedChanged
        rf5points()
    End Sub

    Private Sub rf5rbR2_CheckedChanged(sender As Object, e As EventArgs) Handles rf5rbR2.CheckedChanged
        rf5points()
    End Sub

    Private Sub rf5rbR1_CheckedChanged(sender As Object, e As EventArgs) Handles rf5rbR1.CheckedChanged
        rf5points()
    End Sub

    Private Sub rf5rbI5_CheckedChanged(sender As Object, e As EventArgs) Handles rf5rbI5.CheckedChanged
        rf5points()
    End Sub

    Private Sub rf5rbI4_CheckedChanged(sender As Object, e As EventArgs) Handles rf5rbI4.CheckedChanged
        rf5points()
    End Sub

    Private Sub rf5rbI3_CheckedChanged(sender As Object, e As EventArgs) Handles rf5rbI3.CheckedChanged
        rf5points()
    End Sub

    Private Sub rf5rbI2_CheckedChanged(sender As Object, e As EventArgs) Handles rf5rbI2.CheckedChanged
        rf5points()
    End Sub

    Private Sub rf5rbI1_CheckedChanged(sender As Object, e As EventArgs) Handles rf5rbI1.CheckedChanged
        rf5points()
    End Sub

    Private Sub rf5rbC5_CheckedChanged(sender As Object, e As EventArgs) Handles rf5rbC5.CheckedChanged
        rf5points()
    End Sub

    Private Sub rf5rbC4_CheckedChanged(sender As Object, e As EventArgs) Handles rf5rbC4.CheckedChanged
        rf5points()
    End Sub

    Private Sub rf5rbC3_CheckedChanged(sender As Object, e As EventArgs) Handles rf5rbC3.CheckedChanged
        rf5points()
    End Sub

    Private Sub rf5rbC2_CheckedChanged(sender As Object, e As EventArgs) Handles rf5rbC2.CheckedChanged
        rf5points()
    End Sub

    Private Sub rf5rbC1_CheckedChanged(sender As Object, e As EventArgs) Handles rf5rbC1.CheckedChanged
        rf5points()
    End Sub

    Private Sub rf5rbA5_CheckedChanged(sender As Object, e As EventArgs) Handles rf5rbA5.CheckedChanged
        rf5points()
    End Sub

    Private Sub rf5rbA4_CheckedChanged(sender As Object, e As EventArgs) Handles rf5rbA4.CheckedChanged
        rf5points()
    End Sub

    Private Sub rf5rbA3_CheckedChanged(sender As Object, e As EventArgs) Handles rf5rbA3.CheckedChanged
        rf5points()
    End Sub

    Private Sub rf5rbA2_CheckedChanged(sender As Object, e As EventArgs) Handles rf5rbA2.CheckedChanged
        rf5points()
    End Sub

    Private Sub rf5rbA1_CheckedChanged(sender As Object, e As EventArgs) Handles rf5rbA1.CheckedChanged
        rf5points()
    End Sub

    Private Sub rf5rbP5_CheckedChanged(sender As Object, e As EventArgs) Handles rf5rbP5.CheckedChanged
        rf5points()
    End Sub

    Private Sub rf5rbP4_CheckedChanged(sender As Object, e As EventArgs) Handles rf5rbP4.CheckedChanged
        rf5points()
    End Sub

    Private Sub rf5rbP3_CheckedChanged(sender As Object, e As EventArgs) Handles rf5rbP3.CheckedChanged
        rf5points()
    End Sub

    Private Sub rf5rbP2_CheckedChanged(sender As Object, e As EventArgs) Handles rf5rbP2.CheckedChanged
        rf5points()
    End Sub

    Private Sub rf5rbP1_CheckedChanged(sender As Object, e As EventArgs) Handles rf5rbP1.CheckedChanged
        rf5points()
    End Sub
    Private Sub rf6points()
        Dim inpoints As Integer = 0
        If rf6rbRO1.Checked Then
            inpoints += 1
        End If
        If rf6rbRO2.Checked Then
            inpoints += 2
        End If
        If rf6rbRO3.Checked Then
            inpoints += 3
        End If
        If rf6rbRO4.Checked Then
            inpoints += 4
        End If
        If rf6rbRO5.Checked Then
            inpoints += 5
        End If
        If rf6rbSR1.Checked Then
            inpoints += 1
        End If
        If rf6rbSR2.Checked Then
            inpoints += 2
        End If
        If rf6rbSR3.Checked Then
            inpoints += 3
        End If
        If rf6rbSR4.Checked Then
            inpoints += 4
        End If
        If rf6rbSR5.Checked Then
            inpoints += 5
        End If
        If rf6rbR1.Checked Then
            inpoints += 1
        End If
        If rf6rbR2.Checked Then
            inpoints += 2
        End If
        If rf6rbR3.Checked Then
            inpoints += 3
        End If
        If rf6rbR4.Checked Then
            inpoints += 4
        End If
        If rf6rbR5.Checked Then
            inpoints += 5
        End If
        If rf6rbI1.Checked Then
            inpoints += 1
        End If
        If rf6rbI2.Checked Then
            inpoints += 2
        End If
        If rf6rbI3.Checked Then
            inpoints += 3
        End If
        If rf6rbI4.Checked Then
            inpoints += 4
        End If
        If rf6rbI5.Checked Then
            inpoints += 5
        End If
        If rf6rbC1.Checked Then
            inpoints += 1
        End If
        If rf6rbC2.Checked Then
            inpoints += 2
        End If
        If rf6rbC3.Checked Then
            inpoints += 3
        End If
        If rf6rbC4.Checked Then
            inpoints += 4
        End If
        If rf6rbC5.Checked Then
            inpoints += 5
        End If
        If rf6rbA1.Checked Then
            inpoints += 1
        End If
        If rf6rbA2.Checked Then
            inpoints += 2
        End If
        If rf6rbA3.Checked Then
            inpoints += 3
        End If
        If rf6rbA4.Checked Then
            inpoints += 4
        End If
        If rf6rbA5.Checked Then
            inpoints += 5
        End If
        If rf6rbP1.Checked Then
            inpoints += 1
        End If
        If rf6rbP2.Checked Then
            inpoints += 2
        End If
        If rf6rbP3.Checked Then
            inpoints += 3
        End If
        If rf6rbP4.Checked Then
            inpoints += 4
        End If
        If rf6rbP5.Checked Then
            inpoints += 5
        End If
        rf6txtPoints.Text = inpoints
    End Sub

    Private Sub rf6rbRO5_CheckedChanged(sender As Object, e As EventArgs) Handles rf6rbRO5.CheckedChanged
        rf6points()
    End Sub

    Private Sub rf6rbRO4_CheckedChanged(sender As Object, e As EventArgs) Handles rf6rbRO4.CheckedChanged
        rf6points()
    End Sub

    Private Sub rf6rbRO3_CheckedChanged(sender As Object, e As EventArgs) Handles rf6rbRO3.CheckedChanged
        rf6points()
    End Sub

    Private Sub rf6rbRO2_CheckedChanged(sender As Object, e As EventArgs) Handles rf6rbRO2.CheckedChanged
        rf6points()
    End Sub

    Private Sub rf6rbRO1_CheckedChanged(sender As Object, e As EventArgs) Handles rf6rbRO1.CheckedChanged
        rf6points()
    End Sub

    Private Sub rf6rbSR5_CheckedChanged(sender As Object, e As EventArgs) Handles rf6rbSR5.CheckedChanged
        rf6points()
    End Sub

    Private Sub rf6rbSR4_CheckedChanged(sender As Object, e As EventArgs) Handles rf6rbSR4.CheckedChanged
        rf6points()
    End Sub

    Private Sub rf6rbSR3_CheckedChanged(sender As Object, e As EventArgs) Handles rf6rbSR3.CheckedChanged
        rf6points()
    End Sub

    Private Sub rf6rbSR2_CheckedChanged(sender As Object, e As EventArgs) Handles rf6rbSR2.CheckedChanged
        rf6points()
    End Sub

    Private Sub rf6rbSR1_CheckedChanged(sender As Object, e As EventArgs) Handles rf6rbSR1.CheckedChanged
        rf6points()
    End Sub

    Private Sub rf6rbR5_CheckedChanged(sender As Object, e As EventArgs) Handles rf6rbR5.CheckedChanged
        rf6points()
    End Sub

    Private Sub rf6rbR4_CheckedChanged(sender As Object, e As EventArgs) Handles rf6rbR4.CheckedChanged
        rf6points()
    End Sub

    Private Sub rf6rbR3_CheckedChanged(sender As Object, e As EventArgs) Handles rf6rbR3.CheckedChanged
        rf6points()
    End Sub

    Private Sub rf6rbR2_CheckedChanged(sender As Object, e As EventArgs) Handles rf6rbR2.CheckedChanged
        rf6points()
    End Sub

    Private Sub rf6rbR1_CheckedChanged(sender As Object, e As EventArgs) Handles rf6rbR1.CheckedChanged
        rf6points()
    End Sub

    Private Sub rf6rbI5_CheckedChanged(sender As Object, e As EventArgs) Handles rf6rbI5.CheckedChanged
        rf6points()
    End Sub

    Private Sub rf6rbI4_CheckedChanged(sender As Object, e As EventArgs) Handles rf6rbI4.CheckedChanged
        rf6points()
    End Sub

    Private Sub rf6rbI3_CheckedChanged(sender As Object, e As EventArgs) Handles rf6rbI3.CheckedChanged
        rf6points()
    End Sub

    Private Sub rf6rbI2_CheckedChanged(sender As Object, e As EventArgs) Handles rf6rbI2.CheckedChanged
        rf6points()
    End Sub

    Private Sub rf6rbI1_CheckedChanged(sender As Object, e As EventArgs) Handles rf6rbI1.CheckedChanged
        rf6points()
    End Sub

    Private Sub rf6rbC5_CheckedChanged(sender As Object, e As EventArgs) Handles rf6rbC5.CheckedChanged
        rf6points()
    End Sub

    Private Sub rf6rbC4_CheckedChanged(sender As Object, e As EventArgs) Handles rf6rbC4.CheckedChanged
        rf6points()
    End Sub

    Private Sub rf6rbC3_CheckedChanged(sender As Object, e As EventArgs) Handles rf6rbC3.CheckedChanged
        rf6points()
    End Sub

    Private Sub rf6rbC2_CheckedChanged(sender As Object, e As EventArgs) Handles rf6rbC2.CheckedChanged
        rf6points()
    End Sub

    Private Sub rf6rbC1_CheckedChanged(sender As Object, e As EventArgs) Handles rf6rbC1.CheckedChanged
        rf6points()
    End Sub

    Private Sub rf6rbA5_CheckedChanged(sender As Object, e As EventArgs) Handles rf6rbA5.CheckedChanged
        rf6points()
    End Sub

    Private Sub rf6rbA4_CheckedChanged(sender As Object, e As EventArgs) Handles rf6rbA4.CheckedChanged
        rf6points()
    End Sub

    Private Sub rf6rbA3_CheckedChanged(sender As Object, e As EventArgs) Handles rf6rbA3.CheckedChanged
        rf6points()
    End Sub

    Private Sub rf6rbA2_CheckedChanged(sender As Object, e As EventArgs) Handles rf6rbA2.CheckedChanged
        rf6points()
    End Sub

    Private Sub rf6rbA1_CheckedChanged(sender As Object, e As EventArgs) Handles rf6rbA1.CheckedChanged
        rf6points()
    End Sub

    Private Sub rf6rbP5_CheckedChanged(sender As Object, e As EventArgs) Handles rf6rbP5.CheckedChanged
        rf6points()
    End Sub

    Private Sub rf6rbP4_CheckedChanged(sender As Object, e As EventArgs) Handles rf6rbP4.CheckedChanged
        rf6points()
    End Sub

    Private Sub rf6rbP3_CheckedChanged(sender As Object, e As EventArgs) Handles rf6rbP3.CheckedChanged
        rf6points()
    End Sub

    Private Sub rf6rbP2_CheckedChanged(sender As Object, e As EventArgs) Handles rf6rbP2.CheckedChanged
        rf6points()
    End Sub

    Private Sub rf6rbP1_CheckedChanged(sender As Object, e As EventArgs) Handles rf6rbP1.CheckedChanged
        rf6points()
    End Sub
    Private Sub rf6weight()
        Select Case rf6comLvlOf.SelectedIndex
            Case 0
                Select Case rf6comPosition.SelectedIndex
                    Case 0
                        rf6txtWeight.Text = "15"
                    Case 1
                        rf6txtWeight.Text = "12"
                    Case 2
                        rf6txtWeight.Text = "12"
                    Case 3
                        rf6txtWeight.Text = "12"
                    Case 4
                        rf6txtWeight.Text = "10"
                    Case 5
                        rf6txtWeight.Text = "10"
                    Case Else
                        rf6txtWeight.Text = String.Empty
                End Select
            Case 1
                Select Case rf6comPosition.SelectedIndex
                    Case 0
                        rf6txtWeight.Text = "10"
                    Case 1
                        rf6txtWeight.Text = "7"
                    Case 2
                        rf6txtWeight.Text = "7"
                    Case 3
                        rf6txtWeight.Text = "7"
                    Case 4
                        rf6txtWeight.Text = "5"
                    Case 5
                        rf6txtWeight.Text = "5"
                    Case Else
                        rf6txtWeight.Text = String.Empty
                End Select
            Case 2
                rf6comPubOrg.Visible = True
                Select Case rf6comPubOrg.SelectedIndex
                    Case 0
                        Select Case rf6comPosition.SelectedIndex
                            Case 0
                                rf6txtWeight.Text = "12"
                            Case 1
                                rf6txtWeight.Text = "10"
                            Case 2
                                rf6txtWeight.Text = "10"
                            Case 3
                                rf6txtWeight.Text = "10"
                            Case 4
                                rf6txtWeight.Text = "8"
                            Case 5
                                rf6txtWeight.Text = "8"
                            Case 6
                                rf6txtWeight.Text = "6"
                            Case Else
                                rf6txtWeight.Text = String.Empty
                        End Select
                    Case 1
                        Select Case rf6comPosition.SelectedIndex
                            Case 0
                                rf6txtWeight.Text = "9"
                            Case 1
                                rf6txtWeight.Text = "7"
                            Case 2
                                rf6txtWeight.Text = "7"
                            Case 3
                                rf6txtWeight.Text = "7"
                            Case 4
                                rf6txtWeight.Text = "5"
                            Case 5
                                rf6txtWeight.Text = "5"
                            Case Else
                                rf6txtWeight.Text = String.Empty
                        End Select
                    Case 2
                        Select Case rf6comPosition.SelectedIndex
                            Case 0
                                rf6txtWeight.Text = "6"
                            Case 1
                                rf6txtWeight.Text = "4"
                            Case 2
                                rf6txtWeight.Text = "4"
                            Case 3
                                rf6txtWeight.Text = "4"
                            Case 4
                                rf6txtWeight.Text = "2"
                            Case 5
                                rf6txtWeight.Text = "2"
                            Case Else
                                rf6txtWeight.Text = String.Empty
                        End Select
                End Select

        End Select
        Dim points As Integer = Val(rf6txtPoints.Text)
        Dim weight As Integer = Val(rf6txtWeight.Text)
        rf6txtTWP.Text = points * weight
        txtPoints.Text = Val(txtPoints.Text) + points
        txtWeight.Text = Val(txtWeight.Text) + weight
        txtTotal.Text = Val(txtTotal.Text) + Val(rf6txtTWP.Text)

    End Sub

    Private Sub rf6comPosition_SelectedIndexChanged(sender As Object, e As EventArgs) Handles rf6comPosition.SelectedIndexChanged
        rf6weight()
    End Sub

    Private Sub rf6comLvlOf_SelectedIndexChanged(sender As Object, e As EventArgs) Handles rf6comLvlOf.SelectedIndexChanged
        rf6weight()
    End Sub

    Private Sub rf6comPubOrg_SelectedIndexChanged(sender As Object, e As EventArgs) Handles rf6comPubOrg.SelectedIndexChanged
        rf6weight()
    End Sub
    Private Sub rf7points()
        Dim inpoints As Integer = 0
        If rf7rbRO1.Checked Then
            inpoints += 1
        End If
        If rf7rbRO2.Checked Then
            inpoints += 2
        End If
        If rf7rbRO3.Checked Then
            inpoints += 3
        End If
        If rf7rbRO4.Checked Then
            inpoints += 4
        End If
        If rf7rbRO5.Checked Then
            inpoints += 5
        End If
        If rf7rbSR1.Checked Then
            inpoints += 1
        End If
        If rf7rbSR2.Checked Then
            inpoints += 2
        End If
        If rf7rbSR3.Checked Then
            inpoints += 3
        End If
        If rf7rbSR4.Checked Then
            inpoints += 4
        End If
        If rf7rbSR5.Checked Then
            inpoints += 5
        End If
        If rf7rbR1.Checked Then
            inpoints += 1
        End If
        If rf7rbR2.Checked Then
            inpoints += 2
        End If
        If rf7rbR3.Checked Then
            inpoints += 3
        End If
        If rf7rbR4.Checked Then
            inpoints += 4
        End If
        If rf7rbR5.Checked Then
            inpoints += 5
        End If
        If rf7rbI1.Checked Then
            inpoints += 1
        End If
        If rf7rbI2.Checked Then
            inpoints += 2
        End If
        If rf7rbI3.Checked Then
            inpoints += 3
        End If
        If rf7rbI4.Checked Then
            inpoints += 4
        End If
        If rf7rbI5.Checked Then
            inpoints += 5
        End If
        If rf7rbC1.Checked Then
            inpoints += 1
        End If
        If rf7rbC2.Checked Then
            inpoints += 2
        End If
        If rf7rbC3.Checked Then
            inpoints += 3
        End If
        If rf7rbC4.Checked Then
            inpoints += 4
        End If
        If rf7rbC5.Checked Then
            inpoints += 5
        End If
        If rf7rbA1.Checked Then
            inpoints += 1
        End If
        If rf7rbA2.Checked Then
            inpoints += 2
        End If
        If rf7rbA3.Checked Then
            inpoints += 3
        End If
        If rf7rbA4.Checked Then
            inpoints += 4
        End If
        If rf7rbA5.Checked Then
            inpoints += 5
        End If
        If rf7rbP1.Checked Then
            inpoints += 1
        End If
        If rf7rbP2.Checked Then
            inpoints += 2
        End If
        If rf7rbP3.Checked Then
            inpoints += 3
        End If
        If rf7rbP4.Checked Then
            inpoints += 4
        End If
        If rf7rbP5.Checked Then
            inpoints += 5
        End If
        rf7txtPoints.Text = inpoints
    End Sub

    Private Sub rf7rbRO5_CheckedChanged(sender As Object, e As EventArgs) Handles rf7rbRO5.CheckedChanged
        rf7points()
    End Sub

    Private Sub rf7rbRO4_CheckedChanged(sender As Object, e As EventArgs) Handles rf7rbRO4.CheckedChanged
        rf7points()
    End Sub

    Private Sub rf7rbRO3_CheckedChanged(sender As Object, e As EventArgs) Handles rf7rbRO3.CheckedChanged
        rf7points()
    End Sub

    Private Sub rf7rbRO2_CheckedChanged(sender As Object, e As EventArgs) Handles rf7rbRO2.CheckedChanged
        rf7points()
    End Sub

    Private Sub rf7rbRO1_CheckedChanged(sender As Object, e As EventArgs) Handles rf7rbRO1.CheckedChanged
        rf7points()
    End Sub

    Private Sub rf7rbSR5_CheckedChanged(sender As Object, e As EventArgs) Handles rf7rbSR5.CheckedChanged
        rf7points()
    End Sub

    Private Sub rf7rbSR4_CheckedChanged(sender As Object, e As EventArgs) Handles rf7rbSR4.CheckedChanged
        rf7points()
    End Sub

    Private Sub rf7rbSR3_CheckedChanged(sender As Object, e As EventArgs) Handles rf7rbSR3.CheckedChanged
        rf7points()
    End Sub

    Private Sub rf7rbSR2_CheckedChanged(sender As Object, e As EventArgs) Handles rf7rbSR2.CheckedChanged
        rf7points()
    End Sub

    Private Sub rf7rbSR1_CheckedChanged(sender As Object, e As EventArgs) Handles rf7rbSR1.CheckedChanged
        rf7points()
    End Sub

    Private Sub rf7rbR5_CheckedChanged(sender As Object, e As EventArgs) Handles rf7rbR5.CheckedChanged
        rf7points()
    End Sub

    Private Sub rf7rbR4_CheckedChanged(sender As Object, e As EventArgs) Handles rf7rbR4.CheckedChanged
        rf7points()
    End Sub

    Private Sub rf7rbR3_CheckedChanged(sender As Object, e As EventArgs) Handles rf7rbR3.CheckedChanged
        rf7points()
    End Sub

    Private Sub rf7rbR2_CheckedChanged(sender As Object, e As EventArgs) Handles rf7rbR2.CheckedChanged
        rf7points()
    End Sub

    Private Sub rf7rbR1_CheckedChanged(sender As Object, e As EventArgs) Handles rf7rbR1.CheckedChanged
        rf7points()
    End Sub

    Private Sub rf7rbI5_CheckedChanged(sender As Object, e As EventArgs) Handles rf7rbI5.CheckedChanged
        rf7points()
    End Sub

    Private Sub rf7rbI4_CheckedChanged(sender As Object, e As EventArgs) Handles rf7rbI4.CheckedChanged
        rf7points()
    End Sub

    Private Sub rf7rbI3_CheckedChanged(sender As Object, e As EventArgs) Handles rf7rbI3.CheckedChanged
        rf7points()
    End Sub

    Private Sub rf7rbI2_CheckedChanged(sender As Object, e As EventArgs) Handles rf7rbI2.CheckedChanged
        rf7points()
    End Sub

    Private Sub rf7rbI1_CheckedChanged(sender As Object, e As EventArgs) Handles rf7rbI1.CheckedChanged
        rf7points()
    End Sub

    Private Sub rf7rbC5_CheckedChanged(sender As Object, e As EventArgs) Handles rf7rbC5.CheckedChanged
        rf7points()
    End Sub

    Private Sub rf7rbC4_CheckedChanged(sender As Object, e As EventArgs) Handles rf7rbC4.CheckedChanged
        rf7points()
    End Sub

    Private Sub rf7rbC3_CheckedChanged(sender As Object, e As EventArgs) Handles rf7rbC3.CheckedChanged
        rf7points()
    End Sub

    Private Sub rf7rbC2_CheckedChanged(sender As Object, e As EventArgs) Handles rf7rbC2.CheckedChanged
        rf7points()
    End Sub

    Private Sub rf7rbC1_CheckedChanged(sender As Object, e As EventArgs) Handles rf7rbC1.CheckedChanged
        rf7points()
    End Sub

    Private Sub rf7rbA5_CheckedChanged(sender As Object, e As EventArgs) Handles rf7rbA5.CheckedChanged
        rf7points()
    End Sub

    Private Sub rf7rbA4_CheckedChanged(sender As Object, e As EventArgs) Handles rf7rbA4.CheckedChanged
        rf7points()
    End Sub

    Private Sub rf7rbA3_CheckedChanged(sender As Object, e As EventArgs) Handles rf7rbA3.CheckedChanged
        rf7points()
    End Sub

    Private Sub rf7rbA2_CheckedChanged(sender As Object, e As EventArgs) Handles rf7rbA2.CheckedChanged
        rf7points()
    End Sub

    Private Sub rf7rbA1_CheckedChanged(sender As Object, e As EventArgs) Handles rf7rbA1.CheckedChanged
        rf7points()
    End Sub

    Private Sub rf7rbP5_CheckedChanged(sender As Object, e As EventArgs) Handles rf7rbP5.CheckedChanged
        rf7points()
    End Sub

    Private Sub rf7rbP4_CheckedChanged(sender As Object, e As EventArgs) Handles rf7rbP4.CheckedChanged
        rf7points()
    End Sub

    Private Sub rf7rbP3_CheckedChanged(sender As Object, e As EventArgs) Handles rf7rbP3.CheckedChanged
        rf7points()
    End Sub

    Private Sub rf7rbP2_CheckedChanged(sender As Object, e As EventArgs) Handles rf7rbP2.CheckedChanged
        rf7points()
    End Sub

    Private Sub rf7rbP1_CheckedChanged(sender As Object, e As EventArgs) Handles rf7rbP1.CheckedChanged
        rf7points()
    End Sub

    Private Sub rf7comPosition_SelectedIndexChanged(sender As Object, e As EventArgs) Handles rf7comPosition.SelectedIndexChanged
        Select Case rf7comPosition.SelectedIndex
            Case 0
                rf7txtWeight.Text = "20"
            Case 1
                rf7txtWeight.Text = "17"
            Case 2
                rf7txtWeight.Text = "17"
            Case 3
                rf7txtWeight.Text = "17"
            Case 4
                rf7txtWeight.Text = "17"
            Case 5
                rf7txtWeight.Text = "17"
            Case 6
                rf7txtWeight.Text = "17"
            Case 7
                rf7txtWeight.Text = "15"
            Case 8
                rf7txtWeight.Text = "15"
            Case 9
                rf7txtWeight.Text = "15"
            Case 10
                rf7txtWeight.Text = "15"
        End Select

    End Sub

    Private Sub Reset(ByVal index As Integer)
        txtPoints.Text = String.Empty
        txtWeight.Text = String.Empty
        txtTotal.Text = String.Empty

        Select Case index
            Case 0
                rf1txtTitle.Text = String.Empty
                rf1comLevel.SelectedIndex = -1
                rf1comLvlAct.SelectedIndex = -1
                rf1comPosition.SelectedIndex = -1
                rf1txtPoints.Text = String.Empty
                rf1txtWeight.Text = String.Empty
                rf1txtTWP.Text = String.Empty
            Case 1
                rf2txtTitle.Text = String.Empty
                rf2comExt.SelectedIndex = -1
                rf2comActStat.SelectedIndex = -1
                rf2comPosition.SelectedIndex = -1
                rf2txtPoints.Text = String.Empty
                rf2txtWeight.Text = String.Empty
                rf2txtTWP.Text = String.Empty
            Case 2
                rf3txtTitle.Text = String.Empty
                rf3comLvlAct.SelectedIndex = -1
                rf3comActStat.SelectedIndex = -1
                rf3comPrize.SelectedIndex = -1
                rf3comNatAct.SelectedIndex = -1
                rf3txtPoints.Text = String.Empty
                rf3txtWeight.Text = String.Empty
                rf3txtTWP.Text = String.Empty
            Case 3
                rf4txtTitle.Text = String.Empty
                rf4comNatAct.SelectedIndex = -1
                rf4comAct.SelectedIndex = -1
                rf4comLvlAct.SelectedIndex = -1
                rf4txtPoints.Text = String.Empty
                rf4txtWeight.Text = String.Empty
                rf4txtTWP.Text = String.Empty
            Case 4
                For Each panel As Control In tabRF5.Controls
                    If TypeOf panel Is MetroFramework.Controls.MetroPanel Then
                        For Each button As Control In panel.Controls
                            If TypeOf button Is MetroFramework.Controls.MetroRadioButton Then
                                DirectCast(button, MetroFramework.Controls.MetroRadioButton).Checked = False
                            End If
                        Next

                    End If
                Next
                rf5txtPoints.Text = String.Empty
                rf5txtWeight.Text = String.Empty
                rf5txtTWP.Text = String.Empty
            Case 5
                For Each panel As Control In tabRF6.Controls
                    If TypeOf panel Is MetroFramework.Controls.MetroPanel Then
                        For Each button As Control In panel.Controls
                            If TypeOf button Is MetroFramework.Controls.MetroRadioButton Then
                                DirectCast(button, MetroFramework.Controls.MetroRadioButton).Checked = False
                            End If
                        Next

                    End If
                Next
                rf6txtPoints.Text = String.Empty
                rf6txtWeight.Text = String.Empty
                rf6txtTWP.Text = String.Empty
            Case 6
                For Each panel As Control In tabRF7.Controls
                    If TypeOf panel Is MetroFramework.Controls.MetroPanel Then
                        For Each button As Control In panel.Controls
                            If TypeOf button Is MetroFramework.Controls.MetroRadioButton Then
                                DirectCast(button, MetroFramework.Controls.MetroRadioButton).Checked = False
                            End If
                        Next
                    End If
                Next
                rf7comPosition.SelectedIndex = -1
                rf7txtPoints.Text = String.Empty
                rf7txtWeight.Text = String.Empty
                rf7txtIP.Text = String.Empty
                rf7txtTWP.Text = String.Empty
        End Select
    End Sub

    Private Sub tilClose_Click(sender As Object, e As EventArgs) Handles tilClose.Click
        previousForm.Enabled = True
        previousForm.Focus()
        Hide()
    End Sub

    Private Sub tilClear_Click(sender As Object, e As EventArgs) Handles tilClear.Click
        Reset(tabForms.SelectedIndex)
    End Sub

    Private Sub frmForms_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblrfstudno.Text = previousForm.GetNum
        lblrfstudname.Text = previousForm.GetName
    End Sub

    Private Sub tilSave_Click(sender As Object, e As EventArgs) Handles tilSave.Click
        Save(tabForms.SelectedIndex)
    End Sub

    Public Function GetRemarks(ByVal points As Integer) As String
        Dim ct As Integer
        Dim gold As Integer
        Dim sil As Integer
        Dim bro As Integer
        query = "Select minPoint from ceuratingforms.points_ranges where award = 'Gold'; "
        ct = count(query, 1)
        If ct <> 0 Then
            Dim ggeld = RetrieveQuery(query, 1)
            gold = ggeld(0)(0).ToString
        End If
        query = "Select minPoint from ceuratingforms.points_ranges where award = 'Silver'; "
        ct = count(query, 1)
        If ct <> 0 Then
            Dim gsil = RetrieveQuery(query, 1)
            sil = gsil(0)(0).ToString
        End If
        query = "Select minPoint from ceuratingforms.points_ranges where award = 'Bronze'; "
        ct = count(query, 1)
        If ct <> 0 Then
            Dim gbro = RetrieveQuery(query, 1)
            bro = gbro(0)(0).ToString
        End If
        MsgBox(gold + sil + bro)
        Dim remarks As String = String.Empty
        If points >= gold Then
            remarks = "Gold"
        ElseIf points >= sil Then
            remarks = "Silver"

        ElseIf points >= bro Then
            remarks = "Bronze"
        ElseIf points >= 0 Then
            remarks = String.Empty
        Else
            MsgBox("Error")
        End If
        Return remarks
    End Function

    Private Sub rf7txtIP_TextChanged(sender As Object, e As EventArgs) Handles rf7txtIP.TextChanged
        Dim points As Integer = Val(rf7txtPoints.Text)
        Dim weight As Integer = Val(rf7txtWeight.Text)
        Dim incen As Integer = Val(rf7txtIP.Text)
        rf7txtTWP.Text = points * weight + incen
        txtPoints.Text = Val(txtPoints.Text) + points
        txtWeight.Text = Val(txtWeight.Text) + weight
        txtTotal.Text = Val(txtTotal.Text) + Val(rf7txtTWP.Text)
    End Sub

    Private Sub tilSaveAll_Click(sender As Object, e As EventArgs) Handles tilSaveAll.Click

        For index As Integer = 0 To 6
            Save(index)
        Next
    End Sub
    Public Sub Save(ByVal index As Integer)

        Dim approve As Integer = 1

        If GetAccess() <> "Admin" Then
            approve = 0
        End If

        Select Case tabForms.SelectedIndex
            Case 0
                If String.IsNullOrEmpty(rf1txtTitle.Text) Then
                    tipError.Show("Please enter title of activity.", rf1txtTitle)
                    rf1txtTitle.Select()
                ElseIf rf1comLevel.SelectedIndex = -1 Then
                    tipError.Show("Please select level of performance.", rf1comLevel)
                    rf1comLevel.Select()
                ElseIf rf1comLvlAct.SelectedIndex = -1 Then
                    tipError.Show("Please select level of activity.", rf1comLvlAct)
                    rf1comLvlAct.Select()
                ElseIf rf1comPosition.SelectedIndex = -1 Then
                    tipError.Show("Please select position.", rf1comPosition)
                    rf1comPosition.Select()
                Else
                    Dim title = rf1txtTitle.Text
                    Dim level = rf1comLevel.SelectedItem.ToString
                    Dim act = rf1comLvlAct.SelectedItem.ToString
                    Dim pos = rf1comPosition.SelectedItem.ToString
                    Dim rf1point = Val(rf1txtPoints.Text)
                    Dim rf1weight = Val(rf1txtWeight.Text)
                    Dim rf1total = Val(rf1txtTWP.Text)
                    Dim answer As MsgBoxResult
                    If GetAccess() <> "Admin" Then
                        answer = MsgBox("Are you sure to submit this form?", MsgBoxStyle.YesNo, "")
                    End If

                    If GetAccess() = "Admin" Or answer = MsgBoxResult.Yes Then
                        Dim query As String = "INSERT INTO ceuratingforms.ratingform1 VALUES(DEFAULT,'" & previousForm.GetNum() & "' , '" & title & "', '" & level & "', '" & act & "' , '" & pos & "'," & rf1point & ", " & rf1weight & ", " & rf1total & " , " & approve & ")"

                        If ExecuteQuery(query) Then
                            If approve = 1 Then
                                Dim totalPoints As Integer = previousForm.GetPoints() + rf1total
                                Dim remarks = GetRemarks(totalPoints)
                                MsgBox("Form Added!")
                                query = "UPDATE ceuratingforms.pointsinfo SET TotalPoints = " & totalPoints & " , Remarks = '" & remarks & "' WHERE StudNo = '" & previousForm.GetNum() & "'"
                                If ExecuteQuery(query) Then
                                    MsgBox("Points Added!")

                                    previousForm.SetPoints(totalPoints)
                                    previousForm.setRemarks(remarks)
                                End If
                            End If
                            Reset(tabForms.SelectedIndex)
                        End If
                    End If
                End If
            Case 1 'RatingForm2
                If String.IsNullOrEmpty(rf2txtTitle.Text) Then
                    tipError.Show("Please enter title of activity.", rf2txtTitle)
                    rf2txtTitle.Select()
                ElseIf rf2comExt.SelectedIndex = -1 Then
                    tipError.Show("Please select extent of involvement.", rf2comExt)
                    rf2comExt.Select()

                ElseIf rf2comActStat.SelectedIndex = -1 Then
                    tipError.Show("Please select activity status.", rf2comActStat)
                    rf2comActStat.Select()
                ElseIf rf2comActStat.SelectedIndex = 1 Then
                    If rf2comSup.SelectedIndex = -1 Then
                        tipError.Show("Please select supervision.", rf2comSup)
                        rf2comSup.Select()
                    End If
                ElseIf rf2comPosition.SelectedIndex = -1 Then
                    tipError.Show("Please select position/role.", rf2comPosition)
                    rf2comPosition.Select()
                Else
                    Dim act2 As String
                    Dim title = rf2txtTitle.Text
                    Dim level = rf2comExt.SelectedItem.ToString
                    Dim act = rf2comActStat.SelectedItem.ToString
                    If rf2comSup.SelectedIndex Then
                        act2 = rf2comSup.SelectedItem.ToString
                    End If
                    Dim pos = rf2comPosition.SelectedItem.ToString
                    Dim rf2point = Val(rf2txtPoints.Text)
                    Dim rf2weight = Val(rf2txtWeight.Text)
                        Dim rf2total = Val(rf2txtTWP.Text)
                        Dim answer As MsgBoxResult
                        If GetAccess() <> "Admin" Then
                            answer = MsgBox("Are you sure to submit this form?", MsgBoxStyle.YesNo, "")
                        End If
                        If GetAccess() = "Admin" Or answer = MsgBox("Are you sure to submit this form?", MsgBoxStyle.YesNo, "") Then
                            Dim query As String = "INSERT INTO ceuratingforms.ratingform2 VALUES(DEFAULT,'" & previousForm.GetNum() & "' , '" & title & "', '" & level & "', '" & act & "','" & act2 & "' ,'" & pos & "'," & rf2point & ", " & rf2weight & ", " & rf2total & " , " & approve & ")"

                            If ExecuteQuery(query) Then
                                If approve = 1 Then
                                    Dim totalPoints As Integer = previousForm.GetPoints() + rf2total
                                    Dim remarks = GetRemarks(totalPoints)

                                    MsgBox("Form Added!")
                                    query = "UPDATE ceuratingforms.pointsinfo SET TotalPoints = " & totalPoints & " , Remarks = '" & remarks & "' WHERE StudNo = '" & previousForm.GetNum() & "'"
                                    If ExecuteQuery(query) Then
                                        MsgBox("Points Added!")
                                        Reset(tabForms.SelectedIndex)
                                        previousForm.SetPoints(totalPoints)
                                        previousForm.setRemarks(remarks)
                                    End If

                                End If
                            End If
                        End If
                    End If
                    Case 2 'Rating Form 3
                If String.IsNullOrEmpty(rf3txtTitle.Text) Then
                    tipError.Show("Please enter title of activity.", rf3txtTitle)
                    rf3txtTitle.Select()
                ElseIf rf3comNatAct.SelectedIndex = -1 Then
                    tipError.Show("Please select nature of activity.", rf3comNatAct)
                    rf3comNatAct.Select()
                ElseIf rf3comActStat.SelectedIndex = -1 Then
                    tipError.Show("Please select activity status.", rf3comActStat)
                    rf3comActStat.Select()
                ElseIf rf3comActStat.SelectedIndex = 1 Then
                    If rf3comPrize.SelectedIndex = -1 Then
                        tipError.Show("Please select place.", rf3comPrize)
                        rf3comPrize.Select()
                    End If
                ElseIf rf3comLvlAct.SelectedIndex = -1 Then
                    tipError.Show("Please select level of activity.", rf3comLvlAct)
                    rf3comLvlAct.Select()
                ElseIf String.IsNullOrEmpty(rf3txtPoints.Text) Then
                    tipError.Show("Please enter points.", rf3txtPoints)
                    rf3txtPoints.Select()
                Else
                    Dim act2 As String
                    Dim title = rf3txtTitle.Text
                    Dim level = rf3comNatAct.SelectedItem.ToString
                    Dim act = rf3comActStat.SelectedItem.ToString
                    If rf3comPrize.SelectedIndex Then
                        act2 = rf3comPrize.SelectedItem.ToString
                    End If

                    Dim pos = rf3comLvlAct.SelectedItem.ToString
                    Dim rf3point = Val(rf3txtPoints.Text)
                    Dim rf3weight = Val(rf3txtWeight.Text)
                    Dim rf3total = Val(rf3txtTWP.Text)
                    Dim answer As MsgBoxResult
                    If GetAccess() <> "Admin" Then
                        answer = MsgBox("Are you sure to submit this form?", MsgBoxStyle.YesNo, "")
                    End If
                    If GetAccess() = "Admin" Or answer = MsgBoxResult.Yes Then
                        Dim query As String = "INSERT INTO ceuratingforms.ratingform3 VALUES(DEFAULT,'" & previousForm.GetNum() & "' , '" & title & "', '" & level & "', '" & act & "','" & act2 & "' ,'" & pos & "'," & rf3point & ", " & rf3weight & ", " & rf3total & " , " & approve & ")"
                        If ExecuteQuery(query) Then
                            If approve = 1 Then
                                Dim totalPoints As Integer = previousForm.GetPoints() + rf3total
                                Dim remarks = GetRemarks(totalPoints)


                                MsgBox("Form Added!")
                                query = "UPDATE ceuratingforms.pointsinfo SET TotalPoints = " & totalPoints & " , Remarks = '" & remarks & "' WHERE StudNo = '" & previousForm.GetNum() & "'"
                                If ExecuteQuery(query) Then
                                    MsgBox("Points Added!")

                                    previousForm.SetPoints(totalPoints)
                                    previousForm.setRemarks(remarks)
                                End If
                            End If
                            Reset(tabForms.SelectedIndex)
                        End If
                    End If
                End If
            Case 3 'Rating Form4
                If String.IsNullOrEmpty(rf4txtTitle.Text) Then
                    tipError.Show("Please enter title of activity.", rf4txtTitle)
                    rf4txtTitle.Select()
                ElseIf rf4comNatAct.SelectedIndex = -1 Then
                    tipError.Show("Please select nature of activity.", rf4comNatAct)
                    rf4comNatAct.Select()
                ElseIf rf4comAct.SelectedIndex = -1 Then
                    tipError.Show("Please select activity status.", rf4comAct)
                    rf4comAct.Select()
                ElseIf rf4comAct.SelectedIndex = 1 Then
                    If rf4comAward.SelectedIndex = -1 Then
                        tipError.Show("Please select place.", rf4comAward)
                        rf4comAward.Select()
                    End If
                ElseIf rf4comLvlAct.SelectedIndex = -1 Then
                    tipError.Show("Please select level of activity.", rf4comLvlAct)
                    rf4comLvlAct.Select()
                Else
                    Dim act2 As String
                    Dim title = rf4txtTitle.Text
                    Dim level = rf4comNatAct.SelectedItem.ToString
                    Dim act = rf4comAct.SelectedItem.ToString
                    If rf4comAward.SelectedIndex Then
                        act2 = rf4comAward.SelectedItem.ToString
                    End If
                    Dim pos = rf4comLvlAct.SelectedItem.ToString
                    Dim rf4point = Val(rf4txtPoints.Text)
                    Dim rf4weight = Val(rf4txtWeight.Text)
                    Dim rf4total = Val(rf4txtTWP.Text)
                    Dim answer As MsgBoxResult
                    If GetAccess() <> "Admin" Then
                        answer = MsgBox("Are you sure to submit this form?", MsgBoxStyle.YesNo, "")
                    End If
                    If GetAccess() = "Admin" Or answer = MsgBoxResult.Yes Then
                        Dim query As String = "INSERT INTO ceuratingforms.ratingform4 VALUES(DEFAULT,'" & previousForm.GetNum() & "' , '" & title & "', '" & level & "', '" & act & "','" & act2 & "' ,'" & pos & "'," & rf4point & ", " & rf4weight & ", " & rf4total & " , " & approve & ")"
                        If ExecuteQuery(query) Then
                            If approve = 1 Then
                                Dim totalPoints As Integer = previousForm.GetPoints() + rf4total
                                Dim remarks = GetRemarks(totalPoints)
                                query = "UPDATE ceuratingforms.pointsinfo SET TotalPoints = " & totalPoints & " , Remarks = '" & remarks & "' WHERE StudNo = '" & previousForm.GetNum() & "'"
                                If ExecuteQuery(query) Then
                                    MsgBox("Points Added!")

                                    previousForm.SetPoints(totalPoints)
                                    previousForm.setRemarks(remarks)
                                End If
                            End If
                            Reset(tabForms.SelectedIndex)
                        End If
                    End If
                End If

            Case 4 'RatingForm5
                Dim panel1, panel2, panel3, panel4, panel5, panel6, panel7 As String
                For Each button In rf5Panel1.Controls
                    If TypeOf button Is MetroFramework.Controls.MetroRadioButton Then
                        If DirectCast(button, MetroFramework.Controls.MetroRadioButton).Checked Then
                            panel1 = DirectCast(button, MetroFramework.Controls.MetroRadioButton).Name.ToString()
                        End If
                    End If
                Next
                For Each button In rf5Panel2.Controls
                    If TypeOf button Is MetroFramework.Controls.MetroRadioButton Then
                        If DirectCast(button, MetroFramework.Controls.MetroRadioButton).Checked Then
                            panel2 = DirectCast(button, MetroFramework.Controls.MetroRadioButton).Name.ToString()
                        End If
                    End If
                Next
                For Each button In rf5Panel3.Controls
                    If TypeOf button Is MetroFramework.Controls.MetroRadioButton Then
                        If DirectCast(button, MetroFramework.Controls.MetroRadioButton).Checked Then
                            panel3 = DirectCast(button, MetroFramework.Controls.MetroRadioButton).Name.ToString()
                        End If
                    End If
                Next
                For Each button In rf5Panel4.Controls
                    If TypeOf button Is MetroFramework.Controls.MetroRadioButton Then
                        If DirectCast(button, MetroFramework.Controls.MetroRadioButton).Checked Then
                            panel4 = DirectCast(button, MetroFramework.Controls.MetroRadioButton).Name.ToString()
                        End If
                    End If
                Next
                For Each button In rf5Panel5.Controls
                    If TypeOf button Is MetroFramework.Controls.MetroRadioButton Then
                        If DirectCast(button, MetroFramework.Controls.MetroRadioButton).Checked Then
                            panel5 = DirectCast(button, MetroFramework.Controls.MetroRadioButton).Name.ToString()
                        End If
                    End If
                Next
                For Each button In rf5Panel6.Controls
                    If TypeOf button Is MetroFramework.Controls.MetroRadioButton Then
                        If DirectCast(button, MetroFramework.Controls.MetroRadioButton).Checked Then
                            panel6 = DirectCast(button, MetroFramework.Controls.MetroRadioButton).Name.ToString()
                        End If
                    End If
                Next
                For Each button In rf5Panel7.Controls
                    If TypeOf button Is MetroFramework.Controls.MetroRadioButton Then
                        If DirectCast(button, MetroFramework.Controls.MetroRadioButton).Checked Then
                            panel7 = DirectCast(button, MetroFramework.Controls.MetroRadioButton).Name.ToString()
                        End If
                    End If
                Next

                If String.IsNullOrEmpty(panel1) Then
                    tipError.Show("Please select rating.", rf5Panel1)
                    rf5Panel1.Select()
                ElseIf String.IsNullOrEmpty(panel2) Then
                    tipError.Show("Please select rating.", rf5Panel2)
                    rf5Panel2.Select()
                ElseIf String.IsNullOrEmpty(panel3) Then
                    tipError.Show("Please select rating.", rf5Panel3)
                    rf5Panel3.Select()
                ElseIf String.IsNullOrEmpty(panel4) Then
                    tipError.Show("Please select rating.", rf5Panel4)
                    rf5Panel4.Select()
                ElseIf String.IsNullOrEmpty(panel5) Then
                    tipError.Show("Please select rating.", rf5Panel5)
                    rf5Panel5.Select()
                ElseIf String.IsNullOrEmpty(panel6) Then
                    tipError.Show("Please select rating.", rf5Panel6)
                    rf5Panel6.Select()
                ElseIf String.IsNullOrEmpty(panel7) Then
                    tipError.Show("Please select rating.", rf5Panel7)
                    rf5Panel7.Select()
                ElseIf rf5comRole.SelectedIndex = -1 Then
                    tipError.Show("Please select role.", rf5comRole)
                    rf5comRole.Select()
                Else
                    Dim rf5point = Val(rf5txtPoints.Text)
                    Dim rf5total = Val(rf5txtTWP.Text)
                    Dim pos = rf5comRole.SelectedItem.ToString
                    Dim answer As MsgBoxResult
                    If GetAccess() <> "Admin" Then
                        answer = MsgBox("Are you sure to submit this form?", MsgBoxStyle.YesNo, "")
                    End If
                    If GetAccess() = "Admin" Or answer = MsgBoxResult.Yes Then
                        Dim query As String = "INSERT INTO ceuratingforms.ratingform5 VALUES(DEFAULT,'" & previousForm.GetNum() & "' , '" & pos & "', '" & panel1 & "', '" & panel2 & "','" & panel3 & "' ,'" & panel4 & "','" & panel5 & "', '" & panel6 & "', '" & panel7 & "' ," & rf5point & ", " & rf5total & "," & approve & ")"
                        If ExecuteQuery(query) Then
                            If approve = 1 Then
                                Dim totalPoints As Integer = previousForm.GetPoints() + rf5total
                                Dim remarks = GetRemarks(totalPoints)
                                MsgBox("Form Added!")
                                query = "UPDATE ceuratingforms.pointsinfo SET TotalPoints = " & totalPoints & " , Remarks = '" & remarks & "' WHERE StudNo = '" & previousForm.GetNum() & "'"
                                If ExecuteQuery(query) Then
                                    MsgBox("Points Added!")

                                    previousForm.SetPoints(totalPoints)
                                    previousForm.setRemarks(remarks)
                                End If
                            End If
                            Reset(tabForms.SelectedIndex)
                        End If
                    End If
                End If
            Case 5 'Ratingform6
                Dim panel1, panel2, panel3, panel4, panel5, panel6, panel7 As String
                For Each button In rf6Panel1.Controls
                    If TypeOf button Is MetroFramework.Controls.MetroRadioButton Then
                        If DirectCast(button, MetroFramework.Controls.MetroRadioButton).Checked Then
                            panel1 = DirectCast(button, MetroFramework.Controls.MetroRadioButton).Name.ToString()
                        End If
                    End If
                Next
                For Each button In rf6Panel2.Controls
                    If TypeOf button Is MetroFramework.Controls.MetroRadioButton Then
                        If DirectCast(button, MetroFramework.Controls.MetroRadioButton).Checked Then
                            panel2 = DirectCast(button, MetroFramework.Controls.MetroRadioButton).Name.ToString()
                        End If
                    End If
                Next
                For Each button In rf6Panel3.Controls
                    If TypeOf button Is MetroFramework.Controls.MetroRadioButton Then
                        If DirectCast(button, MetroFramework.Controls.MetroRadioButton).Checked Then
                            panel3 = DirectCast(button, MetroFramework.Controls.MetroRadioButton).Name.ToString()
                        End If
                    End If
                Next
                For Each button In rf6Panel4.Controls
                    If TypeOf button Is MetroFramework.Controls.MetroRadioButton Then
                        If DirectCast(button, MetroFramework.Controls.MetroRadioButton).Checked Then
                            panel4 = DirectCast(button, MetroFramework.Controls.MetroRadioButton).Name.ToString()
                        End If
                    End If
                Next
                For Each button In rf6Panel5.Controls
                    If TypeOf button Is MetroFramework.Controls.MetroRadioButton Then
                        If DirectCast(button, MetroFramework.Controls.MetroRadioButton).Checked Then
                            panel5 = DirectCast(button, MetroFramework.Controls.MetroRadioButton).Name.ToString()
                        End If
                    End If
                Next
                For Each button In rf6Panel6.Controls
                    If TypeOf button Is MetroFramework.Controls.MetroRadioButton Then
                        If DirectCast(button, MetroFramework.Controls.MetroRadioButton).Checked Then
                            panel6 = DirectCast(button, MetroFramework.Controls.MetroRadioButton).Name.ToString()
                        End If
                    End If
                Next
                For Each button In rf6Panel7.Controls
                    If TypeOf button Is MetroFramework.Controls.MetroRadioButton Then
                        If DirectCast(button, MetroFramework.Controls.MetroRadioButton).Checked Then
                            panel7 = DirectCast(button, MetroFramework.Controls.MetroRadioButton).Name.ToString()
                        End If
                    End If
                Next

                If String.IsNullOrEmpty(panel1) Then
                    tipError.Show("Please select rating.", rf6Panel1)
                    rf6Panel1.Select()
                ElseIf String.IsNullOrEmpty(panel2) Then
                    tipError.Show("Please select rating.", rf6Panel2)
                    rf6Panel2.Select()
                ElseIf String.IsNullOrEmpty(panel3) Then
                    tipError.Show("Please select rating.", rf6Panel3)
                    rf6Panel3.Select()
                ElseIf String.IsNullOrEmpty(panel4) Then
                    tipError.Show("Please select rating.", rf6Panel4)
                    rf6Panel4.Select()
                ElseIf String.IsNullOrEmpty(panel5) Then
                    tipError.Show("Please select rating.", rf6Panel5)
                    rf6Panel5.Select()
                ElseIf String.IsNullOrEmpty(panel6) Then
                    tipError.Show("Please select rating.", rf6Panel6)
                    rf6Panel6.Select()
                ElseIf String.IsNullOrEmpty(panel7) Then
                    tipError.Show("Please select rating.", rf6Panel7)
                    rf6Panel7.Select()
                ElseIf rf6comLvlOf.SelectedIndex = -1 Then
                    tipError.Show("Please select level of office.", rf6comLvlOf)
                    rf6comLvlOf.Select()
                ElseIf rf6comLvlOf.SelectedIndex = 2 Then
                    If rf6comPubOrg.SelectedIndex = -1 Then
                        tipError.Show("Please select publication/organization.", rf6comPubOrg)
                        rf6comPubOrg.Select()
                    End If
                ElseIf rf6comPosition.SelectedIndex = -1 Then
                    tipError.Show("Please select position.", rf6comPosition)
                    rf6comPosition.Select()
                Else
                    Dim org As String
                    Dim pos = rf6comPosition.SelectedItem.ToString
                    If rf6comPubOrg.SelectedIndex Then
                        org = rf6comPubOrg.SelectedItem.ToString
                    End If
                    Dim lvl = rf6comLvlOf.SelectedItem.ToString
                    Dim rf6point = Val(rf6txtPoints.Text)
                    Dim rf6weight = Val(rf6txtWeight.Text)
                    Dim rf6total = Val(rf6txtTWP.Text)
                    Dim answer As MsgBoxResult
                    If GetAccess() <> "Admin" Then
                        answer = MsgBox("Are you sure to submit this form?", MsgBoxStyle.YesNo, "")
                    End If
                    If GetAccess() = "Admin" Or answer = MsgBoxResult.Yes Then
                        Dim query As String = "INSERT INTO ceuratingforms.ratingform6 VALUES(DEFAULT,'" & previousForm.GetNum() & "' , '" & panel1 & "', '" & panel2 & "','" & panel3 & "' ,'" & panel4 & "','" & panel5 & "', '" & panel6 & "', '" & panel7 & "', '" & lvl & "','" & org & "','" & pos & "'," & rf6point & "," & rf6weight & ", " & rf6total & ", " & approve & ")"
                        If ExecuteQuery(query) Then
                            If approve = 1 Then
                                Dim totalPoints As Integer = previousForm.GetPoints() + rf6total
                                Dim remarks = GetRemarks(totalPoints)
                                MsgBox("Form Added!")
                                query = "UPDATE ceuratingforms.pointsinfo SET TotalPoints = " & totalPoints & " , Remarks = '" & remarks & "' WHERE StudNo = '" & previousForm.GetNum() & "'"
                                If ExecuteQuery(query) Then
                                    MsgBox("Points Added!")

                                    previousForm.SetPoints(totalPoints)
                                    previousForm.setRemarks(remarks)
                                End If
                            End If
                            Reset(tabForms.SelectedIndex)
                        End If
                    End If
                End If
            Case 6 'Rating form 7
                Dim panel1, panel2, panel3, panel4, panel5, panel6, panel7 As String
                For Each button In rf7Panel1.Controls
                    If TypeOf button Is MetroFramework.Controls.MetroRadioButton Then
                        If DirectCast(button, MetroFramework.Controls.MetroRadioButton).Checked Then
                            panel1 = DirectCast(button, MetroFramework.Controls.MetroRadioButton).Name.ToString()
                        End If
                    End If
                Next
                For Each button In rf7Panel2.Controls
                    If TypeOf button Is MetroFramework.Controls.MetroRadioButton Then
                        If DirectCast(button, MetroFramework.Controls.MetroRadioButton).Checked Then
                            panel2 = DirectCast(button, MetroFramework.Controls.MetroRadioButton).Name.ToString()
                        End If
                    End If
                Next
                For Each button In rf7Panel3.Controls
                    If TypeOf button Is MetroFramework.Controls.MetroRadioButton Then
                        If DirectCast(button, MetroFramework.Controls.MetroRadioButton).Checked Then
                            panel3 = DirectCast(button, MetroFramework.Controls.MetroRadioButton).Name.ToString()
                        End If
                    End If
                Next
                For Each button In rf7Panel4.Controls
                    If TypeOf button Is MetroFramework.Controls.MetroRadioButton Then
                        If DirectCast(button, MetroFramework.Controls.MetroRadioButton).Checked Then
                            panel4 = DirectCast(button, MetroFramework.Controls.MetroRadioButton).Name.ToString()
                        End If
                    End If
                Next
                For Each button In rf7Panel5.Controls
                    If TypeOf button Is MetroFramework.Controls.MetroRadioButton Then
                        If DirectCast(button, MetroFramework.Controls.MetroRadioButton).Checked Then
                            panel5 = DirectCast(button, MetroFramework.Controls.MetroRadioButton).Name.ToString()
                        End If
                    End If
                Next
                For Each button In rf7Panel6.Controls
                    If TypeOf button Is MetroFramework.Controls.MetroRadioButton Then
                        If DirectCast(button, MetroFramework.Controls.MetroRadioButton).Checked Then
                            panel6 = DirectCast(button, MetroFramework.Controls.MetroRadioButton).Name.ToString()
                        End If
                    End If
                Next
                For Each button In rf7Panel7.Controls
                    If TypeOf button Is MetroFramework.Controls.MetroRadioButton Then
                        If DirectCast(button, MetroFramework.Controls.MetroRadioButton).Checked Then
                            panel7 = DirectCast(button, MetroFramework.Controls.MetroRadioButton).Name.ToString()
                        End If
                    End If
                Next

                If String.IsNullOrEmpty(panel1) Then
                    tipError.Show("Please select rating.", rf7Panel1)
                    rf7Panel1.Select()
                ElseIf String.IsNullOrEmpty(panel2) Then
                    tipError.Show("Please select rating.", rf7Panel2)
                    rf7Panel2.Select()
                ElseIf String.IsNullOrEmpty(panel3) Then
                    tipError.Show("Please select rating.", rf7Panel3)
                    rf7Panel3.Select()
                ElseIf String.IsNullOrEmpty(panel4) Then
                    tipError.Show("Please select rating.", rf7Panel4)
                    rf7Panel4.Select()
                ElseIf String.IsNullOrEmpty(panel5) Then
                    tipError.Show("Please select rating.", rf7Panel5)
                    rf7Panel5.Select()
                ElseIf String.IsNullOrEmpty(panel6) Then
                    tipError.Show("Please select rating.", rf7Panel6)
                    rf6Panel7.Select()
                ElseIf String.IsNullOrEmpty(panel7) Then
                    tipError.Show("Please select rating.", rf7Panel7)
                    rf7Panel7.Select()
                ElseIf rf7comPosition.SelectedIndex = -1 Then
                    tipError.Show("Please select level of office.", rf7comPosition)
                    rf7comPosition.Select()
                ElseIf String.IsNullOrEmpty(rf7txtIP.Text) Then
                    tipError.Show("Please enter incentive points.", rf7txtIP)
                    rf7txtIP.Select()
                Else
                    Dim pos = rf7comPosition.SelectedItem.ToString
                    Dim rf7point = Val(rf7txtPoints.Text)
                    Dim rf7weight = Val(rf7txtWeight.Text)
                    Dim rf7total = Val(rf7txtTWP.Text)
                    Dim inc As Integer = Val(rf7txtIP.Text)
                    Dim answer As MsgBoxResult
                    If GetAccess() <> "Admin" Then
                        answer = MsgBox("Are you sure to submit this form?", MsgBoxStyle.YesNo, "")
                    End If
                    If GetAccess() = "Admin" Or answer = MsgBoxResult.Yes Then
                        Dim query As String = "INSERT INTO ceuratingforms.ratingform7 VALUES(DEFAULT,'" & previousForm.GetNum() & "' , '" & panel1 & "', '" & panel2 & "','" & panel3 & "' ,'" & panel4 & "','" & panel5 & "', '" & panel6 & "', '" & panel7 & "','" & pos & "'," & rf7point & "," & rf7weight & ", " & inc & ", " & rf7total & ", " & approve & ")"
                        If ExecuteQuery(query) Then
                            If approve = 1 Then
                                Dim totalPoints As Integer = previousForm.GetPoints() + rf7total
                                Dim remarks = GetRemarks(totalPoints)
                                MsgBox("Form Added!")
                                query = "UPDATE ceuratingforms.pointsinfo SET TotalPoints = " & totalPoints & " , Remarks = '" & remarks & "' WHERE StudNo = '" & previousForm.GetNum() & "'"
                                If ExecuteQuery(query) Then
                                    MsgBox("Points Added!")

                                    previousForm.SetPoints(totalPoints)
                                    previousForm.setRemarks(remarks)
                                End If
                            End If
                        End If
                        Reset(tabForms.SelectedIndex)
                    End If
                End If
        End Select
    End Sub

    Private Sub txtPoints_TextChanged(sender As Object, e As EventArgs) Handles txtPoints.TextChanged
        txtPoints.Text = Val(rf1txtPoints.Text) + Val(rf2txtPoints.Text) + Val(rf3txtPoints.Text) + Val(rf4txtPoints.Text) + Val(rf5txtPoints.Text) + Val(rf6txtPoints.Text) + Val(rf7txtPoints.Text)
        If tabForms.SelectedIndex = 4 Then
            txtTotal.Text = Val(txtTotal.Text) + Val(rf5txtWeight.Text)
        End If
    End Sub

    Private Sub txtTotal_TextChanged(sender As Object, e As EventArgs) Handles txtTotal.TextChanged
        txtTotal.Text = Val(txtPoints.Text) * (Val(txtWeight.Text) + Val(rf5txtTWP.Text))
    End Sub
End Class