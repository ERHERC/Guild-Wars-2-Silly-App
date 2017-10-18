Public Class MainForm
    Private RNG As Random


    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RNG = New Random()
        For I = 1 To 1
            Call New Adopted() With {.Opacity = 0}.Show()
            Call New BainStahp() With {.Opacity = 0}.Show()
            Call New Charr() With {.Opacity = 0}.Show()
            Call New Confuse() With {.Opacity = 0}.Show()
            Call New Dyes() With {.Opacity = 0}.Show()
            Call New FalseLake() With {.Opacity = 0}.Show()
            Call New FinishHim() With {.Opacity = 0}.Show()
            Call New ForgotWarrior() With {.Opacity = 0}.Show()
            Call New Frisbee() With {.Opacity = 0}.Show()
            Call New GemStore() With {.Opacity = 0}.Show()
            Call New HighVista() With {.Opacity = 0}.Show()
            Call New Hype() With {.Opacity = 0}.Show()
            Call New JumpingPuzzle() With {.Opacity = 0}.Show()
            Call New Karma() With {.Opacity = 0}.Show()
            Call New Leader() With {.Opacity = 0}.Show()
            Call New LolSerious() With {.Opacity = 0}.Show()
            Call New RedditDown() With {.Opacity = 0}.Show()
            Call New Silver() With {.Opacity = 0}.Show()
            Call New VistasEverywhere() With {.Opacity = 0}.Show()
            Call New Wow() With {.Opacity = 0}.Show()
            Call New WVW() With {.Opacity = 0}.Show()
        Next

        For Each Window As Form In Application.OpenForms
            If Not Window Is Me Then
                Globals.AdCount += 1
                With Window
                    .Top = RNG.Next(0, My.Computer.Screen.WorkingArea.Height - .Height)
                    .Left = RNG.Next(0, My.Computer.Screen.WorkingArea.Width - .Width)
                    .TopMost = True
                    .Cursor = Cursors.No

                    '.FormBorderStyle = FormBorderStyle.FixedToolWindow

                    .Opacity = 1
                    AddHandler .Click, AddressOf Window_Click
                    AddHandler .FormClosing, AddressOf Window_FormClosing
                    'AddHandler .MouseEnter, AddressOf Window_MouseEnter
                    For Each Control As Control In .Controls
                        AddHandler Control.Click, AddressOf Control_Click
                        Control.Cursor = Cursors.No
                    Next
                End With
            End If
        Next

        'Dim FormOpacity As Task = New Task(AddressOf ShowForm)
        'FormOpacity.Start()
    End Sub

    Private Sub Window_Click(Sender As Form, E As EventArgs)
        Sender.Close()
    End Sub

    Private Sub Control_Click(Sender As Control, E As EventArgs)
        Sender.FindForm.Close()
    End Sub

    Private Sub Window_MouseEnter(Sender As Form, E As EventArgs)
        Sender.ControlBox = False
        Sender.BringToFront()
        Sender.Select()
        Sender.Focus()
    End Sub

    Private Sub Window_FormClosing(sender As Object, e As FormClosingEventArgs)
        Globals.CloseAd()
    End Sub

    Private Sub MainForm_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Dim TextColor As Task = New Task(AddressOf BRUH)
        TextColor.Start()
    End Sub

    Public Sub BRUH()
        Dim Index As Integer = 0
        While Me.Visible
            MainLbl.ForeColor = Globals.Colors(Index Mod Globals.Colors.Count)
            'MainLbl.BackColor = Globals.Colors((Index + 1) Mod Globals.Colors.Count)
            Libraries.Tools.Wait(0.05)
            Index += 1
        End While
    End Sub

    Public Sub ShowForm()
        While Application.OpenForms.Count > 1
            Libraries.Tools.Wait(0.05)
        End While
        Me.WindowState = FormWindowState.Normal
        Me.ShowInTaskbar = True
    End Sub


End Class