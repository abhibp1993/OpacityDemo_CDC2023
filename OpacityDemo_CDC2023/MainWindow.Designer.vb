<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainWindow
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
        GroupGrid = New GroupBox()
        GroupAutomaton = New GroupBox()
        LblAutState = New Label()
        PictureBox1 = New PictureBox()
        GroupBox1 = New GroupBox()
        btnSolutionLoad = New Button()
        lblSolution = New Label()
        txtSolutionPath = New TextBox()
        btnSolutionBrowse = New Button()
        GroupBox2 = New GroupBox()
        BtnInitialize = New Button()
        TxtInitState = New TextBox()
        ListActions = New ListBox()
        BtnOpenBeliefView = New Button()
        ListPath = New ListBox()
        GroupBox3 = New GroupBox()
        Button5 = New Button()
        Button4 = New Button()
        Label2 = New Label()
        TxtNumSteps = New TextBox()
        Button2 = New Button()
        Button1 = New Button()
        OpenFileDialog1 = New OpenFileDialog()
        GroupAutomaton.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupGrid
        ' 
        GroupGrid.Location = New Point(28, 95)
        GroupGrid.Name = "GroupGrid"
        GroupGrid.Size = New Size(600, 600)
        GroupGrid.TabIndex = 0
        GroupGrid.TabStop = False
        GroupGrid.Text = "Gridworld"
        ' 
        ' GroupAutomaton
        ' 
        GroupAutomaton.Controls.Add(LblAutState)
        GroupAutomaton.Controls.Add(PictureBox1)
        GroupAutomaton.Location = New Point(653, 95)
        GroupAutomaton.Name = "GroupAutomaton"
        GroupAutomaton.Size = New Size(500, 500)
        GroupAutomaton.TabIndex = 1
        GroupAutomaton.TabStop = False
        GroupAutomaton.Text = "Automaton"
        ' 
        ' LblAutState
        ' 
        LblAutState.AutoSize = True
        LblAutState.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        LblAutState.ForeColor = Color.Maroon
        LblAutState.Location = New Point(104, 375)
        LblAutState.Name = "LblAutState"
        LblAutState.Size = New Size(199, 32)
        LblAutState.TabIndex = 1
        LblAutState.Text = "Automaton State:"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.Automaton
        PictureBox1.Location = New Point(29, 35)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(453, 293)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btnSolutionLoad)
        GroupBox1.Controls.Add(lblSolution)
        GroupBox1.Controls.Add(txtSolutionPath)
        GroupBox1.Controls.Add(btnSolutionBrowse)
        GroupBox1.Location = New Point(28, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(600, 77)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "Load Solution"
        ' 
        ' btnSolutionLoad
        ' 
        btnSolutionLoad.Location = New Point(416, 24)
        btnSolutionLoad.Name = "btnSolutionLoad"
        btnSolutionLoad.Size = New Size(153, 29)
        btnSolutionLoad.TabIndex = 35
        btnSolutionLoad.Text = "Load Solution"
        btnSolutionLoad.UseVisualStyleBackColor = True
        ' 
        ' lblSolution
        ' 
        lblSolution.AutoSize = True
        lblSolution.Location = New Point(31, 29)
        lblSolution.Name = "lblSolution"
        lblSolution.Size = New Size(91, 20)
        lblSolution.TabIndex = 34
        lblSolution.Text = "Solution File"
        ' 
        ' txtSolutionPath
        ' 
        txtSolutionPath.Location = New Point(128, 26)
        txtSolutionPath.Name = "txtSolutionPath"
        txtSolutionPath.ReadOnly = True
        txtSolutionPath.Size = New Size(240, 27)
        txtSolutionPath.TabIndex = 33
        ' 
        ' btnSolutionBrowse
        ' 
        btnSolutionBrowse.Location = New Point(374, 24)
        btnSolutionBrowse.Name = "btnSolutionBrowse"
        btnSolutionBrowse.Size = New Size(36, 29)
        btnSolutionBrowse.TabIndex = 32
        btnSolutionBrowse.Text = "..."
        btnSolutionBrowse.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(BtnInitialize)
        GroupBox2.Controls.Add(TxtInitState)
        GroupBox2.Controls.Add(ListActions)
        GroupBox2.Controls.Add(BtnOpenBeliefView)
        GroupBox2.Controls.Add(ListPath)
        GroupBox2.Location = New Point(1177, 95)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(393, 500)
        GroupBox2.TabIndex = 2
        GroupBox2.TabStop = False
        GroupBox2.Text = "State Sequence"
        ' 
        ' BtnInitialize
        ' 
        BtnInitialize.Location = New Point(288, 34)
        BtnInitialize.Name = "BtnInitialize"
        BtnInitialize.Size = New Size(94, 29)
        BtnInitialize.TabIndex = 39
        BtnInitialize.Text = "Initialize"
        BtnInitialize.UseVisualStyleBackColor = True
        ' 
        ' TxtInitState
        ' 
        TxtInitState.Location = New Point(6, 35)
        TxtInitState.Name = "TxtInitState"
        TxtInitState.Size = New Size(276, 27)
        TxtInitState.TabIndex = 38
        ' 
        ' ListActions
        ' 
        ListActions.Enabled = False
        ListActions.FormattingEnabled = True
        ListActions.ItemHeight = 20
        ListActions.Location = New Point(340, 76)
        ListActions.Name = "ListActions"
        ListActions.Size = New Size(37, 364)
        ListActions.TabIndex = 37
        ' 
        ' BtnOpenBeliefView
        ' 
        BtnOpenBeliefView.Location = New Point(6, 446)
        BtnOpenBeliefView.Name = "BtnOpenBeliefView"
        BtnOpenBeliefView.Size = New Size(258, 29)
        BtnOpenBeliefView.TabIndex = 36
        BtnOpenBeliefView.Text = "Generate Belief Representation"
        BtnOpenBeliefView.UseVisualStyleBackColor = True
        ' 
        ' ListPath
        ' 
        ListPath.FormattingEnabled = True
        ListPath.ItemHeight = 20
        ListPath.Location = New Point(6, 76)
        ListPath.Name = "ListPath"
        ListPath.Size = New Size(328, 364)
        ListPath.TabIndex = 0
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(Button5)
        GroupBox3.Controls.Add(Button4)
        GroupBox3.Controls.Add(Label2)
        GroupBox3.Controls.Add(TxtNumSteps)
        GroupBox3.Controls.Add(Button2)
        GroupBox3.Controls.Add(Button1)
        GroupBox3.Location = New Point(653, 12)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(500, 77)
        GroupBox3.TabIndex = 36
        GroupBox3.TabStop = False
        GroupBox3.Text = "Simulation Control"
        ' 
        ' Button5
        ' 
        Button5.Enabled = False
        Button5.Location = New Point(123, 24)
        Button5.Name = "Button5"
        Button5.Size = New Size(41, 42)
        Button5.TabIndex = 5
        Button5.Text = ">"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Enabled = False
        Button4.Location = New Point(76, 24)
        Button4.Name = "Button4"
        Button4.Size = New Size(41, 42)
        Button4.TabIndex = 4
        Button4.Text = "<"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(247, 33)
        Label2.Name = "Label2"
        Label2.Size = New Size(159, 28)
        Label2.TabIndex = 3
        Label2.Text = "Number of Steps"
        ' 
        ' TxtNumSteps
        ' 
        TxtNumSteps.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TxtNumSteps.Location = New Point(412, 30)
        TxtNumSteps.Name = "TxtNumSteps"
        TxtNumSteps.ReadOnly = True
        TxtNumSteps.Size = New Size(70, 34)
        TxtNumSteps.TabIndex = 2
        ' 
        ' Button2
        ' 
        Button2.Enabled = False
        Button2.Location = New Point(170, 24)
        Button2.Name = "Button2"
        Button2.Size = New Size(41, 42)
        Button2.TabIndex = 1
        Button2.Text = ">>"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Enabled = False
        Button1.Location = New Point(29, 24)
        Button1.Name = "Button1"
        Button1.Size = New Size(41, 42)
        Button1.TabIndex = 0
        Button1.Text = "<<"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' MainWindow
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1582, 853)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(GroupAutomaton)
        Controls.Add(GroupGrid)
        Name = "MainWindow"
        Text = "MainWindow"
        GroupAutomaton.ResumeLayout(False)
        GroupAutomaton.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupGrid As GroupBox
    Friend WithEvents GroupAutomaton As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LblAutState As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnSolutionLoad As Button
    Friend WithEvents lblSolution As Label
    Friend WithEvents txtSolutionPath As TextBox
    Friend WithEvents btnSolutionBrowse As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtNumSteps As TextBox
    Friend WithEvents ListPath As ListBox
    Friend WithEvents BtnOpenBeliefView As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents ListActions As ListBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents BtnInitialize As Button
    Friend WithEvents TxtInitState As TextBox
End Class
