namespace Day_7_task
{
    class MyList
    {
        private int[] items;
        private int count;

        public MyList()
        {
            items = new int[4];
            count = 0;
        }

        public int Count
        {
            get
            {
                return count;
            }
        }

        public void Add(int value)
        {
            if (count == items.Length)
            {
                int[] newArray = new int[items.Length * 2];
                for (int i = 0; i < items.Length; i++)
                {
                    newArray[i] = items[i];
                }
                items = newArray;
            }
            items[count] = value;
            count++;
        }

        public int Get(int index)
        {
            if (index < 0 || index >= count)
                throw new Exception("Out of index");
            return items[index];
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= count)
                throw new Exception("Out of index");

            for (int i = index; i < count - 1; i++)
            {
                items[i] = items[i + 1];
            }
            count--;
        }
    }
}