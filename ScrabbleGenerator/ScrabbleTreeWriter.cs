using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrabble
{
    public partial class ScrabbleTree
    {
        private System.IO.StreamWriter writer;

        public void Write(string outfile)
        {
            writer = new System.IO.StreamWriter(outfile, false);
            writer.Write(root.ToString());
            writer.Close();
        }

        public List<string> ToWordList()
        {
            return BuildWordList(root).Select(o => new string(o.ToString().Reverse().ToArray())).ToList();
        }

        private List<StringBuilder> BuildWordList(ScrabbleTreeNode node)
        {
            List<StringBuilder> wordList = new List<StringBuilder>();
            if (node == (char)sChar.EOW)
            {
                wordList.Add(new StringBuilder());
            }
            foreach (ScrabbleTreeNode child in node.children)
            {
                wordList.AddRange(BuildWordList(child).Select(o => node == (char)sChar.root ? o : o.Append(node.value)));
            }
            return wordList;
        }
    }
}
