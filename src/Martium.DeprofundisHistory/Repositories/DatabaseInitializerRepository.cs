﻿using System;
using System.Data.SQLite;
using System.IO;
using Martium.DeprofundisHistory.Constants;

namespace Martium.DeprofundisHistory.Repositories
{
    public class DatabaseInitializerRepository
    {
        public void InitializeDatabaseIfNotExist()
        {
            if (File.Exists(AppConfiguration.DatabaseFile))
            {
#if DEBUG

#else
                return;
#endif
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

#if DEBUG
                FillDefaultFuneralServices(dbConnection);
#endif

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

            string createFuneralServiceHistoryTableQuery =
                $@"                  
                  CREATE TABLE [FuneralServiceHistory] (
                    [OrderNumber] [INTEGER] NOT NULL,
                    [OrderCreationYear] [INTEGER] NOT NULL,
                    [OrderDate] [Date] NOT NULL,
                    [CustomerNames] [nvarchar]({FormSettings.TextBoxLengths.CustomerNames}) NULL,
                    [CustomerPhoneNumbers] [nvarchar]({FormSettings.TextBoxLengths.CustomerPhoneNumbers}) NOT NULL,
                    [CustomerEmails] [nvarchar]({FormSettings.TextBoxLengths.CustomerEmails}) NULL,
                    [CustomerAddresses] [nvarchar]({FormSettings.TextBoxLengths.CustomerAddresses}) NULL,
                    [ServiceDates] [nvarchar]({FormSettings.TextBoxLengths.ServiceDates}) NULL,
                    [ServicePlaces] [nvarchar]({FormSettings.TextBoxLengths.ServicePlaces}) NULL,
                    [ServiceTypes] [nvarchar]({FormSettings.TextBoxLengths.ServiceTypes}) NULL,
                    [ServiceDuration] [nvarchar]({FormSettings.TextBoxLengths.ServiceDuration}) NULL,
                    [ServiceMusiciansCount] [nvarchar]({FormSettings.TextBoxLengths.ServiceMusiciansCount}) NULL,
                    [ServiceMusicProgram] [nvarchar]({FormSettings.TextBoxLengths.ServiceMusicProgram}) NULL,
                    [DepartedInfo] [nvarchar]({FormSettings.TextBoxLengths.DepartedInfo}) NULL,
                    [DepartedConfession] [nvarchar]({FormSettings.TextBoxLengths.DepartedConfession}) NULL,
                    [DepartedRemainsType] [nvarchar]({FormSettings.TextBoxLengths.DepartedRemainsType}) NULL,
                    [ServiceMusicianUnitPrices] [nvarchar]({FormSettings.TextBoxLengths.ServiceMusicianUnitPrices}) NULL,
                    [ServiceDiscountPercentage] [nvarchar]({FormSettings.TextBoxLengths.ServiceDiscountPercentage}) NULL,
                    [ServicePaymentAmount] [nvarchar]({FormSettings.TextBoxLengths.ServicePaymentAmount}) NULL,
                    [ServicePaymentType] [nvarchar]({FormSettings.TextBoxLengths.ServicePaymentType}) NULL,
                    [ServiceDescription] [nvarchar]({FormSettings.TextBoxLengths.ServiceDescription}) NULL,
                    UNIQUE(OrderNumber, OrderCreationYear)
                  );
                ";
            SQLiteCommand createFuneralServiceHistoryTableCommand = new SQLiteCommand(createFuneralServiceHistoryTableQuery, dbConnection);
            createFuneralServiceHistoryTableCommand.ExecuteNonQuery();
        }

        private void FillDefaultFuneralServices(SQLiteConnection dbConnection)
        {
            string fillFuneralServiceHistoryTableQuery =
                $@"BEGIN TRANSACTION;
	                INSERT INTO 'FuneralServiceHistory' 
	                    VALUES (1, {DateTime.Now.Year}, '2020-05-23 10:09:03', 'Bazinga Bombas', '+370645858222', 'bazinga@bazinga.com', 'Kaimuks', '2020-10-10 10:00, 2020-10-11 11:00', 'Kaimuks kaimo g 1', 'muzikavimas laidotuvese', '3h', '2 muzikantai', 'klasikos programa', 'balandis bazinga', 'katalikas', 'karastas', '200 EUR', '50%', '400 EUR', 'Saskaita faktura', 'bla balas basd hasd gasd ahsdb asjdaf ajsdajf asjhas asjdbasf');
	                INSERT INTO 'FuneralServiceHistory'
                        VALUES (2, {DateTime.Now.Year}, '2020-06-23 10:09:03', 'Bazinge Bombe', '+370645858111', 'bazinge@bazinge.com', 'Kaimuks', '2020-10-10 10:00, 2020-10-11 11:00', 'Kaimuks kaimo g 1', 'muzikavimas laidotuvese', '3h', '2 muzikantai', 'klasikos programa', 'balandis bazinga', 'katalikas', 'karastas', '200 EUR', '50%', '400 EUR', 'Saskaita faktura', 'bla balas basd hasd gasd ahsdb asjdaf ajsdajf asjhas asjdbasf');
                    INSERT INTO 'FuneralServiceHistory' 
	                    VALUES (1, {DateTime.Now.AddYears(-1).Year}, '2020-05-23 10:09:03', 'Bazinga Bombas praitu metu', '+370645858222', 'bazinga@bazinga.com', 'Kaimuks', '2020-10-10 10:00, 2020-10-11 11:00', 'Kaimuks kaimo g 1', 'muzikavimas laidotuvese', '3h', '2 muzikantai', 'klasikos programa', 'balandis bazinga', 'katalikas', 'karastas', '200 EUR', '50%', '400 EUR', 'Saskaita faktura', 'bla balas basd hasd gasd ahsdb asjdaf ajsdajf asjhas asjdbasf');
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
