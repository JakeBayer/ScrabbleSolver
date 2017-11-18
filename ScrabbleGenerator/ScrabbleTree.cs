using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrabble
{
    public partial class ScrabbleTree
    {
        public ScrabbleTree()
        {
            root = new ScrabbleTreeNode((char)sChar.root);
        }

        public ScrabbleTreeNode root;

        public ScrabbleTreeNode FindWordTreeWithPosition(char[] letters, char[] positionInfo)
        {

            return new ScrabbleTreeNode();
        }

        #region FindWordTree(char[] letters)
        public ScrabbleTree FindWordTree(char[] letters)
        {
            ScrabbleTree wordTree = new ScrabbleTree() { root = new ScrabbleTreeNode(root.value) { children = FindWordTreeChildren(root, new List<char>(letters)) } };
            return wordTree;
        }

        private List<ScrabbleTreeNode> FindWordTreeChildren(ScrabbleTreeNode node, List<char> remainingLetters)
        {
            List<ScrabbleTreeNode> children = new List<ScrabbleTreeNode>();
            if (node.children.Any(o => o == (char)sChar.EOW))
            {
                children.Add(new ScrabbleTreeNode((char)sChar.EOW));
            }
            foreach (char letter in remainingLetters)
            {
                if (node.children.Any(o => o == letter))
                {
                    var remaining = new List<char>(remainingLetters);
                    remaining.Remove(letter);
                    List<ScrabbleTreeNode> leaves = new List<ScrabbleTreeNode>();
                    foreach (ScrabbleTreeNode matchingChild in node.children.Where(o => o == letter))
                    {
                        leaves = FindWordTreeChildren(matchingChild, remaining);
                        if (leaves.Count() > 0)
                        {
                            children.Add(new ScrabbleTreeNode(matchingChild.value) { children = leaves, state = new ScrabbleTreeNode.State() { fromWildCard = (letter == (char)sChar.wildCard) } });
                        }
                    }
                }
            }
            return children;
        }
        #endregion

        #region COUNT()
        public int Count()
        {
            return countChildren(root);
        }

        private int countChildren(ScrabbleTreeNode node)
        {
            int count = 1;
            foreach (ScrabbleTreeNode child in node.children)
            {
                count += countChildren(child);
            }
            return count;
        }
        #endregion
    }



}
