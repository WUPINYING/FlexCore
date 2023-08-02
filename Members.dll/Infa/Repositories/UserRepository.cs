using Members.dll.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Data.SqlClient;


namespace Members.dll.Infa.Repositories
{
    public class UserRepository
    {
        /// <summary>
        /// 連線字串
        /// </summary>
        private readonly string _connectStr = @"Server=.;Database=Flex;User ID=sa5;Password=sa5;";

        /// <summary>
        /// 新增會員
        /// </summary>
        /// <param name="parameter">參數</param>
        /// <returns></returns>
        public int Create(RegisterDto dto)
        {
            var sql =
            @"
        INSERT INTO Members 
        (
            Account
           ,EncryptedPassword
        ) 
        VALUES 
        (
            @Account
           ,@EncryptedPassword
        );";

            using (var conn = new SqlConnection(_connectStr))
            {
                var result = conn.QueryFirstOrDefault<int>(sql, dto);
                return result;
            }
        }
    }
}
