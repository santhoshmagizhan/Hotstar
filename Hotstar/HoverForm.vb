Imports System.Runtime.InteropServices
Imports System.Threading

Public Class HoverForm


    <Runtime.InteropServices.StructLayout(Runtime.InteropServices.LayoutKind.Sequential)> Public Structure side
        Public Left As Integer
        Public Right As Integer
        Public Top As Integer
        Public Bottom As Integer
    End Structure


    <Runtime.InteropServices.DllImport("dwmapi.dll")> Public Shared Function DwmExtendFrameIntoClientArea(ByVal hWnd As IntPtr, ByRef pMarinset As side) As Integer

    End Function
    Dim isFocus As Boolean = False

    Private Sub HoverForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
        Me.BackColor = Color.Black
        Dim side As side = side
        side.Left = -1
        side.Right = -1
        side.Top = -1
        side.Bottom = -1
        Dim result As Integer = DwmExtendFrameIntoClientArea(Me.Handle, side)
        Timer1.Start()
        Me.toggleVisiblity(True)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Me.Opacity = 0 Then
            Me.Opacity = Me.Opacity + 0.05
        End If
        Me.TopMost = True
    End Sub

    Private Sub closePIP_Click(sender As Object, e As EventArgs) Handles closePIP.Click
        Form1.Close()
    End Sub

    Private Sub maxiPIP_Click(sender As Object, e As EventArgs) Handles maxiPIP.Click
        Me.maxiMUM()
    End Sub

    Private Sub maxiMUM()
        Form1.isPIPenabled = False
        Form1.pipToggle()
        Me.Close()
    End Sub

    Public Sub toggleVisiblity(isVisible As Boolean)
        If isVisible = True Then
            Me.maxiPIP.BackColor = ColorTranslator.FromHtml("#212122")
            Me.titlepanel.BackColor = ColorTranslator.FromHtml("#212122")
            Me.maxiPIP.Image = My.Resources.maxi
            Me.closePIP.Image = My.Resources.sm_closewhite
            Me.pausenplay.Image = If(Form1.Isplay, My.Resources.pause, My.Resources.play)
        Else
            Timer2.Start()
        End If
    End Sub

    Private Sub maxiPIP_MouseHover(sender As Object, e As EventArgs) Handles maxiPIP.MouseHover
        Me.isFocus = True
        Me.toggleVisiblity(True)
    End Sub

    Private Sub maxiPIP_MouseLeave(sender As Object, e As EventArgs) Handles maxiPIP.MouseLeave
        Me.isFocus = False
        Me.toggleVisiblity(False)
    End Sub

    Private Sub titlepanel_Click(sender As Object, e As EventArgs) Handles titlepanel.Click
        Me.maxiMUM()
    End Sub

    Private Sub titlepanel_MouseHover(sender As Object, e As EventArgs) Handles titlepanel.MouseHover
        Me.isFocus = True
        Me.toggleVisiblity(True)
    End Sub

    Private Sub titlepanel_MouseLeave(sender As Object, e As EventArgs) Handles titlepanel.MouseLeave
        Me.isFocus = False
        Me.toggleVisiblity(False)
    End Sub

    Private Sub closePIP_MouseHover(sender As Object, e As EventArgs) Handles closePIP.MouseHover
        Me.isFocus = True
        Me.toggleVisiblity(True)
    End Sub

    Private Sub closePIP_MouseLeave(sender As Object, e As EventArgs) Handles closePIP.MouseLeave
        Me.isFocus = False
        Me.toggleVisiblity(False)
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If (Me.isFocus = False) Then
            Me.maxiPIP.BackColor = Color.Transparent
            Me.titlepanel.BackColor = Color.Transparent
            Me.maxiPIP.Image = Nothing
            Me.closePIP.Image = Nothing
            Me.pausenplay.Image = Nothing
        End If
        Timer2.Stop()
    End Sub

    Private Sub pausenplay_Click(sender As Object, e As EventArgs) Handles pausenplay.Click
        Me.pausenplay.Image = If(Form1.Isplay, My.Resources.play, My.Resources.pause)
        Form1.PlayPause()
    End Sub

    Private Sub pausenplay_MouseHover(sender As Object, e As EventArgs) Handles pausenplay.MouseHover
        Me.isFocus = True
        Me.toggleVisiblity(True)
    End Sub

    Private Sub pausenplay_MouseLeave(sender As Object, e As EventArgs) Handles pausenplay.MouseLeave
        Me.isFocus = False
        Me.toggleVisiblity(False)
    End Sub
End Class