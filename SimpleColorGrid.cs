using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

// Reading Adobe Swatch Exchange (ase) files using C#
// http://www.cyotek.com/blog/reading-adobe-swatch-exchange-ase-files-using-csharp

namespace AdobeSwatchExchangeLoader
{
  internal class SimpleColorGrid : Control
  {
    #region Fields

    private Size _cellSize;

    private Color[] _colors;

    private int _columns;

    private int _rows;

    #endregion

    #region Constructors

    public SimpleColorGrid()
    {
      this.DoubleBuffered = true;
      this.SetStyle(ControlStyles.Selectable | ControlStyles.StandardClick | ControlStyles.StandardDoubleClick, false);
      this.Colors = new Color[0];
    }

    #endregion

    #region Properties

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public virtual Color[] Colors
    {
      get { return _colors; }
      set
      {
        _colors = value ?? new Color[0];

        this.DefineCellSize();
        this.Invalidate();
      }
    }

    #endregion

    #region Methods

    /// <summary>
    /// Raises the <see cref="E:System.Windows.Forms.Control.Paint"/> event.
    /// </summary>
    /// <param name="e">A <see cref="T:System.Windows.Forms.PaintEventArgs"/> that contains the event data. </param>
    protected override void OnPaint(PaintEventArgs e)
    {
      int count;
      int cw;
      int ch;

      base.OnPaint(e);

      count = _colors.Length;
      cw = _cellSize.Width;
      ch = _cellSize.Height;

      e.Graphics.Clear(this.BackColor);

      for (int row = 0; row < _rows; row++)
      {
        for (int column = 0; column < _columns; column++)
        {
          int index;

          index = row * _columns + column;

          if (index < count)
          {
            int x;
            int y;
            Rectangle bounds;

            x = column * cw;
            y = row * ch;
            bounds = new Rectangle(x, y, cw, ch);

            using (Brush brush = new SolidBrush(_colors[index]))
            {
              e.Graphics.FillRectangle(brush, bounds);
            }

            e.Graphics.DrawRectangle(Pens.Black, bounds);
          }
        }
      }
    }

    /// <summary>
    /// Raises the <see cref="E:System.Windows.Forms.Control.Resize"/> event.
    /// </summary>
    /// <param name="e">An <see cref="T:System.EventArgs"/> that contains the event data. </param>
    protected override void OnResize(EventArgs e)
    {
      base.OnResize(e);

      this.DefineCellSize();
      this.Invalidate();
    }

    private void DefineCellSize()
    {
      int count;

      count = _colors.Length;

      if (count > 0)
      {
        Size size;
        int w;
        int h;

        size = this.ClientSize;
        _columns = Convert.ToInt32(Math.Sqrt(_colors.Length));
        _rows = _columns;

        if (_columns * _columns < count)
        {
          _columns++;
        }

        w = size.Width / _columns;
        h = size.Height / _rows;

        _cellSize = new Size(w, h);
      }
    }

    #endregion
  }
}
