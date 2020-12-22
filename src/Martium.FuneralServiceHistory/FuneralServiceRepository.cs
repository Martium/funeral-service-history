using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using Dapper;
using Martium.FuneralServiceHistory.Models;

//using System.Reflection;

namespace Martium.FuneralServiceHistory
{
    public class FuneralServiceRepository
    {
        private readonly string _dbFolder;
        private readonly string _dbFile;
        private readonly string _connectionString;

        public FuneralServiceRepository()
        {
            string databaseName = "FuneralServiceHistory";
            //_dbFolder = $"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}\\Database";
            _dbFolder = "C:\\Development\\Github\\funeral-services-history\\Database";
            _dbFile = $"{_dbFolder}\\{databaseName}.db";
            _connectionString = $"Data Source={_dbFile};Version=3;UseUTF16Encoding=True;";
        }
        
        public IEnumerable<FuneralServiceModel> GetAll()
        {
            using (var dbConnection = new SQLiteConnection(_connectionString))
            {
                dbConnection.Open();

                object queryParameters = new { };

                string getAllWordsQuery =
                    @"SELECT  
                        FSH.ServiceDates, FSH.OrderNumber, FSH.CustomerNames, FSH.CustomerPhoneNumbers, FSH.DepartedInfo
                      FROM FuneralServiceHistory FSH";

                IEnumerable<FuneralServiceModel> funeralServices = dbConnection.Query<FuneralServiceModel>(getAllWordsQuery, queryParameters);

                return funeralServices;
            }
        }

        public void InitializeDatabaseIfNotExist()
        {
            if (File.Exists(_dbFile))
            {
                return;
            }

            if (!Directory.Exists(_dbFolder))
            {
                Directory.CreateDirectory(_dbFolder);
            }
            else
            {
                DeleteLeftoverFilesAndFoldersBeforeDbCreate();
            }

            SQLiteConnection.CreateFile(_dbFile);

            using (var dbConnection = new SQLiteConnection(_connectionString))
            {
                dbConnection.Open();

                CreateFuneralServiceHistoryTable(dbConnection);

                FillDefaultFuneralServices(dbConnection);
            }
        }

        private void DeleteLeftoverFilesAndFoldersBeforeDbCreate()
        {
            var directory = new DirectoryInfo(_dbFolder);

            foreach (FileInfo file in directory.GetFiles())
            {
                file.Delete();
            }

            foreach (DirectoryInfo subdirectory in directory.GetDirectories())
            {
                subdirectory.Delete(true);
            }
        }

        private void CreateFuneralServiceHistoryTable(SQLiteConnection dbConnection)
        {
            string dropFuneralServiceHistoryTableQuery = GetDropTableQuery("FuneralServiceHistory");
            SQLiteCommand dropAFuneralServiceHistoryTableCommand = new SQLiteCommand(dropFuneralServiceHistoryTableQuery, dbConnection);
            dropAFuneralServiceHistoryTableCommand.ExecuteNonQuery();

            const string createFuneralServiceHistoryTableQuery =
                @"                  
                  CREATE TABLE [FuneralServiceHistory] (
                    [OrderNumber] [INTEGER] PRIMARY KEY AUTOINCREMENT,
                    [OrderDate] [Date] NOT NULL,
                    [CustomerNames] [nvarchar](800) NULL,
                    [CustomerPhoneNumbers] [nvarchar](100) NOT NULL,
	                [CustomerEmails] [nvarchar](800) NULL,
	                [CustomerAddresses] [nvarchar](800) NULL,
	                [ServiceDates] [nvarchar](150) NULL,
	                [ServicePlaces] [nvarchar](300) NULL,
	                [ServiceTypes] [nvarchar](300) NULL,
                    [ServiceDuration] [decimal](18, 1) NULL,
                    [ServiceMusiciansCount] [int] NULL,
                    [ServiceMusicProgram] [nvarchar](200) NULL,
                    [DepartedInfo] [nvarchar](810) NULL,
	                [DepartedRemainsType] [nvarchar](50) NULL,
	                [ServiceMusicianUnitPrices] [nvarchar](200) NULL,
	                [ServiceDiscountPercentage] [int] NULL,
	                [ServicePaymentAmount] [decimal](18, 2) NULL,
	                [ServicePaymentCurrencyCode] [nvarchar](3) NULL,
	                [ServicePaymentType] [nvarchar](100) NULL,
	                [ServiceDescription] [nvarchar](1000) NULL,
	                [ServiceReviewScore] [nvarchar](50) NULL,
	                [ServiceReviewComments] [nvarchar](800) NULL
                  );
                ";
            SQLiteCommand createFuneralServiceHistoryTableCommand = new SQLiteCommand(createFuneralServiceHistoryTableQuery, dbConnection);
            createFuneralServiceHistoryTableCommand.ExecuteNonQuery();
        }

        private void FillDefaultFuneralServices(SQLiteConnection dbConnection)
        {
            const string fillFuneralServiceHistoryTableQuery =
                @"BEGIN TRANSACTION;
	                INSERT INTO 'FuneralServiceHistory' 
                           (OrderDate, CustomerPhoneNumbers)
	                VALUES ('2020-12-22 10:09:03', '+37062505181');
                COMMIT;";
            SQLiteCommand fillFuneralServiceHistoryTableCommand = new SQLiteCommand(fillFuneralServiceHistoryTableQuery, dbConnection);
            fillFuneralServiceHistoryTableCommand.ExecuteNonQuery();
        }

        private string GetDropTableQuery(string tableName)
        {
            return $"DROP TABLE IF EXISTS [{tableName}]";
        }
    }
}
