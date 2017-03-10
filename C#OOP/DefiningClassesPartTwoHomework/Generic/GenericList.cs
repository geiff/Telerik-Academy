using System;
using System.Text;

namespace DefiningClasses
{
    public class GenericList<T>
        where T : IComparable<T>
    {
        private const int CAPACITY = 4;

        private T[] elements;
        private int count = 0;

        public GenericList()
        {
            this.elements = new T[CAPACITY];
        }

        public int Count {
            get { return this.count; }
            private set { this.count = value; }
        }

        public int Capacity { get {return this.elements.Length; } }

        /// <summary>
        /// Accessing element by index
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public T this[int index]
        {
            get
            {
                if (index > this.Count - 1)
                {
                    throw new ArgumentOutOfRangeException($"Invalid index {index}");
                }

                return this.elements[index];
            }
        }

        /// <summary>
        /// Adding element
        /// </summary>
        /// <param name="item"></param>
        public void Add(T item)
        {
            this.elements[count] = item;
            this.count++;
            if (this.Count == this.Capacity)
            {
                Resize();
            }

        }

        /// <summary>
        /// Implement auto-grow functionality
        /// </summary>
        private void Resize()
        {
            var newElements = new T[2* this.Capacity];

            for (int i = 0; i < this.Count; i++)
            {
                newElements[i] = this.elements[i];
            }

            this.elements = newElements;
        }

        /// <summary>
        /// Finding index on element by its value
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public int FindIndex(T element)
        {
            int index = -1;
                
            for (int i = 0; i < this.Count; i++)
            {
                if (this.elements[i].Equals(element))
                {
                    index = i;
                    break;
                }
            }

            return index;
        }

        /// <summary>
        /// Removing element by element
        /// </summary>
        /// <param name="element"></param>
        public void RemoveByElement(T element)
        {
            int index = FindIndex(element);

            for (int i = index; i < this.Count - 1; i++)
            {
                this.elements[i] = this.elements[i + 1];
            }

            this.elements[this.Count - 1] = default(T);
            this.Count--;
        }

        /// <summary>
        /// Removing element by index
        /// </summary>
        /// <param name="index"></param>
        public void RemoveByIndex(int index)
        {
            if (index > this.Count - 1)
            {
                throw new ArgumentOutOfRangeException($"Invalid index {index}");
            }
            for (int i = index; i < this.Count - 1; i++)
            {
                this.elements[i] = this.elements[i + 1];
            }

            this.elements[this.Count - 1] = default(T);
            this.Count--;
        }

        /// <summary>
        /// Inserting element at given position
        /// </summary>
        /// <param name="element"></param>
        /// <param name="position"></param>
        public void Insert(T element, int position)
        {
            if (position > this.Count - 1)
            {
                throw new ArgumentOutOfRangeException($"Invalid index {position}");
            }

            if (this.Count + 1 == this.Capacity)
            {
                Resize();
            }

            this.Count++;

            for (int i = this.Count; i >= position; i--)
            {
                this.elements[i] = this.elements[i - 1];
            }

            this.elements[position] = element;
        }

        /// <summary>
        ///  Clearing the list
        /// </summary>
        public void ClearList()
        {
            for (int i = 0; i < this.Count; i++)
            {
                this.elements[i] = default(T);
            }

            this.Count = 0;
        }

        public T Min() 
        {
            T minElement = this.elements[0];

            for (int i = 1; i < this.Count; i++)
            {
                if (this.elements[i].CompareTo(minElement) < 0)
                {
                    minElement = this.elements[i];
                }
            }

            return minElement;
        }

        public T Max() 
        {
            T maxElement = this.elements[0];

            for (int i = 1; i < this.Count; i++)
            {
                if (this.elements[i].CompareTo(maxElement) > 0)
                {
                    maxElement = this.elements[i];
                }
            }

            return maxElement;
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            int length = 0;

            length = this.Count != 0 ? this.Count : this.Capacity;

            for (int i = 0; i < length - 1; i++)
            {
               result.Append(this.elements[i] + ", ");
            }

            result.Append(this.elements[length - 1]);

            return result.ToString();
        }
    }
}