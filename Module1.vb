Imports System.IO
Imports Newtonsoft.Json.Linq

Module Module1

    Sub Main()

        ' Enter Path
        Dim JsonPath As String = ""
        Dim JsonString As String = File.ReadAllText(JsonPath)
        Dim jObject As JObject = JObject.Parse(JsonString)

        ' Enter Key
        Dim ID As String = jObject("")("").ToString()

        System.Console.WriteLine(ID)
        System.Console.ReadLine()

    End Sub

End Module