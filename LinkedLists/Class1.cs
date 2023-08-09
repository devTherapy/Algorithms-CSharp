namespace LinkedLists

public class LinkedList {
    public int value;
    public LinkedList next;

    public LinkedList(int value) {
      this.value = value;
      this.next = null;
    }
  }

  public LinkedList RemoveDuplicatesFromLinkedList(LinkedList linkedList) {
    // Write your code here.
    var current = linkedList;
    while (current.next is not null)
    {
        if (current.value == current.next.value)
        {
            current.next = current.next.next
        }
        else
        {
            current = current.next
        }
    }
    return linkedList;
  }

  
