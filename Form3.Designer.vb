<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
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
        Me.components = New System.ComponentModel.Container()
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection()
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IssueDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KeyboardDBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KeyboardFinalDataSet = New Keyboard.KeyboardFinalDataSet()
        Me.KeyboardDBTableAdapter = New Keyboard.KeyboardFinalDataSetTableAdapters.KeyboardDBTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.KeyboardFinalDataSet1 = New Keyboard.KeyboardFinalDataSet()
        Me.KeyboardDBBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KeyboardDBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KeyboardFinalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KeyboardFinalDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KeyboardDBBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "Select * from KeyboardDB"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\KeyboardFinal.mdb"
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO `KeyboardDB` (`Issue`, `SNo`) VALUES (?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Issue", System.Data.OleDb.OleDbType.LongVarWChar, 0, "Issue"), New System.Data.OleDb.OleDbParameter("SNo", System.Data.OleDb.OleDbType.[Integer], 0, "SNo")})
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = "UPDATE `KeyboardDB` SET `Issue` = ?, `SNo` = ? WHERE ((`SNo` = ?))"
        Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Issue", System.Data.OleDb.OleDbType.LongVarWChar, 0, "Issue"), New System.Data.OleDb.OleDbParameter("SNo", System.Data.OleDb.OleDbType.[Integer], 0, "SNo"), New System.Data.OleDb.OleDbParameter("Original_SNo", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SNo", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = "DELETE FROM `KeyboardDB` WHERE ((`SNo` = ?))"
        Me.OleDbDeleteCommand1.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Original_SNo", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SNo", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "KeyboardDB", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Issue", "Issue"), New System.Data.Common.DataColumnMapping("SNo", "SNo")})})
        Me.OleDbDataAdapter1.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IssueDataGridViewTextBoxColumn, Me.SNoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.KeyboardDBBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(306, 148)
        Me.DataGridView1.TabIndex = 0
        '
        'IssueDataGridViewTextBoxColumn
        '
        Me.IssueDataGridViewTextBoxColumn.DataPropertyName = "Issue"
        Me.IssueDataGridViewTextBoxColumn.HeaderText = "Issue"
        Me.IssueDataGridViewTextBoxColumn.Name = "IssueDataGridViewTextBoxColumn"
        '
        'SNoDataGridViewTextBoxColumn
        '
        Me.SNoDataGridViewTextBoxColumn.DataPropertyName = "SNo"
        Me.SNoDataGridViewTextBoxColumn.HeaderText = "SNo"
        Me.SNoDataGridViewTextBoxColumn.Name = "SNoDataGridViewTextBoxColumn"
        '
        'KeyboardDBBindingSource
        '
        Me.KeyboardDBBindingSource.DataMember = "KeyboardDB"
        Me.KeyboardDBBindingSource.DataSource = Me.KeyboardFinalDataSet
        '
        'KeyboardFinalDataSet
        '
        Me.KeyboardFinalDataSet.DataSetName = "KeyboardFinalDataSet"
        Me.KeyboardFinalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'KeyboardDBTableAdapter
        '
        Me.KeyboardDBTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 179)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Issue Addition"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(12, 240)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(294, 21)
        Me.ComboBox1.TabIndex = 2
        '
        'KeyboardFinalDataSet1
        '
        Me.KeyboardFinalDataSet1.DataSetName = "KeyboardFinalDataSet"
        Me.KeyboardFinalDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'KeyboardDBBindingSource1
        '
        Me.KeyboardDBBindingSource1.DataMember = "KeyboardDB"
        Me.KeyboardDBBindingSource1.DataSource = Me.KeyboardFinalDataSet
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(463, 337)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KeyboardDBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KeyboardFinalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KeyboardFinalDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KeyboardDBBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents OleDbSelectCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbConnection1 As OleDb.OleDbConnection
    Friend WithEvents OleDbInsertCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbDataAdapter1 As OleDb.OleDbDataAdapter
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents KeyboardFinalDataSet As KeyboardFinalDataSet
    Friend WithEvents KeyboardDBBindingSource As BindingSource
    Friend WithEvents KeyboardDBTableAdapter As KeyboardFinalDataSetTableAdapters.KeyboardDBTableAdapter
    Friend WithEvents IssueDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents KeyboardFinalDataSet1 As KeyboardFinalDataSet
    Friend WithEvents KeyboardDBBindingSource1 As BindingSource
End Class
