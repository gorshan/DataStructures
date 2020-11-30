using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.DoubleLinkedLists
{
    public class DoubleLinkedList
    {
        public int Length { get; set; }

        private Node _root;

        private Node _tail;

        public int this[int index]
        {
            get
            {
                Node tmp = _root;
                if (index < Length / 2)
                {
                    for (int i = 1; i <= index; i++)
                    {
                        tmp = tmp.Next;
                    }
                }
                else
                {
                    tmp = _tail;
                    for (int i = Length - 1; i > 0; i--)
                    {
                        tmp = tmp.Previous;
                    }
                }
                return tmp.Value;
            }
            set
            {
                Node tmp = _root;
                if (index < Length / 2)
                {
                    for (int i = 1; i <= index; i++)
                    {
                        tmp = tmp.Next;
                    }
                }
                else
                {
                    tmp = _tail;
                    for (int i = Length - 1; i > 0; i--)
                    {
                        tmp = tmp.Previous;
                    }
                }
                tmp.Value = value;
            }
        }

        public DoubleLinkedList()
        {
            Length = 0;
            _root = null;
            _tail = null;
        }

        public DoubleLinkedList(int value)
        {
            _root = new Node(value);
            _tail = _root;
            Length = 1;
        }

        public DoubleLinkedList(int[] array)
        {
            if (array.Length != 0)
            {
                _root = new Node(array[0]);
                Node tmp = _root;

                for (int i = 1; i < array.Length; i++)
                {
                    tmp.Next = new Node(array[i]);
                    tmp.Next.Previous = tmp;
                    tmp = tmp.Next;
                }
                _tail = tmp;
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
            //если индек не в массиве сделай исключение
            if (index == 0)
            {
                Node tmp = _root;
                _root = new Node(value);
                _root.Next = tmp;
                _root.Next.Previous = _root;
            }
            else
            {
                Node tmp = GetNodeByIndex(index);
                Node tmp1 = GetNodeByIndex(index+1);

                tmp.Next = new Node(value);
                tmp.Next.Next = tmp1;
                tmp1.Previous = tmp.Next;
                tmp1.Previous.Previous = tmp;
            }
            Length++;
        }

        public void AddToTheEnd(int value)
        {
            if (Length == 0)
            {
                _root = new Node(value);
                _tail = _root;
            }

            Node tmp = _tail;
            _tail = new Node(value);
            _tail.Previous = tmp;
            _tail.Previous.Next = _tail;
            Length++;
        }

        public void DeleteByIndex(int index)
        {
            if (Length == 0)
            {
                throw new Exception("Nothing to delete");
            }

            if (Length == 1)
            {
                _root = null;
                _tail = _root;
                Length--;
                return;
            }

            if (index == 0)
            {
                _root = _root.Next;
                _root.Previous = null;
                Length--;
                return;
            }

            if (index == Length - 1)
            {
                DeleteFromTheEnd();
            }
            else
            {
                Node tmp = GetNodeByIndex(index - 1);
                Node tmp1 = GetNodeByIndex(index + 1);

                tmp.Next = tmp1;
                tmp1.Previous = tmp;
                Length--;
            }
            
        }

        public void DeleteFromTheEnd()
        {
            if (Length == 0)
            {
                throw new Exception("Nothing to delete");
            }
            if (Length == 1)
            {
                _root = null;
                _tail = _root;
                Length--;
                return;
            }

            _tail = _tail.Previous;
            _tail.Next = null;

            Length--;
        }

        public int GetIndexByValue(int val)
        {
            Node current = _root;
            int value;
            for (int i = 0; i < Length; i++)
            {
                value = current.Value;
                if (value == val)
                {
                    return i;
                }
                current = current.Next;
            }
            return -1;
        }

        public int FindMaxElement()
        {
            if (Length == 0)
            {
                throw new InvalidOperationException();
            }
            Node current = _root;
            int max = _root.Value;
            int value;
            for (int i = 0; i < Length; i++)
            {
                value = current.Value;
                if (value > max)
                {
                    max = value;
                }
                current = current.Next;
            }
            return max;
        }

        public int FindMinElement()
        {
            if (Length == 0)
            {
                throw new InvalidOperationException();
            }
            Node current = _root;
            int min = _root.Value;
            int value;
            for (int i = 0; i < Length; i++)
            {
                value = current.Value;
                if (value < min)
                {
                    min = value;
                }
                current = current.Next;
            }
            return min;
        }

        public int FindIndexOfMax()
        {
            if (Length == 0)
            {
                throw new InvalidOperationException();
            }
            Node current = _root;
            int max = _root.Value;
            int value;
            int indexMax = 0;
            for (int i = 0; i < Length; i++)
            {
                value = current.Value;
                if (value > max)
                {
                    max = value;
                    indexMax = i;
                }
                current = current.Next;
            }
            return indexMax;
        }

        public int FindIndexOfMin()
        {
            Node current = _root;
            int min = _root.Value;
            int value;
            int indexMin = 0;
            for (int i = 0; i < Length; i++)
            {
                value = current.Value;
                if (value < min)
                {
                    min = value;
                    indexMin = i;
                }
                current = current.Next;
            }
            return indexMin;
        }

        public void RangeArrayToBig()
        {

            //int temp;
            //for (int i = 0; i < Length - 1; i++)
            //{
            //    for (int j = 0; j < Length - 1 - i; j++)
            //    {
            //        if (_array[j] > _array[j + 1])
            //        {
            //            temp = _array[j];
            //            _array[j] = _array[j + 1];
            //            _array[j + 1] = temp;
            //        }
            //    }
            //}
        }

        public void DeleteByFirstValue(int val)
        {
            if (GetIndexByValue(val) != -1)
            {
                DeleteByIndex(GetIndexByValue(val));
            }
        }

        public void DeleteByValue(int val)
        {
            while (GetIndexByValue(val) != -1)
            {
                DeleteByIndex(GetIndexByValue(val));
            }
        }

        public void Reverse()
        {
            Node oldRoot = _root;
            Node tmp;

            while (oldRoot.Next != null)
            {
                tmp = oldRoot.Next;
                oldRoot.Next = oldRoot.Next.Next;
                tmp.Next = _root;
                _root = tmp;
            }
        }

        public void AddArrayToTheEnd(int[] array)
        {
            Node current = GetNodeByIndex(Length - 1);

            for (int i = 0; i < array.Length; i++)
            {
                current.Next = new Node(array[i]);
                current = current.Next;
            }
            Length = Length + array.Length;
        }

        public void AddArrayByIndex(int[] array, int index = 0)
        {
            Node current = GetNodeByIndex(index - 1);
            Node tmp = GetNodeByIndex(index);

            if (index == 0)
            {
                _root = new Node(array[0]);
                Node current2 = _root;
                for (int i = 1; i < array.Length; i++)
                {
                    current2.Next = new Node(array[i]);
                    current2 = current2.Next;
                }
                current2.Next = tmp;
            }
            else
            {
                if (index == Length - 1)
                {
                    AddArrayToTheEnd(array);
                }

                for (int i = 0; i < array.Length; i++)
                {
                    current.Next = new Node(array[i]);
                    current = current.Next;
                }
                current.Next = tmp;
            }
            Length = Length + array.Length;
        }

        public void DeleteNElementsFromTheEnd(int n)
        {
            Node tmp = GetNodeByIndex(Length - n);
            tmp.Next = null;
        }

        public override bool Equals(object obj)
        {
            DoubleLinkedList doubleLinkedList = (DoubleLinkedList)obj;

            if (Length != doubleLinkedList.Length)
            {
                return false;
            }

            Node tmp1 = _root;
            Node tmp2 = doubleLinkedList._root;

            while (tmp1 != null)
            {
                if (tmp1.Value != tmp2.Value)
                {
                    return false;
                }
                tmp1 = tmp1.Next;
                tmp2 = tmp2.Next;
            }
            tmp1 = _tail;
            tmp2 = doubleLinkedList._tail;
            while (tmp1 != null)
            {
                if (tmp1.Value != tmp2.Value)
                {
                    return false;
                }
                tmp1 = tmp1.Previous;
                tmp2 = tmp2.Previous;
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

        private Node GetNodeByIndex(int index)
        {
            //Node tmp = _root;
            //for (int i = 0; i < index; i++)
            //{
            //    tmp = tmp.Next;
            //}

            Node tmp = _root;
            if (index < Length / 2)
            {
                for (int i = 0; i < index; i++)
                {
                    tmp = tmp.Next;
                }
            }
            else
            {
                tmp = _tail;
                for (int i = Length - 1; i > index; i--)
                {
                    tmp = tmp.Previous;
                }
            }
            return tmp;
        }

        
    }
}
