using System;
using System.Linq;
using System.Collections.Generic;
using Ken.Test.Web.Models;

namespace Ken.Test.Web.Respositories
{
    //创建Linq to entity数据访问类
    public class TestRepository
    {
        private TestDbContext DbContext { get; }

        public TestRepository(TestDbContext dbContext)
        {
            //在构造函数中注入DbContext
            this.DbContext = dbContext;
        }

        //添加
        public int Add(UserEntity user)
        {
            using (DbContext)
            {
                DbContext.Users.Add(user);
                return DbContext.SaveChanges();
            }
        }

        public int Delete(int id)
        {
            using (DbContext)
            {
                var userFromContext = DbContext.Users.FirstOrDefault(u => u.ID == id);
                DbContext.Users.Remove(userFromContext);
                return DbContext.SaveChanges();
            }
        }

        public int Update(UserEntity user)
        {
            using (DbContext)
            {
                var userFromContext = DbContext.Users.FirstOrDefault(u => u.ID == user.ID);
                userFromContext.Name = user.Name;
                userFromContext.age = user.age;
                userFromContext.hobby = user.hobby;
                return DbContext.SaveChanges();
            }
        }

        public UserEntity QueryById(int id)
        {
            using (DbContext)
            {
                return DbContext.Users.First(u => u.ID == id);
            }
        }

        public List<UserEntity> QueryByAge(int age)
        {
            return DbContext.Users.Where(u => u.age == age).ToList();
        }

        public List<string> QueryNameByAge(int age)
        {
            using (DbContext)
            {
                return DbContext.Users.Where(u => u.age == age).Select(u => u.Name).ToList();
            }
        }

        public List<UserEntity> QueryUserPaging(int pageSize, int page)
        {
            using (DbContext)
            {
                //skip跳过x个，take取y个
                return DbContext.Users.Skip(pageSize * (page - 1)).Take(pageSize).ToList();
            }
        }

        //事务：将年龄<0的修改为0
        public int FixAge()
        {
            using (DbContext)
            {
                using (var transaction = DbContext.Database.BeginTransaction())
                {
                    try
                    {
                        var userListFromContext = DbContext.Users.Where(u => u.age < 0);
                        foreach (UserEntity u in userListFromContext)
                        {
                            u.age = 0;
                        }
                        var count = DbContext.SaveChanges();
                        transaction.Commit();
                        return count;
                    }
                    catch
                    {
                        transaction.Rollback();
                        return 0;
                    }
                }
            }
        }
    }
}
