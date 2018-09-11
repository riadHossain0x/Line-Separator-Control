Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Partial Public Class LineSeparator
	Inherits UserControl

	Public Sub New()
		AddHandler Me.Paint, AddressOf LineSeparator_Paint
		Me.MaximumSize = New Size(2000, 2)
		Me.MinimumSize = New Size(0, 2)
		Me.Width = 350
	End Sub

	Private Sub LineSeparator_Paint(ByVal sender As Object, ByVal e As PaintEventArgs)
		Dim g As Graphics = e.Graphics
		g.DrawLine(Pens.DarkGray, New Point(0, 0), New Point(Me.Width, 0))
		g.DrawLine(Pens.White, New Point(0, 1), New Point(Me.Width, 1))
	End Sub
End Class
