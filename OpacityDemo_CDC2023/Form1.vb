Imports System.Windows.Forms.AxHost
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class Form1

    Private m_Transitions As Dictionary(Of Integer, Dictionary(Of String, Integer))
    Private m_Win As List(Of Integer)
    Private m_States As HashSet(Of BeliefGameState)
    Private m_GameStates As New HashSet(Of GameState)
    Private m_InitState As New BeliefGameState
    Private m_CurrState As BeliefGameState

    Private m_Cells As New Dictionary(Of String, Button)

    Public Class GameState
        Public Property P1X As Integer
        Public Property P1Y As Integer
        Public Property P2X As Integer
        Public Property P2Y As Integer
        Public Property Turn As Integer
        Public Property AutState As Integer

        Public Overrides Function ToString() As String
            Return $"(({P1X}, {P1Y}, {P2X}, {P2Y}, {Turn}), {AutState})"
        End Function
    End Class

    Public Class BeliefGameState
        Public Property StateId As Integer
        Public Property State As GameState
        Public Property BeliefState As List(Of GameState)

        Public Overrides Function ToString() As String
            Dim beliefStr As String = String.Join(", ", BeliefState)
            Return $"{State}, {{{beliefStr}}}"
        End Function
    End Class

    Private Sub btnSolutionBrowse_Click(sender As Object, e As EventArgs) Handles btnSolutionBrowse.Click
        If OpenFileDialog.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            txtSolutionPath.Text = OpenFileDialog.FileName
        End If
    End Sub

    Private Sub btnSolutionLoad_Click(sender As Object, e As EventArgs) Handles btnSolutionLoad.Click
        ' Clear data dictionaries
        m_States = New HashSet(Of BeliefGameState)
        m_Transitions = New Dictionary(Of Integer, Dictionary(Of String, Integer))
        m_Win = New List(Of Integer)

        ' Read JSON file into string 
        If Not System.IO.File.Exists(txtSolutionPath.Text) Then
            MsgBox("File not found", MsgBoxStyle.Critical)
            Exit Sub
        End If
        Dim jsonString As String = System.IO.File.ReadAllText(txtSolutionPath.Text)

        ' Parse JSON string into a JObject
        Dim json As JObject = JObject.Parse(jsonString)

        ' Load JProperties 
        For Each prop As JProperty In json.Properties()
            If prop.Name = "state" Then
                Dim jsonStates As JObject = json.GetValue("state")
                listBoxStates.Items().Clear()
                For Each stateId As JProperty In jsonStates.Properties()
                    Dim trueState As List(Of Integer) = jsonStates.GetValue(stateId.Name).Item(0).ToObject(Of List(Of Integer))
                    Dim autState As Integer = Convert.ToInt64(jsonStates.GetValue(stateId.Name).Item(1))

                    Dim state As New GameState()
                    state.P1X = trueState.ElementAt(0)
                    state.P1Y = trueState.ElementAt(1)
                    state.P2X = trueState.ElementAt(2)
                    state.P2Y = trueState.ElementAt(3)
                    state.Turn = trueState.ElementAt(4)
                    state.AutState = autState
                    m_GameStates.Add(state)

                    Dim belief As New List(Of GameState)
                    For Each item In jsonStates.GetValue(stateId.Name).Item(2)
                        Dim tmpState As New GameState()
                        tmpState.P1X = item.ElementAt(0).ElementAt(0)
                        tmpState.P1Y = item.ElementAt(0).ElementAt(1)
                        tmpState.P2X = item.ElementAt(0).ElementAt(2)
                        tmpState.P2Y = item.ElementAt(0).ElementAt(3)
                        tmpState.Turn = item.ElementAt(0).ElementAt(4)
                        tmpState.AutState = item.ElementAt(1)

                        belief.Add(tmpState)
                    Next

                    Dim beliefState As New BeliefGameState
                    beliefState.StateId = Convert.ToInt64(stateId.Name)
                    beliefState.State = state
                    beliefState.BeliefState = belief

                    m_States.Add(beliefState)
                Next
                MsgBox("Updated states...")
            ElseIf prop.Name = "win" Then

            ElseIf prop.Name = "init_state" Then
                Dim jsonInitState As JArray = json.GetValue("init_state")

                Dim trueState As List(Of Integer) = jsonInitState.Item(0).ToObject(Of List(Of Integer))
                Dim autState As Integer = Convert.ToInt64(jsonInitState.Item(1))

                Dim state As New GameState()
                state.P1X = trueState.ElementAt(0)
                state.P1Y = trueState.ElementAt(1)
                state.P2X = trueState.ElementAt(2)
                state.P2Y = trueState.ElementAt(3)
                state.Turn = trueState.ElementAt(4)
                state.AutState = autState
                m_GameStates.Add(state)

                Dim belief As New List(Of GameState)
                For Each item In jsonInitState.Item(2)
                    Dim tmpState As New GameState()
                    tmpState.P1X = item.ElementAt(0).ElementAt(0)
                    tmpState.P1Y = item.ElementAt(0).ElementAt(1)
                    tmpState.P2X = item.ElementAt(0).ElementAt(2)
                    tmpState.P2Y = item.ElementAt(0).ElementAt(3)
                    tmpState.Turn = item.ElementAt(0).ElementAt(4)
                    tmpState.AutState = item.ElementAt(1)

                    belief.Add(tmpState)
                Next

                Dim beliefState As New BeliefGameState
                'beliefState.StateId = Convert.ToInt64(stateId.Name)
                beliefState.State = state
                beliefState.BeliefState = belief
                m_InitState = beliefState

            Else ' prop.Name = "transitions"

            End If
        Next

        ' Get a list of all top-level keys
        Dim states As List(Of String) = json.Properties().Select(Function(p) p.Name).ToList()

        ' Show all source states in ListView
        ' updateStateList()

        ' Initialize state 
        Me.setInitState()
    End Sub

    Private Sub updateStateList()
        listBoxStates.Items.Clear()
        For Each state As GameState In m_GameStates
            listBoxStates.Items.Add(state)
        Next
    End Sub


    Private Sub SetInitState()
        Me.listBoxStates.Items.Add(m_InitState)
        Me.m_currState = Me.m_InitState
        Me.RenderState()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        m_Cells("Cell00") = Cell00
        m_Cells("Cell01") = Cell01
        m_Cells("Cell02") = Cell02
        m_Cells("Cell03") = Cell03
        m_Cells("Cell04") = Cell04

        m_Cells("Cell10") = Cell10
        m_Cells("Cell11") = Cell11
        m_Cells("Cell12") = Cell12
        m_Cells("Cell13") = Cell13
        m_Cells("Cell14") = Cell14

        m_Cells("Cell20") = Cell20
        m_Cells("Cell21") = Cell21
        m_Cells("Cell22") = Cell22
        m_Cells("Cell23") = Cell23
        m_Cells("Cell24") = Cell24

        m_Cells("Cell30") = Cell30
        m_Cells("Cell31") = Cell31
        m_Cells("Cell32") = Cell32
        m_Cells("Cell33") = Cell33
        m_Cells("Cell34") = Cell34

        m_Cells("Cell40") = Cell40
        m_Cells("Cell41") = Cell41
        m_Cells("Cell42") = Cell42
        m_Cells("Cell43") = Cell43
        m_Cells("Cell44") = Cell44
    End Sub

    Private Sub RenderState()
        Dim state As GameState = m_CurrState.State

        ' Show current configuration 
        Dim p1CellName As String = $"Cell{state.P1X}{state.P1Y}"
        Dim p1Cell As Button = m_Cells($"Cell{state.P1X}{state.P1Y}")
        Dim p2Cell As Button = m_Cells($"Cell{state.P2X}{state.P2Y}")
        Me.PBox1.Left = p1Cell.Left + (p1Cell.Width - PBox1.Width) / 2
        Me.PBox1.Top = p1Cell.Top + (p1Cell.Height - PBox1.Height) / 2
        Me.PBox2.Left = p2Cell.Left + (p2Cell.Width - PBox2.Width) / 2
        Me.PBox2.Top = p2Cell.Top + (p2Cell.Height - PBox2.Height) / 2
        Me.PBox1.Visible = True
        Me.PBox2.Visible = True

        ' Update automaton state 
        Me.lblAutState.Text = $"Automaton State: 1 {state.AutState}"


    End Sub

End Class
