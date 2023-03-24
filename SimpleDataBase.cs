using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mod5_1302213026
{
    internal class SimpleDataBase<T>
    {
        private List<T> storeData;
        private List<DateTime> inputDates;
        public SimpleDataBase() {
           this.storeData = new List<T>();
            this.inputDates = new List<DateTime>(); 
        }
        public void AddNewData(T addnewdata) { 
            this.storeData.Add(addnewdata);
            this.inputDates.Add(DateTime.Now);

        }

        public void PrintAllData() { 
            for(int i = 0; i<this.storeData.Count; i++)
            {
                Console.WriteLine("Data "+ i +" berisi: "+ storeData[i]+" , yang disimpan pada waktu "+ inputDates[i]);
            }
        }
    }
}
