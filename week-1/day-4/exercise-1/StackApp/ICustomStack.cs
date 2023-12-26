namespace StackApp
{
    internal interface ICustomStack<T>
    {
        void Push(T item);
        T Pop();
        bool IsEmpty();
    }
    public class CustomStack<T> : ICustomStack<T>
    {
        List<T> internalArray;
        int lastIndex;
        public CustomStack()
        {
            internalArray = new List<T> ();
            lastIndex = -1;
        }

        public void Push(T item) {
            internalArray.Add(item);
            lastIndex++;
        }
        public T Pop() {
            T  ans = internalArray[lastIndex]; 
            internalArray.RemoveAt(lastIndex);
            lastIndex--;
            return ans;
             }
        public bool IsEmpty()
        {
            return lastIndex == -1;
        }
    }
}
