public class MyLinkedList {
      private Node head;
      private Node tail;
      private int size;

    public MyLinkedList() {
      this.size = 0;
    }
    
    public int Get(int index) {
        if (index < 0 || index >= size) return -1; 
        var current = head;
        for(int i = 0 ;i < index;i++)
            current = current.next;
        return current.val;
    }
    
    public void AddAtHead(int val) {
        Node node = new Node(val,null);
        node.next = head;
        head = node;
        if(tail == null)
            tail = head;
        size+=1;
    }
    
    public void AddAtTail(int val) {
        if(tail==null)
            AddAtHead(val);
        else{
        var node = new Node(val);
        tail.next = node;
        tail = node;
        size++;
        }
    }
    
    public void AddAtIndex(int index, int val) {
        if (index < 0 || index > size) return;
        if(index == 0){
            AddAtHead(val);
            return;
        }
        if(index == size)
        {
            AddAtTail(val);
            return;
        }
        var current = head;
        for(int i = 1; i < index;i++)
            current = current.next;
        Node node = new Node(val,current.next);
        current.next = node;
        size++;
    }
    
    public void DeleteAtIndex(int index) {
        if (index < 0 || index >= size) return;
        if(index == 0)
        {
            head = head.next;
            size--;
            if(size==0)
                tail = null;
            return;
        }
        var current = head;
        for(int i = 0; i < index-1;i++){
            current = current.next;
        } 
        current.next = current.next.next;
        if(index==size-1)
            tail = current;
        size--;
        }


    private class Node{
        public int val;
        public Node next;
        public Node(int value)
        {
            this.val = value;
        }
        public Node(int value,Node next)
        {
            this.val = value;
            this.next = next;
        }
    }

}

/**
 * Your MyLinkedList object will be instantiated and called as such:
 * MyLinkedList obj = new MyLinkedList();
 * int param_1 = obj.Get(index);
 * obj.AddAtHead(val);
 * obj.AddAtTail(val);
 * obj.AddAtIndex(index,val);
 * obj.DeleteAtIndex(index);
 */