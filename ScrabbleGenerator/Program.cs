using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrabble
{
    class Program
    {
        static void Main(string[] args)
        {
            mainHelp m = new mainHelp();
            m.helpOut();
            
        }
    }

    public class mainHelp
    {
        public void helpOut()
        {
            //var generator = new TreeGenerator(@"E:\Scrabble\Word List.txt");
            //var generator = new TreeGenerator(@"E:\Scrabble\TestList.txt");
            //generator.CreateTreeFile(@"E:\Scrabble\TreeFileTest.txt");

            var a = new ScrabbleTreeNode('A');
            var b = new ScrabbleTreeNode('B');

            Console.WriteLine(a == b);


            var tree = new ScrabbleTree();
            //tree.Read(@"E:\Scrabble\TreeFileTest.txt");
            tree.Read(@"E:\Scrabble\TreeFile.txt");

            var wordTree = tree.FindWordTree(new char[] { 'P', 'E', 'E', 'K' });
            var wordList = wordTree.ToWordList();

            foreach (var word in wordList)
            {
                Console.WriteLine(word);
            }
        }
    }
}
