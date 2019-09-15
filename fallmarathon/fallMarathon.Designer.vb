<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fallMarathon
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fallMarathon))
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.picRunners = New System.Windows.Forms.PictureBox()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.btnViewDetails = New System.Windows.Forms.Button()
        Me.lblDetails = New System.Windows.Forms.Label()
        CType(Me.picRunners, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Tahoma", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.ForeColor = System.Drawing.Color.DarkOrange
        Me.lblHeading.Location = New System.Drawing.Point(289, 27)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(208, 34)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Fall Marathon"
        '
        'picRunners
        '
        Me.picRunners.Image = CType(resources.GetObject("picRunners.Image"), System.Drawing.Image)
        Me.picRunners.Location = New System.Drawing.Point(121, 74)
        Me.picRunners.Name = "picRunners"
        Me.picRunners.Size = New System.Drawing.Size(545, 356)
        Me.picRunners.TabIndex = 1
        Me.picRunners.TabStop = False
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.ForeColor = System.Drawing.Color.Chocolate
        Me.lblWelcome.Location = New System.Drawing.Point(169, 447)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(448, 23)
        Me.lblWelcome.TabIndex = 2
        Me.lblWelcome.Text = "Full- and half-marathon runners are welcome."
        '
        'btnViewDetails
        '
        Me.btnViewDetails.Location = New System.Drawing.Point(340, 491)
        Me.btnViewDetails.Name = "btnViewDetails"
        Me.btnViewDetails.Size = New System.Drawing.Size(106, 31)
        Me.btnViewDetails.TabIndex = 3
        Me.btnViewDetails.Text = "View Details"
        Me.btnViewDetails.UseVisualStyleBackColor = True
        '
        'lblDetails
        '
        Me.lblDetails.AutoSize = True
        Me.lblDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDetails.ForeColor = System.Drawing.Color.DarkOrange
        Me.lblDetails.Location = New System.Drawing.Point(163, 556)
        Me.lblDetails.Name = "lblDetails"
        Me.lblDetails.Size = New System.Drawing.Size(461, 80)
        Me.lblDetails.TabIndex = 4
        Me.lblDetails.Text = "May 30,2017" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ryan Park" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Start Time: 8:00 AM" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "For more information,view the Fall M" &
    "arathon Facebook Page." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblDetails.Visible = False
        '
        'fallMarathon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Moccasin
        Me.ClientSize = New System.Drawing.Size(787, 747)
        Me.Controls.Add(Me.lblDetails)
        Me.Controls.Add(Me.btnViewDetails)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.picRunners)
        Me.Controls.Add(Me.lblHeading)
        Me.Name = "fallMarathon"
        Me.Text = "Fall Marathon"
        CType(Me.picRunners, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents picRunners As PictureBox
    Friend WithEvents lblWelcome As Label
    Friend WithEvents btnViewDetails As Button
    Friend WithEvents lblDetails As Label
End Class
