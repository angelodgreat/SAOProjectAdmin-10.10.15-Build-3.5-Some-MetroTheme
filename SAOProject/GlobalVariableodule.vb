Imports MySql.Data.MySqlClient
Module GlobalVariableodule

    Public MysqlConn As MySqlConnection
    Public test As String = "server='" & DBSettings.tb_setserver.Text & "'; port='" & DBSettings.tb_setport.Text & "'; database='" & DBSettings.tb_setDB.Text & "'; userid='" & DBSettings.tb_setusername.Text & "'; password='" & DBSettings.tb_setpassword.Text & "'"
    Public connstring As String = test
    'Public connstring As String = "server=AngeloUmaliPC;userid=root;password=root;database=saoinfo"
    Public query As String

    Public Command As MySqlCommand
    Public dbdataset As New DataTable
    Public reader As MySqlDataReader
End Module
