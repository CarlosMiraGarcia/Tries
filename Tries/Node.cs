namespace Tries {
    public class Node {
        private int Size { get; set; } = 0;
        private static int NumberOfCharacters = 26;
        Node[] Children = new Node[NumberOfCharacters];
        private int GetCharIndex(char c) {
            return c - 97;
        }
        private Node GetNode (char c) {
            return Children[GetCharIndex(c)];
        }
        private void SetNode(char c, Node node) {
            Children[GetCharIndex(c)] = node;
        }
        public void Add(string s) {
            s = s.ToLower();
            Add(s, 0);
        }
        private void Add(string s, int index) {
            Size++;
            if (index == s.Length) {
                return;
            }
            char current = s[index];
            Node child = GetNode(current);
            if (child == null) {
                child = new Node();
                SetNode(current, child);
            }
            child.Add(s, index + 1);
        }
        public int FindCount(string s, int index) {
            s = s.ToLower();
            if (index == s.Length) {
                return Size;
            }

            Node child = GetNode(s[index]);
            if (child == null) {
                return 0;
            }

            return child.FindCount(s, index + 1);            
        }
    }
}
