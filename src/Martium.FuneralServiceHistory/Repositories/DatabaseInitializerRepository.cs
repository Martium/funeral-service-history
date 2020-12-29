using System.Data.SQLite;
using System.IO;

namespace Martium.FuneralServiceHistory.Repositories
{
    public class DatabaseInitializerRepository
    {
        public void InitializeDatabaseIfNotExist()
        {
            if (File.Exists(AppConfiguration.DatabaseFile))
            {
                // TODO: uncomment return below before real testing
                //return;
            }

            if (!Directory.Exists(AppConfiguration.DatabaseFolder))
            {
                Directory.CreateDirectory(AppConfiguration.DatabaseFolder);
            }
            else
            {
                DeleteLeftoverFilesAndFolders();
            }

            SQLiteConnection.CreateFile(AppConfiguration.DatabaseFile);

            using (var dbConnection = new SQLiteConnection(AppConfiguration.ConnectionString))
            {
                dbConnection.Open();

                CreateFuneralServiceHistoryTable(dbConnection);

                FillDefaultFuneralServices(dbConnection);
            }
        }

        private void DeleteLeftoverFilesAndFolders()
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
                     [ServiceDuration] [nvarchar](50) NULL,
                     [ServiceMusiciansCount] [nvarchar] NULL,
                     [ServiceMusicProgram] [nvarchar](200) NULL,
                     [DepartedInfo] [nvarchar](810) NULL,
                     [DepartedConfession] [nvarchar](100) NULL,
                     [DepartedRemainsType] [nvarchar](50) NULL,
                     [ServiceMusicianUnitPrices] [nvarchar](200) NULL,
                     [ServiceDiscountPercentage] [nvarchar](50) NULL,
                     [ServicePaymentAmount] [nvarchar](200) NULL,
                     [ServicePaymentType] [nvarchar](100) NULL,
                     [ServiceDescription] [nvarchar](1000) NULL
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
		                   (OrderDate, ServiceDates, CustomerNames, CustomerPhoneNumbers, DepartedInfo)
	                VALUES ('2020-05-23 10:09:03', '2020-12-22 10:09:03', 'Martynas Gedutis', '+37064432380', 'Balandis Petras');
	                INSERT INTO 'FuneralServiceHistory' 
		                   (OrderDate, ServiceDates, CustomerNames, CustomerPhoneNumbers, DepartedInfo)
	                VALUES ('2020-06-23 12:09:03', '2020-12-22 10:09:03', 'Erikas Neverdauskas', '+37062505181', 'Katė Smiltė');
	                INSERT INTO 'FuneralServiceHistory' 
		                   (OrderDate, ServiceDates, CustomerNames, CustomerPhoneNumbers, DepartedInfo)
	                VALUES ('2020-12-23 10:09:03', '2020-12-22 10:09:03', 'Erikas Neverdauskas, Martynas Gedutis', '+37062505181, +37064432380', 'Katė Smiltė (2015-2020), Balandis Petras (2019-2020)');
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
