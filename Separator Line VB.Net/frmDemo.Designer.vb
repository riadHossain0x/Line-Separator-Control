'========================================================================
' This conversion was produced by the Free Edition of
' Instant VB courtesy of Tangible Software Solutions.
' Order the Premium Edition at https://www.tangiblesoftwaresolutions.com
'========================================================================

Namespace Separator_Line
	Partial Public Class frmDemo
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.lineSeparator1 = New LineSeparator()
			Me.label1 = New System.Windows.Forms.Label()
			Me.SuspendLayout()
			' 
			' lineSeparator1
			' 
			Me.lineSeparator1.Location = New System.Drawing.Point(95, 203)
			Me.lineSeparator1.MaximumSize = New System.Drawing.Size(2000, 2)
			Me.lineSeparator1.MinimumSize = New System.Drawing.Size(0, 2)
			Me.lineSeparator1.Name = "lineSeparator1"
			Me.lineSeparator1.Size = New System.Drawing.Size(620, 2)
			Me.lineSeparator1.TabIndex = 1
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label1.Location = New System.Drawing.Point(290, 170)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(230, 25)
			Me.label1.TabIndex = 2
			Me.label1.Text = "Line Separator Control"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(810, 442)
			Me.Controls.Add(Me.label1)
			Me.Controls.Add(Me.lineSeparator1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private lineSeparator1 As LineSeparator
		Private label1 As System.Windows.Forms.Label
	End Class
End Namespace

