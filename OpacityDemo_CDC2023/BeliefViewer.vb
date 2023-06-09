Imports OpacityDemo_CDC2023.MainWindow

Public Class BeliefViewer

    Private m_BeliefViews(4, 2) As GroupBox
    Private m_BeliefViewGrid(4, 2) As Gridworld
    Private m_BeliefGameState As BeliefGameState


    Private Sub BeliefViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AutoSizeMode = AutoSizeMode.GrowOnly
        Me.AutoSize = True

        ' Create 15 instances of groupbox
        Dim size As Integer = Math.Min(Me.Width / 5, Me.Height / 3)
        For i As Integer = 0 To 4
            For j As Integer = 0 To 2
                ' Add a groupbox to represent one belief state view 
                Dim beliefView As New GroupBox()
                beliefView.Width = size
                beliefView.Height = size
                beliefView.Left = i * size
                beliefView.Top = j * size
                beliefView.Visible = False
                m_BeliefViews(i, j) = beliefView

                ' Add groupbox to form 
                Me.Controls.Add(m_BeliefViews(i, j))

                ' Add Grid to groupbox 
                Dim beliefViewGrid As New Gridworld(Nothing, beliefView, 0.9 * size / 5, 10, 10)
                m_BeliefViewGrid(i, j) = beliefViewGrid
            Next
        Next

        ' Update visualization 
        UpdateViz()

        ' Autosize form 
        Me.AutoScrollMinSize = Me.GetPreferredSize(Me.Size)
    End Sub

    Public Sub SetBeliefState(beliefGameState As BeliefGameState)
        m_BeliefGameState = beliefGameState
    End Sub

    Public Sub UpdateViz()
        ' Clear all controls in all groupboxes
        Me.ResetViz()

        ' For game state in belief, show it in respective groupbox
        If m_BeliefGameState Is Nothing Then
            Exit Sub
        End If

        ' Show beliefs
        Dim count As Integer = 0
        Dim i, j As Integer
        For Each gameState As GameState In m_BeliefGameState.Belief
            i = count Mod 5
            j = count / 5

            m_BeliefViewGrid(i, j).SetState(gameState)
            m_BeliefViews(i, j).Visible = True

            count += 1
        Next

    End Sub

    Private Sub ResetViz()
        For Each beliefView As GroupBox In m_BeliefViews
            beliefView.Visible = False
        Next
    End Sub
End Class