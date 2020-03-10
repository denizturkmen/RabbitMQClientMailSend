using System;
using System.Collections.Generic;
using System.Text;
using RabbitMQ.Coree.Entities;

namespace RabbitMQ.Coree.Data
{
    public class UsersDataModel : IDataModel<User>
    {
        public IEnumerable<User> GetData()
        {
            return new List<User>
            {
                new User{UserId=1,FirstName="ddd",LastName="bbbb",Email="turkmen_deniz@hotmail.com"}
                //,new User{UserId=2,FirstName="Barış",LastName="Boy",Email="baris.boy@ericssonmsp.com"}
                //,new User{UserId=3,FirstName="Vacip",LastName="Derici",Email="vacip.derici@ericssonmsp.com"}
                //,new User{UserId=4,FirstName="Talha",LastName="Seçkin",Email="taha.seckin@ericssonmsp.com"}
            };
        }
    }
}
