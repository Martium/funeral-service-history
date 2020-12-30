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
                      FROM FuneralServiceHistory FSH
                      ORDER BY FSH.OrderNumber DESC";

                IEnumerable<FuneralServiceListModel> funeralServices =
                    dbConnection.Query<FuneralServiceListModel>(getAllWordsQuery, queryParameters);

                return funeralServices;
            }
        }

        public int GetMaxOrderNumber()
        {
            using (var dbConnection = new SQLiteConnection(AppConfiguration.ConnectionString))
            {
                dbConnection.Open();

                object queryParameters = new { };

                string getAllWordsQuery =
                    @"SELECT  
                        MAX(FSH.OrderNumber)
                      FROM FuneralServiceHistory FSH
                    ";

                int biggestOrderNumber = dbConnection.QuerySingle<int>(getAllWordsQuery, queryParameters);

                return biggestOrderNumber;
            }
        }
    }
}
