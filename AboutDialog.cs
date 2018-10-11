﻿using System;
using System.Diagnostics;
using System.Windows.Forms;

// Reading Adobe Swatch Exchange (ase) files using C#
// http://www.cyotek.com/blog/reading-adobe-swatch-exchange-ase-files-using-csharp

namespace AdobeSwatchExchangeLoader
{
  internal sealed partial class AboutDialog : Form
  {
    #region Constructors

    public AboutDialog()
    {
      this.InitializeComponent();
    }

    #endregion

    #region Methods

    protected override void OnLoad(EventArgs e)
    {
      FileVersionInfo versionInfo;

      versionInfo = FileVersionInfo.GetVersionInfo(typeof(MainForm).Assembly.Location);
      nameLabel.Text = versionInfo.ProductName;
      copyrightLabel.Text = versionInfo.LegalCopyright;

      base.OnLoad(e);
    }

    private void closeButton_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void webLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      try
      {
        Process.Start("http://www.cyotek.com");
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.GetBaseException().
                           Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    #endregion
  }
}
