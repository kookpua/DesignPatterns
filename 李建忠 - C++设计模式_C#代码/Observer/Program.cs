using System;
using System.Collections;

namespace Observer
{
    /// <summary>
    /// 此demo来自维基百科：https://zh.wikipedia.org/wiki/%E8%A7%82%E5%AF%9F%E8%80%85%E6%A8%A1%E5%BC%8F
    /// 印象笔记镜像：https://app.yinxiang.com/fx/7d005479-38d3-4613-94a5-31272383dded
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Subject mySubject = new Subject();
            IObserver myObserver1 = new Observer1();
            IObserver myObserver2 = new Observer2();

            // register observers
            mySubject.Register(myObserver1);
            mySubject.Register(myObserver2);

            mySubject.Notify("message 1");
            mySubject.Notify("message 2");
        }
    }


    // IObserver --> interface for the observer
    public interface IObserver
    {
        // called by the subject to update the observer of any change
        // The method parameters can be modified to fit certain criteria
        void Update(string message);
    }

    public class Subject
    {
        // use array list implementation for collection of observers
        private ArrayList observers;

        // constructor
        public Subject()
        {
            observers = new ArrayList();
        }

        public void Register(IObserver observer)
        {
            // if list does not contain observer, add
            if (!observers.Contains(observer))
            {
                observers.Add(observer);
            }
        }

        public void Deregister(IObserver observer)
        {
            // if observer is in the list, remove
            if (observers.Contains(observer))
            {
                observers.Remove(observer);
            }
        }

        public void Notify(string message)
        {
            // call update method for every observer
            foreach (IObserver observer in observers)
            {
                observer.Update(message);
            }
        }
    }

    // Observer1 --> Implements the IObserver
    public class Observer1 : IObserver
    {
        public void Update(string message)
        {
            Console.WriteLine("Observer1:" + message);
        }
    }

    // Observer2 --> Implements the IObserver
    public class Observer2 : IObserver
    {
        public void Update(string message)
        {
            Console.WriteLine("Observer2:" + message);
        }
    }
}
