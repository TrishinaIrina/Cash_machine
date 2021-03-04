using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tengri.ServiceUser
{
    public class ServiceUser
    {
        private DAL.lightDbEntity db = null;
        //1.регистрация пользователя
        public bool Registration(User user)
        {
            return true;
        }
        //2.наличие пользователя
        public ServiceUser(string connectionString)
        {
            db = new DAL.lightDbEntity(connectionString); // coздать конструктор в классе
        }

        public User IsExist(string login)
        {
            List <User> users = db.GetCollection<User>();
            return users
                .Where(w => w.login == login)
                .FirstOrDefault();
        }
        //3.авторизация
        //4.восстановление пароля
        //5.изменение пароля
        //6.блокировка учет записи





    }
}
