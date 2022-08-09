using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodApp.Services
{
    public class dbServices
    {
        SQLiteAsyncConnection db;
        async Task Init()
        {
            if (db != null)
                return;

            var databasePath = Path.Combine(FileSystem.AppDataDirectory, "Data.db");

            db = new SQLiteAsyncConnection(databasePath);

            await db.CreateTableAsync<UserToken>();
        }

        public async Task AddToken(Dictionary<string, string> keys)
        {
            await Init();
            var Token = new UserToken
            {
                Id = keys["Id"],
                Name = keys["Name"],
                CreationT = keys["CreationT"],
                DryingT = keys["DryingT"],
                Email = keys["Email"],
                Image = keys["Image"],
                AccessToken = keys["AccessToken"],
                RefreshToken = keys["RefreshToken"]

            };

            var id = await db.InsertAsync(Token);
        }
        public async Task AddToken(UserToken userToken)
        {
            await Init();
            var id = await db.InsertAsync(userToken);
        }

        public async Task RemoveToken()
        {
            await Init();
            var user = await db.Table<UserToken>().FirstAsync();
            await db.DeleteAsync<UserToken>(user.Id);
        }

        public async Task<UserToken> GetToken()
        {
            await Init();
            if (await db.Table<UserToken>().CountAsync() != 0)
            {
                UserToken Token = await db.Table<UserToken>().FirstAsync();
                return Token;
            }
            else
            {
                return null;
            }
        }
    }
}
