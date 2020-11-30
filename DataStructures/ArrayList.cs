using System;
using System.Data;
using System.Linq;

namespace DataStructures
{
    public class ArrayList
    {
        public int Length { get; private set; }

        private int[] _array;
        private int _TrueLength
        {
            get
            {
                return _array.Length;
            }
        }

        public ArrayList()
        {
            _array = new int[9];
            Length = 0;
        }

        public ArrayList(int a)
        {
            _array = new int[1];
            _array[0] = a;
            Length = 1;
        }

        public ArrayList(int[] array)
        {
            _array = new int[(int)(array.Length * 1.33d)];
            Length = array.Length;
            Array.Copy(array, _array, array.Length);
        }

        public int this[int i]
        {
            get
            {
                if (i >= Length || i < 0)
                {
                    throw new Exception();
                }
                return _array[i];
            }
            set
            {
                if (i >= Length || i < 0)
                {
                    throw new Exception();
                }
                _array[i] = value;
            }
        }

        public void Add1ToTheEnd(int value)
        {
            if (_TrueLength <= Length)
            {
                IncreaseLength();
            }
            _array[Length] = value;
            Length++;
        }

        public void Delete1FromTheEnd()
        {
            if (Length == 0)
            {
                throw new Exception("Nothing to delete");
            }
           
            
            if (Length < _TrueLength / 2 + 1)
            {
                DecreaseLength();
            }
            Length--;
        }
             

        public void Add1ToIndex(int value, int index = 0)
        {
            RightShiftForAdd(index);
            _array[index] = value;
            Length++;
        }

        public void Delete1ByIndex(int index = 0)
        {
            if (Length == 0)
            {
                throw new Exception("Nothing to delete");
            }
            if (Length < _TrueLength / 2 + 1)
            {
                DecreaseLength();
            }
            LeftShiftForDelete(index);
            Length--;
        }

       
        public int GetIndexByValue(int value)
        {
            for (int i = 0; i<Length; i++)
            {
                if (_array[i] == value)
                {
                    return i;
                }
            }
            return -1;
        }

        public void Reverse()
        {
            for (int i=0; i<Length/2; i++)
            {
                int a = _array[i];
                _array[i] = _array[Length - i - 1];
                _array[Length - i - 1] = a;
            }
        }

        public int FindMaxElement()
        {
            int max = _array[0];

            for (int i = 1; i < Length; i++)
            {
                if (_array[i] > max)
                {
                    max = _array[i];
                }
            }
            return max;
        }

        public int FindMinElement()
        {
            int min = _array[0];

            for (int i = 1; i < Length; i++)
            {
                if (_array[i] < min)
                {
                    min = _array[i];
                }
            }
            return min;
        }

        public int FindIndexOfMax()
        {
            int max = _array[0];
            int index = 0;
            for (int i = 1; i < Length; i++)
            {
                if (_array[i] > max)
                {
                    index = i;
                    max = _array[i];
                }
            }
            return index;
        }

        public int FindIndexOfMin()
        {
            int min = _array[0];
            int index = 0;
            for (int i = 1; i < Length; i++)
            {
                if (_array[i] < min)
                {
                    index = i;
                    min = _array[i];
                }
            }
            return index;
        }

        public void AddByIndex(int index, int value)
        {
            throw new NotImplementedException();
        }

        public void RangeArrayToBig()
        {
            int temp;
            for (int i = 0; i < Length - 1; i++)
            {
                for (int j = 0; j < Length - 1 - i; j++)
                {
                    if (_array[j] > _array[j + 1])
                    {
                        temp = _array[j];
                        _array[j] = _array[j + 1];
                        _array[j + 1] = temp;
                    }
                }
            }
        }

        public void RangeArrayToSmall()
        {
            for (int i = 0; i < Length - 1; i++)
            {
                int maxi = i;

                for (int j = i; j < Length; j++)
                {
                    if (_array[j] > _array[maxi])
                    {
                        maxi = j;
                    }
                }
                int c = _array[i];
                _array[i] = _array[maxi];
                _array[maxi] = c;
            }
        }

        public void DeleteByFirstValue(int value)
        {
            if (GetIndexByValue(value) != -1)
            {
                Delete1ByIndex(GetIndexByValue(value));
            }
        }

        public void DeleteByValue(int value)
        {
            while (GetIndexByValue(value) != -1)
            {
                Delete1ByIndex(GetIndexByValue(value));
            }
        }

        public void AddArrayToTheEnd(int[] array)
        {
            IncreaseLength(array.Length);
            for (int i=0; i<array.Length; i++)
            {
                _array[Length + i] = array[i];
            }
            Length = Length + array.Length;
        }

        public void AddArrayByIndex(int[] array, int index=0)
        {
            IncreaseLength(array.Length);

            Length = Length + array.Length;

            int shiftpoint = index;
            for (int i=0; i<array.Length; i++)
            {
                RightShiftForAdd(shiftpoint);
                shiftpoint++;
            }
            //for (int i = Length+array.Length; i > index+array.Length; i--)
            //{
            //    _array[i+array.Length] = _array[i - array.Length];
            //}

            for (int i=0; i<array.Length; i++)
            {
                _array[i+index] = array[i];
            }
        }

        public override string ToString()
        {
            return string.Join(";", _array.Take(Length));
        }

        private void RightShiftForAdd(int index = 0)
        {
            if (_TrueLength <= Length)
            {
                IncreaseLength();
            }
            for (int i = Length; i > index; i--)
            {
                _array[i] = _array[i - 1];
            }
        }

        private void LeftShiftForDelete(int index = 0)
        {
            if (Length < _TrueLength / 2 + 1)
            {
                DecreaseLength();
            }
            for (int i=index; i<Length-1; i++)
            {
                _array[i] = _array[i + 1];
            }
        }
        
        private void IncreaseLength(int number = 1)
        {
            int newLength = _TrueLength;
            while (newLength <= Length + number)
            {
                newLength = (int)(newLength * 1.33 + 1);
            }

            int[] newArray = new int[newLength];
            Array.Copy(_array, newArray, Length);

            _array = newArray;
        }

        private void DecreaseLength(int number = 1)
        {
            int newLength = _TrueLength;
            while (Length - number < newLength/2 + 1)
            {
                newLength = newLength * 2 / 3 + 1;
            }
            int[] newArray = new int[newLength];
            Array.Copy(_array, newArray, Length);

            _array = newArray;
        }

        public override bool Equals(object obj)
        {
            ArrayList arrayList = (ArrayList)obj;

            if (Length != arrayList.Length)
            {
                return false;
            }
            else
            {
                for (int i = 0; i < Length; i++)
                {
                    if (_array[i] != arrayList._array[i])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
