﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Security.Cryptography;

namespace Studrex.Database
{
    static class Database
    {
        private const string conn = "URI=file:Studrex.db";
        public static bool DatabaseExists()
        {
            if (File.Exists("Studrex.db"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void createDatabase()
        {
            SQLiteConnection databaseConnection = new SQLiteConnection(conn);
            databaseConnection.Open();
            SQLiteCommand command = databaseConnection.CreateCommand();
            command.CommandText = "CREATE TABLE IF NOT EXISTS USER(USERNAME VARCHAR(21) PRIMARY KEY, PASSWORD VARCHAR(33) NOT NULL, FIRSTNAME VARCHAR(33) NOT NULL, LASTNAME VARCHAR(77) NOT NULL, ROLE INTEGER NOT NULL)";
            command.ExecuteNonQuery();
            command.CommandText = "CREATE TABLE IF NOT EXISTS STUDENT(ID_NUMBER VARCHAR(7) PRIMARY KEY, NAME VARCHAR(33) NOT NULL, LASTNAME VARCHAR(33) NOT NULL, PROGRAM VARCHAR(33) NOT NULL, LEVEL VARCHAR(33) NOT NULL, YEAR INTEGER NOT NULL, PHOTO BLOB NOT NULL)";
            command.ExecuteNonQuery();
            command.Dispose();
            databaseConnection.Close();
        }

        public static bool UsernameExists(string username)
        {
            SQLiteConnection databaseConnection = new SQLiteConnection(conn);
            databaseConnection.Open();
            SQLiteCommand command = databaseConnection.CreateCommand();
            command.CommandText = "SELECT USERNAME FROM USER;";
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader.GetString(0) == username)
                    return true;
            }
            reader.Close();
            command.Dispose();
            databaseConnection.Close();
            return false;
        }

        public static void AddUser(string username, string password, string firstname, string lastname, int role)
        {
            SQLiteConnection databaseConnection = new SQLiteConnection(conn);
            databaseConnection.Open();
            SQLiteCommand command = databaseConnection.CreateCommand();
            command.CommandText = "INSERT INTO USER VALUES('"+ username + "', '" + Encrypt(password) + "', '" + firstname + "', '" + lastname + "', '" + role + "');";
            command.ExecuteNonQuery();
            command.Dispose();
            databaseConnection.Close();
        }

        public static bool PasswordExists(string username, string password)
        {
            string encryptedPassword = Encrypt(password);
            SQLiteConnection databaseConnection = new SQLiteConnection(conn);
            databaseConnection.Open();
            SQLiteCommand command = databaseConnection.CreateCommand();
            command.CommandText = "SELECT PASSWORD FROM USER WHERE USERNAME = '" + username + "';";
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader.GetString(0) == encryptedPassword)
                    return true;
            }
            reader.Close();
            command.Dispose();
            databaseConnection.Close();
            return false;
        }

        public static string Encrypt(string password)
        {
            string EncryptionKey = "terrathul";
            byte[] clearBytes = Encoding.Unicode.GetBytes(password);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    password = Convert.ToBase64String(ms.ToArray());
                }
            }
            return password;
        }

        public static Classes.User loadUser(string username)
        {
            Classes.User temp = new Classes.User();
            SQLiteConnection databaseConnection = new SQLiteConnection(conn);
            databaseConnection.Open();
            SQLiteCommand command = databaseConnection.CreateCommand();
            command.CommandText = "SELECT username, firstname, lastname, role FROM USER WHERE username = '" + username + "';";
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                temp.setUsername(reader.GetString(0));
                temp.setFirstname(reader.GetString(1));
                temp.setLastname(reader.GetString(2));
                temp.setRole(reader.GetInt32(3));
            }
            reader.Close();
            command.Dispose();
            databaseConnection.Close();
            return temp;
        }
    }
}
