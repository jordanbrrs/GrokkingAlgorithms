namespace Algorithms
{
    internal class SelectionSort
    {
        public int[] Sort(int[] array)
        {
            int[] newArray = new int[array.Length];
            int indexMinor;
            int indexAppend = 0;
            int length = array.Length;
            for (int i = 0; i < length; i++)
            {
                indexMinor = SearchMinor(array);
                newArray[indexAppend] = array[indexMinor];
                indexAppend++;
                array = RemoveItemByIndex(array, indexMinor);
            }

            return newArray;
        }

        private int[] RemoveItemByIndex(int[] array, int indexMinor)
        {
            int[] newArray = new int[array.Length - 1];
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i != indexMinor)
                {
                    newArray[index] = array[i];
                    index++;
                }
            }
            return newArray;
        }

        private int SearchMinor(int[] array)
        {
            int minor = array[0];
            int index = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < minor)
                {
                    minor = array[i];
                    index = i;
                }
            }
            return index;
        }
    }
}
