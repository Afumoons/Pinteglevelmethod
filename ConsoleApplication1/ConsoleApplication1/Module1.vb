Module Module1

    Sub Main()
        Dim p As rest = New rest("http://localhost/mvcSimpan")
        p.List("application/json")

    End Sub

End Module
