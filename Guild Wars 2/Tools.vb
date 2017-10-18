Imports System.Drawing
Imports System.Windows.Forms
Imports VB = Microsoft.VisualBasic
Namespace Libraries
    Partial Module Tools
        Public Sub Wait(ByVal Seconds As Single)
            Static Start As Single
            Start = VB.Timer()
            Do While VB.Timer() < Start + Seconds
                System.Windows.Forms.Application.DoEvents()
            Loop
        End Sub

        Public Function FileName(ByVal FilePath As String) As String
            Dim FolderCut As String() = FilePath.Split("\"c)
            Dim FileCut As String() = FolderCut(FolderCut.Length - 1).Split("."c)
            Dim Result As System.Text.StringBuilder = New System.Text.StringBuilder()
            If (FileCut.Length > 1) Then
                Dim Count As Integer = 0
                For Count = 0 To FileCut.Length - 2
                    If (Count = 0) Then
                        Result.Append(FileCut(Count))
                    Else
                        Result.Append(".")
                        Result.Append(FileCut(Count))
                    End If
                Next
            Else
                Result.Append(FileCut(0))
            End If
            Return Result.ToString()
        End Function

        Public Function GetPath(ByVal FilePath As String) As String
            Dim FolderCut As String() = FilePath.Split("\"c)
            Dim Result As System.Text.StringBuilder = New System.Text.StringBuilder()
            If (FolderCut.Length > 1) Then
                Dim Count As Integer = 0
                For Count = 0 To FolderCut.Length - 2
                    If (Count = 0) Then
                        Result.Append(FolderCut(Count))
                    Else
                        Result.Append("\")
                        Result.Append(FolderCut(Count))
                    End If
                Next
            End If
            Return Result.ToString()
        End Function

        Public Function SplitSourceImage(ByVal SourceImage As Image, ByVal ImageCount As Integer, ByVal ImageSize As Size) As Image()
            Dim Result(ImageCount) As Image
            Dim PictureBoxContainer = New PictureBox
            With PictureBoxContainer
                .SizeMode = PictureBoxSizeMode.AutoSize
                .Image = SourceImage
                For Count As Integer = 0 To ImageCount - 1
                    Dim OutputImage As Bitmap = New Bitmap(ImageSize.Width, ImageSize.Height)
                    .DrawToBitmap(Result(Count), New Rectangle(0, Count * ImageSize.Height, ImageSize.Width, ImageSize.Height))
                    Result(Count) = CType(OutputImage, Image)
                Next
            End With
            Return Result
        End Function

        Public Function TrimStart(ByVal Input As String, ByVal Text As String) As String
            Dim Output As String = Input
            For Each Letter As Char In Text
                Output.TrimStart(Letter)
            Next
            Return Output
        End Function

        Public Function TrimEnd(ByVal Input As String, ByVal Text As String) As String
            Dim Output As String = Input
            For Each Letter As Char In Text.Reverse
                Output.TrimEnd(Letter)
            Next
            Return Output
        End Function
    End Module
End Namespace