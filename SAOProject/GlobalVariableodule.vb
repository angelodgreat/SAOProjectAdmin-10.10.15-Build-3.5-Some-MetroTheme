Imports MySql.Data.MySqlClient
Module GlobalVariableodule

    Public MysqlConn As MySqlConnection

    Public test As String = "server='" & DBSettings.tb_setserver.Text & "'; port='" & DBSettings.tb_setport.Text & "'; database='" & DBSettings.tb_setDB.Text & "'; userid='" & DBSettings.tb_setusername.Text & "'; password='" & DBSettings.tb_setpassword.Text & "'"
    Public connstring As String = test

    Public query As String

    Public Command As MySqlCommand
    Public dbdataset As New DataTable
    Public reader As MySqlDataReader

    Public remozconnection As String = "server=" & DBSettings.tb_setserver.Text & "; port=" & DBSettings.tb_setport.Text & "; database=ceuratingforms; userid=" & DBSettings.tb_setusername.Text & "; password=" & DBSettings.tb_setpassword.Text & ""


    'remoz codez
    Dim accountName As String
    Dim accountType As String

    Public Sub SetAccount(ByVal name As String)
        accountName = name
    End Sub

    Public Sub SetAccess(ByVal account As String)
        accountType = account
    End Sub

    Public Function GetAccount() As String
        Return accountName
    End Function

    Public Function GetAccess() As String
        Return accountType
    End Function

    Public Function ConnectToDatabase() As MySqlConnection
        Return New MySqlConnection(remozconnection)
    End Function

    Public Function ExecuteQuery(ByVal query As String) As Boolean
        Try
            Dim conn As MySqlConnection = ConnectToDatabase()

            conn.Open()

            Dim cmd As MySqlCommand = New MySqlCommand()

            cmd.Connection = conn
            cmd.CommandText = query
            cmd.ExecuteNonQuery()
            conn.Close()

            Return True
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

        Return False

    End Function

    Public Function count(ByVal query As String, ByVal nCol As Integer) As Integer
        Dim list As ArrayList = RetrieveQuery(query, nCol)
        Return list.Count
    End Function

    Public Function RetrieveQuery(ByVal query As String, ByVal nCol As Integer) As ArrayList
        Try
            Dim conn As MySqlConnection = ConnectToDatabase()

            conn.Open()

            Dim cmd As MySqlCommand = New MySqlCommand()

            Dim list As ArrayList
            Dim list1 As ArrayList = New ArrayList()

            cmd.Connection = conn
            cmd.CommandText = query

            cmd.ExecuteNonQuery()
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            While reader.Read
                list = New ArrayList()

                Dim i As Integer

                For i = 0 To nCol - 1
                    list.Add(reader(i))
                Next

                list1.Add(list)
            End While
            reader.Close()
            conn.Close()

            Return list1
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try

        Return Nothing
    End Function



End Module
