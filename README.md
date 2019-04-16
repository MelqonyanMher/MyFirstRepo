# MyFirstRepo
Hi!I am Mher and I start learn GitHub))
This is my first repo and here you can find my Homeworks and other exercises that I did when I did my first steps))
Heav a good jurnay

[Task Parallel Library](#tpl)

[Prime num](#prime-numbers)

[Fibonacci](#fibonacci)

[MyToDoList](#my-to-do-list)

## TPL



[TPL](https://github.com/MherMelkonyan/MyFirstRepo/tree/master/MIC.Volo/MIC.Volo.TPL)

## Prime Numbers

```csharp
public async Task<int> PrimeNumAsync(int n)
{
     Func<int> myFunc = () =>
     {
         if (n == 1) return 2;
         else if(n == 2) return 3;
         else if(n == 3) return 5;
         else
         {
             int temp = 3;
             int count = 1;

             while (count <= n)
             {
                bool b = true;

                for (int i = 2; i < temp / 2; i++)
                {
                     if (temp % i == 0)
                     {
                       b = false;
                       temp++;
                       break;
                     }
                }
                if (b)
                {
                    count++;
                    if (count <= n)
                    {
                        temp++;
                    }
                 }
              }

              return temp;
          }
      };
      Task<int> myTask = Task.Factory.StartNew<int>(myFunc);
      return await myTask;
}
```

[Prime Num](https://github.com/MherMelkonyan/MyFirstRepo/tree/master/MIC.Volo/Mic.Volo.PrimeNumber)

## Fibonacci


This is my first HomeWork in the github.I think you know Fibonacci's numbers)))in my code my function is returning IEnumerable<BigInteger> and we can get Fibonacci's numbers endless.
  
  ```csharp
  static IEnumerable<BigInteger> Fibonacci()
  {
       BigInteger a = 0;
       BigInteger b = 1;
       BigInteger temp = a;

       while (true)
       {
           yield return  b;
           temp = a;
           a = b;
           b = a + temp;
           Thread.Sleep(500);
       }
   }
  ```
You can find my project here [Fibonacci](https://github.com/MherMelkonyan/MyFirstRepo/tree/master/MIC.Volo/MIC.Volo.HW_FibFunc)

## My To Do List

This is my To Do List where you can add your strings,by boolean parametr indicate them checked or not and remove not only by string but also by bool parametr.

Here is my code example 
```csharp
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

```
You can find my project here [My_ToDoList](https://github.com/MherMelkonyan/MyFirstRepo/tree/master/MIC.Volo/MIC.Volo_Convertor_Eng-Arm)

[Convertor from eng Letter to arm letter](https://github.com/MherMelkonyan/MyFirstRepo/tree/master/MIC.Volo/MIC.Volo_ToDoList)
