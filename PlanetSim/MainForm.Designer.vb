<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim Planet8 As PlanetSim.Planet = New PlanetSim.Planet()
        Dim Planet9 As PlanetSim.Planet = New PlanetSim.Planet()
        Dim Planet10 As PlanetSim.Planet = New PlanetSim.Planet()
        Dim Planet11 As PlanetSim.Planet = New PlanetSim.Planet()
        Dim Planet12 As PlanetSim.Planet = New PlanetSim.Planet()
        Dim Planet13 As PlanetSim.Planet = New PlanetSim.Planet()
        Dim Planet14 As PlanetSim.Planet = New PlanetSim.Planet()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.bt_start = New System.Windows.Forms.Button()
        Me.SolarSystem = New PlanetSim.CCSystem()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.SolarSystem, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(987, 763)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.bt_start)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(4, 4)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(979, 54)
        Me.Panel1.TabIndex = 1
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(411, 11)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(100, 28)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Faster"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(519, 11)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(100, 28)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Slower"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(245, 11)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 28)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Zoom out"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(137, 11)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 28)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Zoom In"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'bt_start
        '
        Me.bt_start.Location = New System.Drawing.Point(12, 11)
        Me.bt_start.Margin = New System.Windows.Forms.Padding(4)
        Me.bt_start.Name = "bt_start"
        Me.bt_start.Size = New System.Drawing.Size(100, 28)
        Me.bt_start.TabIndex = 0
        Me.bt_start.Text = "Start"
        Me.bt_start.UseVisualStyleBackColor = True
        '
        'SolarSystem
        '
        Me.SolarSystem.BackColor = System.Drawing.Color.Black
        Me.SolarSystem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SolarSystem.Location = New System.Drawing.Point(4, 66)
        Me.SolarSystem.Margin = New System.Windows.Forms.Padding(4)
        Me.SolarSystem.Name = "SolarSystem"
        Planet8.Aphel = 0R
        Planet8.Color = System.Drawing.Color.Yellow
        Planet8.DisplayRadius = 20
        Planet8.Eccentricity = 0R
        Planet8.MajorAxis = 0R
        Planet8.Perihel = 0R
        Planet8.PlanetName = "Sun"
        Planet9.Aphel = 0R
        Planet9.Color = System.Drawing.Color.OldLace
        Planet9.DisplayRadius = 5
        Planet9.Eccentricity = 0.2056R
        Planet9.MajorAxis = 0.3871R
        Planet9.Perihel = 0.7R
        Planet9.PlanetName = "Mercury"
        Planet10.Aphel = 0R
        Planet10.Color = System.Drawing.Color.NavajoWhite
        Planet10.DisplayRadius = 7
        Planet10.Eccentricity = 0.0068R
        Planet10.MajorAxis = 0.723R
        Planet10.Perihel = 0R
        Planet10.PlanetName = "Venus"
        Planet11.Aphel = 0R
        Planet11.Color = System.Drawing.Color.DodgerBlue
        Planet11.DisplayRadius = 10
        Planet11.Eccentricity = 0.0167R
        Planet11.MajorAxis = 1.0R
        Planet11.Perihel = 0R
        Planet11.PlanetName = "Earth"
        Planet12.Aphel = 0R
        Planet12.Color = System.Drawing.Color.Brown
        Planet12.DisplayRadius = 10
        Planet12.Eccentricity = 0.0935R
        Planet12.MajorAxis = 1.524R
        Planet12.Perihel = 0R
        Planet12.PlanetName = "Mars"
        Planet13.Aphel = 0R
        Planet13.Color = System.Drawing.Color.Goldenrod
        Planet13.DisplayRadius = 20
        Planet13.Eccentricity = 0.0484R
        Planet13.MajorAxis = 5.203R
        Planet13.Perihel = 0R
        Planet13.PlanetName = "Jupiter"
        Planet14.Aphel = 0R
        Planet14.Color = System.Drawing.Color.LemonChiffon
        Planet14.DisplayRadius = 17
        Planet14.Eccentricity = 0.05648R
        Planet14.MajorAxis = 9.5826R
        Planet14.Perihel = 0R
        Planet14.PlanetName = "Saturn"
        Me.SolarSystem.Planets.Add(Planet8)
        Me.SolarSystem.Planets.Add(Planet9)
        Me.SolarSystem.Planets.Add(Planet10)
        Me.SolarSystem.Planets.Add(Planet11)
        Me.SolarSystem.Planets.Add(Planet12)
        Me.SolarSystem.Planets.Add(Planet13)
        Me.SolarSystem.Planets.Add(Planet14)
        Me.SolarSystem.Size = New System.Drawing.Size(979, 693)
        Me.SolarSystem.SolarSystem.Dimension = 0.000000001R
        Me.SolarSystem.SolarSystem.TimeFactor = 60000.0R
        Me.SolarSystem.TabIndex = 2
        Me.SolarSystem.Text = "CcSystem1"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(987, 763)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MainForm"
        Me.Text = "Solar System"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents bt_start As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents SolarSystem As PlanetSim.CCSystem
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
