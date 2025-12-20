Imports System.Net.Http
Imports System.Text
Imports System.Threading.Tasks
Imports Newtonsoft.Json.Linq

Public Class RestApiClient
    Private ReadOnly _client As HttpClient

    ' Constructor: initialize HttpClient with base URL
    Public Sub New(baseUrl As String)
        _client = New HttpClient()
        _client.BaseAddress = New Uri(baseUrl)
        _client.DefaultRequestHeaders.Clear()
        _client.DefaultRequestHeaders.Add("Accept", "application/json")
    End Sub

    ' Add a single header
    Public Sub AddHeader(key As String, value As String)
        ' Remove if already exists to avoid duplicates
        If _client.DefaultRequestHeaders.Contains(key) Then
            _client.DefaultRequestHeaders.Remove(key)
        End If
        _client.DefaultRequestHeaders.Add(key, value)
    End Sub

    ' GET request returning raw JSON string
    Public Async Function GetAsync(endpoint As String) As Task(Of String)
        Dim response As HttpResponseMessage = Await _client.GetAsync(endpoint)
        response.EnsureSuccessStatusCode()
        Return Await response.Content.ReadAsStringAsync()
    End Function

    ' POST request accepting JObject and returning raw JSON string
    Public Async Function PostAsync(endpoint As String, data As JObject) As Task(Of String)
        Dim jsonData As String = data.ToString()
        Dim content As New StringContent(jsonData, Encoding.UTF8, "application/json")
        Dim response As HttpResponseMessage = Await _client.PostAsync(endpoint, content)
        response.EnsureSuccessStatusCode()
        Return Await response.Content.ReadAsStringAsync()
    End Function

    ' PUT request accepting JObject
    Public Async Function PutAsync(endpoint As String, data As JObject) As Task(Of String)
        Dim jsonData As String = data.ToString()
        Dim content As New StringContent(jsonData, Encoding.UTF8, "application/json")
        Dim response As HttpResponseMessage = Await _client.PutAsync(endpoint, content)
        response.EnsureSuccessStatusCode()
        Return Await response.Content.ReadAsStringAsync()
    End Function

    ' DELETE request
    Public Async Function DeleteAsync(endpoint As String) As Task(Of String)
        Dim response As HttpResponseMessage = Await _client.DeleteAsync(endpoint)
        response.EnsureSuccessStatusCode()
        Return Await response.Content.ReadAsStringAsync()
    End Function
End Class