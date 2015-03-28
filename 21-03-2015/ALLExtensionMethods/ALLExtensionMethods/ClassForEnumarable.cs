using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALLExtensionMethods
{
    public static class ClassForIEnumerable
    {
        public static int countSumOfEnumerableForEvenElements(this IEnumerable<int> listOfElements) //чётные (1)
        {
            int n = 0;

            return countSumOfList(listOfElements, n);
        }

        public static int countSumOfEnumerableForOddElements(this IEnumerable<int> listOfElements) //нечётные (2)
        {
            int n = 1;

            return countSumOfList(listOfElements, n);
        }

        private static int countSumOfList(IEnumerable<int> listOfElements, int start)
        {
            int sum = 0;

            if (listOfElements.Count() == 0)
            {
                throw new ArgumentNullException("listOfElement", "Список пуст!");
            }

            for (int i = start; i < listOfElements.Count(); i += 2)
            {
                sum += listOfElements.ElementAt(i);
            }

            return sum;
        }

        public static IEnumerable<T> returnListInEnumerableForEvenElements<T>(this IEnumerable<T> listOfElements) //(3)
        {
            int n = 0;

            return madeNewList(listOfElements, n);
        }

        public static IEnumerable<T> returnListInEnumerableForOddElements<T>(this IEnumerable<T> listOfElements) //(4)
        {
            int n = 1;

            return madeNewList(listOfElements, n);
        }

        private static IEnumerable<T> madeNewList<T>(IEnumerable<T> listOfElements, int start)
        {
            List<T> list = new List<T>();

            if (listOfElements.Count() == 0)
            {
                throw new ArgumentNullException("listOfElement", "Список пуст!");
            }

            for (int i = 1; i < listOfElements.Count(); i += 2)
            {
                list.Add(listOfElements.ElementAt(i));
            }

            return list;
        }

        public static IEnumerable<T> returnMixEnumerable<T>(this IEnumerable<T> listOfElements) //(5)
        {
            List<T> list = new List<T>();

            for (int i = 0; i < listOfElements.Count() - 1; i += 2)
            {
                list.Add(listOfElements.ElementAt(i + 1));
                list.Add(listOfElements.ElementAt(i));
            }

            return list;
        }
    }
}
