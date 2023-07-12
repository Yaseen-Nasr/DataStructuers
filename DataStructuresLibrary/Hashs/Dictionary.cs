 

namespace DataStructuresLibrary.Hashs
{
    public class Dictionary<TKey, TValue> where TKey : class
    {
        CustomKeyValuePair<TKey,TValue> [] enteries;
        int initialSize = default;
        int enteriesCount = default;
        public Dictionary()
        {
             initialSize = 3;

            enteries = new CustomKeyValuePair<TKey, TValue>[initialSize];
        }
        public int Size()
        {
            return enteriesCount;
        }
        public TValue Get(TKey key)
        {
            for (int i = 0; i < enteries.Length; i++)
            {
                if (enteries[i] is null)
                    continue;
                if (enteries[i].Key == key) 
                    return enteries[i].Value; 
            }
            return default!;
        }
        /// <summary>
        /// if key exist it remove it by swap between that CustomKeyValuePair with
        ///                    the last element in dictionary, after that set This last element to null to guarantee that ther's will not be null values inside the dictionary
        /// </summary>
        /// <param name="key"> </param>
        /// <returns>True if Removed an exists Key , false if Key not exists</returns>
        public bool Remove(TKey key)
        {
            for (int i = 0; i < enteries.Length; i++)
            {
                if (enteries[i] is null)
                    continue;
                if (enteries[i].Key == key)
                {
                    enteries[i] = enteries[enteriesCount-1];
                    enteries[enteriesCount - 1] = default!;
                    enteriesCount--;
                    return true;
                }
            }
            return false;
        }
        public void Print()
        {
            Console.WriteLine("----------");
            Console.WriteLine("[size] " + Size());
            for (int i = 0; i < enteries.Length; i++)
            {
                if (enteries[i] is null)
                    continue;
                Console.WriteLine($"key: {enteries[i].Key} => Value: {enteries[i].Value}");
            }
            Console.WriteLine("==========");

        }
        public void Set(TKey key, TValue value)
        {
            
            for (int i = 0; i < enteries.Length; i++)
            {
                if (enteries[i] is null)
                    continue;
                if (enteries[i].Key == key)
                {
                    enteries[i].Value = value;
                    return;
                }
            }
            Resize();
            CustomKeyValuePair<TKey, TValue> CustomKeyValuePair = new CustomKeyValuePair<TKey, TValue>(key, value);
            enteries[this.enteriesCount] = CustomKeyValuePair;
            enteriesCount++;
        }
        void Resize()
        {
            if (enteriesCount < enteries.Length - 1)
                return;
            int newSize=initialSize  + enteries.Length;
            Console.WriteLine($"Resize from {enteries.Length} to {newSize}" );
            CustomKeyValuePair<TKey, TValue>[] newEnteries = new CustomKeyValuePair<TKey, TValue>[newSize];
            Array.Copy(enteries, newEnteries, this.enteries.Length);
            enteries = newEnteries;
        } 
     
    }
    class  CustomKeyValuePair<TKey , TValue>
    {
        TKey _key;
        TValue _value;
        public CustomKeyValuePair(TKey key, TValue value)
        {
            _key = key;
            _value = value;
        }
        public TKey Key
        {
            get { return _key; }
        }
        public TValue Value
        {
            get { return _value; }
            set { _value = value; }
        }
    }

}
