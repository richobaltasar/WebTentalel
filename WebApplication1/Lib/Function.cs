using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Reflection;
using System.Threading.Tasks;
using WebTentakel.Models;

namespace WebTentakel.Lib
{
    public class Function
    {
        public SqlConnection conn = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();

        public async Task<List<ServicesData>> GetDataServices()
        {
            var res = new List<ServicesData>();
            try
            {
                conn.ConnectionString = General.Configuration.ToString();
                using (var connection = conn)
                {
                    connection.Open();
                    string sql = "exec SP_GetDataServices";
                    using (var command = new SqlCommand(sql, connection))
                    {
                        command.CommandTimeout = 0;
                        using (var reader = await command.ExecuteReaderAsync())
                        {
                            while (reader.Read())
                            {
                                var d = new ServicesData();
                                Type type = d.GetType();
                                PropertyInfo[] props = type.GetProperties();
                                foreach (var p in props)
                                {
                                    if (null != p && p.CanWrite)
                                    {
                                        if (p.PropertyType.Name.ToString() != "IFormFile" && p.Name != "Result")
                                        {
                                            p.SetValue(d, reader[p.Name].ToString(), null);
                                        }
                                    }
                                }
                                res.Add(d);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return res;
        }
        public async Task<List<ContentSliderData>> GetDataSliderBanner(string Page)
        {
            var res = new List<ContentSliderData>();
            try
            {
                conn.ConnectionString = General.Configuration.ToString();
                using (var connection = conn)
                {
                    connection.Open();
                    string sql = "exec SP_GetDataSliderBanner @Page='" + Page + "'";
                    using (var command = new SqlCommand(sql, connection))
                    {
                        command.CommandTimeout = 0;
                        using (var reader = await command.ExecuteReaderAsync())
                        {
                            while (reader.Read())
                            {
                                var d = new ContentSliderData();
                                Type type = d.GetType();
                                PropertyInfo[] props = type.GetProperties();
                                foreach (var p in props)
                                {
                                    if (null != p && p.CanWrite)
                                    {
                                        if (p.PropertyType.Name.ToString() != "IFormFile" && p.Name != "Result")
                                        {
                                            p.SetValue(d, reader[p.Name].ToString(), null);
                                        }
                                    }
                                }
                                res.Add(d);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return res;
        }

        #region HomeBanner
        public async Task<List<HomeBannerData>> GetDataHomeBanner()
        {
            var res = new List<HomeBannerData>();
            try
            {
                conn.ConnectionString = General.Configuration.ToString();
                using (var connection = conn)
                {
                    connection.Open();
                    string sql = "exec SP_GetDataHomeBanner";
                    using (var command = new SqlCommand(sql, connection))
                    {
                        command.CommandTimeout = 0;
                        using (var reader = await command.ExecuteReaderAsync())
                        {
                            while (reader.Read())
                            {
                                var d = new HomeBannerData();
                                Type type = d.GetType();
                                PropertyInfo[] props = type.GetProperties();
                                foreach (var p in props)
                                {
                                    if (null != p && p.CanWrite)
                                    {
                                        if (p.PropertyType.Name.ToString() != "IFormFile" && p.Name != "Result")
                                        {
                                            p.SetValue(d, reader[p.Name].ToString(), null);
                                        }
                                    }
                                }
                                res.Add(d);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return res;
        }
        #endregion

    }
}
