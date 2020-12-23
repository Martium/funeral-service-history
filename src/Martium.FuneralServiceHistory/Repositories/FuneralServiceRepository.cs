using System.Collections.Generic;
using System.Data.SQLite;
using Dapper;
using Martium.FuneralServiceHistory.Models;

namespace Martium.FuneralServiceHistory.Repositories
{
    public class FuneralServiceRepository
    {
        public IEnumerable<FuneralServiceListModel> GetAll()
        {
            using (var dbConnection = new SQLiteConnection(AppConfiguration.ConnectionString))
            {
                dbConnection.Open();

                object queryParameters = new { };

                string getAllWordsQuery =
                    @"SELECT  
                        FSH.ServiceDates, FSH.OrderNumber, FSH.CustomerNames, FSH.CustomerPhoneNumbers, FSH.DepartedInfo
                      FROM FuneralServiceHistory FSH";

                IEnumerable<FuneralServiceListModel> funeralServices =
                    dbConnection.Query<FuneralServiceListModel>(getAllWordsQuery, queryParameters);

                return funeralServices;
            }
        }
    }
}
