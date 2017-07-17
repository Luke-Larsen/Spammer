Public Class Form1


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Timer1.Interval = TextBox2.Text 'Sets the interval at the timer1
        Timer1.Enabled = True 'Enables timer1
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Timer1.Interval = TextBox2.Text 'This command is not necessary
        Timer1.Enabled = False 'This stops timer1 repeating the command
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        SendKeys.Send(TextBox1.Text) 'Sends the message you typed in the textbox1
        SendKeys.Send("{enter}") 'presses the ENTER key from your keyboard
    End Sub
End Class
