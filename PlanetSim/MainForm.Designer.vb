<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim Planet1 As PlanetSim.Planet = New PlanetSim.Planet()
        Dim Planet2 As PlanetSim.Planet = New PlanetSim.Planet()
        Dim Planet3 As PlanetSim.Planet = New PlanetSim.Planet()
        Dim Planet4 As PlanetSim.Planet = New PlanetSim.Planet()
        Dim Planet5 As PlanetSim.Planet = New PlanetSim.Planet()
        Dim Planet6 As PlanetSim.Planet = New PlanetSim.Planet()
        Dim Planet7 As PlanetSim.Planet = New PlanetSim.Planet()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.bt_start = New System.Windows.Forms.Button()
        Me.SolarSystem = New PlanetSim.CCSystem()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.SolarSystem, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(740, 620)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.bt_start)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(734, 44)
        Me.Panel1.TabIndex = 1
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(308, 9)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Faster"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(389, 9)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Slower"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(686, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Label1"
        Me.Label1.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(184, 9)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Zoom out"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(103, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Zoom In"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'bt_start
        '
        Me.bt_start.Location = New System.Drawing.Point(9, 9)
        Me.bt_start.Name = "bt_start"
        Me.bt_start.Size = New System.Drawing.Size(75, 23)
        Me.bt_start.TabIndex = 0
        Me.bt_start.Text = "Start"
        Me.bt_start.UseVisualStyleBackColor = True
        '
        'SolarSystem
        '
        Me.SolarSystem.BackColor = System.Drawing.Color.Black
        Me.SolarSystem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SolarSystem.Location = New System.Drawing.Point(3, 53)
        Me.SolarSystem.Name = "SolarSystem"
        Planet1.Aphel = 0R
        Planet1.Color = System.Drawing.Color.Yellow
        Planet1.DisplayRadius = 20
        Planet1.Eccentricity = 0R
        Planet1.MajorAxis = 0R
        Planet1.Perihel = 0R
        Planet1.PlanetName = "Sun"
        Planet2.Aphel = 0R
        Planet2.Color = System.Drawing.Color.OldLace
        Planet2.DisplayRadius = 5
        Planet2.Eccentricity = 0.2056R
        Planet2.MajorAxis = 0.3871R
        Planet2.Perihel = 0.7R
        Planet2.PlanetName = "Mercury"
        Planet3.Aphel = 0R
        Planet3.Color = System.Drawing.Color.NavajoWhite
        Planet3.DisplayRadius = 7
        Planet3.Eccentricity = 0.0068R
        Planet3.MajorAxis = 0.723R
        Planet3.Perihel = 0R
        Planet3.PlanetName = "Venus"
        Planet4.Aphel = 0R
        Planet4.Color = System.Drawing.Color.DodgerBlue
        Planet4.DisplayRadius = 10
        Planet4.Eccentricity = 0.0167R
        Planet4.MajorAxis = 1.0R
        Planet4.Perihel = 0R
        Planet4.PlanetName = "Earth"
        Planet5.Aphel = 0R
        Planet5.Color = System.Drawing.Color.Brown
        Planet5.DisplayRadius = 10
        Planet5.Eccentricity = 0.0935R
        Planet5.MajorAxis = 1.524R
        Planet5.Perihel = 0R
        Planet5.PlanetName = "Mars"
        Planet6.Aphel = 0R
        Planet6.Color = System.Drawing.Color.Goldenrod
        Planet6.DisplayRadius = 20
        Planet6.Eccentricity = 0.0484R
        Planet6.MajorAxis = 5.203R
        Planet6.Perihel = 0R
        Planet6.PlanetName = "Jupiter"
        Planet7.Aphel = 0R
        Planet7.Color = System.Drawing.Color.LemonChiffon
        Planet7.DisplayRadius = 17
        Planet7.Eccentricity = 0.05648R
        Planet7.MajorAxis = 9.5826R
        Planet7.Perihel = 0R
        Planet7.PlanetName = "Saturn"
        Me.SolarSystem.Planets.Add(Planet1)
        Me.SolarSystem.Planets.Add(Planet2)
        Me.SolarSystem.Planets.Add(Planet3)
        Me.SolarSystem.Planets.Add(Planet4)
        Me.SolarSystem.Planets.Add(Planet5)
        Me.SolarSystem.Planets.Add(Planet6)
        Me.SolarSystem.Planets.Add(Planet7)
        Me.SolarSystem.Size = New System.Drawing.Size(734, 564)
        Me.SolarSystem.SolarSystem.Dimension = 0.000000001R
        Me.SolarSystem.SolarSystem.TimeFactor = 60000.0R
        Me.SolarSystem.TabIndex = 2
        Me.SolarSystem.Text = "CcSystem1"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(510, 9)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "Button5"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(740, 620)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.DoubleBuffered = True
        Me.Name = "MainForm"
        Me.Text = "Solar System"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents bt_start As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents SolarSystem As PlanetSim.CCSystem
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button5 As Button
End Class
