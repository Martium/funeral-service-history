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

        public FuneralServiceModel GetByOrderNumber(int orderNumber)
        {
            using (var dbConnection = new SQLiteConnection(AppConfiguration.ConnectionString))
            {
                dbConnection.Open();

                string getByOrderNumberQuery =
                    @"SELECT  
                        FSH.OrderDate , FSH.CustomerNames , FSH.CustomerPhoneNumbers , FSH.CustomerEmails , FSH.CustomerAddresses , FSH.ServiceDates , FSH.ServicePlaces , FSH.ServiceTypes , 
                        FSH.ServiceDuration , FSH.ServiceMusiciansCount , FSH.ServiceMusicProgram, FSH.DepartedInfo , FSH.DepartedConfession , FSH.DepartedRemainsType , FSH.ServiceMusicianUnitPrices , 
                        FSH.ServiceDiscountPercentage , FSH.ServicePaymentAmount , FSH.ServicePaymentType , FSH.ServiceDescription
                      FROM FuneralServiceHistory FSH
                      WHERE FSH.OrderNumber = @OrderNumber";

                object queryParameters = new
                {
                   OrderNumber = orderNumber
                };

                FuneralServiceModel funeralService = dbConnection.QuerySingle<FuneralServiceModel>(getByOrderNumberQuery, queryParameters);

                return funeralService;
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
                                @ServiceDiscountPercentage , @ServicePaymentAmount , @ServicePaymentType , @ServiceDescription)";

                object queryParameters = new
                {
                    newService.OrderDate, newService.CustomerNames, newService.CustomerPhoneNumbers,
                    newService.CustomerEmails, newService.CustomerAddresses,
                    newService.ServiceDates, newService.ServicePlaces, newService.ServiceTypes,
                    newService.ServiceDuration, newService.ServiceMusiciansCount,
                    newService.ServiceMusicProgram, newService.DepartedInfo, newService.DepartedConfession,
                    newService.DepartedRemainsType, newService.ServiceMusicianUnitPrices,
                    newService.ServiceDiscountPercentage, newService.ServicePaymentAmount,
                    newService.ServicePaymentType, newService.ServiceDescription
                };

                int affectedRows = dbConnection.Execute(createNewFuneralServiceCommand, queryParameters);

                return affectedRows == 1;
            }
        }

        public bool EditFuneralService(int orderNumber, FuneralServiceModel updatedService)
        {
            using (var dbConnection = new SQLiteConnection(AppConfiguration.ConnectionString))
            {
                dbConnection.Open();

                string createNewFuneralServiceCommand =
                    @"UPDATE 'FuneralServiceHistory' 
	                    SET OrderDate = @OrderDate, CustomerNames = @CustomerNames , CustomerPhoneNumbers = @CustomerPhoneNumbers , CustomerEmails = @CustomerEmails, 
                            CustomerAddresses = @CustomerAddresses, ServiceDates = @ServiceDates, ServicePlaces = @ServicePlaces, ServiceTypes = @ServiceTypes, 
                            ServiceDuration = @ServiceDuration, ServiceMusiciansCount = @ServiceMusiciansCount, ServiceMusicProgram = @ServiceMusicProgram, 
                            DepartedInfo = @DepartedInfo, DepartedConfession = @DepartedConfession, DepartedRemainsType = @DepartedRemainsType, 
                            ServiceMusicianUnitPrices = @ServiceMusicianUnitPrices, ServiceDiscountPercentage = @ServiceDiscountPercentage,
                            ServicePaymentAmount = @ServicePaymentAmount, ServicePaymentType = @ServicePaymentType, ServiceDescription = @ServiceDescription
                     WHERE OrderNumber = @OrderNumber";

                object queryParameters = new
                {
                    OrderNumber = orderNumber,
                    updatedService.OrderDate,
                    updatedService.CustomerNames,
                    updatedService.CustomerPhoneNumbers,
                    updatedService.CustomerEmails,
                    updatedService.CustomerAddresses,
                    updatedService.ServiceDates,
                    updatedService.ServicePlaces,
                    updatedService.ServiceTypes,
                    updatedService.ServiceDuration,
                    updatedService.ServiceMusiciansCount,
                    updatedService.ServiceMusicProgram,
                    updatedService.DepartedInfo,
                    updatedService.DepartedConfession,
                    updatedService.DepartedRemainsType,
                    updatedService.ServiceMusicianUnitPrices,
                    updatedService.ServiceDiscountPercentage,
                    updatedService.ServicePaymentAmount,
                    updatedService.ServicePaymentType,
                    updatedService.ServiceDescription
                };

                int affectedRows = dbConnection.Execute(createNewFuneralServiceCommand, queryParameters);

                return affectedRows == 1;
            }
        }
    }
}
