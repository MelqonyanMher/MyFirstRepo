using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIC.Volo_ToDoList
{
    public class MyToDoList
    {
        private class MyToDo
        {
            public MyToDo(string value)
            {
                Value = value;
            }

            public string Value { get; set; }
            public bool Checked { get; set; } = false;
        }

        private List<MyToDo> myList;
        public bool IsEmpty => myList == null;
        public void Add(string s)
        {
            if (IsEmpty)
            {
                myList = new List<MyToDo>();
                myList.Add(new MyToDo(s));
            }
            else
            {
                myList.Add(new MyToDo(s));
            }
        }
        public void Remove(string s)
        {
            if (IsEmpty)
            {
                throw new NullReferenceException("List is Empty!");
            }

            MyToDo m = null;
            foreach (var item in myList)
            {
                if (item.Value == s)
                {
                    m = item;
                }
                else throw new Exception("string wasn't found!");

            }
            myList.Remove(m);

        }
        public void RemoveAll(bool b)
        {
            if (IsEmpty)
            {
                throw new NullReferenceException("List is Empty!");
            }

            
            myList.RemoveAll(x=>x.Valid);

        }
    }
}
