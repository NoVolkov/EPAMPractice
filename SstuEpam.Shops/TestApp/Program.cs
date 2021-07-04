using SstuEpam.Shops.DAL.Interfaces;
using SstuEpam.Shops.DAL.SqlDAL.ADO;
using SstuEpam.Shops.Entities;
using System;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            User u;//= new User(0,"TEST","","","TEST@mail.ru", "8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918", "ADMIN");
            IUsersDAO dao = new UsersSqlDAO();
            //dao.AddUser(u);
            //dao.RemoveUser("TEST@mail.ru");
            u = dao.SearchUserByEmail("TEST@mail.ru");
            Console.WriteLine(u);
            Console.Read();
        }
    }
}
