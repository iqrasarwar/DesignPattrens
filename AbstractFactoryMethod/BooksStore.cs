using System.Threading;
using System;

namespace SingletonMethod
{
    class BooksStore
    {
        private static BooksStore store;
        public int storeId { get; set; }
        private BooksStore(int id) 
        {
            Console.WriteLine("Constructor called!");
            Thread.Sleep(1000);
            storeId = id;
        }

        public static BooksStore getStore()
        {
            if (store == null)
                store = new BooksStore(1);
            return store;
        }

        //furthre, bookstore functionaities can be implemented here
    }
}
