
Public Class Form1
    Private Sub btnPower_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPower.Click
        SerialPort1.Open()
        SerialPort1.WriteLine("p")
        SerialPort1.Close()
        Me.Focus()
    End Sub
    Private Sub btnVolDwn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolDwn.Click
        SerialPort1.Open()
        SerialPort1.WriteLine("d")
        SerialPort1.Close()
        Me.Focus()
    End Sub
    Private Sub btnVolUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolUp.Click
        SerialPort1.Open()
        SerialPort1.WriteLine("u")
        SerialPort1.Close()
        Me.Focus()
    End Sub
    Private Sub btnOne_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOne.Click
        SerialPort1.Open()
        SerialPort1.WriteLine("1")
        SerialPort1.Close()
        Me.Focus()
    End Sub
    Private Sub btnTwo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTwo.Click
        SerialPort1.Open()
        SerialPort1.WriteLine("2")
        SerialPort1.Close()
        Me.Focus()
    End Sub
    Private Sub btnThree_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThree.Click
        SerialPort1.Open()
        SerialPort1.WriteLine("3")
        SerialPort1.Close()
        Me.Focus()
    End Sub
    Private Sub btnFour_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFour.Click
        SerialPort1.Open()
        SerialPort1.WriteLine("4")
        SerialPort1.Close()
        Me.Focus()
    End Sub
    Private Sub btnFive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFive.Click
        SerialPort1.Open()
        SerialPort1.WriteLine("5")
        SerialPort1.Close()
        Me.Focus()
    End Sub
    Private Sub btnSix_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSix.Click
        SerialPort1.Open()
        SerialPort1.WriteLine("6")
        SerialPort1.Close()
        Me.Focus()
    End Sub
    Private Sub btnSeven_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeven.Click
        SerialPort1.Open()
        SerialPort1.WriteLine("7")
        SerialPort1.Close()
        Me.Focus()
    End Sub
    Private Sub btnEight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEight.Click
        SerialPort1.Open()
        SerialPort1.WriteLine("8")
        SerialPort1.Close()
        Me.Focus()
    End Sub
    Private Sub btnNine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNine.Click
        SerialPort1.Open()
        SerialPort1.WriteLine("9")
        SerialPort1.Close()
        Me.Focus()
    End Sub
    Private Sub btnZero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnZero.Click
        SerialPort1.Open()
       SerialPort1.WriteLine("0")
        SerialPort1.Close()
        Me.Focus()
    End Sub
    Private Sub btnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast.Click
        SerialPort1.Open()
        SerialPort1.WriteLine("l")
        SerialPort1.Close()
        Me.Focus()
    End Sub
    Private Sub btnChUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChUp.Click
        SerialPort1.Open()
        SerialPort1.WriteLine("n")
        SerialPort1.Close()
        Me.Focus()
    End Sub
    Private Sub btnChDwn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChDwn.Click
        SerialPort1.Open()
       SerialPort1.WriteLine("b")
        SerialPort1.Close()
        Me.Focus()
    End Sub
    Private Sub btnMute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMute.Click
        SerialPort1.Open()
        SerialPort1.WriteLine("m")
        SerialPort1.Close()
        Me.Focus()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub Form1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click
        Me.Focus()
    End Sub

    Private Sub Form1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        MessageBox.Show(e.KeyChar)
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Try
        '    SerialPort1.Open()
        'Catch ex As Exception
        '    MessageBox.Show("Remote not detected.  Please attach and restart.")
        '    Me.Close()
        'End Try
        'Me.Focus()
        'SerialPort1.Close()
    End Sub
End Class