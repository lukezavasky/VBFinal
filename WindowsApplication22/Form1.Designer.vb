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
        Me.txtHours = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.CboLevel = New System.Windows.Forms.ComboBox()
        Me.lblHours = New System.Windows.Forms.Label()
        Me.lblLevel = New System.Windows.Forms.Label()
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.lblPrint = New System.Windows.Forms.Label()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtHours
        '
        Me.txtHours.Location = New System.Drawing.Point(265, 129)
        Me.txtHours.Name = "txtHours"
        Me.txtHours.Size = New System.Drawing.Size(121, 20)
        Me.txtHours.TabIndex = 0
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(237, 290)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 2
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'CboLevel
        '
        Me.CboLevel.FormattingEnabled = True
        Me.CboLevel.Items.AddRange(New Object() {"Skill Level One", "Skill Level Two", "Skill Level Three"})
        Me.CboLevel.Location = New System.Drawing.Point(265, 218)
        Me.CboLevel.Name = "CboLevel"
        Me.CboLevel.Size = New System.Drawing.Size(121, 21)
        Me.CboLevel.TabIndex = 3
        '
        'lblHours
        '
        Me.lblHours.AutoSize = True
        Me.lblHours.Location = New System.Drawing.Point(27, 132)
        Me.lblHours.Name = "lblHours"
        Me.lblHours.Size = New System.Drawing.Size(221, 13)
        Me.lblHours.TabIndex = 4
        Me.lblHours.Text = "Enter the Number of Hours worked per week:"
        '
        'lblLevel
        '
        Me.lblLevel.AutoSize = True
        Me.lblLevel.Location = New System.Drawing.Point(112, 221)
        Me.lblLevel.Name = "lblLevel"
        Me.lblLevel.Size = New System.Drawing.Size(86, 13)
        Me.lblLevel.TabIndex = 5
        Me.lblLevel.Text = "Enter Skill Level:"
        '
        'lblDisplay
        '
        Me.lblDisplay.AutoSize = True
        Me.lblDisplay.Location = New System.Drawing.Point(157, 376)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(41, 13)
        Me.lblDisplay.TabIndex = 6
        Me.lblDisplay.Text = "Display"
        Me.lblDisplay.Visible = False
        '
        'lblPrint
        '
        Me.lblPrint.AutoSize = True
        Me.lblPrint.Location = New System.Drawing.Point(157, 414)
        Me.lblPrint.Name = "lblPrint"
        Me.lblPrint.Size = New System.Drawing.Size(28, 13)
        Me.lblPrint.TabIndex = 7
        Me.lblPrint.Text = "Print"
        Me.lblPrint.Visible = False
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(199, 47)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(166, 24)
        Me.lblHeader.TabIndex = 8
        Me.lblHeader.Text = "Salary Calculator"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 462)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.lblPrint)
        Me.Controls.Add(Me.lblDisplay)
        Me.Controls.Add(Me.lblLevel)
        Me.Controls.Add(Me.lblHours)
        Me.Controls.Add(Me.CboLevel)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtHours)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtHours As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents CboLevel As ComboBox
    Friend WithEvents lblHours As Label
    Friend WithEvents lblLevel As Label
    Friend WithEvents lblDisplay As Label
    Friend WithEvents lblPrint As Label
    Friend WithEvents lblHeader As Label
End Class
