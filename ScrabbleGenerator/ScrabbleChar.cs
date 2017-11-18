using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrabble
{
    public class ScrabbleChar : IComparable<char>, IEquatable<char>
    {
        public ScrabbleChar(char _v)
        {
            value = _v;
        }

        public char value { get; set; }


        public char EOW = '#';
        public char Root = '$';
        public char WildCard = '*';

        int IComparable<char>.CompareTo(char other)
        {
            return value.CompareTo(other);
        }

        bool IEquatable<char>.Equals(char other)
        {
           return value.Equals(other);
        }

        public bool IsEOW { get { return value == EOW; } }
        public bool IsRoot { get { return value == Root; } }
        public bool IsWildCard { get { return value == WildCard; } }

    }
}
