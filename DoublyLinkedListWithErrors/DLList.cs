using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedListWithErrors
{
    public class DLList
    {
        public DLLNode head; // pointer to the head of the list
        public DLLNode tail; // pointer to the tail of the list
        public DLList() { head = null; tail = null; } // constructor

        public void addToHead(DLLNode p)
        {
            if (head == null)
            {
                head = p;
                tail = p;
                return;
            }
            p.next = head;
            head.previous = p;
            head = p;
            return;
        }

        public void addToTail(DLLNode p)
        {
            if (tail == null)
            {
                tail = p;
                head = p;
                return;
            }
            tail.next = p;
            p.previous = tail;
            tail = p;
            return;
        }

        public DLLNode removeHead()
        {
            DLLNode p = head;
            if (p == null)
            {
                return null;
            }
            if (p.next == null)
            {
                head = null;
                tail = null;
                return p;
            }
            head = head.next;
            head.previous = null;
            p.next = null;
            return p;
        }

        public DLLNode removeTail()
        {
            DLLNode p = tail;

            if (p == null)
            {
                return null;
            }
            if (p.previous == null)
            {
                head = null;
                tail = null;
                return p;
            }
            tail = tail.previous;
            tail.next = null;
            p.previous = null;
            return p;
        }

        public bool newSearch(int num)
        {
            DLLNode temp = head;
            while (temp != null)
            {
                if (temp.num == num)
                {
                    return true;
                }
                temp = temp.next;
            }
            return false;
        }

        public void removeNode(DLLNode p)
        {
            if (p == null)
                return;
            bool isInList = false;
            DLLNode node = head;
            while (node != null)
            {
                if (node == p)
                {
                    isInList = true;
                    break;
                }

                node = node.next;
            }
            if (!isInList) { return;}
            else
            {
                if (p.next == null)
                {
                    removeTail();
                    return;
                }
                if (p.previous == null)
                {
                    removeHead();
                    return;
                }
                p.next.previous = p.previous;
                p.previous.next = p.next;
                p.next = null;
                p.previous = null;
                return;
            }
        }

        public int total()
        {
            DLLNode p = head;
            int tot = 0;
            while (p != null)
            {
                tot += p.num;
                p = p.next;
            }
            return (tot);
        } // end of total
    }
}
