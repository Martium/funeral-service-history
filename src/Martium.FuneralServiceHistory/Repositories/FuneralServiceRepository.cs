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

        public bool CreateNewFuneralService(FuneralServiceModel newService)
        {
            using (var dbConnection = new SQLiteConnection(AppConfiguration.ConnectionString))
            {
                dbConnection.Open();

                string createNewFuneralServiceCommand =
                    @"INSERT INTO 'FuneralServiceHistory' 
	                    VALUES (NULL, @OrderDate , @CustomerNames , @CustomerPhoneNumbers , @CustomerEmails , @CustomerAddresses , @ServiceDates , @ServicePlaces , @ServiceTypes , 
                                @ServiceDuration , @ServiceMusiciansCount , @ServiceMusicProgram, @DepartedInfo , @DepartedConfession , @DepartedRemainsType , @ServiceMusicianUnitPrices , 
                                @ServiceDiscountPercentage , @ServicePaymentAmount , @ServicePaymentType , @ServiceDescription);";

                object queryParameters = new
                {
                    newService.OrderDate, newService.CustomerNames, newService.CustomerPhoneNumbers, newService.CustomerEmails, newService.CustomerAddresses, 
                    newService.ServiceDates, newService.ServicePlaces, newService.ServiceTypes, newService.ServiceDuration, newService.ServiceMusiciansCount, 
                    newService.ServiceMusicProgram, newService.DepartedInfo, newService.DepartedConfession, newService.DepartedRemainsType, newService.ServiceMusicianUnitPrices, 
                    newService.ServiceDiscountPercentage, newService.ServicePaymentAmount, newService.ServicePaymentType, newService.ServiceDescription
                };

                int affectedRows = dbConnection.Execute(createNewFuneralServiceCommand, queryParameters);

                return affectedRows == 1;
            }
        }
    }
}
