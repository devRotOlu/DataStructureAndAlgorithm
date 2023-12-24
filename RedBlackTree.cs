namespace DataStructureAndAlgorithm
{
    public class RBTree
    {
        public RBTNode root;
        bool ll = false;
        bool rr = false;
        bool lr = false;
        bool rl = false;

        public RBTNode RotateLeft(RBTNode node)
        {
            RBTNode x = node.right;
            RBTNode y = x.left;
            node.right = y;
            node.parent = x;

            if (y != null)
                y.left = node;
            return x;
        }

        public RBTNode RotateRight(RBTNode node)
        {
            RBTNode x = node.left;
            RBTNode y = x.right;
            x.right = node;
            node.left = y;
            node.parent= x;

            if (y != null)
                y.parent = node;

            return x;
        }

        // Public method to insert data into the tree
        public void Insert(int data)
        {
            if (root == null)
            {
                root = new RBTNode(data);
                root.colour = 'B';
            }
            else
            {
                root = InsertHelp(root, data);
            }
        }

        private RBTNode InsertHelp(RBTNode root,int data)
        {
            bool f = false;

            if (root == null) 
            {
                return new RBTNode(data);
            }
            else if(data < root.data)
            {
                root.left = InsertHelp(root.left, data);
                root.left.parent = root;
                if (root != this.root)
                    if (root.colour == 'R' && root.left.colour == 'R') f = true;
            }
            else
            {
                root.right = InsertHelp(root.right, data);
                root.right.parent = root;
                if(root != this.root)
                    if(root.colour == 'R' && root.right.colour == 'R')
                        f = true;
            }

            // Rotate and recolor based on flags

            if (ll)
            {
                root = RotateLeft(root);
                root.colour = 'B';
                root.left.colour = 'R';
                ll = false;
            }
            else if (rr)
            {
                root = RotateRight(root);
                root.colour = 'B';
                root.right.colour = 'R';
                rr = false;
            }
            else if (rl)
            {
                root.right = RotateRight(root.right);
                root.right.parent = root;
                root = RotateLeft(root);
                root.colour = 'B';
                root.left.colour = 'R';
                rl = false;
            }
            else if (lr)
            {
                root.left =RotateLeft(root.left);
                root.left.parent = root;
                root = RotateRight(root);
                root.colour = 'B';
                root.right.colour = 'R';
                lr = false;
            }

            // Handle RED-RED Conflict
            if (f)
            {
                if (root.parent.right == root)
                {
                    if (root.parent.left == null || root.parent.left.colour == 'B')
                    {
                        if (root.left != null && root.left.colour == 'R')
                            rl = true;
                        else if(root.right != null && root.right.colour == 'R')
                            ll = true;
                    }
                    else
                    {
                        root.parent.left.colour = 'B';
                        root.colour = 'B';
                        if (root.parent != this.root)
                            root.parent.colour = 'R';
                    }
                }
                else
                {
                    if (root.parent.right == null || root.parent.right.colour == 'B')
                    {
                        if (root.left != null && root.left.colour == 'R')
                            rr = true;
                        else if(root.right != null && root.right.colour == 'R')
                            lr = true;
                    }
                    else
                    {
                        root.parent.right.colour = 'B';
                        root.colour = 'B';
                        if (root.parent != this.root)
                            root.parent.colour = 'R';
                    }
                }
                f = false;
            }
            return root;
        }

    }

    public class RBTNode
    {
        public int data;
        public RBTNode left;
        public RBTNode right;
        public char colour;
        public RBTNode parent;
        public RBTNode(int data)
        {
            this.data = data;
            left = null;
            right = null;
            colour = 'R';
            parent = null;
        }
    }
}
