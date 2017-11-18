using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Scrabble
{
    public partial class ScrabbleTree
    {
        private System.IO.StreamReader reader;

        public void Read(string infile)
        {
            try
            {
                reader = new System.IO.StreamReader(infile);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Parse(reader.ReadToEnd());

        }

        private void Parse(string treeString)
        {
            StringReader reader = new StringReader(treeString);  
            root = GetChildren(reader).First();
        }

        private List<ScrabbleTreeNode> GetChildren(StringReader reader)
        {
            var nodes = new List<ScrabbleTreeNode>();
            var val = reader.Read();
            while (val > 0)
            {
                if (val == '{')
                {
                    nodes.Last().children = GetChildren(reader);
                }
                else if (val == '}')
                {
                    return nodes;
                }
                else
                {
                    nodes.Add(new ScrabbleTreeNode((char)val));
                }
                val = reader.Read();
            }
            return nodes;
        }
    }
}
