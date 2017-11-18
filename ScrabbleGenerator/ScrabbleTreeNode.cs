using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Scrabble
{
    [DebuggerDisplay("{ToString()}")]
    public class ScrabbleTreeNode
    {
        public ScrabbleTreeNode()
        { }

        public ScrabbleTreeNode(char _v)
        {
            value = _v;
        }

        public State state;
        public char value;
        public IList<ScrabbleTreeNode> children = new List<ScrabbleTreeNode>();
        public ScrabbleTreeNode parent;

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(value.ToString());
            if (children.Count > 0)
            {
                sb.Append("{");
                foreach (var child in children)
                {
                    sb.Append(child.ToString());
                }
                sb.Append("}");
            }
            return sb.ToString();
        }

        public class State
        {
            public bool fromWildCard = false;
        }


        #region Operator Overloading
        public static bool operator ==(ScrabbleTreeNode a, char b)
        {
            return (a.value == (char)sChar.wildCard || b == (char)sChar.wildCard || a.value == b);
        }

        public static bool operator !=(ScrabbleTreeNode a, char b)
        {
            return (a.value != (char)sChar.wildCard && b != (char)sChar.wildCard && a.value != b);
        }

        public static bool operator ==(ScrabbleTreeNode a, ScrabbleTreeNode b)
        {
            return (a == b.value);
        }

        public static bool operator !=(ScrabbleTreeNode a, ScrabbleTreeNode b)
        {
            return (a != b.value);
        }

        public override bool Equals(object obj)
        {
            var b = obj as ScrabbleTreeNode;
            if (b != null)
            {
                return b == value;
            }
            var c = obj as char?;
            if (c != null)
            {
                return c == value;
            }
            return false;
        }
        #endregion
    }

    public enum sChar
    {
        EOW = '#',
        root = '$',
        wildCard = '*',
    };
}
