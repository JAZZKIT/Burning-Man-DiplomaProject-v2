using BurnTest.Interfaces;
using BurnTest.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BurnTest.Repositories
{
    public class UserRepository : IRepository<User>
    {
        private ApplicationContext db;

        public UserRepository(ApplicationContext context)
        {
            db = context;
        }

        public void Create(User item)
        {
            db.Users.Add(item);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> Find(Func<User, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public User Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAll()
        {
            return db.Users;
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void Update(User item)
        {
            db.Entry(item).State = EntityState.Modified;
        }
    }
}
