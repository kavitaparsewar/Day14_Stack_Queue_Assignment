using Day14_Stack_Queue_Assignment.Linked_List_Using_Queue;
using Day14_Stack_Queue_Assignment.Stack;
using System;

namespace Day14_Stack_Queue_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Stack and Queue Program");


            //#region of stack 
            //UC1_UC2_create_stack_peak_pop linkedListStack = new UC1_UC2_create_stack_peak_pop();

            //#region UC1 create a stack
            //linkedListStack.Push(70);
            //linkedListStack.Push(30);
            //linkedListStack.Push(56);
            //linkedListStack.Display();
            //#endregion UC1 create a stack


            //#region UC2 i.e peak and pop
            ////linkedListStack.Peek();          
            ////linkedListStack.Pop();
            //linkedListStack.IsEmpty();
            //linkedListStack.Display();
            //#endregion UC2 i.e peak and pop

            //#endregion of stack



            UC3_UC4_create_Queue_dequeue linkedListQueue = new UC3_UC4_create_Queue_dequeue();

            //#region of Queue

            //#region UC3 create a Queue
            linkedListQueue.Enqueue(56);
            linkedListQueue.Enqueue(30);
            linkedListQueue.Enqueue(70);
            linkedListQueue.Display();
            //#endregion UC3 create a Queue




            //#endregion of Queue
        }
    }
}
