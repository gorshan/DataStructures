using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.LinkedList
{
    public class LinkedList
    {
        public int Length { get; set; }

        private Node _root;

        public int this[int index]
        {
            get
            {
                Node tmp = _root;
                for (int i = 1; i <= index; i++)
                {
                    tmp = tmp.Next;
                }
                return tmp.Value;
            }

            set
            {
                Node tmp = _root;
                for (int i = 1; i <= index; i++)
                {
                    tmp = tmp.Next;
                }
                tmp.Value = value;
            }
        }

        public LinkedList()
        {
            Length = 0;
            _root = null;
        }

        public LinkedList(int value)
        {
            _root = new Node(value);
            Length = 1;
        }

        public LinkedList(int[] array)
        {
            if (array.Length != 0)
            {
                _root = new Node(array[0]);
                Node tmp = _root;

                for (int i = 1; i < array.Length; i++)
                {
                    tmp.Next = new Node(array[i]);
                    tmp = tmp.Next;
                }

                Length = array.Length;
            }
            else
            {
                Length = 0;
                _root = null;
            }
        }

        public void AddByIndex(int index, int value)
        {
            if (index == 0)
            {
                Node tmp = _root;
                _root = new Node(value);
                _root.Next = tmp;
            }
            else
            {
                Node current = _root;
                for (int i = 1; i < index; i++)
                {
                    current = current.Next;
                }

                Node tmp = current.Next;
                current.Next = new Node(value);

                current.Next.Next = tmp;
            }
            Length++;
        }

        public void AddToTheEnd(int value)
        {
            if (Length == 0)
            {
                Node tmp = _root;
                _root = new Node(value);
                _root.Next = tmp;
            }

            Node current = _root;
            for (int i = 1; i < Length; i++)
            {
                current = current.Next;
            }
            current.Next = new Node(value);
            Length++;
        }

        public void DeleteByIndex(int index)
        {
            if (Length == 0)
            {
                throw new Exception("Nothing to delete");
            }
            Node current = _root;
            if (index == 0)
            {
                _root = current.Next;
            }

            for (int i = 0; i < index-1; i++)
            {
                current = current.Next;
            }
            current.Next = current.Next.Next;
            Length--;
        }

        public void DeleteFromTheEnd()
        {
            if (Length == 0)
            {
                throw new Exception("Nothing to delete");
            }

            Node current = _root;
            for (int i = 1; i < Length-1; i++)
            {
                current = current.Next;
            }
            Length--;
        }



        public override bool Equals(object obj)
        {
            LinkedList linkedList = (LinkedList)obj;

            if (Length != linkedList.Length)
            {
                return false;
            }

            //for (int i = 0; i < Length; i++)
            //{
            //    if(this[i]!=linkedList[i])
            //    {
            //        return false;
            //    }
            //}

            Node tmp1 = _root;
            Node tmp2 = linkedList._root;
            for (int i = 0; i < Length; i++)
            {
                if (tmp1.Value != tmp2.Value)
                {
                    return false;
                }
                tmp1 = tmp1.Next;
                tmp2 = tmp2.Next;
            }
            return true;
        }

        public override string ToString()
        {
            string s = "";

            if (_root != null)
            {
                Node tmp = _root;

                while (tmp != null)
                {
                    s += tmp.Value + ";";
                    tmp = tmp.Next;
                }
            }
            return s;
        }
    }
}
