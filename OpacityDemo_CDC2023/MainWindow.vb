Imports System.Windows.Forms.AxHost
Imports Newtonsoft.Json.Linq
Imports OpacityDemo_CDC2023.Form1

Public Class MainWindow

    Dim m_Gridworld As Gridworld
    Dim m_Transitions As New Dictionary(Of Integer, Dictionary(Of String, Integer))
    Dim m_States As New Dictionary(Of Integer, BeliefGameState)
    Dim m_InitState As BeliefGameState
    Dim m_CurrState As BeliefGameState

    Public Class GameState
        Public ReadOnly Property P1X As Integer
        Public ReadOnly Property P1Y As Integer
        Public ReadOnly Property P2X As Integer
        Public ReadOnly Property P2Y As Integer
        Public ReadOnly Property Turn As Integer
        Public ReadOnly Property AutState As Integer

        Public Sub New(p1x As Integer, p1y As Integer, p2x As Integer, p2y As Integer, turn As Integer, autState As Integer)
            Me.P1X = p1x
            Me.P1Y = p1y
            Me.P2X = p2x
            Me.P2Y = p2y
            Me.Turn = turn
            Me.AutState = autState
        End Sub
        Public Sub New(stateList As List(Of Integer), autState As Integer)
            Me.New(stateList.Item(0), stateList.Item(1), stateList.Item(2), stateList.Item(3), stateList.Item(4), autState)
        End Sub

        Public Overrides Function Equals(obj As Object) As Boolean
            If TypeOf (obj) Is GameState Then
                Return Me.P1X = obj.P1X And
                    Me.P1X = obj.P1Y And
                    Me.P1X = obj.P2X And
                    Me.P1X = obj.P2Y And
                    Me.P1X = obj.Turn And
                    Me.AutState = obj.AutState
            End If
            Return False
        End Function

        Public Overrides Function ToString() As String
            Return $"(({P1X}, {P1Y}, {P2X}, {P2Y}, {Turn}), {AutState})"
        End Function
    End Class

    Public Class BeliefGameState
        Public ReadOnly Property Id As Integer
        Public ReadOnly Property GameState As GameState
        Public ReadOnly Property Belief As List(Of GameState)

        Public Sub New(id As Integer, gameState As GameState, belief As List(Of GameState))
            Me.Id = id
            Me.GameState = gameState
            Me.Belief = belief
        End Sub

        Public Overrides Function Equals(obj As Object) As Boolean
            If TypeOf (obj) Is BeliefGameState Then
                Return Me.Id = obj.id
            End If
            Return False
        End Function

        Public Overrides Function ToString() As String
            Dim beliefStr As String = String.Join(", ", Belief)
            Return $"{GameState}, {{{beliefStr}}}"
        End Function
    End Class

    Public Class Gridworld

        ' Create a new 5x5 array to hold the buttons.
        Private Form As MainWindow
        Public Grid(4, 4) As Button
        Public Player1 As PictureBox
        Public Player2 As PictureBox
        Private CurrState As GameState

        Public Sub New(form As Form, groupBox As GroupBox, cellSize As Integer,
                       Optional offsetX As Integer = 25, Optional offsetY As Integer = 20)
            ' Save form 
            Me.Form = form

            ' Define offset (determined by trial) 
            Dim offsetLeft As Integer = offsetX
            Dim offsetTop As Integer = offsetY

            ' Loop through each row and column and create a new button (to represent cell).
            For row As Integer = 0 To 4
                For col As Integer = 0 To 4
                    ' Create a new button.
                    Dim newButton As New Button
                    newButton.Parent = groupBox

                    ' Set the button's properties.
                    newButton.Name = "Button" & row.ToString() & col.ToString()
                    newButton.Size = New Size(cellSize, cellSize)
                    newButton.Location = New Point(col * cellSize + offsetLeft, (4 - row) * cellSize + offsetTop)
                    newButton.Text = row.ToString() & "," & col.ToString()
                    newButton.TextAlign = ContentAlignment.TopLeft
                    newButton.Enabled = False
                    AddHandler newButton.Click, AddressOf GridCell_Click
                    AddHandler newButton.MouseHover, AddressOf GridCell_MouseHover
                    AddHandler newButton.MouseLeave, AddressOf GridCell_MouseLeave

                    ' Add the button to the form and to the array.
                    groupBox.Controls.Add(newButton)
                    Grid(row, col) = newButton
                Next
            Next
            'Apply default color scheme to buttoms 
            Me.ApplyDefaultColorScheme()

            ' Add player sprites 
            Player1 = New PictureBox
            Player2 = New PictureBox

            Player1.BackColor = Color.Blue
            Player2.BackColor = Color.Red

            Player1.Visible = False
            Player2.Visible = False

            Player1.Size = New Point(0.5 * cellSize, 0.5 * cellSize)
            Player2.Size = New Point(0.5 * cellSize, 0.5 * cellSize)

            groupBox.Controls.Add(Player1)
            groupBox.Controls.Add(Player2)

        End Sub

        Private Sub ApplyDefaultColorScheme()
            For row As Integer = 0 To 4
                For col As Integer = 0 To 4
                    If 1 <= row And row <= 3 And 1 <= col And col <= 3 Then
                        Grid(row, col).BackColor = Color.LightBlue
                    Else
                        Grid(row, col).BackColor = Color.White
                    End If
                Next
            Next

        End Sub

        Private Sub GridCell_MouseLeave(sender As Object, e As EventArgs)
            Dim obj As Button = sender
            If obj.Enabled Then
                Me.ApplyDefaultColorScheme()
            End If
        End Sub

        Private Sub GridCell_MouseHover(sender As Object, e As EventArgs)
            Dim obj As Button = sender
            If obj.Enabled Then
                obj.BackColor = Color.Yellow
            End If
        End Sub

        Private Sub GridCell_Click(sender As Object, e As EventArgs)
            ' Declare action 
            Dim action As String

            ' Infer the action by consequence.
            Dim currCell As Point
            If CurrState.Turn = 1 Then
                currCell = New Point(CurrState.P1X, CurrState.P1Y)
            Else
                currCell = New Point(CurrState.P2X, CurrState.P2Y)
            End If

            Dim clickedCell As Point
            Dim found As Boolean
            For i As Integer = 0 To 4
                For j As Integer = 0 To 4
                    If Grid(i, j) Is sender Then
                        clickedCell = New Point(i, j)
                        found = True
                        Exit For
                    End If
                Next
                If found Then Exit For
            Next

            Dim diff As Point = clickedCell - currCell
            If diff.X = 1 Then
                action = "N"
            ElseIf diff.X = -1 Then
                action = "S"
            ElseIf diff.Y = 1 Then
                action = "E"
            Else   'If diff.Y = -1 Then
                action = "W"
            End If

            ' Apply action 
            Me.Form.ApplyAction(action)
        End Sub

        Public Sub SetState(state As GameState)

            Dim p1Cell As Button = Me.Grid(state.P1X, state.P1Y)
            Dim p2Cell As Button = Me.Grid(state.P2X, state.P2Y)

            Dim p1Location As Point = New Point(p1Cell.Left + (p1Cell.Width - Player1.Width) / 2,
                                                p1Cell.Top + (p1Cell.Height - Player1.Height) / 2)

            Dim p2Location As Point = New Point(p2Cell.Left + (p2Cell.Width - Player2.Width) / 2,
                                                p2Cell.Top + (p2Cell.Height - Player2.Height) / 2)

            Me.Player1.Location = p1Location
            Me.Player2.Location = p2Location
            Me.Player1.Visible = True
            Me.Player2.Visible = True
            Me.Player1.BringToFront()
            Me.Player2.BringToFront()

            Me.CurrState = state
        End Sub

        Public Sub SetActions(actions As List(Of String))
            If CurrState Is Nothing Then
                Exit Sub
            End If

            ' Apply default color scheme
            Me.ApplyDefaultColorScheme()

            ' Disable all cells 
            For Each btn As Button In Grid
                btn.Enabled = False
                btn.FlatAppearance.BorderColor = Color.Black
            Next

            ' Based on turn decide which player moves
            Dim cell As Point
            If CurrState.Turn = 1 Then
                cell = New Point(CurrState.P1X, CurrState.P1Y)
            Else
                cell = New Point(CurrState.P2X, CurrState.P2Y)
            End If

            ' Process the enabled states 
            Dim newCell As Point
            For Each act As String In actions
                ' Determine next cell on applying action
                If act.ToUpper() = "N" Then
                    newCell = New Point(cell.X + 1, cell.Y)
                ElseIf act.ToUpper() = "E" Then
                    newCell = New Point(cell.X, cell.Y + 1)
                ElseIf act.ToUpper() = "S" Then
                    newCell = New Point(cell.X - 1, cell.Y)
                Else   'If act.ToUpper() = "W" Then
                    newCell = New Point(cell.X, cell.Y - 1)
                End If

                ' Update visualizations
                Dim btn As Button
                If 0 <= newCell.X And newCell.X <= 4 And 0 <= newCell.Y And newCell.Y <= 4 Then
                    btn = Grid(newCell.X, newCell.Y)
                    btn.Enabled = True
                    If CurrState.Turn = 1 Then
                        btn.FlatAppearance.BorderColor = Color.Blue
                    Else
                        btn.FlatAppearance.BorderColor = Color.Red
                    End If
                End If
            Next


        End Sub

    End Class

    Private Sub MainWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        m_Gridworld = New Gridworld(Me, Me.GroupGrid, 80)
        'm_Gridworld.SetState(New GameState(0, 0, 0, 1, 1, 1))
        'm_Gridworld.SetActions(New List(Of String)({"N", "E"}))
        txtSolutionPath.Text = "E:\Github-Repositories\ggsolver\examples\opacity\out\ex14_5x5_UAV_UGV\0_1\ex14_5x5_UAV_UGV_0_1_p1.json"
    End Sub

    Private Sub btnSolutionBrowse_Click(sender As Object, e As EventArgs) Handles btnSolutionBrowse.Click
        If OpenFileDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            txtSolutionPath.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub btnSolutionLoad_Click(sender As Object, e As EventArgs) Handles btnSolutionLoad.Click
        ' Clear data dictionaries
        m_Transitions.Clear()
        m_States.Clear()
        m_InitState = Nothing

        ' Read JSON file into string 
        If Not System.IO.File.Exists(txtSolutionPath.Text) Then
            MsgBox("File not found", MsgBoxStyle.Critical)
            Exit Sub
        End If
        Dim jsonString As String = System.IO.File.ReadAllText(txtSolutionPath.Text)

        ' Parse JSON string into a JObject
        Dim json As JObject = JObject.Parse(jsonString)

        ' Extract top-level JSON data 
        Dim jsonInitState As Integer = json.GetValue("init_state")
        Dim jsonState As JObject = json.GetValue("state")
        Dim jsonTransitions As JObject = json.GetValue("transitions")

        ' Extract all states 
        For Each prop As JProperty In jsonState.Properties()
            ' Get state id 
            Dim id As Integer = Val(prop.Name)
            Dim gameState As GameState = New GameState(prop.Value.Item(0).ToObject(Of List(Of Integer)), Val(prop.Value.Item(1)))
            Dim rawBeliefState As JArray = prop.Value.Item(2)
            Dim beliefState As New List(Of GameState)

            Dim loopGameState As GameState
            For Each item As JToken In rawBeliefState
                loopGameState = New GameState(item.Item(0).ToObject(Of List(Of Integer)), Val(item.Item(1)))
                beliefState.Add(loopGameState)
            Next

            m_States(id) = New BeliefGameState(id, gameState, beliefState)
        Next

        ' Extract initial state 
        m_InitState = m_States(jsonInitState)

        ' Extract transitions 
        Dim uid As Integer
        Dim act As String
        Dim vid As Integer
        For Each jsonTrans As JProperty In jsonTransitions.Properties()
            uid = Val(jsonTrans.Name)
            m_Transitions(uid) = New Dictionary(Of String, Integer)
            For Each jsonAct As JProperty In jsonTrans.Value
                act = jsonAct.Name.ToString
                vid = Val(jsonAct.Value)
                m_Transitions(uid)(act) = vid
            Next
        Next

        ' Initialize gridworld 
        m_CurrState = m_InitState
        ListPath.Items().Clear()
        ListActions.Items().Clear()
        ListPath.Items().Add(m_CurrState)
        ListPath.SelectedIndex = ListPath.Items.Count - 1
        UpdateViz()

    End Sub

    Public Sub ApplyAction(action As String)
        Dim nextStateId As Integer = m_Transitions(m_CurrState.Id)(action)
        m_CurrState = m_States(nextStateId)
        UpdateViz()
        ListPath.Items().Add(m_CurrState)
        ListPath.SelectedIndex = ListPath.Items.Count - 1
        ListActions.Items().Add(action)
    End Sub

    Public Sub UpdateViz()
        LblAutState.Text = "Automaton State: " & m_CurrState.GameState.AutState.ToString
        m_Gridworld.SetState(m_CurrState.GameState)
        m_Gridworld.SetActions(m_Transitions(m_CurrState.Id).Keys.ToList)
    End Sub

    Private Sub BtnOpenBeliefView_Click(sender As Object, e As EventArgs) Handles BtnOpenBeliefView.Click
        Dim beliefGameState As BeliefGameState = ListPath.SelectedItem

        'Check if belief viewer is already open. If yes, update the belief state in viewer. Else, create new.
        Dim frm As BeliefViewer = Application.OpenForms.OfType(Of BeliefViewer)().FirstOrDefault()

        If frm IsNot Nothing Then
            ' Form is already open, activate it
            frm.SetBeliefState(beliefGameState)
            frm.UpdateViz()
            frm.Activate()
        Else
            ' Form is not open, create and show it
            BeliefViewer.SetBeliefState(beliefGameState)
            BeliefViewer.Show()

        End If
    End Sub

    Private Sub BtnInitialize_Click(sender As Object, e As EventArgs) Handles BtnInitialize.Click
        ' Try finding the initial state in state list  
        Dim initState As BeliefGameState = Nothing
        For Each state As BeliefGameState In m_States.Values()
            Dim stateStr As String = state.ToString().Replace(" ", "")
            Dim givenStr As String = Me.TxtInitState.Text.Replace(" ", "")
            If stateStr = givenStr Then
                initState = state
                Exit For
            End If
        Next

        ' If given initial state is valid
        If initState IsNot Nothing Then
            m_CurrState = initState
            ListPath.Items().Clear()
            ListActions.Items().Clear()
            ListPath.Items().Add(initState)
            ListPath.SelectedIndex = ListPath.Items.Count - 1
            Me.UpdateViz()
        Else
            MsgBox("Initial state not found", MsgBoxStyle.Critical)
        End If

    End Sub

    Private Sub ListPath_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListPath.SelectedIndexChanged
        Me.TxtNumSteps.Text = ListPath.Items.Count
    End Sub
End Class