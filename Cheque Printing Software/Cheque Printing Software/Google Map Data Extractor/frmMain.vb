Imports System.Threading

Public Class frmMain


    
    Private Sub frmMain_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub

    Private Sub frmMain_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Application.Exit()
        End If
    End Sub

    Private Sub frmMain_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = "[" Or e.KeyChar = "]" Or e.KeyChar = "'" Then
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub


    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
      
        Dim chk As New DataGridViewCheckBoxColumn()
        Grid.Columns.Add(chk)
        chk.HeaderText = "Tick"
        chk.Name = "chk"
        chk.Width = 50
        chk.FillWeight = 50
        chk.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        With Grid
            .ColumnCount = 8
            .Columns(1).HeaderText = "Date" : .Columns(1).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft : .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft : .Columns(1).Width = 100 : .Columns(1).ReadOnly = True
            .Columns(2).HeaderText = "Payee Name" : .Columns(2).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft : .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft : .Columns(2).Width = 250 : .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill : .Columns(2).ReadOnly = True
            .Columns(3).HeaderText = "Bank Name" : .Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft : .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft : .Columns(3).Width = 180 : .Columns(3).ReadOnly = True
            .Columns(4).HeaderText = "Amount" : .Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight : .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight : .Columns(4).Width = 120 : .Columns(4).ReadOnly = True
            .Columns(5).HeaderText = "Remarks" : .Columns(5).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft : .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft : .Columns(5).Width = 150 : .Columns(5).ReadOnly = True
            .Columns(6).HeaderText = "ID" : .Columns(6).Width = 0 : .Columns(6).Visible = False
            .Columns(7).HeaderText = "Status" : .Columns(7).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter : .Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter : .Columns(7).Width = 70 : .Columns(7).ReadOnly = True
        End With

        'Dim btn As New DataGridViewButtonColumn()
        'Grid.Columns.Add(btn) : btn.Width = 70 : btn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter : btn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        'btn.HeaderText = "Print"
        'btn.Name = "btn"
        'btn.Text = "Print"

        Dim btn1 As New DataGridViewButtonColumn()
        Grid.Columns.Add(btn1) : btn1.Width = 50 : btn1.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter : btn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        btn1.HeaderText = "Delete"
        btn1.Name = "btn"
        btn1.Text = "Delete"
    End Sub




   
End Class
