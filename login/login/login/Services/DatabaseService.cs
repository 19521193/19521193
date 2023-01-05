using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using login.Model;
using System.IO;
using System.Threading.Tasks;

namespace login.Services
{
    public class DatabaseService
    {
        private SQLiteAsyncConnection _sqLite;
        private const SQLite.SQLiteOpenFlags _flags =
            // open the database in read/write mode
            SQLite.SQLiteOpenFlags.ReadWrite |
            // create the database if it doesn't exist
            SQLite.SQLiteOpenFlags.Create |
            // enable multi-threaded database access
            SQLite.SQLiteOpenFlags.SharedCache;
        public DatabaseService()
        {
            _sqLite = new SQLiteAsyncConnection(
                Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "database.db3"), _flags);
            _sqLite.CreateTableAsync<UserModel>();
        }
        /// <summary>
        /// đăng ký tài khoản
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public async Task<bool> RegisterAccount(UserModel user)
        {
            return await _sqLite.InsertAsync(user) == 1;
        }
        /// <summary>
        /// đăng nhập
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public async Task<UserModel> Login(UserModel user)
        {
            var data = await _sqLite.FindAsync<UserModel>(user.userName);
            if (data != null)
            {
                if (data.paswword == user.paswword)
                {
                    return data;
                }
            }
            return null;
        }
    }
}
