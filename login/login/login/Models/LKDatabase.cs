using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace App_do_an.Models
{
    public class LKDatabase
    {
        private readonly SQLiteConnection db;

        public LKDatabase()
        {
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            db = new SQLiteConnection(System.IO.Path.Combine(folder, "LKDatabase.db3"));
            db.CreateTable<LichKham>();
        }

        //LichKham

        public bool CreateLichKham(LichKham lichkham)
        {
            try
            {
                db.Insert(lichkham);
                return true;

            }
            catch (SQLiteException ex)
            {
                Debug.WriteLine("Exception: " + ex);
                return false;
                throw;
            }
        }

        public List<LichKham>ReadLichKham()
        {
            try
            {
                return db.Table<LichKham>().ToList();
            }
            catch (SQLiteException ex)
            {
                Debug.WriteLine("Exception: " + ex);
                return null;
                throw;
            }
        }

        public bool UpdateLichKham(LichKham lichkham)
        {
            try
            {
                db.Update(lichkham);
                return true;

            }
            catch (SQLiteException ex)
            {
                Debug.WriteLine("Exception: " + ex);
                return false;
                throw;
            }
        }
        public bool DeleteLichKham(LichKham lichkham)
        {
            try
            {
                db.Delete(lichkham);
                return true;

            }
            catch (SQLiteException ex)
            {
                Debug.WriteLine("Exception: " + ex);
                return false;
                throw;
            }
        }
    }
}
