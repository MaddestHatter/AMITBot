using Microsoft.Data.Sqlite;
using System.Collections.Generic;

namespace TrtlBotSharp
{
    class Operators
    {
      internal static bool ContainsKey(ulong uid)
      {
        using (SqliteConnection Connection = new SqliteConnection("Data Source=" + TrtlBotSharp.databaseFile))
       {
         Connection.Open();
         SqliteCommand Command = new SqliteCommand("SELECT uid FROM operators WHERE uid = @uid", Connection);
         Command.Parameters.AddWithValue("uid", uid);
         using (SqliteDataReader Reader = Command.ExecuteReader())
         if (Reader.Read()) return true;
         else return false;
       }
     }
   }
}
