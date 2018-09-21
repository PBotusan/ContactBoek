using ContactBook.UWP.Persistence;
using SQLite;
using System.IO;
using Windows.Storage;
using Xamarin.Forms;
using ContactBook.Persistence;

[assembly: Dependency(typeof(SQLiteDb))]

namespace ContactBook.UWP.Persistence
{
    public class SQLiteDb : ISQLiteDb
    {
        public SQLiteAsyncConnection GetConnection()
        {
            var documentsPath = ApplicationData.Current.LocalFolder.Path;
            var path = Path.Combine(documentsPath, "MySQLite.db3");
            return new SQLiteAsyncConnection(path);
        }
    }
}
