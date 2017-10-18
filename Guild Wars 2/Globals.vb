Module Globals
    Public Colors As List(Of Color) = New List(Of Color) _
    From {Color.Red, Color.Orange, Color.Yellow, Color.Lime, Color.Cyan, Color.Purple}


    Public AdCount As Integer = 0
    Public Sub CloseAd()
        If AdCount < 0 Then Exit Sub
        AdCount -= 1







        If AdCount <= 0 Then
            Try : For Each Window As Form In Application.OpenForms : With Window
                        If Not Window Is Nothing AndAlso .Name = "MainForm" AndAlso .Text = "Message" Then
                            .ShowInTaskbar = True
                            .WindowState = FormWindowState.Normal
                            .Text = "Guild Wars 2"
                        End If
                    End With : Next
            Catch ErrorCode As Exception : End Try
        End If
    End Sub
End Module
