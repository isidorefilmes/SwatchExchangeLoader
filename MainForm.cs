using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

// Reading Adobe Swatch Exchange (ase) files using C#
// http://www.cyotek.com/blog/reading-adobe-swatch-exchange-ase-files-using-csharp

// Sample palettes used in this example program from:
// http://www.sherwin-williams.com/architects-specifiers-designers/color/color-tools/downloadable-color-palettes/
// http://www.colourlovers.com/palette/3899568/Blue_Lace
// http://www.colourlovers.com/palette/92095/Giant_Goldfish

namespace AdobeSwatchExchangeLoader
{
  internal sealed partial class MainForm : Form
  {
    #region Fields

    private SwatchExchangeData _paletteData;

    #endregion

    #region Constructors

    public MainForm()
    {
      this.InitializeComponent();
    }

    #endregion

    #region Methods

    /// <summary>
    /// Raises the <see cref="E:System.Windows.Forms.Form.Load"/> event.
    /// </summary>
    /// <param name="e">An <see cref="T:System.EventArgs"/> that contains the event data. </param>
    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);

      this.AddFiles("ase");
    }

    private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
    {
      using (Form dialog = new AboutDialog())
      {
        dialog.ShowDialog(this);
      }
    }

    private void AddFiles(string extension)
    {
      string path;

      path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data");
      foreach (string fileName in Directory.GetFiles(path, "*." + extension))
      {
        filesListBox.Items.Add(new FileInfo(fileName));
      }
    }

    private void DefinePreviewColors()
    {
      List<Color> colors;

      colors = new List<Color>();

      if (_paletteData != null)
      {
        if (_paletteData.Groups != null)
        {
          colors.AddRange(_paletteData.Groups.Where(group => group.Colors != null).
                                       SelectMany(group => group.Colors).
                                       Select(colorEntry => colorEntry.ToColor()));
        }

        if (_paletteData.Colors != null)
        {
          colors.AddRange(_paletteData.Colors.Select(colorEntry => colorEntry.ToColor()));
        }
      }

      simpleColorGrid.Colors = colors.ToArray();
    }

    private void exitToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void filesListBox_SelectedIndexChanged(object sender, EventArgs e)
    {
      FileInfo selectedFile;

      selectedFile = filesListBox.SelectedItem as FileInfo;

      _paletteData = null;
      this.Text = Application.ProductName;

      if (selectedFile != null)
      {
        _paletteData = new SwatchExchangeData();

        try
        {
          _paletteData.Load(selectedFile.FullPath);
          this.Text = $"{Path.GetFileName(selectedFile.FullPath)} - {Application.ProductName}";
        }
        catch (Exception ex)
        {
          MessageBox.Show(ex.GetBaseException().
                             Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
      }

      simpleColorGrid.Invalidate();
      aseExplorerTreeView.Data = _paletteData;
      this.DefinePreviewColors();
    }

    #endregion
  }
}
