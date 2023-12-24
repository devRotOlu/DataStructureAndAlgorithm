namespace DataStructureAndAlgorithm.BinaryTree
{
    public class BinarySearchTree<T> where T : IComparable<T>
    {
        public BinaryTreeNode<T> Root { get; set; }
        public int Count { get; set; }  

        private void TraversePreOrder(BinaryTreeNode<T> root,List<BinaryTreeNode<T>> result)
        {
            if (root != null)
            {
                result.Add(root);
                TraversePreOrder(root.Left, result);
                TraversePreOrder(root.Right, result);
            }
        }

        private void TraverseInOrder(BinaryTreeNode<T> root, List<BinaryTreeNode<T>> result)
        {
            if (root != null)
            {
                TraverseInOrder(root.Left, result);
                result.Add(root);
                TraverseInOrder(root.Right, result);
            }
        }

        private void TraversePostOrder(BinaryTreeNode<T> root, List<BinaryTreeNode<T>> result)
        {
            if (root != null)
            {
                TraversePostOrder(root.Left, result);
                TraversePostOrder(root.Right, result);
                result.Add(root);
            }
        }

        public List<BinaryTreeNode<T>> Traverse(TraversalEnum mode)
        {
            List<BinaryTreeNode<T>> nodes = new List<BinaryTreeNode<T>>();

            switch (mode)
            {
                case TraversalEnum.PreOder:
                    TraversePreOrder(Root, nodes);
                    break;
                case TraversalEnum.PostOder:
                    TraversePostOrder(Root, nodes);
                    break;
                default:
                    TraverseInOrder(Root, nodes);
                    break;
            }

            return nodes;
        }

        public int GetHeight()
        {
            int height = 0;

            foreach (var node in Traverse(TraversalEnum.PreOder))
            {
                height = Math.Max(height, node.GetHeight());
            }

            return height;
        }

        public bool Contains(T data)
        {
            BinaryTreeNode<T> node = Root;

            while (node != null)
            {
                int result = data.CompareTo(node.Data);

                if (result == 0)
                {
                    return true;
                }
                else if (result < 0)
                {
                    node = node.Left;
                }
                else
                {
                    node = node.Right;
                }
            }

            return false;
        }

        public void Add(T data)
        {
            BinaryTreeNode<T> parent = GetParentForNewNode(data);
            BinaryTreeNode<T> node = new BinaryTreeNode<T> 
            {
                Data = data,
                Parent = parent,
            };

            if (parent == null)
            {
                Root = node;
            }
            else if (data.CompareTo(parent.Data) < 0)
            {
                parent.Left = node;
            }
            else
            {
               parent.Right = node;
            }

            Count++;
        }

        private BinaryTreeNode<T>? GetParentForNewNode(T data)
        {
            BinaryTreeNode<T> current = Root;
            BinaryTreeNode<T> parent = null;

            while (current != null)
            {
                parent = current;
                int result = data.CompareTo(current.Data);

                if (result == 0)
                {
                    throw new ArgumentException("Node already exist");
                }
                else if (result < 0)
                {
                    current = current.Left;
                }
                else
                {
                    current = current.Right;
                }
            }

            return parent;
        }

        public void Remove(T data)
        {
            Remove(Root, data);
        }

        private void Remove(BinaryTreeNode<T> root, T data)
        {
            if (root == null)
            {
                throw new ArgumentException($"The node {data} does not exist");
            }
            else if (data.CompareTo(root.Data) < 0)
            {
                Remove(root.Left, data);
            }
            else if (data.CompareTo(root.Data) > 0)
            {
                Remove(root.Right, data);
            }
            else
            {
                if (root.Left == null && root.Right == null)
                {
                    ReplaceInParent(root,null);
                    Count--;
                }
                else if (root.Right == null)
                {
                    ReplaceInParent(root,root.Left);
                    Count--;
                }
                else if (root.Left == null)
                {
                    ReplaceInParent(root, root.Right);
                    Count--;
                }
                else
                {
                    BinaryTreeNode<T> sucessor = FindMinInSubTree(root.Right);
                    root.Data = sucessor.Data;
                    Remove(sucessor,sucessor.Data);
                }
            }
        }

        private BinaryTreeNode<T> FindMinInSubTree(BinaryTreeNode<T> node)
        {
            while (node.Left != null)
            {
                node = node.Left;
            }

            return node;
        }

        private void ReplaceInParent(BinaryTreeNode<T> parent, BinaryTreeNode<T>? child)
        {
            if (parent.Parent != null)
            {
                if (parent.Parent.Left == parent)
                {
                    parent.Parent.Left = child;
                }
                else
                {
                    parent.Parent.Right = child;
                }
            }
            else
            {
                Root = child;
            }

            if (child != null)
            {
                child.Parent = parent.Parent;
            }
        }
    }

    public enum TraversalEnum
    {
        PreOder,
        PostOder,
        InOrder
    }
}
