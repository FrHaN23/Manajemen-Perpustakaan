<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formMenu
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MasterDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataBukuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataJenisBukuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanDataBukuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanDataJenisBukuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PengaturanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SwitchUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.statusName = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusLevel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MasterDataToolStripMenuItem, Me.TransaksiToolStripMenuItem, Me.LaporanToolStripMenuItem, Me.PengaturanToolStripMenuItem, Me.KeluarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MasterDataToolStripMenuItem
        '
        Me.MasterDataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataBukuToolStripMenuItem, Me.DataJenisBukuToolStripMenuItem})
        Me.MasterDataToolStripMenuItem.Name = "MasterDataToolStripMenuItem"
        Me.MasterDataToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.MasterDataToolStripMenuItem.Text = "Master Data"
        '
        'DataBukuToolStripMenuItem
        '
        Me.DataBukuToolStripMenuItem.Name = "DataBukuToolStripMenuItem"
        Me.DataBukuToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.DataBukuToolStripMenuItem.Text = "Data Buku"
        '
        'DataJenisBukuToolStripMenuItem
        '
        Me.DataJenisBukuToolStripMenuItem.Name = "DataJenisBukuToolStripMenuItem"
        Me.DataJenisBukuToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.DataJenisBukuToolStripMenuItem.Text = "Data Jenis Buku"
        '
        'TransaksiToolStripMenuItem
        '
        Me.TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        Me.TransaksiToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.TransaksiToolStripMenuItem.Text = "Transaksi"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LaporanDataBukuToolStripMenuItem, Me.LaporanDataJenisBukuToolStripMenuItem})
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.LaporanToolStripMenuItem.Text = "Laporan"
        '
        'LaporanDataBukuToolStripMenuItem
        '
        Me.LaporanDataBukuToolStripMenuItem.Name = "LaporanDataBukuToolStripMenuItem"
        Me.LaporanDataBukuToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.LaporanDataBukuToolStripMenuItem.Text = "Laporan Data Buku"
        '
        'LaporanDataJenisBukuToolStripMenuItem
        '
        Me.LaporanDataJenisBukuToolStripMenuItem.Name = "LaporanDataJenisBukuToolStripMenuItem"
        Me.LaporanDataJenisBukuToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.LaporanDataJenisBukuToolStripMenuItem.Text = "Laporan Data Jenis Buku"
        '
        'PengaturanToolStripMenuItem
        '
        Me.PengaturanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserToolStripMenuItem, Me.SwitchUserToolStripMenuItem})
        Me.PengaturanToolStripMenuItem.Name = "PengaturanToolStripMenuItem"
        Me.PengaturanToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.PengaturanToolStripMenuItem.Text = "Pengaturan"
        '
        'UserToolStripMenuItem
        '
        Me.UserToolStripMenuItem.Name = "UserToolStripMenuItem"
        Me.UserToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.UserToolStripMenuItem.Text = "User"
        '
        'SwitchUserToolStripMenuItem
        '
        Me.SwitchUserToolStripMenuItem.Name = "SwitchUserToolStripMenuItem"
        Me.SwitchUserToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.SwitchUserToolStripMenuItem.Text = "Switch User"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.statusName, Me.StatusLevel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 428)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(800, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 17)
        '
        'statusName
        '
        Me.statusName.Name = "statusName"
        Me.statusName.Size = New System.Drawing.Size(119, 17)
        Me.statusName.Text = "ToolStripStatusLabel2"
        '
        'StatusLevel
        '
        Me.StatusLevel.Name = "StatusLevel"
        Me.StatusLevel.Size = New System.Drawing.Size(119, 17)
        Me.StatusLevel.Text = "ToolStripStatusLabel3"
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 404)
        Me.Panel1.TabIndex = 3
        '
        'formMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "formMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buku-Bukuan"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MasterDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataBukuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataJenisBukuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransaksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PengaturanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents statusName As ToolStripStatusLabel
    Friend WithEvents StatusLevel As ToolStripStatusLabel
    Friend WithEvents LaporanDataBukuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanDataJenisBukuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SwitchUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
End Class
