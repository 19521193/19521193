using SQLite;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace App_do_an.Models
{
    public class LKDatabase
    {
        private readonly SQLiteConnection db;
        //string folder = Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
        /* public bool CreateDatabase()
         {
             try
             {
                 string path = System.IO.Path.Combine(folder, "LichKham.db");
                 var connection = new SQLiteConnection(path);
                 connection.CreateTable<Khoa>();
                 connection.CreateTable<LichKham>();

                 return true;
             }
             catch
             {
                 return false;
             }
         }
         public bool AddnewCity(LichKham lichkham)
         {
             try
             {
                 string path = System.IO.Path.Combine(folder, "LichKham.db");
                 var connection = new SQLiteConnection(path);
                 connection.Insert(lichkham);

                 return true;
             }
             catch
             {
                 return false;
             }
         }
         public List<LichKham> GetCities(Khoa khoa)
         {
             try
             {
                 string path = System.IO.Path.Combine(folder, "LichKham.db");
                 var connection = new SQLiteConnection(path);
                 List<LichKham> list = new List<LichKham>();
                 foreach (LichKham l in connection.Table<LichKham>().ToList())
                 {
                     if (khoa.id_Khoa == l.id_khoa)
                     {
                         list.Add(l);
                     }
                 };
                 return list;


                 // return connection.Table<LichKham>().ToList();
             }
             catch
             {
                 return null;
             }

         }

         public bool DeleteCity(LichKham lichkham)
         {
             try
             {
                 string path = System.IO.Path.Combine(folder, "LichKham.db");
                 //var connection = new SQLiteConnection(path);
                 connection.Delete(lichkham);

                 return true;
             }
             catch
             {
                 return false;
             }
         }
         public bool UpdateCity(LichKham lichkham)
         {
             try
             {
                 string path = System.IO.Path.Combine(folder, "LichKham.db");
                 var connection = new SQLiteConnection(path);
                 connection.Update(lichkham);

                 return true;
             }
             catch
             {
                 return false;
             }
         }*/
        public LKDatabase()
        {
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            db = new SQLiteConnection(System.IO.Path.Combine(folder, "BookingDatabase.db3"));
            //db.CreateTable<City>();
            db.CreateTable<LichKham>();
        }
        public bool AddnewCity(LichKham lichkham)
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
        public List<LichKham> GetCities(Khoa khoa)
        {
            try
            {
                List<LichKham> list = new List<LichKham>();
                foreach (LichKham l in db.Table<LichKham>().ToList())
                {
                    if (khoa.id_Khoa == l.id_khoa)
                    {
                        list.Add(l);
                    }
                };
                return list;
            }
            catch (SQLiteException ex)
            {
                Debug.WriteLine("Exception: " + ex);
                return null;
                throw;
            }
        }
        public bool UpdateCity(LichKham lichkham)
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
        public bool DeleteCity(LichKham lichkham)
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
