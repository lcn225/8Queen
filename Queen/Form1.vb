Imports System.IO
Public Class 八皇后问题

    Dim loc(0 To 7) As Integer
    Dim locLine As String
    Dim answerNum As Integer = 1
    Dim queenNum As Integer = 1
    Dim testMode As Boolean = False

    Private Sub formatDGV()

        View_DataGridView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        For index = 1 To 8
            View_DataGridView.Rows.Add()
            View_DataGridView.Rows(index - 1).Height = 40
        Next

        For index = 1 To 8
            View_DataGridView.Columns(index - 1).Width = 40
        Next

        For index = 1 To 8
            For j = 1 To 8
                View_DataGridView.Rows(index - 1).Cells(j - 1).Value = ""
            Next
        Next

    End Sub

    Private Sub displayDGV()

        For index = 1 To 8
            For j = 1 To 8
                View_DataGridView.Rows(index - 1).Cells(j - 1).Value = ""
            Next
        Next

        For index = 1 To 8
            If loc(index - 1) > 0 Then
                View_DataGridView.Rows(index - 1).Cells(loc(index - 1) - 1).Value = "○"
            End If
        Next

    End Sub
    ''在棋盘上展示当前解

    Private Sub displayDGV(ans As String)

        Dim an(0 To 7) As Integer

        For index = 0 To 7
            an(index) = Mid(ans, 2 * index + 4, 1)
        Next

        For index = 1 To 8
            For j = 1 To 8
                View_DataGridView.Rows(index - 1).Cells(j - 1).Value = ""
            Next
        Next

        For index = 1 To 8
            If loc(index - 1) > 0 Then
                View_DataGridView.Rows(index - 1).Cells(an(index - 1) - 1).Value = "○"
            End If
        Next

    End Sub
    ''在棋盘上展示指定借

    Private Sub textshow()

        Label1.Text = "目前：" & answerNum & vbCrLf

        For index = 1 To 8
            Label1.Text = Label1.Text & index & ": " & index & "," & loc(index - 1) & vbCrLf
        Next
    End Sub

    Private Sub movequeen(i As Integer)
        ''i即为queenNum，从1~8

        Dim k As Integer
        ''定义比较棋子的编号

        If i = 1 Then
            loc(i - 1) += 1
            ''放置第一行的棋子
            queenNum += 1
            Exit Sub
            ''如果是第一行的棋子，放好后直接结束
        End If

        For j = (loc(i - 1) + 1) To 8
            ''尝试第j列，从loc(i)+1开始。
            Dim flag As Integer = 0
            ''设置flag为0，开始比较之前的棋子
            For k = 1 To i - 1
                    ''从第一个棋子开始对比是否冲突，直到前一个棋子
                    If j = loc(k - 1) Or Math.Abs(i - k) = Math.Abs(j - loc(k - 1)) Then
                        flag += 1
                        ''如果有冲突，flag+1，不比较剩下的棋子
                        Exit For
                        ''如果没有冲突，则比较下一个结果
                    End If
                Next
                ''所有棋子比较完毕
                If flag = 0 Then
                    loc(i - 1) = j
                    queenNum += 1
                    Exit Sub
                    ''如果没冲突，记录列数，结束
                End If
            ''如果有冲突，继续
        Next

        ''到达这里表示全部列比较完毕仍然有冲突

        For n = i - 1 To 7
            loc(n) = 0
        Next
        ''消除之后的所有结果

        i = i - 1
        queenNum = queenNum - 1
        ''从上一个棋子开始
        movequeen(i)

    End Sub
    ''找到第i个棋子的放法

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        formatDGV()
        textshow()
    End Sub

    Private Sub Move_Button_Click(sender As Object, e As EventArgs) Handles Move_Button.Click
        movequeen(queenNum)

        textshow()
        displayDGV()
    End Sub

    Private Sub locToString()
        locLine = loc(0) & " " & loc(1) & " " & loc(2) & " " & loc(3) & " " & loc(4) & " " & loc(5) & " " & loc(6) & " " & loc(7)
    End Sub
    ''将当前放置方法生产字符串

    Private Sub answerToLB()
        locToString()
        Answer_ListBox.Items.Add(answerNum & ": " & locLine)
        answerNum += 1
    End Sub
    ''将答案写入LB

    Private Sub nextAnswer_Button_Click(sender As Object, e As EventArgs) Handles nextAnswer_Button.Click

        FileOpen(1, "Log.txt", OpenMode.Output)

        If queenNum = 9 Then
            queenNum = 8
        End If
        ''如果放好8个棋子了，则继续动第八个棋子（即继续找下一个解）

        While queenNum < 9
            movequeen(queenNum)

            If testMode Then
                locToString()
                PrintLine(1, locLine & vbCrLf)
            End If
            ''调试模式，写入LOG

        End While
        ''当放好8个棋子之前，重复Move

        answerToLB()
        ''将答案写入LB

        textshow()
        displayDGV()

        FileClose(1)

    End Sub

    Private Sub Answer_ListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Answer_ListBox.SelectedIndexChanged
        Dim ans As String = Answer_ListBox.SelectedItem.ToString
        displayDGV(ans)
    End Sub
End Class
