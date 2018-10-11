using System.Windows.Forms;

// Reading Adobe Swatch Exchange (ase) files using C#
// http://www.cyotek.com/blog/reading-adobe-swatch-exchange-ase-files-using-csharp

namespace AdobeSwatchExchangeLoader
{
  internal class AseExplorerTreeView : TreeView
  {
    #region Fields

    private SwatchExchangeData _data;

    #endregion

    #region Properties

    public SwatchExchangeData Data
    {
      get { return _data; }
      set
      {
        _data = value;

        this.Reload();
      }
    }

    #endregion

    #region Methods

    private void LoadColors(ColorEntryCollection colors, TreeNode root)
    {
      foreach (ColorEntry color in colors)
      {
        TreeNode node;

        node = new TreeNode
               {
                 Text = $"{color.Name} [RGB({color.R}, {color.G}, {color.B}) {color.Type}]",
                 ImageKey = "color",
                 SelectedImageKey = "color"
               };

        root.Nodes.Add(node);
      }
    }

    private void LoadGlobalColors()
    {
      if (_data.Colors != null && _data.Colors.Count != 0)
      {
        TreeNode root;

        root = new TreeNode
               {
                 Name = "colors",
                 Text = "Colors",
                 ImageKey = "group",
                 SelectedImageKey = "group"
               };

        this.LoadColors(_data.Colors, root);

        this.Nodes.Add(root);
        root.Expand();
      }
    }

    private void LoadGroup(ColorGroup group, TreeNode root)
    {
      TreeNode groupNode;

      groupNode = new TreeNode
                  {
                    Text = group.Name,
                    ImageKey = "group",
                    SelectedImageKey = "group"
                  };

      this.LoadColors(group.Colors, groupNode);

      root.Nodes.Add(groupNode);
    }

    private void LoadGroups()
    {
      if (_data.Groups != null && _data.Groups.Count != 0)
      {
        TreeNode root;

        root = new TreeNode
               {
                 Name = "groups",
                 Text = "Groups",
                 ImageKey = "groups",
                 SelectedImageKey = "groups"
               };

        foreach (ColorGroup group in _data.Groups)
        {
          this.LoadGroup(group, root);
        }

        if (root.Nodes.Count != 0)
        {
          root.Nodes[0].Expand();
        }

        this.Nodes.Add(root);
        root.Expand();
      }
    }

    private void Reload()
    {
      this.BeginUpdate();

      this.Nodes.Clear();

      if (_data != null)
      {
        this.LoadGroups();
        this.LoadGlobalColors();
      }

      this.EndUpdate();
    }

    #endregion
  }
}
