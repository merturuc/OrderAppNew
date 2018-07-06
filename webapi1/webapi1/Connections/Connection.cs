using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapi1.Model;

namespace webapi1.Connections
{

    
    public class Connection
    {
        private string ConnectString;
        public Connection()
        {
            ConnectString =@"server=sql7.freemysqlhosting.net;userid=sql7245535;password=jCrl9m78yD;database=sql7245535;sslmode=none";
        }

        public List<User> UserList()
        {
            List<User> allUser = new List<User>();
            using (MySqlConnection myConnectdb = new MySqlConnection(ConnectString)) {

                using (MySqlCommand myCommanddb = myConnectdb.CreateCommand())
                {
                    myCommanddb.CommandText = "Select * from users";
                    myCommanddb.CommandType = System.Data.CommandType.Text;
                    myCommanddb.Connection = myConnectdb;
                    myConnectdb.Open();

                    using (MySqlDataReader myReader = myCommanddb.ExecuteReader())
                    {
                        while (myReader.Read())
                        {
                            allUser.Add(new User {Id =myReader.GetInt32(myReader.GetOrdinal("ID")),
                                Company =myReader.GetString(myReader.GetOrdinal("Company")),
                                Name = myReader.GetString(myReader.GetOrdinal("Name")),
                                Surname = myReader.GetString(myReader.GetOrdinal("Surname")),
                                Email = myReader.GetString(myReader.GetOrdinal("Email")),
                                Officephone =myReader.GetInt32(myReader.GetOrdinal("OfficePhone")),
                                Mobilephone = myReader.GetInt32(myReader.GetOrdinal("MobilePhone")),
                                Faxadress =myReader.GetInt32(myReader.GetOrdinal("Fax")),
                                Address =myReader.GetString(myReader.GetOrdinal("Address")),
                                City =myReader.GetString(myReader.GetOrdinal("City")),
                                Province =myReader.GetString(myReader.GetOrdinal("Province")),
                                Country =myReader.GetString(myReader.GetOrdinal("Country")) });
                        }
                    }
                }
                myConnectdb.Close();
            }
            

                return allUser;
        }
    }
}
