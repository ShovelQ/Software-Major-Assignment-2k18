﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DebugForm
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.DynamicFormCreation1 = New LAMP.DynamicFormCreation()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(68, 52)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(151, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Fill Database with data"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(68, 96)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(151, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "View database"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(68, 143)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(151, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "View Designer"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(68, 187)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(151, 23)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "View Login"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(246, 52)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(151, 23)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Reset Database"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(246, 96)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(151, 23)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "View trophies"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(184, 517)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(151, 23)
        Me.Button7.TabIndex = 6
        Me.Button7.Text = "Test"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(246, 143)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(151, 23)
        Me.Button8.TabIndex = 7
        Me.Button8.Text = "Add template"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(356, 517)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(75, 23)
        Me.Button9.TabIndex = 9
        Me.Button9.Text = "Test2"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(331, 479)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 10
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(246, 186)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(151, 23)
        Me.Button10.TabIndex = 12
        Me.Button10.Text = "ddynamictext"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'DynamicFormCreation1
        '
        Me.DynamicFormCreation1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DynamicFormCreation1.Location = New System.Drawing.Point(486, 52)
        Me.DynamicFormCreation1.Name = "DynamicFormCreation1"
        Me.DynamicFormCreation1.Size = New System.Drawing.Size(684, 480)
        Me.DynamicFormCreation1.TabIndex = 13
        '
        'DebugForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1343, 587)
        Me.Controls.Add(Me.DynamicFormCreation1)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "DebugForm"
        Me.Text = "DebugForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button10 As Button
    Friend WithEvents DynamicFormCreation1 As DynamicFormCreation
End Class
