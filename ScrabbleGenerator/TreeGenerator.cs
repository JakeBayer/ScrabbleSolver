using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Scrabble
{
    public class TreeGenerator
    {
        public TreeGenerator()
        { }

        public TreeGenerator(string _filePath)
        {
            _wordListFilePath = _filePath;
        }
        private const string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private string _wordListFilePath;
        private System.IO.StreamReader reader;

        private void LoadFile()
        {
            try
            {
                if (_wordListFilePath == string.Empty)
                    throw new Exception("You must specify a file path");
                reader = new StreamReader(_wordListFilePath);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private IEnumerable<string> GenerateWordList()
        {
            return reader.ReadToEnd().ToUpper().Split(new char[] { ',' });
        }

        public void CreateTreeFile(string outfile)
        {
            LoadFile();
            var _tree = GenerateTreeFromWordList(GenerateWordList());

            _tree.Write(outfile);
        }

        private ScrabbleTree GenerateTreeFromWordList(IEnumerable<string> wordList)
        {
            SortedSet<string> sorted = new SortedSet<string>(wordList);
            var _tree = new ScrabbleTree();
            _tree.root.children = GenerateChildren(sorted, 0);


            return _tree;
        }

        private IList<ScrabbleTreeNode> GenerateChildren(SortedSet<string> wordsAlongPath, int depth)
        {
            List<ScrabbleTreeNode> nodes = new List<ScrabbleTreeNode>();
            while (wordsAlongPath.Count > 0)
            {
                if (wordsAlongPath.First().Length == depth)
                {
                    nodes.Add(new ScrabbleTreeNode('#'));
                    wordsAlongPath.Remove(wordsAlongPath.First());
                }
                if (wordsAlongPath.Count > 0)
                {
                    char newPathChar = wordsAlongPath.First()[depth];
                    var newNode = new ScrabbleTreeNode(newPathChar);
                    var nextpath = new SortedSet<string>(wordsAlongPath.Where(o => o[depth] == newPathChar));
                    wordsAlongPath.RemoveWhere(o => nextpath.Contains(o));
                    newNode.children = GenerateChildren(nextpath, depth + 1);
                    nodes.Add(newNode);
                    
                }
            }
            
            return nodes;
        }
    }
}
