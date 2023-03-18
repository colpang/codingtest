using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace siftup
{
    class program4
    {
        class TreeNode<T>
        {
            public T data { get; set; }
            public List<TreeNode<T>> children { get; set; } = new List<TreeNode<T>>();
        }
        public int solution(string s1, string s2)
        {
            int answer = 0;
            //이진트리 그래프를 만든다
            

            return answer;
        }
        static int index;
        static void Main(string[] args)
        {
            TreeNode<char> tree= makeTree("ppwwwbpbbwwbw");

            //mergeTree(tree);
        }
        static TreeNode<char> makeTree(string s)
        {
            index = 0;
            char[] arr = s.ToCharArray();
            TreeNode<char> result = makeChildNode(index, arr);
            return result;
        }
        static void mergeTree(TreeNode<char> root)
        {
            // 현재 노드의 데이터 접근
            Console.WriteLine(root.data);

            // 재귀적으로 자식들의 데이터 접근
            foreach (TreeNode<char> child in root.children)
                mergeTree(child);
        }

        static TreeNode<char> makeChildNode(int index, char[] arr)
        {
            Console.WriteLine(index);
            TreeNode<char> node = new TreeNode<char>();
            if (arr[index] == 'b')
            {
                node.data = 'b';
            }
            else if (arr[index] == 'w')
            {
                node.data = 'w';
            }
            else
            {

                node.data = 'p';
                index++;
                for (int i = 0; i < 4; i++)
                    node.children.Add(makeChildNode(index++,arr));
            }
            return node;
        }
    }
}
