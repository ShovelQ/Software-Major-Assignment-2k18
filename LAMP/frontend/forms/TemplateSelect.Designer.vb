﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TemplateSelect
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TemplateSelect))
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrev = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbSort = New System.Windows.Forms.ComboBox()
        Me.lblSort = New System.Windows.Forms.Label()
        Me.MultiTemplateViewer1 = New LAMP.MultiTemplateViewer()
        Me.ToolBar1 = New LAMP.ToolBar()
        Me.SuspendLayout()
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(867, 710)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(42, 25)
        Me.btnNext.TabIndex = 4
        Me.btnNext.Text = "->"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnPrev
        '
        Me.btnPrev.Location = New System.Drawing.Point(819, 710)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(42, 25)
        Me.btnPrev.TabIndex = 5
        Me.btnPrev.Text = "<-"
        Me.btnPrev.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(827, 735)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Prev"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(875, 735)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "next"
        '
        'cmbSort
        '
        Me.cmbSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSort.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSort.FormattingEnabled = True
        Me.cmbSort.Items.AddRange(New Object() {"Creator (Alphabetical)", "Date Created", "Height (Ascending)", "Height (Descending)", "Material", "Name (Alphabetical)", "Width (Ascending)", "Width (Descending)"})
        Me.cmbSort.Location = New System.Drawing.Point(1031, 120)
        Me.cmbSort.Name = "cmbSort"
        Me.cmbSort.Size = New System.Drawing.Size(188, 31)
        Me.cmbSort.Sorted = True
        Me.cmbSort.TabIndex = 17
        '
        'lblSort
        '
        Me.lblSort.AutoSize = True
        Me.lblSort.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSort.Location = New System.Drawing.Point(943, 123)
        Me.lblSort.Name = "lblSort"
        Me.lblSort.Size = New System.Drawing.Size(82, 23)
        Me.lblSort.TabIndex = 13
        Me.lblSort.Text = "Sort By:"
        '
        'MultiTemplateViewer1
        '
        Me.MultiTemplateViewer1.ColumnCount = 4
        Me.MultiTemplateViewer1.Location = New System.Drawing.Point(37, 143)
        Me.MultiTemplateViewer1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MultiTemplateViewer1.Name = "MultiTemplateViewer1"
        Me.MultiTemplateViewer1.RowCount = 2
        Me.MultiTemplateViewer1.Size = New System.Drawing.Size(873, 561)
        Me.MultiTemplateViewer1.TabIndex = 19
        '
        'ToolBar1
        '
        Me.ToolBar1.BackColor = System.Drawing.Color.Fuchsia
        Me.ToolBar1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolBar1.Location = New System.Drawing.Point(0, 0)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.Size = New System.Drawing.Size(1231, 108)
        Me.ToolBar1.TabIndex = 20
        '
        'TemplateSelect
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(1232, 703)
        Me.Controls.Add(Me.ToolBar1)
        Me.Controls.Add(Me.MultiTemplateViewer1)
        Me.Controls.Add(Me.lblSort)
        Me.Controls.Add(Me.cmbSort)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnPrev)
        Me.Controls.Add(Me.btnNext)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "TemplateSelect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Viewer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnNext As Button
    Friend WithEvents btnPrev As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbSort As ComboBox
    Friend WithEvents lblSort As Label
    Friend WithEvents MultiTemplateViewer1 As MultiTemplateViewer
    Friend WithEvents ToolBar1 As ToolBar
End Class
