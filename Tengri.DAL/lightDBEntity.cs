using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tengri.DAL
{
    public class lightDbEntity
    {
        private string ConnectionString { get; set; }

        public lightDbEntity(string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
                throw new Exception("Отсутствует строка подключения");
            else ConnectionString = connectionString;
        }

        public List<T> GetCollection<T>()
        {
            using (var db = new LiteDatabase(ConnectionString))
            {
                return db.GetCollection<T>(typeof(T).Name).FindAll().ToList();
            }
        }

        public bool Create<T>(T data, out string message)
        {
            try
            {
                using (var db = new LiteDatabase(ConnectionString))
                {
                    var collection = db.GetCollection<T>(typeof(T).Name);
                    collection.Insert(data);
                }
                message = "success";
                return true;
            }
            
            catch(Exception ex)
            {
                message = ex.Message;
                return false;
            }
            
        }

    }
}
