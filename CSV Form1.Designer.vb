<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnImportCSV = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.ApplyEdit = New System.Windows.Forms.Button()
        Me.Create = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.dgvCSVread = New System.Windows.Forms.DataGridView()
        Me.dgvCSVwrite = New System.Windows.Forms.DataGridView()
        Me.cmbLogD = New System.Windows.Forms.ComboBox()
        Me.cmbLogD2 = New System.Windows.Forms.ComboBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        CType(Me.dgvCSVread, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCSVwrite, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnImportCSV
        '
        Me.btnImportCSV.Location = New System.Drawing.Point(678, 35)
        Me.btnImportCSV.Name = "btnImportCSV"
        Me.btnImportCSV.Size = New System.Drawing.Size(185, 23)
        Me.btnImportCSV.TabIndex = 0
        Me.btnImportCSV.Text = "Import CSV"
        Me.btnImportCSV.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(675, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Plot From:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(764, 73)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(675, 137)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Plot To:"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(764, 130)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 4
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(764, 187)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(675, 187)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Limit - Min:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(675, 238)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Limit - Max:"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(764, 235)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 8
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(764, 285)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 20)
        Me.TextBox5.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(673, 288)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Dev Factor - Min:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(673, 334)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Dev Factor - Max:"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(764, 331)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(100, 20)
        Me.TextBox6.TabIndex = 12
        '
        'ApplyEdit
        '
        Me.ApplyEdit.Location = New System.Drawing.Point(764, 370)
        Me.ApplyEdit.Name = "ApplyEdit"
        Me.ApplyEdit.Size = New System.Drawing.Size(100, 23)
        Me.ApplyEdit.TabIndex = 13
        Me.ApplyEdit.Text = "Apply Edit"
        Me.ApplyEdit.UseVisualStyleBackColor = True
        '
        'Create
        '
        Me.Create.Location = New System.Drawing.Point(679, 408)
        Me.Create.Name = "Create"
        Me.Create.Size = New System.Drawing.Size(185, 23)
        Me.Create.TabIndex = 14
        Me.Create.Text = "Create CSV"
        Me.Create.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(679, 448)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "File Name"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(679, 464)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(182, 20)
        Me.TextBox7.TabIndex = 16
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(678, 494)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(185, 23)
        Me.btnExport.TabIndex = 17
        Me.btnExport.Text = "Export to CSV"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'dgvCSVread
        '
        Me.dgvCSVread.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCSVread.Location = New System.Drawing.Point(13, 35)
        Me.dgvCSVread.Name = "dgvCSVread"
        Me.dgvCSVread.Size = New System.Drawing.Size(328, 482)
        Me.dgvCSVread.TabIndex = 18
        '
        'dgvCSVwrite
        '
        Me.dgvCSVwrite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCSVwrite.Location = New System.Drawing.Point(364, 35)
        Me.dgvCSVwrite.Name = "dgvCSVwrite"
        Me.dgvCSVwrite.Size = New System.Drawing.Size(294, 482)
        Me.dgvCSVwrite.TabIndex = 19
        '
        'cmbLogD
        '
        Me.cmbLogD.FormattingEnabled = True
        Me.cmbLogD.Location = New System.Drawing.Point(764, 99)
        Me.cmbLogD.Name = "cmbLogD"
        Me.cmbLogD.Size = New System.Drawing.Size(99, 21)
        Me.cmbLogD.TabIndex = 20
        '
        'cmbLogD2
        '
        Me.cmbLogD2.FormattingEnabled = True
        Me.cmbLogD2.Location = New System.Drawing.Point(764, 156)
        Me.cmbLogD2.Name = "cmbLogD2"
        Me.cmbLogD2.Size = New System.Drawing.Size(100, 21)
        Me.cmbLogD2.TabIndex = 21
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(509, 6)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 23
        Me.Button2.Text = "DEL"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(674, 99)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(84, 21)
        Me.Button3.TabIndex = 24
        Me.Button3.Text = "Load box 1"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(676, 153)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(82, 23)
        Me.Button4.TabIndex = 25
        Me.Button4.Text = "Load box 2"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(876, 557)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.cmbLogD2)
        Me.Controls.Add(Me.cmbLogD)
        Me.Controls.Add(Me.dgvCSVwrite)
        Me.Controls.Add(Me.dgvCSVread)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Create)
        Me.Controls.Add(Me.ApplyEdit)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnImportCSV)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "CSV-Filter - NW R&D - 190820 - HB"
        CType(Me.dgvCSVread, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCSVwrite, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnImportCSV As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents ApplyEdit As System.Windows.Forms.Button
    Friend WithEvents Create As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents btnExport As System.Windows.Forms.Button
    Friend WithEvents dgvCSVread As System.Windows.Forms.DataGridView
    Friend WithEvents dgvCSVwrite As System.Windows.Forms.DataGridView
    Friend WithEvents cmbLogD As System.Windows.Forms.ComboBox
    Friend WithEvents cmbLogD2 As System.Windows.Forms.ComboBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button

End Class
