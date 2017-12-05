using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.OtherStuff
{
    public class AsyncWrapper<T> where T : class
    {
        private T _item;
        private Task loadTask;
        private double _initializationMilliseconds;

        public T Item
        {
            get
            {
                if (_item == null)
                    loadTask.Wait();
                return _item;
            }
            set { _item = value; }
        }

        public double InitializationMilliseconds
        {
            get
            {
                if (_item == null)
                    loadTask.Wait();
                return _initializationMilliseconds;
            }
        }

        internal void AbstractLoadAsync(Action completeInitialization = null)
        {
            var startTime = DateTime.Now;
            var constructor = typeof(T).GetConstructors().FirstOrDefault
          (c => c.GetParameters().Length == 0);
            Debug.Assert(constructor != null,
                "The AbstractLoadAsync constructor without the constructor parameter requires "
               + "a parameterless constructor");
            loadTask = Task.Run<T>(() =>
            {
                var item = constructor.Invoke(new object[] { });
                return (T)item;
            }).ContinueWith(result =>
            {
                Item = result.Result;
                _initializationMilliseconds = DateTime.Now.Subtract(startTime).TotalMilliseconds;
                completeInitialization();
            });
        }

        internal void AbstractLoadAsync(Func<T> constructor, Action completeInitialization = null)
        {
            var startTime = DateTime.Now;
            loadTask = Task.Run<T>(() =>
            {
                var item = constructor();
                return (T)item;
            }).ContinueWith(result =>
            {
                Item = result.Result;
                _initializationMilliseconds = DateTime.Now.Subtract(startTime).TotalMilliseconds;
                completeInitialization();
            });
        }

        public void ExecuteAsync(Action<T> set)
        {
            if (_item == null)
                Task.Run(() => loadTask.Wait())
                    .ContinueWith(result => set(Item));
            else
                set(Item);
        }
    }
}
