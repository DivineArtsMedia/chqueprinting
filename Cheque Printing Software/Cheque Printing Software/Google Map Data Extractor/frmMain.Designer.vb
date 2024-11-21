<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.fraMainPannel = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmdDelete1 = New System.Windows.Forms.Button()
        Me.cmdExport = New System.Windows.Forms.Button()
        Me.cmdPrintSelected = New System.Windows.Forms.Button()
        Me.cmdImport = New System.Windows.Forms.Button()
        Me.chkSelectAll = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.txtBankName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpChequeDt = New System.Windows.Forms.DateTimePicker()
        Me.lblServiceUpto = New System.Windows.Forms.Label()
        Me.txtAccountName = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtEncryptDate = New System.Windows.Forms.TextBox()
        Me.dtpServerDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpAMCDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpTodayDate = New System.Windows.Forms.DateTimePicker()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Grid = New System.Windows.Forms.DataGridView()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.fraMainPannel.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fraMainPannel
        '
        Me.fraMainPannel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fraMainPannel.BackColor = System.Drawing.Color.Honeydew
        Me.fraMainPannel.Controls.Add(Me.Button1)
        Me.fraMainPannel.Controls.Add(Me.cmdDelete1)
        Me.fraMainPannel.Controls.Add(Me.cmdExport)
        Me.fraMainPannel.Controls.Add(Me.cmdPrintSelected)
        Me.fraMainPannel.Controls.Add(Me.cmdImport)
        Me.fraMainPannel.Controls.Add(Me.chkSelectAll)
        Me.fraMainPannel.Controls.Add(Me.Label5)
        Me.fraMainPannel.Controls.Add(Me.Label4)
        Me.fraMainPannel.Controls.Add(Me.Label3)
        Me.fraMainPannel.Controls.Add(Me.txtRemarks)
        Me.fraMainPannel.Controls.Add(Me.txtAmount)
        Me.fraMainPannel.Controls.Add(Me.txtBankName)
        Me.fraMainPannel.Controls.Add(Me.Label2)
        Me.fraMainPannel.Controls.Add(Me.Label1)
        Me.fraMainPannel.Controls.Add(Me.dtpChequeDt)
        Me.fraMainPannel.Controls.Add(Me.lblServiceUpto)
        Me.fraMainPannel.Controls.Add(Me.txtAccountName)
        Me.fraMainPannel.Controls.Add(Me.GroupBox1)
        Me.fraMainPannel.Controls.Add(Me.lblTotal)
        Me.fraMainPannel.Controls.Add(Me.Grid)
        Me.fraMainPannel.Controls.Add(Me.cmdAdd)
        Me.fraMainPannel.Location = New System.Drawing.Point(0, 0)
        Me.fraMainPannel.Name = "fraMainPannel"
        Me.fraMainPannel.Size = New System.Drawing.Size(1066, 492)
        Me.fraMainPannel.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.Crimson
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.Color.Transparent
        Me.Button1.Location = New System.Drawing.Point(905, 457)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 23)
        Me.Button1.TabIndex = 199
        Me.Button1.Text = "(F6 - Search)"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'cmdDelete1
        '
        Me.cmdDelete1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdDelete1.BackColor = System.Drawing.Color.Indigo
        Me.cmdDelete1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdDelete1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmdDelete1.ForeColor = System.Drawing.Color.Transparent
        Me.cmdDelete1.Location = New System.Drawing.Point(747, 457)
        Me.cmdDelete1.Name = "cmdDelete1"
        Me.cmdDelete1.Size = New System.Drawing.Size(150, 23)
        Me.cmdDelete1.TabIndex = 181
        Me.cmdDelete1.Text = "(F5 - Delete Entries)"
        Me.cmdDelete1.UseVisualStyleBackColor = False
        '
        'cmdExport
        '
        Me.cmdExport.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExport.BackColor = System.Drawing.Color.Maroon
        Me.cmdExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdExport.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmdExport.ForeColor = System.Drawing.Color.Transparent
        Me.cmdExport.Location = New System.Drawing.Point(589, 457)
        Me.cmdExport.Name = "cmdExport"
        Me.cmdExport.Size = New System.Drawing.Size(150, 23)
        Me.cmdExport.TabIndex = 180
        Me.cmdExport.Text = "(F4 - Export to Excel)"
        Me.cmdExport.UseVisualStyleBackColor = False
        '
        'cmdPrintSelected
        '
        Me.cmdPrintSelected.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdPrintSelected.BackColor = System.Drawing.Color.DarkSlateGray
        Me.cmdPrintSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdPrintSelected.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmdPrintSelected.ForeColor = System.Drawing.Color.Transparent
        Me.cmdPrintSelected.Location = New System.Drawing.Point(401, 457)
        Me.cmdPrintSelected.Name = "cmdPrintSelected"
        Me.cmdPrintSelected.Size = New System.Drawing.Size(180, 23)
        Me.cmdPrintSelected.TabIndex = 142
        Me.cmdPrintSelected.Text = "(F3 - Print Selected Cheque)"
        Me.cmdPrintSelected.UseVisualStyleBackColor = False
        '
        'cmdImport
        '
        Me.cmdImport.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdImport.BackColor = System.Drawing.Color.SeaGreen
        Me.cmdImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdImport.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.cmdImport.ForeColor = System.Drawing.Color.Transparent
        Me.cmdImport.Location = New System.Drawing.Point(228, 457)
        Me.cmdImport.Name = "cmdImport"
        Me.cmdImport.Size = New System.Drawing.Size(165, 23)
        Me.cmdImport.TabIndex = 141
        Me.cmdImport.Text = "(F2 - Import From Excel)"
        Me.cmdImport.UseVisualStyleBackColor = False
        '
        'chkSelectAll
        '
        Me.chkSelectAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkSelectAll.AutoSize = True
        Me.chkSelectAll.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.chkSelectAll.ForeColor = System.Drawing.Color.Black
        Me.chkSelectAll.Location = New System.Drawing.Point(12, 458)
        Me.chkSelectAll.Name = "chkSelectAll"
        Me.chkSelectAll.Size = New System.Drawing.Size(78, 17)
        Me.chkSelectAll.TabIndex = 140
        Me.chkSelectAll.Text = "Select &All"
        Me.chkSelectAll.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(877, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 139
        Me.Label5.Text = "Remarks"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(732, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 138
        Me.Label4.Text = "Amount"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(544, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 137
        Me.Label3.Text = "Bank Name"
        '
        'txtRemarks
        '
        Me.txtRemarks.BackColor = System.Drawing.Color.White
        Me.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRemarks.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold)
        Me.txtRemarks.Location = New System.Drawing.Point(824, 26)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(165, 26)
        Me.txtRemarks.TabIndex = 4
        '
        'txtAmount
        '
        Me.txtAmount.BackColor = System.Drawing.Color.White
        Me.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAmount.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold)
        Me.txtAmount.Location = New System.Drawing.Point(692, 26)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(132, 26)
        Me.txtAmount.TabIndex = 3
        Me.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBankName
        '
        Me.txtBankName.BackColor = System.Drawing.Color.White
        Me.txtBankName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBankName.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold)
        Me.txtBankName.Location = New System.Drawing.Point(467, 26)
        Me.txtBankName.Name = "txtBankName"
        Me.txtBankName.Size = New System.Drawing.Size(225, 26)
        Me.txtBankName.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(219, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(170, 13)
        Me.Label2.TabIndex = 133
        Me.Label2.Text = "Payee Name / Account Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(29, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 132
        Me.Label1.Text = "Cheque Date"
        '
        'dtpChequeDt
        '
        Me.dtpChequeDt.CalendarFont = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.dtpChequeDt.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.dtpChequeDt.CustomFormat = "dd-MM-yyyy"
        Me.dtpChequeDt.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold)
        Me.dtpChequeDt.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpChequeDt.Location = New System.Drawing.Point(12, 26)
        Me.dtpChequeDt.Name = "dtpChequeDt"
        Me.dtpChequeDt.Size = New System.Drawing.Size(123, 26)
        Me.dtpChequeDt.TabIndex = 0
        '
        'lblServiceUpto
        '
        Me.lblServiceUpto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblServiceUpto.AutoSize = True
        Me.lblServiceUpto.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.lblServiceUpto.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Underline)
        Me.lblServiceUpto.ForeColor = System.Drawing.Color.White
        Me.lblServiceUpto.Location = New System.Drawing.Point(681, 433)
        Me.lblServiceUpto.Name = "lblServiceUpto"
        Me.lblServiceUpto.Size = New System.Drawing.Size(0, 18)
        Me.lblServiceUpto.TabIndex = 129
        '
        'txtAccountName
        '
        Me.txtAccountName.BackColor = System.Drawing.Color.White
        Me.txtAccountName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAccountName.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold)
        Me.txtAccountName.Location = New System.Drawing.Point(141, 26)
        Me.txtAccountName.Name = "txtAccountName"
        Me.txtAccountName.Size = New System.Drawing.Size(326, 26)
        Me.txtAccountName.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtEncryptDate)
        Me.GroupBox1.Controls.Add(Me.dtpServerDate)
        Me.GroupBox1.Controls.Add(Me.dtpAMCDate)
        Me.GroupBox1.Controls.Add(Me.dtpTodayDate)
        Me.GroupBox1.Location = New System.Drawing.Point(1026, 348)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(18, 23)
        Me.GroupBox1.TabIndex = 48
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        Me.GroupBox1.Visible = False
        '
        'txtEncryptDate
        '
        Me.txtEncryptDate.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEncryptDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txtEncryptDate.Location = New System.Drawing.Point(357, 19)
        Me.txtEncryptDate.Name = "txtEncryptDate"
        Me.txtEncryptDate.Size = New System.Drawing.Size(34, 22)
        Me.txtEncryptDate.TabIndex = 26
        '
        'dtpServerDate
        '
        Me.dtpServerDate.CustomFormat = "dd-MM-yyyy"
        Me.dtpServerDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpServerDate.Location = New System.Drawing.Point(123, 55)
        Me.dtpServerDate.Name = "dtpServerDate"
        Me.dtpServerDate.Size = New System.Drawing.Size(61, 20)
        Me.dtpServerDate.TabIndex = 25
        '
        'dtpAMCDate
        '
        Me.dtpAMCDate.CustomFormat = "dd-MM-yyyy"
        Me.dtpAMCDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpAMCDate.Location = New System.Drawing.Point(6, 73)
        Me.dtpAMCDate.Name = "dtpAMCDate"
        Me.dtpAMCDate.Size = New System.Drawing.Size(61, 20)
        Me.dtpAMCDate.TabIndex = 24
        '
        'dtpTodayDate
        '
        Me.dtpTodayDate.CustomFormat = "dd-MM-yyyy"
        Me.dtpTodayDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTodayDate.Location = New System.Drawing.Point(133, 7)
        Me.dtpTodayDate.Name = "dtpTodayDate"
        Me.dtpTodayDate.Size = New System.Drawing.Size(61, 20)
        Me.dtpTodayDate.TabIndex = 23
        '
        'lblTotal
        '
        Me.lblTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotal.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold)
        Me.lblTotal.ForeColor = System.Drawing.Color.Brown
        Me.lblTotal.Location = New System.Drawing.Point(96, 461)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(92, 18)
        Me.lblTotal.TabIndex = 46
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Grid
        '
        Me.Grid.AllowUserToAddRows = False
        Me.Grid.AllowUserToDeleteRows = False
        Me.Grid.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        Me.Grid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Grid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grid.BackgroundColor = System.Drawing.Color.White
        Me.Grid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Grid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Grid.DefaultCellStyle = DataGridViewCellStyle3
        Me.Grid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.Grid.EnableHeadersVisualStyles = False
        Me.Grid.Location = New System.Drawing.Point(12, 58)
        Me.Grid.MultiSelect = False
        Me.Grid.Name = "Grid"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Grid.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.Grid.RowHeadersWidth = 45
        Me.Grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.Grid.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Grid.Size = New System.Drawing.Size(1042, 395)
        Me.Grid.TabIndex = 45
        '
        'cmdAdd
        '
        Me.cmdAdd.BackColor = System.Drawing.Color.SeaGreen
        Me.cmdAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAdd.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold)
        Me.cmdAdd.ForeColor = System.Drawing.Color.White
        Me.cmdAdd.Location = New System.Drawing.Point(995, 23)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(59, 29)
        Me.cmdAdd.TabIndex = 5
        Me.cmdAdd.Text = "Add"
        Me.cmdAdd.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1066, 492)
        Me.Controls.Add(Me.fraMainPannel)
        Me.KeyPreview = True
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cheque Printing Software (#151024)"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.fraMainPannel.ResumeLayout(False)
        Me.fraMainPannel.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents fraMainPannel As System.Windows.Forms.Panel
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents Grid As System.Windows.Forms.DataGridView
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtAccountName As System.Windows.Forms.TextBox
    Friend WithEvents dtpServerDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpAMCDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpTodayDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtEncryptDate As System.Windows.Forms.TextBox
    Friend WithEvents lblServiceUpto As System.Windows.Forms.Label
    Friend WithEvents dtpChequeDt As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents txtBankName As System.Windows.Forms.TextBox
    Friend WithEvents txtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents chkSelectAll As System.Windows.Forms.CheckBox
    Friend WithEvents cmdImport As System.Windows.Forms.Button
    Friend WithEvents cmdPrintSelected As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents cmdExport As System.Windows.Forms.Button
    Friend WithEvents cmdDelete1 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
