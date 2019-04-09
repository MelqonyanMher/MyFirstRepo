# MyFirstRepo
Hi!I am Mher and I start learn GitHub))
This is my first repo and here you can find my Homeworks and other exercises that I did when I did my first steps))
Heav a good jurnay

[Fibonacci](##fibonacci)

[MyToDoList](##my-to-do-list)


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

[Fibonacci](https://github.com/MherMelkonyan/MyFirstRepo/tree/master/MIC.Volo/MIC.Volo.HW_FibFunc)

## My To Do List

[My_ToDoList](https://github.com/MherMelkonyan/MyFirstRepo/tree/master/MIC.Volo/MIC.Volo_Convertor_Eng-Arm)

[Convertor from eng Letter to arm letter](https://github.com/MherMelkonyan/MyFirstRepo/tree/master/MIC.Volo/MIC.Volo_ToDoList)
