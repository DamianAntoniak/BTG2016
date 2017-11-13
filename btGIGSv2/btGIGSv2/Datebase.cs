using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btGIGSv2
{
    class Datebase : Config
    {
        private SQLiteConnection conn = new SQLiteConnection();
        private string nameDatebase = "btg.s3db";


        public Datebase() : base()
        {
            SQLiteConnection.CreateFile(Path.Combine(base.GetPathConfig(), nameDatebase));
            conn = new SQLiteConnection(String.Format("Data source={0}", Path.Combine(base.GetPathConfig(), nameDatebase)));
            conn.Open();

            CreateTabels();

            
            if(conn.State == ConnectionState.Open) MessageBox.Show("Polaczono z baza", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("blad", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //conn.Close();
        }

        /*~Datebase()
        {
            if (conn.State == ConnectionState.Open) MessageBox.Show("Polaczone", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("blad1", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            conn.Close();
            if (conn.State == ConnectionState.Open) MessageBox.Show("Polaczone2", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("blad2", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }*/

        private void CreateTabels()
        {
            CreateTable(base.GetTableVideo());
            CreateTable(base.GetTableAudio());
            CreateTable(base.GetTableFirstLng());
            CreateTable(base.GetTableSecondLng());
            CreateTable(base.GetTableThirdLng());
            CreateTable(base.GetTableSubtitle());
            CreateTable(base.GetTableNick());
        }

        private void CreateTable(string table)
        {
            SQLiteCommand command = new SQLiteCommand(table, conn);
            command.ExecuteNonQuery();
        }



    }
}
