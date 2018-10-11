namespace AdobeSwatchExchangeLoader
{
  partial class MainForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.splitContainer = new System.Windows.Forms.SplitContainer();
      this.filesListBox = new System.Windows.Forms.ListBox();
      this.aseSplitContainer = new System.Windows.Forms.SplitContainer();
      this.simpleColorGrid = new AdobeSwatchExchangeLoader.SimpleColorGrid();
      this.aseExplorerTreeView = new AdobeSwatchExchangeLoader.AseExplorerTreeView();
      this.imageList = new System.Windows.Forms.ImageList(this.components);
      this.menuStrip = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.splitContainer.Panel1.SuspendLayout();
      this.splitContainer.Panel2.SuspendLayout();
      this.splitContainer.SuspendLayout();
      this.aseSplitContainer.Panel1.SuspendLayout();
      this.aseSplitContainer.Panel2.SuspendLayout();
      this.aseSplitContainer.SuspendLayout();
      this.menuStrip.SuspendLayout();
      this.SuspendLayout();
      // 
      // splitContainer
      // 
      this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
      this.splitContainer.Location = new System.Drawing.Point(0, 24);
      this.splitContainer.Name = "splitContainer";
      // 
      // splitContainer.Panel1
      // 
      this.splitContainer.Panel1.Controls.Add(this.filesListBox);
      // 
      // splitContainer.Panel2
      // 
      this.splitContainer.Panel2.Controls.Add(this.aseSplitContainer);
      this.splitContainer.Size = new System.Drawing.Size(744, 585);
      this.splitContainer.SplitterDistance = 250;
      this.splitContainer.TabIndex = 0;
      // 
      // filesListBox
      // 
      this.filesListBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.filesListBox.FormattingEnabled = true;
      this.filesListBox.IntegralHeight = false;
      this.filesListBox.Location = new System.Drawing.Point(0, 0);
      this.filesListBox.Name = "filesListBox";
      this.filesListBox.Size = new System.Drawing.Size(250, 585);
      this.filesListBox.TabIndex = 0;
      this.filesListBox.SelectedIndexChanged += new System.EventHandler(this.filesListBox_SelectedIndexChanged);
      // 
      // aseSplitContainer
      // 
      this.aseSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
      this.aseSplitContainer.Location = new System.Drawing.Point(0, 0);
      this.aseSplitContainer.Name = "aseSplitContainer";
      this.aseSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // aseSplitContainer.Panel1
      // 
      this.aseSplitContainer.Panel1.Controls.Add(this.simpleColorGrid);
      // 
      // aseSplitContainer.Panel2
      // 
      this.aseSplitContainer.Panel2.Controls.Add(this.aseExplorerTreeView);
      this.aseSplitContainer.Size = new System.Drawing.Size(490, 585);
      this.aseSplitContainer.SplitterDistance = 290;
      this.aseSplitContainer.TabIndex = 0;
      // 
      // simpleColorGrid
      // 
      this.simpleColorGrid.Dock = System.Windows.Forms.DockStyle.Fill;
      this.simpleColorGrid.Location = new System.Drawing.Point(0, 0);
      this.simpleColorGrid.Name = "simpleColorGrid";
      this.simpleColorGrid.Size = new System.Drawing.Size(490, 290);
      this.simpleColorGrid.TabIndex = 1;
      // 
      // aseExplorerTreeView
      // 
      this.aseExplorerTreeView.Data = null;
      this.aseExplorerTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
      this.aseExplorerTreeView.ImageIndex = 0;
      this.aseExplorerTreeView.ImageList = this.imageList;
      this.aseExplorerTreeView.Location = new System.Drawing.Point(0, 0);
      this.aseExplorerTreeView.Name = "aseExplorerTreeView";
      this.aseExplorerTreeView.SelectedImageIndex = 0;
      this.aseExplorerTreeView.Size = new System.Drawing.Size(490, 291);
      this.aseExplorerTreeView.TabIndex = 0;
      // 
      // imageList
      // 
      this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
      this.imageList.TransparentColor = System.Drawing.Color.Transparent;
      this.imageList.Images.SetKeyName(0, "groups");
      this.imageList.Images.SetKeyName(1, "group");
      this.imageList.Images.SetKeyName(2, "color");
      // 
      // menuStrip
      // 
      this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
      this.menuStrip.Location = new System.Drawing.Point(0, 0);
      this.menuStrip.Name = "menuStrip";
      this.menuStrip.Size = new System.Drawing.Size(744, 24);
      this.menuStrip.TabIndex = 1;
      this.menuStrip.Text = "menuStrip1";
      // 
      // fileToolStripMenuItem
      // 
      this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
      this.fileToolStripMenuItem.Text = "&File";
      // 
      // exitToolStripMenuItem
      // 
      this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
      this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
      this.exitToolStripMenuItem.Text = "E&xit";
      this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
      // 
      // helpToolStripMenuItem
      // 
      this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
      this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
      this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
      this.helpToolStripMenuItem.Text = "&Help";
      // 
      // aboutToolStripMenuItem
      // 
      this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
      this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
      this.aboutToolStripMenuItem.Text = "&About...";
      this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(744, 609);
      this.Controls.Add(this.splitContainer);
      this.Controls.Add(this.menuStrip);
      this.MainMenuStrip = this.menuStrip;
      this.Name = "MainForm";
      this.Text = "cyotek.com Adobe Swatch Exchange Loader Demo";
      this.splitContainer.Panel1.ResumeLayout(false);
      this.splitContainer.Panel2.ResumeLayout(false);
      this.splitContainer.ResumeLayout(false);
      this.aseSplitContainer.Panel1.ResumeLayout(false);
      this.aseSplitContainer.Panel2.ResumeLayout(false);
      this.aseSplitContainer.ResumeLayout(false);
      this.menuStrip.ResumeLayout(false);
      this.menuStrip.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.SplitContainer splitContainer;
    private System.Windows.Forms.ListBox filesListBox;
    private SimpleColorGrid simpleColorGrid;
    private System.Windows.Forms.MenuStrip menuStrip;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    private System.Windows.Forms.SplitContainer aseSplitContainer;
    private AseExplorerTreeView aseExplorerTreeView;
    private System.Windows.Forms.ImageList imageList;
  }
}

