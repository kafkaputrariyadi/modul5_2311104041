using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul5_2311104041
{
    class SimpleDataBase<T>
    {
        private List<T> storedData;      
        private List<DateTime> inputDates; 
        public SimpleDataBase()
        {
            storedData = new List<T>();
            inputDates = new List<DateTime>();
        }

        public void AddNewData(T data)
        {
            storedData.Add(data);
            inputDates.Add(DateTime.UtcNow); 
        }

        public void PrintAllData()
        {
            for (int i = 0; i < storedData.Count; i++)
            {
                Console.WriteLine($"Data ke-{i + 1}: {storedData[i]}, disimpan pada waktu UTC: {inputDates[i]}");
            }
        }
    }

    class Program
    {
        static void Main()
        {
            SimpleDataBase<int> database = new SimpleDataBase<int>();

            database.AddNewData(12);
            database.AddNewData(34);
            database.AddNewData(56);

            Console.WriteLine("\nData dalam SimpleDataBase:");
            database.PrintAllData();
        }
    }
}