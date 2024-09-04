Imports System.IO
Imports Newtonsoft.Json.Linq

Public Class GCloud
    Private Const QUERY As String = "query.bat"
    Private Const EXEC As String = "execute.bat"
    Private Const QUERY_RESULT As String = "d:\GGC_Maven_Systems\temp\query.json"
    Private Const EXECUTION_RESULT As String = "d:\GGC_Maven_Systems\temp\exec-result.json"

    Dim p_sUserIDxx As String
    Dim p_bShowMsgx As Boolean
    Dim p_oArray As JArray

    Sub BeginTransaction()
        ' Create a JObject to hold the parameters
        Dim jsonObject As New JObject()
        jsonObject("sql") = "BEGIN;"
        jsonObject("condition") = SQLCondition.xeNone
        jsonObject("rows") = 0

        ' Add the JObject to the JSON array
        p_oArray.Add(jsonObject)
    End Sub

    Sub CommitTransaction()
        ' Create a JObject to hold the parameters
        Dim jsonObject As New JObject()
        jsonObject("sql") = "COMMIT;"
        jsonObject("condition") = SQLCondition.xeNone
        jsonObject("rows") = 0

        ' Add the JObject to the JSON array
        p_oArray.Add(jsonObject)
    End Sub

    Public Sub AddStatement(ByVal fsSQL As String,
                            ByVal fnLogical As SQLCondition,
                            Optional ByVal fnResult As Integer = 0,
                            Optional ByVal fbReplicte As Boolean = True,
                            Optional ByVal fsTableNme As String = "",
                            Optional ByVal fsBranchCd As String = "",
                            Optional ByVal fsDestinat As String = "")

        If (fbReplicte = True) Then
            If (fsTableNme = "") Then
                Debug.Print("Table is not set for a query to replicate.")
                If p_bShowMsgx Then
                    MsgBox("Table is not set for a query to replicate.", vbCritical, "Warning")
                End If
                Exit Sub
            End If

            If (fsBranchCd = "") Then
                Debug.Print("Table is not set for a query to replicate.")
                If p_bShowMsgx Then
                    MsgBox("Table is not set for a query to replicate.", vbCritical, "Warning")
                End If
                Exit Sub
            End If
        End If

        ' Create a JObject to hold the parameters
        Dim jsonObject As New JObject()
        jsonObject("sql") = fsSQL
        jsonObject("condition") = fnLogical
        jsonObject("rows") = fnResult
        jsonObject("replicate") = fbReplicte
        jsonObject("table") = fsTableNme
        jsonObject("branch") = fsBranchCd
        jsonObject("destination") = fsTableNme

        ' Add the JObject to the JSON array
        p_oArray.Add(jsonObject)
    End Sub

    Public Function Execute() As Boolean
        If p_sUserIDxx = "" Then
            Debug.Print("User ID is not set.")

            If p_bShowMsgx Then
                MsgBox("User ID is not set.", vbCritical, "Warning")
            End If

            Return False
        End If

        Dim jsonObject As New JObject()
        jsonObject("sql") = p_oArray
        jsonObject("user") = p_sUserIDxx

        Dim lnRes As Integer = RMJExecute("d:\GGC_Maven_Systems", EXEC, jsonObject.ToString)

        Dim jsonString As String = File.ReadAllText(EXECUTION_RESULT)
        Dim jsobObject As JObject = JObject.Parse(jsonString)

        If lnRes = 0 Then
            If jsobObject("result").ToString() = "success" Then
                Return True
            Else
                Debug.Print(jsobObject("message").ToString())

                If p_bShowMsgx Then
                    MsgBox(jsobObject("message").ToString(), vbCritical, "Warning")
                End If

                Return False
            End If
        Else
            Debug.Print("API Exeption Detected. Please ask assistance to MIS.")

            If p_bShowMsgx Then
                MsgBox("API Exeption Detected." & vbCrLf & vbCrLf &
                    "Please ask assistance to MIS.", vbCritical, "Warning")
            End If

            Return False
        End If
    End Function

    Public Function ExecuteQuery(ByVal fsSQL As String) As DataTable
        Dim lnRes As Integer = RMJExecute("d:\GGC_Maven_Systems", QUERY, fsSQL)

        Dim jsonString As String = File.ReadAllText(QUERY_RESULT)
        Dim jsobObject As JObject = JObject.Parse(jsonString)

        If lnRes = 0 Then
            If jsobObject("result").ToString() = "success" Then
                Dim jsonArray As JArray = CType(jsobObject("payload"), JArray)

                Return JsonArrayToDataTable(jsonArray)
            Else
                Debug.Print(jsobObject("message").ToString())

                If p_bShowMsgx Then
                    MsgBox(jsobObject("message").ToString(), vbCritical, "Warning")
                End If

                Return Nothing
            End If
        Else
            Debug.Print("API Exeption Detected. Please ask assistance to MIS.")

            If p_bShowMsgx Then
                MsgBox("API Exeption Detected." & vbCrLf & vbCrLf &
                    "Please ask assistance to MIS.", vbCritical, "Warning")
            End If

            Return Nothing
        End If
    End Function

    Private Function JsonArrayToDataTable(jsonArray As JArray) As DataTable
        ' Create a new DataTable
        Dim dataTable As New DataTable()

        ' Check if the array is not empty
        If jsonArray.Count > 0 Then
            ' Get the first object in the array to define the columns
            Dim firstObject As JObject = CType(jsonArray(0), JObject)

            ' Create columns in the DataTable based on JSON object keys
            For Each prop As JProperty In firstObject.Properties()
                dataTable.Columns.Add(prop.Name)
            Next

            ' Add rows to the DataTable
            For Each jsonObject As JObject In jsonArray
                Dim row As DataRow = dataTable.NewRow()
                For Each prop As JProperty In jsonObject.Properties()
                    row(prop.Name) = prop.Value.ToString()
                Next
                dataTable.Rows.Add(row)
            Next
        End If

        Return dataTable
    End Function

    Public Sub New()
        p_oArray = New JArray

        p_sUserIDxx = ""
    End Sub

    Public Property UserID As String
        Get
            Return p_sUserIDxx
        End Get
        Set(ByVal fsValue As String)
            p_sUserIDxx = fsValue
        End Set
    End Property

    Public Property ShowMessage As Boolean
        Get
            Return p_bShowMsgx
        End Get
        Set(ByVal fbValue As Boolean)
            p_bShowMsgx = fbValue
        End Set
    End Property
End Class