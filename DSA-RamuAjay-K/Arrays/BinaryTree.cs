namespace DSA_RamuAjay_K.Arrays
{
    internal class BinaryTree
    {
        public BinaryTree()
        {

        }

       
    }


    public class Node
    {
        public string data ;
        public Node? leftNode;
        public Node? rightNode;
        public void GetAllValuesInTheNodesQueue(Node rootNode, List<string> values)
        {
            
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(rootNode);

            while (queue.Count > 0)
            {
                Node currentNode = queue.Dequeue();
                values.Add(currentNode.data);

                if (currentNode.leftNode != null)
                    queue.Enqueue(currentNode.leftNode);

                if (currentNode.rightNode != null)
                    queue.Enqueue(currentNode.rightNode);
            }
        }

        public List<string> Get()
        {
           Node? rootNode =  this.BuildSampleTree();
           
            List<string> values = new List<string>();

            GetAllValuesInTheNodesQueue(rootNode, values);

            return values;


        }

        public Node()
        {

        }
        public Node(string data, Node? leftNode = null, Node? rightNode = null)
        {
            this.data = data;
            this.leftNode = leftNode;
            this.rightNode = rightNode;
        }

        public Node BuildSampleTree()
        {

            Node A = new Node("A");

            Node B = new Node("B");


            Node C = new Node("C");

            A.leftNode = B;
            A.rightNode = C;

            Node D = new Node("D");


            Node E = new Node("E");


            B.leftNode = D;
            B.rightNode = E;

            Node F = new Node("F");


            Node G = new Node("G");

            C.leftNode = F;
            C.rightNode = G;
            return A;

        }
    }

}
