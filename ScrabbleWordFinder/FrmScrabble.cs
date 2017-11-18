using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Scrabble;

namespace ScrabbleWordFinder
{
    public partial class FrmScrabble : Form
    {
        public FrmScrabble()
        {
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
            InitializeMatchByPosition();
            wordTree.Read(@"E:\Scrabble\TreeFile.txt");
        }

        private ScrabbleTree wordTree = new ScrabbleTree();

        private void txtPosition_TextChanged(object sender, EventArgs e)
        {
            var box = sender as TextBox;
            if (box.Text.Length > 0)
            {
                SendKeys.Send("{TAB}");
            }
            else
            {
                SendKeys.Send("+{TAB}");
            }
        }

        private void txtPosistion_KeyDown(object sender, KeyEventArgs e, int index)
        {
            var box = sender as TextBox;
            int newIdx;
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    btnFindWords_Position.PerformClick();
                    break;
                case Keys.Back:
                    if (box.Text.Length > 0)
                    {
                        box.Clear();
                    }
                    else 
                    {
                        newIdx = Math.Max(0, index - 1);
                        txtMatchByPosition[newIdx].Focus();
                        txtMatchByPosition[newIdx].Clear();
                    }
                    break;
                case Keys.Left:
                    newIdx = Math.Max(0, index - 1);
                    txtMatchByPosition[newIdx].Focus();
                    break;
                default:
                    break;
            }
        }

        private void txtPosistion_KeyUp(object sender, KeyEventArgs e, int index)
        {
            var box = sender as TextBox;
            if (e.KeyCode != Keys.Enter)
            {
                box.Text = Regex.Replace(box.Text, @"[^A-Z]", "");
                if (box.Text.Length > 0 || e.KeyCode == Keys.Right || e.KeyCode == Keys.Space)
                {
                    if (e.KeyCode != Keys.Left)
                    {
                        txtMatchByPosition[Math.Min(11, index + 1)].Focus();
                    }
                }
            }
        }

        private void btnFindWords_Rack_Click(object sender, EventArgs e)
        {
            var words = wordTree.FindWordTree(txtRack.Text.ToCharArray()).ToWordList();
            PrintWords(words);
            return;
        }


        private void PrintWords(List<string> words)
        {
            words = words.Where(o => o.Length > 1).Distinct().OrderByDescending(o => o.Length).ThenBy(o=> o).ToList();
            rtbGeneratedWords.Clear();
            rtbGeneratedWords.SelectionTabs = GenerateTabLocations(ref words, rtbGeneratedWords.CreateGraphics());
            for (int i = 0; i < words.Count; i++)
            {
                rtbGeneratedWords.AppendText(words[i] + ((i + 1) % rtbGeneratedWords.SelectionTabs.Count() == 0 ? '\n' : '\t'));
            }

        }


        private int[] GenerateTabLocations(ref List<string> words, Graphics g)
        {
            if (words.Count == 0)
            {
                return new int[0];
            }
            List<int> tabLocations = new List<int>();
            int idx = 1, x = (int)g.MeasureString(words[0], rtbGeneratedWords.Font).Width;

            while (x < rtbGeneratedWords.Width && idx < words.Count)
            {
                tabLocations.Add(x += 20);
                x += (int)g.MeasureString(words[idx], rtbGeneratedWords.Font).Width;
                idx++;
            }
            return tabLocations.ToArray();
        }
    }




    public static class RichTextBoxExtensions
    {
        public static void AppendText(this RichTextBox box, string text, Color color)
        {
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;

            box.SelectionColor = color;
            box.AppendText(text);
            box.SelectionColor = box.ForeColor;
        }
    }
}
