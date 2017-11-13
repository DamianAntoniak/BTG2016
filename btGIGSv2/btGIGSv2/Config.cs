using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btGIGSv2
{
    class Config
    {
        private string specialFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        private string myFolder = "//BTGIGS";

        #region TABELS_DB
        private string tableVideo = "CREATE TABLE [video] ([id] INTEGER  NOT NULL PRIMARY KEY AUTOINCREMENT,[name] VARCHAR(30)  NOT NULL);";
        private string tableAudio = "CREATE TABLE [audio] ([id] INTEGER  NOT NULL PRIMARY KEY AUTOINCREMENT,[name] VARCHAR(30)  NOT NULL);";
        private string tableFirstLng = "CREATE TABLE [firstlng] ([id] INTEGER  NOT NULL PRIMARY KEY AUTOINCREMENT,[name] VARCHAR(30)  NOT NULL);";
        private string tableSecondLng = "CREATE TABLE [secondlng] ([id] INTEGER  NOT NULL PRIMARY KEY AUTOINCREMENT,[name] VARCHAR(30)  NOT NULL);";
        private string tableThirdLng = "CREATE TABLE [thirdlng] ([id] INTEGER  NOT NULL PRIMARY KEY AUTOINCREMENT,[name] VARCHAR(30)  NOT NULL);";
        private string tableSubtitle = "CREATE TABLE [subtitle] ([id] INTEGER  NOT NULL PRIMARY KEY AUTOINCREMENT,[name] VARCHAR(30)  NOT NULL);";
        private string tableNick = "CREATE TABLE [nick] ([id] INTEGER  NOT NULL PRIMARY KEY AUTOINCREMENT,[name] VARCHAR(30)  NOT NULL);";
        #endregion

        public Config()
        {
            Directory.CreateDirectory(specialFolder + myFolder);
        }

        public string GetPathConfig()
        {
            return specialFolder + myFolder;
        }

        public string GetTableVideo()
        {
            return tableVideo;
        }

        public string GetTableAudio()
        {
            return tableAudio;
        }

        public string GetTableFirstLng()
        {
            return tableFirstLng;
        }

        public string GetTableSecondLng()
        {
            return tableSecondLng;
        }

        public string GetTableThirdLng()
        {
            return tableThirdLng;
        }

        public string GetTableSubtitle()
        {
            return tableSubtitle;
        }

        public string GetTableNick()
        {
            return tableNick;
        }



    }
}
