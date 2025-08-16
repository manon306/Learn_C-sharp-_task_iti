namespace Day_7_task
{
    class MyDictionary<TKey, TValue>
    {
        private TKey[] keys = new TKey[0];
        private TValue[] items = new TValue[0];

        public void Add(TKey key, TValue value)
        {
            for (int i = 0; i < keys.Length; i++)
            {
                if (keys[i] == (dynamic) (key))
                {
                    throw new Exception("Must enter Unique Key");
                }
            }
            TKey[] newKeys = new TKey[keys.Length + 1];
            TValue[] newValues = new TValue[items.Length + 1];

            for (int i = 0; i < keys.Length; i++)
            {
                newKeys[i] = keys[i];
                newValues[i] = items[i];
            }
            newKeys[newKeys.Length - 1] = key;
            newValues[newValues.Length - 1] = value;

            keys = newKeys;
            items = newValues;
        }

        public TValue GetValue(TKey key)
        {
            for (int i = 0; i < keys.Length; i++)
            {
                if (keys[i] == (dynamic)(key))
                {
                    return items[i];
                }
            }
            throw new Exception("Key not found");
        }

        public void Remove(TKey key)
        {
            int index = -1;
            for (int i = 0; i < keys.Length; i++)
            {
                if (keys[i] == (dynamic)(key))
                {
                    index = i;
                    break;
                }
            }

            if (index == -1)
            {
                throw new Exception("Key not found");
            }

            TKey[] newKeys = new TKey[keys.Length - 1];
            TValue[] newValues = new TValue[items.Length - 1];

            int j = 0;
            for (int i = 0; i < keys.Length; i++)
            {
                if (i == index) continue;
                newKeys[j] = keys[i];
                newValues[j] = items[i];
                j++;
            }
            keys = newKeys;
            items = newValues;
        }


    }
}