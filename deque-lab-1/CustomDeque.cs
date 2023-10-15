using CustomCollection;
using System.Collections;
using System.Collections.Generic;


namespace CustomCollection
{

    public class DoublyNode<T> 
    {
        public DoublyNode(T data)
        {
            Data = data;
        }
        public T Data { get; set; }
        public DoublyNode<T> Previous { get; set; }
        public DoublyNode<T> Next { get; set; }
    }

    internal class CustomDeque<T>
    {

        DoublyNode<T> head; 
        DoublyNode<T> tail; 
        int count;  // количество элементов в списке

        public CustomDeque()
        {
        }

       
        public void AddFirst(T data)
        {
            DoublyNode<T> node = new DoublyNode<T>(data);
            DoublyNode<T> temp = head;
            node.Next = temp;
            head = node;
            if (count == 0)
                tail = head;
            else
                temp.Previous = node;
            count++;
        }
      

        public int Count { get { return count; } }
   

    }

   

}
