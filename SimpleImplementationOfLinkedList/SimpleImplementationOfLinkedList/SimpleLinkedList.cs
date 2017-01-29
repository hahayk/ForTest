namespace SimpleImplementationOfLinkedList
{
    class SimpleLinkedList
    {
        Node mainNode;

        //Add new item from the begining
        public void AddFirst(object data)
        {
            Node added = new Node();
            added.data = data;
            added.next = mainNode;

            //make current node added one
            mainNode = added;        
        }

        public void AddLast(object data)
        {
            if (mainNode == null)
            {
                mainNode = new Node();
                mainNode.data = data;
                mainNode.next = null;
            }
            else
            {
                Node added = new Node();
                added.data = data;

                Node currentNode = mainNode;
                while (currentNode.next != null)
                {
                    currentNode = currentNode.next;
                }

                currentNode.next = added;
            }
        }

        public override string ToString()
        {
            Node cur = mainNode;
            string toPrint = string.Empty;

            while (cur != null)
            {

                toPrint += cur.data + ", ";
                cur = cur.next;
            }

            return toPrint; 
        }

    }


}
