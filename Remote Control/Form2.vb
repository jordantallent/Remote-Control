Public Class Form2
    Dim tv = Form1.SerialPort1
    Private Sub Form2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.DoubleClick
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Form2_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        'shows all keys with a KeyCode
        'MessageBox.Show(e.KeyCode)
        If tv.IsOpen = False Then
            tv.Open()
            If e.KeyCode = 32 Then  'power
                tv.WriteLine("p")
            ElseIf e.KeyCode = 38 Then  'channel up
                tv.WriteLine("n")
            ElseIf e.KeyCode = 40 Then  'channel down
                tv.WriteLine("b")
            ElseIf e.KeyCode = 37 Then  'volume down
                tv.WriteLine("d")
            ElseIf e.KeyCode = 39 Then  'volume up
                tv.WriteLine("u")
            ElseIf e.KeyCode = 77 Then  'mute
                tv.WriteLine("m")
            ElseIf e.KeyCode = 8 Then   'prev. channel
                tv.WriteLine("l")
            End If
            tv.Close()
        End If
    End Sub

    Private Sub Form2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If tv.IsOpen = False Then
            tv.Open()
            If e.KeyChar = "1" Then
                tv.Write("1")
            ElseIf e.KeyChar = "2" Then
                tv.WriteLine("2")
            ElseIf e.KeyChar = "3" Then
                tv.WriteLine("3")
            ElseIf e.KeyChar = "4" Then
                tv.WriteLine("4")
            ElseIf e.KeyChar = "5" Then
                tv.WriteLine("5")
            ElseIf e.KeyChar = "6" Then
                tv.WriteLine("6")
            ElseIf e.KeyChar = "7" Then
                tv.WriteLine("7")
            ElseIf e.KeyChar = "8" Then
                tv.WriteLine("8")
            ElseIf e.KeyChar = "9" Then
                tv.WriteLine("9")
            ElseIf e.KeyChar = "0" Then
                tv.WriteLine("0")
            End If
            tv.Close()
        End If
    End Sub
End Class