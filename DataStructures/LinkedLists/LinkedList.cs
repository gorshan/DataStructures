﻿using System;

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
                Length--;
                return;
            }

            for (int i = 0; i < index - 1; i++)
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

            if (Length == 1)
            {
                _root = current.Next;
            }
            for (int i = 1; i < Length - 1; i++)
            {
                current = current.Next;
            }
            current.Next = null;
            //current.Next = current.Next.Next;
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
            Node current = GetNodeByIndex(Length-1);

            for (int i = 0; i < array.Length; i++)
            {
                current.Next = new Node(array[i]);
                current = current.Next;
            }
            Length = Length + array.Length;
        }

        public void AddArrayByIndex(int[] array, int index = 0)
        {
            Node current = GetNodeByIndex(index-1);
            Node tmp = GetNodeByIndex(index );

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
            if (n > Length)
            {
                throw new ArgumentOutOfRangeException();
            }
            Node tmp = GetNodeByIndex(Length - n);
            tmp = null;
            Length = Length - n;
        }

        public void DeleteNElementsFromTheBeginning(int n)
        {
            if (n > Length)
            {
                throw new ArgumentOutOfRangeException();
            }

            Node tmp = GetNodeByIndex(n);
            _root = tmp;
            Length = Length - n;
        }

        public void DeleteNElementsByIndex(int index, int n)
        {
            if (n > Length)
            {
                throw new ArgumentOutOfRangeException();
            }

            Node tmp = GetNodeByIndex(index-1);
            Node tmp1 = GetNodeByIndex(index + n);
            if (index == 0)
            {
                DeleteNElementsFromTheBeginning(n);
                return;
            }
            tmp.Next = tmp1;

            Length = Length - n;
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

        private Node GetNodeByIndex(int index)
        {
            Node tmp = _root;
            for (int i = 0; i < index; i++)
            {
                tmp = tmp.Next;
            }
            return tmp;
        }
    }
}
