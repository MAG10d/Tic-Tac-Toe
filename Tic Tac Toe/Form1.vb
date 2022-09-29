Public Class Form1

    Dim checker As Boolean
    Dim plusone As Integer

    Private Sub Enable_False()
        btn1.Enabled = False
        btn2.Enabled = False
        btn3.Enabled = False
        btn4.Enabled = False
        btn5.Enabled = False
        btn6.Enabled = False
        btn7.Enabled = False
        btn8.Enabled = False
        btn9.Enabled = False
    End Sub

    Private Sub score()
        If (btn1.Text = "X" And btn2.Text = "X" And btn3.Text = "X") Then
            btn1.BackColor = System.Drawing.Color.PowderBlue
            btn2.BackColor = System.Drawing.Color.PowderBlue
            btn3.BackColor = System.Drawing.Color.PowderBlue
            MessageBox.Show("玩家 X 勝出", "過三關", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(lblPlayerXMark.Text)
            lblPlayerXMark.Text = Convert.ToString(plusone + 1)
            Enable_False()
        End If

        If (btn1.Text = "X" And btn4.Text = "X" And btn7.Text = "X") Then
            btn1.BackColor = System.Drawing.Color.Pink
            btn4.BackColor = System.Drawing.Color.Pink
            btn7.BackColor = System.Drawing.Color.Pink
            MessageBox.Show("玩家 X 勝出", "過三關", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(lblPlayerXMark.Text)
            lblPlayerXMark.Text = Convert.ToString(plusone + 1)
            Enable_False()
        End If

        If (btn1.Text = "X" And btn5.Text = "X" And btn9.Text = "X") Then
            btn1.BackColor = System.Drawing.Color.Crimson
            btn5.BackColor = System.Drawing.Color.Crimson
            btn9.BackColor = System.Drawing.Color.Crimson
            MessageBox.Show("玩家 X 勝出", "過三關", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(lblPlayerXMark.Text)
            lblPlayerXMark.Text = Convert.ToString(plusone + 1)
            Enable_False()
        End If

        If (btn3.Text = "X" And btn5.Text = "X" And btn7.Text = "X") Then
            btn3.BackColor = System.Drawing.Color.CadetBlue
            btn5.BackColor = System.Drawing.Color.CadetBlue
            btn7.BackColor = System.Drawing.Color.CadetBlue
            MessageBox.Show("玩家 X 勝出", "過三關", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(lblPlayerXMark.Text)
            lblPlayerXMark.Text = Convert.ToString(plusone + 1)
            Enable_False()
        End If

        If (btn2.Text = "X" And btn5.Text = "X" And btn8.Text = "X") Then
            btn2.BackColor = System.Drawing.Color.SlateBlue
            btn5.BackColor = System.Drawing.Color.SlateBlue
            btn8.BackColor = System.Drawing.Color.SlateBlue
            MessageBox.Show("玩家 X 勝出", "過三關", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(lblPlayerXMark.Text)
            lblPlayerXMark.Text = Convert.ToString(plusone + 1)
            Enable_False()
        End If

        If (btn3.Text = "X" And btn6.Text = "X" And btn9.Text = "X") Then
            btn3.BackColor = System.Drawing.Color.Violet
            btn6.BackColor = System.Drawing.Color.Violet
            btn9.BackColor = System.Drawing.Color.Violet
            MessageBox.Show("玩家 X 勝出", "過三關", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(lblPlayerXMark.Text)
            lblPlayerXMark.Text = Convert.ToString(plusone + 1)
            Enable_False()
        End If

        If (btn1.Text = "X" And btn5.Text = "X" And btn9.Text = "X") Then
            btn1.BackColor = System.Drawing.Color.DarkSlateBlue
            btn3.BackColor = System.Drawing.Color.DarkSlateBlue
            btn9.BackColor = System.Drawing.Color.DarkSlateBlue
            MessageBox.Show("玩家 X 勝出", "過三關", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(lblPlayerXMark.Text)
            lblPlayerXMark.Text = Convert.ToString(plusone + 1)
            Enable_False()
        End If

        If (btn7.Text = "X" And btn8.Text = "X" And btn9.Text = "X") Then
            btn7.BackColor = System.Drawing.Color.Azure
            btn8.BackColor = System.Drawing.Color.Azure
            btn9.BackColor = System.Drawing.Color.Azure
            MessageBox.Show("玩家 X 勝出", "過三關", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(lblPlayerXMark.Text)
            lblPlayerXMark.Text = Convert.ToString(plusone + 1)
            Enable_False()
        End If

        '-------------------------------------------------------------------------------


        If (btn1.Text = "O" And btn2.Text = "O" And btn3.Text = "O") Then
            btn1.BackColor = System.Drawing.Color.PowderBlue
            btn2.BackColor = System.Drawing.Color.PowderBlue
            btn3.BackColor = System.Drawing.Color.PowderBlue
            MessageBox.Show("玩家 O 勝出", "過三關", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(lblPlayerOMark.Text)
            lblPlayerOMark.Text = Convert.ToString(plusone + 1)
            Enable_False()
        End If

        If (btn1.Text = "O" And btn4.Text = "O" And btn7.Text = "O") Then
            btn1.BackColor = System.Drawing.Color.Pink
            btn4.BackColor = System.Drawing.Color.Pink
            btn7.BackColor = System.Drawing.Color.Pink
            MessageBox.Show("玩家 O 勝出", "過三關", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(lblPlayerOMark.Text)
            lblPlayerOMark.Text = Convert.ToString(plusone + 1)
            Enable_False()
        End If

        If (btn1.Text = "O" And btn5.Text = "O" And btn9.Text = "O") Then
            btn1.BackColor = System.Drawing.Color.Crimson
            btn5.BackColor = System.Drawing.Color.Crimson
            btn9.BackColor = System.Drawing.Color.Crimson
            MessageBox.Show("玩家 O 勝出", "過三關", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(lblPlayerOMark.Text)
            lblPlayerOMark.Text = Convert.ToString(plusone + 1)
            Enable_False()
        End If

        If (btn3.Text = "O" And btn5.Text = "O" And btn7.Text = "O") Then
            btn3.BackColor = System.Drawing.Color.CadetBlue
            btn5.BackColor = System.Drawing.Color.CadetBlue
            btn7.BackColor = System.Drawing.Color.CadetBlue
            MessageBox.Show("玩家 O 勝出", "過三關", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(lblPlayerOMark.Text)
            lblPlayerOMark.Text = Convert.ToString(plusone + 1)
            Enable_False()
        End If

        If (btn2.Text = "O" And btn5.Text = "O" And btn8.Text = "O") Then
            btn2.BackColor = System.Drawing.Color.SlateBlue
            btn5.BackColor = System.Drawing.Color.SlateBlue
            btn8.BackColor = System.Drawing.Color.SlateBlue
            MessageBox.Show("玩家 O 勝出", "過三關", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(lblPlayerOMark.Text)
            lblPlayerOMark.Text = Convert.ToString(plusone + 1)
            Enable_False()
        End If

        If (btn3.Text = "O" And btn6.Text = "O" And btn9.Text = "O") Then
            btn3.BackColor = System.Drawing.Color.Violet
            btn6.BackColor = System.Drawing.Color.Violet
            btn9.BackColor = System.Drawing.Color.Violet
            MessageBox.Show("玩家 O 勝出", "過三關", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(lblPlayerOMark.Text)
            lblPlayerOMark.Text = Convert.ToString(plusone + 1)
            Enable_False()
        End If

        If (btn1.Text = "O" And btn5.Text = "O" And btn9.Text = "O") Then
            btn1.BackColor = System.Drawing.Color.DarkSlateBlue
            btn3.BackColor = System.Drawing.Color.DarkSlateBlue
            btn9.BackColor = System.Drawing.Color.DarkSlateBlue
            MessageBox.Show("玩家 O 勝出", "過三關", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(lblPlayerOMark.Text)
            lblPlayerOMark.Text = Convert.ToString(plusone + 1)
            Enable_False()
        End If

        If (btn7.Text = "O" And btn8.Text = "O" And btn9.Text = "O") Then
            btn7.BackColor = System.Drawing.Color.Azure
            btn8.BackColor = System.Drawing.Color.Azure
            btn9.BackColor = System.Drawing.Color.Azure
            MessageBox.Show("玩家 O 勝出", "過三關", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(lblPlayerOMark.Text)
            lblPlayerOMark.Text = Convert.ToString(plusone + 1)
            Enable_False()
        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles btnqwq.Click
        btn1.Enabled = True
        btn2.Enabled = True
        btn3.Enabled = True
        btn4.Enabled = True
        btn5.Enabled = True
        btn6.Enabled = True
        btn7.Enabled = True
        btn8.Enabled = True
        btn9.Enabled = True

        btn1.Text = ""
        btn2.Text = ""
        btn3.Text = ""
        btn4.Text = ""
        btn5.Text = ""
        btn6.Text = ""
        btn7.Text = ""
        btn8.Text = ""
        btn9.Text = ""

        btn1.BackColor = System.Drawing.Color.WhiteSmoke
        btn2.BackColor = System.Drawing.Color.WhiteSmoke
        btn3.BackColor = System.Drawing.Color.WhiteSmoke
        btn4.BackColor = System.Drawing.Color.WhiteSmoke
        btn5.BackColor = System.Drawing.Color.WhiteSmoke
        btn6.BackColor = System.Drawing.Color.WhiteSmoke
        btn7.BackColor = System.Drawing.Color.WhiteSmoke
        btn8.BackColor = System.Drawing.Color.WhiteSmoke
        btn9.BackColor = System.Drawing.Color.WhiteSmoke
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        If (checker = False) Then
            btn1.Text = "X"
            checker = True
        Else
            btn1.Text = "O"
            checker = False
        End If
        score()
        btn1.Enabled = False
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        If (checker = False) Then
            btn2.Text = "X"
            checker = True
        Else
            btn2.Text = "O"
            checker = False
        End If
        score()
        btn2.Enabled = False
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        If (checker = False) Then
            btn3.Text = "X"
            checker = True
        Else
            btn3.Text = "O"
            checker = False
        End If
        score()
        btn3.Enabled = False
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        If (checker = False) Then
            btn4.Text = "X"
            checker = True
        Else
            btn4.Text = "O"
            checker = False
        End If
        score()
        btn4.Enabled = False
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        If (checker = False) Then
            btn5.Text = "X"
            checker = True
        Else
            btn5.Text = "O"
            checker = False
        End If
        score()
        btn5.Enabled = False
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        If (checker = False) Then
            btn6.Text = "X"
            checker = True
        Else
            btn6.Text = "O"
            checker = False
        End If
        score()
        btn6.Enabled = False
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        If (checker = False) Then
            btn7.Text = "X"
            checker = True
        Else
            btn7.Text = "O"
            checker = False
        End If
        score()
        btn7.Enabled = False
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        If (checker = False) Then
            btn8.Text = "X"
            checker = True
        Else
            btn8.Text = "O"
            checker = False
        End If
        score()
        btn8.Enabled = False
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        If (checker = False) Then
            btn9.Text = "X"
            checker = True
        Else
            btn9.Text = "O"
            checker = False
        End If
        score()
        btn9.Enabled = False
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim iExit As DialogResult

        iExit = MessageBox.Show("主人，你要離開我了嗎＞︿＜", "過三關娘", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If iExit = DialogResult.Yes Then
            Application.Exit()
        Else
            PictureBox1.Visible = True
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        btn1.Enabled = True
        btn2.Enabled = True
        btn3.Enabled = True
        btn4.Enabled = True
        btn5.Enabled = True
        btn6.Enabled = True
        btn7.Enabled = True
        btn8.Enabled = True
        btn9.Enabled = True

        btn1.Text = ""
        btn2.Text = ""
        btn3.Text = ""
        btn4.Text = ""
        btn5.Text = ""
        btn6.Text = ""
        btn7.Text = ""
        btn8.Text = ""
        btn9.Text = ""

        btn1.BackColor = System.Drawing.Color.WhiteSmoke
        btn2.BackColor = System.Drawing.Color.WhiteSmoke
        btn3.BackColor = System.Drawing.Color.WhiteSmoke
        btn4.BackColor = System.Drawing.Color.WhiteSmoke
        btn5.BackColor = System.Drawing.Color.WhiteSmoke
        btn6.BackColor = System.Drawing.Color.WhiteSmoke
        btn7.BackColor = System.Drawing.Color.WhiteSmoke
        btn8.BackColor = System.Drawing.Color.WhiteSmoke
        btn9.BackColor = System.Drawing.Color.WhiteSmoke

        lblPlayerXMark.Text = "0"
        lblPlayerOMark.Text = "0"
        btnqwq.Enabled = True
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
End Class
