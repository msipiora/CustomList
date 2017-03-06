using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T>
    {

        T[] array;
        public int capacity = 5;
        public int size;
        private int counter;
        public int Count { get { return counter; } }

        public T this[int index]
        {
            get
            {
                return array[index];
            }

            set
            {
                array[index] = value;
            }
        }


        public CustomList()
        {
            array = new T[0];

        }



        public void Add(T value)
        {
            T[] tempArray = new T[array.Length + 1];
            counter++;

            for (int index = 0; index < array.Length; index++)
            {
                tempArray[index] = array[index];
            }

            tempArray[tempArray.Length - 1] = value;

            array = tempArray;

        }


        public bool Remove(T value)
        {
            for (int i = 0; i < counter; i++)
            {
                if (array[i].Equals(value))
                {
                    int indexFirstInstance = i;

                    for (int j = indexFirstInstance; j < counter-1; j++)
                    {
                        array[j] = array[j + 1];
                       
                       
                    }
                    counter--;
                    return true;
                } 
               
            }
            return false;
        }

        public override string ToString()
        {
            string result = "";
            foreach (T value in array)
            {
                result += value.ToString();
            }
            return result;
        }

        public static CustomList<T> operator +(CustomList<T> listOne, CustomList<T> listTwo)
        {
            CustomList<T> combinedArray = new CustomList<T>();

            for (int i = 0; i < listOne.Count; i++)
            {
                combinedArray.Add(listOne.array[i]);
            }

            for (int i = 0; i < listTwo.Count; i++)
            {
                combinedArray.Add(listTwo.array[i]);
            }

            return combinedArray;



        }

        public static CustomList<T> operator -(CustomList<T> listOne, CustomList<T> listTwo)
        {
            for (int i = 0; i < listOne.Count; i++)
            {
                for (int j = 0; j < listTwo.Count; j++)
                {
                    if (listOne.array[i].Equals(listTwo.array[j]))
                    {
                        listOne.Remove(listTwo.array[j]);
                    }
                }
            }
            return listOne;
        }

        public CustomList<T> ZipList(CustomList<T> listOne)
        {
            CustomList<T> ZipList = new CustomList<T>();

            for (int i = 0; i < listOne.Count * 2; i++)
            {
                if (i % 2 == 0)
                {
                    ZipList.Add(listOne[i / 2]);
                }
                else
                    ZipList.Add(this[i / 2]);
            }
            return ZipList;
        }

        //public IEnumerator : GetEnumerator()
        //{
        //    //this is a reason to use var as the data type for the temporary variable
        //    //in a foreach loop
        //    yield return custom;

        //    for (int i = 0; i < custom.Count(); i++)
        //    {
        //        yield return custom[i];
        //    }
        //}
    }
    }


