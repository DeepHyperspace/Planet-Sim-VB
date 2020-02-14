Imports System.Drawing.Drawing2D
Imports System.ComponentModel


'Cartesian coordinate system 
Public Class CCSystem
    Inherits System.Windows.Forms.Control

    Public Sub New()
        MyBase.New()
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        Me.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        Me.SetStyle(ControlStyles.UserPaint, True)
        Me.SetStyle(ControlStyles.SupportsTransparentBackColor, True)
    End Sub

    <Browsable(False)>
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
    Public ReadOnly Property Center As Point
        Get
            Dim p As New Point
            p.X = Me.Size.Width / 2
            p.Y = Me.Size.Height / 2
            Return p
        End Get
    End Property

    Private m_Planets As New List(Of Planet)
    <Editor(GetType(PlanetCollectionEditor), GetType(System.Drawing.Design.UITypeEditor))> _
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Content)>
    <RefreshProperties(RefreshProperties.Repaint)>
    <Category("1Solar-System")>
    Public ReadOnly Property Planets As List(Of Planet)
        Get
            Return m_Planets
        End Get
    End Property

    Private m_SS As New PlanetSystem
    <TypeConverter(GetType(PlanetSystemConverter)), Category("1Solar-System")> _
    <DesignerSerializationVisibility(DesignerSerializationVisibility.Content), NotifyParentProperty(True), RefreshProperties(RefreshProperties.Repaint)>
    Public ReadOnly Property SolarSystem As PlanetSystem
        Get
            Return m_SS
        End Get
    End Property

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Try
            MyBase.OnPaint(e)
            Dim g As Graphics = e.Graphics
            g.CompositingQuality = CompositingQuality.HighSpeed
            g.SmoothingMode = SmoothingMode.AntiAlias
            Dim bahn As New Pen(Brushes.Gray, 1)

            For Each Planet In Planets
                Planet.Dimension = SolarSystem.Dimension
                Planet.TimeFactor = SolarSystem.TimeFactor
                Dim p_brush As New SolidBrush(Planet.Color)
                g.DrawEllipse(bahn, Center.X - CInt(Planet.Orbit.Width / 2) + Planet.DeltaXDim, Center.Y - CInt(Planet.Orbit.Height / 2) + Planet.DeltaYDim, Planet.Orbit.Width, Planet.Orbit.Height)
                Dim p_Planet As New Point(Center.X + Planet.Position.X - Planet.DisplayRadius, Center.Y + Planet.Position.Y - Planet.DisplayRadius)
                g.FillEllipse(p_brush, p_Planet.X, p_Planet.Y, Planet.DisplayRadius * 2, Planet.DisplayRadius * 2)
                Dim p_Text As Point = p_Planet
                p_Text.Offset(Planet.DisplayRadius * 2, Planet.DisplayRadius * 2)
                g.DrawString(Planet.PlanetName, Me.Font, Brushes.White, p_Text)
            Next

            If Planets.Count >= 3 Then
                Dim earth As Planet = Planets(3)
                g.DrawString(earth.MetaInfo, Me.Font, Brushes.White, New Point(10, 10))
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class



Public Class PlanetCollectionEditor
    Inherits System.ComponentModel.Design.CollectionEditor

    Public Sub New(type As Type)
        MyBase.New(type)
    End Sub

    Protected Overrides Function GetDisplayText(value As Object) As String
        Return CType(value, Planet).PlanetName
    End Function
End Class


Public Class PlanetSystem
    Private m_Dim As Double = 1 / 10 ^ 9
    Public Property Dimension As Double
        Get
            Return m_Dim
        End Get
        Set(value As Double)
            m_Dim = value
        End Set
    End Property
    Private m_Time As Double = 60000
    Public Property TimeFactor As Double
        Get
            Return m_Time
        End Get
        Set(value As Double)
            m_Time = value
        End Set
    End Property
End Class

Public Class PlanetSystemConverter
    Inherits ExpandableObjectConverter

    Public Overrides Function ConvertTo(ByVal context As ITypeDescriptorContext, ByVal culture As Globalization.CultureInfo, ByVal value As Object, ByVal destinationType As Type) As Object
        If destinationType Is GetType(String) Then
            Return ""
        End If
        Return MyBase.ConvertTo(context, culture, value, destinationType)
    End Function
End Class


Public Class Planet

    Private Const G As Double = 6.67384 * (10 ^ -11)
    Private Const SunMass As Double = 1.989E+30
    Private Const AE As Double = 149597870700

    Public Dimension As Double = 1
    Public TimeFactor As Double = 1

    'Design:
    Public Property PlanetName As String = ""

    <NotifyParentProperty(True)>
    <RefreshProperties(RefreshProperties.All)>
    Public Property DisplayRadius As Integer = 5

    <RefreshProperties(RefreshProperties.All)>
    Public Property Color As Color = Drawing.Color.White


    Private _mAx As Double = 0
    <NotifyParentProperty(True)>
    <RefreshProperties(RefreshProperties.All)>
    Public Property MajorAxis As Double
        Get
            Return _mAx
        End Get
        Set(value As Double)
            _mAx = value
            CalcPosition()
        End Set
    End Property

    Private _mEcc As Double = 0
    <RefreshProperties(RefreshProperties.All)>
    Public Property Eccentricity As Double
        Get
            Return _mEcc
        End Get
        Set(value As Double)
            _mEcc = value
            CalcPosition()
        End Set
    End Property

    Private ReadOnly Property SemiMajorAxis As Double
        Get
            Return MajorAxis * AE
        End Get
    End Property


    Private ReadOnly Property SemiMinorAxis As Double
        Get
            Return Math.Sqrt(SemiMajorAxis ^ 2 - (Eccentricity * SemiMajorAxis) ^ 2)
        End Get
    End Property


    Dim m_Orbit As New Size
    <Browsable(False)>
    Public ReadOnly Property Orbit As Size
        Get
            m_Orbit.Width = CInt((SemiMajorAxis * 2) * Dimension)
            m_Orbit.Height = CInt((SemiMinorAxis * 2) * Dimension)
            Return m_Orbit
        End Get
    End Property

    Public ReadOnly Property DeltaXDim As Integer
        Get
            Return DeltaX * Dimension
        End Get
    End Property

    Public ReadOnly Property DeltaYDim As Integer
        Get
            Return DeltaY * Dimension
        End Get
    End Property

    Private ReadOnly Property DeltaX As Double
        Get
            If Perihel <> 0 Then
                Return (SemiMajorAxis - (Perihel * AE)) / 2
            Else
                Return 0
            End If
        End Get
    End Property

    Private ReadOnly Property DeltaY As Double
        Get
            If Aphel <> 0 Then
                Return (SemiMinorAxis - (Aphel * AE)) / 2
            Else
                Return 0
            End If
        End Get
    End Property

    Public Property Perihel As Double = 0
    Public Property Aphel As Double = 0


    Private PosX As Double
    Private PosY As Double
    ''' <summary>
    ''' Angular Velocity
    ''' </summary>
    <Browsable(False)>
    Public ReadOnly Property Omega As Double
        Get
            If Not SemiMajorAxis = 0 Then
                Dim r As Double = Math.Sqrt(PosX ^ 2 + PosY ^ 2)
                Return Math.Sqrt(G * (SunMass / r)) / r
            Else
                Return 0
            End If
        End Get
    End Property

    Private Sub CalcPosition()
        PosX = Math.Cos(Velocity) * SemiMajorAxis + DeltaX
        PosY = Math.Sin(Velocity) * SemiMinorAxis + DeltaY
    End Sub

    Public Sub Animate()
        CalcPosition()
        m_velo += Omega * TimeFactor
    End Sub

    Private m_velo As Double = 0
    <Browsable(False)>
    Public ReadOnly Property Velocity As Double
        Get
            Return m_velo
        End Get
    End Property

    Private p As New Point(0, 0)
    <Browsable(False)>
    Public ReadOnly Property Position As Point
        Get
            CalcPosition()
            p.X = PosX * Dimension
            p.Y = PosY * Dimension
            Return p
        End Get
    End Property


    Public ReadOnly Property MetaInfo As String
        Get
            Dim s As String = PlanetName & "-Data:" & vbNewLine
            s += "Major Axis: " & SemiMajorAxis / AE & vbNewLine
            s += "Minor Axis: " & SemiMinorAxis / AE & vbNewLine
            s += "Angular Velocity: " & Math.Round(Omega * AE / 1000, 2) & " km/s" & vbNewLine
            s += "Dimension: 1:" & Format(1 / Dimension / 1000, "#,#") & " km"

            Return s
        End Get
    End Property

End Class