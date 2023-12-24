using DataStructureAndAlgorithm.Trees;

namespace DataStructureAndAlgorithm.BinaryTree
{
    public class BinaryTreeNode<T> : Node<T>
    {
        public new BinaryTreeNode<T>? Parent { get; set; } = null;

        public BinaryTreeNode<T> Left
        {
            get => (BinaryTreeNode<T>)Children[0];
            set => Children[0] = value; 
        }

        public BinaryTreeNode<T> Right
        {
            get => (BinaryTreeNode<T>)Children[1];
            set => Children[1] = value;
        }

        public BinaryTreeNode()
        {
            Children = new List<Node<T>> {null,null};
        }
    }
}
