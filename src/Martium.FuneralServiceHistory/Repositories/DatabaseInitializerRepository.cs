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
		                   (OrderDate, CustomerNames, CustomerPhoneNumbers, CustomerEmails, CustomerAddresses, ServiceDates, ServicePlaces, ServiceTypes, ServiceDuration, ServiceMusiciansCount, ServiceMusicProgram,
                            DepartedInfo, DepartedConfession, DepartedRemainsType, ServiceMusicianUnitPrices, ServiceDiscountPercentage, ServicePaymentAmount, ServicePaymentType, ServiceDescription)
	                VALUES ('2020-05-23 10:09:03', 'Bazinga Bombas', '+370645858222', 'bazinga@bazinga.com', 'Kaimuks', '2020-10-10 10:00, 2020-10-11 11:00', 'Kaimuks kaimo g 1', 'muzikavimas laidotuvese', '3h', '2 muzikantai', 'klasikos programa', 'balandis bazinga', 'katalikas', 'karastas', '200 EUR', '50%', '400 EUR', 'Saskaita faktura', 'bla balas basd hasd gasd ahsdb asjdaf ajsdajf asjhas asjdbasf');
	                INSERT INTO 'FuneralServiceHistory'
                            (OrderDate, CustomerNames, CustomerPhoneNumbers, CustomerEmails, CustomerAddresses, ServiceDates, ServicePlaces, ServiceTypes, ServiceDuration, ServiceMusiciansCount, ServiceMusicProgram,
                            DepartedInfo, DepartedConfession, DepartedRemainsType, ServiceMusicianUnitPrices, ServiceDiscountPercentage, ServicePaymentAmount, ServicePaymentType, ServiceDescription)
                    VALUES ('2020-06-23 10:09:03', 'Bazinge Bombe', '+370645858111', 'bazinge@bazinge.com', 'Kaimuks', '2020-10-10 10:00, 2020-10-11 11:00', 'Kaimuks kaimo g 1', 'muzikavimas laidotuvese', '3h', '2 muzikantai', 'klasikos programa', 'balandis bazinga', 'katalikas', 'karastas', '200 EUR', '50%', '400 EUR', 'Saskaita faktura', 'bla balas basd hasd gasd ahsdb asjdaf ajsdajf asjhas asjdbasf');
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
