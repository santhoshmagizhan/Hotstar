Imports System.Drawing.Drawing2D
Imports System.IO
Imports System.Security.AccessControl
Imports Microsoft.Web.WebView2.Core

Public Class Form1
    Dim loadertime As Integer = 0
    Dim AddBackArrowHtml As String = """<div id=\""btn-backarrow\"" class=\""btn-hamburger\""><div class=\""icon-wrapper\""><img class=\""btn-gobackarrow\"" src=\""data:image/svg+xml,%3Csvg xmlns='http://www.w3.org/2000/svg' version='1.0' width='100.000000pt' height='100.000000pt' viewBox='0 0 100.000000 100.000000' preserveAspectRatio='xMidYMid meet'%3E%3Cg transform='translate(0.000000,100.000000) scale(0.100000,-0.100000)' fill='%23ffffff99' stroke='none'%3E%3Cpath d='M137 626 c-59 -63 -107 -119 -107 -126 0 -19 211 -240 230 -240 20 0 40 19 40 39 0 9 -30 49 -66 88 l-65 73 397 2 c365 3 398 4 408 21 8 12 8 22 0 35 -10 16 -43 17 -408 20 l-397 2 65 73 c66 73 76 93 54 115 -25 25 -48 9 -151 -102z'/%3E%3C/g%3E%3C/svg%3E\"" style=\""width: 35px;\""></div></div>"""
    Dim navURL As String = "https://www.hotstar.com/in"
    Dim pip As String = """<div id=\""pip\"" class=\""skin-lock-wrapper\""><div class=\""fullscreen pip player-control\""><img class=\""fullscreen-img pip\"" src=\""data:image/svg+xml,%3Csvg xmlns='http://www.w3.org/2000/svg' version='1.0' width='24.000000pt' height='24.000000pt' viewBox='0 0 512.000000 512.000000' preserveAspectRatio='xMidYMid meet'%3E%3Cg transform='translate(0.000000,512.000000) scale(0.100000,-0.100000)' fill='%23ffff' stroke='none'%3E%3Cpath d='M975 4464 c-229 -49 -428 -225 -509 -453 l-31 -86 -3 -1120 c-3 -1258 -6 -1196 71 -1355 56 -115 186 -247 297 -303 156 -77 150 -77 892 -77 l659 0 -3 158 -3 157 -665 5 -665 5 -55 28 c-72 37 -141 105 -176 176 l-29 56 0 1115 0 1115 33 67 c38 78 100 138 182 177 l55 26 1535 0 1535 0 55 -26 c82 -39 144 -99 182 -177 l33 -67 3 -662 2 -663 161 0 160 0 -3 683 -3 682 -31 86 c-63 176 -187 316 -349 394 -164 80 -59 75 -1752 74 -1287 -1 -1518 -3 -1578 -15z'/%3E%3Cpath d='M1170 3829 c-32 -13 -68 -47 -86 -81 -17 -32 -18 -101 -3 -131 6 -12 171 -183 367 -379 l357 -358 -199 0 c-222 0 -246 -6 -294 -68 -39 -51 -39 -133 0 -184 52 -68 50 -68 499 -68 387 0 404 1 445 21 26 12 53 36 66 57 23 37 23 40 26 429 2 260 -1 406 -8 433 -38 140 -216 169 -290 47 -18 -29 -20 -51 -20 -237 l0 -205 -352 352 c-239 238 -365 357 -390 368 -42 17 -81 18 -118 4z'/%3E%3Cpath d='M2919 2339 c-117 -17 -234 -96 -296 -200 -64 -106 -64 -113 -61 -776 3 -555 4 -602 22 -648 47 -127 151 -227 273 -265 63 -19 92 -20 879 -20 797 0 816 0 876 21 156 52 264 181 288 344 13 94 13 1100 -1 1185 -30 191 -168 329 -359 359 -78 13 -1536 13 -1621 0z'/%3E%3C/g%3E%3C/svg%3E\"" alt=\""pip-screen\""></div></div>"""
    Dim watermark As String = "if (document.getElementsByClassName('hs-logo active').length) { if(watermark){document.getElementsByClassName('hs-logo active')[0].style.visibility = 'visible';} else {document.getElementsByClassName('hs-logo active')[0].style.visibility = 'hidden';} }"
    Dim ScriptInjection As String = " 
    var url = window.location;
    var watermark = " & My.Settings.WaterMark.ToString().ToLower() & "
    var durationEnds = false;
     function scriptInjection() {
    if (!document.getElementById('btn-backarrow') && url!= '" & navURL & "') {
    document.getElementsByClassName('nav-container')[0].insertAdjacentHTML('afterbegin', " & AddBackArrowHtml & ");
    } 
    if(document.getElementsByClassName('footer')?.length > 0){
    document.getElementsByClassName('footer')[0]?.remove();
    document.getElementsByClassName('email-us-link')[0]?.remove();
    var styles = '::-webkit-scrollbar{width:8px;}::-webkit-scrollbar-track{background:#192133;}::-webkit-scrollbar-thumb{background:#334366;}::-webkit-scrollbar-thumb:hover{background:#334366;} body {user-select:none;-moz-user-select:none;-webkit-user-select:none;-ms-user-select:none;}';
    var styleSheet = document.createElement('style');
    styleSheet.innerText = styles;
    document.head.appendChild(styleSheet);
    window.ondragstart = function() {return false};
    }
    }
    function playerscriptInjection(){
      if ((!document.getElementById('pip') && url!= '" & navURL & "' && document.getElementsByClassName('controls-container')?.length > 0 && document.getElementsByClassName('bottom-right-panel')?.length > 0) ) {
    document.getElementsByClassName('bottom-right-panel')[0].insertAdjacentHTML('beforeend', " & pip & ");

    }
    if(!durationEnds && !document.getElementsByClassName('web_player_loader loader').length && document.getElementsByClassName('duration')[0]?.innerHTML === '00:00' && document.getElementsByClassName('player-icon player-control play').length)
    {
     durationEnds = true;
     let jsonObj = {Key:'click',Value:document.getElementsByClassName('duration')[0]?.innerHTML||'Unknown',Class:'duration-ends',Alt:'Unknown',Play:(document.getElementsByClassName('player-icon player-control play')?.length ? true:false),Pause:(document.getElementsByClassName('player-icon player-control pause')?.length ? true:false)}; 
     window.chrome.webview.postMessage(jsonObj);
    }
    else if(durationEnds && !document.getElementsByClassName('web_player_loader loader').length && document.getElementsByClassName('duration')[0]?.innerHTML !== '00:00')
    {
     durationEnds = false;
    }
    if(document.getElementsByClassName('ad-cta-companion-panel').length)
    {
       document.getElementsByClassName('ad-cta-companion-panel')[0].remove();
    } " & watermark & "
    }"
    Dim script As String = "document.addEventListener('click',function(event){let elem = event.target; let jsonObject = {Key:'click',Value:elem.name||elem.id||elem.tagName||'Unknown',Class:elem.className || 'Unknown',Alt:elem.alt || 'Unknown',Play:(document.getElementsByClassName('player-icon player-control play')?.length ? true:false),Pause:(document.getElementsByClassName('player-icon player-control pause')?.length ? true:false)}; window.chrome.webview.postMessage(jsonObject);}); window.oncontextmenu = function () { return false;}" & ScriptInjection

    Dim BackScript As String = "scriptInjection();
     setTimeout(scriptInjection(), 1000);
     var playerInterval ;
     if(!playerInterval){
     playerInterval= setInterval(playerscriptInjection, 1000);
     }"

    Dim IsfullScreen As Boolean = False
    Public Isplay As Boolean = True
    Private Declare Function SetWindowPos Lib "user32.dll" _
        Alias "SetWindowPos" (ByVal hWnd As IntPtr,
                              ByVal hWndIntertAfter As IntPtr,
                              ByVal X As Integer,
                              ByVal Y As Integer,
                              ByVal cx As Integer,
                              ByVal cy As Integer,
                              ByVal uFlags As Integer) As Boolean

    Private HWND_TOP As IntPtr = IntPtr.Zero
    Private Const SWP_SHOWWINDOW As Integer = 64
    Dim firstX As Integer
    Dim firstY As Integer
    Dim lbuttonDown As Boolean
    Dim prevHeight As Integer = 0
    Dim prevWidth As Integer = 0
    Public isPIPenabled As Boolean = False
    Public prevLocation As Point = Point.Empty
    Private Const cGrip As Integer = 16
    Private Const cCaption As Integer = 32


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim FolderPath = (Directory.GetCurrentDirectory & "\Hotstar.exe.WebView2")
            Dim UserAccount = SystemInformation.UserName
            If Directory.Exists(FolderPath) Then
                Dim FolderInfo As DirectoryInfo = New IO.DirectoryInfo(FolderPath)
                Dim FolderAcl As New DirectorySecurity
                FolderAcl.AddAccessRule(New FileSystemAccessRule(UserAccount, FileSystemRights.FullControl, InheritanceFlags.ContainerInherit Or InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Allow))
                FolderInfo.SetAccessControl(FolderAcl)
            End If

            Me.settingsbtn.Hide()
            Me.FormBorder.BackgroundImage = My.Resources.header_1
            'Timer1.Start()
            Me.WebView21.Hide()
            Me.WebView21.Source = New Uri(navURL)
            Me.configSettings()
        Catch ex As Exception

        End Try
    End Sub

    Private Async Sub WebView21_CoreWebView2InitializationCompleted(sender As Object, e As CoreWebView2InitializationCompletedEventArgs) Handles WebView21.CoreWebView2InitializationCompleted

        Try

            Me.WebView21.CoreWebView2.Settings.IsStatusBarEnabled = False
            Me.WebView21.CoreWebView2.Settings.IsZoomControlEnabled = False
            Me.WebView21.CoreWebView2.Settings.AreDefaultContextMenusEnabled = False
            Me.WebView21.CoreWebView2.Settings.AreDevToolsEnabled = False
            Me.WebView21.CoreWebView2.Settings.AreBrowserAcceleratorKeysEnabled = False
            Me.WebView21.CoreWebView2.CallDevToolsProtocolMethodAsync("Network.clearBrowserCache", "{}")

            Await WebView21.CoreWebView2.AddScriptToExecuteOnDocumentCreatedAsync(script)
            BeLazy()
            Me.LoaderImg.Hide()
            Me.WebView21.Show()
            Me.settingsbtn.Show()
            Me.FormBorder.BackgroundImage = My.Resources.header_2
        Catch ex As Exception

        End Try
    End Sub

    Private Sub WebView21_WebMessageReceived(sender As Object, e As CoreWebView2WebMessageReceivedEventArgs) Handles WebView21.WebMessageReceived
        Try
            Dim JsonString As String = e.WebMessageAsJson?.ToString()?.Replace("{", "").Replace("}", "").Replace("""", "")
            Dim evenArray = JsonString.Split(",")

            Select Case (evenArray(0)?.ToString())
                Case "Key:click"
                    If ((evenArray(1)?.ToString() = "Value:IMG") And
                       (evenArray(2)?.ToString() = "Class:fullscreen-img")) Or
                       ((evenArray(1)?.ToString() = "Value:DIV") And
                       (evenArray(2)?.ToString() = "Class:fullscreen player-control")) Then

                        Me.FullscreenToggle()
                    ElseIf ((evenArray(1)?.ToString() = "Value:IMG") And
                       (evenArray(2)?.ToString() = "Class:fullscreen-img pip")) Or
                       ((evenArray(1)?.ToString() = "Value:DIV") And
                       (evenArray(2)?.ToString() = "Class:fullsc1reen pip player-control")) Then

                        Me.WindowState = FormWindowState.Maximized
                        Me.isPIPenabled = True

                        If (Me.IsfullScreen = False) Then
                            Me.IsfullScreen = True
                            Dim fullscreenTrigger = "document.getElementsByClassName('fullscreen player-control')[0].click();"
                            WebView21.CoreWebView2.ExecuteScriptAsync(fullscreenTrigger)
                        End If
                        Me.pipToggle()

                    ElseIf ((evenArray(1)?.ToString() = "Value:IMG") And
                   (evenArray(2)?.ToString() = "Class:btn-gobackarrow")) Then
                        If WebView21 IsNot Nothing AndAlso WebView21.CanGoBack Then
                            WebView21.GoBack()
                        End If

                    ElseIf ((evenArray(1)?.ToString() = "Value:DIV") And
                   (evenArray(2)?.ToString() = "Class:shaka-text-container")) Or
                   ((evenArray(1)?.ToString() = "Value:DIV") And
                   (evenArray(2)?.ToString() = "Class:ad-cta-overlay")) Or
                    ((evenArray(1)?.ToString() = "Value:IMG") And
                   ((evenArray(3)?.ToString() = "Alt:play" Or evenArray(3)?.ToString() = "Alt:pause"))) Or
                   ((evenArray(1)?.ToString() = "Value:DIV") And
                   ((evenArray(2)?.ToString() = "Class:player-icon player-control play" Or evenArray(2)?.ToString() = "Class:player-icon player-control pause"))) Then
                        Me.Isplay = If(evenArray(4)?.ToString() = "Play:true", True, False)

                    ElseIf ((evenArray(2)?.ToString() = "Class:duration-ends")) Then
                        Me.Isplay = False
                        If (Me.WindowState = FormWindowState.Normal) Then
                            HoverForm.pausenplay.Image = If(Me.Isplay, My.Resources.pause, My.Resources.play)
                        End If

                    End If

            End Select
        Catch ex As Exception

        End Try
    End Sub
    Public Async Sub PlayPause()
        Dim PPclass As String = "player-icon player-control "
        Dim playRpause As String = "document.getElementsByClassName('" & If(Isplay, (PPclass & "pause"), (PPclass & "play")) & "')[0].click();"
        Await WebView21.CoreWebView2.ExecuteScriptAsync(playRpause)
    End Sub
    Public Sub pipToggle()
        If Me.isPIPenabled Then
            Me.MinimumSize = New System.Drawing.Size(0, 0)
            Me.WindowState = FormWindowState.Normal
            Me.FormBorder.Hide()
            Me.TopMost = True
            Me.prevHeight = Me.Height
            Me.prevWidth = Me.Width
            Me.prevLocation = Me.Location
            Me.Height = Convert.ToInt16(Screen.PrimaryScreen.WorkingArea.Height * My.Settings.PiP)
            Me.Width = Convert.ToInt16(Screen.PrimaryScreen.WorkingArea.Width * My.Settings.PiP)
            Me.Location = New Point(Screen.PrimaryScreen.WorkingArea.Width - Me.Width, Screen.PrimaryScreen.WorkingArea.Height - Me.Height)
            HoverForm.Show()
            HoverForm.Height = Me.Height
            HoverForm.Width = Me.Width
            HoverForm.Location = Me.Location
            HoverForm.TopMost = True


        Else
            Me.MinimumSize = New System.Drawing.Size(590, 360)
            If (Me.prevHeight <> 0 And Me.prevWidth <> 0) Then
                Me.Height = Me.prevHeight
                Me.Width = Me.prevWidth
            End If
            Me.Location = If(Me.prevLocation <> Point.Empty, Me.prevLocation, Me.Location)
            Me.prevLocation = Point.Empty
            Me.WindowState = FormWindowState.Maximized
            Me.maxminBtn.Image = My.Resources.sm_square_white
            Me.tooltip.SetToolTip(maxminBtn, "Normal")
            'Me.FormBorderStyle = FormBorderStyle.None
            Me.FormBorder.Hide()
            Me.TopMost = True


            SetWindowPos(Me.Handle, HWND_TOP, 0, 0,
                             Screen.PrimaryScreen.Bounds.Width,
                             Screen.PrimaryScreen.Bounds.Height,
                             SWP_SHOWWINDOW)
            Me.IsfullScreen = True
        End If

    End Sub

    Private Sub FullscreenToggle()
        Try
            If (Me.isPIPenabled = False) Then
                IsfullScreen = If(IsfullScreen, False, True)
                If IsfullScreen Then
                    Me.WindowState = FormWindowState.Maximized
                    Me.maxminBtn.Image = My.Resources.sm_square_white
                    Me.tooltip.SetToolTip(maxminBtn, "Normal")
                    'Me.FormBorderStyle = FormBorderStyle.None
                    Me.FormBorder.Hide()
                    Me.TopMost = True

                    SetWindowPos(Me.Handle, HWND_TOP, 0, 0,
                                     Screen.PrimaryScreen.Bounds.Width,
                                     Screen.PrimaryScreen.Bounds.Height,
                                     SWP_SHOWWINDOW)

                Else
                    Me.WindowState = FormWindowState.Maximized
                    Me.maxminBtn.Image = My.Resources.sm_square_white
                    Me.tooltip.SetToolTip(maxminBtn, "Normal")
                    'Me.FormBorderStyle = FormBorderStyle.Sizable
                    Me.FormBorder.Show()
                    Me.TopMost = False
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Async Sub WebView21_KeyDown(sender As Object, e As KeyEventArgs) Handles WebView21.KeyDown
        Try

            If ((e.KeyCode = Keys.Escape) And IsfullScreen) Then
                Me.FullscreenToggle()

            ElseIf ((e.KeyCode = Keys.LWin Or e.KeyCode = Keys.LWin) And IsfullScreen) Then
                Dim windowskey_Script As String = "document.getElementsByClassName('fullscreen player-control')[0].click();"
                Await WebView21.CoreWebView2.ExecuteScriptAsync(windowskey_Script)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub WebView21_SourceChanged(sender As Object, e As CoreWebView2SourceChangedEventArgs) Handles WebView21.SourceChanged
        Me.Isplay = True
        BeLazy()
    End Sub

    Public Sub BeLazy()
        Try

            For i = 1 To 10
                Threading.Thread.Sleep(100)
                Application.DoEvents()
                WebView21.CoreWebView2.ExecuteScriptAsync(BackScript)
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub FormBorder_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles FormBorder.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            lbuttonDown = True
            firstX = e.X
            firstY = e.Y
        End If
    End Sub

    Private Sub FormBorder_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles FormBorder.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Left Then
            lbuttonDown = False
        End If
    End Sub

    Private Sub FormBorder_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles FormBorder.MouseMove
        If lbuttonDown Then
            Me.Left = -firstX + PointToScreen(e.Location).X
            Me.Top = PointToScreen(e.Location).Y
        End If
    End Sub
    Private Sub Titlepanel_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Titlepanel.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            lbuttonDown = True
            firstX = e.X
            firstY = e.Y
        End If
    End Sub

    Private Sub Titlepanel_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Titlepanel.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Left Then
            lbuttonDown = False
        End If
    End Sub

    Private Sub Titlepanel_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Titlepanel.MouseMove
        If lbuttonDown Then
            Me.Left = -firstX + PointToScreen(e.Location).X
            Me.Top = PointToScreen(e.Location).Y
        End If
    End Sub

    Private Sub Hotstar_title_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Hotstar_title.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            lbuttonDown = True
            firstX = e.X
            firstY = e.Y
        End If
    End Sub

    Private Sub Hotstar_title_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Hotstar_title.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Left Then
            lbuttonDown = False
        End If
    End Sub

    Private Sub Hotstar_title_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Hotstar_title.MouseMove
        If lbuttonDown Then
            Me.Left = -firstX + PointToScreen(e.Location).X
            Me.Top = PointToScreen(e.Location).Y
        End If
    End Sub

    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Me.Close()
    End Sub

    Private Sub closeBtn_MouseHover(sender As Object, e As EventArgs) Handles closeBtn.MouseHover
        Me.closeBtn.BackColor = Color.DarkRed
    End Sub

    Private Sub closeBtn_MouseLeave(sender As Object, e As EventArgs) Handles closeBtn.MouseLeave
        Me.closeBtn.BackColor = Color.Transparent
    End Sub

    Private Sub minBtn_Click(sender As Object, e As EventArgs) Handles minBtn.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub maxORnormal()
        If (Me.WindowState = FormWindowState.Normal) Then
            Me.maxminBtn.Image = My.Resources.sm_square_white
            Me.WindowState = FormWindowState.Maximized
            Me.tooltip.SetToolTip(maxminBtn, "Normal")
            Me.DoubleBuffered = False
            Me.SetStyle(ControlStyles.ResizeRedraw, False)
        Else
            Me.maxminBtn.Image = My.Resources.sm_maxiwhite
            Me.WindowState = FormWindowState.Normal
            Me.tooltip.SetToolTip(maxminBtn, "Maximize")
            Me.DoubleBuffered = True
            Me.SetStyle(ControlStyles.ResizeRedraw, True)
        End If
    End Sub
    Private Sub maxminBtn_Click(sender As Object, e As EventArgs) Handles maxminBtn.Click
        Me.maxORnormal()

    End Sub

    Private Sub minBtn_MouseHover(sender As Object, e As EventArgs) Handles minBtn.MouseHover
        If (LoaderImg.Visible = True) Then
            minBtn.BackColor = ColorTranslator.FromHtml("#202445")
        Else
            minBtn.BackColor = ColorTranslator.FromHtml("#2a303c")
        End If


    End Sub

    Private Sub maxminBtn_MouseHover(sender As Object, e As EventArgs) Handles maxminBtn.MouseHover
        If (LoaderImg.Visible = True) Then
            maxminBtn.BackColor = ColorTranslator.FromHtml("#202445")
        Else
            maxminBtn.BackColor = ColorTranslator.FromHtml("#2a303c")
        End If

    End Sub

    Private Sub minBtn_MouseLeave(sender As Object, e As EventArgs) Handles minBtn.MouseLeave
        minBtn.BackColor = Color.Transparent
    End Sub

    Private Sub maxminBtn_MouseLeave(sender As Object, e As EventArgs) Handles maxminBtn.MouseLeave
        maxminBtn.BackColor = Color.Transparent
    End Sub

    Private Sub FormBorder_DoubleClick(sender As Object, e As EventArgs) Handles FormBorder.DoubleClick
        Me.maxORnormal()
    End Sub
    Private Sub Form1_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        If IsfullScreen = False And isPIPenabled = False Then

            Dim MF_Rect As New Rectangle(5, 5, Me.ClientSize.Width, Me.ClientSize.Height)
            Dim MF_Color = New SolidBrush(ColorTranslator.FromHtml("#141b29"))
            e.Graphics.FillRectangle(MF_Color, MF_Rect)
            contentContainer.Padding = New Padding(5, 0, 5, 5)
            If (Me.LoaderImg.Visible) Then
                Me.contentContainer.BackColor = ColorTranslator.FromHtml("#111e53")
            Else
                contentContainer.BackColor = ColorTranslator.FromHtml("#141b29")
                Me.BackColor = ColorTranslator.FromHtml("#141b29")
            End If
        Else
            contentContainer.Padding = New Padding(0, 0, 0, 0)
            contentContainer.BackColor = ColorTranslator.FromHtml("#141b29")
            Me.BackColor = Color.Black
        End If

    End Sub

    Private Sub Titlepanel_DoubleClick(sender As Object, e As EventArgs) Handles Titlepanel.DoubleClick
        Me.maxORnormal()
    End Sub

    Private Sub Hotstar_title_DoubleClick(sender As Object, e As EventArgs) Handles Hotstar_title.DoubleClick
        Me.maxORnormal()
    End Sub

    Private Const HTLEFT As Integer = 10, HTRIGHT As Integer = 11, HTTOP As Integer = 12, HTTOPLEFT As Integer = 13, HTTOPRIGHT As Integer = 14, HTBOTTOM As Integer = 15, HTBOTTOMLEFT As Integer = 16, HTBOTTOMRIGHT As Integer = 17

    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        MyBase.WndProc(m)
        If Me.WindowState = FormWindowState.Normal Then
            If m.Msg = &H84 Then
                Dim mp = Me.PointToClient(Cursor.Position)

                If TopLeft.Contains(mp) Then
                    m.Result = CType(HTTOPLEFT, IntPtr)
                ElseIf TopRight.Contains(mp) Then
                    m.Result = CType(HTTOPRIGHT, IntPtr)
                ElseIf BottomLeft.Contains(mp) Then
                    m.Result = CType(HTBOTTOMLEFT, IntPtr)
                ElseIf BottomRight.Contains(mp) Then
                    m.Result = CType(HTBOTTOMRIGHT, IntPtr)
                ElseIf FTop.Contains(mp) Then
                    m.Result = CType(HTTOP, IntPtr)
                ElseIf FLeft.Contains(mp) Then
                    m.Result = CType(HTLEFT, IntPtr)
                ElseIf FRight.Contains(mp) Then
                    m.Result = CType(HTRIGHT, IntPtr)
                ElseIf FBottom.Contains(mp) Then
                    m.Result = CType(HTBOTTOM, IntPtr)
                End If
            End If
        End If
    End Sub

    Dim rng As New Random
    Function randomColour() As Color
        Return Color.FromArgb(255, rng.Next(255), rng.Next(255), rng.Next(255))
    End Function

    Const ImaginaryBorderSize As Integer = 16

    Function FTop() As Rectangle
        Return New Rectangle(0, 0, Me.ClientSize.Width, ImaginaryBorderSize)
    End Function

    Private Sub settingsbtn_Click(sender As Object, e As EventArgs) Handles settingsbtn.Click

    End Sub

    Function FLeft() As Rectangle
        Return New Rectangle(0, 0, ImaginaryBorderSize, Me.ClientSize.Height)
    End Function

    Function FBottom() As Rectangle
        Return New Rectangle(0, Me.ClientSize.Height - ImaginaryBorderSize, Me.ClientSize.Width, ImaginaryBorderSize)
    End Function

    Function FRight() As Rectangle
        Return New Rectangle(Me.ClientSize.Width - ImaginaryBorderSize, 0, ImaginaryBorderSize, Me.ClientSize.Height)
    End Function

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        My.Settings.PiP = 0.3
        My.Settings.Save()
        Me.configSettings()
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        My.Settings.PiP = 0.35
        My.Settings.Save()
        Me.configSettings()
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        My.Settings.PiP = 0.4
        My.Settings.Save()
        Me.configSettings()
    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click
        My.Settings.PiP = 0.45
        My.Settings.Save()
        Me.configSettings()
    End Sub

    Private Sub ToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem6.Click
        My.Settings.PiP = 0.5
        My.Settings.Save()
        Me.configSettings()
    End Sub

    Private Sub EnabledToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnabledToolStripMenuItem.Click
        My.Settings.WaterMark = True
        My.Settings.Save()
        Me.configSettings()
    End Sub

    Private Sub DisabledToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisabledToolStripMenuItem.Click
        My.Settings.WaterMark = False
        My.Settings.Save()
        Me.configSettings()
    End Sub

    Function TopLeft() As Rectangle
        Return New Rectangle(0, 0, ImaginaryBorderSize, ImaginaryBorderSize)
    End Function

    Function TopRight() As Rectangle
        Return New Rectangle(Me.ClientSize.Width - ImaginaryBorderSize, 0, ImaginaryBorderSize, ImaginaryBorderSize)
    End Function

    Function BottomLeft() As Rectangle
        Return New Rectangle(0, Me.ClientSize.Height - ImaginaryBorderSize, ImaginaryBorderSize, ImaginaryBorderSize)
    End Function

    Function BottomRight() As Rectangle
        Return New Rectangle(Me.ClientSize.Width - ImaginaryBorderSize, Me.ClientSize.Height - ImaginaryBorderSize, ImaginaryBorderSize, ImaginaryBorderSize)
    End Function

    Private Sub settingsbtn_MouseHover(sender As Object, e As EventArgs) Handles settingsbtn.MouseHover
        If (LoaderImg.Visible = True) Then
            settingsbtn.BackColor = ColorTranslator.FromHtml("#202445")
        Else
            settingsbtn.BackColor = ColorTranslator.FromHtml("#2a303c")
        End If
    End Sub

    Private Sub settingsbtn_MouseLeave(sender As Object, e As EventArgs) Handles settingsbtn.MouseLeave
        settingsbtn.BackColor = Color.Transparent
    End Sub

    Public Sub configSettings()

        Me.ToolStripMenuItem2.Image = Nothing
        Me.ToolStripMenuItem3.Image = Nothing
        Me.ToolStripMenuItem4.Image = Nothing
        Me.ToolStripMenuItem5.Image = Nothing
        Me.ToolStripMenuItem6.Image = Nothing

        Select Case My.Settings.PiP
            Case 0.3
                Me.ToolStripMenuItem2.Image = My.Resources.tick
            Case 0.35
                Me.ToolStripMenuItem3.Image = My.Resources.tick
            Case 0.4
                Me.ToolStripMenuItem4.Image = My.Resources.tick
            Case 0.45
                Me.ToolStripMenuItem5.Image = My.Resources.tick
            Case 0.5
                Me.ToolStripMenuItem6.Image = My.Resources.tick
        End Select

        If My.Settings.WaterMark Then
            Me.DisabledToolStripMenuItem.Image = Nothing
            Me.EnabledToolStripMenuItem.Image = My.Resources.tick
            Me.WebView21.CoreWebView2.ExecuteScriptAsync("watermark = true;")
        Else
            Me.EnabledToolStripMenuItem.Image = Nothing
            Me.DisabledToolStripMenuItem.Image = My.Resources.tick
            Me.WebView21.CoreWebView2.ExecuteScriptAsync("watermark = false;")
        End If
    End Sub

    Private Sub settingsbtn_MouseDown(sender As Object, e As MouseEventArgs) Handles settingsbtn.MouseDown
        If e.Button = MouseButtons.Right Then
            Me.settingsbtn.ContextMenuStrip = Nothing
        ElseIf e.Button = MouseButtons.Left Then
            Me.settingsMenu.Show(CType(settingsbtn, Control), New Point(e.X, e.Y + 60), CType(LeftRightAlignment.Right, ToolStripDropDownDirection))
            'Me.settingsbtn.ContextMenuStrip = settingsMenu

        End If

    End Sub


End Class
