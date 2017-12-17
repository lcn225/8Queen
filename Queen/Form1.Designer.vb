<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 八皇后问题
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.View_DataGridView = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nextAnswer_Button = New System.Windows.Forms.Button()
        Me.Move_Button = New System.Windows.Forms.Button()
        Me.Answer_ListBox = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AS_Button = New System.Windows.Forms.Button()
        CType(Me.View_DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'View_DataGridView
        '
        Me.View_DataGridView.AllowUserToAddRows = False
        Me.View_DataGridView.AllowUserToDeleteRows = False
        Me.View_DataGridView.AllowUserToResizeColumns = False
        Me.View_DataGridView.AllowUserToResizeRows = False
        Me.View_DataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.View_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.View_DataGridView.ColumnHeadersVisible = False
        Me.View_DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8})
        Me.View_DataGridView.Location = New System.Drawing.Point(28, 42)
        Me.View_DataGridView.Name = "View_DataGridView"
        Me.View_DataGridView.ReadOnly = True
        Me.View_DataGridView.RowHeadersVisible = False
        Me.View_DataGridView.RowHeadersWidth = 20
        Me.View_DataGridView.RowTemplate.Height = 23
        Me.View_DataGridView.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.View_DataGridView.Size = New System.Drawing.Size(320, 320)
        Me.View_DataGridView.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.Frozen = True
        Me.Column1.HeaderText = "Column1"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.Frozen = True
        Me.Column2.HeaderText = "Column2"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.Frozen = True
        Me.Column3.HeaderText = "Column3"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.Frozen = True
        Me.Column4.HeaderText = "Column4"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.Frozen = True
        Me.Column5.HeaderText = "Column5"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.Frozen = True
        Me.Column6.HeaderText = "Column6"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.Frozen = True
        Me.Column7.HeaderText = "Column7"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.Frozen = True
        Me.Column8.HeaderText = "Column8"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'nextAnswer_Button
        '
        Me.nextAnswer_Button.Location = New System.Drawing.Point(91, 384)
        Me.nextAnswer_Button.Name = "nextAnswer_Button"
        Me.nextAnswer_Button.Size = New System.Drawing.Size(75, 23)
        Me.nextAnswer_Button.TabIndex = 1
        Me.nextAnswer_Button.Text = "求解"
        Me.nextAnswer_Button.UseVisualStyleBackColor = True
        '
        'Move_Button
        '
        Me.Move_Button.Location = New System.Drawing.Point(231, 384)
        Me.Move_Button.Name = "Move_Button"
        Me.Move_Button.Size = New System.Drawing.Size(75, 23)
        Me.Move_Button.TabIndex = 2
        Me.Move_Button.Text = "移动"
        Me.Move_Button.UseVisualStyleBackColor = True
        '
        'Answer_ListBox
        '
        Me.Answer_ListBox.FormattingEnabled = True
        Me.Answer_ListBox.ItemHeight = 12
        Me.Answer_ListBox.Location = New System.Drawing.Point(371, 42)
        Me.Answer_ListBox.Name = "Answer_ListBox"
        Me.Answer_ListBox.Size = New System.Drawing.Size(149, 244)
        Me.Answer_ListBox.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(369, 303)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 12)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Label1"
        '
        'AS_Button
        '
        Me.AS_Button.Location = New System.Drawing.Point(350, 383)
        Me.AS_Button.Name = "AS_Button"
        Me.AS_Button.Size = New System.Drawing.Size(75, 23)
        Me.AS_Button.TabIndex = 5
        Me.AS_Button.Text = "全解"
        Me.AS_Button.UseVisualStyleBackColor = True
        '
        '八皇后问题
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 441)
        Me.Controls.Add(Me.AS_Button)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Answer_ListBox)
        Me.Controls.Add(Me.Move_Button)
        Me.Controls.Add(Me.nextAnswer_Button)
        Me.Controls.Add(Me.View_DataGridView)
        Me.Name = "八皇后问题"
        Me.Text = "八皇后问题"
        CType(Me.View_DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents View_DataGridView As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents nextAnswer_Button As Button
    Friend WithEvents Move_Button As Button
    Friend WithEvents Answer_ListBox As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents AS_Button As Button
End Class
