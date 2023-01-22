using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_7._8
{
    internal class Repository
    {
        private string fileName = "Worker";
        public Worker[] GetAllWorkers()
        {
            using (StreamReader sr = new StreamReader(fileName))
            {
                // здесь происходит чтение из файла
                // и возврат массива считанных экземпляров

                string read = sr.ReadToEnd();//Чтение и запись всех данных                           
                string[] data = read.Split("#");

                Worker[] workers= new Worker[data.Length];

            }
        }

        #region GetWorkerById
        /*public Worker GetWorkerById(int id)
        {
            // происходит чтение из файла, возвращается Worker
            // с запрашиваемым ID    
        }*/
        #endregion

        public void DeleteWorker(int id)
        {
            // считывается файл, находится нужный Worker
            // происходит запись в файл всех Worker,
            // кроме удаляемого
        }

        public void AddWorker(Worker worker)
        {
            // присваиваем worker уникальный ID,
            // дописываем нового worker в файл
        }

        public Worker[] GetWorkersBetweenTwoDates(DateTime dateFrom, DateTime dateTo)
        {
            // здесь происходит чтение из файла
            // фильтрация нужных записей
            // и возврат массива считанных экземпляров
            return Array.Empty<Worker>();
        }
    }
}
