using System;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Threading;
using ContactManager.Aspects;

namespace ContactManager.Entities
{
    [Tagable]
    public abstract class Entity
    {
      private static string connectionString;
      private static DbProviderFactory dbProviderFactory;

      static Entity()
        {
            IsDesignTime = true;
        }

      public static bool IsDesignTime { get; set; }


      public int Id { get; protected set; }

        public bool IsNew
        {
            get { return Id == 0; }
        }

        public bool IsDeleted { get; private set; }

      public static void Initialize()
      {
        ConnectionStringSettings connectionStringSettings =
          ConfigurationManager.ConnectionStrings[
            "ContactManager.Properties.Settings.ContactManagerConnectionString"];

        dbProviderFactory = DbProviderFactories.GetFactory(connectionStringSettings.ProviderName);
        connectionString = connectionStringSettings.ConnectionString;

        IsDesignTime = false;
      }

      protected static DbConnection GetConnection()
        {
            DbConnection connection = dbProviderFactory.CreateConnection();
            connection.ConnectionString = connectionString;
            connection.Open();
            return connection;
        }

        public void Save()
        {
            Thread.Sleep(1000);

            using (DbConnection connection = GetConnection())
            {
                if (IsNew)
                {
                    Id = Insert(connection);
                }
                else
                {
                    Update(connection);
                }
            }
        }

        public void Delete()
        {
            if (!IsNew)
            {
                Thread.Sleep(1000);

                using (DbConnection connection = GetConnection())
                {
                    Delete(connection);
                }
            }

            IsDeleted = true;
        }

        protected abstract void Delete(DbConnection connection);

        protected abstract void Update(DbConnection connection);

        protected abstract int Insert(DbConnection connection);

        protected static int? ToInt32(object value)
        {
            if (Convert.IsDBNull(value))
                return null;
            else return Convert.ToInt32(value);
        }

        protected static string ToString(object value)
        {
            return Convert.ToString(value);
        }

        public static void Repopulate()
        {
            using (DbConnection connection = GetConnection())
            {
                DbCommand command;

                command = connection.CreateCommand();
                command.CommandText = "DELETE FROM Contacts";
                command.ExecuteNonQuery();

                command = connection.CreateCommand();
                command.CommandText = "DELETE FROM Countries";
                command.ExecuteNonQuery();

                command = connection.CreateCommand();
                command.CommandText = "INSERT INTO Countries ( Name ) VALUES ( @Name )";
                DbParameter nameParam = command.AddParameter("Name", DbType.String, null);

                foreach (string country in Populate.GetCountries())
                {
                    nameParam.Value = country;
                    command.ExecuteNonQuery();
                }

                DbCommand command2 = connection.CreateCommand();
                command2.CommandText = "INSERT INTO Contacts ( FirstName, LastName ) VALUES ( @FirstName, @LastName )";
                DbParameter firstNameParam = command2.AddParameter("FirstName", DbType.String, null);
                DbParameter lastNameParam = command2.AddParameter("LastName", DbType.String, null);

                foreach (string contact in Populate.GetContacts())
                {
                    string[] parts = contact.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                    firstNameParam.Value = parts[0];
                    lastNameParam.Value = parts[1];
                    command2.ExecuteNonQuery();
                }
            }
        }
    }
}