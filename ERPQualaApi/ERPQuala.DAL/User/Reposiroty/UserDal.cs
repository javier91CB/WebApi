using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using ERPQuala.Crosscutting.Model.Request;
using ERPQuala.Crosscutting.Model.Response;
using ERPQuala.DAL.BaseDAL;
using Npgsql;

namespace ERPQuala.DAL.User.Reposiroty
{
    public class UserDal : ConnectionDal, IUserDal
    {
        NpgsqlConnection connection = null;

        public Task<UserResponse> AddUser(UserRequest user)
        {

            try
            {
                connection = ConnectionPostgrest();
                command = new NpgsqlCommand();
                command.Connection = connection;
                command.CommandText = $"INSERT INTO \"GandS\".\"sag.user\"(username, password, secondname, firstname, dni, isprovider) " +
                    $"VALUES('{user.userName}', '{user.password}', '{user.secondName}', '{user.firstName}', '{user.dni}', {user.isProvider});";
                var registerResult = new List<object>();

                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                connection.Close();
            }

            return Task.FromResult(new UserResponse
            {
                id = user.id,
                firstName = user.firstName,
                secondName = user.secondName,
                userName = user.secondName
            });
        }

        public Task<UserResponse> GetUserById(UserRequest user)
        {
            try
            {
                connection = ConnectionPostgrest();
                command = new NpgsqlCommand();
                command.Connection = connection;
                command.Transaction = transaction;
                command.CommandText = $"SELECT id, username, password, secondname, firstname, dni, isprovider FROM \"GandS\".\"sag.user\" " +
                    $"where username = '{user.userName}' AND password = '{user.password}';";
                UserResponse registerResult = new UserResponse();

                connection.Open();
                using (IDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        var sch = dr.GetSchemaTable();

                        int orderNameUser = dr.GetOrdinal("username");
                        int orderPassword = dr.GetOrdinal("password");
                        int orderSecondName = dr.GetOrdinal("secondname");
                        int orderFirstName = dr.GetOrdinal("firstname");
                        int orderDni = dr.GetOrdinal("dni");
                        int orderIsProvider = dr.GetOrdinal("isprovider");

                        var nameUser = dr.GetValue(orderNameUser);
                        var password = dr.GetValue(orderPassword);
                        var secondName = dr.GetValue(orderSecondName);
                        var firstName = dr.GetValue(orderFirstName);
                        var dni = dr.GetValue(orderDni);
                        var isProvider = dr.GetValue(orderIsProvider);

                        registerResult = new UserResponse
                        {
                            firstName = (string)firstName,
                            secondName = (string)secondName,
                            userName = (string)nameUser
                        };
                    }
                    return Task.FromResult(registerResult);
                }
            }
            catch (Exception ex)
            {
                return Task.FromResult(new UserResponse());
            }
            finally
            {
                connection.Close();
            }
        }

    }
}
