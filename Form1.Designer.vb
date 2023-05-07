<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMeterCalculator
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
        Me.lblMeterConversion = New System.Windows.Forms.Label()
        Me.btnMeters = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lstMeters = New System.Windows.Forms.ListBox()
        Me.lblSurvey = New System.Windows.Forms.Label()
        Me.picCalculator = New System.Windows.Forms.PictureBox()
        Me.grpConversions = New System.Windows.Forms.GroupBox()
        Me.radCentimeterKilometer = New System.Windows.Forms.RadioButton()
        Me.radCentimeterMeter = New System.Windows.Forms.RadioButton()
        Me.radKilometerCentimeter = New System.Windows.Forms.RadioButton()
        Me.radKilometerMeter = New System.Windows.Forms.RadioButton()
        Me.radMeterCentimeter = New System.Windows.Forms.RadioButton()
        Me.radMeterKilometer = New System.Windows.Forms.RadioButton()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.picCalculator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpConversions.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblMeterConversion
        '
        Me.lblMeterConversion.AutoSize = True
        Me.lblMeterConversion.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblMeterConversion.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMeterConversion.Location = New System.Drawing.Point(393, 543)
        Me.lblMeterConversion.Name = "lblMeterConversion"
        Me.lblMeterConversion.Size = New System.Drawing.Size(282, 32)
        Me.lblMeterConversion.TabIndex = 10
        Me.lblMeterConversion.Text = "XXXXXXXXXXXX 0000"
        Me.lblMeterConversion.Visible = False
        '
        'btnMeters
        '
        Me.btnMeters.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnMeters.Font = New System.Drawing.Font("Segoe UI Black", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMeters.Location = New System.Drawing.Point(537, 93)
        Me.btnMeters.Name = "btnMeters"
        Me.btnMeters.Size = New System.Drawing.Size(291, 51)
        Me.btnMeters.TabIndex = 9
        Me.btnMeters.Text = "Enter Meters"
        Me.btnMeters.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(821, 400)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(156, 48)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'lstMeters
        '
        Me.lstMeters.Font = New System.Drawing.Font("Segoe UI Black", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstMeters.FormattingEnabled = True
        Me.lstMeters.ItemHeight = 38
        Me.lstMeters.Location = New System.Drawing.Point(845, 93)
        Me.lstMeters.Name = "lstMeters"
        Me.lstMeters.Size = New System.Drawing.Size(158, 232)
        Me.lstMeters.TabIndex = 7
        '
        'lblSurvey
        '
        Me.lblSurvey.AutoSize = True
        Me.lblSurvey.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblSurvey.Font = New System.Drawing.Font("Segoe UI Black", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSurvey.Location = New System.Drawing.Point(509, 21)
        Me.lblSurvey.Name = "lblSurvey"
        Me.lblSurvey.Size = New System.Drawing.Size(468, 45)
        Me.lblSurvey.TabIndex = 6
        Me.lblSurvey.Text = "Meter Conversion Caluclator"
        '
        'picCalculator
        '
        Me.picCalculator.BackgroundImage = Global.GUI_Final_Project.My.Resources.Resources.calc
        Me.picCalculator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picCalculator.Location = New System.Drawing.Point(12, 21)
        Me.picCalculator.Name = "picCalculator"
        Me.picCalculator.Size = New System.Drawing.Size(488, 427)
        Me.picCalculator.TabIndex = 11
        Me.picCalculator.TabStop = False
        '
        'grpConversions
        '
        Me.grpConversions.Controls.Add(Me.radCentimeterKilometer)
        Me.grpConversions.Controls.Add(Me.radCentimeterMeter)
        Me.grpConversions.Controls.Add(Me.radKilometerCentimeter)
        Me.grpConversions.Controls.Add(Me.radKilometerMeter)
        Me.grpConversions.Controls.Add(Me.radMeterCentimeter)
        Me.grpConversions.Controls.Add(Me.radMeterKilometer)
        Me.grpConversions.Location = New System.Drawing.Point(590, 168)
        Me.grpConversions.Name = "grpConversions"
        Me.grpConversions.Size = New System.Drawing.Size(238, 220)
        Me.grpConversions.TabIndex = 12
        Me.grpConversions.TabStop = False
        Me.grpConversions.Text = "Choose Conversion"
        '
        'radCentimeterKilometer
        '
        Me.radCentimeterKilometer.AutoSize = True
        Me.radCentimeterKilometer.Location = New System.Drawing.Point(7, 176)
        Me.radCentimeterKilometer.Name = "radCentimeterKilometer"
        Me.radCentimeterKilometer.Size = New System.Drawing.Size(216, 24)
        Me.radCentimeterKilometer.TabIndex = 5
        Me.radCentimeterKilometer.TabStop = True
        Me.radCentimeterKilometer.Text = "Centimeters to Kilometers"
        Me.radCentimeterKilometer.UseVisualStyleBackColor = True
        '
        'radCentimeterMeter
        '
        Me.radCentimeterMeter.AutoSize = True
        Me.radCentimeterMeter.Location = New System.Drawing.Point(7, 146)
        Me.radCentimeterMeter.Name = "radCentimeterMeter"
        Me.radCentimeterMeter.Size = New System.Drawing.Size(191, 24)
        Me.radCentimeterMeter.TabIndex = 4
        Me.radCentimeterMeter.TabStop = True
        Me.radCentimeterMeter.Text = "Centimeters to Meters"
        Me.radCentimeterMeter.UseVisualStyleBackColor = True
        '
        'radKilometerCentimeter
        '
        Me.radKilometerCentimeter.AutoSize = True
        Me.radKilometerCentimeter.Location = New System.Drawing.Point(7, 116)
        Me.radKilometerCentimeter.Name = "radKilometerCentimeter"
        Me.radKilometerCentimeter.Size = New System.Drawing.Size(216, 24)
        Me.radKilometerCentimeter.TabIndex = 3
        Me.radKilometerCentimeter.TabStop = True
        Me.radKilometerCentimeter.Text = "Kilometers to Centimeters"
        Me.radKilometerCentimeter.UseVisualStyleBackColor = True
        '
        'radKilometerMeter
        '
        Me.radKilometerMeter.AutoSize = True
        Me.radKilometerMeter.Location = New System.Drawing.Point(7, 86)
        Me.radKilometerMeter.Name = "radKilometerMeter"
        Me.radKilometerMeter.Size = New System.Drawing.Size(179, 24)
        Me.radKilometerMeter.TabIndex = 2
        Me.radKilometerMeter.TabStop = True
        Me.radKilometerMeter.Text = "Kilometers to Meters"
        Me.radKilometerMeter.UseVisualStyleBackColor = True
        '
        'radMeterCentimeter
        '
        Me.radMeterCentimeter.AutoSize = True
        Me.radMeterCentimeter.Location = New System.Drawing.Point(7, 56)
        Me.radMeterCentimeter.Name = "radMeterCentimeter"
        Me.radMeterCentimeter.Size = New System.Drawing.Size(191, 24)
        Me.radMeterCentimeter.TabIndex = 1
        Me.radMeterCentimeter.TabStop = True
        Me.radMeterCentimeter.Text = "Meters to Centimeters"
        Me.radMeterCentimeter.UseVisualStyleBackColor = True
        '
        'radMeterKilometer
        '
        Me.radMeterKilometer.AutoSize = True
        Me.radMeterKilometer.Location = New System.Drawing.Point(7, 26)
        Me.radMeterKilometer.Name = "radMeterKilometer"
        Me.radMeterKilometer.Size = New System.Drawing.Size(179, 24)
        Me.radMeterKilometer.TabIndex = 0
        Me.radMeterKilometer.TabStop = True
        Me.radMeterKilometer.Text = "Meters to Kilometers"
        Me.radMeterKilometer.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(860, 544)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(117, 35)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'frmMeterCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1015, 627)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.grpConversions)
        Me.Controls.Add(Me.picCalculator)
        Me.Controls.Add(Me.lblMeterConversion)
        Me.Controls.Add(Me.btnMeters)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lstMeters)
        Me.Controls.Add(Me.lblSurvey)
        Me.Name = "frmMeterCalculator"
        Me.Text = "Meter Calculator"
        CType(Me.picCalculator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpConversions.ResumeLayout(False)
        Me.grpConversions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMeterConversion As Label
    Friend WithEvents btnMeters As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lstMeters As ListBox
    Friend WithEvents lblSurvey As Label
    Friend WithEvents picCalculator As PictureBox
    Friend WithEvents grpConversions As GroupBox
    Friend WithEvents radCentimeterKilometer As RadioButton
    Friend WithEvents radCentimeterMeter As RadioButton
    Friend WithEvents radKilometerCentimeter As RadioButton
    Friend WithEvents radKilometerMeter As RadioButton
    Friend WithEvents radMeterCentimeter As RadioButton
    Friend WithEvents radMeterKilometer As RadioButton
    Friend WithEvents btnExit As Button
End Class
