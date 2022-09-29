<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lblPlayerOMark = New System.Windows.Forms.Label()
        Me.lblPlayerXMark = New System.Windows.Forms.Label()
        Me.lblPlayerO = New System.Windows.Forms.Label()
        Me.btnqwq = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.lblPlayerX = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btn8 = New System.Windows.Forms.Button()
        Me.btn9 = New System.Windows.Forms.Button()
        Me.btn7 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(597, 72)
        Me.Panel1.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Roboto", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(10, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(573, 43)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "過三關高級免安裝綠色福利中文版"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Location = New System.Drawing.Point(12, 90)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(597, 281)
        Me.Panel2.TabIndex = 1
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel5.Controls.Add(Me.lblPlayerOMark)
        Me.Panel5.Controls.Add(Me.lblPlayerXMark)
        Me.Panel5.Controls.Add(Me.lblPlayerO)
        Me.Panel5.Controls.Add(Me.btnqwq)
        Me.Panel5.Controls.Add(Me.btnExit)
        Me.Panel5.Controls.Add(Me.btnReset)
        Me.Panel5.Controls.Add(Me.lblPlayerX)
        Me.Panel5.Location = New System.Drawing.Point(301, 5)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(289, 269)
        Me.Panel5.TabIndex = 3
        '
        'lblPlayerOMark
        '
        Me.lblPlayerOMark.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblPlayerOMark.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPlayerOMark.Font = New System.Drawing.Font("Roboto", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayerOMark.Location = New System.Drawing.Point(142, 68)
        Me.lblPlayerOMark.Name = "lblPlayerOMark"
        Me.lblPlayerOMark.Size = New System.Drawing.Size(131, 43)
        Me.lblPlayerOMark.TabIndex = 14
        Me.lblPlayerOMark.Text = "0"
        Me.lblPlayerOMark.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPlayerXMark
        '
        Me.lblPlayerXMark.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblPlayerXMark.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPlayerXMark.Font = New System.Drawing.Font("Roboto", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayerXMark.Location = New System.Drawing.Point(142, 16)
        Me.lblPlayerXMark.Name = "lblPlayerXMark"
        Me.lblPlayerXMark.Size = New System.Drawing.Size(131, 43)
        Me.lblPlayerXMark.TabIndex = 13
        Me.lblPlayerXMark.Text = "0"
        Me.lblPlayerXMark.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPlayerO
        '
        Me.lblPlayerO.Font = New System.Drawing.Font("Roboto", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayerO.Location = New System.Drawing.Point(15, 68)
        Me.lblPlayerO.Name = "lblPlayerO"
        Me.lblPlayerO.Size = New System.Drawing.Size(131, 43)
        Me.lblPlayerO.TabIndex = 12
        Me.lblPlayerO.Text = "玩家 O"
        '
        'btnqwq
        '
        Me.btnqwq.Font = New System.Drawing.Font("Roboto", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnqwq.Location = New System.Drawing.Point(13, 132)
        Me.btnqwq.Name = "btnqwq"
        Me.btnqwq.Size = New System.Drawing.Size(260, 53)
        Me.btnqwq.TabIndex = 11
        Me.btnqwq.Text = "再來一局"
        Me.btnqwq.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Roboto", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(150, 200)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(123, 53)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "退出"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Roboto", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(13, 200)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(122, 53)
        Me.btnReset.TabIndex = 9
        Me.btnReset.Text = "重置"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'lblPlayerX
        '
        Me.lblPlayerX.Font = New System.Drawing.Font("Roboto", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayerX.Location = New System.Drawing.Point(15, 16)
        Me.lblPlayerX.Name = "lblPlayerX"
        Me.lblPlayerX.Size = New System.Drawing.Size(131, 43)
        Me.lblPlayerX.TabIndex = 0
        Me.lblPlayerX.Text = "玩家 X"
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.btn8)
        Me.Panel4.Controls.Add(Me.btn9)
        Me.Panel4.Controls.Add(Me.btn7)
        Me.Panel4.Controls.Add(Me.btn5)
        Me.Panel4.Controls.Add(Me.btn6)
        Me.Panel4.Controls.Add(Me.btn4)
        Me.Panel4.Controls.Add(Me.btn2)
        Me.Panel4.Controls.Add(Me.btn3)
        Me.Panel4.Controls.Add(Me.btn1)
        Me.Panel4.Location = New System.Drawing.Point(3, 5)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(292, 269)
        Me.Panel4.TabIndex = 2
        '
        'btn8
        '
        Me.btn8.Font = New System.Drawing.Font("Roboto", 38.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn8.Location = New System.Drawing.Point(105, 184)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(79, 69)
        Me.btn8.TabIndex = 8
        Me.btn8.UseVisualStyleBackColor = True
        '
        'btn9
        '
        Me.btn9.Font = New System.Drawing.Font("Roboto", 38.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn9.Location = New System.Drawing.Point(197, 184)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(79, 69)
        Me.btn9.TabIndex = 7
        Me.btn9.UseVisualStyleBackColor = True
        '
        'btn7
        '
        Me.btn7.Font = New System.Drawing.Font("Roboto", 38.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn7.Location = New System.Drawing.Point(12, 184)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(79, 69)
        Me.btn7.TabIndex = 6
        Me.btn7.UseVisualStyleBackColor = True
        '
        'btn5
        '
        Me.btn5.Font = New System.Drawing.Font("Roboto", 38.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn5.Location = New System.Drawing.Point(105, 99)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(79, 69)
        Me.btn5.TabIndex = 5
        Me.btn5.UseVisualStyleBackColor = True
        '
        'btn6
        '
        Me.btn6.Font = New System.Drawing.Font("Roboto", 38.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn6.Location = New System.Drawing.Point(197, 99)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(79, 69)
        Me.btn6.TabIndex = 4
        Me.btn6.UseVisualStyleBackColor = True
        '
        'btn4
        '
        Me.btn4.Font = New System.Drawing.Font("Roboto", 38.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn4.Location = New System.Drawing.Point(12, 99)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(79, 69)
        Me.btn4.TabIndex = 3
        Me.btn4.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.Font = New System.Drawing.Font("Roboto", 38.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn2.Location = New System.Drawing.Point(105, 16)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(79, 69)
        Me.btn2.TabIndex = 2
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.Font = New System.Drawing.Font("Roboto", 38.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn3.Location = New System.Drawing.Point(197, 16)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(79, 69)
        Me.btn3.TabIndex = 1
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btn1
        '
        Me.btn1.Font = New System.Drawing.Font("Roboto", 38.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1.Location = New System.Drawing.Point(12, 16)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(79, 69)
        Me.btn1.TabIndex = 0
        Me.btn1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(17, 377)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(321, 216)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCoral
        Me.ClientSize = New System.Drawing.Size(621, 598)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = ":)"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lblPlayerOMark As Label
    Friend WithEvents lblPlayerXMark As Label
    Friend WithEvents lblPlayerO As Label
    Friend WithEvents btnqwq As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents lblPlayerX As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btn8 As Button
    Friend WithEvents btn9 As Button
    Friend WithEvents btn7 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
