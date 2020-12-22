using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using Dapper;
using Martium.FuneralServiceHistory.Models;

namespace Martium.FuneralServiceHistory.Repositories
{
    public class DatabaseInitializerRepository
    {
        public void InitializeDatabaseIfNotExist()
        {
            if (File.Exists(AppConfiguration.DatabaseFile))
            {
                return;
            }

            if (!Directory.Exists(AppConfiguration.DatabaseFolder))
            {
                Directory.CreateDirectory(AppConfiguration.DatabaseFolder);
            }
            else
            {
                DeleteLeftoverFilesAndFoldersBeforeDbCreate();
            }

            SQLiteConnection.CreateFile(AppConfiguration.DatabaseFile);

            using (var dbConnection = new SQLiteConnection(AppConfiguration.ConnectionString))
            {
                dbConnection.Open();

                CreateFuneralServiceHistoryTable(dbConnection);

                FillDefaultFuneralServices(dbConnection);
            }
        }

        private void DeleteLeftoverFilesAndFoldersBeforeDbCreate()
        {
            var directory = new DirectoryInfo(AppConfiguration.DatabaseFolder);

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
