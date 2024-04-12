using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_01
{
    public struct PhoneBook
    {
        #region Attrbuite
        string[] names;
        long[] numbers;
        int size;
        #endregion

        #region Propertis
        public int Size //ReadOnly Property
        {
            get{ return size; } 
        }
        #endregion

        #region Getter && Setter && Indexer
        //// Getter
        //public long GetPersonNumber(string name)
        //{
        //    for(int i=0;i < names?.Length;i++)
        //        if (names[i]==name)
        //            return numbers[i];
        //    return -1;
        //}

        ////Setter [Update]
        //public void SetPersonNumber(string name, long value) 
        //{
        //    for (int i = 0; i < names?.Length; i++)
        //        if (names[i] == name)
        //        {
        //            numbers[i] = value;
        //            break;
        //        }
        //}

        //Indexer 
        public long this[string name]
        {
            get
            {
                for (int i = 0; i < names?.Length; i++)
                    if (names[i] == name)
                        return numbers[i];
                return -1;
            }
            set {
                for (int i = 0; i < names?.Length; i++)
                    if (names[i] == name)
                    {
                        numbers[i] = value;
                        break;
                    }
            }
        }
        public string this[int index]
        {
            get
            {
                return $"{index} :: {names[index]} :: {numbers[index]}";
            }
        }
        #endregion

        #region Constructors
        
        public PhoneBook(int _size)
        {
            size = _size;
            names = new string[size];
            numbers = new long[size];   
        }
        #endregion

        #region Methods
        public void AddPerson(int position,string name,long number)
        {
            if (position >= 0 && position <= size)
            {
                names[position] = name;
                numbers[position] = number;
            }
        }
        public override string ToString()
        {
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"{i} :: {names[i]} :: 0{numbers[i]}" );
            }
            return "The End";
        }
        #endregion
    }
}
