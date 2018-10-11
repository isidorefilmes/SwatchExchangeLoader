using System.Drawing;

// Reading Adobe Swatch Exchange (ase) files using C#
// http://www.cyotek.com/blog/reading-adobe-swatch-exchange-ase-files-using-csharp

namespace AdobeSwatchExchangeLoader
{
  internal class ColorEntry : Block
  {
    #region Properties

    public int B { get; set; }

    public int G { get; set; }

    public int R { get; set; }

    public ColorType Type { get; set; }

    #endregion

    #region Methods

    public Color ToColor()
    {
      return Color.FromArgb(this.R, this.G, this.B);
    }

    #endregion
  }
}
