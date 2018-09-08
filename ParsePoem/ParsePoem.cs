using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ParsePoem
{
    public partial class ParsePoem : Form
    {

        private bool _hasMultipleStanzas = false;

        public ParsePoem()
        {
            InitializeComponent();
            btnCopyToClipboard.Enabled = true;
        }

        private void btnPoemToHTML_Click(object sender, EventArgs e)
        {
            string finalPoemText = string.Empty;

            string strTitle = txtPoemBody.Lines[0];
            txtPoemTitle.Text = "<span>" + System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(strTitle.ToLower() + "</span>");
            
            List<string> poemText = txtPoemBody.Text.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None).ToList();

            StringBuilder sb = new StringBuilder();

            if (_hasMultipleStanzas)
            {
                finalPoemText = getParsePoem(poemText);
                finalPoemText = finalPoemText.Insert(0, "<p>\r\n");
                finalPoemText = finalPoemText.Replace("<br />\r\n<br />", "\r\n</p>\r\n<p>");
                finalPoemText = finalPoemText + "\r\n</p>";
            }
            else if (_hasMultipleStanzas == false)
            {
                finalPoemText = getParsePoem(poemText);
            }

            txtPoemBody.Text = finalPoemText;

            btnCopyToClipboard.Enabled = true;

        }

        private void btnCopyToClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(txtPoemTitle.Text + System.Environment.NewLine + txtPoemBody.Text);
        }

        private void btnMultipleStanzas_Click(object sender, EventArgs e)
        {

            if (_hasMultipleStanzas == false)
            {
                _hasMultipleStanzas = true;
                btnMultipleStanzas.Text = "Block";
            }
            else
            {
                _hasMultipleStanzas = false;
                btnMultipleStanzas.Text = "Multiple Stanzas";
            }
        }

        private string getParsePoem(List<string> poemText)
        {
            StringBuilder sb = new StringBuilder();

            foreach (string line in poemText)
            {
                string _replaced = line.Replace("  ", "&nbsp;&nbsp;");
                string whiteSpaceLine = _replaced.Replace("&nbsp; ", "&nbsp;&nbsp;");
                sb.Append(whiteSpaceLine + "<br />" + System.Environment.NewLine);
            }

            return sb.ToString().Replace('\u2018', '\'').Replace('\u2019', '\'').Replace('\u201c', '\"').Replace('\u201d', '\"');
        }


    }
}
