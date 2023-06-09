<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        GroupBox1 = New GroupBox()
        PBox1 = New PictureBox()
        lblAutState = New Label()
        PBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        Cell04 = New Button()
        Cell40 = New Button()
        Cell03 = New Button()
        Cell41 = New Button()
        Cell02 = New Button()
        Cell42 = New Button()
        Cell01 = New Button()
        Cell43 = New Button()
        Cell00 = New Button()
        Cell44 = New Button()
        Cell14 = New Button()
        Cell30 = New Button()
        Cell13 = New Button()
        Cell31 = New Button()
        Cell12 = New Button()
        Cell32 = New Button()
        Cell11 = New Button()
        Cell33 = New Button()
        Cell10 = New Button()
        Cell34 = New Button()
        Cell24 = New Button()
        Cell20 = New Button()
        Cell23 = New Button()
        Cell21 = New Button()
        Cell22 = New Button()
        btnSolutionBrowse = New Button()
        txtSolutionPath = New TextBox()
        lblSolution = New Label()
        btnSolutionLoad = New Button()
        OpenFileDialog = New OpenFileDialog()
        txtSearchState = New TextBox()
        GroupBox2 = New GroupBox()
        listBoxStates = New ListBox()
        Label1 = New Label()
        GroupBox1.SuspendLayout()
        CType(PBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.AutoSize = True
        GroupBox1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        GroupBox1.Controls.Add(PBox1)
        GroupBox1.Controls.Add(lblAutState)
        GroupBox1.Controls.Add(PBox2)
        GroupBox1.Controls.Add(PictureBox1)
        GroupBox1.Controls.Add(Cell04)
        GroupBox1.Controls.Add(Cell40)
        GroupBox1.Controls.Add(Cell03)
        GroupBox1.Controls.Add(Cell41)
        GroupBox1.Controls.Add(Cell02)
        GroupBox1.Controls.Add(Cell42)
        GroupBox1.Controls.Add(Cell01)
        GroupBox1.Controls.Add(Cell43)
        GroupBox1.Controls.Add(Cell00)
        GroupBox1.Controls.Add(Cell44)
        GroupBox1.Controls.Add(Cell14)
        GroupBox1.Controls.Add(Cell30)
        GroupBox1.Controls.Add(Cell13)
        GroupBox1.Controls.Add(Cell31)
        GroupBox1.Controls.Add(Cell12)
        GroupBox1.Controls.Add(Cell32)
        GroupBox1.Controls.Add(Cell11)
        GroupBox1.Controls.Add(Cell33)
        GroupBox1.Controls.Add(Cell10)
        GroupBox1.Controls.Add(Cell34)
        GroupBox1.Controls.Add(Cell24)
        GroupBox1.Controls.Add(Cell20)
        GroupBox1.Controls.Add(Cell23)
        GroupBox1.Controls.Add(Cell21)
        GroupBox1.Controls.Add(Cell22)
        GroupBox1.Location = New Point(466, 103)
        GroupBox1.Margin = New Padding(3, 4, 3, 4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 4, 3, 4)
        GroupBox1.Size = New Size(1016, 579)
        GroupBox1.TabIndex = 27
        GroupBox1.TabStop = False
        GroupBox1.Text = "Gridworld"
        ' 
        ' PBox1
        ' 
        PBox1.BackColor = Color.Blue
        PBox1.Location = New Point(473, 156)
        PBox1.Margin = New Padding(3, 4, 3, 4)
        PBox1.Name = "PBox1"
        PBox1.Size = New Size(55, 55)
        PBox1.SizeMode = PictureBoxSizeMode.AutoSize
        PBox1.TabIndex = 28
        PBox1.TabStop = False
        PBox1.Visible = False
        ' 
        ' lblAutState
        ' 
        lblAutState.AutoSize = True
        lblAutState.Font = New Font("Rockwell", 16F, FontStyle.Regular, GraphicsUnit.Point)
        lblAutState.Location = New Point(627, 520)
        lblAutState.Name = "lblAutState"
        lblAutState.Size = New Size(342, 31)
        lblAutState.TabIndex = 27
        lblAutState.Text = "Automaton State: <NotSet>"
        ' 
        ' PBox2
        ' 
        PBox2.BackColor = Color.Red
        PBox2.Location = New Point(50, 264)
        PBox2.Margin = New Padding(3, 4, 3, 4)
        PBox2.Name = "PBox2"
        PBox2.Size = New Size(55, 55)
        PBox2.SizeMode = PictureBoxSizeMode.AutoSize
        PBox2.TabIndex = 26
        PBox2.TabStop = False
        PBox2.Visible = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(576, 246)
        PictureBox1.Margin = New Padding(3, 4, 3, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(434, 248)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 25
        PictureBox1.TabStop = False
        ' 
        ' Cell04
        ' 
        Cell04.BackColor = Color.White
        Cell04.Location = New Point(450, 451)
        Cell04.Margin = New Padding(3, 4, 3, 4)
        Cell04.Name = "Cell04"
        Cell04.Size = New Size(100, 100)
        Cell04.TabIndex = 24
        Cell04.UseVisualStyleBackColor = False
        ' 
        ' Cell40
        ' 
        Cell40.BackColor = Color.White
        Cell40.Location = New Point(26, 27)
        Cell40.Margin = New Padding(3, 4, 3, 4)
        Cell40.Name = "Cell40"
        Cell40.Size = New Size(100, 100)
        Cell40.TabIndex = 0
        Cell40.UseVisualStyleBackColor = False
        ' 
        ' Cell03
        ' 
        Cell03.BackColor = Color.White
        Cell03.Location = New Point(344, 451)
        Cell03.Margin = New Padding(3, 4, 3, 4)
        Cell03.Name = "Cell03"
        Cell03.Size = New Size(100, 100)
        Cell03.TabIndex = 23
        Cell03.UseVisualStyleBackColor = False
        ' 
        ' Cell41
        ' 
        Cell41.BackColor = Color.White
        Cell41.Location = New Point(132, 27)
        Cell41.Margin = New Padding(3, 4, 3, 4)
        Cell41.Name = "Cell41"
        Cell41.Size = New Size(100, 100)
        Cell41.TabIndex = 1
        Cell41.UseVisualStyleBackColor = False
        ' 
        ' Cell02
        ' 
        Cell02.BackColor = Color.White
        Cell02.Location = New Point(238, 451)
        Cell02.Margin = New Padding(3, 4, 3, 4)
        Cell02.Name = "Cell02"
        Cell02.Size = New Size(100, 100)
        Cell02.TabIndex = 22
        Cell02.UseVisualStyleBackColor = False
        ' 
        ' Cell42
        ' 
        Cell42.BackColor = Color.White
        Cell42.Location = New Point(238, 27)
        Cell42.Margin = New Padding(3, 4, 3, 4)
        Cell42.Name = "Cell42"
        Cell42.Size = New Size(100, 100)
        Cell42.TabIndex = 2
        Cell42.UseVisualStyleBackColor = False
        ' 
        ' Cell01
        ' 
        Cell01.BackColor = Color.White
        Cell01.Location = New Point(132, 451)
        Cell01.Margin = New Padding(3, 4, 3, 4)
        Cell01.Name = "Cell01"
        Cell01.Size = New Size(100, 100)
        Cell01.TabIndex = 21
        Cell01.UseVisualStyleBackColor = False
        ' 
        ' Cell43
        ' 
        Cell43.BackColor = Color.White
        Cell43.Location = New Point(344, 27)
        Cell43.Margin = New Padding(3, 4, 3, 4)
        Cell43.Name = "Cell43"
        Cell43.Size = New Size(100, 100)
        Cell43.TabIndex = 3
        Cell43.UseVisualStyleBackColor = False
        ' 
        ' Cell00
        ' 
        Cell00.BackColor = Color.White
        Cell00.Location = New Point(26, 451)
        Cell00.Margin = New Padding(3, 4, 3, 4)
        Cell00.Name = "Cell00"
        Cell00.Size = New Size(100, 100)
        Cell00.TabIndex = 20
        Cell00.UseVisualStyleBackColor = False
        ' 
        ' Cell44
        ' 
        Cell44.BackColor = Color.White
        Cell44.Location = New Point(450, 27)
        Cell44.Margin = New Padding(3, 4, 3, 4)
        Cell44.Name = "Cell44"
        Cell44.Size = New Size(100, 100)
        Cell44.TabIndex = 4
        Cell44.UseVisualStyleBackColor = False
        ' 
        ' Cell14
        ' 
        Cell14.BackColor = Color.White
        Cell14.Location = New Point(450, 345)
        Cell14.Margin = New Padding(3, 4, 3, 4)
        Cell14.Name = "Cell14"
        Cell14.Size = New Size(100, 100)
        Cell14.TabIndex = 19
        Cell14.UseVisualStyleBackColor = False
        ' 
        ' Cell30
        ' 
        Cell30.BackColor = Color.White
        Cell30.Location = New Point(26, 133)
        Cell30.Margin = New Padding(3, 4, 3, 4)
        Cell30.Name = "Cell30"
        Cell30.Size = New Size(100, 100)
        Cell30.TabIndex = 5
        Cell30.UseVisualStyleBackColor = False
        ' 
        ' Cell13
        ' 
        Cell13.BackColor = Color.Azure
        Cell13.Location = New Point(344, 345)
        Cell13.Margin = New Padding(3, 4, 3, 4)
        Cell13.Name = "Cell13"
        Cell13.Size = New Size(100, 100)
        Cell13.TabIndex = 18
        Cell13.UseVisualStyleBackColor = False
        ' 
        ' Cell31
        ' 
        Cell31.BackColor = Color.Azure
        Cell31.Location = New Point(132, 133)
        Cell31.Margin = New Padding(3, 4, 3, 4)
        Cell31.Name = "Cell31"
        Cell31.Size = New Size(100, 100)
        Cell31.TabIndex = 6
        Cell31.UseVisualStyleBackColor = False
        ' 
        ' Cell12
        ' 
        Cell12.BackColor = Color.Azure
        Cell12.Location = New Point(238, 345)
        Cell12.Margin = New Padding(3, 4, 3, 4)
        Cell12.Name = "Cell12"
        Cell12.Size = New Size(100, 100)
        Cell12.TabIndex = 17
        Cell12.UseVisualStyleBackColor = False
        ' 
        ' Cell32
        ' 
        Cell32.BackColor = Color.Azure
        Cell32.Location = New Point(238, 133)
        Cell32.Margin = New Padding(3, 4, 3, 4)
        Cell32.Name = "Cell32"
        Cell32.Size = New Size(100, 100)
        Cell32.TabIndex = 7
        Cell32.UseVisualStyleBackColor = False
        ' 
        ' Cell11
        ' 
        Cell11.BackColor = Color.Azure
        Cell11.Location = New Point(132, 345)
        Cell11.Margin = New Padding(3, 4, 3, 4)
        Cell11.Name = "Cell11"
        Cell11.Size = New Size(100, 100)
        Cell11.TabIndex = 16
        Cell11.UseVisualStyleBackColor = False
        ' 
        ' Cell33
        ' 
        Cell33.BackColor = Color.Azure
        Cell33.Location = New Point(344, 133)
        Cell33.Margin = New Padding(3, 4, 3, 4)
        Cell33.Name = "Cell33"
        Cell33.Size = New Size(100, 100)
        Cell33.TabIndex = 8
        Cell33.UseVisualStyleBackColor = False
        ' 
        ' Cell10
        ' 
        Cell10.BackColor = Color.White
        Cell10.Location = New Point(26, 345)
        Cell10.Margin = New Padding(3, 4, 3, 4)
        Cell10.Name = "Cell10"
        Cell10.Size = New Size(100, 100)
        Cell10.TabIndex = 15
        Cell10.UseVisualStyleBackColor = False
        ' 
        ' Cell34
        ' 
        Cell34.BackColor = Color.White
        Cell34.Location = New Point(450, 133)
        Cell34.Margin = New Padding(3, 4, 3, 4)
        Cell34.Name = "Cell34"
        Cell34.Size = New Size(100, 100)
        Cell34.TabIndex = 9
        Cell34.UseVisualStyleBackColor = False
        ' 
        ' Cell24
        ' 
        Cell24.BackColor = Color.White
        Cell24.Location = New Point(450, 239)
        Cell24.Margin = New Padding(3, 4, 3, 4)
        Cell24.Name = "Cell24"
        Cell24.Size = New Size(100, 100)
        Cell24.TabIndex = 14
        Cell24.UseVisualStyleBackColor = False
        ' 
        ' Cell20
        ' 
        Cell20.BackColor = Color.White
        Cell20.Location = New Point(26, 239)
        Cell20.Margin = New Padding(3, 4, 3, 4)
        Cell20.Name = "Cell20"
        Cell20.Size = New Size(100, 100)
        Cell20.TabIndex = 10
        Cell20.UseVisualStyleBackColor = False
        ' 
        ' Cell23
        ' 
        Cell23.BackColor = Color.Azure
        Cell23.Location = New Point(344, 239)
        Cell23.Margin = New Padding(3, 4, 3, 4)
        Cell23.Name = "Cell23"
        Cell23.Size = New Size(100, 100)
        Cell23.TabIndex = 13
        Cell23.UseVisualStyleBackColor = False
        ' 
        ' Cell21
        ' 
        Cell21.BackColor = Color.Azure
        Cell21.Location = New Point(132, 239)
        Cell21.Margin = New Padding(3, 4, 3, 4)
        Cell21.Name = "Cell21"
        Cell21.Size = New Size(100, 100)
        Cell21.TabIndex = 11
        Cell21.UseVisualStyleBackColor = False
        ' 
        ' Cell22
        ' 
        Cell22.BackColor = Color.Azure
        Cell22.Location = New Point(238, 239)
        Cell22.Margin = New Padding(3, 4, 3, 4)
        Cell22.Name = "Cell22"
        Cell22.Size = New Size(100, 100)
        Cell22.TabIndex = 12
        Cell22.UseVisualStyleBackColor = False
        ' 
        ' btnSolutionBrowse
        ' 
        btnSolutionBrowse.Location = New Point(367, 34)
        btnSolutionBrowse.Name = "btnSolutionBrowse"
        btnSolutionBrowse.Size = New Size(36, 29)
        btnSolutionBrowse.TabIndex = 28
        btnSolutionBrowse.Text = "..."
        btnSolutionBrowse.UseVisualStyleBackColor = True
        ' 
        ' txtSolutionPath
        ' 
        txtSolutionPath.Location = New Point(121, 36)
        txtSolutionPath.Name = "txtSolutionPath"
        txtSolutionPath.ReadOnly = True
        txtSolutionPath.Size = New Size(240, 27)
        txtSolutionPath.TabIndex = 29
        ' 
        ' lblSolution
        ' 
        lblSolution.AutoSize = True
        lblSolution.Location = New Point(24, 39)
        lblSolution.Name = "lblSolution"
        lblSolution.Size = New Size(91, 20)
        lblSolution.TabIndex = 30
        lblSolution.Text = "Solution File"
        ' 
        ' btnSolutionLoad
        ' 
        btnSolutionLoad.Location = New Point(409, 34)
        btnSolutionLoad.Name = "btnSolutionLoad"
        btnSolutionLoad.Size = New Size(153, 29)
        btnSolutionLoad.TabIndex = 31
        btnSolutionLoad.Text = "Load Solution"
        btnSolutionLoad.UseVisualStyleBackColor = True
        ' 
        ' OpenFileDialog
        ' 
        OpenFileDialog.FileName = "FileDialog"
        ' 
        ' txtSearchState
        ' 
        txtSearchState.Location = New Point(103, 55)
        txtSearchState.Name = "txtSearchState"
        txtSearchState.Size = New Size(327, 27)
        txtSearchState.TabIndex = 32
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(listBoxStates)
        GroupBox2.Controls.Add(Label1)
        GroupBox2.Controls.Add(txtSearchState)
        GroupBox2.Location = New Point(24, 103)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(436, 432)
        GroupBox2.TabIndex = 33
        GroupBox2.TabStop = False
        GroupBox2.Text = "State Explorer"
        ' 
        ' listBoxStates
        ' 
        listBoxStates.FormattingEnabled = True
        listBoxStates.ItemHeight = 20
        listBoxStates.Location = New Point(103, 88)
        listBoxStates.Name = "listBoxStates"
        listBoxStates.Size = New Size(327, 304)
        listBoxStates.TabIndex = 35
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(6, 58)
        Label1.Name = "Label1"
        Label1.Size = New Size(91, 20)
        Label1.TabIndex = 34
        Label1.Text = "Search State"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1582, 853)
        Controls.Add(GroupBox2)
        Controls.Add(btnSolutionLoad)
        Controls.Add(lblSolution)
        Controls.Add(txtSolutionPath)
        Controls.Add(btnSolutionBrowse)
        Controls.Add(GroupBox1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form1"
        Text = "Opacity Demo CDC 2023 (Base Game Viewer)"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(PBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PBox1 As PictureBox
    Friend WithEvents lblAutState As Label
    Friend WithEvents PBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Cell04 As Button
    Friend WithEvents Cell40 As Button
    Friend WithEvents Cell03 As Button
    Friend WithEvents Cell41 As Button
    Friend WithEvents Cell02 As Button
    Friend WithEvents Cell42 As Button
    Friend WithEvents Cell01 As Button
    Friend WithEvents Cell43 As Button
    Friend WithEvents Cell00 As Button
    Friend WithEvents Cell44 As Button
    Friend WithEvents Cell14 As Button
    Friend WithEvents Cell30 As Button
    Friend WithEvents Cell13 As Button
    Friend WithEvents Cell31 As Button
    Friend WithEvents Cell12 As Button
    Friend WithEvents Cell32 As Button
    Friend WithEvents Cell11 As Button
    Friend WithEvents Cell33 As Button
    Friend WithEvents Cell10 As Button
    Friend WithEvents Cell34 As Button
    Friend WithEvents Cell24 As Button
    Friend WithEvents Cell20 As Button
    Friend WithEvents Cell23 As Button
    Friend WithEvents Cell21 As Button
    Friend WithEvents Cell22 As Button
    Friend WithEvents btnSolutionBrowse As Button
    Friend WithEvents txtSolutionPath As TextBox
    Friend WithEvents lblSolution As Label
    Friend WithEvents btnSolutionLoad As Button
    Friend WithEvents OpenFileDialog As OpenFileDialog
    Friend WithEvents txtSearchState As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents listBoxStates As ListBox
End Class
